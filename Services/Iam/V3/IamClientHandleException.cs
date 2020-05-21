using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Iam.V3.Model;

namespace HuaweiCloud.SDK.Iam.V3
{
    public partial class IamClient
    {
        protected override SdkError HandleServiceSpecException(SdkResponse response)
        {
            IamException exception = JsonUtils.DeSerialize<IamException>(response);

            //服务根据不同场景修改以下判断条件
            if (!string.IsNullOrEmpty(exception.Code)  && !string.IsNullOrEmpty(exception.Message) )
            {
                return new SdkError(exception.Code, exception.Message);
            }

            return new SdkError(response.GetHttpBody());
        }
    }
}