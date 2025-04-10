using System.Linq;
using System.Net.Http;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3
{
    public class CceExceptionHandler : IExceptionHandler
    {
        public void HandleException(HttpRequest request, HttpResponseMessage response)
        {
            if ((int)response.StatusCode < 400)
            {
                return;
            }

            var errorInfo = JsonUtils.DeSerializeMap<string, object>(response);
            var sdkError = new SdkError();
            if (response.Headers.TryGetValues("X-Request-Id", out var requestId))
            {
                sdkError.RequestId = requestId.FirstOrDefault();
            }

            // error_code
            if (errorInfo.TryGetValue("error_code", out var errorCode) && errorCode != null &&
                !errorCode.ToString().Equals(""))
            {
                sdkError.ErrorCode = errorCode.ToString();
            }
            else if (errorInfo.TryGetValue("errorCode", out errorCode) && errorCode != null)
            {
                sdkError.ErrorCode = errorCode.ToString();
            }

            // error_message
            if (errorInfo.TryGetValue("error_msg", out var errorMsg) && errorMsg != null &&
                !errorMsg.ToString().Equals(""))
            {
                sdkError.ErrorMsg = errorMsg.ToString();
            }
            else if (errorInfo.TryGetValue("errorMessage", out errorMsg) && errorMsg != null)
            {
                sdkError.ErrorMsg = errorMsg.ToString();
            }

            if (errorInfo.TryGetValue("message", out var message) && message != null && !message.ToString().Equals(""))
            {
                if (sdkError.ErrorMsg.Equals(""))
                {
                    sdkError.ErrorMsg = message.ToString();
                }
                else
                {
                    sdkError.ErrorMsg += ", " + message;
                }
            }

            // encoded_authorization_message
            if (errorInfo.TryGetValue("encoded_authorization_message", out var authMsg) && authMsg != null)
            {
                sdkError.ErrorMsg = authMsg.ToString();
            }

            throw ServiceResponseException.MapException((int)response.StatusCode, sdkError);
        }
    }
}