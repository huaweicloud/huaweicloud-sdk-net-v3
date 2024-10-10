using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Curve 
    {

        /// <summary>
        /// 入带宽
        /// </summary>
        [JsonProperty("in", NullValueHandling = NullValueHandling.Ignore)]
        public float? In { get; set; }

        /// <summary>
        /// 出带宽
        /// </summary>
        [JsonProperty("out", NullValueHandling = NullValueHandling.Ignore)]
        public float? Out { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public int? Time { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Curve {\n");
            sb.Append("  In: ").Append(In).Append("\n");
            sb.Append("  Out: ").Append(Out).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Curve);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Curve input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.In == input.In ||
                    (this.In != null &&
                    this.In.Equals(input.In))
                ) && 
                (
                    this.Out == input.Out ||
                    (this.Out != null &&
                    this.Out.Equals(input.Out))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
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
                if (this.In != null)
                    hashCode = hashCode * 59 + this.In.GetHashCode();
                if (this.Out != null)
                    hashCode = hashCode * 59 + this.Out.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }
    }
}
