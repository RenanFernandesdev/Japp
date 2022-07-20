using Japp.Model.Enums;


namespace Japp.View
{
    partial class NewStep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewStep));
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveStep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.descriptionStepBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameStepBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.parameterBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.parameterTypeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.actionBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.saveStep);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 60);
            this.panel1.TabIndex = 0;
            // 
            // saveStep
            // 
            this.saveStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.saveStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.saveStep.Image = ((System.Drawing.Image)(resources.GetObject("saveStep.Image")));
            this.saveStep.Location = new System.Drawing.Point(287, 3);
            this.saveStep.Name = "saveStep";
            this.saveStep.Size = new System.Drawing.Size(72, 54);
            this.saveStep.TabIndex = 3;
            this.saveStep.UseVisualStyleBackColor = false;
            this.saveStep.Click += new System.EventHandler(this.saveStep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Novo step";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.descriptionStepBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nameStepBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(2, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 187);
            this.panel2.TabIndex = 1;
            // 
            // descriptionStepBox
            // 
            this.descriptionStepBox.Location = new System.Drawing.Point(10, 95);
            this.descriptionStepBox.Multiline = true;
            this.descriptionStepBox.Name = "descriptionStepBox";
            this.descriptionStepBox.Size = new System.Drawing.Size(342, 65);
            this.descriptionStepBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição";
            // 
            // nameStepBox
            // 
            this.nameStepBox.Location = new System.Drawing.Point(10, 38);
            this.nameStepBox.Name = "nameStepBox";
            this.nameStepBox.Size = new System.Drawing.Size(342, 23);
            this.nameStepBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.timeBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.parameterBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.parameterTypeBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.actionBox);
            this.panel3.Location = new System.Drawing.Point(2, 261);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 272);
            this.panel3.TabIndex = 2;
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(10, 223);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(342, 23);
            this.timeBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(10, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tempo (em milissegundos)";
            // 
            // parameterBox
            // 
            this.parameterBox.Location = new System.Drawing.Point(10, 157);
            this.parameterBox.Name = "parameterBox";
            this.parameterBox.Size = new System.Drawing.Size(342, 23);
            this.parameterBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(10, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Parametro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo do parametro";
            // 
            // parameterTypeBox
            // 
            this.parameterTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parameterTypeBox.FormattingEnabled = true;
            this.parameterTypeBox.Location = new System.Drawing.Point(10, 96);
            this.parameterTypeBox.Name = "parameterTypeBox";
            this.parameterTypeBox.Size = new System.Drawing.Size(342, 23);
            this.parameterTypeBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ação";
            // 
            // actionBox
            // 
            this.actionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionBox.FormattingEnabled = true;
            this.actionBox.Location = new System.Drawing.Point(10, 37);
            this.actionBox.Name = "actionBox";
            this.actionBox.Size = new System.Drawing.Size(342, 23);
            this.actionBox.TabIndex = 0;
            // 
            // NewStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 536);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NewStep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewStep";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewStep_FormClosing);
            this.Load += new System.EventHandler(this.NewStep_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        

        private Panel panel1;
        private Button saveStep;
        private Label label1;
        private Panel panel2;
        private TextBox descriptionStepBox;
        private Label label3;
        private TextBox nameStepBox;
        private Label label2;
        private Panel panel3;
        private Label label4;
        private ComboBox actionBox;
        private Label label5;
        private ComboBox parameterTypeBox;
        private TextBox parameterBox;
        private Label label6;
        private TextBox timeBox;
        private Label label7;
    }
}