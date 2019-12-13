namespace BDApp
{
    partial class AddMark
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
            this.cBSubject = new System.Windows.Forms.ComboBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.StudName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBMark = new System.Windows.Forms.TextBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBSubject
            // 
            this.cBSubject.FormattingEnabled = true;
            this.cBSubject.Location = new System.Drawing.Point(182, 58);
            this.cBSubject.Name = "cBSubject";
            this.cBSubject.Size = new System.Drawing.Size(195, 24);
            this.cBSubject.TabIndex = 0;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(29, 129);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(141, 45);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // StudName
            // 
            this.StudName.AutoSize = true;
            this.StudName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudName.Location = new System.Drawing.Point(153, 9);
            this.StudName.Name = "StudName";
            this.StudName.Size = new System.Drawing.Size(0, 29);
            this.StudName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Предмет :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Оценка: ";
            // 
            // tBMark
            // 
            this.tBMark.Location = new System.Drawing.Point(182, 93);
            this.tBMark.Name = "tBMark";
            this.tBMark.Size = new System.Drawing.Size(195, 22);
            this.tBMark.TabIndex = 5;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(209, 129);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(141, 45);
            this.butCancel.TabIndex = 6;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // AddMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 186);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.tBMark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudName);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.cBSubject);
            this.Name = "AddMark";
            this.Text = "AddMark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBSubject;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Label StudName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBMark;
        private System.Windows.Forms.Button butCancel;
    }
}