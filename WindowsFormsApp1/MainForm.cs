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
        private void CreateCol() //Заполнение datagridview главными полями
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
        private void ReadSingleRow(DataGridView dataGridView, IDataRecord dataRecord) //Добавление объектов в datagridview
        {
            dataGridView.Rows.Add(
            dataRecord.GetInt32(0),
            dataRecord.GetString(1), 
            dataRecord.GetString(2), 
            dataRecord.GetString(3), 
            dataRecord.GetValue(4),
            dataRecord.GetString(5), 
            dataRecord.GetString(6), 
            dataRecord.GetInt32(7),
            RowState.ModifiedNew);
        }
        private void ResetData(DataGridView dataGridView) //Обновление данных 
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
        private void DataGrid_Добавить_CellClick(object sender, DataGridViewCellEventArgs dataGridViewArgs) //событие отвечающее за сортировку
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
        private void button7_Click(object sender, EventArgs e)
        {
            ResetData(DataGrid_Добавить);
        }
        private void HelperMain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("После заполнения всех полей, нажав кнопку 'Добавить в базу данных'" +
                " ваш объект и его данные будут добавлены в последнюю строку" +
                ". Поля помеченные как 'Имя' 'Фамилия' необходимо обязательно зполнить. " +
                "\nКнопка 'Удалить из базы данных' удаляет пользователя, для этого необходимо ввести его данные " +
                "и выполнить удаление.", "Помощь с добавлением и удалением");
        }
        private void AddToBD_Click(object sender, EventArgs e)//добавление объекта в базу данных
        {
            Create();
        }

        private void DeleteDBnonid_Click(object sender, EventArgs e) //Удаление объекта из базы данных
        {
            Delete();
        }

        private void RedactData_Click(object sender, EventArgs e) //редактирование объетов в базе данных
        {
            Redact();
        }

        private void SaveDB_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(DataGrid_Добавить);
        }
    }
}
