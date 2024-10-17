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
    /// 修改生命周期挂钩
    /// </summary>
    public class UpdateLifeCycleHookOption 
    {
        /// <summary>
        /// 生命周期挂钩类型。INSTANCE_TERMINATING。INSTANCE_LAUNCHING。INSTANCE_TERMINATING 类型的挂钩负责在实例终止时将实例挂起，INSTANCE_LAUNCHING 类型的挂钩则是在实例启动时将实例挂起。
        /// </summary>
        /// <value>生命周期挂钩类型。INSTANCE_TERMINATING。INSTANCE_LAUNCHING。INSTANCE_TERMINATING 类型的挂钩负责在实例终止时将实例挂起，INSTANCE_LAUNCHING 类型的挂钩则是在实例启动时将实例挂起。</value>
        [JsonConverter(typeof(EnumClassConverter<LifecycleHookTypeEnum>))]
        public class LifecycleHookTypeEnum
        {
            /// <summary>
            /// Enum INSTANCE_TERMINATING for value: INSTANCE_TERMINATING
            /// </summary>
            public static readonly LifecycleHookTypeEnum INSTANCE_TERMINATING = new LifecycleHookTypeEnum("INSTANCE_TERMINATING");

            /// <summary>
            /// Enum INSTANCE_LAUNCHING for value: INSTANCE_LAUNCHING
            /// </summary>
            public static readonly LifecycleHookTypeEnum INSTANCE_LAUNCHING = new LifecycleHookTypeEnum("INSTANCE_LAUNCHING");

            private static readonly Dictionary<string, LifecycleHookTypeEnum> StaticFields =
            new Dictionary<string, LifecycleHookTypeEnum>()
            {
                { "INSTANCE_TERMINATING", INSTANCE_TERMINATING },
                { "INSTANCE_LAUNCHING", INSTANCE_LAUNCHING },
            };

            private string _value;

            public LifecycleHookTypeEnum()
            {

            }

            public LifecycleHookTypeEnum(string value)
            {
                _value = value;
            }

            public static LifecycleHookTypeEnum FromValue(string value)
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

                if (this.Equals(obj as LifecycleHookTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LifecycleHookTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LifecycleHookTypeEnum a, LifecycleHookTypeEnum b)
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

            public static bool operator !=(LifecycleHookTypeEnum a, LifecycleHookTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 生命周期挂钩默认回调操作。默认情况下，到达超时时间后执行的操作。ABANDON；CONTINUE；如果实例正在启动，则 CONTINUE 表示用户自定义操作已成功，可将实例投入使用。否则，ABANDON 表示用户自定义操作未成功，终止实例，伸缩活动置为失败，重新创建新实例。如果实例正在终止，则 ABANDON 和 CONTINUE 都允许终止实例。不过，ABANDON 将停止其他生命周期挂钩，而 CONTINUE 将允许完成其他生命周期挂钩。该字段缺省时默认为 ABANDON。
        /// </summary>
        /// <value>生命周期挂钩默认回调操作。默认情况下，到达超时时间后执行的操作。ABANDON；CONTINUE；如果实例正在启动，则 CONTINUE 表示用户自定义操作已成功，可将实例投入使用。否则，ABANDON 表示用户自定义操作未成功，终止实例，伸缩活动置为失败，重新创建新实例。如果实例正在终止，则 ABANDON 和 CONTINUE 都允许终止实例。不过，ABANDON 将停止其他生命周期挂钩，而 CONTINUE 将允许完成其他生命周期挂钩。该字段缺省时默认为 ABANDON。</value>
        [JsonConverter(typeof(EnumClassConverter<DefaultResultEnum>))]
        public class DefaultResultEnum
        {
            /// <summary>
            /// Enum ABANDON for value: ABANDON
            /// </summary>
            public static readonly DefaultResultEnum ABANDON = new DefaultResultEnum("ABANDON");

            /// <summary>
            /// Enum CONTINUE for value: CONTINUE
            /// </summary>
            public static readonly DefaultResultEnum CONTINUE = new DefaultResultEnum("CONTINUE");

            private static readonly Dictionary<string, DefaultResultEnum> StaticFields =
            new Dictionary<string, DefaultResultEnum>()
            {
                { "ABANDON", ABANDON },
                { "CONTINUE", CONTINUE },
            };

            private string _value;

            public DefaultResultEnum()
            {

            }

            public DefaultResultEnum(string value)
            {
                _value = value;
            }

            public static DefaultResultEnum FromValue(string value)
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

                if (this.Equals(obj as DefaultResultEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DefaultResultEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DefaultResultEnum a, DefaultResultEnum b)
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

            public static bool operator !=(DefaultResultEnum a, DefaultResultEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 生命周期挂钩类型。INSTANCE_TERMINATING。INSTANCE_LAUNCHING。INSTANCE_TERMINATING 类型的挂钩负责在实例终止时将实例挂起，INSTANCE_LAUNCHING 类型的挂钩则是在实例启动时将实例挂起。
        /// </summary>
        [JsonProperty("lifecycle_hook_type", NullValueHandling = NullValueHandling.Ignore)]
        public LifecycleHookTypeEnum LifecycleHookType { get; set; }
        /// <summary>
        /// 生命周期挂钩默认回调操作。默认情况下，到达超时时间后执行的操作。ABANDON；CONTINUE；如果实例正在启动，则 CONTINUE 表示用户自定义操作已成功，可将实例投入使用。否则，ABANDON 表示用户自定义操作未成功，终止实例，伸缩活动置为失败，重新创建新实例。如果实例正在终止，则 ABANDON 和 CONTINUE 都允许终止实例。不过，ABANDON 将停止其他生命周期挂钩，而 CONTINUE 将允许完成其他生命周期挂钩。该字段缺省时默认为 ABANDON。
        /// </summary>
        [JsonProperty("default_result", NullValueHandling = NullValueHandling.Ignore)]
        public DefaultResultEnum DefaultResult { get; set; }
        /// <summary>
        /// 生命周期挂钩超时时间，取值范围60-86400，默认为3600，单位是秒。默认情况下，实例保持等待状态的时间。您可以延长超时时间，也可以在超时时间结束前进行 CONTINUE 或 ABANDON 操作。
        /// </summary>
        [JsonProperty("default_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultTimeout { get; set; }

        /// <summary>
        /// SMN 服务中 Topic 的唯一的资源标识。为生命周期挂钩定义一个通知目标，当实例被生命周期挂钩挂起时向该通知目标发送消息。该消息包含实例的基本信息、用户自定义通知消息，以及可用于控制生命周期操作的令牌信息。
        /// </summary>
        [JsonProperty("notification_topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationTopicUrn { get; set; }

        /// <summary>
        /// 自定义通知消息，长度不超过256位，不能包含字符&lt; &gt; &amp; &#39; ( )当配置了通知目标时，可向其发送用户自定义的通知内容。
        /// </summary>
        [JsonProperty("notification_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationMetadata { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLifeCycleHookOption {\n");
            sb.Append("  lifecycleHookType: ").Append(LifecycleHookType).Append("\n");
            sb.Append("  defaultResult: ").Append(DefaultResult).Append("\n");
            sb.Append("  defaultTimeout: ").Append(DefaultTimeout).Append("\n");
            sb.Append("  notificationTopicUrn: ").Append(NotificationTopicUrn).Append("\n");
            sb.Append("  notificationMetadata: ").Append(NotificationMetadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLifeCycleHookOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLifeCycleHookOption input)
        {
            if (input == null) return false;
            if (this.LifecycleHookType != input.LifecycleHookType) return false;
            if (this.DefaultResult != input.DefaultResult) return false;
            if (this.DefaultTimeout != input.DefaultTimeout || (this.DefaultTimeout != null && !this.DefaultTimeout.Equals(input.DefaultTimeout))) return false;
            if (this.NotificationTopicUrn != input.NotificationTopicUrn || (this.NotificationTopicUrn != null && !this.NotificationTopicUrn.Equals(input.NotificationTopicUrn))) return false;
            if (this.NotificationMetadata != input.NotificationMetadata || (this.NotificationMetadata != null && !this.NotificationMetadata.Equals(input.NotificationMetadata))) return false;

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
                hashCode = hashCode * 59 + this.LifecycleHookType.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultResult.GetHashCode();
                if (this.DefaultTimeout != null) hashCode = hashCode * 59 + this.DefaultTimeout.GetHashCode();
                if (this.NotificationTopicUrn != null) hashCode = hashCode * 59 + this.NotificationTopicUrn.GetHashCode();
                if (this.NotificationMetadata != null) hashCode = hashCode * 59 + this.NotificationMetadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
