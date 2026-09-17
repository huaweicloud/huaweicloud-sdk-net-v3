using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// **参数解释**： 基线属性信息，指定基线或取消基线操作。 **约束限制**： 不涉及。
    /// </summary>
    public class BaseLineVO 
    {

        /// <summary>
        /// **参数解释**： 基线或取消基线操作类型。 **约束限制**： 不涉及。 **取值范围**： - baselined：基线发布/迭代计划 - unbaseline：取消基线，恢复发布/迭代计划 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
        public string Baseline { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseLineVO {\n");
            sb.Append("  baseline: ").Append(Baseline).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BaseLineVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BaseLineVO input)
        {
            if (input == null) return false;
            if (this.Baseline != input.Baseline || (this.Baseline != null && !this.Baseline.Equals(input.Baseline))) return false;

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
                if (this.Baseline != null) hashCode = hashCode * 59 + this.Baseline.GetHashCode();
                return hashCode;
            }
        }
    }
}
