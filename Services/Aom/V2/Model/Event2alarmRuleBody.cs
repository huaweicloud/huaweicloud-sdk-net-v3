using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 事件类告警实体
    /// </summary>
    public class Event2alarmRuleBody 
    {

        /// <summary>
        /// 用户项目id
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? UpdateTime { get; set; }

        /// <summary>
        /// 事件源
        /// </summary>
        [JsonProperty("resource_provider", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Event2alarmRuleBodyMetadata Metadata { get; set; }

        /// <summary>
        /// 规则是否启用
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 触发策略
        /// </summary>
        [JsonProperty("trigger_policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Event2alarmRuleBodyTriggerPolicies> TriggerPolicies { get; set; }

        /// <summary>
        /// 告警类型
        /// </summary>
        [JsonProperty("alarm_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmType { get; set; }

        /// <summary>
        /// 告警行动规则
        /// </summary>
        [JsonProperty("action_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionRule { get; set; }

        /// <summary>
        /// 告警抑制规则
        /// </summary>
        [JsonProperty("inhibit_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string InhibitRule { get; set; }

        /// <summary>
        /// 告警静默规则
        /// </summary>
        [JsonProperty("route_group_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string RouteGroupRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Event2alarmRuleBody {\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  resourceProvider: ").Append(ResourceProvider).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  triggerPolicies: ").Append(TriggerPolicies).Append("\n");
            sb.Append("  alarmType: ").Append(AlarmType).Append("\n");
            sb.Append("  actionRule: ").Append(ActionRule).Append("\n");
            sb.Append("  inhibitRule: ").Append(InhibitRule).Append("\n");
            sb.Append("  routeGroupRule: ").Append(RouteGroupRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Event2alarmRuleBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Event2alarmRuleBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.ResourceProvider == input.ResourceProvider ||
                    (this.ResourceProvider != null &&
                    this.ResourceProvider.Equals(input.ResourceProvider))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
                ) && 
                (
                    this.TriggerPolicies == input.TriggerPolicies ||
                    this.TriggerPolicies != null &&
                    input.TriggerPolicies != null &&
                    this.TriggerPolicies.SequenceEqual(input.TriggerPolicies)
                ) && 
                (
                    this.AlarmType == input.AlarmType ||
                    (this.AlarmType != null &&
                    this.AlarmType.Equals(input.AlarmType))
                ) && 
                (
                    this.ActionRule == input.ActionRule ||
                    (this.ActionRule != null &&
                    this.ActionRule.Equals(input.ActionRule))
                ) && 
                (
                    this.InhibitRule == input.InhibitRule ||
                    (this.InhibitRule != null &&
                    this.InhibitRule.Equals(input.InhibitRule))
                ) && 
                (
                    this.RouteGroupRule == input.RouteGroupRule ||
                    (this.RouteGroupRule != null &&
                    this.RouteGroupRule.Equals(input.RouteGroupRule))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ResourceProvider != null)
                    hashCode = hashCode * 59 + this.ResourceProvider.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.TriggerPolicies != null)
                    hashCode = hashCode * 59 + this.TriggerPolicies.GetHashCode();
                if (this.AlarmType != null)
                    hashCode = hashCode * 59 + this.AlarmType.GetHashCode();
                if (this.ActionRule != null)
                    hashCode = hashCode * 59 + this.ActionRule.GetHashCode();
                if (this.InhibitRule != null)
                    hashCode = hashCode * 59 + this.InhibitRule.GetHashCode();
                if (this.RouteGroupRule != null)
                    hashCode = hashCode * 59 + this.RouteGroupRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
