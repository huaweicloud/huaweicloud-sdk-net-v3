using System.Net.Http;

namespace HuaweiCloud.SDK.Core
{
    public class DefaultExceptionHandler: IExceptionHandler
    {
        public void HandleException(HttpRequest request, HttpResponseMessage response)
        {
            if ((int)response.StatusCode >= 400)
            {
                throw ExceptionUtils.GetException(response);
            }
        }
    }
}
