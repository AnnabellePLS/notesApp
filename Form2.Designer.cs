namespace NotesApp
{
    partial class Form2
    {
      
        private System.ComponentModel.IContainer components = null;

       
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

    
        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            txtMessage = new TextBox();
            bttnClose = new Button();
            SuspendLayout();
           
            txtTitle.Location = new Point(12, 30);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(120, 26);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Title";
            txtTitle.TextChanged += textBox1_TextChanged;
          
            txtMessage.Location = new Point(12, 80);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(287, 174);
            txtMessage.TabIndex = 1;
            txtMessage.Text = "Message";
           
            bttnClose.Location = new Point(12, 260);
            bttnClose.Name = "bttnClose";
            bttnClose.Size = new Size(90, 28);
            bttnClose.TabIndex = 2;
            bttnClose.Text = "Close";
            bttnClose.UseVisualStyleBackColor = true;
            bttnClose.Click += bttnClose_Click;
           
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttnClose);
            Controls.Add(txtMessage);
            Controls.Add(txtTitle);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtMessage;
        private Button bttnClose;
    }
}