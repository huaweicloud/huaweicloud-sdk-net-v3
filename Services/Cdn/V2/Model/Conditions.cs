using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// **参数解释：** 触发当前规则的条件 **约束限制：** 不涉及
    /// </summary>
    public class Conditions 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("match", NullValueHandling = NullValueHandling.Ignore)]
        public Match Match { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Conditions {\n");
            sb.Append("  match: ").Append(Match).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Conditions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Conditions input)
        {
            if (input == null) return false;
            if (this.Match != input.Match || (this.Match != null && !this.Match.Equals(input.Match))) return false;

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
                if (this.Match != null) hashCode = hashCode * 59 + this.Match.GetHashCode();
                return hashCode;
            }
        }
    }
}
