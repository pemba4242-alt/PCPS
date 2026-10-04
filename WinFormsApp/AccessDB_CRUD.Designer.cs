namespace SectionA_WindowsForms
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
            lblBookRecords = new Label();
            listBoxBooks = new ListBox();
            lblListOfBooks = new Label();
            btnDisplay = new Button();
            btnClear = new Button();
            lblEdit = new Label();
            btnEditTitle = new Button();
            lblDelete = new Label();
            btnDelete = new Button();
            label2 = new Label();
            lblBookKey = new Label();
            lblTitle = new Label();
            lblPages = new Label();
            textBoxBookKey = new TextBox();
            textBoxTitle = new TextBox();
            textBoxPages = new TextBox();
            btnInsert = new Button();
            textBoxEditTitle = new TextBox();
            SuspendLayout();
            // 
            // lblBookRecords
            // 
            lblBookRecords.AutoSize = true;
            lblBookRecords.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookRecords.ForeColor = Color.White;
            lblBookRecords.Location = new Point(60, 37);
            lblBookRecords.Name = "lblBookRecords";
            lblBookRecords.Size = new Size(119, 23);
            lblBookRecords.TabIndex = 0;
            lblBookRecords.Text = "Book Records";
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(60, 82);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(487, 204);
            listBoxBooks.TabIndex = 1;
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
            // 
            // lblListOfBooks
            // 
            lblListOfBooks.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListOfBooks.ForeColor = Color.White;
            lblListOfBooks.Location = new Point(60, 282);
            lblListOfBooks.Name = "lblListOfBooks";
            lblListOfBooks.Size = new Size(341, 74);
            lblListOfBooks.TabIndex = 2;
            lblListOfBooks.Text = "To show the list of books, click on Display. To clear the list click on Clear.";
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(60, 359);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(94, 29);
            btnDisplay.TabIndex = 3;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(225, 359);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblEdit
            // 
            lblEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEdit.ForeColor = Color.White;
            lblEdit.Location = new Point(60, 418);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(361, 86);
            lblEdit.TabIndex = 5;
            lblEdit.Text = "To edit a title, click on Display, and select a record. Enter the new title below and click on Edit Title.";
            // 
            // btnEditTitle
            // 
            btnEditTitle.Location = new Point(60, 541);
            btnEditTitle.Name = "btnEditTitle";
            btnEditTitle.Size = new Size(94, 29);
            btnEditTitle.TabIndex = 7;
            btnEditTitle.Text = "Edit Title";
            btnEditTitle.UseVisualStyleBackColor = true;
            btnEditTitle.Click += btnEditTitle_Click;
            // 
            // lblDelete
            // 
            lblDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDelete.ForeColor = Color.White;
            lblDelete.Location = new Point(51, 591);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(361, 70);
            lblDelete.TabIndex = 8;
            lblDelete.Text = "To delete a book, click on Display and select a record. Click on Delete.";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(60, 664);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(596, 37);
            label2.Name = "label2";
            label2.Size = new Size(378, 79);
            label2.TabIndex = 10;
            label2.Text = "To insert a new record, click on Display. Enter the details below and click on Insert.";
            // 
            // lblBookKey
            // 
            lblBookKey.AutoSize = true;
            lblBookKey.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookKey.ForeColor = Color.White;
            lblBookKey.Location = new Point(635, 122);
            lblBookKey.Name = "lblBookKey";
            lblBookKey.Size = new Size(85, 23);
            lblBookKey.TabIndex = 11;
            lblBookKey.Text = "BookKey:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(635, 191);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(51, 23);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Title:";
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPages.ForeColor = Color.White;
            lblPages.Location = new Point(635, 257);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(61, 23);
            lblPages.TabIndex = 13;
            lblPages.Text = "Pages:";
            // 
            // textBoxBookKey
            // 
            textBoxBookKey.Location = new Point(776, 119);
            textBoxBookKey.Name = "textBoxBookKey";
            textBoxBookKey.Size = new Size(125, 27);
            textBoxBookKey.TabIndex = 14;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(776, 191);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(125, 27);
            textBoxTitle.TabIndex = 15;
            // 
            // textBoxPages
            // 
            textBoxPages.Location = new Point(776, 254);
            textBoxPages.Name = "textBoxPages";
            textBoxPages.Size = new Size(125, 27);
            textBoxPages.TabIndex = 16;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(791, 327);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 17;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // textBoxEditTitle
            // 
            textBoxEditTitle.Location = new Point(60, 496);
            textBoxEditTitle.Name = "textBoxEditTitle";
            textBoxEditTitle.Size = new Size(279, 27);
            textBoxEditTitle.TabIndex = 18;
            // 
            // AccessDB_CRUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(1031, 743);
            Controls.Add(textBoxEditTitle);
            Controls.Add(btnInsert);
            Controls.Add(textBoxPages);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxBookKey);
            Controls.Add(lblPages);
            Controls.Add(lblTitle);
            Controls.Add(lblBookKey);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(lblDelete);
            Controls.Add(btnEditTitle);
            Controls.Add(lblEdit);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(lblListOfBooks);
            Controls.Add(listBoxBooks);
            Controls.Add(lblBookRecords);
            Name = "AccessDB_CRUD";
            Text = "AccessDB_CRUD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookRecords;
        private ListBox listBoxBooks;
        private Label lblListOfBooks;
        private Button btnDisplay;
        private Button btnClear;
        private Label lblEdit;
        private Button btnEditTitle;
        private Label lblDelete;
        private Button btnDelete;
        private Label label2;
        private Label lblBookKey;
        private Label lblTitle;
        private Label lblPages;
        private TextBox textBoxBookKey;
        private TextBox textBoxTitle;
        private TextBox textBoxPages;
        private Button btnInsert;
        private TextBox textBoxEditTitle;
    }
}