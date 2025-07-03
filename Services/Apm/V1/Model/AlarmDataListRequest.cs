using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 告警消息请求参数。
    /// </summary>
    public class AlarmDataListRequest 
    {

        /// <summary>
        /// 页码。
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// 每页数量。
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// region英文名称。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 组件环境名称。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 应用id。
        /// </summary>
        [JsonProperty("business_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BusinessId { get; set; }

        /// <summary>
        /// 监控项id。
        /// </summary>
        [JsonProperty("monitor_item_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? MonitorItemId { get; set; }

        /// <summary>
        /// 告警状态  RECOVER：已恢复 ABNORMAL：异常 ALERT：告警中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 告警级别  COMMON：轻微  CRITICAL：严重。
        /// </summary>
        [JsonProperty("alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmLevel { get; set; }

        /// <summary>
        /// 关键字。
        /// </summary>
        [JsonProperty("keyword", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// 告警开始时间。
        /// </summary>
        [JsonProperty("alarm_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmStartTime { get; set; }

        /// <summary>
        /// 告警结束时间。
        /// </summary>
        [JsonProperty("alarm_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmEndTime { get; set; }

        /// <summary>
        /// 采集器id。
        /// </summary>
        [JsonProperty("collector_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CollectorId { get; set; }

        /// <summary>
        /// 实例ip地址。
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 环境集合。
        /// </summary>
        [JsonProperty("env_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> EnvList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmDataListRequest {\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  businessId: ").Append(BusinessId).Append("\n");
            sb.Append("  monitorItemId: ").Append(MonitorItemId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  alarmLevel: ").Append(AlarmLevel).Append("\n");
            sb.Append("  keyword: ").Append(Keyword).Append("\n");
            sb.Append("  alarmStartTime: ").Append(AlarmStartTime).Append("\n");
            sb.Append("  alarmEndTime: ").Append(AlarmEndTime).Append("\n");
            sb.Append("  collectorId: ").Append(CollectorId).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  envList: ").Append(EnvList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmDataListRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmDataListRequest input)
        {
            if (input == null) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.BusinessId != input.BusinessId || (this.BusinessId != null && !this.BusinessId.Equals(input.BusinessId))) return false;
            if (this.MonitorItemId != input.MonitorItemId || (this.MonitorItemId != null && !this.MonitorItemId.Equals(input.MonitorItemId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.AlarmLevel != input.AlarmLevel || (this.AlarmLevel != null && !this.AlarmLevel.Equals(input.AlarmLevel))) return false;
            if (this.Keyword != input.Keyword || (this.Keyword != null && !this.Keyword.Equals(input.Keyword))) return false;
            if (this.AlarmStartTime != input.AlarmStartTime || (this.AlarmStartTime != null && !this.AlarmStartTime.Equals(input.AlarmStartTime))) return false;
            if (this.AlarmEndTime != input.AlarmEndTime || (this.AlarmEndTime != null && !this.AlarmEndTime.Equals(input.AlarmEndTime))) return false;
            if (this.CollectorId != input.CollectorId || (this.CollectorId != null && !this.CollectorId.Equals(input.CollectorId))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;
            if (this.EnvList != input.EnvList || (this.EnvList != null && input.EnvList != null && !this.EnvList.SequenceEqual(input.EnvList))) return false;

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
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.BusinessId != null) hashCode = hashCode * 59 + this.BusinessId.GetHashCode();
                if (this.MonitorItemId != null) hashCode = hashCode * 59 + this.MonitorItemId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AlarmLevel != null) hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                if (this.Keyword != null) hashCode = hashCode * 59 + this.Keyword.GetHashCode();
                if (this.AlarmStartTime != null) hashCode = hashCode * 59 + this.AlarmStartTime.GetHashCode();
                if (this.AlarmEndTime != null) hashCode = hashCode * 59 + this.AlarmEndTime.GetHashCode();
                if (this.CollectorId != null) hashCode = hashCode * 59 + this.CollectorId.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.EnvList != null) hashCode = hashCode * 59 + this.EnvList.GetHashCode();
                return hashCode;
            }
        }
    }
}
