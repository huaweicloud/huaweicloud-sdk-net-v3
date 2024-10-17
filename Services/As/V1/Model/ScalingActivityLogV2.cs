using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 伸缩活动日志列表。
    /// </summary>
    public class ScalingActivityLogV2 
    {
        /// <summary>
        /// 伸缩活动状态：SUCCESS：成功。FAIL：失败。DOING：伸缩过程中。
        /// </summary>
        /// <value>伸缩活动状态：SUCCESS：成功。FAIL：失败。DOING：伸缩过程中。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            public static readonly StatusEnum SUCCESS = new StatusEnum("SUCCESS");

            /// <summary>
            /// Enum FAIL for value: FAIL
            /// </summary>
            public static readonly StatusEnum FAIL = new StatusEnum("FAIL");

            /// <summary>
            /// Enum DING for value: DING
            /// </summary>
            public static readonly StatusEnum DING = new StatusEnum("DING");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "SUCCESS", SUCCESS },
                { "FAIL", FAIL },
                { "DING", DING },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 伸缩活动状态：SUCCESS：成功。FAIL：失败。DOING：伸缩过程中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 伸缩活动触发时间，遵循UTC时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 伸缩活动结束时间，遵循UTC时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 伸缩活动日志ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 完成伸缩活动且只被移出弹性伸缩组的云服务器名称列表，云服务信息之间以逗号分隔。
        /// </summary>
        [JsonProperty("instance_removed_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScalingInstance> InstanceRemovedList { get; set; }

        /// <summary>
        /// 完成伸缩活动且被移出弹性伸缩组并删除的云服务器名称列表，云服务器信息之间以逗号分隔。
        /// </summary>
        [JsonProperty("instance_deleted_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScalingInstance> InstanceDeletedList { get; set; }

        /// <summary>
        /// 完成伸缩活动且被加入弹性伸缩组的云服务器名称列表，云服务器信息之间以逗号分割。
        /// </summary>
        [JsonProperty("instance_added_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScalingInstance> InstanceAddedList { get; set; }

        /// <summary>
        /// 弹性伸缩组中伸缩活动失败的云服务器列表。
        /// </summary>
        [JsonProperty("instance_failed_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScalingInstance> InstanceFailedList { get; set; }

        /// <summary>
        /// 完成伸缩活动且被转入/移出备用状态的云服务器列表
        /// </summary>
        [JsonProperty("instance_standby_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScalingInstance> InstanceStandbyList { get; set; }

        /// <summary>
        /// 伸缩活动中变化（增加或减少）的云服务器数量。
        /// </summary>
        [JsonProperty("scaling_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScalingValue { get; set; }

        /// <summary>
        /// 伸缩活动的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 伸缩组当前instance值。
        /// </summary>
        [JsonProperty("instance_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceValue { get; set; }

        /// <summary>
        /// 伸缩活动最终desire值。
        /// </summary>
        [JsonProperty("desire_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? DesireValue { get; set; }

        /// <summary>
        /// 绑定成功的负载均衡器列表。
        /// </summary>
        [JsonProperty("lb_bind_success_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ModifyLb> LbBindSuccessList { get; set; }

        /// <summary>
        /// 绑定失败的负载均衡器列表。
        /// </summary>
        [JsonProperty("lb_bind_failed_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ModifyLb> LbBindFailedList { get; set; }

        /// <summary>
        /// 解绑成功的负载均衡器列表。
        /// </summary>
        [JsonProperty("lb_unbind_success_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ModifyLb> LbUnbindSuccessList { get; set; }

        /// <summary>
        /// 解绑失败的负载均衡器列表。
        /// </summary>
        [JsonProperty("lb_unbind_failed_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ModifyLb> LbUnbindFailedList { get; set; }

        /// <summary>
        /// 伸缩组活动类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScalingActivityLogV2 {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  instanceRemovedList: ").Append(InstanceRemovedList).Append("\n");
            sb.Append("  instanceDeletedList: ").Append(InstanceDeletedList).Append("\n");
            sb.Append("  instanceAddedList: ").Append(InstanceAddedList).Append("\n");
            sb.Append("  instanceFailedList: ").Append(InstanceFailedList).Append("\n");
            sb.Append("  instanceStandbyList: ").Append(InstanceStandbyList).Append("\n");
            sb.Append("  scalingValue: ").Append(ScalingValue).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  instanceValue: ").Append(InstanceValue).Append("\n");
            sb.Append("  desireValue: ").Append(DesireValue).Append("\n");
            sb.Append("  lbBindSuccessList: ").Append(LbBindSuccessList).Append("\n");
            sb.Append("  lbBindFailedList: ").Append(LbBindFailedList).Append("\n");
            sb.Append("  lbUnbindSuccessList: ").Append(LbUnbindSuccessList).Append("\n");
            sb.Append("  lbUnbindFailedList: ").Append(LbUnbindFailedList).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScalingActivityLogV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScalingActivityLogV2 input)
        {
            if (input == null) return false;
            if (this.Status != input.Status) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.InstanceRemovedList != input.InstanceRemovedList || (this.InstanceRemovedList != null && input.InstanceRemovedList != null && !this.InstanceRemovedList.SequenceEqual(input.InstanceRemovedList))) return false;
            if (this.InstanceDeletedList != input.InstanceDeletedList || (this.InstanceDeletedList != null && input.InstanceDeletedList != null && !this.InstanceDeletedList.SequenceEqual(input.InstanceDeletedList))) return false;
            if (this.InstanceAddedList != input.InstanceAddedList || (this.InstanceAddedList != null && input.InstanceAddedList != null && !this.InstanceAddedList.SequenceEqual(input.InstanceAddedList))) return false;
            if (this.InstanceFailedList != input.InstanceFailedList || (this.InstanceFailedList != null && input.InstanceFailedList != null && !this.InstanceFailedList.SequenceEqual(input.InstanceFailedList))) return false;
            if (this.InstanceStandbyList != input.InstanceStandbyList || (this.InstanceStandbyList != null && input.InstanceStandbyList != null && !this.InstanceStandbyList.SequenceEqual(input.InstanceStandbyList))) return false;
            if (this.ScalingValue != input.ScalingValue || (this.ScalingValue != null && !this.ScalingValue.Equals(input.ScalingValue))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.InstanceValue != input.InstanceValue || (this.InstanceValue != null && !this.InstanceValue.Equals(input.InstanceValue))) return false;
            if (this.DesireValue != input.DesireValue || (this.DesireValue != null && !this.DesireValue.Equals(input.DesireValue))) return false;
            if (this.LbBindSuccessList != input.LbBindSuccessList || (this.LbBindSuccessList != null && input.LbBindSuccessList != null && !this.LbBindSuccessList.SequenceEqual(input.LbBindSuccessList))) return false;
            if (this.LbBindFailedList != input.LbBindFailedList || (this.LbBindFailedList != null && input.LbBindFailedList != null && !this.LbBindFailedList.SequenceEqual(input.LbBindFailedList))) return false;
            if (this.LbUnbindSuccessList != input.LbUnbindSuccessList || (this.LbUnbindSuccessList != null && input.LbUnbindSuccessList != null && !this.LbUnbindSuccessList.SequenceEqual(input.LbUnbindSuccessList))) return false;
            if (this.LbUnbindFailedList != input.LbUnbindFailedList || (this.LbUnbindFailedList != null && input.LbUnbindFailedList != null && !this.LbUnbindFailedList.SequenceEqual(input.LbUnbindFailedList))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstanceRemovedList != null) hashCode = hashCode * 59 + this.InstanceRemovedList.GetHashCode();
                if (this.InstanceDeletedList != null) hashCode = hashCode * 59 + this.InstanceDeletedList.GetHashCode();
                if (this.InstanceAddedList != null) hashCode = hashCode * 59 + this.InstanceAddedList.GetHashCode();
                if (this.InstanceFailedList != null) hashCode = hashCode * 59 + this.InstanceFailedList.GetHashCode();
                if (this.InstanceStandbyList != null) hashCode = hashCode * 59 + this.InstanceStandbyList.GetHashCode();
                if (this.ScalingValue != null) hashCode = hashCode * 59 + this.ScalingValue.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.InstanceValue != null) hashCode = hashCode * 59 + this.InstanceValue.GetHashCode();
                if (this.DesireValue != null) hashCode = hashCode * 59 + this.DesireValue.GetHashCode();
                if (this.LbBindSuccessList != null) hashCode = hashCode * 59 + this.LbBindSuccessList.GetHashCode();
                if (this.LbBindFailedList != null) hashCode = hashCode * 59 + this.LbBindFailedList.GetHashCode();
                if (this.LbUnbindSuccessList != null) hashCode = hashCode * 59 + this.LbUnbindSuccessList.GetHashCode();
                if (this.LbUnbindFailedList != null) hashCode = hashCode * 59 + this.LbUnbindFailedList.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
