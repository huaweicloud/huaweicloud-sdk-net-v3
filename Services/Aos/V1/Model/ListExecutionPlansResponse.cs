using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListExecutionPlansResponse : SdkResponse
    {

        /// <summary>
        /// 执行计划的元数据
        /// </summary>
        [JsonProperty("execution_plans", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExecutionPlan> ExecutionPlans { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListExecutionPlansResponse {\n");
            sb.Append("  executionPlans: ").Append(ExecutionPlans).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListExecutionPlansResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListExecutionPlansResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExecutionPlans == input.ExecutionPlans ||
                    this.ExecutionPlans != null &&
                    input.ExecutionPlans != null &&
                    this.ExecutionPlans.SequenceEqual(input.ExecutionPlans)
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
                if (this.ExecutionPlans != null)
                    hashCode = hashCode * 59 + this.ExecutionPlans.GetHashCode();
                return hashCode;
            }
        }
    }
}
