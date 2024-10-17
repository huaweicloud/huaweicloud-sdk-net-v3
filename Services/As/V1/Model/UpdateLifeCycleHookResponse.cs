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
    /// Response Object
    /// </summary>
    public class UpdateLifeCycleHookResponse : SdkResponse
    {
        /// <summary>
        /// 生命周期挂钩类型。INSTANCE_TERMINATING;INSTANCE_LAUNCHING
        /// </summary>
        /// <value>生命周期挂钩类型。INSTANCE_TERMINATING;INSTANCE_LAUNCHING</value>
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
        /// 生命周期挂钩默认回调操作。ABANDON;CONTINUE
        /// </summary>
        /// <value>生命周期挂钩默认回调操作。ABANDON;CONTINUE</value>
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
        /// 生命周期挂钩名称。
        /// </summary>
        [JsonProperty("lifecycle_hook_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LifecycleHookName { get; set; }

        /// <summary>
        /// 生命周期挂钩类型。INSTANCE_TERMINATING;INSTANCE_LAUNCHING
        /// </summary>
        [JsonProperty("lifecycle_hook_type", NullValueHandling = NullValueHandling.Ignore)]
        public LifecycleHookTypeEnum LifecycleHookType { get; set; }
        /// <summary>
        /// 生命周期挂钩默认回调操作。ABANDON;CONTINUE
        /// </summary>
        [JsonProperty("default_result", NullValueHandling = NullValueHandling.Ignore)]
        public DefaultResultEnum DefaultResult { get; set; }
        /// <summary>
        /// 生命周期挂钩超时时间，单位秒。
        /// </summary>
        [JsonProperty("default_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultTimeout { get; set; }

        /// <summary>
        /// SMN服务中Topic的唯一的资源标识。
        /// </summary>
        [JsonProperty("notification_topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationTopicUrn { get; set; }

        /// <summary>
        /// SMN服务中Topic的资源名称。
        /// </summary>
        [JsonProperty("notification_topic_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationTopicName { get; set; }

        /// <summary>
        /// 自定义通知消息。
        /// </summary>
        [JsonProperty("notification_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationMetadata { get; set; }

        /// <summary>
        /// 生命周期挂钩创建时间，遵循UTC时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLifeCycleHookResponse {\n");
            sb.Append("  lifecycleHookName: ").Append(LifecycleHookName).Append("\n");
            sb.Append("  lifecycleHookType: ").Append(LifecycleHookType).Append("\n");
            sb.Append("  defaultResult: ").Append(DefaultResult).Append("\n");
            sb.Append("  defaultTimeout: ").Append(DefaultTimeout).Append("\n");
            sb.Append("  notificationTopicUrn: ").Append(NotificationTopicUrn).Append("\n");
            sb.Append("  notificationTopicName: ").Append(NotificationTopicName).Append("\n");
            sb.Append("  notificationMetadata: ").Append(NotificationMetadata).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLifeCycleHookResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLifeCycleHookResponse input)
        {
            if (input == null) return false;
            if (this.LifecycleHookName != input.LifecycleHookName || (this.LifecycleHookName != null && !this.LifecycleHookName.Equals(input.LifecycleHookName))) return false;
            if (this.LifecycleHookType != input.LifecycleHookType) return false;
            if (this.DefaultResult != input.DefaultResult) return false;
            if (this.DefaultTimeout != input.DefaultTimeout || (this.DefaultTimeout != null && !this.DefaultTimeout.Equals(input.DefaultTimeout))) return false;
            if (this.NotificationTopicUrn != input.NotificationTopicUrn || (this.NotificationTopicUrn != null && !this.NotificationTopicUrn.Equals(input.NotificationTopicUrn))) return false;
            if (this.NotificationTopicName != input.NotificationTopicName || (this.NotificationTopicName != null && !this.NotificationTopicName.Equals(input.NotificationTopicName))) return false;
            if (this.NotificationMetadata != input.NotificationMetadata || (this.NotificationMetadata != null && !this.NotificationMetadata.Equals(input.NotificationMetadata))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.LifecycleHookName != null) hashCode = hashCode * 59 + this.LifecycleHookName.GetHashCode();
                hashCode = hashCode * 59 + this.LifecycleHookType.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultResult.GetHashCode();
                if (this.DefaultTimeout != null) hashCode = hashCode * 59 + this.DefaultTimeout.GetHashCode();
                if (this.NotificationTopicUrn != null) hashCode = hashCode * 59 + this.NotificationTopicUrn.GetHashCode();
                if (this.NotificationTopicName != null) hashCode = hashCode * 59 + this.NotificationTopicName.GetHashCode();
                if (this.NotificationMetadata != null) hashCode = hashCode * 59 + this.NotificationMetadata.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
