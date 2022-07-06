using System;

namespace WebPx.AdminLTE.AspNetCore.MVC.Template.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}