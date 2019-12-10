namespace BDApp
{
    partial class TableStudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.bNStudent = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.butFrist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBSpecial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBGroup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.butNext = new System.Windows.Forms.Button();
            this.butLast = new System.Windows.Forms.Button();
            this.butPrevios = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bNStudent)).BeginInit();
            this.bNStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(131, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица \"Студенты\"";
            // 
            // bNStudent
            // 
            this.bNStudent.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bNStudent.CountItem = this.bindingNavigatorCountItem;
            this.bNStudent.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bNStudent.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bNStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bNStudent.Location = new System.Drawing.Point(0, 0);
            this.bNStudent.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bNStudent.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bNStudent.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bNStudent.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bNStudent.Name = "bNStudent";
            this.bNStudent.PositionItem = this.bindingNavigatorPositionItem;
            this.bNStudent.Size = new System.Drawing.Size(465, 31);
            this.bNStudent.TabIndex = 3;
            this.bNStudent.Text = "bNStudent";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // butFrist
            // 
            this.butFrist.Location = new System.Drawing.Point(12, 169);
            this.butFrist.Name = "butFrist";
            this.butFrist.Size = new System.Drawing.Size(142, 49);
            this.butFrist.TabIndex = 4;
            this.butFrist.Text = "Перейди к первой записи";
            this.butFrist.UseVisualStyleBackColor = true;
            this.butFrist.Click += new System.EventHandler(this.butFrist_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ф. И. О. :";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(215, 78);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(235, 22);
            this.tBName.TabIndex = 6;
            // 
            // tBSpecial
            // 
            this.tBSpecial.Location = new System.Drawing.Point(215, 134);
            this.tBSpecial.Name = "tBSpecial";
            this.tBSpecial.Size = new System.Drawing.Size(235, 22);
            this.tBSpecial.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(47, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Специальность:";
            // 
            // tBGroup
            // 
            this.tBGroup.Location = new System.Drawing.Point(215, 106);
            this.tBGroup.Name = "tBGroup";
            this.tBGroup.Size = new System.Drawing.Size(235, 22);
            this.tBGroup.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(47, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Группа: ";
            // 
            // butNext
            // 
            this.butNext.Location = new System.Drawing.Point(160, 169);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(142, 49);
            this.butNext.TabIndex = 13;
            this.butNext.Text = "Перейди к следующей записи";
            this.butNext.UseVisualStyleBackColor = true;
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // butLast
            // 
            this.butLast.Location = new System.Drawing.Point(12, 224);
            this.butLast.Name = "butLast";
            this.butLast.Size = new System.Drawing.Size(142, 49);
            this.butLast.TabIndex = 14;
            this.butLast.Text = "Перейди к последней записи";
            this.butLast.UseVisualStyleBackColor = true;
            this.butLast.Click += new System.EventHandler(this.butLast_Click);
            // 
            // butPrevios
            // 
            this.butPrevios.Location = new System.Drawing.Point(160, 224);
            this.butPrevios.Name = "butPrevios";
            this.butPrevios.Size = new System.Drawing.Size(142, 49);
            this.butPrevios.TabIndex = 15;
            this.butPrevios.Text = "Перейди к прошлой записи";
            this.butPrevios.UseVisualStyleBackColor = true;
            this.butPrevios.Click += new System.EventHandler(this.butPrevios_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(308, 169);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(142, 49);
            this.butAdd.TabIndex = 16;
            this.butAdd.Text = "Добавить запись";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(308, 224);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(142, 49);
            this.butDel.TabIndex = 17;
            this.butDel.Text = "Удплить запись";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(160, 279);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(142, 49);
            this.butSave.TabIndex = 18;
            this.butSave.Text = "Сохранить запись";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripSaveItem_Click);
            // 
            // TableStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 342);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butPrevios);
            this.Controls.Add(this.butLast);
            this.Controls.Add(this.butNext);
            this.Controls.Add(this.tBGroup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBSpecial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butFrist);
            this.Controls.Add(this.bNStudent);
            this.Controls.Add(this.label1);
            this.Name = "TableStudent";
            this.Text = "Таблица \"Студенты\"";
            ((System.ComponentModel.ISupportInitialize)(this.bNStudent)).EndInit();
            this.bNStudent.ResumeLayout(false);
            this.bNStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bNStudent;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button butFrist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBSpecial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.Button butLast;
        private System.Windows.Forms.Button butPrevios;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}