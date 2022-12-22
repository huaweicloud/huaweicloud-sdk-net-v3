using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAlarmHistoriesRequest 
    {

        /// <summary>
        /// 服务提供的资源分组功能，创建的资源分组ID，如：rg1603107497873DK4O2pXbn。
        /// </summary>
        [SDKProperty("group_id", IsQuery = true)]
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 告警规则ID。如：al1603088932912v98rGl1al。
        /// </summary>
        [SDKProperty("alarm_id", IsQuery = true)]
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        /// <summary>
        /// 告警规则名称，如alarm-test01。
        /// </summary>
        [SDKProperty("alarm_name", IsQuery = true)]
        [JsonProperty("alarm_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmName { get; set; }

        /// <summary>
        /// 告警历史的状态，取值为ok，alarm，insufficient_data； ok为正常，alarm为告警，insufficient_data为数据不足。
        /// </summary>
        [SDKProperty("alarm_status", IsQuery = true)]
        [JsonProperty("alarm_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmStatus { get; set; }

        /// <summary>
        /// 告警历史的告警级别，值为1,2,3,4；1为紧急，2为重要，3为次要，4为提示。
        /// </summary>
        [SDKProperty("alarm_level", IsQuery = true)]
        [JsonProperty("alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmLevel { get; set; }

        /// <summary>
        /// 告警资源对应的命名空间，如ECS服务的资源命名空间为：SYS.ECS；各服务命名空间可查看：“[服务命名空间](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)”。
        /// </summary>
        [SDKProperty("namespace", IsQuery = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 查询告警历史的起始时间，UNIX时间戳，单位毫秒，如：1602501480905；from，to如果不进行赋值，则默认to是当前时间，from是当前时间减7天的时间戳。
        /// </summary>
        [SDKProperty("from", IsQuery = true)]
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public string From { get; set; }

        /// <summary>
        /// 查询告警历史的截止时间，UNIX时间戳，单位毫秒。from必须小于等于to，如：1603106280905；from，to如果不进行赋值，则默认to是当前时间，from是当前时间减7天的时间戳。
        /// </summary>
        [SDKProperty("to", IsQuery = true)]
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public string To { get; set; }

        /// <summary>
        /// 分页起始值，类型为integer，默认值为0。
        /// </summary>
        [SDKProperty("start", IsQuery = true)]
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public string Start { get; set; }

        /// <summary>
        /// 单次查询的条数限制，取值范围(0,100]，默认值为100， 用于限制结果数据条数。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmHistoriesRequest {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  alarmName: ").Append(AlarmName).Append("\n");
            sb.Append("  alarmStatus: ").Append(AlarmStatus).Append("\n");
            sb.Append("  alarmLevel: ").Append(AlarmLevel).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  to: ").Append(To).Append("\n");
            sb.Append("  start: ").Append(Start).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmHistoriesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmHistoriesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.AlarmId == input.AlarmId ||
                    (this.AlarmId != null &&
                    this.AlarmId.Equals(input.AlarmId))
                ) && 
                (
                    this.AlarmName == input.AlarmName ||
                    (this.AlarmName != null &&
                    this.AlarmName.Equals(input.AlarmName))
                ) && 
                (
                    this.AlarmStatus == input.AlarmStatus ||
                    (this.AlarmStatus != null &&
                    this.AlarmStatus.Equals(input.AlarmStatus))
                ) && 
                (
                    this.AlarmLevel == input.AlarmLevel ||
                    (this.AlarmLevel != null &&
                    this.AlarmLevel.Equals(input.AlarmLevel))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.AlarmId != null)
                    hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.AlarmName != null)
                    hashCode = hashCode * 59 + this.AlarmName.GetHashCode();
                if (this.AlarmStatus != null)
                    hashCode = hashCode * 59 + this.AlarmStatus.GetHashCode();
                if (this.AlarmLevel != null)
                    hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
