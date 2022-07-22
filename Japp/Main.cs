using Japp.Controller;
using Japp.Model;
using Japp.Model.Enums;
using Japp.View;
using System.Data;

namespace Japp
{
    public partial class Main : Form
    {
        private List<Process>? _process = null;
        private List<IStep>? _steps = null;
        private Process? _currentProcess = null;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitComponents();

            LoadProcess();
            FillListProcess();
            SetCurrentProcess(0);
            if (_currentProcess != null)
            {
                LoadSteps(_currentProcess.GetId());
            }
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

        
        
        private void InitComponents()
        {
            _process = new List<Process>();
            _steps = new List<IStep>();
        }
        public void LoadProcess()
        {
            _process.Clear();
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
            processList.Items.Clear();
            if (_process.Count != 0)
            {
                foreach (Process process in _process)
                {
                    processList.Items.Add(process.GetName());
                }
            }
        }
        private void SetCurrentProcess(int index)
        {
            if (index < 0)
            {
                index = 0;
                processList.SelectedValue = processList.Items[index];
            }
            if (_process.Count > 0)
            {
                _currentProcess = _process[index];
                descriptionLabel.Text = _currentProcess.GetDescription();
            }
        }

        public void LoadSteps(int idProcess)
        {
            _steps.Clear();
            if (_process.Count != 0 && _currentProcess != null)
            {
                using (DataTable dt = StepController.Select(idProcess))
                {

                    gridSteps.DataSource = dt;
                    ConfigGrid();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string? idStr = dt.Rows[i][0].ToString(); //CC
                                                                 //idProcess
                        string? name = dt.Rows[i][2].ToString();
                        string? description = dt.Rows[i][3].ToString();
                        string? action = dt.Rows[i][4].ToString(); //CC
                        string? parameterType = dt.Rows[i][5].ToString(); //CC
                        string? parameter = dt.Rows[i][6].ToString();
                        string? text = dt.Rows[i][7].ToString();
                        string? statusStr = dt.Rows[i][8].ToString(); //CC
                        string? timeStr = dt.Rows[i][9].ToString(); //CC

                        int.TryParse(idStr, out int id);
                        bool.TryParse(statusStr, out bool status);
                        int.TryParse(timeStr, out int time);

                        IStep step = new IStep(id, idProcess, name, description, action, parameterType, parameter, text, status, time);
                        _steps.Add(step);
                    }
                    _currentProcess.SetSteps(_steps);
                }
            }
        }
        public void ConfigGrid()
        {
            for(int i = 0; i < 9; i++)
            {
                switch (i)
                {
                    case 0:
                    case 1:
                        gridSteps.Columns[i].Visible = false; 
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 8:
                        gridSteps.Columns[i].ReadOnly = true;
                        break;
                }
            }
        }

        private void executeProcess_Click(object sender, EventArgs e)
        {
            ProcessController.Execute(_currentProcess);
        }
    }
}