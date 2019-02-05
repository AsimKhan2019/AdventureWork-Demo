using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jamuro.AdventureWorks.Resources;

namespace Jamuro.AdventureWorks.SimpleDemo.ViewModels
{
    public class NotFoundViewModel : ErrorViewModel
    {
        public override string Message()
        {
            return Messages.NotFound_Message;
        }

        public string Url { get; set; }       
    }
}