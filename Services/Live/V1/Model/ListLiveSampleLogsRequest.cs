using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListLiveSampleLogsRequest 
    {

        /// <summary>
        /// 播放域名。
        /// </summary>
        [SDKProperty("play_domain", IsQuery = true)]
        [JsonProperty("play_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayDomain { get; set; }

        /// <summary>
        /// 查询开始时间，UTC时间：YYYY-MM-DDTHH:mm:ssZ，如北京时间2020年3月4日16点00分00秒可表示为2020-03-04T08:00:00Z。仅支持查询最近3个月内的数据。
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 查询结束时间，UTC时间：YYYY-MM-DDTHH:mm:ssZ，如北京时间2020年3月4日16点00分00秒可表示为2020-03-04T08:00:00Z。查询时间跨度不能大于7天。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLiveSampleLogsRequest {\n");
            sb.Append("  playDomain: ").Append(PlayDomain).Append("\n");
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
            return this.Equals(input as ListLiveSampleLogsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLiveSampleLogsRequest input)
        {
            if (input == null) return false;
            if (this.PlayDomain != input.PlayDomain || (this.PlayDomain != null && !this.PlayDomain.Equals(input.PlayDomain))) return false;
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
                if (this.PlayDomain != null) hashCode = hashCode * 59 + this.PlayDomain.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
