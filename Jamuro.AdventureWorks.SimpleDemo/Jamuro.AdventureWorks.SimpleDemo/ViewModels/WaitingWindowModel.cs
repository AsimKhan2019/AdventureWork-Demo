using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jamuro.AdventureWorks.Resources;

namespace Jamuro.AdventureWorks.SimpleDemo.ViewModels
{
    public class WaitingWindowViewModel
    {
        public string Name { set; get; }
        public string Title { set; get; }
        public string Message { set; get; }

        public static WaitingWindowViewModel GetDefaultValues()
        {
            return new WaitingWindowViewModel()
            {
                Name = "waiting-window",
                Title = Labels.ApplicationName,
                Message = Labels.Loading
            };
        }
    }
}