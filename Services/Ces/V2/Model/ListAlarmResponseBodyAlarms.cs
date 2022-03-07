using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListAlarmResponseBodyAlarms 
    {

        /// <summary>
        /// 告警规则ID
        /// </summary>
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        /// <summary>
        /// 告警规则名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 告警规则描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 告警规则的命名空间
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 策略
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Policy> Policies { get; set; }

        /// <summary>
        /// 资源
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourcesInListResp> Resources { get; set; }

        /// <summary>
        /// 告警类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 告警开关
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 告警通知开关
        /// </summary>
        [JsonProperty("action_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActionEnabled { get; set; }

        /// <summary>
        /// 告警通知
        /// </summary>
        [JsonProperty("alarm_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<SMNAction> AlarmActions { get; set; }

        /// <summary>
        /// 告警恢复通知
        /// </summary>
        [JsonProperty("ok_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<SMNAction> OkActions { get; set; }

        /// <summary>
        /// 数据不足通知
        /// </summary>
        [JsonProperty("insufficientdata_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<SMNAction> InsufficientdataActions { get; set; }

        /// <summary>
        /// 告警通知起始时间
        /// </summary>
        [JsonProperty("action_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionBeginTime { get; set; }

        /// <summary>
        /// 告警通知结束时间
        /// </summary>
        [JsonProperty("action_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionEndTime { get; set; }

        /// <summary>
        /// 告警更新时间，参考API规范，使用UTC时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 一键告警标志
        /// </summary>
        [JsonProperty("one_click_alarm_flag", NullValueHandling = NullValueHandling.Ignore)]
        public int? OneClickAlarmFlag { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmResponseBodyAlarms {\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  policies: ").Append(Policies).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  actionEnabled: ").Append(ActionEnabled).Append("\n");
            sb.Append("  alarmActions: ").Append(AlarmActions).Append("\n");
            sb.Append("  okActions: ").Append(OkActions).Append("\n");
            sb.Append("  insufficientdataActions: ").Append(InsufficientdataActions).Append("\n");
            sb.Append("  actionBeginTime: ").Append(ActionBeginTime).Append("\n");
            sb.Append("  actionEndTime: ").Append(ActionEndTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  oneClickAlarmFlag: ").Append(OneClickAlarmFlag).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmResponseBodyAlarms);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmResponseBodyAlarms input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlarmId == input.AlarmId ||
                    (this.AlarmId != null &&
                    this.AlarmId.Equals(input.AlarmId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.ActionEnabled == input.ActionEnabled ||
                    (this.ActionEnabled != null &&
                    this.ActionEnabled.Equals(input.ActionEnabled))
                ) && 
                (
                    this.AlarmActions == input.AlarmActions ||
                    this.AlarmActions != null &&
                    input.AlarmActions != null &&
                    this.AlarmActions.SequenceEqual(input.AlarmActions)
                ) && 
                (
                    this.OkActions == input.OkActions ||
                    this.OkActions != null &&
                    input.OkActions != null &&
                    this.OkActions.SequenceEqual(input.OkActions)
                ) && 
                (
                    this.InsufficientdataActions == input.InsufficientdataActions ||
                    this.InsufficientdataActions != null &&
                    input.InsufficientdataActions != null &&
                    this.InsufficientdataActions.SequenceEqual(input.InsufficientdataActions)
                ) && 
                (
                    this.ActionBeginTime == input.ActionBeginTime ||
                    (this.ActionBeginTime != null &&
                    this.ActionBeginTime.Equals(input.ActionBeginTime))
                ) && 
                (
                    this.ActionEndTime == input.ActionEndTime ||
                    (this.ActionEndTime != null &&
                    this.ActionEndTime.Equals(input.ActionEndTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.OneClickAlarmFlag == input.OneClickAlarmFlag ||
                    (this.OneClickAlarmFlag != null &&
                    this.OneClickAlarmFlag.Equals(input.OneClickAlarmFlag))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.AlarmId != null)
                    hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Policies != null)
                    hashCode = hashCode * 59 + this.Policies.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.ActionEnabled != null)
                    hashCode = hashCode * 59 + this.ActionEnabled.GetHashCode();
                if (this.AlarmActions != null)
                    hashCode = hashCode * 59 + this.AlarmActions.GetHashCode();
                if (this.OkActions != null)
                    hashCode = hashCode * 59 + this.OkActions.GetHashCode();
                if (this.InsufficientdataActions != null)
                    hashCode = hashCode * 59 + this.InsufficientdataActions.GetHashCode();
                if (this.ActionBeginTime != null)
                    hashCode = hashCode * 59 + this.ActionBeginTime.GetHashCode();
                if (this.ActionEndTime != null)
                    hashCode = hashCode * 59 + this.ActionEndTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.OneClickAlarmFlag != null)
                    hashCode = hashCode * 59 + this.OneClickAlarmFlag.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
