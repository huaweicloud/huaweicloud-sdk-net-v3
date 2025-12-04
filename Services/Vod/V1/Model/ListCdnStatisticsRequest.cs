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
    public class ListCdnStatisticsRequest 
    {

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。 
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 开始时间，格式为yyyymmddhhmmss。   - interval为300时，end_time设置为整5分钟时刻点，如：20240601000000。   - interval为3600时，end_time设置为整小时时刻点，如：20240601120000。   - interval为86400时，end_time设置为东8区零点时刻点，如：20240601000000。   - 只能查询最近三个月内的数据，且时间跨度不能超过31天。
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间，格式为yyyymmddhhmmss。   - interval为300时，end_time设置为整5分钟时刻点，如：20240601000000。   - interval为3600时，end_time设置为整小时时刻点，如：20240601120000。   - interval为86400时，end_time设置为东8区零点时刻点，如：20240601000000。   - 只能查询最近三个月内的数据，且时间跨度不能超过31天。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 统计数据类型。  取值如下： - bw：CDN峰值带宽 - flux：CDN流量 - req_num：请求总数 - req_hit_rate：请求命中率 - flux_hit_rate：流量命中率 - http_code_2xx 状态码汇总2xx - http_code_3xx 状态码汇总3xx - http_code_4xx 状态码汇总4xx - http_code_5xx 状态码汇总5xx  每次只能查询一种统计数据。
        /// </summary>
        [SDKProperty("stat_type", IsQuery = true)]
        [JsonProperty("stat_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StatType { get; set; }

        /// <summary>
        /// 域名列表，多个域名以逗号（半角）分隔。  示例：example.test1.com,example.test2.com。  ALL表示查询名下全部域名。一次最多查询20个域名。
        /// </summary>
        [SDKProperty("domain", IsQuery = true)]
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 查询粒度间隔。  取值如下： - 300(5分钟)：最大查询跨度2天。 - 3600(1小时)：最大查询跨度7天。 - 86400(1天)：最大查询跨度31天，最少跨度为2天。  单位：秒。  若不设置，小于1天 300，大于1天小于7天3600，大于7天86400。
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
            sb.Append("class ListCdnStatisticsRequest {\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  statType: ").Append(StatType).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCdnStatisticsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCdnStatisticsRequest input)
        {
            if (input == null) return false;
            if (this.XSdkDate != input.XSdkDate || (this.XSdkDate != null && !this.XSdkDate.Equals(input.XSdkDate))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.StatType != input.StatType || (this.StatType != null && !this.StatType.Equals(input.StatType))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.Interval != input.Interval || (this.Interval != null && !this.Interval.Equals(input.Interval))) return false;

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
                if (this.XSdkDate != null) hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StatType != null) hashCode = hashCode * 59 + this.StatType.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Interval != null) hashCode = hashCode * 59 + this.Interval.GetHashCode();
                return hashCode;
            }
        }
    }
}
