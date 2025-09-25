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
    /// Response Object
    /// </summary>
    public class ShowPipelineDetailResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 流水线ID，可以通过[查询流水线列表](ListPipelines.xml)接口，其中pipelines.pipelineId即为流水线ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 流水线名称。 **取值范围**： 仅包含中文、大小写英文字母、数字、&#39;-&#39;和&#39;_&#39;，且长度为[1,128]个字符。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 对流水线的补充描述。 **取值范围**： 不超过1024字符。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 流水线版本，默认为3.0。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("manifest_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ManifestVersion { get; set; }

        /// <summary>
        /// **参数解释**： 当前环境所属局点。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// **参数解释**： 所属租户ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释**： 项目ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 所属微服务ID。可以通过[查询微服务列表](ListMicroservice.xml)接口获取，其中data.id即为微服务ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        /// <summary>
        /// **参数解释**： 是否为变更流水线。 **取值范围**： - true：是变更流水线。 - false：不是变更流水线。 
        /// </summary>
        [JsonProperty("is_publish", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPublish { get; set; }

        /// <summary>
        /// **参数解释**： 流水线创建人ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线创建人名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// **参数解释**： 流水线上次更新人ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("updater_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdaterId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线创建时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// **参数解释**： 流水线更新时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// **参数解释**： 流水线是否被当前用户收藏。 **取值范围**： - true：流水线已被收藏。 - false：流水线未被收藏。 
        /// </summary>
        [JsonProperty("is_collect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCollect { get; set; }

        /// <summary>
        /// **参数解释**： 流水线源列表。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<PipelineSource> Sources { get; set; }

        /// <summary>
        /// **参数解释**： 流水线自定义参数。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public List<PipelineVariable> Variables { get; set; }

        /// <summary>
        /// **参数解释**： 流水线定时任务设置。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("schedules", NullValueHandling = NullValueHandling.Ignore)]
        public List<PipelineSchedule> Schedules { get; set; }

        /// <summary>
        /// **参数解释**： 流水线事件触发设置。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("triggers", NullValueHandling = NullValueHandling.Ignore)]
        public List<PipelineTrigger> Triggers { get; set; }

        /// <summary>
        /// **参数解释**： 流水线所属分组ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线定义JSON。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("definition", NullValueHandling = NullValueHandling.Ignore)]
        public string Definition { get; set; }

        /// <summary>
        /// **参数解释**： 流水线涉密等级。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("security_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecurityLevel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPipelineDetailResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  manifestVersion: ").Append(ManifestVersion).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("  isPublish: ").Append(IsPublish).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  updaterId: ").Append(UpdaterId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  isCollect: ").Append(IsCollect).Append("\n");
            sb.Append("  sources: ").Append(Sources).Append("\n");
            sb.Append("  variables: ").Append(Variables).Append("\n");
            sb.Append("  schedules: ").Append(Schedules).Append("\n");
            sb.Append("  triggers: ").Append(Triggers).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  definition: ").Append(Definition).Append("\n");
            sb.Append("  securityLevel: ").Append(SecurityLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPipelineDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPipelineDetailResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ManifestVersion != input.ManifestVersion || (this.ManifestVersion != null && !this.ManifestVersion.Equals(input.ManifestVersion))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ComponentId != input.ComponentId || (this.ComponentId != null && !this.ComponentId.Equals(input.ComponentId))) return false;
            if (this.IsPublish != input.IsPublish || (this.IsPublish != null && !this.IsPublish.Equals(input.IsPublish))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.UpdaterId != input.UpdaterId || (this.UpdaterId != null && !this.UpdaterId.Equals(input.UpdaterId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.IsCollect != input.IsCollect || (this.IsCollect != null && !this.IsCollect.Equals(input.IsCollect))) return false;
            if (this.Sources != input.Sources || (this.Sources != null && input.Sources != null && !this.Sources.SequenceEqual(input.Sources))) return false;
            if (this.Variables != input.Variables || (this.Variables != null && input.Variables != null && !this.Variables.SequenceEqual(input.Variables))) return false;
            if (this.Schedules != input.Schedules || (this.Schedules != null && input.Schedules != null && !this.Schedules.SequenceEqual(input.Schedules))) return false;
            if (this.Triggers != input.Triggers || (this.Triggers != null && input.Triggers != null && !this.Triggers.SequenceEqual(input.Triggers))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.Definition != input.Definition || (this.Definition != null && !this.Definition.Equals(input.Definition))) return false;
            if (this.SecurityLevel != input.SecurityLevel || (this.SecurityLevel != null && !this.SecurityLevel.Equals(input.SecurityLevel))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ManifestVersion != null) hashCode = hashCode * 59 + this.ManifestVersion.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ComponentId != null) hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                if (this.IsPublish != null) hashCode = hashCode * 59 + this.IsPublish.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.UpdaterId != null) hashCode = hashCode * 59 + this.UpdaterId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.IsCollect != null) hashCode = hashCode * 59 + this.IsCollect.GetHashCode();
                if (this.Sources != null) hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.Variables != null) hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.Schedules != null) hashCode = hashCode * 59 + this.Schedules.GetHashCode();
                if (this.Triggers != null) hashCode = hashCode * 59 + this.Triggers.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Definition != null) hashCode = hashCode * 59 + this.Definition.GetHashCode();
                if (this.SecurityLevel != null) hashCode = hashCode * 59 + this.SecurityLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
