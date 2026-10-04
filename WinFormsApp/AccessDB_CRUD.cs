using System.Data;
using System.Data.OleDb;

namespace SectionA_WindowsForms
{
    public partial class AccessDB_CRUD : Form
    {
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Pemba\\BookCSharp.accdb";
        string selectedBookKey;
        string selectedTitle;

        public AccessDB_CRUD()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            listBoxBooks.Items.Clear();
            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
            string query = "SELECT BookKey, Title, Pages FROM Books";

            OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.Fill(dataTable);


            foreach (DataRow row in dataTable.Rows)
            {
                string bookKey = row["BookKey"].ToString();
                string title = row["Title"].ToString();
                string pages = row["Pages"].ToString();

                listBoxBooks.Items.Add($"{bookKey}-{title}-{pages}");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string bookKey = textBoxBookKey.Text;
            string title = textBoxTitle.Text;
            string pages = textBoxPages.Text;

            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
            string query = "INSERT INTO Books (BookKey, Title, Pages) VALUES (?, ?, ?)";

            OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);
            oleDbCommand.Parameters.AddWithValue("@BookKey", bookKey);
            oleDbCommand.Parameters.AddWithValue("@Title", title);
            oleDbCommand.Parameters.AddWithValue("@Pages", pages);

            oleDbConnection.Open();
            oleDbCommand.ExecuteNonQuery();
            oleDbConnection.Close();

            MessageBox.Show("Record inserted successfully");
            textBoxBookKey.Clear();
            textBoxTitle.Clear();
            textBoxPages.Clear();
            btnDisplay_Click(null, null);
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;

            if (listBox != null && listBox.SelectedIndex != -1)
            {
                string selectedItemText = listBox.SelectedItem.ToString();
                string[] selectedItemParts = selectedItemText.Split('-');

                selectedBookKey = selectedItemParts[0];
                selectedTitle = selectedItemParts[1];
                textBoxEditTitle.Text = selectedTitle;
            }
        }

        private void btnEditTitle_Click(object sender, EventArgs e)
        {
            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
            string query = "Update Books  set Title=? where BookKey=?";

            OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);
            oleDbCommand.Parameters.AddWithValue("@Title", textBoxEditTitle.Text);
            oleDbCommand.Parameters.AddWithValue("@BookKey", selectedBookKey);

            oleDbConnection.Open();
            oleDbCommand.ExecuteNonQuery();
            oleDbConnection.Close();

            MessageBox.Show("Record updated successfully");
        }
    }
}
