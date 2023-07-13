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
    public class BatchDeleteWorkflowsResponse : SdkResponse
    {

        /// <summary>
        /// 成功流程URN列表
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Success { get; set; }

        /// <summary>
        /// 错误流程详情
        /// </summary>
        [JsonProperty("fail", NullValueHandling = NullValueHandling.Ignore)]
        public List<OperateErrorInfo> Fail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteWorkflowsResponse {\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  fail: ").Append(Fail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteWorkflowsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteWorkflowsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Success == input.Success ||
                    this.Success != null &&
                    input.Success != null &&
                    this.Success.SequenceEqual(input.Success)
                ) && 
                (
                    this.Fail == input.Fail ||
                    this.Fail != null &&
                    input.Fail != null &&
                    this.Fail.SequenceEqual(input.Fail)
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
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Fail != null)
                    hashCode = hashCode * 59 + this.Fail.GetHashCode();
                return hashCode;
            }
        }
    }
}
