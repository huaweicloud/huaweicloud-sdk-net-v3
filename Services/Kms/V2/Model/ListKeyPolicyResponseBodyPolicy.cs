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
    /// **参数解释：** 密钥策略 **取值范围：** 不涉及
    /// </summary>
    public class ListKeyPolicyResponseBodyPolicy 
    {

        /// <summary>
        /// **参数解释：** 密钥策略版本 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("validityPeriod", NullValueHandling = NullValueHandling.Ignore)]
        public ListKeyPolicyResponseBodyPolicyValidityPeriod ValidityPeriod { get; set; }

        /// <summary>
        /// **参数解释：** 允许访问的接入点ID列表 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("allowedAccessPoint", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowedAccessPoint { get; set; }

        /// <summary>
        /// **参数解释：** 允许访问的数据安全专区ID列表 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("allowed_data_security_zone", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowedDataSecurityZone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListKeyPolicyResponseBodyPolicy {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  validityPeriod: ").Append(ValidityPeriod).Append("\n");
            sb.Append("  allowedAccessPoint: ").Append(AllowedAccessPoint).Append("\n");
            sb.Append("  allowedDataSecurityZone: ").Append(AllowedDataSecurityZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListKeyPolicyResponseBodyPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListKeyPolicyResponseBodyPolicy input)
        {
            if (input == null) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.ValidityPeriod != input.ValidityPeriod || (this.ValidityPeriod != null && !this.ValidityPeriod.Equals(input.ValidityPeriod))) return false;
            if (this.AllowedAccessPoint != input.AllowedAccessPoint || (this.AllowedAccessPoint != null && input.AllowedAccessPoint != null && !this.AllowedAccessPoint.SequenceEqual(input.AllowedAccessPoint))) return false;
            if (this.AllowedDataSecurityZone != input.AllowedDataSecurityZone || (this.AllowedDataSecurityZone != null && input.AllowedDataSecurityZone != null && !this.AllowedDataSecurityZone.SequenceEqual(input.AllowedDataSecurityZone))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ValidityPeriod != null) hashCode = hashCode * 59 + this.ValidityPeriod.GetHashCode();
                if (this.AllowedAccessPoint != null) hashCode = hashCode * 59 + this.AllowedAccessPoint.GetHashCode();
                if (this.AllowedDataSecurityZone != null) hashCode = hashCode * 59 + this.AllowedDataSecurityZone.GetHashCode();
                return hashCode;
            }
        }
    }
}
