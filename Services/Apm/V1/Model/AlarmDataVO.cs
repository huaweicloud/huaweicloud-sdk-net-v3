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
    /// 告警信息视图。
    /// </summary>
    public class AlarmDataVO 
    {

        /// <summary>
        /// 告警通知id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("gmt_create", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// region中事件的id。
        /// </summary>
        [JsonProperty("region_alarm_event_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? RegionAlarmEventId { get; set; }

        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("business_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessName { get; set; }

        /// <summary>
        /// 组件名称。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 版本。
        /// </summary>
        [JsonProperty("version_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? VersionNumber { get; set; }

        /// <summary>
        /// 告警规则类别。
        /// </summary>
        [JsonProperty("alarm_rule_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleType { get; set; }

        /// <summary>
        /// 修改时间。
        /// </summary>
        [JsonProperty("gmt_modify", NullValueHandling = NullValueHandling.Ignore)]
        public string GmtModify { get; set; }

        /// <summary>
        /// 处理单元。
        /// </summary>
        [JsonProperty("process_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessUnit { get; set; }

        /// <summary>
        /// 区域名称。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 实例id。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// 实例ip地址。
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 环境id。
        /// </summary>
        [JsonProperty("env_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnvId { get; set; }

        /// <summary>
        /// 应用id。
        /// </summary>
        [JsonProperty("business_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BusinessId { get; set; }

        /// <summary>
        /// 模板id。
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// 告警规则id。
        /// </summary>
        [JsonProperty("alarm_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? AlarmRuleId { get; set; }

        /// <summary>
        /// 监控项id。
        /// </summary>
        [JsonProperty("monitor_item_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? MonitorItemId { get; set; }

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
        /// 告警规则名称。
        /// </summary>
        [JsonProperty("alarm_rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleName { get; set; }

        /// <summary>
        /// 告警表达式。
        /// </summary>
        [JsonProperty("alarm_rule_expression", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleExpression { get; set; }

        /// <summary>
        /// 开始报警时间。
        /// </summary>
        [JsonProperty("alarm_first_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmFirstTime { get; set; }

        /// <summary>
        /// 最后一次报警时间。
        /// </summary>
        [JsonProperty("alarm_last_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmLastTime { get; set; }

        /// <summary>
        /// 告警级别。
        /// </summary>
        [JsonProperty("alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmLevel { get; set; }

        /// <summary>
        /// 唯一告警标识符。
        /// </summary>
        [JsonProperty("restrain_key", NullValueHandling = NullValueHandling.Ignore)]
        public string RestrainKey { get; set; }

        /// <summary>
        /// 告警状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmDataVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  gmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  regionAlarmEventId: ").Append(RegionAlarmEventId).Append("\n");
            sb.Append("  businessName: ").Append(BusinessName).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  versionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  alarmRuleType: ").Append(AlarmRuleType).Append("\n");
            sb.Append("  gmtModify: ").Append(GmtModify).Append("\n");
            sb.Append("  processUnit: ").Append(ProcessUnit).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  envId: ").Append(EnvId).Append("\n");
            sb.Append("  businessId: ").Append(BusinessId).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  alarmRuleId: ").Append(AlarmRuleId).Append("\n");
            sb.Append("  monitorItemId: ").Append(MonitorItemId).Append("\n");
            sb.Append("  collectorId: ").Append(CollectorId).Append("\n");
            sb.Append("  collectorName: ").Append(CollectorName).Append("\n");
            sb.Append("  alarmRuleName: ").Append(AlarmRuleName).Append("\n");
            sb.Append("  alarmRuleExpression: ").Append(AlarmRuleExpression).Append("\n");
            sb.Append("  alarmFirstTime: ").Append(AlarmFirstTime).Append("\n");
            sb.Append("  alarmLastTime: ").Append(AlarmLastTime).Append("\n");
            sb.Append("  alarmLevel: ").Append(AlarmLevel).Append("\n");
            sb.Append("  restrainKey: ").Append(RestrainKey).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmDataVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmDataVO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.GmtCreate != input.GmtCreate || (this.GmtCreate != null && !this.GmtCreate.Equals(input.GmtCreate))) return false;
            if (this.RegionAlarmEventId != input.RegionAlarmEventId || (this.RegionAlarmEventId != null && !this.RegionAlarmEventId.Equals(input.RegionAlarmEventId))) return false;
            if (this.BusinessName != input.BusinessName || (this.BusinessName != null && !this.BusinessName.Equals(input.BusinessName))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.VersionNumber != input.VersionNumber || (this.VersionNumber != null && !this.VersionNumber.Equals(input.VersionNumber))) return false;
            if (this.AlarmRuleType != input.AlarmRuleType || (this.AlarmRuleType != null && !this.AlarmRuleType.Equals(input.AlarmRuleType))) return false;
            if (this.GmtModify != input.GmtModify || (this.GmtModify != null && !this.GmtModify.Equals(input.GmtModify))) return false;
            if (this.ProcessUnit != input.ProcessUnit || (this.ProcessUnit != null && !this.ProcessUnit.Equals(input.ProcessUnit))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.EnvId != input.EnvId || (this.EnvId != null && !this.EnvId.Equals(input.EnvId))) return false;
            if (this.BusinessId != input.BusinessId || (this.BusinessId != null && !this.BusinessId.Equals(input.BusinessId))) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.AlarmRuleId != input.AlarmRuleId || (this.AlarmRuleId != null && !this.AlarmRuleId.Equals(input.AlarmRuleId))) return false;
            if (this.MonitorItemId != input.MonitorItemId || (this.MonitorItemId != null && !this.MonitorItemId.Equals(input.MonitorItemId))) return false;
            if (this.CollectorId != input.CollectorId || (this.CollectorId != null && !this.CollectorId.Equals(input.CollectorId))) return false;
            if (this.CollectorName != input.CollectorName || (this.CollectorName != null && !this.CollectorName.Equals(input.CollectorName))) return false;
            if (this.AlarmRuleName != input.AlarmRuleName || (this.AlarmRuleName != null && !this.AlarmRuleName.Equals(input.AlarmRuleName))) return false;
            if (this.AlarmRuleExpression != input.AlarmRuleExpression || (this.AlarmRuleExpression != null && !this.AlarmRuleExpression.Equals(input.AlarmRuleExpression))) return false;
            if (this.AlarmFirstTime != input.AlarmFirstTime || (this.AlarmFirstTime != null && !this.AlarmFirstTime.Equals(input.AlarmFirstTime))) return false;
            if (this.AlarmLastTime != input.AlarmLastTime || (this.AlarmLastTime != null && !this.AlarmLastTime.Equals(input.AlarmLastTime))) return false;
            if (this.AlarmLevel != input.AlarmLevel || (this.AlarmLevel != null && !this.AlarmLevel.Equals(input.AlarmLevel))) return false;
            if (this.RestrainKey != input.RestrainKey || (this.RestrainKey != null && !this.RestrainKey.Equals(input.RestrainKey))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.GmtCreate != null) hashCode = hashCode * 59 + this.GmtCreate.GetHashCode();
                if (this.RegionAlarmEventId != null) hashCode = hashCode * 59 + this.RegionAlarmEventId.GetHashCode();
                if (this.BusinessName != null) hashCode = hashCode * 59 + this.BusinessName.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.VersionNumber != null) hashCode = hashCode * 59 + this.VersionNumber.GetHashCode();
                if (this.AlarmRuleType != null) hashCode = hashCode * 59 + this.AlarmRuleType.GetHashCode();
                if (this.GmtModify != null) hashCode = hashCode * 59 + this.GmtModify.GetHashCode();
                if (this.ProcessUnit != null) hashCode = hashCode * 59 + this.ProcessUnit.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.EnvId != null) hashCode = hashCode * 59 + this.EnvId.GetHashCode();
                if (this.BusinessId != null) hashCode = hashCode * 59 + this.BusinessId.GetHashCode();
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.AlarmRuleId != null) hashCode = hashCode * 59 + this.AlarmRuleId.GetHashCode();
                if (this.MonitorItemId != null) hashCode = hashCode * 59 + this.MonitorItemId.GetHashCode();
                if (this.CollectorId != null) hashCode = hashCode * 59 + this.CollectorId.GetHashCode();
                if (this.CollectorName != null) hashCode = hashCode * 59 + this.CollectorName.GetHashCode();
                if (this.AlarmRuleName != null) hashCode = hashCode * 59 + this.AlarmRuleName.GetHashCode();
                if (this.AlarmRuleExpression != null) hashCode = hashCode * 59 + this.AlarmRuleExpression.GetHashCode();
                if (this.AlarmFirstTime != null) hashCode = hashCode * 59 + this.AlarmFirstTime.GetHashCode();
                if (this.AlarmLastTime != null) hashCode = hashCode * 59 + this.AlarmLastTime.GetHashCode();
                if (this.AlarmLevel != null) hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                if (this.RestrainKey != null) hashCode = hashCode * 59 + this.RestrainKey.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
