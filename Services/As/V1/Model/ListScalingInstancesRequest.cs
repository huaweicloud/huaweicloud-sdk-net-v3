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
    public class ListScalingInstancesRequest 
    {
        /// <summary>
        /// 实例在伸缩组中的生命周期状态：INSERVICE： 正在使用。PENDING：正在加入伸缩组。REMOVING：正在移出伸缩组。PENDING_WAIT：正在加入伸缩组：等待。REMOVING_WAIT：正在移出伸缩组：等待。
        /// </summary>
        /// <value>实例在伸缩组中的生命周期状态：INSERVICE： 正在使用。PENDING：正在加入伸缩组。REMOVING：正在移出伸缩组。PENDING_WAIT：正在加入伸缩组：等待。REMOVING_WAIT：正在移出伸缩组：等待。</value>
        [JsonConverter(typeof(EnumClassConverter<LifeCycleStateEnum>))]
        public class LifeCycleStateEnum
        {
            /// <summary>
            /// Enum INSERVICE for value: INSERVICE
            /// </summary>
            public static readonly LifeCycleStateEnum INSERVICE = new LifeCycleStateEnum("INSERVICE");

            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            public static readonly LifeCycleStateEnum PENDING = new LifeCycleStateEnum("PENDING");

            /// <summary>
            /// Enum REMOVING for value: REMOVING
            /// </summary>
            public static readonly LifeCycleStateEnum REMOVING = new LifeCycleStateEnum("REMOVING");

            /// <summary>
            /// Enum PENDING_WAIT for value: PENDING_WAIT
            /// </summary>
            public static readonly LifeCycleStateEnum PENDING_WAIT = new LifeCycleStateEnum("PENDING_WAIT");

            /// <summary>
            /// Enum REMOVING_WAIT for value: REMOVING_WAIT
            /// </summary>
            public static readonly LifeCycleStateEnum REMOVING_WAIT = new LifeCycleStateEnum("REMOVING_WAIT");

            /// <summary>
            /// Enum STANDBY for value: STANDBY
            /// </summary>
            public static readonly LifeCycleStateEnum STANDBY = new LifeCycleStateEnum("STANDBY");

            /// <summary>
            /// Enum ENTERING_STANDBY for value: ENTERING_STANDBY
            /// </summary>
            public static readonly LifeCycleStateEnum ENTERING_STANDBY = new LifeCycleStateEnum("ENTERING_STANDBY");

            private static readonly Dictionary<string, LifeCycleStateEnum> StaticFields =
            new Dictionary<string, LifeCycleStateEnum>()
            {
                { "INSERVICE", INSERVICE },
                { "PENDING", PENDING },
                { "REMOVING", REMOVING },
                { "PENDING_WAIT", PENDING_WAIT },
                { "REMOVING_WAIT", REMOVING_WAIT },
                { "STANDBY", STANDBY },
                { "ENTERING_STANDBY", ENTERING_STANDBY },
            };

            private string _value;

            public LifeCycleStateEnum()
            {

            }

            public LifeCycleStateEnum(string value)
            {
                _value = value;
            }

            public static LifeCycleStateEnum FromValue(string value)
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

                if (this.Equals(obj as LifeCycleStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LifeCycleStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LifeCycleStateEnum a, LifeCycleStateEnum b)
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

            public static bool operator !=(LifeCycleStateEnum a, LifeCycleStateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 实例健康状态：INITIALIZING：初始化。NORMAL：正常。ERROR：异常
        /// </summary>
        /// <value>实例健康状态：INITIALIZING：初始化。NORMAL：正常。ERROR：异常</value>
        [JsonConverter(typeof(EnumClassConverter<HealthStatusEnum>))]
        public class HealthStatusEnum
        {
            /// <summary>
            /// Enum INITIALIZING for value: INITIALIZING
            /// </summary>
            public static readonly HealthStatusEnum INITIALIZING = new HealthStatusEnum("INITIALIZING");

            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            public static readonly HealthStatusEnum NORMAL = new HealthStatusEnum("NORMAL");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly HealthStatusEnum ERROR = new HealthStatusEnum("ERROR");

            private static readonly Dictionary<string, HealthStatusEnum> StaticFields =
            new Dictionary<string, HealthStatusEnum>()
            {
                { "INITIALIZING", INITIALIZING },
                { "NORMAL", NORMAL },
                { "ERROR", ERROR },
            };

            private string _value;

            public HealthStatusEnum()
            {

            }

            public HealthStatusEnum(string value)
            {
                _value = value;
            }

            public static HealthStatusEnum FromValue(string value)
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

                if (this.Equals(obj as HealthStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HealthStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HealthStatusEnum a, HealthStatusEnum b)
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

            public static bool operator !=(HealthStatusEnum a, HealthStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 实例保护状态：true：已设置实例保护。false：未设置实例保护。
        /// </summary>
        /// <value>实例保护状态：true：已设置实例保护。false：未设置实例保护。</value>
        [JsonConverter(typeof(EnumClassConverter<ProtectFromScalingDownEnum>))]
        public class ProtectFromScalingDownEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly ProtectFromScalingDownEnum TRUE = new ProtectFromScalingDownEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly ProtectFromScalingDownEnum FALSE = new ProtectFromScalingDownEnum("false");

            private static readonly Dictionary<string, ProtectFromScalingDownEnum> StaticFields =
            new Dictionary<string, ProtectFromScalingDownEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public ProtectFromScalingDownEnum()
            {

            }

            public ProtectFromScalingDownEnum(string value)
            {
                _value = value;
            }

            public static ProtectFromScalingDownEnum FromValue(string value)
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

                if (this.Equals(obj as ProtectFromScalingDownEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtectFromScalingDownEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtectFromScalingDownEnum a, ProtectFromScalingDownEnum b)
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

            public static bool operator !=(ProtectFromScalingDownEnum a, ProtectFromScalingDownEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 伸缩组ID。
        /// </summary>
        [SDKProperty("scaling_group_id", IsPath = true)]
        [JsonProperty("scaling_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// 实例在伸缩组中的生命周期状态：INSERVICE： 正在使用。PENDING：正在加入伸缩组。REMOVING：正在移出伸缩组。PENDING_WAIT：正在加入伸缩组：等待。REMOVING_WAIT：正在移出伸缩组：等待。
        /// </summary>
        [SDKProperty("life_cycle_state", IsQuery = true)]
        [JsonProperty("life_cycle_state", NullValueHandling = NullValueHandling.Ignore)]
        public LifeCycleStateEnum LifeCycleState { get; set; }
        /// <summary>
        /// 实例健康状态：INITIALIZING：初始化。NORMAL：正常。ERROR：异常
        /// </summary>
        [SDKProperty("health_status", IsQuery = true)]
        [JsonProperty("health_status", NullValueHandling = NullValueHandling.Ignore)]
        public HealthStatusEnum HealthStatus { get; set; }
        /// <summary>
        /// 实例保护状态：true：已设置实例保护。false：未设置实例保护。
        /// </summary>
        [SDKProperty("protect_from_scaling_down", IsQuery = true)]
        [JsonProperty("protect_from_scaling_down", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectFromScalingDownEnum ProtectFromScalingDown { get; set; }
        /// <summary>
        /// 查询的起始行号，默认为0。
        /// </summary>
        [SDKProperty("start_number", IsQuery = true)]
        [JsonProperty("start_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartNumber { get; set; }

        /// <summary>
        /// 查询的记录条数，默认为20。
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
            sb.Append("class ListScalingInstancesRequest {\n");
            sb.Append("  scalingGroupId: ").Append(ScalingGroupId).Append("\n");
            sb.Append("  lifeCycleState: ").Append(LifeCycleState).Append("\n");
            sb.Append("  healthStatus: ").Append(HealthStatus).Append("\n");
            sb.Append("  protectFromScalingDown: ").Append(ProtectFromScalingDown).Append("\n");
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
            return this.Equals(input as ListScalingInstancesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScalingInstancesRequest input)
        {
            if (input == null) return false;
            if (this.ScalingGroupId != input.ScalingGroupId || (this.ScalingGroupId != null && !this.ScalingGroupId.Equals(input.ScalingGroupId))) return false;
            if (this.LifeCycleState != input.LifeCycleState) return false;
            if (this.HealthStatus != input.HealthStatus) return false;
            if (this.ProtectFromScalingDown != input.ProtectFromScalingDown) return false;
            if (this.StartNumber != input.StartNumber || (this.StartNumber != null && !this.StartNumber.Equals(input.StartNumber))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.ScalingGroupId != null) hashCode = hashCode * 59 + this.ScalingGroupId.GetHashCode();
                hashCode = hashCode * 59 + this.LifeCycleState.GetHashCode();
                hashCode = hashCode * 59 + this.HealthStatus.GetHashCode();
                hashCode = hashCode * 59 + this.ProtectFromScalingDown.GetHashCode();
                if (this.StartNumber != null) hashCode = hashCode * 59 + this.StartNumber.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
