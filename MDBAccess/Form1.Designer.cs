namespace MDBAccess
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonECO_Cont = new System.Windows.Forms.Button();
            this.buttonECO_Attr = new System.Windows.Forms.Button();
            this.buttonProj = new System.Windows.Forms.Button();
            this.buttonRegystri = new System.Windows.Forms.Button();
            this.comboBoxSelectTable = new System.Windows.Forms.ComboBox();
            this.buttonViewTable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPathDB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(941, 559);
            this.splitContainer1.SplitterDistance = 148;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonECO_Cont);
            this.groupBox2.Controls.Add(this.buttonECO_Attr);
            this.groupBox2.Controls.Add(this.buttonProj);
            this.groupBox2.Controls.Add(this.buttonRegystri);
            this.groupBox2.Controls.Add(this.comboBoxSelectTable);
            this.groupBox2.Controls.Add(this.buttonViewTable);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(941, 89);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор таблицы для редактирования";
            // 
            // buttonECO_Cont
            // 
            this.buttonECO_Cont.Location = new System.Drawing.Point(249, 59);
            this.buttonECO_Cont.Name = "buttonECO_Cont";
            this.buttonECO_Cont.Size = new System.Drawing.Size(75, 23);
            this.buttonECO_Cont.TabIndex = 6;
            this.buttonECO_Cont.Text = "Литера изв";
            this.buttonECO_Cont.UseVisualStyleBackColor = true;
            this.buttonECO_Cont.Click += new System.EventHandler(this.buttonECO_Cont_Click);
            // 
            // buttonECO_Attr
            // 
            this.buttonECO_Attr.Location = new System.Drawing.Point(168, 59);
            this.buttonECO_Attr.Name = "buttonECO_Attr";
            this.buttonECO_Attr.Size = new System.Drawing.Size(75, 23);
            this.buttonECO_Attr.TabIndex = 5;
            this.buttonECO_Attr.Text = "Номер изв";
            this.buttonECO_Attr.UseVisualStyleBackColor = true;
            this.buttonECO_Attr.Click += new System.EventHandler(this.buttonECO_ATTR_Click);
            // 
            // buttonProj
            // 
            this.buttonProj.Location = new System.Drawing.Point(87, 59);
            this.buttonProj.Name = "buttonProj";
            this.buttonProj.Size = new System.Drawing.Size(75, 23);
            this.buttonProj.TabIndex = 4;
            this.buttonProj.Text = "Проекты";
            this.buttonProj.UseVisualStyleBackColor = true;
            this.buttonProj.Click += new System.EventHandler(this.buttonProjs_Click);
            // 
            // buttonRegystri
            // 
            this.buttonRegystri.Location = new System.Drawing.Point(6, 59);
            this.buttonRegystri.Name = "buttonRegystri";
            this.buttonRegystri.Size = new System.Drawing.Size(75, 23);
            this.buttonRegystri.TabIndex = 3;
            this.buttonRegystri.Text = "Регистрация";
            this.buttonRegystri.UseVisualStyleBackColor = true;
            this.buttonRegystri.Click += new System.EventHandler(this.buttonRegistry_Click);
            // 
            // comboBoxSelectTable
            // 
            this.comboBoxSelectTable.FormattingEnabled = true;
            this.comboBoxSelectTable.Location = new System.Drawing.Point(6, 26);
            this.comboBoxSelectTable.Name = "comboBoxSelectTable";
            this.comboBoxSelectTable.Size = new System.Drawing.Size(183, 21);
            this.comboBoxSelectTable.TabIndex = 2;
            // 
            // buttonViewTable
            // 
            this.buttonViewTable.Location = new System.Drawing.Point(223, 24);
            this.buttonViewTable.Name = "buttonViewTable";
            this.buttonViewTable.Size = new System.Drawing.Size(75, 23);
            this.buttonViewTable.TabIndex = 1;
            this.buttonViewTable.Text = "Показать";
            this.buttonViewTable.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxPathDB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Путь к файлу БД";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPathDB
            // 
            this.textBoxPathDB.Location = new System.Drawing.Point(9, 25);
            this.textBoxPathDB.Name = "textBoxPathDB";
            this.textBoxPathDB.Size = new System.Drawing.Size(208, 20);
            this.textBoxPathDB.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 407);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 559);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonECO_Cont;
        private System.Windows.Forms.Button buttonECO_Attr;
        private System.Windows.Forms.Button buttonProj;
        private System.Windows.Forms.Button buttonRegystri;
        private System.Windows.Forms.ComboBox comboBoxSelectTable;
        private System.Windows.Forms.Button buttonViewTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPathDB;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

