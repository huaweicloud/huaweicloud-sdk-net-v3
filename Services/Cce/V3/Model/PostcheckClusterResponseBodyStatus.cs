using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// **参数解释：** 集群升级后确认的状态信息 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及 
    /// </summary>
    public class PostcheckClusterResponseBodyStatus 
    {

        /// <summary>
        /// **参数解释：** 状态 **约束限制：** 不涉及 **取值范围：** - Success：成功 - Failed：失败 - Error：错误  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostcheckClusterResponseBodyStatus {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostcheckClusterResponseBodyStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostcheckClusterResponseBodyStatus input)
        {
            if (input == null) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;

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
                if (this.Phase != null) hashCode = hashCode * 59 + this.Phase.GetHashCode();
                return hashCode;
            }
        }
    }
}
