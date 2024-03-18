namespace NotesApp
{
    partial class frmNotes
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
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNewNote = new System.Windows.Forms.Button();
            this.btnSaveNote = new System.Windows.Forms.Button();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.listViewNotes = new System.Windows.Forms.ListView();
            this.textBoxTimestamp = new System.Windows.Forms.TextBox();
            this.labelLastChanged = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBtn
            // 
            this.panelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtn.Controls.Add(this.btnEdit);
            this.panelBtn.Controls.Add(this.btnNewNote);
            this.panelBtn.Controls.Add(this.btnSaveNote);
            this.panelBtn.Controls.Add(this.btnDeleteNote);
            this.panelBtn.Location = new System.Drawing.Point(0, 382);
            this.panelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(1163, 49);
            this.panelBtn.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(17, 9);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNewNote
            // 
            this.btnNewNote.Location = new System.Drawing.Point(281, 10);
            this.btnNewNote.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(100, 28);
            this.btnNewNote.TabIndex = 3;
            this.btnNewNote.Text = "New";
            this.btnNewNote.UseVisualStyleBackColor = true;
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Location = new System.Drawing.Point(152, 10);
            this.btnSaveNote.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(100, 28);
            this.btnSaveNote.TabIndex = 2;
            this.btnSaveNote.Text = "Save";
            this.btnSaveNote.UseVisualStyleBackColor = true;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Location = new System.Drawing.Point(408, 9);
            this.btnDeleteNote.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(111, 30);
            this.btnDeleteNote.TabIndex = 4;
            this.btnDeleteNote.Text = "Delete";
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxContent.Location = new System.Drawing.Point(608, 128);
            this.richTextBoxContent.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.Size = new System.Drawing.Size(532, 245);
            this.richTextBoxContent.TabIndex = 6;
            this.richTextBoxContent.Text = "";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.Location = new System.Drawing.Point(712, 34);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(428, 22);
            this.textBoxTitle.TabIndex = 5;
            // 
            // listViewNotes
            // 
            this.listViewNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewNotes.GridLines = true;
            this.listViewNotes.HideSelection = false;
            this.listViewNotes.Location = new System.Drawing.Point(0, 34);
            this.listViewNotes.Margin = new System.Windows.Forms.Padding(4);
            this.listViewNotes.Name = "listViewNotes";
            this.listViewNotes.Size = new System.Drawing.Size(597, 339);
            this.listViewNotes.TabIndex = 0;
            this.listViewNotes.UseCompatibleStateImageBehavior = false;
            this.listViewNotes.View = System.Windows.Forms.View.List;
            this.listViewNotes.SelectedIndexChanged += new System.EventHandler(this.listViewNotes_SelectedIndexChanged);
            // 
            // textBoxTimestamp
            // 
            this.textBoxTimestamp.Enabled = false;
            this.textBoxTimestamp.Location = new System.Drawing.Point(712, 69);
            this.textBoxTimestamp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTimestamp.Name = "textBoxTimestamp";
            this.textBoxTimestamp.Size = new System.Drawing.Size(191, 22);
            this.textBoxTimestamp.TabIndex = 5;
            // 
            // labelLastChanged
            // 
            this.labelLastChanged.Location = new System.Drawing.Point(607, 73);
            this.labelLastChanged.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastChanged.Name = "labelLastChanged";
            this.labelLastChanged.Size = new System.Drawing.Size(100, 16);
            this.labelLastChanged.TabIndex = 6;
            this.labelLastChanged.Text = "Last Changed";
            this.labelLastChanged.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(611, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Notes list";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(259, 8);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(122, 22);
            this.textBoxSearch.TabIndex = 10;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search By Title:";
            // 
            // frmNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLastChanged);
            this.Controls.Add(this.textBoxTimestamp);
            this.Controls.Add(this.listViewNotes);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.richTextBoxContent);
            this.Controls.Add(this.panelBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNotes";
            this.Text = "Notes Application";
            this.Load += new System.EventHandler(this.frmNotes_Load);
            this.Resize += new System.EventHandler(this.frmNotes_Resize);
            this.panelBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.RichTextBox richTextBoxContent;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ListView listViewNotes;
        private System.Windows.Forms.Button btnDeleteNote;
        private System.Windows.Forms.Button btnSaveNote;
        private System.Windows.Forms.Button btnNewNote;
        private System.Windows.Forms.TextBox textBoxTimestamp;
        private System.Windows.Forms.Label labelLastChanged;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label4;
    }
}

