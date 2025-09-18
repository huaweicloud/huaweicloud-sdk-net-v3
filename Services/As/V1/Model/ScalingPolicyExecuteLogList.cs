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
    /// 伸缩策略执行日志列表
    /// </summary>
    public class ScalingPolicyExecuteLogList 
    {
        /// <summary>
        /// 策略执行状态：SUCCESS：成功。FAIL：失败。EXECUTING：执行中
        /// </summary>
        /// <value>策略执行状态：SUCCESS：成功。FAIL：失败。EXECUTING：执行中</value>
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
            /// Enum EXECUTING for value: EXECUTING
            /// </summary>
            public static readonly StatusEnum EXECUTING = new StatusEnum("EXECUTING");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "SUCCESS", SUCCESS },
                { "FAIL", FAIL },
                { "EXECUTING", EXECUTING },
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
                if (ReferenceEquals(a, b))
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
        /// 策略执行类型：SCHEDULE：自动触发（定时）。RECURRENCE：自动触发（周期）。ALARM：自动警告（告警）。MANUAL：手动触发
        /// </summary>
        /// <value>策略执行类型：SCHEDULE：自动触发（定时）。RECURRENCE：自动触发（周期）。ALARM：自动警告（告警）。MANUAL：手动触发</value>
        [JsonConverter(typeof(EnumClassConverter<ExecuteTypeEnum>))]
        public class ExecuteTypeEnum
        {
            /// <summary>
            /// Enum SCHEDULE for value: SCHEDULE
            /// </summary>
            public static readonly ExecuteTypeEnum SCHEDULE = new ExecuteTypeEnum("SCHEDULE");

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
                { "SCHEDULE", SCHEDULE },
                { "RECURRENCE", RECURRENCE },
                { "ALARM", ALARM },
                { "MANUAL", MANUAL },
            };

            private string _value;

            public ExecuteTypeEnum()
            {

            }

            public ExecuteTypeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ExecuteTypeEnum a, ExecuteTypeEnum b)
            {
                if (ReferenceEquals(a, b))
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
        /// 伸缩资源类型：伸缩组：SCALING_GROUP 带宽：BANDWIDTH
        /// </summary>
        /// <value>伸缩资源类型：伸缩组：SCALING_GROUP 带宽：BANDWIDTH</value>
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

            private string _value;

            public ScalingResourceTypeEnum()
            {

            }

            public ScalingResourceTypeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScalingResourceTypeEnum a, ScalingResourceTypeEnum b)
            {
                if (ReferenceEquals(a, b))
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
        /// 策略执行任务类型。ADD：添加。REMOVE：减少。SET：设置为
        /// </summary>
        /// <value>策略执行任务类型。ADD：添加。REMOVE：减少。SET：设置为</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum ADD for value: ADD
            /// </summary>
            public static readonly TypeEnum ADD = new TypeEnum("ADD");

            /// <summary>
            /// Enum REMOVE for value: REMOVE
            /// </summary>
            public static readonly TypeEnum REMOVE = new TypeEnum("REMOVE");

            /// <summary>
            /// Enum SET for value: SET
            /// </summary>
            public static readonly TypeEnum SET = new TypeEnum("SET");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "ADD", ADD },
                { "REMOVE", REMOVE },
                { "SET", SET },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 策略执行状态：SUCCESS：成功。FAIL：失败。EXECUTING：执行中
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 策略执行失败原因。
        /// </summary>
        [JsonProperty("failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedReason { get; set; }

        /// <summary>
        /// 策略执行类型：SCHEDULE：自动触发（定时）。RECURRENCE：自动触发（周期）。ALARM：自动警告（告警）。MANUAL：手动触发
        /// </summary>
        [JsonProperty("execute_type", NullValueHandling = NullValueHandling.Ignore)]
        public ExecuteTypeEnum ExecuteType { get; set; }
        /// <summary>
        /// 策略执行时间，遵循UTC时间。
        /// </summary>
        [JsonProperty("execute_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// 策略执行日志ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 租户id。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 伸缩策略ID。
        /// </summary>
        [JsonProperty("scaling_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingPolicyId { get; set; }

        /// <summary>
        /// 伸缩资源类型：伸缩组：SCALING_GROUP 带宽：BANDWIDTH
        /// </summary>
        [JsonProperty("scaling_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingResourceTypeEnum ScalingResourceType { get; set; }
        /// <summary>
        /// 伸缩资源ID。
        /// </summary>
        [JsonProperty("scaling_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingResourceId { get; set; }

        /// <summary>
        /// 伸缩原始值。
        /// </summary>
        [JsonProperty("old_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OldValue { get; set; }

        /// <summary>
        /// 伸缩目标值。
        /// </summary>
        [JsonProperty("desire_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DesireValue { get; set; }

        /// <summary>
        /// 操作限制。当scaling_resource_type为BANDWIDTH时，且operation不为SET时，limit_value生效，单位为Mbit/s。此时，当operation为ADD时，limit_value表示最高带宽限制；当operation为REDUCE时，limit_value表示最低带宽限制。
        /// </summary>
        [JsonProperty("limit_value", NullValueHandling = NullValueHandling.Ignore)]
        public string LimitValue { get; set; }

        /// <summary>
        /// 策略执行任务类型。ADD：添加。REMOVE：减少。SET：设置为
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 策略执行动作包含的具体任务
        /// </summary>
        [JsonProperty("job_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobRecords> JobRecords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("meta_data", NullValueHandling = NullValueHandling.Ignore)]
        public EipMetaData MetaData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScalingPolicyExecuteLogList {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  failedReason: ").Append(FailedReason).Append("\n");
            sb.Append("  executeType: ").Append(ExecuteType).Append("\n");
            sb.Append("  executeTime: ").Append(ExecuteTime).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  scalingPolicyId: ").Append(ScalingPolicyId).Append("\n");
            sb.Append("  scalingResourceType: ").Append(ScalingResourceType).Append("\n");
            sb.Append("  scalingResourceId: ").Append(ScalingResourceId).Append("\n");
            sb.Append("  oldValue: ").Append(OldValue).Append("\n");
            sb.Append("  desireValue: ").Append(DesireValue).Append("\n");
            sb.Append("  limitValue: ").Append(LimitValue).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  jobRecords: ").Append(JobRecords).Append("\n");
            sb.Append("  metaData: ").Append(MetaData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScalingPolicyExecuteLogList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScalingPolicyExecuteLogList input)
        {
            if (input == null) return false;
            if (this.Status != input.Status) return false;
            if (this.FailedReason != input.FailedReason || (this.FailedReason != null && !this.FailedReason.Equals(input.FailedReason))) return false;
            if (this.ExecuteType != input.ExecuteType) return false;
            if (this.ExecuteTime != input.ExecuteTime || (this.ExecuteTime != null && !this.ExecuteTime.Equals(input.ExecuteTime))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.ScalingPolicyId != input.ScalingPolicyId || (this.ScalingPolicyId != null && !this.ScalingPolicyId.Equals(input.ScalingPolicyId))) return false;
            if (this.ScalingResourceType != input.ScalingResourceType) return false;
            if (this.ScalingResourceId != input.ScalingResourceId || (this.ScalingResourceId != null && !this.ScalingResourceId.Equals(input.ScalingResourceId))) return false;
            if (this.OldValue != input.OldValue || (this.OldValue != null && !this.OldValue.Equals(input.OldValue))) return false;
            if (this.DesireValue != input.DesireValue || (this.DesireValue != null && !this.DesireValue.Equals(input.DesireValue))) return false;
            if (this.LimitValue != input.LimitValue || (this.LimitValue != null && !this.LimitValue.Equals(input.LimitValue))) return false;
            if (this.Type != input.Type) return false;
            if (this.JobRecords != input.JobRecords || (this.JobRecords != null && input.JobRecords != null && !this.JobRecords.SequenceEqual(input.JobRecords))) return false;
            if (this.MetaData != input.MetaData || (this.MetaData != null && !this.MetaData.Equals(input.MetaData))) return false;

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
                if (this.FailedReason != null) hashCode = hashCode * 59 + this.FailedReason.GetHashCode();
                hashCode = hashCode * 59 + this.ExecuteType.GetHashCode();
                if (this.ExecuteTime != null) hashCode = hashCode * 59 + this.ExecuteTime.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ScalingPolicyId != null) hashCode = hashCode * 59 + this.ScalingPolicyId.GetHashCode();
                hashCode = hashCode * 59 + this.ScalingResourceType.GetHashCode();
                if (this.ScalingResourceId != null) hashCode = hashCode * 59 + this.ScalingResourceId.GetHashCode();
                if (this.OldValue != null) hashCode = hashCode * 59 + this.OldValue.GetHashCode();
                if (this.DesireValue != null) hashCode = hashCode * 59 + this.DesireValue.GetHashCode();
                if (this.LimitValue != null) hashCode = hashCode * 59 + this.LimitValue.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.JobRecords != null) hashCode = hashCode * 59 + this.JobRecords.GetHashCode();
                if (this.MetaData != null) hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                return hashCode;
            }
        }
    }
}
