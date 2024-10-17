using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAssetDailySummaryLogResponse : SdkResponse
    {

        /// <summary>
        /// 记录总数 
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 日志文件列表 
        /// </summary>
        [JsonProperty("summary_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssetDailySummaryResult> SummaryResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAssetDailySummaryLogResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  summaryResults: ").Append(SummaryResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAssetDailySummaryLogResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAssetDailySummaryLogResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.SummaryResults != input.SummaryResults || (this.SummaryResults != null && input.SummaryResults != null && !this.SummaryResults.SequenceEqual(input.SummaryResults))) return false;

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
                if (this.SummaryResults != null) hashCode = hashCode * 59 + this.SummaryResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
