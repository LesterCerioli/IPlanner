using System;
using System.Collections.Generic;
using System.Text;

namespace IPlanner.BaselExport.Application.Contracts.RequestResponse
{
    public static class Mapper
    {
        public static BaseelExportResponse ToBaselExportResponse(this BaselExportStatus status)
            => new BaselExportResponse
            {
                Id = status.Id,
                Status = status.Status.ToDescription(),
                FileName = status.FileName
            };
    }
}
