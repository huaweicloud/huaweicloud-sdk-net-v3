using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RotateCredentialsRequestBody 
    {

        /// <summary>
        /// **参数解释：**  需要轮转的组件名称。 **约束限制：** 不涉及 **取值范围：** - all：轮转CCE集群证书。 - service-account-controller：轮转ServiceAccount token相关证书。 - custom：轮转用户自有证书，指定此参数时，需同时指定certContent参数。  **默认取值：** 不涉及 
        /// </summary>
        [JsonProperty("component", NullValueHandling = NullValueHandling.Ignore)]
        public string Component { get; set; }

        /// <summary>
        /// **参数解释：**  轮转证书后，用于验证ServiceAccount Token签名的旧证书保留时间。  为了保证基于旧证书签发的ServiceAccount Token在证书轮转后能验签通过，CCE会保留老证书一段时间，具体规则如下： - 首次轮转时，CCE会保留创建集群时生成的证书； - 从第二次轮转开始，CCE会保留老证书一段时间，默认24小时。用户可以通过当前参数配置保留的时间。  **约束限制：** 不涉及 **取值范围：** 0-8784（小时） **默认取值：** 24（小时） 
        /// </summary>
        [JsonProperty("certificateExpirationTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertificateExpirationTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("certContent", NullValueHandling = NullValueHandling.Ignore)]
        public AuthenticatingProxy CertContent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RotateCredentialsRequestBody {\n");
            sb.Append("  component: ").Append(Component).Append("\n");
            sb.Append("  certificateExpirationTime: ").Append(CertificateExpirationTime).Append("\n");
            sb.Append("  certContent: ").Append(CertContent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RotateCredentialsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RotateCredentialsRequestBody input)
        {
            if (input == null) return false;
            if (this.Component != input.Component || (this.Component != null && !this.Component.Equals(input.Component))) return false;
            if (this.CertificateExpirationTime != input.CertificateExpirationTime || (this.CertificateExpirationTime != null && !this.CertificateExpirationTime.Equals(input.CertificateExpirationTime))) return false;
            if (this.CertContent != input.CertContent || (this.CertContent != null && !this.CertContent.Equals(input.CertContent))) return false;

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
                if (this.Component != null) hashCode = hashCode * 59 + this.Component.GetHashCode();
                if (this.CertificateExpirationTime != null) hashCode = hashCode * 59 + this.CertificateExpirationTime.GetHashCode();
                if (this.CertContent != null) hashCode = hashCode * 59 + this.CertContent.GetHashCode();
                return hashCode;
            }
        }
    }
}
