using Japp.Model;
using System.Data;
using Japp.Controller;
using MySql.Data.MySqlClient;
using Japp.Model.Enums;

namespace Japp
{
    partial class Main
    {
        private List<Process> _process;
        private List<IStep> _steps;
        private Process _currentProcess;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel2 = new System.Windows.Forms.Panel();
            this.processList = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.newProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridSteps = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.newStep = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSteps)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.processList);
            this.panel2.Location = new System.Drawing.Point(12, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 489);
            this.panel2.TabIndex = 1;
            // 
            // processList
            // 
            this.processList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.processList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.processList.FormattingEnabled = true;
            this.processList.ItemHeight = 21;
            this.processList.Location = new System.Drawing.Point(3, 3);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(199, 483);
            this.processList.TabIndex = 1;
            this.processList.SelectedIndexChanged += new System.EventHandler(this.processList_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.newProcess);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 63);
            this.panel4.TabIndex = 0;
            // 
            // newProcess
            // 
            this.newProcess.BackColor = System.Drawing.Color.White;
            this.newProcess.Image = ((System.Drawing.Image)(resources.GetObject("newProcess.Image")));
            this.newProcess.Location = new System.Drawing.Point(135, 3);
            this.newProcess.Name = "newProcess";
            this.newProcess.Size = new System.Drawing.Size(59, 55);
            this.newProcess.TabIndex = 1;
            this.newProcess.UseVisualStyleBackColor = false;
            this.newProcess.Click += new System.EventHandler(this.newProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(-1, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo processo";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.gridSteps);
            this.panel3.Location = new System.Drawing.Point(220, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 489);
            this.panel3.TabIndex = 2;
            // 
            // gridSteps
            // 
            this.gridSteps.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSteps.Location = new System.Drawing.Point(7, 10);
            this.gridSteps.Name = "gridSteps";
            this.gridSteps.RowTemplate.Height = 25;
            this.gridSteps.Size = new System.Drawing.Size(594, 468);
            this.gridSteps.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.newStep);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(602, 63);
            this.panel5.TabIndex = 2;
            // 
            // newStep
            // 
            this.newStep.BackColor = System.Drawing.Color.White;
            this.newStep.Image = ((System.Drawing.Image)(resources.GetObject("newStep.Image")));
            this.newStep.Location = new System.Drawing.Point(538, 3);
            this.newStep.Name = "newStep";
            this.newStep.Size = new System.Drawing.Size(59, 55);
            this.newStep.TabIndex = 2;
            this.newStep.UseVisualStyleBackColor = false;
            this.newStep.Click += new System.EventHandler(this.newStep_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Novo passo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 98);
            this.panel1.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(220, 106);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(608, 69);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Location = new System.Drawing.Point(12, 106);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(205, 68);
            this.panel7.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 683);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Main";
            this.Text = "Main";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSteps)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            InitComponents();
            LoadProcess();
            FillListProcess();
            SetCurrentProcess(0);
            LoadSteps(_currentProcess.GetId());
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private ListBox processList;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Label label2;
        private Button newStep;
        private Panel panel6;
        private Panel panel7;
        private Button newProcess;

        private void InitComponents()
        {
            _process = new List<Process>();
            _steps = new List<IStep>();
        }

        private void LoadProcess()
        {
            using (DataTable dt = ProcessController.Select())
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string idStr = dt.Rows[i][0].ToString();
                    string name = dt.Rows[i][1].ToString();
                    string description = dt.Rows[i][2].ToString();
                    string statusStr = dt.Rows[i][3].ToString();

                    int.TryParse(idStr, out int id);
                    bool.TryParse(statusStr, out bool status);

                    _process.Add(new Process(id, name, description, status));
                }
            }
        }

        private void FillListProcess()
        {
            foreach (Process process in _process)
            {
                processList.Items.Add(process.GetName());
            }
        }

        private void SetCurrentProcess(int index)
        {
            if (index < 0) 
            {
                index = 0;
                processList.SelectedValue = processList.Items[index];
            }
            _currentProcess = _process[index];
        }

        private void LoadSteps(int idProcess)
        {
            using(DataTable dt = StepController.Select(idProcess))
            {
                
                gridSteps.DataSource = dt;
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    string idStr = dt.Rows[i][0].ToString(); //CC
                    //idProcess
                    string name = dt.Rows[i][2].ToString();
                    string description = dt.Rows[i][3].ToString();
                    string actionStr = dt.Rows[i][4].ToString(); //CC
                    string parameterTypeStr = dt.Rows[i][5].ToString(); //CC
                    string parameter = dt.Rows[i][6].ToString();
                    string statusStr = dt.Rows[i][7].ToString(); //CC
                    string timeStr = dt.Rows[i][8].ToString(); //CC

                    int.TryParse(idStr, out int id);
                    int.TryParse(actionStr, out int action);
                    int.TryParse(parameterTypeStr, out int parameterType);
                    bool.TryParse(statusStr, out bool status);
                    int.TryParse(timeStr, out int time);

                    IStep step = new IStep(id,idProcess,name,description,(Actions) action,(Parameters) parameterType,parameter,string.Empty,status,time);
                    _steps.Add(step);
                }
            }
        }

        private DataGridView gridSteps;
    }
}