namespace sql_inter
{
    partial class Penalties
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
            System.Windows.Forms.Label apartment_idLabel;
            System.Windows.Forms.Label bill_idLabel;
            System.Windows.Forms.Label penalty_amountLabel;
            System.Windows.Forms.Label penalty_dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Penalties));
            this.postgresDataSet = new sql_inter.postgresDataSet();
            this.penaltiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.penaltiesTableAdapter = new sql_inter.postgresDataSetTableAdapters.penaltiesTableAdapter();
            this.tableAdapterManager = new sql_inter.postgresDataSetTableAdapters.TableAdapterManager();
            this.penaltiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.penaltiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.apartment_idTextBox = new System.Windows.Forms.TextBox();
            this.bill_idTextBox = new System.Windows.Forms.TextBox();
            this.penalty_amountTextBox = new System.Windows.Forms.TextBox();
            this.penalty_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.billsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billsTableAdapter = new sql_inter.postgresDataSetTableAdapters.billsTableAdapter();
            apartment_idLabel = new System.Windows.Forms.Label();
            bill_idLabel = new System.Windows.Forms.Label();
            penalty_amountLabel = new System.Windows.Forms.Label();
            penalty_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penaltiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penaltiesBindingNavigator)).BeginInit();
            this.penaltiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apartment_idLabel
            // 
            apartment_idLabel.AutoSize = true;
            apartment_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            apartment_idLabel.Location = new System.Drawing.Point(206, 92);
            apartment_idLabel.Name = "apartment_idLabel";
            apartment_idLabel.Size = new System.Drawing.Size(136, 25);
            apartment_idLabel.TabIndex = 1;
            apartment_idLabel.Text = "Id квартиры:";
            // 
            // bill_idLabel
            // 
            bill_idLabel.AutoSize = true;
            bill_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            bill_idLabel.Location = new System.Drawing.Point(206, 131);
            bill_idLabel.Name = "bill_idLabel";
            bill_idLabel.Size = new System.Drawing.Size(97, 25);
            bill_idLabel.TabIndex = 3;
            bill_idLabel.Text = "Id счёта:";
            // 
            // penalty_amountLabel
            // 
            penalty_amountLabel.AutoSize = true;
            penalty_amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            penalty_amountLabel.Location = new System.Drawing.Point(206, 170);
            penalty_amountLabel.Name = "penalty_amountLabel";
            penalty_amountLabel.Size = new System.Drawing.Size(148, 25);
            penalty_amountLabel.TabIndex = 5;
            penalty_amountLabel.Text = "Размер пени:";
            // 
            // penalty_dateLabel
            // 
            penalty_dateLabel.AutoSize = true;
            penalty_dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            penalty_dateLabel.Location = new System.Drawing.Point(206, 209);
            penalty_dateLabel.Name = "penalty_dateLabel";
            penalty_dateLabel.Size = new System.Drawing.Size(208, 25);
            penalty_dateLabel.TabIndex = 7;
            penalty_dateLabel.Text = "Дата расчёта пени:";
            // 
            // postgresDataSet
            // 
            this.postgresDataSet.DataSetName = "postgresDataSet";
            this.postgresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // penaltiesBindingSource
            // 
            this.penaltiesBindingSource.DataMember = "penalties";
            this.penaltiesBindingSource.DataSource = this.postgresDataSet;
            // 
            // penaltiesTableAdapter
            // 
            this.penaltiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.apartmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.billsTableAdapter = null;
            this.tableAdapterManager.paymentsTableAdapter = null;
            this.tableAdapterManager.penaltiesTableAdapter = this.penaltiesTableAdapter;
            this.tableAdapterManager.residentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sql_inter.postgresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilitiesTableAdapter = null;
            // 
            // penaltiesBindingNavigator
            // 
            this.penaltiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.penaltiesBindingNavigator.BindingSource = this.penaltiesBindingSource;
            this.penaltiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.penaltiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.penaltiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.penaltiesBindingNavigatorSaveItem});
            this.penaltiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.penaltiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.penaltiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.penaltiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.penaltiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.penaltiesBindingNavigator.Name = "penaltiesBindingNavigator";
            this.penaltiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.penaltiesBindingNavigator.Size = new System.Drawing.Size(946, 25);
            this.penaltiesBindingNavigator.TabIndex = 0;
            this.penaltiesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // penaltiesBindingNavigatorSaveItem
            // 
            this.penaltiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.penaltiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("penaltiesBindingNavigatorSaveItem.Image")));
            this.penaltiesBindingNavigatorSaveItem.Name = "penaltiesBindingNavigatorSaveItem";
            this.penaltiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.penaltiesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.penaltiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.penaltiesBindingNavigatorSaveItem_Click);
            // 
            // apartment_idTextBox
            // 
            this.apartment_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.penaltiesBindingSource, "apartment_id", true));
            this.apartment_idTextBox.Location = new System.Drawing.Point(432, 97);
            this.apartment_idTextBox.Name = "apartment_idTextBox";
            this.apartment_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.apartment_idTextBox.TabIndex = 2;
            // 
            // bill_idTextBox
            // 
            this.bill_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.penaltiesBindingSource, "bill_id", true));
            this.bill_idTextBox.Location = new System.Drawing.Point(432, 136);
            this.bill_idTextBox.Name = "bill_idTextBox";
            this.bill_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.bill_idTextBox.TabIndex = 4;
            // 
            // penalty_amountTextBox
            // 
            this.penalty_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.penaltiesBindingSource, "penalty_amount", true));
            this.penalty_amountTextBox.Location = new System.Drawing.Point(432, 175);
            this.penalty_amountTextBox.Name = "penalty_amountTextBox";
            this.penalty_amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.penalty_amountTextBox.TabIndex = 6;
            // 
            // penalty_dateDateTimePicker
            // 
            this.penalty_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.penaltiesBindingSource, "penalty_date", true));
            this.penalty_dateDateTimePicker.Location = new System.Drawing.Point(432, 214);
            this.penalty_dateDateTimePicker.Name = "penalty_dateDateTimePicker";
            this.penalty_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.penalty_dateDateTimePicker.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(329, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Пени";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(289, 371);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(226, 39);
            this.button7.TabIndex = 35;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(405, 313);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 39);
            this.button6.TabIndex = 34;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(289, 313);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 39);
            this.button5.TabIndex = 33;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(521, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 39);
            this.button4.TabIndex = 32;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(405, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 39);
            this.button3.TabIndex = 31;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(289, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 39);
            this.button2.TabIndex = 30;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(173, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // billsBindingSource
            // 
            this.billsBindingSource.DataMember = "bills";
            this.billsBindingSource.DataSource = this.postgresDataSet;
            // 
            // billsTableAdapter
            // 
            this.billsTableAdapter.ClearBeforeFill = true;
            // 
            // Penalties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(penalty_dateLabel);
            this.Controls.Add(this.penalty_dateDateTimePicker);
            this.Controls.Add(penalty_amountLabel);
            this.Controls.Add(this.penalty_amountTextBox);
            this.Controls.Add(bill_idLabel);
            this.Controls.Add(this.bill_idTextBox);
            this.Controls.Add(apartment_idLabel);
            this.Controls.Add(this.apartment_idTextBox);
            this.Controls.Add(this.penaltiesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Penalties";
            this.Text = "Пени";
            this.Load += new System.EventHandler(this.Penalties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penaltiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penaltiesBindingNavigator)).EndInit();
            this.penaltiesBindingNavigator.ResumeLayout(false);
            this.penaltiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private postgresDataSet postgresDataSet;
        private System.Windows.Forms.BindingSource penaltiesBindingSource;
        private postgresDataSetTableAdapters.penaltiesTableAdapter penaltiesTableAdapter;
        private postgresDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator penaltiesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton penaltiesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox apartment_idTextBox;
        private System.Windows.Forms.TextBox bill_idTextBox;
        private System.Windows.Forms.TextBox penalty_amountTextBox;
        private System.Windows.Forms.DateTimePicker penalty_dateDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource billsBindingSource;
        private postgresDataSetTableAdapters.billsTableAdapter billsTableAdapter;
    }
}