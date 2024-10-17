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
    public class StartWorkflowExecutionResponse : SdkResponse
    {

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("execution_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartWorkflowExecutionResponse {\n");
            sb.Append("  executionId: ").Append(ExecutionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartWorkflowExecutionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartWorkflowExecutionResponse input)
        {
            if (input == null) return false;
            if (this.ExecutionId != input.ExecutionId || (this.ExecutionId != null && !this.ExecutionId.Equals(input.ExecutionId))) return false;

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
                if (this.ExecutionId != null) hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
