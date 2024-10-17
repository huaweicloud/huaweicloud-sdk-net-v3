using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IntegerRange 
    {

        /// <summary>
        /// 伸缩组最大实例数
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public int? Max { get; set; }

        /// <summary>
        /// 伸缩组最小实例数
        /// </summary>
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public int? Min { get; set; }

        /// <summary>
        /// 伸缩组期望实例数
        /// </summary>
        [JsonProperty("desire", NullValueHandling = NullValueHandling.Ignore)]
        public int? Desire { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegerRange {\n");
            sb.Append("  max: ").Append(Max).Append("\n");
            sb.Append("  min: ").Append(Min).Append("\n");
            sb.Append("  desire: ").Append(Desire).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IntegerRange);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IntegerRange input)
        {
            if (input == null) return false;
            if (this.Max != input.Max || (this.Max != null && !this.Max.Equals(input.Max))) return false;
            if (this.Min != input.Min || (this.Min != null && !this.Min.Equals(input.Min))) return false;
            if (this.Desire != input.Desire || (this.Desire != null && !this.Desire.Equals(input.Desire))) return false;

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
                if (this.Max != null) hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this.Min != null) hashCode = hashCode * 59 + this.Min.GetHashCode();
                if (this.Desire != null) hashCode = hashCode * 59 + this.Desire.GetHashCode();
                return hashCode;
            }
        }
    }
}
