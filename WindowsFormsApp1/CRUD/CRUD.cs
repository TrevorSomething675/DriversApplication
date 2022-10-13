using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DriversApplication
{
    public partial class MainForm
    {
        public void Delete()
        {
            int index = DataGrid_Добавить.CurrentCell.RowIndex;
            DataGrid_Добавить.Rows[index].Visible = false;
            if (DataGrid_Добавить.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                DataGrid_Добавить.Rows[index].Cells[8].Value = RowState.Deleted;
                return;
            }
            DataGrid_Добавить.Rows[index].Cells[8].Value = RowState.Deleted;
        }//метод для удаления данных из базы данных
        public void Update()
        {
            dataBase.openConnection();
            for (int index = 0; index < DataGrid_Добавить.Rows.Count; index++)
            {
                var rowState = (RowState)DataGrid_Добавить.Rows[index].Cells[8].Value;
                if (rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(DataGrid_Добавить.Rows[index].Cells[0].Value);
                    var deleteData = $"DELETE FROM Drivers where id ={id}";
                    var command = new SqlCommand(deleteData, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var id = DataGrid_Добавить.Rows[index].Cells[0].Value.ToString();
                    var fname = DataGrid_Добавить.Rows[index].Cells[1].Value.ToString();
                    var mname = DataGrid_Добавить.Rows[index].Cells[2].Value.ToString();
                    var lname = DataGrid_Добавить.Rows[index].Cells[3].Value.ToString();
                    var phone = DataGrid_Добавить.Rows[index].Cells[4].Value.ToString();
                    var carname = DataGrid_Добавить.Rows[index].Cells[5].Value.ToString();
                    var carnum = DataGrid_Добавить.Rows[index].Cells[6].Value.ToString();
                    var maxspeed = DataGrid_Добавить.Rows[index].Cells[7].Value.ToString();
                    var redaktData =
                        $"update Drivers set First_Name = N'{NameText.Text}', Middle_Name = N'{FamiliaText.Text}', Last_Name = N'{OtchestoText.Text}', Phone = '{PhoneText.Text}', Car_Number = N'{CarNumber.Text}', Car_Name = N'{CarName.Text}', Max_Speed = '{MaxSpdText.Text}' where id = '{IdName.Text}'";
                    var command = new SqlCommand(redaktData, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }//метод для обновления базы данных
        public void Redact()
        {
            var selectedRowIndex = DataGrid_Добавить.CurrentCell.RowIndex;
            var id = IdName.Text;
            var fname = NameText.Text;
            var mname = FamiliaText.Text;
            var lname = OtchestoText.Text;
            var phone = PhoneText.Text;
            var carname = CarName.Text;
            var carnum = CarNumber.Text;
            var maxspeed = MaxSpdText.Text;
            if (NameText.Text != "" && OtchestoText.Text != "" && CarName.Text != "" && CarNumber.Text != "")
            {
                DataGrid_Добавить.Rows[selectedRowIndex].SetValues(id, fname, mname, lname, phone, carnum, carname, maxspeed);
                DataGrid_Добавить.Rows[selectedRowIndex].Cells[8].Value = RowState.Modified;
            }
            else
            {
                MessageBox.Show("Введены неверные данные.");
            }
        }//метод для редактирования базы данных
        public void Create()
        {
            dataBase.openConnection();
            int result;
            if (NameText.Text != "" && OtchestoText.Text != "" && CarName.Text != "" && CarNumber.Text != "")
            {
                try
                {
                    if (int.TryParse(MaxSpdText.Text, out result))
                    {
                        var adder = $"INSERT INTO[Drivers](First_Name," +
                            $" Middle_Name, Last_Name, Phone, Car_Number," +
                            $" Car_Name, Max_Speed) VALUES(N'{NameText.Text}'," +
                            $" N'{FamiliaText.Text}', N'{OtchestoText.Text}', N'{PhoneText.Text}', N'{CarNumber.Text}'," +
                            $" N'{CarName.Text}', N'{MaxSpdText.Text}')";
                        SqlCommand sqlCommand = new SqlCommand(adder, dataBase.getConnection());
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Запись была успешно создана.");
                    }
                }
                catch
                {
                    MessageBox.Show("Максимальная скорость введена неверно");
                }
            }
            else
            {
                MessageBox.Show("Запись не была создана, обязательные поля не заполнены.");
            }
            ResetData(DataGrid_Добавить);
            dataBase.closeConnection();
        }//метод для создания объекта базы данных
    }
}
