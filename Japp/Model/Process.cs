using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Japp.Model
{
    internal class Process
    {
        private int _id;
        private string _name;
        private string _description;
        private bool _status;

        private List<IStep> _steps = new List<IStep>();

        public Process(string name, string description)
        {
            _name = name;
            _description = description;
            _status = true;
        }

        public Process(int id, string name, string description, bool status)
        {
            _id = id;
            _name = name;
            _description = description;
            _status = status;
        }

        public void AddStep(IStep step)
        {
            _steps.Add(step);
        }

        //Getters
        public int GetId() { return _id; }
        public string GetName() { return _name; }
        public string GetDescription() { return _description; }
        public bool IsStatus() { return _status; }
        public List<IStep> GetSteps() { return _steps; }
        public IStep GetStepAt(int index) { return _steps[index]; }

        //Setters
        public void SetId(int id) { _id = id; }
        public void SetName(string name) { _name = name; }
        public void SetDescription(string description) { _description = description; }
        public void SetStatus(bool status) { _status = status; }
        public void SetSteps(List<IStep> steps) { _steps = steps; }
        public void SetStepsAt(int index, IStep step) { _steps[index] = step; }

        public override string ToString()
        {
            return _name;
        }
    }
}
