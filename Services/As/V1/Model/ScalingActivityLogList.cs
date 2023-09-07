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
    public class ScalingActivityLogList 
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
        /// 完成伸缩活动且只被移出弹性伸缩组的云服务器名称列表，云服务器名之间以逗号分隔。
        /// </summary>
        [JsonProperty("instance_removed_list", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceRemovedList { get; set; }

        /// <summary>
        /// 完成伸缩活动且被移出弹性伸缩组并删除的云服务器名称列表，云服务器名之间以逗号分隔。
        /// </summary>
        [JsonProperty("instance_deleted_list", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceDeletedList { get; set; }

        /// <summary>
        /// 完成伸缩活动且被加入弹性伸缩组的云服务器名称列表，云服务器名之间以逗号分割。
        /// </summary>
        [JsonProperty("instance_added_list", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceAddedList { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScalingActivityLogList {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  instanceRemovedList: ").Append(InstanceRemovedList).Append("\n");
            sb.Append("  instanceDeletedList: ").Append(InstanceDeletedList).Append("\n");
            sb.Append("  instanceAddedList: ").Append(InstanceAddedList).Append("\n");
            sb.Append("  scalingValue: ").Append(ScalingValue).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  instanceValue: ").Append(InstanceValue).Append("\n");
            sb.Append("  desireValue: ").Append(DesireValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScalingActivityLogList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScalingActivityLogList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InstanceRemovedList == input.InstanceRemovedList ||
                    (this.InstanceRemovedList != null &&
                    this.InstanceRemovedList.Equals(input.InstanceRemovedList))
                ) && 
                (
                    this.InstanceDeletedList == input.InstanceDeletedList ||
                    (this.InstanceDeletedList != null &&
                    this.InstanceDeletedList.Equals(input.InstanceDeletedList))
                ) && 
                (
                    this.InstanceAddedList == input.InstanceAddedList ||
                    (this.InstanceAddedList != null &&
                    this.InstanceAddedList.Equals(input.InstanceAddedList))
                ) && 
                (
                    this.ScalingValue == input.ScalingValue ||
                    (this.ScalingValue != null &&
                    this.ScalingValue.Equals(input.ScalingValue))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.InstanceValue == input.InstanceValue ||
                    (this.InstanceValue != null &&
                    this.InstanceValue.Equals(input.InstanceValue))
                ) && 
                (
                    this.DesireValue == input.DesireValue ||
                    (this.DesireValue != null &&
                    this.DesireValue.Equals(input.DesireValue))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstanceRemovedList != null)
                    hashCode = hashCode * 59 + this.InstanceRemovedList.GetHashCode();
                if (this.InstanceDeletedList != null)
                    hashCode = hashCode * 59 + this.InstanceDeletedList.GetHashCode();
                if (this.InstanceAddedList != null)
                    hashCode = hashCode * 59 + this.InstanceAddedList.GetHashCode();
                if (this.ScalingValue != null)
                    hashCode = hashCode * 59 + this.ScalingValue.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.InstanceValue != null)
                    hashCode = hashCode * 59 + this.InstanceValue.GetHashCode();
                if (this.DesireValue != null)
                    hashCode = hashCode * 59 + this.DesireValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
