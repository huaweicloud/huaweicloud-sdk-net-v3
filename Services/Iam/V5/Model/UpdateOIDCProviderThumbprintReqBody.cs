using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateOIDCProviderThumbprintReqBody 
    {

        /// <summary>
        /// **参数解释**： OIDC 身份提供商的服务器证书指纹列表。  **约束限制**： 列表元素数量取值范围为[1,5]个，每个元素字符串长度为64。  **取值范围**： 不涉及。  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("thumbprints", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Thumbprints { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateOIDCProviderThumbprintReqBody {\n");
            sb.Append("  thumbprints: ").Append(Thumbprints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateOIDCProviderThumbprintReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateOIDCProviderThumbprintReqBody input)
        {
            if (input == null) return false;
            if (this.Thumbprints != input.Thumbprints || (this.Thumbprints != null && input.Thumbprints != null && !this.Thumbprints.SequenceEqual(input.Thumbprints))) return false;

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
                if (this.Thumbprints != null) hashCode = hashCode * 59 + this.Thumbprints.GetHashCode();
                return hashCode;
            }
        }
    }
}
