using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IPlanner.BaselExport.Application.Contracts.Interfaces
{
    public interface IBaselAppService : IDisposable
    {
        Task<ResponseMessage<BaselExportResponse>> ExportAsync();
    }
}
