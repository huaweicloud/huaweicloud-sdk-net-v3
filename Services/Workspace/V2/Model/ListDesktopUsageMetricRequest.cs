using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListDesktopUsageMetricRequest 
    {

        /// <summary>
        /// 查询起始时间(0时区) 云服务每天凌晨02:00进行聚合运算前一天00:00:00~23:59:59的使用时长,并将周期范围内的数据聚合到周期边界上 跨天的记录会按照统计周期进行计算 假设一天内桌面登录多次，09:00~12:00,13:00~21:00,22:00~01:00(次日): 则当天的累计使用时长数据会被汇聚到23:59:59这个点;总使用时长为 3hours(09:00~12:00)+8hours(13:00~21:00)+2hours(22:00~00:00) 如果查询的from-to不足一个周期内，可能造成查询到数据为空；
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 查询截至时间(0时区)
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 资源名称(模糊匹配)
        /// </summary>
        [SDKProperty("resource_name", IsQuery = true)]
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 最小空闲天数
        /// </summary>
        [SDKProperty("min_idle_days", IsQuery = true)]
        [JsonProperty("min_idle_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinIdleDays { get; set; }

        /// <summary>
        /// 最大空闲天数 min_idle_days、max_idle_days都非空时,max_idle_days必须大于等于min_idle_days否则可能查询不到数据
        /// </summary>
        [SDKProperty("max_idle_days", IsQuery = true)]
        [JsonProperty("max_idle_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxIdleDays { get; set; }

        /// <summary>
        /// 使用时长(hour)最小值
        /// </summary>
        [SDKProperty("usage_min_hours", IsQuery = true)]
        [JsonProperty("usage_min_hours", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsageMinHours { get; set; }

        /// <summary>
        /// 使用时长(hour)最大值(必须大于等于usage_min_hours)
        /// </summary>
        [SDKProperty("usage_max_hours", IsQuery = true)]
        [JsonProperty("usage_max_hours", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsageMaxHours { get; set; }

        /// <summary>
        /// 按照指标进行排序 * &#x60;desktop_usage&#x60; -  按照桌面使用时长排序 * &#x60;desktop_idle_duration&#x60; -  按照桌面空闲周期排序
        /// </summary>
        [SDKProperty("sort_field", IsQuery = true)]
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public string SortField { get; set; }

        /// <summary>
        /// 按照指标进行排序的方向;需配合sort_field一起使用 * &#x60;DESC&#x60; - 降序返回数据 * &#x60;ASC&#x60; -  升序返回数据
        /// </summary>
        [SDKProperty("sort_type", IsQuery = true)]
        [JsonProperty("sort_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SortType { get; set; }

        /// <summary>
        /// 查询的偏移量,默认值0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// limit范围[1-100],默认值0
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDesktopUsageMetricRequest {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  minIdleDays: ").Append(MinIdleDays).Append("\n");
            sb.Append("  maxIdleDays: ").Append(MaxIdleDays).Append("\n");
            sb.Append("  usageMinHours: ").Append(UsageMinHours).Append("\n");
            sb.Append("  usageMaxHours: ").Append(UsageMaxHours).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  sortType: ").Append(SortType).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDesktopUsageMetricRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDesktopUsageMetricRequest input)
        {
            if (input == null) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.MinIdleDays != input.MinIdleDays || (this.MinIdleDays != null && !this.MinIdleDays.Equals(input.MinIdleDays))) return false;
            if (this.MaxIdleDays != input.MaxIdleDays || (this.MaxIdleDays != null && !this.MaxIdleDays.Equals(input.MaxIdleDays))) return false;
            if (this.UsageMinHours != input.UsageMinHours || (this.UsageMinHours != null && !this.UsageMinHours.Equals(input.UsageMinHours))) return false;
            if (this.UsageMaxHours != input.UsageMaxHours || (this.UsageMaxHours != null && !this.UsageMaxHours.Equals(input.UsageMaxHours))) return false;
            if (this.SortField != input.SortField || (this.SortField != null && !this.SortField.Equals(input.SortField))) return false;
            if (this.SortType != input.SortType || (this.SortType != null && !this.SortType.Equals(input.SortType))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.MinIdleDays != null) hashCode = hashCode * 59 + this.MinIdleDays.GetHashCode();
                if (this.MaxIdleDays != null) hashCode = hashCode * 59 + this.MaxIdleDays.GetHashCode();
                if (this.UsageMinHours != null) hashCode = hashCode * 59 + this.UsageMinHours.GetHashCode();
                if (this.UsageMaxHours != null) hashCode = hashCode * 59 + this.UsageMaxHours.GetHashCode();
                if (this.SortField != null) hashCode = hashCode * 59 + this.SortField.GetHashCode();
                if (this.SortType != null) hashCode = hashCode * 59 + this.SortType.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
