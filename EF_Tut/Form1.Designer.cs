namespace EF_Tut
{
    partial class Form1
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.bWriteDB = new System.Windows.Forms.Button();
            this.bReadDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bClearTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(132, 28);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(200, 22);
            this.txt_Name.TabIndex = 0;
            // 
            // txt_Author
            // 
            this.txt_Author.Location = new System.Drawing.Point(132, 90);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(200, 22);
            this.txt_Author.TabIndex = 1;
            // 
            // bWriteDB
            // 
            this.bWriteDB.Location = new System.Drawing.Point(132, 149);
            this.bWriteDB.Name = "bWriteDB";
            this.bWriteDB.Size = new System.Drawing.Size(75, 23);
            this.bWriteDB.TabIndex = 2;
            this.bWriteDB.Text = "Write";
            this.bWriteDB.UseVisualStyleBackColor = true;
            this.bWriteDB.Click += new System.EventHandler(this.bWriteDB_Click);
            // 
            // bReadDB
            // 
            this.bReadDB.Location = new System.Drawing.Point(227, 149);
            this.bReadDB.Name = "bReadDB";
            this.bReadDB.Size = new System.Drawing.Size(75, 23);
            this.bReadDB.TabIndex = 3;
            this.bReadDB.Text = "Read";
            this.bReadDB.UseVisualStyleBackColor = true;
            this.bReadDB.Click += new System.EventHandler(this.bReadDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Book  Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Author  Name";
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(317, 149);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 6;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(420, 149);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 7;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bClearTable
            // 
            this.bClearTable.Location = new System.Drawing.Point(132, 197);
            this.bClearTable.Name = "bClearTable";
            this.bClearTable.Size = new System.Drawing.Size(102, 23);
            this.bClearTable.TabIndex = 8;
            this.bClearTable.Text = "Clear Table";
            this.bClearTable.UseVisualStyleBackColor = true;
            this.bClearTable.Click += new System.EventHandler(this.bClearTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bClearTable);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bReadDB);
            this.Controls.Add(this.bWriteDB);
            this.Controls.Add(this.txt_Author);
            this.Controls.Add(this.txt_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.Button bWriteDB;
        private System.Windows.Forms.Button bReadDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bClearTable;
    }
}

