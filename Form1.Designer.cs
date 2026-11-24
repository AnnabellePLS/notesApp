namespace NotesApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            txtMessage = new TextBox();
            dataGridView1 = new DataGridView();
            bttnNew = new Button();
            bttnSave = new Button();
            bttnRead = new Button();
            bttnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 47);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Message";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(85, 44);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(120, 26);
            txtTitle.TabIndex = 2;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(85, 83);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(290, 253);
            txtMessage.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(404, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.Size = new Size(150, 253);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // bttnNew
            // 
            bttnNew.Location = new Point(85, 358);
            bttnNew.Name = "bttnNew";
            bttnNew.Size = new Size(90, 28);
            bttnNew.TabIndex = 5;
            bttnNew.Text = "New";
            bttnNew.UseVisualStyleBackColor = true;
            // 
            // bttnSave
            // 
            bttnSave.Location = new Point(209, 358);
            bttnSave.Name = "bttnSave";
            bttnSave.Size = new Size(90, 28);
            bttnSave.TabIndex = 6;
            bttnSave.Text = "Save";
            bttnSave.UseVisualStyleBackColor = true;
            bttnSave.Click += bttnSave_Click_1;
            // 
            // bttnRead
            // 
            bttnRead.Location = new Point(329, 358);
            bttnRead.Name = "bttnRead";
            bttnRead.Size = new Size(90, 28);
            bttnRead.TabIndex = 7;
            bttnRead.Text = "Read";
            bttnRead.UseVisualStyleBackColor = true;
            bttnRead.Click += bttnRead_Click;
            // 
            // bttnDelete
            // 
            bttnDelete.Location = new Point(453, 358);
            bttnDelete.Name = "bttnDelete";
            bttnDelete.Size = new Size(90, 28);
            bttnDelete.TabIndex = 8;
            bttnDelete.Text = "Delete";
            bttnDelete.UseVisualStyleBackColor = true;
            bttnDelete.Click += bttnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttnDelete);
            Controls.Add(bttnRead);
            Controls.Add(bttnSave);
            Controls.Add(bttnNew);
            Controls.Add(dataGridView1);
            Controls.Add(txtMessage);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private TextBox txtMessage;
        private DataGridView dataGridView1;
        private Button bttnNew;
        private Button bttnSave;
        private Button bttnRead;
        private Button bttnDelete;
    }
}
