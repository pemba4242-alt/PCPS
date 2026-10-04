namespace SectionC_WindowsForms
{
    partial class AccessDB_CRUD
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
            dataGridViewBooks = new DataGridView();
            lblBookKey = new Label();
            lblPublisher = new Label();
            lblPages = new Label();
            lblTitle = new Label();
            textBoxBookKey = new TextBox();
            textBoxPages = new TextBox();
            textBoxTitle = new TextBox();
            textBoxPublisher = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(27, 26);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.Size = new Size(424, 262);
            dataGridViewBooks.TabIndex = 0;
            dataGridViewBooks.CellClick += dataGridViewBooks_CellContentClick;
            // 
            // lblBookKey
            // 
            lblBookKey.AutoSize = true;
            lblBookKey.Location = new Point(558, 26);
            lblBookKey.Name = "lblBookKey";
            lblBookKey.Size = new Size(67, 20);
            lblBookKey.TabIndex = 1;
            lblBookKey.Text = "BookKey";
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Location = new Point(558, 223);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(69, 20);
            lblPublisher.TabIndex = 2;
            lblPublisher.Text = "Publisher";
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.Location = new Point(558, 153);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(47, 20);
            lblPages.TabIndex = 3;
            lblPages.Text = "Pages";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(558, 88);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Title";
            // 
            // textBoxBookKey
            // 
            textBoxBookKey.Location = new Point(688, 26);
            textBoxBookKey.Name = "textBoxBookKey";
            textBoxBookKey.Size = new Size(212, 27);
            textBoxBookKey.TabIndex = 5;
            // 
            // textBoxPages
            // 
            textBoxPages.Location = new Point(688, 153);
            textBoxPages.Name = "textBoxPages";
            textBoxPages.Size = new Size(212, 27);
            textBoxPages.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(688, 88);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(212, 27);
            textBoxTitle.TabIndex = 7;
            // 
            // textBoxPublisher
            // 
            textBoxPublisher.Location = new Point(688, 220);
            textBoxPublisher.Name = "textBoxPublisher";
            textBoxPublisher.Size = new Size(212, 27);
            textBoxPublisher.TabIndex = 8;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(573, 314);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(702, 314);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(834, 314);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // AccessDB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 533);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(textBoxPublisher);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxPages);
            Controls.Add(textBoxBookKey);
            Controls.Add(lblTitle);
            Controls.Add(lblPages);
            Controls.Add(lblPublisher);
            Controls.Add(lblBookKey);
            Controls.Add(dataGridViewBooks);
            Name = "AccessDB";
            Text = "AccessDB";
            Load += AccessDB_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBooks;
        private Label lblBookKey;
        private Label lblPublisher;
        private Label lblPages;
        private Label lblTitle;
        private TextBox textBoxBookKey;
        private TextBox textBoxPages;
        private TextBox textBoxTitle;
        private TextBox textBoxPublisher;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
    }
}