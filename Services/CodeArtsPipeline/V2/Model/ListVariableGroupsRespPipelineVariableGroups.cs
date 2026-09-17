using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListVariableGroupsRespPipelineVariableGroups 
    {

        /// <summary>
        /// 参数组ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 参数组名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 参数列表。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryVariableGroupDetailRespVariables> Variables { get; set; }

        /// <summary>
        /// 关联的流水线
        /// </summary>
        [JsonProperty("related_pipelines", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListVariableGroupsRespRelatedPipelines> RelatedPipelines { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// 更新人ID
        /// </summary>
        [JsonProperty("updater_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdaterId { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// 更新人名称
        /// </summary>
        [JsonProperty("updater_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdaterName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListVariableGroupsRespPipelineVariableGroups {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  variables: ").Append(Variables).Append("\n");
            sb.Append("  relatedPipelines: ").Append(RelatedPipelines).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  updaterId: ").Append(UpdaterId).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  updaterName: ").Append(UpdaterName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListVariableGroupsRespPipelineVariableGroups);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListVariableGroupsRespPipelineVariableGroups input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Variables != input.Variables || (this.Variables != null && input.Variables != null && !this.Variables.SequenceEqual(input.Variables))) return false;
            if (this.RelatedPipelines != input.RelatedPipelines || (this.RelatedPipelines != null && input.RelatedPipelines != null && !this.RelatedPipelines.SequenceEqual(input.RelatedPipelines))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.UpdaterId != input.UpdaterId || (this.UpdaterId != null && !this.UpdaterId.Equals(input.UpdaterId))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.UpdaterName != input.UpdaterName || (this.UpdaterName != null && !this.UpdaterName.Equals(input.UpdaterName))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Variables != null) hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.RelatedPipelines != null) hashCode = hashCode * 59 + this.RelatedPipelines.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.UpdaterId != null) hashCode = hashCode * 59 + this.UpdaterId.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.UpdaterName != null) hashCode = hashCode * 59 + this.UpdaterName.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
