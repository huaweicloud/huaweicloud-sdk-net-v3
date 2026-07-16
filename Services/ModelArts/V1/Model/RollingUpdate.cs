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
    /// **参数解释：** 滚动更新配置。 **约束限制：** 不涉及。
    /// </summary>
    public class RollingUpdate 
    {

        /// <summary>
        /// **参数解释：** 滚动更新时最多可以启动多少个Pod。 **约束限制：** 百分数类型字符串。 **取值范围：** 1%-100%。 **默认取值：** 1%。
        /// </summary>
        [JsonProperty("max_surge", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxSurge { get; set; }

        /// <summary>
        /// **参数解释：** 滚动更新时最多可以删除多少个Pod。 **约束限制：** 百分数类型字符串。 **取值范围：** 1%-100%。 **默认取值：** 1%。
        /// </summary>
        [JsonProperty("max_unavailable", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxUnavailable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RollingUpdate {\n");
            sb.Append("  maxSurge: ").Append(MaxSurge).Append("\n");
            sb.Append("  maxUnavailable: ").Append(MaxUnavailable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RollingUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RollingUpdate input)
        {
            if (input == null) return false;
            if (this.MaxSurge != input.MaxSurge || (this.MaxSurge != null && !this.MaxSurge.Equals(input.MaxSurge))) return false;
            if (this.MaxUnavailable != input.MaxUnavailable || (this.MaxUnavailable != null && !this.MaxUnavailable.Equals(input.MaxUnavailable))) return false;

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
                if (this.MaxSurge != null) hashCode = hashCode * 59 + this.MaxSurge.GetHashCode();
                if (this.MaxUnavailable != null) hashCode = hashCode * 59 + this.MaxUnavailable.GetHashCode();
                return hashCode;
            }
        }
    }
}
