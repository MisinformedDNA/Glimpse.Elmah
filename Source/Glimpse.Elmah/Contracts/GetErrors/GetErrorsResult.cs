using System.Collections.Generic;

namespace Glimpse.Elmah.Contracts.GetErrors
{
    public class GetErrorsResult
    {
        public IEnumerable<ErrorModel> Errors { get; set; }
    }
}