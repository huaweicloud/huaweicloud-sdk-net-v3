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
    public class ActionsPipelineRunsQueryDTO 
    {

        /// <summary>
        /// **参数解释**： 分页查询页码。 **约束限制**： 不涉及。 **取值范围**： 大于0。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public long? Page { get; set; }

        /// <summary>
        /// **参数解释**： 每页的查询数量。 **约束限制**： 不涉及。 **取值范围**： 固定20。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public string PageSize { get; set; }

        /// <summary>
        /// **参数解释**： 代码源地址。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("https_url", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpsUrl { get; set; }

        /// <summary>
        /// **参数解释**： 流水线名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("pipeline_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineName { get; set; }

        /// <summary>
        /// **参数解释**： 文件所处路径。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// **参数解释**： 流水线运行人名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("pipeline_run_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineRunName { get; set; }

        /// <summary>
        /// **参数解释**： 流水线触发类型。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public string Event { get; set; }

        /// <summary>
        /// **参数解释**： 流水线创建者名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("actor", NullValueHandling = NullValueHandling.Ignore)]
        public string Actor { get; set; }

        /// <summary>
        /// **参数解释**： 代码源分支。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// **参数解释**： 流水线运行状态。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionsPipelineRunsQueryDTO {\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  httpsUrl: ").Append(HttpsUrl).Append("\n");
            sb.Append("  pipelineName: ").Append(PipelineName).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  pipelineRunName: ").Append(PipelineRunName).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  actor: ").Append(Actor).Append("\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionsPipelineRunsQueryDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActionsPipelineRunsQueryDTO input)
        {
            if (input == null) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.HttpsUrl != input.HttpsUrl || (this.HttpsUrl != null && !this.HttpsUrl.Equals(input.HttpsUrl))) return false;
            if (this.PipelineName != input.PipelineName || (this.PipelineName != null && !this.PipelineName.Equals(input.PipelineName))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.PipelineRunName != input.PipelineRunName || (this.PipelineRunName != null && !this.PipelineRunName.Equals(input.PipelineRunName))) return false;
            if (this.Event != input.Event || (this.Event != null && !this.Event.Equals(input.Event))) return false;
            if (this.Actor != input.Actor || (this.Actor != null && !this.Actor.Equals(input.Actor))) return false;
            if (this.Branch != input.Branch || (this.Branch != null && !this.Branch.Equals(input.Branch))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.HttpsUrl != null) hashCode = hashCode * 59 + this.HttpsUrl.GetHashCode();
                if (this.PipelineName != null) hashCode = hashCode * 59 + this.PipelineName.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.PipelineRunName != null) hashCode = hashCode * 59 + this.PipelineRunName.GetHashCode();
                if (this.Event != null) hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.Actor != null) hashCode = hashCode * 59 + this.Actor.GetHashCode();
                if (this.Branch != null) hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
