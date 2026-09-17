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
    /// **参数解释**： 创建发布/迭代计划的请求参数。 **约束限制**： 不涉及。
    /// </summary>
    public class PlanCreateParam 
    {

        /// <summary>
        /// **参数解释**： 计划标题。 **约束限制**： 不涉及。 **取值范围**： 1~256个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// **参数解释**： 计划分类，枚举类型。 **约束限制**： 不涉及。 **取值范围**： - PI：发布 - Iteration：迭代 - PlanMilestone：里程碑 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**： 计划描述信息。 **约束限制**： 不涉及。 **取值范围**： 0~1000个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 计划开始时间，格式为yyyy-MM-dd，如2024-01-01。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("plan_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanStartDate { get; set; }

        /// <summary>
        /// **参数解释**： 计划完成时间，格式为yyyy-MM-dd，如2024-01-01。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("plan_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanEndDate { get; set; }

        /// <summary>
        /// **参数解释**： 父计划ID，当category为Iteration时必填，用于指定所属的发布计划。 **约束限制**： category为Iteration时必填。 **取值范围**： 长度为18~19个字符的数字字符串。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// **参数解释**： 预估工作量，用于标识计划所需的人力投入，单位人/天。 **约束限制**： 不涉及。 **取值范围**： 0~11个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("workload", NullValueHandling = NullValueHandling.Ignore)]
        public string Workload { get; set; }

        /// <summary>
        /// **参数解释**： 责任人ID，标识计划的负责人。 **约束限制**： 不涉及。 **取值范围**： 长度为32个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanCreateParam {\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  planStartDate: ").Append(PlanStartDate).Append("\n");
            sb.Append("  planEndDate: ").Append(PlanEndDate).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  workload: ").Append(Workload).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PlanCreateParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PlanCreateParam input)
        {
            if (input == null) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.PlanStartDate != input.PlanStartDate || (this.PlanStartDate != null && !this.PlanStartDate.Equals(input.PlanStartDate))) return false;
            if (this.PlanEndDate != input.PlanEndDate || (this.PlanEndDate != null && !this.PlanEndDate.Equals(input.PlanEndDate))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.Workload != input.Workload || (this.Workload != null && !this.Workload.Equals(input.Workload))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;

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
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PlanStartDate != null) hashCode = hashCode * 59 + this.PlanStartDate.GetHashCode();
                if (this.PlanEndDate != null) hashCode = hashCode * 59 + this.PlanEndDate.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Workload != null) hashCode = hashCode * 59 + this.Workload.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                return hashCode;
            }
        }
    }
}
