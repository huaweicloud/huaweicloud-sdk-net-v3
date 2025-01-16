using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// StarRocks内核版本升级请求体。
    /// </summary>
    public class UpgradeSrKernelVersionRequestV3 
    {

        /// <summary>
        /// **参数解释**： 是否延时升级。  **约束限制**： 不涉及  **取值范围**： - true - false  **默认取值**： false。
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public string Delay { get; set; }

        /// <summary>
        /// **参数解释**： 是否跳过升级校验。  **约束限制**： 不涉及  **取值范围**： - true - false  **默认取值**： false。
        /// </summary>
        [JsonProperty("is_skip_validate", NullValueHandling = NullValueHandling.Ignore)]
        public string IsSkipValidate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeSrKernelVersionRequestV3 {\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("  isSkipValidate: ").Append(IsSkipValidate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeSrKernelVersionRequestV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeSrKernelVersionRequestV3 input)
        {
            if (input == null) return false;
            if (this.Delay != input.Delay || (this.Delay != null && !this.Delay.Equals(input.Delay))) return false;
            if (this.IsSkipValidate != input.IsSkipValidate || (this.IsSkipValidate != null && !this.IsSkipValidate.Equals(input.IsSkipValidate))) return false;

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
                if (this.Delay != null) hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.IsSkipValidate != null) hashCode = hashCode * 59 + this.IsSkipValidate.GetHashCode();
                return hashCode;
            }
        }
    }
}
