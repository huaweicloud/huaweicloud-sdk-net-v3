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
    /// 项目详情对象
    /// </summary>
    public class ProjectInfoVO 
    {

        /// <summary>
        /// **参数解释**： 项目ID。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 项目名称。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 项目类型。 **取值范围**： - ipd：IPD项目 - scrum：scrum项目 - xboard：看板项目
        /// </summary>
        [JsonProperty("project_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectType { get; set; }

        /// <summary>
        /// **参数解释**： 项目空间ID。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释**： IPD项目模型Id。 **取值范围**： 10001（系统设备类） 10002（独立软件类） 10003（云服务类型）
        /// </summary>
        [JsonProperty("model_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelId { get; set; }

        /// <summary>
        /// **参数解释**： 该项目是否接受外部RR（原始需求）。 **取值范围**： - 0：不接受外部RR - 1：接受外部RR
        /// </summary>
        [JsonProperty("accept_rr", NullValueHandling = NullValueHandling.Ignore)]
        public int? AcceptRr { get; set; }

        /// <summary>
        /// **参数解释**： 项目类型，用于区分项目和项目群。 **取值范围**： - Project：项目 - Group：项目群
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**： 项目创建人名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("created_by_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedByName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectInfoVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectType: ").Append(ProjectType).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  modelId: ").Append(ModelId).Append("\n");
            sb.Append("  acceptRr: ").Append(AcceptRr).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  createdByName: ").Append(CreatedByName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProjectInfoVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProjectInfoVO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProjectType != input.ProjectType || (this.ProjectType != null && !this.ProjectType.Equals(input.ProjectType))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.ModelId != input.ModelId || (this.ModelId != null && !this.ModelId.Equals(input.ModelId))) return false;
            if (this.AcceptRr != input.AcceptRr || (this.AcceptRr != null && !this.AcceptRr.Equals(input.AcceptRr))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.CreatedByName != input.CreatedByName || (this.CreatedByName != null && !this.CreatedByName.Equals(input.CreatedByName))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectType != null) hashCode = hashCode * 59 + this.ProjectType.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.ModelId != null) hashCode = hashCode * 59 + this.ModelId.GetHashCode();
                if (this.AcceptRr != null) hashCode = hashCode * 59 + this.AcceptRr.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.CreatedByName != null) hashCode = hashCode * 59 + this.CreatedByName.GetHashCode();
                return hashCode;
            }
        }
    }
}
