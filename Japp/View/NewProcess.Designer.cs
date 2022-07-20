namespace Japp.View
{
    partial class NewProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProcess));
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.descriptionProcessBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameProcessBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.saveProcess);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 60);
            this.panel1.TabIndex = 0;
            // 
            // saveProcess
            // 
            this.saveProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.saveProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.saveProcess.Image = ((System.Drawing.Image)(resources.GetObject("saveProcess.Image")));
            this.saveProcess.Location = new System.Drawing.Point(286, 3);
            this.saveProcess.Name = "saveProcess";
            this.saveProcess.Size = new System.Drawing.Size(72, 54);
            this.saveProcess.TabIndex = 1;
            this.saveProcess.UseVisualStyleBackColor = false;
            this.saveProcess.Click += new System.EventHandler(this.saveProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo processo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.descriptionProcessBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nameProcessBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(2, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 226);
            this.panel2.TabIndex = 1;
            // 
            // descriptionProcessBox
            // 
            this.descriptionProcessBox.Location = new System.Drawing.Point(10, 103);
            this.descriptionProcessBox.Multiline = true;
            this.descriptionProcessBox.Name = "descriptionProcessBox";
            this.descriptionProcessBox.Size = new System.Drawing.Size(342, 110);
            this.descriptionProcessBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // nameProcessBox
            // 
            this.nameProcessBox.Location = new System.Drawing.Point(10, 37);
            this.nameProcessBox.Name = "nameProcessBox";
            this.nameProcessBox.Size = new System.Drawing.Size(342, 23);
            this.nameProcessBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // NewProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 297);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NewProcess";
            this.Text = "NewProcess";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button saveProcess;
        private Label label1;
        private Panel panel2;
        private TextBox nameProcessBox;
        private Label label2;
        private TextBox descriptionProcessBox;
        private Label label3;
    }
}