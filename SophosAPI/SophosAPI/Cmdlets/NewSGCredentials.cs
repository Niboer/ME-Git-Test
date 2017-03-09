using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using SophosAPI.Classes;

namespace SophosAPI.Functions
{
    [Cmdlet(VerbsCommon.New, "SGCredentials")]
    [OutputType(typeof(SGCredentials))]
    public class NewSGCredentials : Cmdlet
    {
        [Parameter(Position = 0,
            Mandatory = true,
            ParameterSetName = "Clear",
            HelpMessage = "Username for logon on Webadmin.")]
        public string Username { get; set; }

        [Parameter(Position = 1,
            Mandatory = true,
            ParameterSetName = "Clear",
            HelpMessage = "Password for User.")]
        public string Password { get; set; }

        [Parameter(Position = 2,
            Mandatory = true,
            ParameterSetName = "Clear",
            HelpMessage = "Hostname or IP-Adress wich the Webadmin listens on.")]
        public string Hostname { get; set; }

        [Parameter(Position = 3,
            Mandatory = false,
            ParameterSetName = "Clear",
            HelpMessage = "Port wich the Webadmin listens on.")]
        public UInt16 Port { get; set; } = 4444;

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            WriteObject(new SGCredentials(this.Username,this.Password,this.Hostname,this.Port));
        }
    }
}
