
namespace RMSOK.Forms
{
    partial class MainMenu
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
            this.btnShowCeh = new System.Windows.Forms.Button();
            this.btnShowPers = new System.Windows.Forms.Button();
            this.btnShowTarif = new System.Windows.Forms.Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowCeh
            // 
            this.btnShowCeh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowCeh.Location = new System.Drawing.Point(3, 3);
            this.btnShowCeh.Name = "btnShowCeh";
            this.btnShowCeh.Size = new System.Drawing.Size(137, 54);
            this.btnShowCeh.TabIndex = 0;
            this.btnShowCeh.Text = "Цеха";
            this.btnShowCeh.UseVisualStyleBackColor = true;
            this.btnShowCeh.Click += new System.EventHandler(this.btnShowCeh_Click);
            // 
            // btnShowPers
            // 
            this.btnShowPers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowPers.Location = new System.Drawing.Point(167, 3);
            this.btnShowPers.Name = "btnShowPers";
            this.btnShowPers.Size = new System.Drawing.Size(142, 54);
            this.btnShowPers.TabIndex = 1;
            this.btnShowPers.Text = "Персонал";
            this.btnShowPers.UseVisualStyleBackColor = true;
            this.btnShowPers.Click += new System.EventHandler(this.btnShowPers_Click);
            // 
            // btnShowTarif
            // 
            this.btnShowTarif.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowTarif.Location = new System.Drawing.Point(167, 75);
            this.btnShowTarif.Name = "btnShowTarif";
            this.btnShowTarif.Size = new System.Drawing.Size(142, 54);
            this.btnShowTarif.TabIndex = 2;
            this.btnShowTarif.Text = "Тарифная сетка";
            this.btnShowTarif.UseVisualStyleBackColor = true;
            this.btnShowTarif.Click += new System.EventHandler(this.btnShowTarif_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.72612F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.27388F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tlpMain.Controls.Add(this.btnClose, 0, 2);
            this.tlpMain.Controls.Add(this.btnShowCeh, 0, 0);
            this.tlpMain.Controls.Add(this.btnShowPers, 1, 0);
            this.tlpMain.Controls.Add(this.btnShowTarif, 1, 1);
            this.tlpMain.Controls.Add(this.button1, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMain.Size = new System.Drawing.Size(338, 224);
            this.tlpMain.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(3, 147);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 54);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Выйти";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Документы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnShowOtch_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 224);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(354, 263);
            this.MinimumSize = new System.Drawing.Size(354, 263);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"МЗХР\": РМСОК";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowCeh;
        private System.Windows.Forms.Button btnShowPers;
        private System.Windows.Forms.Button btnShowTarif;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
    }
}