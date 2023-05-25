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
    /// Request Object
    /// </summary>
    public class ShowVodStatisticsRequest 
    {

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。 
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 起始时间，格式为yyyymmddhhmmss。
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间，格式为yyyymmddhhmmss。 - “start_time”、“end_time”均不存在时，“start_time”取当天零点，“end_time”取当前时间。 - “start_time”不存在、“end_time”存在，请求非法。 - “start_time”存在、“end_time”不存在，“end_time”取当前时间。 - 只能查询最近三个月内的数据，且时间跨度不能超过31天。 - 起始时间和结束时间会自动规整，起始时间规整为指定时间所在的整点时刻，结束时间规整为指定时间所在时间的下一小时整点时刻。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 查询粒度间隔。  取值如下： - 时间跨度1天：1小时、4小时、8小时，分别对应3600秒、14400秒和28800秒。 - 时间跨度2~7天：1小时、4小时、8小时、1天，分别对应3600秒、14400秒、28800秒和86400秒。 - 时间跨度8~31天：4小时、8小时、1天，分别对应14400秒、28800秒和86400秒。  单位：秒。  若不设置，默认取对应时间跨度的最小间隔。
        /// </summary>
        [SDKProperty("interval", IsQuery = true)]
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowVodStatisticsRequest {\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowVodStatisticsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowVodStatisticsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XSdkDate == input.XSdkDate ||
                    (this.XSdkDate != null &&
                    this.XSdkDate.Equals(input.XSdkDate))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
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
                if (this.XSdkDate != null)
                    hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                return hashCode;
            }
        }
    }
}
