using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ScaleProxyRequestBody 
    {

        /// <summary>
        /// 需要变更的新规格ID。
        /// </summary>
        [JsonProperty("flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 是否延迟变更。  - true：延迟变更，将在运维时间窗内自动变更。 - false：立即变更。
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScaleProxyRequestBody {\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScaleProxyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScaleProxyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FlavorRef == input.FlavorRef ||
                    (this.FlavorRef != null &&
                    this.FlavorRef.Equals(input.FlavorRef))
                ) && 
                (
                    this.Delay == input.Delay ||
                    (this.Delay != null &&
                    this.Delay.Equals(input.Delay))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FlavorRef != null)
                    hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.Delay != null)
                    hashCode = hashCode * 59 + this.Delay.GetHashCode();
                return hashCode;
            }
        }
    }
}
