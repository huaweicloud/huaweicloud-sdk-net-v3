using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 返回结果
    /// </summary>
    public class ListJunitCoverageSummaryResult 
    {

        /// <summary>
        /// 单元测试覆盖率报告列表
        /// </summary>
        [JsonProperty("unit_summary_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListJunitCoverageSummaryResultUnitSummaryList> UnitSummaryList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListJunitCoverageSummaryResult {\n");
            sb.Append("  unitSummaryList: ").Append(UnitSummaryList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListJunitCoverageSummaryResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListJunitCoverageSummaryResult input)
        {
            if (input == null) return false;
            if (this.UnitSummaryList != input.UnitSummaryList || (this.UnitSummaryList != null && input.UnitSummaryList != null && !this.UnitSummaryList.SequenceEqual(input.UnitSummaryList))) return false;

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
                if (this.UnitSummaryList != null) hashCode = hashCode * 59 + this.UnitSummaryList.GetHashCode();
                return hashCode;
            }
        }
    }
}
