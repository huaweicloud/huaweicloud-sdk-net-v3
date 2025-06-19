using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 实际的数据类型：单个对象，集合 或 NULL
    /// </summary>
    public class RequirementsOverviewVo 
    {

        /// <summary>
        /// 质量报告需求测试情况总数
        /// </summary>
        [JsonProperty("total_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNumber { get; set; }

        /// <summary>
        /// 质量报告需求测试情况列表
        /// </summary>
        [JsonProperty("requirement_overview_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RequirementOverviewVo> RequirementOverviewList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequirementsOverviewVo {\n");
            sb.Append("  totalNumber: ").Append(TotalNumber).Append("\n");
            sb.Append("  requirementOverviewList: ").Append(RequirementOverviewList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RequirementsOverviewVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RequirementsOverviewVo input)
        {
            if (input == null) return false;
            if (this.TotalNumber != input.TotalNumber || (this.TotalNumber != null && !this.TotalNumber.Equals(input.TotalNumber))) return false;
            if (this.RequirementOverviewList != input.RequirementOverviewList || (this.RequirementOverviewList != null && input.RequirementOverviewList != null && !this.RequirementOverviewList.SequenceEqual(input.RequirementOverviewList))) return false;

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
                if (this.TotalNumber != null) hashCode = hashCode * 59 + this.TotalNumber.GetHashCode();
                if (this.RequirementOverviewList != null) hashCode = hashCode * 59 + this.RequirementOverviewList.GetHashCode();
                return hashCode;
            }
        }
    }
}
