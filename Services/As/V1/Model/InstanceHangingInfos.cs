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
    /// 挂钩实例信息
    /// </summary>
    public class InstanceHangingInfos 
    {
        /// <summary>
        /// 伸缩实例挂钩的挂起状态。HANGING：挂起。CONTINUE：继续。ABANDON：终止。
        /// </summary>
        /// <value>伸缩实例挂钩的挂起状态。HANGING：挂起。CONTINUE：继续。ABANDON：终止。</value>
        [JsonConverter(typeof(EnumClassConverter<LifecycleHookStatusEnum>))]
        public class LifecycleHookStatusEnum
        {
            /// <summary>
            /// Enum HANGING for value: HANGING
            /// </summary>
            public static readonly LifecycleHookStatusEnum HANGING = new LifecycleHookStatusEnum("HANGING");

            /// <summary>
            /// Enum CONTINUE for value: CONTINUE
            /// </summary>
            public static readonly LifecycleHookStatusEnum CONTINUE = new LifecycleHookStatusEnum("CONTINUE");

            /// <summary>
            /// Enum ABANDON for value: ABANDON
            /// </summary>
            public static readonly LifecycleHookStatusEnum ABANDON = new LifecycleHookStatusEnum("ABANDON");

            private static readonly Dictionary<string, LifecycleHookStatusEnum> StaticFields =
            new Dictionary<string, LifecycleHookStatusEnum>()
            {
                { "HANGING", HANGING },
                { "CONTINUE", CONTINUE },
                { "ABANDON", ABANDON },
            };

            private string Value;

            private LifecycleHookStatusEnum(string value)
            {
                this.Value = value;
            }

            public static LifecycleHookStatusEnum FromValue(string value)
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

                if (this.Equals(obj as LifecycleHookStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LifecycleHookStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(LifecycleHookStatusEnum a, LifecycleHookStatusEnum b)
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

            public static bool operator !=(LifecycleHookStatusEnum a, LifecycleHookStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 生命周期挂钩名称。
        /// </summary>
        [JsonProperty("lifecycle_hook_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LifecycleHookName { get; set; }

        /// <summary>
        /// 生命周期操作令牌，用于指定生命周期回调对象。
        /// </summary>
        [JsonProperty("lifecycle_action_key", NullValueHandling = NullValueHandling.Ignore)]
        public string LifecycleActionKey { get; set; }

        /// <summary>
        /// 伸缩实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 伸缩组ID。
        /// </summary>
        [JsonProperty("scaling_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// 伸缩实例挂钩的挂起状态。HANGING：挂起。CONTINUE：继续。ABANDON：终止。
        /// </summary>
        [JsonProperty("lifecycle_hook_status", NullValueHandling = NullValueHandling.Ignore)]
        public LifecycleHookStatusEnum LifecycleHookStatus { get; set; }
        /// <summary>
        /// 超时时间，遵循UTC时间，格式为：YYYY-MM-DDThh:mm:ssZZ。
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Timeout { get; set; }

        /// <summary>
        /// 生命周期挂钩默认回调操作。
        /// </summary>
        [JsonProperty("default_result", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultResult { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceHangingInfos {\n");
            sb.Append("  lifecycleHookName: ").Append(LifecycleHookName).Append("\n");
            sb.Append("  lifecycleActionKey: ").Append(LifecycleActionKey).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  scalingGroupId: ").Append(ScalingGroupId).Append("\n");
            sb.Append("  lifecycleHookStatus: ").Append(LifecycleHookStatus).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  defaultResult: ").Append(DefaultResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceHangingInfos);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceHangingInfos input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LifecycleHookName == input.LifecycleHookName ||
                    (this.LifecycleHookName != null &&
                    this.LifecycleHookName.Equals(input.LifecycleHookName))
                ) && 
                (
                    this.LifecycleActionKey == input.LifecycleActionKey ||
                    (this.LifecycleActionKey != null &&
                    this.LifecycleActionKey.Equals(input.LifecycleActionKey))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.ScalingGroupId == input.ScalingGroupId ||
                    (this.ScalingGroupId != null &&
                    this.ScalingGroupId.Equals(input.ScalingGroupId))
                ) && 
                (
                    this.LifecycleHookStatus == input.LifecycleHookStatus ||
                    (this.LifecycleHookStatus != null &&
                    this.LifecycleHookStatus.Equals(input.LifecycleHookStatus))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.DefaultResult == input.DefaultResult ||
                    (this.DefaultResult != null &&
                    this.DefaultResult.Equals(input.DefaultResult))
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
                if (this.LifecycleHookName != null)
                    hashCode = hashCode * 59 + this.LifecycleHookName.GetHashCode();
                if (this.LifecycleActionKey != null)
                    hashCode = hashCode * 59 + this.LifecycleActionKey.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.ScalingGroupId != null)
                    hashCode = hashCode * 59 + this.ScalingGroupId.GetHashCode();
                if (this.LifecycleHookStatus != null)
                    hashCode = hashCode * 59 + this.LifecycleHookStatus.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.DefaultResult != null)
                    hashCode = hashCode * 59 + this.DefaultResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
