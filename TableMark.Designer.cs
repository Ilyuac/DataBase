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
            this.label1 = new System.Windows.Forms.Label();
            this.cBFamily = new System.Windows.Forms.ComboBox();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.butSave = new System.Windows.Forms.Button();
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
            this.sC.Panel1.Controls.Add(this.butSave);
            this.sC.Panel1.Controls.Add(this.label1);
            this.sC.Panel1.Controls.Add(this.cBFamily);
            // 
            // sC.Panel2
            // 
            this.sC.Panel2.Controls.Add(this.dGV);
            this.sC.Size = new System.Drawing.Size(506, 522);
            this.sC.SplitterDistance = 46;
            this.sC.TabIndex = 0;
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
            this.cBFamily.Size = new System.Drawing.Size(266, 24);
            this.cBFamily.TabIndex = 0;
            this.cBFamily.SelectedIndexChanged += new System.EventHandler(this.cBFamaly_SelectedIndexChanged);
            // 
            // dGV
            // 
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV.Location = new System.Drawing.Point(0, 0);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidth = 51;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.Size = new System.Drawing.Size(506, 472);
            this.dGV.TabIndex = 0;
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(406, 15);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(94, 23);
            this.butSave.TabIndex = 2;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // TableMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 522);
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
    }
}