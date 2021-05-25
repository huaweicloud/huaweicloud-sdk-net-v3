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
    /// Request Object
    /// </summary>
    public class ListScalingPolicyExecuteLogsRequest 
    {
        /// <summary>
        /// 伸缩资源类型：伸缩组：SCALING_GROUP。带宽：BANDWIDTH
        /// </summary>
        /// <value>伸缩资源类型：伸缩组：SCALING_GROUP。带宽：BANDWIDTH</value>
        [JsonConverter(typeof(EnumClassConverter<ScalingResourceTypeEnum>))]
        public class ScalingResourceTypeEnum
        {
            /// <summary>
            /// Enum SCALING_GROUP for value: SCALING_GROUP
            /// </summary>
            public static readonly ScalingResourceTypeEnum SCALING_GROUP = new ScalingResourceTypeEnum("SCALING_GROUP");

            /// <summary>
            /// Enum BANDWIDTH for value: BANDWIDTH
            /// </summary>
            public static readonly ScalingResourceTypeEnum BANDWIDTH = new ScalingResourceTypeEnum("BANDWIDTH");

            private static readonly Dictionary<string, ScalingResourceTypeEnum> StaticFields =
            new Dictionary<string, ScalingResourceTypeEnum>()
            {
                { "SCALING_GROUP", SCALING_GROUP },
                { "BANDWIDTH", BANDWIDTH },
            };

            private string Value;

            public ScalingResourceTypeEnum(string value)
            {
                Value = value;
            }

            public static ScalingResourceTypeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as ScalingResourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScalingResourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ScalingResourceTypeEnum a, ScalingResourceTypeEnum b)
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

            public static bool operator !=(ScalingResourceTypeEnum a, ScalingResourceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 策略执行类型：SCHEDULED：自动触发（定时）。RECURRENCE：自动触发（周期）。ALARM：自动触发（告警）。MANUAL：手动触发。
        /// </summary>
        /// <value>策略执行类型：SCHEDULED：自动触发（定时）。RECURRENCE：自动触发（周期）。ALARM：自动触发（告警）。MANUAL：手动触发。</value>
        [JsonConverter(typeof(EnumClassConverter<ExecuteTypeEnum>))]
        public class ExecuteTypeEnum
        {
            /// <summary>
            /// Enum SCHEDULED for value: SCHEDULED
            /// </summary>
            public static readonly ExecuteTypeEnum SCHEDULED = new ExecuteTypeEnum("SCHEDULED");

            /// <summary>
            /// Enum RECURRENCE for value: RECURRENCE
            /// </summary>
            public static readonly ExecuteTypeEnum RECURRENCE = new ExecuteTypeEnum("RECURRENCE");

            /// <summary>
            /// Enum ALARM for value: ALARM
            /// </summary>
            public static readonly ExecuteTypeEnum ALARM = new ExecuteTypeEnum("ALARM");

            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            public static readonly ExecuteTypeEnum MANUAL = new ExecuteTypeEnum("MANUAL");

            private static readonly Dictionary<string, ExecuteTypeEnum> StaticFields =
            new Dictionary<string, ExecuteTypeEnum>()
            {
                { "SCHEDULED", SCHEDULED },
                { "RECURRENCE", RECURRENCE },
                { "ALARM", ALARM },
                { "MANUAL", MANUAL },
            };

            private string Value;

            public ExecuteTypeEnum(string value)
            {
                Value = value;
            }

            public static ExecuteTypeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as ExecuteTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ExecuteTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ExecuteTypeEnum a, ExecuteTypeEnum b)
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

            public static bool operator !=(ExecuteTypeEnum a, ExecuteTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 伸缩策略ID。
        /// </summary>
        [SDKProperty("scaling_policy_id", IsPath = true)]
        [JsonProperty("scaling_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingPolicyId { get; set; }

        /// <summary>
        /// 日志ID。
        /// </summary>
        [SDKProperty("log_id", IsQuery = true)]
        [JsonProperty("log_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogId { get; set; }

        /// <summary>
        /// 伸缩资源类型：伸缩组：SCALING_GROUP。带宽：BANDWIDTH
        /// </summary>
        [SDKProperty("scaling_resource_type", IsQuery = true)]
        [JsonProperty("scaling_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingResourceTypeEnum ScalingResourceType { get; set; }
        /// <summary>
        /// 伸缩资源ID。
        /// </summary>
        [SDKProperty("scaling_resource_id", IsQuery = true)]
        [JsonProperty("scaling_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingResourceId { get; set; }

        /// <summary>
        /// 策略执行类型：SCHEDULED：自动触发（定时）。RECURRENCE：自动触发（周期）。ALARM：自动触发（告警）。MANUAL：手动触发。
        /// </summary>
        [SDKProperty("execute_type", IsQuery = true)]
        [JsonProperty("execute_type", NullValueHandling = NullValueHandling.Ignore)]
        public ExecuteTypeEnum ExecuteType { get; set; }
        /// <summary>
        /// 查询的起始时间，格式是“yyyy-MM-ddThh:mm:ssZ”。
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 查询的截止时间，格式是“yyyy-MM-ddThh:mm:ssZ”。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 查询的起始行号，默认为0。
        /// </summary>
        [SDKProperty("start_number", IsQuery = true)]
        [JsonProperty("start_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartNumber { get; set; }

        /// <summary>
        /// 查询记录数，默认20，最大100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScalingPolicyExecuteLogsRequest {\n");
            sb.Append("  scalingPolicyId: ").Append(ScalingPolicyId).Append("\n");
            sb.Append("  logId: ").Append(LogId).Append("\n");
            sb.Append("  scalingResourceType: ").Append(ScalingResourceType).Append("\n");
            sb.Append("  scalingResourceId: ").Append(ScalingResourceId).Append("\n");
            sb.Append("  executeType: ").Append(ExecuteType).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  startNumber: ").Append(StartNumber).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScalingPolicyExecuteLogsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScalingPolicyExecuteLogsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScalingPolicyId == input.ScalingPolicyId ||
                    (this.ScalingPolicyId != null &&
                    this.ScalingPolicyId.Equals(input.ScalingPolicyId))
                ) && 
                (
                    this.LogId == input.LogId ||
                    (this.LogId != null &&
                    this.LogId.Equals(input.LogId))
                ) && 
                (
                    this.ScalingResourceType == input.ScalingResourceType ||
                    (this.ScalingResourceType != null &&
                    this.ScalingResourceType.Equals(input.ScalingResourceType))
                ) && 
                (
                    this.ScalingResourceId == input.ScalingResourceId ||
                    (this.ScalingResourceId != null &&
                    this.ScalingResourceId.Equals(input.ScalingResourceId))
                ) && 
                (
                    this.ExecuteType == input.ExecuteType ||
                    (this.ExecuteType != null &&
                    this.ExecuteType.Equals(input.ExecuteType))
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
                    this.StartNumber == input.StartNumber ||
                    (this.StartNumber != null &&
                    this.StartNumber.Equals(input.StartNumber))
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
                if (this.ScalingPolicyId != null)
                    hashCode = hashCode * 59 + this.ScalingPolicyId.GetHashCode();
                if (this.LogId != null)
                    hashCode = hashCode * 59 + this.LogId.GetHashCode();
                if (this.ScalingResourceType != null)
                    hashCode = hashCode * 59 + this.ScalingResourceType.GetHashCode();
                if (this.ScalingResourceId != null)
                    hashCode = hashCode * 59 + this.ScalingResourceId.GetHashCode();
                if (this.ExecuteType != null)
                    hashCode = hashCode * 59 + this.ExecuteType.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StartNumber != null)
                    hashCode = hashCode * 59 + this.StartNumber.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
