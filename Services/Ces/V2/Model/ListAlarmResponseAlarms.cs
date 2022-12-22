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
    public class ListAlarmResponseAlarms 
    {

        /// <summary>
        /// 告警规则id，以al开头，包含22个数字或字母
        /// </summary>
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        /// <summary>
        /// 告警名称, 只能包含0-9/a-z/A-Z/_/-或汉字，长度1-128
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 告警描述，长度0-256
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 查询服务的命名空间，各服务命名空间请参考[服务命名空间](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 告警策略
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Policy> Policies { get; set; }

        /// <summary>
        /// 资源列表，关联资源需要使用查询告警规则资源接口获取
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourcesInListResp> Resources { get; set; }

        /// <summary>
        /// 告警规则类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 告警开关
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 是否开启告警通知
        /// </summary>
        [JsonProperty("notification_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotificationEnabled { get; set; }

        /// <summary>
        /// 告警触发的动作
        /// </summary>
        [JsonProperty("alarm_notifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Notification> AlarmNotifications { get; set; }

        /// <summary>
        /// 告警恢复触发的动作
        /// </summary>
        [JsonProperty("ok_notifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Notification> OkNotifications { get; set; }

        /// <summary>
        /// 告警通知开启时间
        /// </summary>
        [JsonProperty("notification_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationBeginTime { get; set; }

        /// <summary>
        /// 告警通知关闭时间
        /// </summary>
        [JsonProperty("notification_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationEndTime { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 告警规则关联告警模板ID，如果传了，告警规则关联的策略会和告警模板策略联动变化
        /// </summary>
        [JsonProperty("alarm_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmTemplateId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmResponseAlarms {\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  policies: ").Append(Policies).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  notificationEnabled: ").Append(NotificationEnabled).Append("\n");
            sb.Append("  alarmNotifications: ").Append(AlarmNotifications).Append("\n");
            sb.Append("  okNotifications: ").Append(OkNotifications).Append("\n");
            sb.Append("  notificationBeginTime: ").Append(NotificationBeginTime).Append("\n");
            sb.Append("  notificationEndTime: ").Append(NotificationEndTime).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  alarmTemplateId: ").Append(AlarmTemplateId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmResponseAlarms);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmResponseAlarms input)
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
                    this.NotificationEnabled == input.NotificationEnabled ||
                    (this.NotificationEnabled != null &&
                    this.NotificationEnabled.Equals(input.NotificationEnabled))
                ) && 
                (
                    this.AlarmNotifications == input.AlarmNotifications ||
                    this.AlarmNotifications != null &&
                    input.AlarmNotifications != null &&
                    this.AlarmNotifications.SequenceEqual(input.AlarmNotifications)
                ) && 
                (
                    this.OkNotifications == input.OkNotifications ||
                    this.OkNotifications != null &&
                    input.OkNotifications != null &&
                    this.OkNotifications.SequenceEqual(input.OkNotifications)
                ) && 
                (
                    this.NotificationBeginTime == input.NotificationBeginTime ||
                    (this.NotificationBeginTime != null &&
                    this.NotificationBeginTime.Equals(input.NotificationBeginTime))
                ) && 
                (
                    this.NotificationEndTime == input.NotificationEndTime ||
                    (this.NotificationEndTime != null &&
                    this.NotificationEndTime.Equals(input.NotificationEndTime))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.AlarmTemplateId == input.AlarmTemplateId ||
                    (this.AlarmTemplateId != null &&
                    this.AlarmTemplateId.Equals(input.AlarmTemplateId))
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
                if (this.NotificationEnabled != null)
                    hashCode = hashCode * 59 + this.NotificationEnabled.GetHashCode();
                if (this.AlarmNotifications != null)
                    hashCode = hashCode * 59 + this.AlarmNotifications.GetHashCode();
                if (this.OkNotifications != null)
                    hashCode = hashCode * 59 + this.OkNotifications.GetHashCode();
                if (this.NotificationBeginTime != null)
                    hashCode = hashCode * 59 + this.NotificationBeginTime.GetHashCode();
                if (this.NotificationEndTime != null)
                    hashCode = hashCode * 59 + this.NotificationEndTime.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.AlarmTemplateId != null)
                    hashCode = hashCode * 59 + this.AlarmTemplateId.GetHashCode();
                return hashCode;
            }
        }
    }
}
