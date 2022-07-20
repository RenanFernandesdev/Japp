using Japp.Model.Enums;

namespace Japp.Model
{
    class IStep
    {
        private int _id;
        private int _idProcess;
        private string _name;
        private string _description;
        private Actions _action;
        private Parameters _parameterType;
        private string _parameter;
        private string _text;
        private bool _status;
        private int _time;

        public IStep(int idProcess, string name, string description, Actions action, Parameters parameterType, string parameter, string text, bool status, int time)
        {
            _idProcess = idProcess;
            _name = name;
            _description = description;
            _action = action;
            _parameterType = parameterType;
            _parameter = parameter;
            _text = text;
            _status = status;
            _time = time;
        }

        public IStep(int id,int idProcess, string name, string description, Actions action, Parameters parameterType, string parameter, string text, bool status, int time)
        {
            _id = id;
            _idProcess = idProcess;
            _name = name;
            _description = description;
            _action = action;
            _parameterType = parameterType;
            _parameter = parameter;
            _text = text;
            _status = status;
            _time = time;
        }

        //Getters
        public int GetId() { return _id; }
        public int GetIdProcess() { return _idProcess; }
        public string GetName() { return _name; }
        public string GetDescription() { return _description; }
        public Actions GetActions() { return _action; }
        public Parameters GetParameterType() { return _parameterType; }
        public string GetParameter() { return _parameter; }
        public string GetText() { return _text; }
        public bool IsStatus() { return _status; }
        public int GetTime() { return _time; }

        //Setters
        public void SetId(int id) { _id = id; }
        public void SetIdProcess(int idProcess) { _idProcess = idProcess; }
        public void SetName(string name) { _name = name; }
        public void SetDescription(string description) { _description = description; }
        public void SetActions(Actions actions) { _action = actions; }
        public void SetParameterType(Parameters parameters) { _parameterType = parameters; }
        public void SetParameter(string parameter) { _parameter = parameter; }
        public void SetText(string text) { _text = text; }
        public void SetStatus(bool status) { _status = status; }
        public void SetTime(int time) { _time = time; }
    }
}
