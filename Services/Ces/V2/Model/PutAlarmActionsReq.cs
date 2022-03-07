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
    public class PutAlarmActionsReq 
    {

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
        /// 是否开启告警通知
        /// </summary>
        [JsonProperty("action_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionEnabled { get; set; }

        /// <summary>
        /// 告警触发的动作
        /// </summary>
        [JsonProperty("alarm_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<SMNAction> AlarmActions { get; set; }

        /// <summary>
        /// 告警恢复触发的动作
        /// </summary>
        [JsonProperty("ok_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<SMNAction> OkActions { get; set; }

        /// <summary>
        /// 告警通知开启时间
        /// </summary>
        [JsonProperty("action_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionBeginTime { get; set; }

        /// <summary>
        /// 告警通知关闭时间
        /// </summary>
        [JsonProperty("action_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionEndTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutAlarmActionsReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  actionEnabled: ").Append(ActionEnabled).Append("\n");
            sb.Append("  alarmActions: ").Append(AlarmActions).Append("\n");
            sb.Append("  okActions: ").Append(OkActions).Append("\n");
            sb.Append("  actionBeginTime: ").Append(ActionBeginTime).Append("\n");
            sb.Append("  actionEndTime: ").Append(ActionEndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PutAlarmActionsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PutAlarmActionsReq input)
        {
            if (input == null)
                return false;

            return 
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
                    this.ActionBeginTime == input.ActionBeginTime ||
                    (this.ActionBeginTime != null &&
                    this.ActionBeginTime.Equals(input.ActionBeginTime))
                ) && 
                (
                    this.ActionEndTime == input.ActionEndTime ||
                    (this.ActionEndTime != null &&
                    this.ActionEndTime.Equals(input.ActionEndTime))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ActionEnabled != null)
                    hashCode = hashCode * 59 + this.ActionEnabled.GetHashCode();
                if (this.AlarmActions != null)
                    hashCode = hashCode * 59 + this.AlarmActions.GetHashCode();
                if (this.OkActions != null)
                    hashCode = hashCode * 59 + this.OkActions.GetHashCode();
                if (this.ActionBeginTime != null)
                    hashCode = hashCode * 59 + this.ActionBeginTime.GetHashCode();
                if (this.ActionEndTime != null)
                    hashCode = hashCode * 59 + this.ActionEndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
