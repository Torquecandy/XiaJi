
namespace WindowsFormsApp1
{
    partial class report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chkCargo = new System.Windows.Forms.CheckBox();
            this.chkdate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxCargo = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkEvening = new System.Windows.Forms.CheckBox();
            this.chkMoring = new System.Windows.Forms.CheckBox();
            this.chkGBType = new System.Windows.Forms.CheckBox();
            this.chkGBCargo = new System.Windows.Forms.CheckBox();
            this.chkGBdate = new System.Windows.Forms.CheckBox();
            this.btnGB = new System.Windows.Forms.Button();
            this.chkType = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkCargo
            // 
            this.chkCargo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkCargo.AutoSize = true;
            this.chkCargo.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkCargo.ForeColor = System.Drawing.Color.White;
            this.chkCargo.Location = new System.Drawing.Point(552, 99);
            this.chkCargo.Name = "chkCargo";
            this.chkCargo.Size = new System.Drawing.Size(196, 38);
            this.chkCargo.TabIndex = 14;
            this.chkCargo.Text = "作為查詢條件";
            this.chkCargo.UseVisualStyleBackColor = true;
            // 
            // chkdate
            // 
            this.chkdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkdate.AutoSize = true;
            this.chkdate.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkdate.ForeColor = System.Drawing.Color.White;
            this.chkdate.Location = new System.Drawing.Point(29, 99);
            this.chkdate.Name = "chkdate";
            this.chkdate.Size = new System.Drawing.Size(196, 38);
            this.chkdate.TabIndex = 13;
            this.chkdate.Text = "作為查詢條件";
            this.chkdate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(546, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "商品";
            // 
            // cboxCargo
            // 
            this.cboxCargo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(102)))));
            this.cboxCargo.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxCargo.ForeColor = System.Drawing.Color.White;
            this.cboxCargo.FormattingEnabled = true;
            this.cboxCargo.Location = new System.Drawing.Point(621, 34);
            this.cboxCargo.Name = "cboxCargo";
            this.cboxCargo.Size = new System.Drawing.Size(149, 42);
            this.cboxCargo.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(102)))));
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(102)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(1088, 28);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(165, 55);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(266, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "-";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker2.Location = new System.Drawing.Point(299, 34);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(241, 43);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 43);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.dGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV.Location = new System.Drawing.Point(0, 153);
            this.dGV.MultiSelect = false;
            this.dGV.Name = "dGV";
            this.dGV.ReadOnly = true;
            this.dGV.RowHeadersVisible = false;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(1592, 591);
            this.dGV.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.chkEvening);
            this.panel1.Controls.Add(this.chkMoring);
            this.panel1.Controls.Add(this.chkGBType);
            this.panel1.Controls.Add(this.chkGBCargo);
            this.panel1.Controls.Add(this.chkGBdate);
            this.panel1.Controls.Add(this.btnGB);
            this.panel1.Controls.Add(this.chkType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboxType);
            this.panel1.Controls.Add(this.chkCargo);
            this.panel1.Controls.Add(this.chkdate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboxCargo);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1592, 153);
            this.panel1.TabIndex = 2;
            // 
            // chkEvening
            // 
            this.chkEvening.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkEvening.AutoSize = true;
            this.chkEvening.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkEvening.ForeColor = System.Drawing.Color.White;
            this.chkEvening.Location = new System.Drawing.Point(1165, 98);
            this.chkEvening.Name = "chkEvening";
            this.chkEvening.Size = new System.Drawing.Size(88, 38);
            this.chkEvening.TabIndex = 29;
            this.chkEvening.Text = "下午";
            this.chkEvening.UseVisualStyleBackColor = true;
            // 
            // chkMoring
            // 
            this.chkMoring.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkMoring.AutoSize = true;
            this.chkMoring.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkMoring.ForeColor = System.Drawing.Color.White;
            this.chkMoring.Location = new System.Drawing.Point(1071, 98);
            this.chkMoring.Name = "chkMoring";
            this.chkMoring.Size = new System.Drawing.Size(88, 38);
            this.chkMoring.TabIndex = 28;
            this.chkMoring.Text = "上午";
            this.chkMoring.UseVisualStyleBackColor = true;
            // 
            // chkGBType
            // 
            this.chkGBType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkGBType.AutoSize = true;
            this.chkGBType.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkGBType.ForeColor = System.Drawing.Color.White;
            this.chkGBType.Location = new System.Drawing.Point(1279, 80);
            this.chkGBType.Name = "chkGBType";
            this.chkGBType.Size = new System.Drawing.Size(162, 28);
            this.chkGBType.TabIndex = 27;
            this.chkGBType.Text = "按售出方式分類";
            this.chkGBType.UseVisualStyleBackColor = true;
            // 
            // chkGBCargo
            // 
            this.chkGBCargo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkGBCargo.AutoSize = true;
            this.chkGBCargo.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkGBCargo.ForeColor = System.Drawing.Color.White;
            this.chkGBCargo.Location = new System.Drawing.Point(1279, 46);
            this.chkGBCargo.Name = "chkGBCargo";
            this.chkGBCargo.Size = new System.Drawing.Size(124, 28);
            this.chkGBCargo.TabIndex = 26;
            this.chkGBCargo.Text = "按商品分類";
            this.chkGBCargo.UseVisualStyleBackColor = true;
            // 
            // chkGBdate
            // 
            this.chkGBdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkGBdate.AutoSize = true;
            this.chkGBdate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkGBdate.ForeColor = System.Drawing.Color.White;
            this.chkGBdate.Location = new System.Drawing.Point(1279, 12);
            this.chkGBdate.Name = "chkGBdate";
            this.chkGBdate.Size = new System.Drawing.Size(124, 28);
            this.chkGBdate.TabIndex = 25;
            this.chkGBdate.Text = "按日期分類";
            this.chkGBdate.UseVisualStyleBackColor = true;
            // 
            // btnGB
            // 
            this.btnGB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(102)))));
            this.btnGB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(102)))));
            this.btnGB.FlatAppearance.BorderSize = 0;
            this.btnGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGB.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGB.ForeColor = System.Drawing.Color.White;
            this.btnGB.Location = new System.Drawing.Point(1441, 28);
            this.btnGB.Name = "btnGB";
            this.btnGB.Size = new System.Drawing.Size(148, 108);
            this.btnGB.TabIndex = 24;
            this.btnGB.Text = "分類統計";
            this.btnGB.UseVisualStyleBackColor = false;
            this.btnGB.Click += new System.EventHandler(this.btnGB_Click);
            // 
            // chkType
            // 
            this.chkType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkType.AutoSize = true;
            this.chkType.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkType.ForeColor = System.Drawing.Color.White;
            this.chkType.Location = new System.Drawing.Point(810, 99);
            this.chkType.Name = "chkType";
            this.chkType.Size = new System.Drawing.Size(196, 38);
            this.chkType.TabIndex = 23;
            this.chkType.Text = "作為查詢條件";
            this.chkType.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(804, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 34);
            this.label3.TabIndex = 22;
            this.label3.Text = "售出方式";
            // 
            // cboxType
            // 
            this.cboxType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(102)))));
            this.cboxType.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxType.ForeColor = System.Drawing.Color.White;
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Location = new System.Drawing.Point(933, 36);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(149, 42);
            this.cboxType.TabIndex = 21;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 744);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "報表";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chkCargo;
        private System.Windows.Forms.CheckBox chkdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxCargo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxType;
        private System.Windows.Forms.CheckBox chkType;
        private System.Windows.Forms.CheckBox chkEvening;
        private System.Windows.Forms.CheckBox chkMoring;
        private System.Windows.Forms.CheckBox chkGBType;
        private System.Windows.Forms.CheckBox chkGBCargo;
        private System.Windows.Forms.CheckBox chkGBdate;
        private System.Windows.Forms.Button btnGB;
    }
}