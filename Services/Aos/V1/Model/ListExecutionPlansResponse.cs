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
        /// 执行计划列表。默认按照生成时间降序排序，最新生成的在最前
        /// </summary>
        [JsonProperty("execution_plans", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExecutionPlan> ExecutionPlans { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListExecutionPlansResponse {\n");
            sb.Append("  executionPlans: ").Append(ExecutionPlans).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
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
            if (input == null) return false;
            if (this.ExecutionPlans != input.ExecutionPlans || (this.ExecutionPlans != null && input.ExecutionPlans != null && !this.ExecutionPlans.SequenceEqual(input.ExecutionPlans))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.ExecutionPlans != null) hashCode = hashCode * 59 + this.ExecutionPlans.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
