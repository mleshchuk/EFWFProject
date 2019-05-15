namespace TestProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new TestProject.MyDBDataSet();
            this.mailInfoTableAdapter = new TestProject.MyDBDataSetTableAdapters.MailInfoTableAdapter();
            this.addMail = new System.Windows.Forms.Button();
            this.editMail = new System.Windows.Forms.Button();
            this.deleteMail = new System.Windows.Forms.Button();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.idField = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.mailInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(402, 169);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // mailInfoBindingSource
            // 
            this.mailInfoBindingSource.DataMember = "MailInfo";
            this.mailInfoBindingSource.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mailInfoTableAdapter
            // 
            this.mailInfoTableAdapter.ClearBeforeFill = true;
            // 
            // addMail
            // 
            this.addMail.Location = new System.Drawing.Point(435, 12);
            this.addMail.Name = "addMail";
            this.addMail.Size = new System.Drawing.Size(75, 23);
            this.addMail.TabIndex = 1;
            this.addMail.Text = "Add mail";
            this.addMail.UseVisualStyleBackColor = true;
            this.addMail.Click += new System.EventHandler(this.addMail_Click);
            // 
            // editMail
            // 
            this.editMail.Location = new System.Drawing.Point(435, 61);
            this.editMail.Name = "editMail";
            this.editMail.Size = new System.Drawing.Size(75, 23);
            this.editMail.TabIndex = 2;
            this.editMail.Text = "Edit mail";
            this.editMail.UseVisualStyleBackColor = true;
            this.editMail.Click += new System.EventHandler(this.editMail_Click);
            // 
            // deleteMail
            // 
            this.deleteMail.Location = new System.Drawing.Point(435, 116);
            this.deleteMail.Name = "deleteMail";
            this.deleteMail.Size = new System.Drawing.Size(75, 23);
            this.deleteMail.TabIndex = 3;
            this.deleteMail.Text = "Delete mail";
            this.deleteMail.UseVisualStyleBackColor = true;
            this.deleteMail.Click += new System.EventHandler(this.deleteMail_Click);
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(160, 190);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(254, 20);
            this.mailBox.TabIndex = 4;
            // 
            // idField
            // 
            this.idField.AutoSize = true;
            this.idField.Location = new System.Drawing.Point(12, 197);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(0, 13);
            this.idField.TabIndex = 6;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(461, 210);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(100, 20);
            this.urlTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.deleteMail);
            this.Controls.Add(this.editMail);
            this.Controls.Add(this.addMail);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource mailInfoBindingSource;
        private MyDBDataSetTableAdapters.MailInfoTableAdapter mailInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addMail;
        private System.Windows.Forms.Button editMail;
        private System.Windows.Forms.Button deleteMail;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.Label idField;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

