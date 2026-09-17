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
    /// **参数解释**： 更新发布/迭代状态的请求体。 **约束限制**： 不涉及。
    /// </summary>
    public class CompleteSprintVO 
    {

        /// <summary>
        /// **参数解释**： 操作类型。 **约束限制**： 不涉及。 **取值范围**： - start：开始发布/迭代计划 - complete：完成发布/迭代计划 - reset：将计划状态设置为\&quot;未开始\&quot; - restart：重新开始发布/迭代计划 - move：将工作项移动到其他迭代 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("operate", NullValueHandling = NullValueHandling.Ignore)]
        public string Operate { get; set; }

        /// <summary>
        /// **参数解释**： 将工作项移动到指定迭代ID。operate参数值为complete时，需要将未完成的工作项移动到其他迭代。 **约束限制**： operate参数值为complete时需填写。空字符串表示将工作项移动到\&quot;待规划\&quot;。 **取值范围**： 长度为18~19个字符的数字字符串。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("move_to_sprint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MoveToSprintId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompleteSprintVO {\n");
            sb.Append("  operate: ").Append(Operate).Append("\n");
            sb.Append("  moveToSprintId: ").Append(MoveToSprintId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompleteSprintVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompleteSprintVO input)
        {
            if (input == null) return false;
            if (this.Operate != input.Operate || (this.Operate != null && !this.Operate.Equals(input.Operate))) return false;
            if (this.MoveToSprintId != input.MoveToSprintId || (this.MoveToSprintId != null && !this.MoveToSprintId.Equals(input.MoveToSprintId))) return false;

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
                if (this.Operate != null) hashCode = hashCode * 59 + this.Operate.GetHashCode();
                if (this.MoveToSprintId != null) hashCode = hashCode * 59 + this.MoveToSprintId.GetHashCode();
                return hashCode;
            }
        }
    }
}
