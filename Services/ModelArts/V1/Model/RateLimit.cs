using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释：** 流量控制配置。 **约束限制：** 不涉及。
    /// </summary>
    public class RateLimit 
    {

        /// <summary>
        /// **参数解释：** 服务流量限制是指指定单位内一个服务能够被访问的次数上限。 **约束限制：** 不涉及。 **取值范围：** 1-10000。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("num", NullValueHandling = NullValueHandling.Ignore)]
        public int? Num { get; set; }

        /// <summary>
        /// **参数解释：** 流量限制单元。 **约束限制：** 不涉及。 **取值范围：** - SECONDS（秒）。 - MINUTES（分钟）。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RateLimit {\n");
            sb.Append("  num: ").Append(Num).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RateLimit);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RateLimit input)
        {
            if (input == null) return false;
            if (this.Num != input.Num || (this.Num != null && !this.Num.Equals(input.Num))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;

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
                if (this.Num != null) hashCode = hashCode * 59 + this.Num.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }
    }
}
