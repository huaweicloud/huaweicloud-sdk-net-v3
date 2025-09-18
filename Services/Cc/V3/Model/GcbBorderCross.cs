using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 全域互联带宽跨境属性。
    /// </summary>
    public class GcbBorderCross 
    {

        /// <summary>
        /// 全域互联带宽跨境属性。
        /// </summary>
        [JsonProperty("bordercross", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Bordercross { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcbBorderCross {\n");
            sb.Append("  bordercross: ").Append(Bordercross).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GcbBorderCross);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GcbBorderCross input)
        {
            if (input == null) return false;
            if (this.Bordercross != input.Bordercross || (this.Bordercross != null && !this.Bordercross.Equals(input.Bordercross))) return false;

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
                if (this.Bordercross != null) hashCode = hashCode * 59 + this.Bordercross.GetHashCode();
                return hashCode;
            }
        }
    }
}
