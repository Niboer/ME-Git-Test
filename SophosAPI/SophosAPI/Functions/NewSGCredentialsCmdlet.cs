using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;

namespace SophosAPI.Functions
{
    [Cmdlet(VerbsCommon.New, "SGCredentials")]
    [OutputType(typeof(SGCredentials))]
    public class NewSGCredentialsCmdlet : Cmdlet
    {
        
    }
}
