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
    /// 函数流批量删除Body体
    /// </summary>
    public class BatchDeleteWorkflowsRequestBody 
    {

        /// <summary>
        /// 流程URN列表
        /// </summary>
        [JsonProperty("workflow_urns", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> WorkflowUrns { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteWorkflowsRequestBody {\n");
            sb.Append("  workflowUrns: ").Append(WorkflowUrns).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteWorkflowsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteWorkflowsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WorkflowUrns == input.WorkflowUrns ||
                    this.WorkflowUrns != null &&
                    input.WorkflowUrns != null &&
                    this.WorkflowUrns.SequenceEqual(input.WorkflowUrns)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.WorkflowUrns != null)
                    hashCode = hashCode * 59 + this.WorkflowUrns.GetHashCode();
                return hashCode;
            }
        }
    }
}
