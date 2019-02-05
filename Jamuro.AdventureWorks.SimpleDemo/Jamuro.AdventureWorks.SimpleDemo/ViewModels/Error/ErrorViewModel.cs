using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jamuro.AdventureWorks.Resources;

namespace Jamuro.AdventureWorks.SimpleDemo.ViewModels
{
    public class ErrorViewModel : BaseViewModel
    {
        public string SomethingWasWrong = ErrorMessages.Error_SomethingWasWrong;
        public string LinkToHome = Messages.LinkToHome_Message;
        public string ImageErrorController = "Error";
        public string ImageErrorMethod = "GetErrorImage";

        public override string Title()
        {
            return ErrorMessages.Error_Title;
        }

        public virtual string Message()
        {
            return ErrorMessages.Error_Message;
        }

    }
}