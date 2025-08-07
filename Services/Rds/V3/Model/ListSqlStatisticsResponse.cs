using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSqlStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 最新重置时间
        /// </summary>
        [JsonProperty("reset_view_last_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ResetViewLastTime { get; set; }

        /// <summary>
        /// 总的个数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 数据列表
        /// </summary>
        [JsonProperty("list", NullValueHandling = NullValueHandling.Ignore)]
        public List<Statistic> List { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSqlStatisticsResponse {\n");
            sb.Append("  resetViewLastTime: ").Append(ResetViewLastTime).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  list: ").Append(List).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSqlStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSqlStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.ResetViewLastTime != input.ResetViewLastTime || (this.ResetViewLastTime != null && !this.ResetViewLastTime.Equals(input.ResetViewLastTime))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.List != input.List || (this.List != null && input.List != null && !this.List.SequenceEqual(input.List))) return false;

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
                if (this.ResetViewLastTime != null) hashCode = hashCode * 59 + this.ResetViewLastTime.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.List != null) hashCode = hashCode * 59 + this.List.GetHashCode();
                return hashCode;
            }
        }
    }
}
