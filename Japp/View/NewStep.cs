using Japp.Model.Enums;
using Japp.Model;
using Japp.Controller.Actions;
using Japp.Controller.ParameterType;
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
            string action = actionBox.Text;
            string type = parameterTypeBox.Text;
            string text = textBox.Text;
            string parameter = parameterBox.Text;
            string timeStr = timeBox.Text;

            int.TryParse(timeStr, out int time);

            IStep step = new IStep(this._process, name, description, action, type, parameter, text, true, time);
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
            IParameterType parameterType = new ParameterBuild();
            string[] pType = parameterType.IParameterTypeDict.Keys.ToArray();
            foreach (string pt in pType)
            {
                parameterTypeBox.Items.Add(pt);
            }
        }
        private void FillActions()
        {
            IActions actions = new ActionRun();
            string[] actionsList = actions.ActionsDict.Keys.ToArray();

            foreach (string action in actionsList)
            {
                actionBox.Items.Add(action);
            }
        }
    }
}
