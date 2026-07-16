using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CreateInferServiceRequest 
    {

        /// <summary>
        /// **参数解释：** 服务提供者的domain级或project级Token，创建服务携带该请求头时，系统将解析该token并将账号id保存为服务的提供者即provider，该服务将被系统保护，仅携带该提供者的domain级或project级Token的更新操作允许执行。[通过调用IAM服务获取用户Token接口获取响应消息头中X-Subject-Token的值。](tag:hws,hws_hk)获取方法请参见[[获取IAM用户Token（使用密码）](modelarts_03_0004.xml)](tag:hws,hws_hk)[[获取Token](modelarts_03_0015.xml)](tag:hcs,hcs_sm)。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("X-Auth-Token-Provider", IsHeader = true)]
        [JsonProperty("X-Auth-Token-Provider", NullValueHandling = NullValueHandling.Ignore)]
        public string XAuthTokenProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceCreateRequest Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInferServiceRequest {\n");
            sb.Append("  xAuthTokenProvider: ").Append(XAuthTokenProvider).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateInferServiceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateInferServiceRequest input)
        {
            if (input == null) return false;
            if (this.XAuthTokenProvider != input.XAuthTokenProvider || (this.XAuthTokenProvider != null && !this.XAuthTokenProvider.Equals(input.XAuthTokenProvider))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.XAuthTokenProvider != null) hashCode = hashCode * 59 + this.XAuthTokenProvider.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
