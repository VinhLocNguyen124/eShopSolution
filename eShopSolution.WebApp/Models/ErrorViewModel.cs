using System;

namespace eShopSolution.WebApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        //Hello hihi haha
   
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
