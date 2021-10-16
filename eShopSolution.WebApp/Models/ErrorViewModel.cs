using System;

namespace eShopSolution.WebApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public int MyProperty { get; set; }
        //Hello edit Model
        //Hello edit Model from local repository

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
