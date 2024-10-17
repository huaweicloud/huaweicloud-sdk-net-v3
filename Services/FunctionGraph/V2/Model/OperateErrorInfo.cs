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
    /// 批量执行错误信息
    /// </summary>
    public class OperateErrorInfo 
    {

        /// <summary>
        /// 唯一标识ID，流程URN
        /// </summary>
        [JsonProperty("workflow_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowUrn { get; set; }

        /// <summary>
        /// 错误详情
        /// </summary>
        [JsonProperty("error_detail", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorDetail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperateErrorInfo {\n");
            sb.Append("  workflowUrn: ").Append(WorkflowUrn).Append("\n");
            sb.Append("  errorDetail: ").Append(ErrorDetail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperateErrorInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperateErrorInfo input)
        {
            if (input == null) return false;
            if (this.WorkflowUrn != input.WorkflowUrn || (this.WorkflowUrn != null && !this.WorkflowUrn.Equals(input.WorkflowUrn))) return false;
            if (this.ErrorDetail != input.ErrorDetail || (this.ErrorDetail != null && !this.ErrorDetail.Equals(input.ErrorDetail))) return false;

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
                if (this.WorkflowUrn != null) hashCode = hashCode * 59 + this.WorkflowUrn.GetHashCode();
                if (this.ErrorDetail != null) hashCode = hashCode * 59 + this.ErrorDetail.GetHashCode();
                return hashCode;
            }
        }
    }
}
