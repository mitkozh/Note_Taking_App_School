using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class frmNotes : Form
    {
        private const string ConnectionString = @"Data Source=DESKTOP-JU1TVUL;Initial Catalog=NoteDB;Integrated Security=True"; 

        public frmNotes()
        {
            InitializeComponent();
        }

        private void frmNotes_Load(object sender, EventArgs e)
        {
            // Load existing notes from the database and populate the ListView
            LoadNotes();
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            int id = currentNoteId;
            if (id != constNewNoteId)
            {
                textBoxTitle.Text = "";
                textBoxTimestamp.Text = DateTime.Now.ToString();
                richTextBoxContent.Text = "";

                ListViewItem item = new ListViewItem("-- New note --");
                item.SubItems.Add("");
                item.Tag = constNewNoteId;
                listViewNotes.Items.Add(item);
                listViewNotes.SelectedItems.Clear();
                listViewNotes.Refresh();

                item.Selected = true;

                // Clear the RichTextBox to create a new note
                richTextBoxContent.Clear();
            
                setStatus();
            }
            else
            {
                MessageBox.Show("You have pressed already the New button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            // Save the note to the database
            string title = textBoxTitle.Text.Trim();
            string content = richTextBoxContent.Text.Trim();

            int noteID = currentNoteId;

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(content))
            {
                // Insert the note into the database
                using (System.Data.SqlClient.SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    if (noteID == constNewNoteId)
                    {
                        string insertQuery = "INSERT INTO Notes (Title, Content, Timestamp) VALUES (@Title, @Content, @Timestamp)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@Title", title);
                            cmd.Parameters.AddWithValue("@Content", content);
                            cmd.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    } else
                    {
                        string insertQuery = "update Notes Set Title=@Title, Content=@Content, Timestamp=@Timestamp Where NoteId=@NoteId";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@NoteId", noteID);
                            cmd.Parameters.AddWithValue("@Title", title);
                            cmd.Parameters.AddWithValue("@Content", content);
                            cmd.Parameters.AddWithValue("@Timestamp", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                // Refresh the ListView
                LoadNotes();
            }
            else
            {
                MessageBox.Show("Please enter both a title and content for the note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            // Delete the selected note from the database
            if (listViewNotes.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Do you wantto delete the note?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int noteID = currentNoteId;
                    if (noteID != constNewNoteId)
                    {
                        using (System.Data.SqlClient.SqlConnection connection = new SqlConnection(ConnectionString))
                        {
                            connection.Open();
                            string deleteQuery = "DELETE FROM Notes WHERE NoteID = @NoteID";
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@NoteID", noteID);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // Refresh the ListView
                    LoadNotes();
                }
            }
            else
            {
                MessageBox.Show("Please select a note to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;

        }

        private void listViewNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                int noteID = currentNoteId;
                if (noteID != constNewNoteId)
                {
                    string selectQuery = "SELECT Content, Title, Timestamp FROM Notes Where NoteId=@NoteId";
                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@NoteId", noteID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                textBoxTitle.Text = reader["Title"].ToString();
                                richTextBoxContent.Text = reader["Content"].ToString();
                                textBoxTimestamp.Text = reader["Timestamp"].ToString();
                            }
                        }
                    }
                }
                else
                {
                    ClearDetails();
                }
            }
        }

        private void LoadNotes()
        {
            ClearDetails();

            // Load notes from the database and populate the ListView
            listViewNotes.SelectedItems.Clear();
            listViewNotes.Items.Clear();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                
                string selectQuery = "SELECT NoteID, Title, Timestamp FROM Notes";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Title"].ToString());
                            item.SubItems.Add(reader["Timestamp"].ToString());
                            item.Tag = reader["NoteID"];
                            listViewNotes.Items.Add(item);
                        }
                        if (listViewNotes.Items.Count > 0)
                        {
                            listViewNotes.Items[0].Selected = true;
                        }
                    }
                }
            }

            isEdit = false;
            setStatus();
        }

        private void ClearDetails()
        {
            textBoxTitle.Text = textBoxTitle.Text.Trim();
            richTextBoxContent.Text = richTextBoxContent.Text.Trim(); 
        }

        private void ClearAllDetails() 
        {
            textBoxTitle.Text = "";
            richTextBoxContent.Text = "";
        }

        private int currentNoteId
        {
            get
            {
                int id = constNewNoteId;
                if (listViewNotes.SelectedItems.Count>0)
                {
                    id = Convert.ToInt32(listViewNotes.SelectedItems[0].Tag);
                }
                return id;
            }
        }

        const int constNewNoteId = -1;
        private bool isNewNote
        {
            get
            {
                return currentNoteId == constNewNoteId;
            }
        }

        private bool _isEdit;
        private bool isEdit
        {
            get
            {
                return _isEdit;
            }
            set
            {
                if (_isEdit != value)
                {
                    _isEdit = value;
                    setStatus();
                }
            }
        }
        private void setStatus()
        {
            bool isNew = isNewNote;
            listViewNotes.Enabled = !isEdit && !isNew;
            richTextBoxContent.Enabled = textBoxTitle.Enabled = isEdit || isNew;
            btnSaveNote.Enabled = isEdit || isNew;
            btnNewNote.Enabled = !isNew && !isEdit;
            btnEdit.Enabled = listViewNotes.SelectedItems.Count > 0 && !isNew && !isEdit; 
            btnDeleteNote.Enabled = listViewNotes.SelectedItems.Count > 0;
        }

        private void frmNotes_Resize(object sender, EventArgs e)
        {
            try
            {
                Form me = (Form)sender;
                if (me.WindowState != FormWindowState.Minimized)
                {
                    if (me.Width < listViewNotes.Width * 2)
                    {
                        me.Width = listViewNotes.Width * 2;
                    }
                    if (me.Height < 300)
                    {
                        me.Height = 300;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void SearchNotes(string query)
        {
            listViewNotes.Items.Clear();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string selectQuery = "SELECT NoteID, Title, Timestamp FROM Notes WHERE Title LIKE @Query OR Content LIKE @Query";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Query", $"%{query}%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Title"].ToString());
                            item.SubItems.Add(reader["Timestamp"].ToString());
                            item.Tag = reader["NoteID"];
                            listViewNotes.Items.Add(item);
                        }
                        if (listViewNotes.Items.Count > 0)
                        {
                            listViewNotes.Items[0].Selected = true;
                        }
                    }
                }
            }

            if (listViewNotes.Items.Count == 0)
            {
                ClearAllDetails();
            }

            setStatus();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchNotes(textBoxSearch.Text.Trim());
        }
    }
}

