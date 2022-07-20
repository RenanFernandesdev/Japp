using Japp.View;

namespace Japp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void newProcess_Click(object sender, EventArgs e)
        {
            NewProcess np = new NewProcess();
            np.Show();
        }

        private void newStep_Click(object sender, EventArgs e)
        {
            NewStep nt = new NewStep();
            nt.SetProcess(_currentProcess.GetId());
            nt.Show();
        }

        private void processList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCurrentProcess(processList.SelectedIndex);
            LoadSteps(_currentProcess.GetId());
        }
    }
}