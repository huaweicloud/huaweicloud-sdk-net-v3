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
    /// 伸缩组实例详情
    /// </summary>
    public class ScalingGroupInstance 
    {
        /// <summary>
        /// 实例在伸缩组中的生命周期状态：  - INSERVICE：已启用 - PENDING：正在加入伸缩组 - PENDING_WAIT：等待（正在加入伸缩组） - REMOVING：正在移出伸缩组 - REMOVING_WAIT：等待（正在移出伸缩组） - STANDBY：已备用 - ENTERING_STANDBY：进入备用状态
        /// </summary>
        /// <value>实例在伸缩组中的生命周期状态：  - INSERVICE：已启用 - PENDING：正在加入伸缩组 - PENDING_WAIT：等待（正在加入伸缩组） - REMOVING：正在移出伸缩组 - REMOVING_WAIT：等待（正在移出伸缩组） - STANDBY：已备用 - ENTERING_STANDBY：进入备用状态</value>
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

            private static readonly Dictionary<string, LifeCycleStateEnum> StaticFields =
            new Dictionary<string, LifeCycleStateEnum>()
            {
                { "INSERVICE", INSERVICE },
                { "PENDING", PENDING },
                { "REMOVING", REMOVING },
                { "PENDING_WAIT", PENDING_WAIT },
                { "REMOVING_WAIT", REMOVING_WAIT },
            };

            private string Value;

            public LifeCycleStateEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(LifeCycleStateEnum a, LifeCycleStateEnum b)
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

            public static bool operator !=(LifeCycleStateEnum a, LifeCycleStateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 实例健康状态:INITAILIZING:初始化；NORMAL：正常；ERROR：错误。
        /// </summary>
        /// <value>实例健康状态:INITAILIZING:初始化；NORMAL：正常；ERROR：错误。</value>
        [JsonConverter(typeof(EnumClassConverter<HealthStatusEnum>))]
        public class HealthStatusEnum
        {
            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            public static readonly HealthStatusEnum NORMAL = new HealthStatusEnum("NORMAL");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly HealthStatusEnum ERROR = new HealthStatusEnum("ERROR");

            /// <summary>
            /// Enum INITAILIZING for value: INITAILIZING
            /// </summary>
            public static readonly HealthStatusEnum INITAILIZING = new HealthStatusEnum("INITAILIZING");

            private static readonly Dictionary<string, HealthStatusEnum> StaticFields =
            new Dictionary<string, HealthStatusEnum>()
            {
                { "NORMAL", NORMAL },
                { "ERROR", ERROR },
                { "INITAILIZING", INITAILIZING },
            };

            private string Value;

            public HealthStatusEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(HealthStatusEnum a, HealthStatusEnum b)
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

            public static bool operator !=(HealthStatusEnum a, HealthStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 实例所在伸缩组ID。
        /// </summary>
        [JsonProperty("scaling_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// 实例所在伸缩组名称。
        /// </summary>
        [JsonProperty("scaling_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingGroupName { get; set; }

        /// <summary>
        /// 实例在伸缩组中的生命周期状态：  - INSERVICE：已启用 - PENDING：正在加入伸缩组 - PENDING_WAIT：等待（正在加入伸缩组） - REMOVING：正在移出伸缩组 - REMOVING_WAIT：等待（正在移出伸缩组） - STANDBY：已备用 - ENTERING_STANDBY：进入备用状态
        /// </summary>
        [JsonProperty("life_cycle_state", NullValueHandling = NullValueHandling.Ignore)]
        public LifeCycleStateEnum LifeCycleState { get; set; }
        /// <summary>
        /// 实例健康状态:INITAILIZING:初始化；NORMAL：正常；ERROR：错误。
        /// </summary>
        [JsonProperty("health_status", NullValueHandling = NullValueHandling.Ignore)]
        public HealthStatusEnum HealthStatus { get; set; }
        /// <summary>
        /// 伸缩配置名称。如果返回为空，表示伸缩配置已经被删除。如果返回MANNUAL_ADD，表示实例为手动加入。
        /// </summary>
        [JsonProperty("scaling_configuration_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingConfigurationName { get; set; }

        /// <summary>
        /// 伸缩配置ID。
        /// </summary>
        [JsonProperty("scaling_configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingConfigurationId { get; set; }

        /// <summary>
        /// 实例加入伸缩组的时间，遵循UTC时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 实例的实例保护属性。
        /// </summary>
        [JsonProperty("protect_from_scaling_down", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProtectFromScalingDown { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScalingGroupInstance {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  scalingGroupId: ").Append(ScalingGroupId).Append("\n");
            sb.Append("  scalingGroupName: ").Append(ScalingGroupName).Append("\n");
            sb.Append("  lifeCycleState: ").Append(LifeCycleState).Append("\n");
            sb.Append("  healthStatus: ").Append(HealthStatus).Append("\n");
            sb.Append("  scalingConfigurationName: ").Append(ScalingConfigurationName).Append("\n");
            sb.Append("  scalingConfigurationId: ").Append(ScalingConfigurationId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  protectFromScalingDown: ").Append(ProtectFromScalingDown).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScalingGroupInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScalingGroupInstance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.InstanceName == input.InstanceName ||
                    (this.InstanceName != null &&
                    this.InstanceName.Equals(input.InstanceName))
                ) && 
                (
                    this.ScalingGroupId == input.ScalingGroupId ||
                    (this.ScalingGroupId != null &&
                    this.ScalingGroupId.Equals(input.ScalingGroupId))
                ) && 
                (
                    this.ScalingGroupName == input.ScalingGroupName ||
                    (this.ScalingGroupName != null &&
                    this.ScalingGroupName.Equals(input.ScalingGroupName))
                ) && 
                (
                    this.LifeCycleState == input.LifeCycleState ||
                    (this.LifeCycleState != null &&
                    this.LifeCycleState.Equals(input.LifeCycleState))
                ) && 
                (
                    this.HealthStatus == input.HealthStatus ||
                    (this.HealthStatus != null &&
                    this.HealthStatus.Equals(input.HealthStatus))
                ) && 
                (
                    this.ScalingConfigurationName == input.ScalingConfigurationName ||
                    (this.ScalingConfigurationName != null &&
                    this.ScalingConfigurationName.Equals(input.ScalingConfigurationName))
                ) && 
                (
                    this.ScalingConfigurationId == input.ScalingConfigurationId ||
                    (this.ScalingConfigurationId != null &&
                    this.ScalingConfigurationId.Equals(input.ScalingConfigurationId))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.ProtectFromScalingDown == input.ProtectFromScalingDown ||
                    (this.ProtectFromScalingDown != null &&
                    this.ProtectFromScalingDown.Equals(input.ProtectFromScalingDown))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null)
                    hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.ScalingGroupId != null)
                    hashCode = hashCode * 59 + this.ScalingGroupId.GetHashCode();
                if (this.ScalingGroupName != null)
                    hashCode = hashCode * 59 + this.ScalingGroupName.GetHashCode();
                if (this.LifeCycleState != null)
                    hashCode = hashCode * 59 + this.LifeCycleState.GetHashCode();
                if (this.HealthStatus != null)
                    hashCode = hashCode * 59 + this.HealthStatus.GetHashCode();
                if (this.ScalingConfigurationName != null)
                    hashCode = hashCode * 59 + this.ScalingConfigurationName.GetHashCode();
                if (this.ScalingConfigurationId != null)
                    hashCode = hashCode * 59 + this.ScalingConfigurationId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ProtectFromScalingDown != null)
                    hashCode = hashCode * 59 + this.ProtectFromScalingDown.GetHashCode();
                return hashCode;
            }
        }
    }
}
