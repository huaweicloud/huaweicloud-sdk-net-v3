using System.Net.Http;

namespace HuaweiCloud.SDK.Core
{
    public interface IExceptionHandler
    {
        void HandleException(HttpRequest request, HttpResponseMessage response);
    }
}
