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
    /// 监控项数据结构。
    /// </summary>
    public class MonitorItem 
    {

        /// <summary>
        /// 监控项id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// 环境id。
        /// </summary>
        [JsonProperty("env_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnvId { get; set; }

        /// <summary>
        /// 采集器id。
        /// </summary>
        [JsonProperty("collector_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CollectorId { get; set; }

        /// <summary>
        /// 采集器名称。
        /// </summary>
        [JsonProperty("collector_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CollectorName { get; set; }

        /// <summary>
        /// 采集器展示名称。
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 采集间隔。
        /// </summary>
        [JsonProperty("collect_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? CollectInterval { get; set; }

        /// <summary>
        /// 是否禁用。
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// 修改采集状态用户id。
        /// </summary>
        [JsonProperty("status_change_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusChangeUserId { get; set; }

        /// <summary>
        /// 修改采集状态用户名称。
        /// </summary>
        [JsonProperty("status_change_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusChangeUserName { get; set; }

        /// <summary>
        /// 修改采集状态时间。
        /// </summary>
        [JsonProperty("status_change_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusChangeTime { get; set; }

        /// <summary>
        /// 修改采集配置用户id。
        /// </summary>
        [JsonProperty("config_change_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigChangeUserId { get; set; }

        /// <summary>
        /// 修改采集配置用户名称。
        /// </summary>
        [JsonProperty("config_change_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigChangeUserName { get; set; }

        /// <summary>
        /// 修改采集配置时间。
        /// </summary>
        [JsonProperty("config_change_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigChangeTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MonitorItem {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  envId: ").Append(EnvId).Append("\n");
            sb.Append("  collectorId: ").Append(CollectorId).Append("\n");
            sb.Append("  collectorName: ").Append(CollectorName).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  collectInterval: ").Append(CollectInterval).Append("\n");
            sb.Append("  disabled: ").Append(Disabled).Append("\n");
            sb.Append("  statusChangeUserId: ").Append(StatusChangeUserId).Append("\n");
            sb.Append("  statusChangeUserName: ").Append(StatusChangeUserName).Append("\n");
            sb.Append("  statusChangeTime: ").Append(StatusChangeTime).Append("\n");
            sb.Append("  configChangeUserId: ").Append(ConfigChangeUserId).Append("\n");
            sb.Append("  configChangeUserName: ").Append(ConfigChangeUserName).Append("\n");
            sb.Append("  configChangeTime: ").Append(ConfigChangeTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MonitorItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MonitorItem input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.EnvId != input.EnvId || (this.EnvId != null && !this.EnvId.Equals(input.EnvId))) return false;
            if (this.CollectorId != input.CollectorId || (this.CollectorId != null && !this.CollectorId.Equals(input.CollectorId))) return false;
            if (this.CollectorName != input.CollectorName || (this.CollectorName != null && !this.CollectorName.Equals(input.CollectorName))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.CollectInterval != input.CollectInterval || (this.CollectInterval != null && !this.CollectInterval.Equals(input.CollectInterval))) return false;
            if (this.Disabled != input.Disabled || (this.Disabled != null && !this.Disabled.Equals(input.Disabled))) return false;
            if (this.StatusChangeUserId != input.StatusChangeUserId || (this.StatusChangeUserId != null && !this.StatusChangeUserId.Equals(input.StatusChangeUserId))) return false;
            if (this.StatusChangeUserName != input.StatusChangeUserName || (this.StatusChangeUserName != null && !this.StatusChangeUserName.Equals(input.StatusChangeUserName))) return false;
            if (this.StatusChangeTime != input.StatusChangeTime || (this.StatusChangeTime != null && !this.StatusChangeTime.Equals(input.StatusChangeTime))) return false;
            if (this.ConfigChangeUserId != input.ConfigChangeUserId || (this.ConfigChangeUserId != null && !this.ConfigChangeUserId.Equals(input.ConfigChangeUserId))) return false;
            if (this.ConfigChangeUserName != input.ConfigChangeUserName || (this.ConfigChangeUserName != null && !this.ConfigChangeUserName.Equals(input.ConfigChangeUserName))) return false;
            if (this.ConfigChangeTime != input.ConfigChangeTime || (this.ConfigChangeTime != null && !this.ConfigChangeTime.Equals(input.ConfigChangeTime))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EnvId != null) hashCode = hashCode * 59 + this.EnvId.GetHashCode();
                if (this.CollectorId != null) hashCode = hashCode * 59 + this.CollectorId.GetHashCode();
                if (this.CollectorName != null) hashCode = hashCode * 59 + this.CollectorName.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.CollectInterval != null) hashCode = hashCode * 59 + this.CollectInterval.GetHashCode();
                if (this.Disabled != null) hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.StatusChangeUserId != null) hashCode = hashCode * 59 + this.StatusChangeUserId.GetHashCode();
                if (this.StatusChangeUserName != null) hashCode = hashCode * 59 + this.StatusChangeUserName.GetHashCode();
                if (this.StatusChangeTime != null) hashCode = hashCode * 59 + this.StatusChangeTime.GetHashCode();
                if (this.ConfigChangeUserId != null) hashCode = hashCode * 59 + this.ConfigChangeUserId.GetHashCode();
                if (this.ConfigChangeUserName != null) hashCode = hashCode * 59 + this.ConfigChangeUserName.GetHashCode();
                if (this.ConfigChangeTime != null) hashCode = hashCode * 59 + this.ConfigChangeTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
