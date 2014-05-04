using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WeeMouse
{
    public partial class Service1 : ServiceBase
    {
        WeeForm Form;

        public Service1()
        {
            InitializeComponent();
            Form = new WeeForm();
        }

        public void StartDebug(string[] args)
        {
            OnStart(args);
        }

        public void StopDebug()
        {
            OnStop();
        }

        protected override void OnStart(string[] args)
        {
            Form.Start();
        }

        protected override void OnStop()
        {
            Form.Stop();
        }
    }
}
