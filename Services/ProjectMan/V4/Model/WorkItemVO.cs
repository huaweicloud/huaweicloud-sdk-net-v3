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
    /// **参数解释**： 工作项信息对象，包含工作项ID、标题、编号、分类、状态、责任人等。 **约束限制**： 不涉及。
    /// </summary>
    public class WorkItemVO 
    {

        /// <summary>
        /// **参数解释**： 工作项唯一ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 工作项标题。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// **参数解释**： 工作项编号。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// **参数解释**： 工作项分类。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusVoIpd Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public UserVO Assignee { get; set; }

        /// <summary>
        /// **参数解释**： 工作项基线状态。 **取值范围**： - baselined：已基线 - unbaseline：未基线 - \&quot;\&quot;：未基线
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
        public string Baseline { get; set; }

        /// <summary>
        /// **参数解释**： 工作项变更状态。 **取值范围**： - cannot_finish：不可完成
        /// </summary>
        [JsonProperty("change_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ChangeStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  assignee: ").Append(Assignee).Append("\n");
            sb.Append("  baseline: ").Append(Baseline).Append("\n");
            sb.Append("  changeStatus: ").Append(ChangeStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkItemVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkItemVO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Assignee != input.Assignee || (this.Assignee != null && !this.Assignee.Equals(input.Assignee))) return false;
            if (this.Baseline != input.Baseline || (this.Baseline != null && !this.Baseline.Equals(input.Baseline))) return false;
            if (this.ChangeStatus != input.ChangeStatus || (this.ChangeStatus != null && !this.ChangeStatus.Equals(input.ChangeStatus))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Assignee != null) hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.Baseline != null) hashCode = hashCode * 59 + this.Baseline.GetHashCode();
                if (this.ChangeStatus != null) hashCode = hashCode * 59 + this.ChangeStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
