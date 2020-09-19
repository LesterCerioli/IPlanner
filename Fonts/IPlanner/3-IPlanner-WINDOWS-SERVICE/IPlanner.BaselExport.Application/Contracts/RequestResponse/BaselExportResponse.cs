using System;
using System.Collections.Generic;
using System.Text;

namespace IPlanner.BaselExport.Application.Contracts.RequestResponse
{
    public sealed class BaselExportResponse
    {
        public stringId MyProperty { get; set; }
        public string Status { get; set; }
        public string FileName { get; set; }
    }
}
