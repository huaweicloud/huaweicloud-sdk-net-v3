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
    public class ListSlowlogStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonProperty("pageNumber", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonProperty("pageRecord", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageRecord { get; set; }

        /// <summary>
        /// 慢日志列表
        /// </summary>
        [JsonProperty("slowLogList", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlowLogStatistics> SlowLogList { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("totalRecord", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRecord { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSlowlogStatisticsResponse {\n");
            sb.Append("  pageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  pageRecord: ").Append(PageRecord).Append("\n");
            sb.Append("  slowLogList: ").Append(SlowLogList).Append("\n");
            sb.Append("  totalRecord: ").Append(TotalRecord).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSlowlogStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSlowlogStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.PageNumber != input.PageNumber || (this.PageNumber != null && !this.PageNumber.Equals(input.PageNumber))) return false;
            if (this.PageRecord != input.PageRecord || (this.PageRecord != null && !this.PageRecord.Equals(input.PageRecord))) return false;
            if (this.SlowLogList != input.SlowLogList || (this.SlowLogList != null && input.SlowLogList != null && !this.SlowLogList.SequenceEqual(input.SlowLogList))) return false;
            if (this.TotalRecord != input.TotalRecord || (this.TotalRecord != null && !this.TotalRecord.Equals(input.TotalRecord))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                if (this.PageNumber != null) hashCode = hashCode * 59 + this.PageNumber.GetHashCode();
                if (this.PageRecord != null) hashCode = hashCode * 59 + this.PageRecord.GetHashCode();
                if (this.SlowLogList != null) hashCode = hashCode * 59 + this.SlowLogList.GetHashCode();
                if (this.TotalRecord != null) hashCode = hashCode * 59 + this.TotalRecord.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
