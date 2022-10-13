
namespace DriversApplication
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.AddToBD = new System.Windows.Forms.Button();
            this.RedactData = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.NameFilter = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HelperMain = new System.Windows.Forms.Button();
            this.DeleteDBnonid = new System.Windows.Forms.Button();
            this.SaveDB = new System.Windows.Forms.Button();
            this.SearchOnPar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DataGrid_Добавить = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MaxSpdText = new System.Windows.Forms.TextBox();
            this.CarName = new System.Windows.Forms.TextBox();
            this.CarNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.OtchestoText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FamiliaText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.IdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Добавить)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.NameFilter);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1058, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Взаимодействие с базой данных";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel3);
            this.groupBox8.Location = new System.Drawing.Point(760, 262);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(292, 64);
            this.groupBox8.TabIndex = 21;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Редактирование базы данных";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.AddToBD, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.RedactData, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(286, 45);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // AddToBD
            // 
            this.AddToBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddToBD.Location = new System.Drawing.Point(146, 3);
            this.AddToBD.Name = "AddToBD";
            this.AddToBD.Size = new System.Drawing.Size(137, 39);
            this.AddToBD.TabIndex = 0;
            this.AddToBD.Text = "Добавить в базу данных";
            this.AddToBD.UseVisualStyleBackColor = true;
            this.AddToBD.Click += new System.EventHandler(this.AddToBD_Click);
            // 
            // RedactData
            // 
            this.RedactData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RedactData.Location = new System.Drawing.Point(3, 3);
            this.RedactData.Name = "RedactData";
            this.RedactData.Size = new System.Drawing.Size(137, 39);
            this.RedactData.TabIndex = 19;
            this.RedactData.Text = "Редактировать данные";
            this.RedactData.UseVisualStyleBackColor = true;
            this.RedactData.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Поиск по ФИО";
            // 
            // NameFilter
            // 
            this.NameFilter.Location = new System.Drawing.Point(98, 6);
            this.NameFilter.Multiline = true;
            this.NameFilter.Name = "NameFilter";
            this.NameFilter.Size = new System.Drawing.Size(652, 23);
            this.NameFilter.TabIndex = 18;
            this.NameFilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel1);
            this.groupBox7.Location = new System.Drawing.Point(759, 332);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(293, 116);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Поиск и удаление из базы данных";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.HelperMain, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DeleteDBnonid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SaveDB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchOnPar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 97);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // HelperMain
            // 
            this.HelperMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelperMain.Location = new System.Drawing.Point(146, 51);
            this.HelperMain.Name = "HelperMain";
            this.HelperMain.Size = new System.Drawing.Size(138, 43);
            this.HelperMain.TabIndex = 15;
            this.HelperMain.Text = "Быстрая помощь по заполнению и удалению";
            this.HelperMain.UseVisualStyleBackColor = true;
            this.HelperMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteDBnonid
            // 
            this.DeleteDBnonid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteDBnonid.Location = new System.Drawing.Point(3, 51);
            this.DeleteDBnonid.Name = "DeleteDBnonid";
            this.DeleteDBnonid.Size = new System.Drawing.Size(137, 43);
            this.DeleteDBnonid.TabIndex = 18;
            this.DeleteDBnonid.Text = "Удалить из базы данных";
            this.DeleteDBnonid.UseVisualStyleBackColor = true;
            this.DeleteDBnonid.Click += new System.EventHandler(this.button4_Click);
            // 
            // SaveDB
            // 
            this.SaveDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveDB.Location = new System.Drawing.Point(146, 3);
            this.SaveDB.Name = "SaveDB";
            this.SaveDB.Size = new System.Drawing.Size(138, 42);
            this.SaveDB.TabIndex = 20;
            this.SaveDB.Text = "Сохранить изменения";
            this.SaveDB.UseVisualStyleBackColor = true;
            this.SaveDB.Click += new System.EventHandler(this.button6_Click);
            // 
            // SearchOnPar
            // 
            this.SearchOnPar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchOnPar.Location = new System.Drawing.Point(3, 3);
            this.SearchOnPar.Name = "SearchOnPar";
            this.SearchOnPar.Size = new System.Drawing.Size(137, 42);
            this.SearchOnPar.TabIndex = 23;
            this.SearchOnPar.Text = "Обновить базу данных";
            this.SearchOnPar.UseVisualStyleBackColor = true;
            this.SearchOnPar.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DataGrid_Добавить);
            this.groupBox4.Location = new System.Drawing.Point(3, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(750, 414);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поля из базы данных";
            // 
            // DataGrid_Добавить
            // 
            this.DataGrid_Добавить.AllowUserToAddRows = false;
            this.DataGrid_Добавить.AllowUserToDeleteRows = false;
            this.DataGrid_Добавить.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Добавить.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_Добавить.Location = new System.Drawing.Point(3, 16);
            this.DataGrid_Добавить.Name = "DataGrid_Добавить";
            this.DataGrid_Добавить.ReadOnly = true;
            this.DataGrid_Добавить.Size = new System.Drawing.Size(744, 395);
            this.DataGrid_Добавить.TabIndex = 1;
            this.DataGrid_Добавить.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Добавить_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(759, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 253);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.MaxSpdText, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.CarName, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.CarNumber, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.PhoneText, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.OtchestoText, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.FamiliaText, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.NameText, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.IdName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(287, 234);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // MaxSpdText
            // 
            this.MaxSpdText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaxSpdText.Location = new System.Drawing.Point(146, 206);
            this.MaxSpdText.Name = "MaxSpdText";
            this.MaxSpdText.Size = new System.Drawing.Size(138, 20);
            this.MaxSpdText.TabIndex = 16;
            // 
            // CarName
            // 
            this.CarName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarName.Location = new System.Drawing.Point(146, 177);
            this.CarName.Name = "CarName";
            this.CarName.Size = new System.Drawing.Size(138, 20);
            this.CarName.TabIndex = 6;
            // 
            // CarNumber
            // 
            this.CarNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarNumber.Location = new System.Drawing.Point(146, 148);
            this.CarNumber.Name = "CarNumber";
            this.CarNumber.Size = new System.Drawing.Size(138, 20);
            this.CarNumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Название машины";
            // 
            // PhoneText
            // 
            this.PhoneText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneText.Location = new System.Drawing.Point(146, 119);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(138, 20);
            this.PhoneText.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 31);
            this.label8.TabIndex = 17;
            this.label8.Text = "Максимальная скорость";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "ID водителя (Вводить только при удалении)";
            // 
            // OtchestoText
            // 
            this.OtchestoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OtchestoText.Location = new System.Drawing.Point(146, 90);
            this.OtchestoText.Name = "OtchestoText";
            this.OtchestoText.Size = new System.Drawing.Size(138, 20);
            this.OtchestoText.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Номер машины";
            // 
            // FamiliaText
            // 
            this.FamiliaText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FamiliaText.Location = new System.Drawing.Point(146, 61);
            this.FamiliaText.Name = "FamiliaText";
            this.FamiliaText.Size = new System.Drawing.Size(138, 20);
            this.FamiliaText.TabIndex = 3;
            // 
            // NameText
            // 
            this.NameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameText.Location = new System.Drawing.Point(146, 32);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(138, 20);
            this.NameText.TabIndex = 2;
            // 
            // IdName
            // 
            this.IdName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdName.Location = new System.Drawing.Point(146, 3);
            this.IdName.Name = "IdName";
            this.IdName.Size = new System.Drawing.Size(138, 20);
            this.IdName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Номер телефона";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 483);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Добавить)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NameFilter;
        private System.Windows.Forms.Button RedactData;
        private System.Windows.Forms.DataGridView DataGrid_Добавить;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IdName;
        private System.Windows.Forms.Button DeleteDBnonid;
        private System.Windows.Forms.Button SaveDB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CarName;
        private System.Windows.Forms.TextBox MaxSpdText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddToBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HelperMain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FamiliaText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OtchestoText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.TextBox CarNumber;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button SearchOnPar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

