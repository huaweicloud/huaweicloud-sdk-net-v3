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
    /// 委托凭据信息
    /// </summary>
    public class Credentials 
    {

        /// <summary>
        /// **参数解释**： 临时安全凭证的AK **约束限制**： 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("accessKeyId", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// **参数解释：** 临时安全凭证的SK **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("secretAccessKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretAccessKey { get; set; }

        /// <summary>
        /// **参数解释**： 临时安全凭证的security_token **约束限制**： 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("securityToken", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// **参数解释：** 临时安全凭证的失效时间 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("expiration", NullValueHandling = NullValueHandling.Ignore)]
        public string Expiration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Credentials {\n");
            sb.Append("  accessKeyId: ").Append(AccessKeyId).Append("\n");
            sb.Append("  secretAccessKey: ").Append(SecretAccessKey).Append("\n");
            sb.Append("  securityToken: ").Append(SecurityToken).Append("\n");
            sb.Append("  expiration: ").Append(Expiration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Credentials);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Credentials input)
        {
            if (input == null) return false;
            if (this.AccessKeyId != input.AccessKeyId || (this.AccessKeyId != null && !this.AccessKeyId.Equals(input.AccessKeyId))) return false;
            if (this.SecretAccessKey != input.SecretAccessKey || (this.SecretAccessKey != null && !this.SecretAccessKey.Equals(input.SecretAccessKey))) return false;
            if (this.SecurityToken != input.SecurityToken || (this.SecurityToken != null && !this.SecurityToken.Equals(input.SecurityToken))) return false;
            if (this.Expiration != input.Expiration || (this.Expiration != null && !this.Expiration.Equals(input.Expiration))) return false;

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
                if (this.AccessKeyId != null) hashCode = hashCode * 59 + this.AccessKeyId.GetHashCode();
                if (this.SecretAccessKey != null) hashCode = hashCode * 59 + this.SecretAccessKey.GetHashCode();
                if (this.SecurityToken != null) hashCode = hashCode * 59 + this.SecurityToken.GetHashCode();
                if (this.Expiration != null) hashCode = hashCode * 59 + this.Expiration.GetHashCode();
                return hashCode;
            }
        }
    }
}
