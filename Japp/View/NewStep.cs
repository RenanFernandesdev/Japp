﻿using Japp.Model.Enums;
using Japp.Model;
using Japp.Controller;

namespace Japp.View
{
    public partial class NewStep : Form
    {
        private int _process;

        public NewStep()
        {
            InitializeComponent();

        }

        private void NewStep_Load(object sender, EventArgs e)
        {
            FillParameterType();
            FillActions();
        }

        private void saveStep_Click(object sender, EventArgs e)
        {
            string name = nameStepBox.Text;
            string description = descriptionStepBox.Text;
            string actionStr = actionBox.Text;
            string typeStr = parameterTypeBox.Text;
            string text = textBox.Text;
            string parameter = parameterBox.Text;
            string timeStr = timeBox.Text;

            int.TryParse(timeStr, out int time);

            Actions action = (Actions) Enum.Parse(typeof(Actions), actionStr);
            Parameters type = (Parameters)Enum.Parse(typeof(Parameters), typeStr);

            IStep step = new IStep(this._process, name, description, action,type, parameter, text, true, time);
            StepController.Insert(step);
            MessageBox.Show("Step salvo com sucesso!");
            this.Close();
        }

        public void SetProcess(int idProcess)
        {
            _process = idProcess;
        }

        private void FillParameterType()
        {
            string[] actions = Enum.GetNames(typeof(Parameters));
            foreach (string action in actions)
            {
                parameterTypeBox.Items.Add(action);
            }
        }

        private void FillActions()
        {
            string[] actions = Enum.GetNames(typeof(Actions));
            foreach (string action in actions)
            {
                actionBox.Items.Add(action);
            }
        }

        private void NewStep_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
