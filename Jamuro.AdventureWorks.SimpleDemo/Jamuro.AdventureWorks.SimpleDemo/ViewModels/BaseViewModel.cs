using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jamuro.AdventureWorks.Resources;

namespace Jamuro.AdventureWorks.SimpleDemo.ViewModels
{
    public abstract class BaseViewModel
    {
        public virtual string Title()
        {
            return Labels.ApplicationName;
        }
    }
}