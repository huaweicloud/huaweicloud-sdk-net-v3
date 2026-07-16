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
    /// 条件节点执行条件。
    /// </summary>
    public class StepConditionResp 
    {

        /// <summary>
        /// **参数解释**：判断类型，例如&#x3D;&#x3D;（等于）、!&#x3D;（不等于）、&gt;（大于）、&gt;&#x3D;（大于等于）、&lt;（小于）、&lt;&#x3D;（小于等于）、in（包含）、or（或）。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：节点执行条件为true时的分支。
        /// </summary>
        [JsonProperty("left", NullValueHandling = NullValueHandling.Ignore)]
        public Object Left { get; set; }

        /// <summary>
        /// **参数解释**：节点执行条件为false时的分支。
        /// </summary>
        [JsonProperty("right", NullValueHandling = NullValueHandling.Ignore)]
        public Object Right { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StepConditionResp {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  left: ").Append(Left).Append("\n");
            sb.Append("  right: ").Append(Right).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StepConditionResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StepConditionResp input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Left != input.Left || (this.Left != null && !this.Left.Equals(input.Left))) return false;
            if (this.Right != input.Right || (this.Right != null && !this.Right.Equals(input.Right))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Left != null) hashCode = hashCode * 59 + this.Left.GetHashCode();
                if (this.Right != null) hashCode = hashCode * 59 + this.Right.GetHashCode();
                return hashCode;
            }
        }
    }
}
