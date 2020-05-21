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
        /// Defines scalingResourceType
        /// </summary>
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

            public static readonly Dictionary<string, ScalingResourceTypeEnum> StaticFields =
            new Dictionary<string, ScalingResourceTypeEnum>()
            {
                {"SCALING_GROUP", SCALING_GROUP},
                {"BANDWIDTH", BANDWIDTH},
            };

            private string Value;

            public ScalingResourceTypeEnum(string Value)
            {
                this.Value = Value;
            }

            public static ScalingResourceTypeEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
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
        /// Defines executeType
        /// </summary>
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

            public static readonly Dictionary<string, ExecuteTypeEnum> StaticFields =
            new Dictionary<string, ExecuteTypeEnum>()
            {
                {"SCHEDULED", SCHEDULED},
                {"RECURRENCE", RECURRENCE},
                {"ALARM", ALARM},
                {"MANUAL", MANUAL},
            };

            private string Value;

            public ExecuteTypeEnum(string Value)
            {
                this.Value = Value;
            }

            public static ExecuteTypeEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
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
        /// 
        /// </summary>
        [SDKProperty("scaling_policy_id", IsPath = true)]
        public string ScalingPolicyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("log_id", IsQuery = true)]
        public string LogId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("scaling_resource_type", IsQuery = true)]
        public ScalingResourceTypeEnum ScalingResourceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("scaling_resource_id", IsQuery = true)]
        public string ScalingResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("execute_type", IsQuery = true)]
        public ExecuteTypeEnum ExecuteType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("start_number", IsQuery = true)]
        public int? StartNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
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
