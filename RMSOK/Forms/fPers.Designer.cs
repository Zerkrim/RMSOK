
namespace RMSOK.Forms
{
    partial class fPers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDogovor = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCehName = new System.Windows.Forms.TextBox();
            this.tbIdCeh = new System.Windows.Forms.TextBox();
            this.cbCeha = new System.Windows.Forms.ComboBox();
            this.cehaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rmsokDBDataSet = new RMSOK.RmsokDBDataSet();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbVidZan = new System.Windows.Forms.ComboBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.mtbInn = new System.Windows.Forms.MaskedTextBox();
            this.mtbSnils = new System.Windows.Forms.MaskedTextBox();
            this.mtbPasport = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDolch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOklad = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbStavka = new System.Windows.Forms.TextBox();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lDateTime = new System.Windows.Forms.Label();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.tbBackRow = new System.Windows.Forms.Button();
            this.cbLoadTrach = new System.Windows.Forms.CheckBox();
            this.btnTarif = new System.Windows.Forms.Button();
            this.btnTrach = new System.Windows.Forms.Button();
            this.cehaTableAdapter = new RMSOK.RmsokDBDataSetTableAdapters.CehaTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cehaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmsokDBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDogovor
            // 
            this.btnDogovor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDogovor.Location = new System.Drawing.Point(146, 48);
            this.btnDogovor.Name = "btnDogovor";
            this.btnDogovor.Size = new System.Drawing.Size(90, 31);
            this.btnDogovor.TabIndex = 5;
            this.btnDogovor.Text = "Договор";
            this.btnDogovor.UseVisualStyleBackColor = true;
            this.btnDogovor.Click += new System.EventHandler(this.btnDogovor_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDel.Location = new System.Drawing.Point(6, 83);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(90, 31);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "В корзину";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(6, 48);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 31);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsert.Location = new System.Drawing.Point(6, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 31);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.AllowUserToAddRows = false;
            this.dgvPersonal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonal.Location = new System.Drawing.Point(3, 3);
            this.dgvPersonal.MultiSelect = false;
            this.dgvPersonal.Name = "dgvPersonal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPersonal.RowHeadersVisible = false;
            this.dgvPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonal.Size = new System.Drawing.Size(1020, 298);
            this.dgvPersonal.TabIndex = 0;
            this.dgvPersonal.DoubleClick += new System.EventHandler(this.dgvPersonal_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 483);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvPersonal, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.13646F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.86354F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1026, 483);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.27723F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.72277F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 307);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1020, 173);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCehName);
            this.groupBox1.Controls.Add(this.tbIdCeh);
            this.groupBox1.Controls.Add(this.cbCeha);
            this.groupBox1.Controls.Add(this.cbGender);
            this.groupBox1.Controls.Add(this.cbVidZan);
            this.groupBox1.Controls.Add(this.mtbPhone);
            this.groupBox1.Controls.Add(this.mtbInn);
            this.groupBox1.Controls.Add(this.mtbSnils);
            this.groupBox1.Controls.Add(this.mtbPasport);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbDolch);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbOklad);
            this.groupBox1.Controls.Add(this.tbAdress);
            this.groupBox1.Controls.Add(this.tbStavka);
            this.groupBox1.Controls.Add(this.tbFIO);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tbCehName
            // 
            this.tbCehName.Enabled = false;
            this.tbCehName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCehName.Location = new System.Drawing.Point(619, 32);
            this.tbCehName.Name = "tbCehName";
            this.tbCehName.Size = new System.Drawing.Size(98, 20);
            this.tbCehName.TabIndex = 34;
            this.tbCehName.Visible = false;
            // 
            // tbIdCeh
            // 
            this.tbIdCeh.Enabled = false;
            this.tbIdCeh.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbIdCeh.Location = new System.Drawing.Point(619, 10);
            this.tbIdCeh.Name = "tbIdCeh";
            this.tbIdCeh.Size = new System.Drawing.Size(98, 20);
            this.tbIdCeh.TabIndex = 33;
            // 
            // cbCeha
            // 
            this.cbCeha.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cehaBindingSource, "id_ceh", true));
            this.cbCeha.DataSource = this.cehaBindingSource;
            this.cbCeha.DisplayMember = "naimen";
            this.cbCeha.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCeha.FormattingEnabled = true;
            this.cbCeha.Location = new System.Drawing.Point(120, 107);
            this.cbCeha.Name = "cbCeha";
            this.cbCeha.Size = new System.Drawing.Size(208, 22);
            this.cbCeha.TabIndex = 32;
            this.cbCeha.ValueMember = "id_ceh";
            this.cbCeha.SelectedIndexChanged += new System.EventHandler(this.cbCeha_SelectedIndexChanged);
            // 
            // cehaBindingSource
            // 
            this.cehaBindingSource.DataMember = "Ceha";
            this.cehaBindingSource.DataSource = this.rmsokDBDataSet;
            // 
            // rmsokDBDataSet
            // 
            this.rmsokDBDataSet.DataSetName = "RmsokDBDataSet";
            this.rmsokDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Мужчина",
            "Женщина"});
            this.cbGender.Location = new System.Drawing.Point(455, 140);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(147, 22);
            this.cbGender.TabIndex = 31;
            // 
            // cbVidZan
            // 
            this.cbVidZan.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbVidZan.FormattingEnabled = true;
            this.cbVidZan.Items.AddRange(new object[] {
            "Основное место работы",
            "Дополнительное место работы"});
            this.cbVidZan.Location = new System.Drawing.Point(455, 114);
            this.cbVidZan.Name = "cbVidZan";
            this.cbVidZan.Size = new System.Drawing.Size(147, 22);
            this.cbVidZan.TabIndex = 30;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbPhone.Location = new System.Drawing.Point(455, 62);
            this.mtbPhone.Mask = "+7(000)000-00-00";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(147, 20);
            this.mtbPhone.TabIndex = 29;
            // 
            // mtbInn
            // 
            this.mtbInn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbInn.Location = new System.Drawing.Point(120, 81);
            this.mtbInn.Mask = "000000000000";
            this.mtbInn.Name = "mtbInn";
            this.mtbInn.Size = new System.Drawing.Size(208, 20);
            this.mtbInn.TabIndex = 28;
            // 
            // mtbSnils
            // 
            this.mtbSnils.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbSnils.Location = new System.Drawing.Point(120, 55);
            this.mtbSnils.Mask = "000-000-000 00";
            this.mtbSnils.Name = "mtbSnils";
            this.mtbSnils.Size = new System.Drawing.Size(208, 20);
            this.mtbSnils.TabIndex = 27;
            // 
            // mtbPasport
            // 
            this.mtbPasport.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbPasport.Location = new System.Drawing.Point(120, 32);
            this.mtbPasport.Mask = "0000 000000";
            this.mtbPasport.Name = "mtbPasport";
            this.mtbPasport.Size = new System.Drawing.Size(208, 20);
            this.mtbPasport.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(346, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Пол";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "ИНН";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(346, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Вид занятости";
            // 
            // tbDolch
            // 
            this.tbDolch.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDolch.Location = new System.Drawing.Point(455, 88);
            this.tbDolch.Name = "tbDolch";
            this.tbDolch.Size = new System.Drawing.Size(147, 20);
            this.tbDolch.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(346, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Должность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Подразделение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(346, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Оклад";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(346, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ставка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Адрес проживания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(346, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "СНИЛС";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Серия/Номер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО";
            // 
            // tbOklad
            // 
            this.tbOklad.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOklad.Location = new System.Drawing.Point(455, 36);
            this.tbOklad.Name = "tbOklad";
            this.tbOklad.Size = new System.Drawing.Size(147, 20);
            this.tbOklad.TabIndex = 5;
            // 
            // tbAdress
            // 
            this.tbAdress.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAdress.Location = new System.Drawing.Point(120, 135);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(208, 20);
            this.tbAdress.TabIndex = 4;
            // 
            // tbStavka
            // 
            this.tbStavka.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStavka.Location = new System.Drawing.Point(455, 10);
            this.tbStavka.Name = "tbStavka";
            this.tbStavka.Size = new System.Drawing.Size(147, 20);
            this.tbStavka.TabIndex = 2;
            // 
            // tbFIO
            // 
            this.tbFIO.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFIO.Location = new System.Drawing.Point(120, 9);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(208, 20);
            this.tbFIO.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lDateTime);
            this.groupBox2.Controls.Add(this.btnDeleted);
            this.groupBox2.Controls.Add(this.tbBackRow);
            this.groupBox2.Controls.Add(this.cbLoadTrach);
            this.groupBox2.Controls.Add(this.btnTarif);
            this.groupBox2.Controls.Add(this.btnDogovor);
            this.groupBox2.Controls.Add(this.btnTrach);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(740, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 167);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // lDateTime
            // 
            this.lDateTime.AutoSize = true;
            this.lDateTime.Location = new System.Drawing.Point(125, 138);
            this.lDateTime.Name = "lDateTime";
            this.lDateTime.Size = new System.Drawing.Size(35, 13);
            this.lDateTime.TabIndex = 10;
            this.lDateTime.Text = "label9";
            this.lDateTime.Visible = false;
            // 
            // btnDeleted
            // 
            this.btnDeleted.Enabled = false;
            this.btnDeleted.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleted.Location = new System.Drawing.Point(6, 46);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(116, 31);
            this.btnDeleted.TabIndex = 9;
            this.btnDeleted.Text = "Удалить";
            this.btnDeleted.UseVisualStyleBackColor = true;
            this.btnDeleted.Visible = false;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // tbBackRow
            // 
            this.tbBackRow.Enabled = false;
            this.tbBackRow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBackRow.Location = new System.Drawing.Point(6, 11);
            this.tbBackRow.Name = "tbBackRow";
            this.tbBackRow.Size = new System.Drawing.Size(116, 31);
            this.tbBackRow.TabIndex = 8;
            this.tbBackRow.Text = "Восстановить";
            this.tbBackRow.UseVisualStyleBackColor = true;
            this.tbBackRow.Visible = false;
            this.tbBackRow.Click += new System.EventHandler(this.tbBackRow_Click);
            // 
            // cbLoadTrach
            // 
            this.cbLoadTrach.AutoSize = true;
            this.cbLoadTrach.Enabled = false;
            this.cbLoadTrach.Location = new System.Drawing.Point(6, 135);
            this.cbLoadTrach.Name = "cbLoadTrach";
            this.cbLoadTrach.Size = new System.Drawing.Size(69, 17);
            this.cbLoadTrach.TabIndex = 7;
            this.cbLoadTrach.Text = "Корзина";
            this.cbLoadTrach.UseVisualStyleBackColor = true;
            this.cbLoadTrach.Visible = false;
            this.cbLoadTrach.CheckedChanged += new System.EventHandler(this.cbLoadTrach_CheckedChanged);
            // 
            // btnTarif
            // 
            this.btnTarif.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTarif.Location = new System.Drawing.Point(125, 85);
            this.btnTarif.Name = "btnTarif";
            this.btnTarif.Size = new System.Drawing.Size(131, 31);
            this.btnTarif.TabIndex = 6;
            this.btnTarif.Text = "Тарифная сетка";
            this.btnTarif.UseVisualStyleBackColor = true;
            this.btnTarif.Click += new System.EventHandler(this.btnTarif_Click);
            // 
            // btnTrach
            // 
            this.btnTrach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrach.Location = new System.Drawing.Point(146, 12);
            this.btnTrach.Name = "btnTrach";
            this.btnTrach.Size = new System.Drawing.Size(90, 31);
            this.btnTrach.TabIndex = 4;
            this.btnTrach.Text = "Корзина";
            this.btnTrach.UseVisualStyleBackColor = true;
            this.btnTrach.Click += new System.EventHandler(this.btnTrach_Click);
            // 
            // cehaTableAdapter
            // 
            this.cehaTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fPers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 483);
            this.Controls.Add(this.panel1);
            this.Name = "fPers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "РМСОК: Персонал";
            this.Load += new System.EventHandler(this.fPers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cehaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmsokDBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDogovor;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbDolch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOklad;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbStavka;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTrach;
        private System.Windows.Forms.ComboBox cbCeha;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbVidZan;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.MaskedTextBox mtbInn;
        private System.Windows.Forms.MaskedTextBox mtbSnils;
        private System.Windows.Forms.MaskedTextBox mtbPasport;
        private RmsokDBDataSet rmsokDBDataSet;
        private System.Windows.Forms.BindingSource cehaBindingSource;
        private RmsokDBDataSetTableAdapters.CehaTableAdapter cehaTableAdapter;
        private System.Windows.Forms.Button btnTarif;
        private System.Windows.Forms.TextBox tbIdCeh;
        private System.Windows.Forms.CheckBox cbLoadTrach;
        private System.Windows.Forms.Button tbBackRow;
        private System.Windows.Forms.Button btnDeleted;
        private System.Windows.Forms.Label lDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbCehName;
    }
}