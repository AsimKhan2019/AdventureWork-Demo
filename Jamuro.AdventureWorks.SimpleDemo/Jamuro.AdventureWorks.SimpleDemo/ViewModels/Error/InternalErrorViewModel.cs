using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jamuro.AdventureWorks.Resources;

namespace Jamuro.AdventureWorks.SimpleDemo.ViewModels
{
    public class InternalErrorViewModel : ErrorViewModel
    {
        public override string Message()
        {
            return Messages.InternalError_Message;
        }

        public string Url { get; set; }       
    }
}