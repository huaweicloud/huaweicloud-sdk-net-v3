using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// **参数解释：** 接入点证明文档 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
    /// </summary>
    public class DecryptDatakeyCapsuleRequestBodyAttestationDocument 
    {

        /// <summary>
        /// **参数解释：** ECS证明文档 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("ecs_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsSignature { get; set; }

        /// <summary>
        /// **参数解释：** 通用类型接入点的签名信息 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("custom_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomSignature { get; set; }

        /// <summary>
        /// **参数解释：** 通用类型接入点公钥信息 **约束限制：** 格式是X509公钥格式中的Base64字符串 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("custom_public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomPublicKey { get; set; }

        /// <summary>
        /// **参数解释：** 通用类型签名信息过期时间 **约束限制：** 时间格式是ISO 8601格式，yyyy-mm-ddTHH:MM:SSZ **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// **参数解释：** CCE类型访问凭证 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("service_token", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecryptDatakeyCapsuleRequestBodyAttestationDocument {\n");
            sb.Append("  ecsSignature: ").Append(EcsSignature).Append("\n");
            sb.Append("  customSignature: ").Append(CustomSignature).Append("\n");
            sb.Append("  customPublicKey: ").Append(CustomPublicKey).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  serviceToken: ").Append(ServiceToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DecryptDatakeyCapsuleRequestBodyAttestationDocument);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DecryptDatakeyCapsuleRequestBodyAttestationDocument input)
        {
            if (input == null) return false;
            if (this.EcsSignature != input.EcsSignature || (this.EcsSignature != null && !this.EcsSignature.Equals(input.EcsSignature))) return false;
            if (this.CustomSignature != input.CustomSignature || (this.CustomSignature != null && !this.CustomSignature.Equals(input.CustomSignature))) return false;
            if (this.CustomPublicKey != input.CustomPublicKey || (this.CustomPublicKey != null && !this.CustomPublicKey.Equals(input.CustomPublicKey))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.ServiceToken != input.ServiceToken || (this.ServiceToken != null && !this.ServiceToken.Equals(input.ServiceToken))) return false;

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
                if (this.EcsSignature != null) hashCode = hashCode * 59 + this.EcsSignature.GetHashCode();
                if (this.CustomSignature != null) hashCode = hashCode * 59 + this.CustomSignature.GetHashCode();
                if (this.CustomPublicKey != null) hashCode = hashCode * 59 + this.CustomPublicKey.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.ServiceToken != null) hashCode = hashCode * 59 + this.ServiceToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
