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
    /// 需求覆盖率
    /// </summary>
    public class CoverRateVo 
    {

        /// <summary>
        /// 统计测试中的需求
        /// </summary>
        [JsonProperty("testing", NullValueHandling = NullValueHandling.Ignore)]
        public int? Testing { get; set; }

        /// <summary>
        /// 统计已完成的需求
        /// </summary>
        [JsonProperty("finished", NullValueHandling = NullValueHandling.Ignore)]
        public int? Finished { get; set; }

        /// <summary>
        /// 统计未测试的需求
        /// </summary>
        [JsonProperty("not_tested", NullValueHandling = NullValueHandling.Ignore)]
        public int? NotTested { get; set; }

        /// <summary>
        /// 计算需求总数
        /// </summary>
        [JsonProperty("total_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNumber { get; set; }

        /// <summary>
        /// 需求覆盖率
        /// </summary>
        [JsonProperty("cover_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverRate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoverRateVo {\n");
            sb.Append("  testing: ").Append(Testing).Append("\n");
            sb.Append("  finished: ").Append(Finished).Append("\n");
            sb.Append("  notTested: ").Append(NotTested).Append("\n");
            sb.Append("  totalNumber: ").Append(TotalNumber).Append("\n");
            sb.Append("  coverRate: ").Append(CoverRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CoverRateVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CoverRateVo input)
        {
            if (input == null) return false;
            if (this.Testing != input.Testing || (this.Testing != null && !this.Testing.Equals(input.Testing))) return false;
            if (this.Finished != input.Finished || (this.Finished != null && !this.Finished.Equals(input.Finished))) return false;
            if (this.NotTested != input.NotTested || (this.NotTested != null && !this.NotTested.Equals(input.NotTested))) return false;
            if (this.TotalNumber != input.TotalNumber || (this.TotalNumber != null && !this.TotalNumber.Equals(input.TotalNumber))) return false;
            if (this.CoverRate != input.CoverRate || (this.CoverRate != null && !this.CoverRate.Equals(input.CoverRate))) return false;

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
                if (this.Testing != null) hashCode = hashCode * 59 + this.Testing.GetHashCode();
                if (this.Finished != null) hashCode = hashCode * 59 + this.Finished.GetHashCode();
                if (this.NotTested != null) hashCode = hashCode * 59 + this.NotTested.GetHashCode();
                if (this.TotalNumber != null) hashCode = hashCode * 59 + this.TotalNumber.GetHashCode();
                if (this.CoverRate != null) hashCode = hashCode * 59 + this.CoverRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
