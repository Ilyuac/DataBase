namespace BDApp
{
    partial class TableSpetial
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
            this.CBSpetial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBInfo = new System.Windows.Forms.TextBox();
            this.butDelet = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBSpetial
            // 
            this.CBSpetial.FormattingEnabled = true;
            this.CBSpetial.Location = new System.Drawing.Point(208, 69);
            this.CBSpetial.Name = "CBSpetial";
            this.CBSpetial.Size = new System.Drawing.Size(220, 24);
            this.CBSpetial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(94, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица \"Специальности\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Специальность:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TBInfo);
            this.groupBox1.Location = new System.Drawing.Point(3, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 253);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Описание:";
            // 
            // TBInfo
            // 
            this.TBInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBInfo.Location = new System.Drawing.Point(3, 18);
            this.TBInfo.Multiline = true;
            this.TBInfo.Name = "TBInfo";
            this.TBInfo.Size = new System.Drawing.Size(422, 232);
            this.TBInfo.TabIndex = 4;
            // 
            // butDelet
            // 
            this.butDelet.Location = new System.Drawing.Point(320, 372);
            this.butDelet.Name = "butDelet";
            this.butDelet.Size = new System.Drawing.Size(108, 28);
            this.butDelet.TabIndex = 7;
            this.butDelet.Text = "Удалить";
            this.butDelet.UseVisualStyleBackColor = true;
            this.butDelet.Click += new System.EventHandler(this.butDelet_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(147, 372);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(106, 28);
            this.butAdd.TabIndex = 6;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(12, 372);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(94, 28);
            this.butSave.TabIndex = 5;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // TableSpetial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 408);
            this.Controls.Add(this.butDelet);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBSpetial);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableSpetial";
            this.Text = "Таблица \"Специальности\"";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBSpetial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBInfo;
        private System.Windows.Forms.Button butDelet;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butSave;
    }
}