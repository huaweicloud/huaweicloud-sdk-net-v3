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
    public class UpdateWorkFlowResponse : SdkResponse
    {

        /// <summary>
        /// 函数流是否返回流式数据
        /// </summary>
        [JsonProperty("enable_stream_response", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableStreamResponse { get; set; }

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
        /// 流程定义名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 流程定义描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateWorkFlowResponse {\n");
            sb.Append("  enableStreamResponse: ").Append(EnableStreamResponse).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  workflowUrn: ").Append(WorkflowUrn).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  updatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateWorkFlowResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateWorkFlowResponse input)
        {
            if (input == null) return false;
            if (this.EnableStreamResponse != input.EnableStreamResponse || (this.EnableStreamResponse != null && !this.EnableStreamResponse.Equals(input.EnableStreamResponse))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.WorkflowUrn != input.WorkflowUrn || (this.WorkflowUrn != null && !this.WorkflowUrn.Equals(input.WorkflowUrn))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.UpdatedTime != input.UpdatedTime || (this.UpdatedTime != null && !this.UpdatedTime.Equals(input.UpdatedTime))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;

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
                if (this.EnableStreamResponse != null) hashCode = hashCode * 59 + this.EnableStreamResponse.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.WorkflowUrn != null) hashCode = hashCode * 59 + this.WorkflowUrn.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.UpdatedTime != null) hashCode = hashCode * 59 + this.UpdatedTime.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                return hashCode;
            }
        }
    }
}
