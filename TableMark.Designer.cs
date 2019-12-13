namespace BDApp
{
    partial class TableMark
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
            this.sC = new System.Windows.Forms.SplitContainer();
            this.butDelet = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBFamily = new System.Windows.Forms.ComboBox();
            this.dGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sC)).BeginInit();
            this.sC.Panel1.SuspendLayout();
            this.sC.Panel2.SuspendLayout();
            this.sC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // sC
            // 
            this.sC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sC.Location = new System.Drawing.Point(0, 0);
            this.sC.Name = "sC";
            this.sC.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sC.Panel1
            // 
            this.sC.Panel1.Controls.Add(this.butDelet);
            this.sC.Panel1.Controls.Add(this.butAdd);
            this.sC.Panel1.Controls.Add(this.butSave);
            this.sC.Panel1.Controls.Add(this.label1);
            this.sC.Panel1.Controls.Add(this.cBFamily);
            // 
            // sC.Panel2
            // 
            this.sC.Panel2.Controls.Add(this.dGV);
            this.sC.Size = new System.Drawing.Size(554, 522);
            this.sC.SplitterDistance = 46;
            this.sC.TabIndex = 0;
            // 
            // butDelet
            // 
            this.butDelet.Location = new System.Drawing.Point(448, 16);
            this.butDelet.Name = "butDelet";
            this.butDelet.Size = new System.Drawing.Size(94, 23);
            this.butDelet.TabIndex = 4;
            this.butDelet.Text = "Удалить";
            this.butDelet.UseVisualStyleBackColor = true;
            this.butDelet.Click += new System.EventHandler(this.butDelet_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(348, 16);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(94, 23);
            this.butAdd.TabIndex = 3;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(248, 16);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(94, 23);
            this.butSave.TabIndex = 2;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия:";
            // 
            // cBFamily
            // 
            this.cBFamily.FormattingEnabled = true;
            this.cBFamily.Location = new System.Drawing.Point(127, 15);
            this.cBFamily.Name = "cBFamily";
            this.cBFamily.Size = new System.Drawing.Size(115, 24);
            this.cBFamily.TabIndex = 0;
            this.cBFamily.SelectedIndexChanged += new System.EventHandler(this.cBFamaly_SelectedIndexChanged);
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV.Location = new System.Drawing.Point(0, 0);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidth = 51;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(554, 472);
            this.dGV.TabIndex = 0;
            // 
            // TableMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 522);
            this.Controls.Add(this.sC);
            this.MaximizeBox = false;
            this.Name = "TableMark";
            this.Text = "Таблица \"Отценки\"";
            this.sC.Panel1.ResumeLayout(false);
            this.sC.Panel1.PerformLayout();
            this.sC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sC)).EndInit();
            this.sC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sC;
        private System.Windows.Forms.ComboBox cBFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butDelet;
        private System.Windows.Forms.Button butAdd;
    }
}