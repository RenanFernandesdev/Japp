using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Japp.Model;
using Japp.Controller;

namespace Japp.View
{
    public partial class NewProcess : Form
    {
        public NewProcess()
        {
            InitializeComponent();
        }

        private void saveProcess_Click(object sender, EventArgs e)
        {
            string name = nameProcessBox.Text;
            string description = descriptionProcessBox.Text;

            Process process = new Process(name, description);

            ProcessController.Insert(process);
            MessageBox.Show("Processo salvo com sucesso!");
            this.Close();
        }
    }
}
