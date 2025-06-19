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
    /// 计算用例通过率
    /// </summary>
    public class CasePassRateVo 
    {

        /// <summary>
        /// 用例通过率
        /// </summary>
        [JsonProperty("pass_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string PassRate { get; set; }

        /// <summary>
        /// 用户自定义结果对应的用例数目
        /// </summary>
        [JsonProperty("result_number_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<NameAndValueVo> ResultNumberList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CasePassRateVo {\n");
            sb.Append("  passRate: ").Append(PassRate).Append("\n");
            sb.Append("  resultNumberList: ").Append(ResultNumberList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CasePassRateVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CasePassRateVo input)
        {
            if (input == null) return false;
            if (this.PassRate != input.PassRate || (this.PassRate != null && !this.PassRate.Equals(input.PassRate))) return false;
            if (this.ResultNumberList != input.ResultNumberList || (this.ResultNumberList != null && input.ResultNumberList != null && !this.ResultNumberList.SequenceEqual(input.ResultNumberList))) return false;

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
                if (this.PassRate != null) hashCode = hashCode * 59 + this.PassRate.GetHashCode();
                if (this.ResultNumberList != null) hashCode = hashCode * 59 + this.ResultNumberList.GetHashCode();
                return hashCode;
            }
        }
    }
}
