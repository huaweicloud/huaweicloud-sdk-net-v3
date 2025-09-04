using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QuotaLimitInfo 
    {

        /// <summary>
        /// 属性key值。
        /// </summary>
        [JsonProperty("limit_key", NullValueHandling = NullValueHandling.Ignore)]
        public string LimitKey { get; set; }

        /// <summary>
        /// 属性值，具体参见表3。
        /// </summary>
        [JsonProperty("limit_values", NullValueHandling = NullValueHandling.Ignore)]
        public List<LimitValue> LimitValues { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaLimitInfo {\n");
            sb.Append("  limitKey: ").Append(LimitKey).Append("\n");
            sb.Append("  limitValues: ").Append(LimitValues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuotaLimitInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuotaLimitInfo input)
        {
            if (input == null) return false;
            if (this.LimitKey != input.LimitKey || (this.LimitKey != null && !this.LimitKey.Equals(input.LimitKey))) return false;
            if (this.LimitValues != input.LimitValues || (this.LimitValues != null && input.LimitValues != null && !this.LimitValues.SequenceEqual(input.LimitValues))) return false;

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
                if (this.LimitKey != null) hashCode = hashCode * 59 + this.LimitKey.GetHashCode();
                if (this.LimitValues != null) hashCode = hashCode * 59 + this.LimitValues.GetHashCode();
                return hashCode;
            }
        }
    }
}
