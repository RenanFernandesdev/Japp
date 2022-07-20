using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Japp.Model.Enums;
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

        private void saveStep_Click(object sender, EventArgs e)
        {
            string name = nameStepBox.Text;
            string description = descriptionStepBox.Text;
            string actionStr = actionBox.Text;
            string typeStr = parameterTypeBox.Text;
            string parameter = parameterBox.Text;
            string timeStr = timeBox.Text;

            int.TryParse(actionStr, out int action);
            int.TryParse(typeStr, out int type);
            int.TryParse(timeStr, out int time);

            IStep step = new IStep(this._process, name, description, (Actions) action, (Parameters) type, parameter, "", true, time);
            StepController.Insert(step);
            MessageBox.Show("Step salvo com sucesso!");
            this.Close();
        }

        public void SetProcess(int idProcess)
        {
            _process = idProcess;
        }
    }
}
