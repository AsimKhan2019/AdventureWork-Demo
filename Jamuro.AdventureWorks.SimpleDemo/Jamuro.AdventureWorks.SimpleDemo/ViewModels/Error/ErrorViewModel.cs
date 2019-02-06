using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jamuro.AdventureWorks.Resources;

namespace Jamuro.AdventureWorks.SimpleDemo.ViewModels
{
    public class ErrorViewModel : BaseViewModel
    {
        private readonly string m_somethingWasWrong = ErrorMessages.Error_SomethingWasWrong;
        private readonly string m_linkToHome = Messages.LinkToHome_Message;
        private readonly string m_imageErrorController = "Error";
        private readonly string m_imageErrorMethod = "GetErrorImage";

        public string ImageErrorMethod
        {
            get
            {
                return m_imageErrorMethod;
            }
        }

        public string ImageErrorController
        {
            get
            {
                return m_imageErrorController;
            }
        }

        public string LinkToHome
        {
            get
            {
                return m_linkToHome;
            }
        }

        public string SomethingWasWrong
        {
            get
            {
                return m_somethingWasWrong;
            }
        }

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