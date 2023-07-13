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
    public class ListWorkflowExecutionsResponse : SdkResponse
    {

        /// <summary>
        /// 流程执行信息列表
        /// </summary>
        [JsonProperty("executions", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlowExecutionBrief> Executions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWorkflowExecutionsResponse {\n");
            sb.Append("  executions: ").Append(Executions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWorkflowExecutionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWorkflowExecutionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Executions == input.Executions ||
                    this.Executions != null &&
                    input.Executions != null &&
                    this.Executions.SequenceEqual(input.Executions)
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
                if (this.Executions != null)
                    hashCode = hashCode * 59 + this.Executions.GetHashCode();
                return hashCode;
            }
        }
    }
}
