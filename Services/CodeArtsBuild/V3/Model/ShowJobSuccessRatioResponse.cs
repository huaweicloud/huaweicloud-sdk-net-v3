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
    /// Response Object
    /// </summary>
    public class ShowJobSuccessRatioResponse : SdkResponse
    {

        /// <summary>
        /// 任务成功构建次数
        /// </summary>
        [JsonProperty("success_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// 任务构建总次数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 任务成功率,精确到小数点后两位
        /// </summary>
        [JsonProperty("success_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public double? SuccessRatio { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowJobSuccessRatioResponse {\n");
            sb.Append("  successCount: ").Append(SuccessCount).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  successRatio: ").Append(SuccessRatio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowJobSuccessRatioResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowJobSuccessRatioResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SuccessCount == input.SuccessCount ||
                    (this.SuccessCount != null &&
                    this.SuccessCount.Equals(input.SuccessCount))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.SuccessRatio == input.SuccessRatio ||
                    (this.SuccessRatio != null &&
                    this.SuccessRatio.Equals(input.SuccessRatio))
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
                if (this.SuccessCount != null)
                    hashCode = hashCode * 59 + this.SuccessCount.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.SuccessRatio != null)
                    hashCode = hashCode * 59 + this.SuccessRatio.GetHashCode();
                return hashCode;
            }
        }
    }
}
