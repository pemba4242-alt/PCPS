using System.Data;
using System.Data.OleDb;

namespace SectionC_WindowsForms
{
    public partial class AccessDB_CRUD : Form
    {
        int rowSelectedIndex = 0;
        public AccessDB_CRUD()
        {
            InitializeComponent();
        }

        private void AccessDB_Load(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Pemba\BookCSharp.accdb";
            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
            string query = "Select BookKey, Title, Pages, Publisher from Books";
            OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);
            DataTable resultTable = new DataTable();
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
            oleDbDataAdapter.Fill(resultTable);

            dataGridViewBooks.DataSource = resultTable;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Pemba\BookCSharp.accdb";
                OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
                string query = "Insert into Books (BookKey, Title, Pages, Publisher) values (?, ?, ?, ?)";
                OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);

                oleDbCommand.Parameters.AddWithValue("@BookKey", Convert.ToInt32(textBoxBookKey.Text));
                oleDbCommand.Parameters.AddWithValue("@Title", textBoxTitle.Text);
                oleDbCommand.Parameters.AddWithValue("@Pages", Convert.ToInt32(textBoxPages.Text));
                oleDbCommand.Parameters.AddWithValue("@Publisher", textBoxPublisher.Text);

                oleDbConnection.Open();
                oleDbCommand.ExecuteNonQuery();
                oleDbConnection.Close();
                MessageBox.Show("Record inserted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Pemba\BookCSharp.accdb";
                OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
                string query = "Delete From Books where BookKey = ?";
                OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);

                var rowSelected = dataGridViewBooks.Rows[rowSelectedIndex];
                oleDbCommand.Parameters.AddWithValue("@BookKey", rowSelected.Cells["BookKey"].Value.ToString());

                oleDbConnection.Open();
                oleDbCommand.ExecuteNonQuery();
                oleDbConnection.Close();
                MessageBox.Show("Record deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting the record");
            }
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelectedIndex = e.RowIndex;
        }
    }
}
