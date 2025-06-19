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
    /// 计算用例完成率
    /// </summary>
    public class CaseCompletionRateVo 
    {

        /// <summary>
        /// 总用例数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 用例完成率
        /// </summary>
        [JsonProperty("completion_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string CompletionRate { get; set; }

        /// <summary>
        /// 用户自定义状态对应的用例数目
        /// </summary>
        [JsonProperty("status_number_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<NameAndValueVo> StatusNumberList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseCompletionRateVo {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  completionRate: ").Append(CompletionRate).Append("\n");
            sb.Append("  statusNumberList: ").Append(StatusNumberList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CaseCompletionRateVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CaseCompletionRateVo input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.CompletionRate != input.CompletionRate || (this.CompletionRate != null && !this.CompletionRate.Equals(input.CompletionRate))) return false;
            if (this.StatusNumberList != input.StatusNumberList || (this.StatusNumberList != null && input.StatusNumberList != null && !this.StatusNumberList.SequenceEqual(input.StatusNumberList))) return false;

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
                if (this.CompletionRate != null) hashCode = hashCode * 59 + this.CompletionRate.GetHashCode();
                if (this.StatusNumberList != null) hashCode = hashCode * 59 + this.StatusNumberList.GetHashCode();
                return hashCode;
            }
        }
    }
}
