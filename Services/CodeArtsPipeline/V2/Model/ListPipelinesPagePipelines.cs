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
    public class ListPipelinesPagePipelines 
    {

        /// <summary>
        /// **参数解释**： 流水线ID，可以通过[查询流水线列表](ListPipelines.xml)接口，其中pipelines.pipelineId即为流水线ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("pipeline_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线名称。 **取值范围**： 仅包含中文、大小写英文字母、数字、&#39;-&#39;和&#39;_&#39;，且长度为[1,128]个字符。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 项目ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 项目名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// **参数解释**： 组件ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        /// <summary>
        /// **参数解释**： 是否为变更流水线。 **取值范围**： - true：是变更流水线。 - false：不是变更流水线。 
        /// </summary>
        [JsonProperty("is_publish", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPublish { get; set; }

        /// <summary>
        /// **参数解释**： 是否收藏此流水线。 **取值范围**： - true：已收藏流水线。 - false：未收藏流水线。 
        /// </summary>
        [JsonProperty("is_collect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCollect { get; set; }

        /// <summary>
        /// **参数解释**： 流水线版本。 **取值范围**： 默认3.0。 
        /// </summary>
        [JsonProperty("manifest_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ManifestVersion { get; set; }

        /// <summary>
        /// **参数解释**： 创建时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("latest_run", NullValueHandling = NullValueHandling.Ignore)]
        public ListPipelinesPageLatestRun LatestRun { get; set; }

        /// <summary>
        /// **参数解释**： 旧版转新版标识。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("convert_sign", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConvertSign { get; set; }

        /// <summary>
        /// **参数解释**： 流水线涉密等级。 **取值范围**： 正整数。 null：未设置密级。 1：最低密级。 
        /// </summary>
        [JsonProperty("security_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecurityLevel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPipelinesPagePipelines {\n");
            sb.Append("  pipelineId: ").Append(PipelineId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("  isPublish: ").Append(IsPublish).Append("\n");
            sb.Append("  isCollect: ").Append(IsCollect).Append("\n");
            sb.Append("  manifestVersion: ").Append(ManifestVersion).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  latestRun: ").Append(LatestRun).Append("\n");
            sb.Append("  convertSign: ").Append(ConvertSign).Append("\n");
            sb.Append("  securityLevel: ").Append(SecurityLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPipelinesPagePipelines);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPipelinesPagePipelines input)
        {
            if (input == null) return false;
            if (this.PipelineId != input.PipelineId || (this.PipelineId != null && !this.PipelineId.Equals(input.PipelineId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.ComponentId != input.ComponentId || (this.ComponentId != null && !this.ComponentId.Equals(input.ComponentId))) return false;
            if (this.IsPublish != input.IsPublish || (this.IsPublish != null && !this.IsPublish.Equals(input.IsPublish))) return false;
            if (this.IsCollect != input.IsCollect || (this.IsCollect != null && !this.IsCollect.Equals(input.IsCollect))) return false;
            if (this.ManifestVersion != input.ManifestVersion || (this.ManifestVersion != null && !this.ManifestVersion.Equals(input.ManifestVersion))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.LatestRun != input.LatestRun || (this.LatestRun != null && !this.LatestRun.Equals(input.LatestRun))) return false;
            if (this.ConvertSign != input.ConvertSign || (this.ConvertSign != null && !this.ConvertSign.Equals(input.ConvertSign))) return false;
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
                if (this.PipelineId != null) hashCode = hashCode * 59 + this.PipelineId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.ComponentId != null) hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                if (this.IsPublish != null) hashCode = hashCode * 59 + this.IsPublish.GetHashCode();
                if (this.IsCollect != null) hashCode = hashCode * 59 + this.IsCollect.GetHashCode();
                if (this.ManifestVersion != null) hashCode = hashCode * 59 + this.ManifestVersion.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LatestRun != null) hashCode = hashCode * 59 + this.LatestRun.GetHashCode();
                if (this.ConvertSign != null) hashCode = hashCode * 59 + this.ConvertSign.GetHashCode();
                if (this.SecurityLevel != null) hashCode = hashCode * 59 + this.SecurityLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
