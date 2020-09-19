using IPlanner.BaselExport.Application.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace IPlanner.BaselExport.Application.Implementation
{
    public class BaselAppService : DisposableObject, IBaselAppService
    {
        private static DateTimeOffset? _lastHealthcheck;
        private static readonly XmlObjectSerializer _healthCheckSyncRoot;
        
        
        
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<ResponseMessage<BaselExportResponse>> ExportAsync()
        {
            throw new NotImplementedException();
        }
    }
}
