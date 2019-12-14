namespace BDApp
{
    partial class TableSubject
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBSpetial = new System.Windows.Forms.ComboBox();
            this.butDelet = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Предмет:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(79, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Таблица \"Предметы\"";
            // 
            // CBSpetial
            // 
            this.CBSpetial.FormattingEnabled = true;
            this.CBSpetial.Location = new System.Drawing.Point(139, 67);
            this.CBSpetial.Name = "CBSpetial";
            this.CBSpetial.Size = new System.Drawing.Size(220, 24);
            this.CBSpetial.TabIndex = 3;
            this.CBSpetial.SelectedIndexChanged += new System.EventHandler(this.CBSpetial_SelectedIndexChanged);
            this.CBSpetial.TextUpdate += new System.EventHandler(this.CBSpetial_TextUpdate);
            // 
            // butDelet
            // 
            this.butDelet.Location = new System.Drawing.Point(251, 100);
            this.butDelet.Name = "butDelet";
            this.butDelet.Size = new System.Drawing.Size(108, 28);
            this.butDelet.TabIndex = 10;
            this.butDelet.Text = "Удалить";
            this.butDelet.UseVisualStyleBackColor = true;
            this.butDelet.Click += new System.EventHandler(this.butDelet_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(125, 100);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(106, 28);
            this.butAdd.TabIndex = 9;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(12, 100);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(94, 28);
            this.butSave.TabIndex = 8;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // TableSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 140);
            this.Controls.Add(this.butDelet);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBSpetial);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableSubject";
            this.Text = "Таблица \"Предметы\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBSpetial;
        private System.Windows.Forms.Button butDelet;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butSave;
    }
}