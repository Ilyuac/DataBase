namespace BDApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.butSpetial = new System.Windows.Forms.Button();
            this.butSubject = new System.Windows.Forms.Button();
            this.butStud = new System.Windows.Forms.Button();
            this.butMark = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "База данных \"Студент\"";
            // 
            // butSpetial
            // 
            this.butSpetial.Location = new System.Drawing.Point(39, 51);
            this.butSpetial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butSpetial.Name = "butSpetial";
            this.butSpetial.Size = new System.Drawing.Size(194, 49);
            this.butSpetial.TabIndex = 1;
            this.butSpetial.Text = "Таблица \"Специальности\"";
            this.butSpetial.UseVisualStyleBackColor = true;
            this.butSpetial.Click += new System.EventHandler(this.butSpetial_Click);
            // 
            // butSubject
            // 
            this.butSubject.Location = new System.Drawing.Point(39, 105);
            this.butSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butSubject.Name = "butSubject";
            this.butSubject.Size = new System.Drawing.Size(194, 49);
            this.butSubject.TabIndex = 2;
            this.butSubject.Text = "Таблица \"Предметы\"\r\n";
            this.butSubject.UseVisualStyleBackColor = true;
            this.butSubject.Click += new System.EventHandler(this.butSubject_Click);
            // 
            // butStud
            // 
            this.butStud.Location = new System.Drawing.Point(39, 158);
            this.butStud.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butStud.Name = "butStud";
            this.butStud.Size = new System.Drawing.Size(194, 49);
            this.butStud.TabIndex = 3;
            this.butStud.Text = "Таблица \"Студенты\"";
            this.butStud.UseVisualStyleBackColor = true;
            this.butStud.Click += new System.EventHandler(this.butStud_Click);
            // 
            // butMark
            // 
            this.butMark.Location = new System.Drawing.Point(39, 212);
            this.butMark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butMark.Name = "butMark";
            this.butMark.Size = new System.Drawing.Size(194, 49);
            this.butMark.TabIndex = 4;
            this.butMark.Text = "Таблица \"Оценки\"";
            this.butMark.UseVisualStyleBackColor = true;
            this.butMark.Click += new System.EventHandler(this.butMark_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "LINQStudent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butMark);
            this.Controls.Add(this.butStud);
            this.Controls.Add(this.butSubject);
            this.Controls.Add(this.butSpetial);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "База Данных";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butSpetial;
        private System.Windows.Forms.Button butSubject;
        private System.Windows.Forms.Button butStud;
        private System.Windows.Forms.Button butMark;
        private System.Windows.Forms.Button button1;
    }
}

