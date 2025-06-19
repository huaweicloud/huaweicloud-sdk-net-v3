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
    /// 整体缺陷信息
    /// </summary>
    public class DefectVo 
    {

        /// <summary>
        /// 缺陷数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 未关闭缺陷数
        /// </summary>
        [JsonProperty("not_solved", NullValueHandling = NullValueHandling.Ignore)]
        public int? NotSolved { get; set; }

        /// <summary>
        /// 组装缺陷每种重要程度的名称和对应的数目
        /// </summary>
        [JsonProperty("severity_number_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<NameAndValueVo> SeverityNumberList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefectVo {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  notSolved: ").Append(NotSolved).Append("\n");
            sb.Append("  severityNumberList: ").Append(SeverityNumberList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DefectVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DefectVo input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.NotSolved != input.NotSolved || (this.NotSolved != null && !this.NotSolved.Equals(input.NotSolved))) return false;
            if (this.SeverityNumberList != input.SeverityNumberList || (this.SeverityNumberList != null && input.SeverityNumberList != null && !this.SeverityNumberList.SequenceEqual(input.SeverityNumberList))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.NotSolved != null) hashCode = hashCode * 59 + this.NotSolved.GetHashCode();
                if (this.SeverityNumberList != null) hashCode = hashCode * 59 + this.SeverityNumberList.GetHashCode();
                return hashCode;
            }
        }
    }
}
