
namespace RMSOK.Forms
{
    partial class fTarifSet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idtarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifKofDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifSetkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rmsokDBDataSet = new RMSOK.RmsokDBDataSet();
            this.tarifSetkaTableAdapter = new RMSOK.RmsokDBDataSetTableAdapters.TarifSetkaTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.изменитьСеткуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifSetkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmsokDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 423);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtarifDataGridViewTextBoxColumn,
            this.razradDataGridViewTextBoxColumn,
            this.tarifKofDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tarifSetkaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(345, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // idtarifDataGridViewTextBoxColumn
            // 
            this.idtarifDataGridViewTextBoxColumn.DataPropertyName = "id_tarif";
            this.idtarifDataGridViewTextBoxColumn.HeaderText = "id_tarif";
            this.idtarifDataGridViewTextBoxColumn.Name = "idtarifDataGridViewTextBoxColumn";
            this.idtarifDataGridViewTextBoxColumn.Visible = false;
            // 
            // razradDataGridViewTextBoxColumn
            // 
            this.razradDataGridViewTextBoxColumn.DataPropertyName = "razrad";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.razradDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.razradDataGridViewTextBoxColumn.HeaderText = "Разряд";
            this.razradDataGridViewTextBoxColumn.Name = "razradDataGridViewTextBoxColumn";
            // 
            // tarifKofDataGridViewTextBoxColumn
            // 
            this.tarifKofDataGridViewTextBoxColumn.DataPropertyName = "tarifKof";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tarifKofDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.tarifKofDataGridViewTextBoxColumn.HeaderText = "Тариф коэффициента";
            this.tarifKofDataGridViewTextBoxColumn.Name = "tarifKofDataGridViewTextBoxColumn";
            this.tarifKofDataGridViewTextBoxColumn.Width = 130;
            // 
            // tarifSetkaBindingSource
            // 
            this.tarifSetkaBindingSource.DataMember = "TarifSetka";
            this.tarifSetkaBindingSource.DataSource = this.rmsokDBDataSet;
            // 
            // rmsokDBDataSet
            // 
            this.rmsokDBDataSet.DataSetName = "RmsokDBDataSet";
            this.rmsokDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarifSetkaTableAdapter
            // 
            this.tarifSetkaTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьСеткуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(351, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // изменитьСеткуToolStripMenuItem
            // 
            this.изменитьСеткуToolStripMenuItem.Name = "изменитьСеткуToolStripMenuItem";
            this.изменитьСеткуToolStripMenuItem.Size = new System.Drawing.Size(126, 23);
            this.изменитьСеткуToolStripMenuItem.Text = "Изменить сетку";
            this.изменитьСеткуToolStripMenuItem.Click += new System.EventHandler(this.изменитьСеткуToolStripMenuItem_Click);
            // 
            // fTarifSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fTarifSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "РМСОК: Тарифная сетка";
            this.Load += new System.EventHandler(this.fTarifSet_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifSetkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rmsokDBDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RmsokDBDataSet rmsokDBDataSet;
        private System.Windows.Forms.BindingSource tarifSetkaBindingSource;
        private RmsokDBDataSetTableAdapters.TarifSetkaTableAdapter tarifSetkaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifKofDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изменитьСеткуToolStripMenuItem;
    }
}