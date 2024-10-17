using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowWorkFlowResponse : SdkResponse
    {

        /// <summary>
        /// 唯一标识ID，流程定义ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 函数工作流URN, 格式为： urn:fss:&lt;region_id&gt;:&lt;project_id&gt;:workflow:\\&lt;package\\&gt;:&lt;workflow_name&gt;:\\&lt;version\\&gt; 注意： package当前只支持default version当前只支持latest
        /// </summary>
        [JsonProperty("workflow_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowUrn { get; set; }

        /// <summary>
        /// 流程创建时间，格式：yyyy-MM-ddTHH:mm:ssZ，UTC时间
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 流程修改时间，格式：yyyy-MM-ddTHH:mm:ssZ，UTC时间
        /// </summary>
        [JsonProperty("updated_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedTime { get; set; }

        /// <summary>
        /// 流程创建者
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 快速函数流日志组ID，仅快速模式函数流且日志级别不为NONE时
        /// </summary>
        [JsonProperty("lts_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsGroupId { get; set; }

        /// <summary>
        /// 快速函数流日志流ID，仅快速模式函数流且日志级别不为NONE时返回。
        /// </summary>
        [JsonProperty("lts_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsStreamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("definition", NullValueHandling = NullValueHandling.Ignore)]
        public WorkflowCreateBody Definition { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowWorkFlowResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  workflowUrn: ").Append(WorkflowUrn).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  updatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ltsGroupId: ").Append(LtsGroupId).Append("\n");
            sb.Append("  ltsStreamId: ").Append(LtsStreamId).Append("\n");
            sb.Append("  definition: ").Append(Definition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowWorkFlowResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowWorkFlowResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.WorkflowUrn != input.WorkflowUrn || (this.WorkflowUrn != null && !this.WorkflowUrn.Equals(input.WorkflowUrn))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.UpdatedTime != input.UpdatedTime || (this.UpdatedTime != null && !this.UpdatedTime.Equals(input.UpdatedTime))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.LtsGroupId != input.LtsGroupId || (this.LtsGroupId != null && !this.LtsGroupId.Equals(input.LtsGroupId))) return false;
            if (this.LtsStreamId != input.LtsStreamId || (this.LtsStreamId != null && !this.LtsStreamId.Equals(input.LtsStreamId))) return false;
            if (this.Definition != input.Definition || (this.Definition != null && !this.Definition.Equals(input.Definition))) return false;

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
                if (this.WorkflowUrn != null) hashCode = hashCode * 59 + this.WorkflowUrn.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.UpdatedTime != null) hashCode = hashCode * 59 + this.UpdatedTime.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.LtsGroupId != null) hashCode = hashCode * 59 + this.LtsGroupId.GetHashCode();
                if (this.LtsStreamId != null) hashCode = hashCode * 59 + this.LtsStreamId.GetHashCode();
                if (this.Definition != null) hashCode = hashCode * 59 + this.Definition.GetHashCode();
                return hashCode;
            }
        }
    }
}
