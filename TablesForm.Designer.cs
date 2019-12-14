namespace BDApp
{
    partial class TablesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butSort = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lBFilters = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.cBFamily = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butFiltr = new System.Windows.Forms.Button();
            this.butShowAll = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.butSeartch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butSort);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.lBFilters);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(754, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка:";
            // 
            // butSort
            // 
            this.butSort.Enabled = false;
            this.butSort.Location = new System.Drawing.Point(9, 374);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(257, 31);
            this.butSort.TabIndex = 4;
            this.butSort.Text = "Сортировка";
            this.butSort.UseVisualStyleBackColor = true;
            this.butSort.Click += new System.EventHandler(this.butSort_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 347);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(197, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Сортировка по убыванию";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 320);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(217, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Сортировка по возрастанию";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lBFilters
            // 
            this.lBFilters.FormattingEnabled = true;
            this.lBFilters.ItemHeight = 16;
            this.lBFilters.Location = new System.Drawing.Point(9, 38);
            this.lBFilters.Name = "lBFilters";
            this.lBFilters.Size = new System.Drawing.Size(257, 276);
            this.lBFilters.TabIndex = 1;
            this.lBFilters.SelectedIndexChanged += new System.EventHandler(this.lBFilters_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Поле для сортировки:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица \"Студенты\" (Табличный вид)\r\n";
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(2, 48);
            this.dGV.Name = "dGV";
            this.dGV.ReadOnly = true;
            this.dGV.RowHeadersWidth = 51;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.Size = new System.Drawing.Size(746, 415);
            this.dGV.TabIndex = 2;
            this.dGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CellContentClick);
            // 
            // cBFamily
            // 
            this.cBFamily.FormattingEnabled = true;
            this.cBFamily.Location = new System.Drawing.Point(144, 476);
            this.cBFamily.Name = "cBFamily";
            this.cBFamily.Size = new System.Drawing.Size(613, 24);
            this.cBFamily.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 515);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(613, 22);
            this.textBox1.TabIndex = 4;
            // 
            // butFiltr
            // 
            this.butFiltr.Location = new System.Drawing.Point(769, 469);
            this.butFiltr.Name = "butFiltr";
            this.butFiltr.Size = new System.Drawing.Size(130, 31);
            this.butFiltr.TabIndex = 5;
            this.butFiltr.Text = "Фильтровать";
            this.butFiltr.UseVisualStyleBackColor = true;
            this.butFiltr.Click += new System.EventHandler(this.butFiltr_Click);
            // 
            // butShowAll
            // 
            this.butShowAll.Location = new System.Drawing.Point(905, 469);
            this.butShowAll.Name = "butShowAll";
            this.butShowAll.Size = new System.Drawing.Size(115, 31);
            this.butShowAll.TabIndex = 9;
            this.butShowAll.Text = "Показать все";
            this.butShowAll.UseVisualStyleBackColor = true;
            this.butShowAll.Click += new System.EventHandler(this.butShowAll_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(905, 509);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(115, 31);
            this.butClose.TabIndex = 11;
            this.butClose.Text = "Закрыть";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butSeartch
            // 
            this.butSeartch.Location = new System.Drawing.Point(769, 511);
            this.butSeartch.Name = "butSeartch";
            this.butSeartch.Size = new System.Drawing.Size(130, 31);
            this.butSeartch.TabIndex = 10;
            this.butSeartch.Text = "Найти";
            this.butSeartch.UseVisualStyleBackColor = true;
            this.butSeartch.Click += new System.EventHandler(this.butSeartch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "ФИО:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Критерий:";
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 546);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butSeartch);
            this.Controls.Add(this.butShowAll);
            this.Controls.Add(this.butFiltr);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cBFamily);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TablesForm";
            this.Text = "Таблица \"Студенты\"";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butSort;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox lBFilters;
        private System.Windows.Forms.ComboBox cBFamily;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butFiltr;
        private System.Windows.Forms.Button butShowAll;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butSeartch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}