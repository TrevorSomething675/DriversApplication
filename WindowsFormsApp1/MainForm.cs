using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DriversApplication
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class MainForm : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public MainForm()
        {
            InitializeComponent();
        }
        private void CreateCol()
        {
            DataGrid_Добавить.Columns.Add("id","id");
            DataGrid_Добавить.Columns.Add("First_Name", "Имя");
            DataGrid_Добавить.Columns.Add("Middle_Name", "Фамилия");
            DataGrid_Добавить.Columns.Add("Last_Name", "Отчество");
            DataGrid_Добавить.Columns.Add("Phone","телефон");
            DataGrid_Добавить.Columns.Add("Car_Number","Номер машины");
            DataGrid_Добавить.Columns.Add("Car_Name","Название машины");
            DataGrid_Добавить.Columns.Add("Max_Speed","Максимальная скорость");
            DataGrid_Добавить.Columns.Add("NewString", String.Empty);
        }
        private void ReadSingleRow(DataGridView dataGridView, IDataRecord dataRecord)
        {
            dataGridView.Rows.Add(
            dataRecord.GetInt32(0), dataRecord.GetString(1), dataRecord.GetString(2), dataRecord.GetString(3), dataRecord.GetValue(4),
            dataRecord.GetString(5), dataRecord.GetString(6), dataRecord.GetInt32(7), RowState.ModifiedNew);
        }
        private void ResetData(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM Drivers", dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read()) 
            {
                ReadSingleRow(dataGridView, dataReader);
            };
            dataReader.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateCol();
            ResetData(DataGrid_Добавить);
        }
        private void AddToBD_Click(object sender, EventArgs e)
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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("После заполнения всех полей, нажав кнопку 'Добавить в базу данных'" +
                " ваш объект и его данные будут добавлены в последнюю строку" +
                ". Поля помеченные как 'Имя' 'Фамилия' необходимо обязательно зполнить. " +
                "\nКнопка 'Удалить из базы данных' удаляет пользователя, для этого необходимо ввести его данные " +
                "и выполнить удаление.", "Помощь с добавлением и удалением");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для поиска по базе данных, нужно ввести инструкцию на языке SQL и нажать кнопку 'Выполнить поиск по базе данных'. Например: SELECT * FROM Drivers");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Deleter();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void Deleter()
        {
            int index = DataGrid_Добавить.CurrentCell.RowIndex;
            DataGrid_Добавить.Rows[index].Visible = false;
            if (DataGrid_Добавить.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                DataGrid_Добавить.Rows[index].Cells[8].Value = RowState.Deleted;
                return;
            }
            DataGrid_Добавить.Rows[index].Cells[8].Value = RowState.Deleted;
        }
        private void Update()
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(DataGrid_Добавить);
        }
        private void Search(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            string ViewSearchString = NameFilter.Text.Replace(" ","");
            string NotViewSearchString = $"SELECT * FROM Drivers WHERE concat(First_Name, Middle_Name, Last_Name, Car_Number, Car_Name) LIKE N'%{ViewSearchString}%'";
            SqlCommand sqlCom = new SqlCommand(NotViewSearchString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = sqlCom.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }
            reader.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            ResetData(DataGrid_Добавить);
        }
        private void Redakt()
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
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Redakt();
        }

        private void DataGrid_Добавить_CellClick(object sender, DataGridViewCellEventArgs dataGridViewArgs)
        {
            selectedRow = dataGridViewArgs.RowIndex;
            if (dataGridViewArgs.RowIndex >= 0)
            {
                DataGridViewRow row = DataGrid_Добавить.Rows[selectedRow];
                IdName.Text = row.Cells[0].Value.ToString();
                NameText.Text = row.Cells[1].Value.ToString();
                FamiliaText.Text = row.Cells[2].Value.ToString();
                OtchestoText.Text = row.Cells[3].Value.ToString();
                PhoneText.Text = row.Cells[4].Value.ToString();
                CarNumber.Text = row.Cells[5].Value.ToString();
                CarName.Text = row.Cells[6].Value.ToString();
                MaxSpdText.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
