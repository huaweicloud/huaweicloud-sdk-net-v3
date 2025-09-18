using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V2.Model
{
    /// <summary>
    /// 回调配置
    /// </summary>
    public class AppCallbackUrl 
    {
        /// <summary>
        /// Defines notifyEventSubscription
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<NotifyEventSubscriptionEnum>))]
        public class NotifyEventSubscriptionEnum
        {
            /// <summary>
            /// Enum RECORD_NEW_FILE_START for value: RECORD_NEW_FILE_START
            /// </summary>
            public static readonly NotifyEventSubscriptionEnum RECORD_NEW_FILE_START = new NotifyEventSubscriptionEnum("RECORD_NEW_FILE_START");

            /// <summary>
            /// Enum RECORD_FILE_COMPLETE for value: RECORD_FILE_COMPLETE
            /// </summary>
            public static readonly NotifyEventSubscriptionEnum RECORD_FILE_COMPLETE = new NotifyEventSubscriptionEnum("RECORD_FILE_COMPLETE");

            private static readonly Dictionary<string, NotifyEventSubscriptionEnum> StaticFields =
            new Dictionary<string, NotifyEventSubscriptionEnum>()
            {
                { "RECORD_NEW_FILE_START", RECORD_NEW_FILE_START },
                { "RECORD_FILE_COMPLETE", RECORD_FILE_COMPLETE },
            };

            private string _value;

            public NotifyEventSubscriptionEnum()
            {

            }

            public NotifyEventSubscriptionEnum(string value)
            {
                _value = value;
            }

            public static NotifyEventSubscriptionEnum FromValue(string value)
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

                if (this.Equals(obj as NotifyEventSubscriptionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NotifyEventSubscriptionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NotifyEventSubscriptionEnum a, NotifyEventSubscriptionEnum b)
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

            public static bool operator !=(NotifyEventSubscriptionEnum a, NotifyEventSubscriptionEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 回调通知url地址，url必须以http://或https://开头，需要支持POST调用。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 回调秘钥，主要用于鉴权。如果不设置或者为空，则回调不会增加鉴权头域字段。 
        /// </summary>
        [JsonProperty("auth_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthKey { get; set; }

        /// <summary>
        /// 订阅云端录制通知消息。  取值如下：  - RECORD_NEW_FILE_START：开始创建新的录制文件。  - RECORD_FILE_COMPLETE：录制文件生成完成。 
        /// </summary>
        [JsonProperty("notify_event_subscription", NullValueHandling = NullValueHandling.Ignore)]
        public List<NotifyEventSubscriptionEnum> NotifyEventSubscription { get; set; }
        /// <summary>
        /// 更新时间，形如“2006-01-02T15:04:05.075Z”，时区为：UTC。 
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppCallbackUrl {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  authKey: ").Append(AuthKey).Append("\n");
            sb.Append("  notifyEventSubscription: ").Append(NotifyEventSubscription).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppCallbackUrl);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppCallbackUrl input)
        {
            if (input == null) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.AuthKey != input.AuthKey || (this.AuthKey != null && !this.AuthKey.Equals(input.AuthKey))) return false;
            if (this.NotifyEventSubscription != input.NotifyEventSubscription || (this.NotifyEventSubscription != null && input.NotifyEventSubscription != null && !this.NotifyEventSubscription.SequenceEqual(input.NotifyEventSubscription))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.AuthKey != null) hashCode = hashCode * 59 + this.AuthKey.GetHashCode();
                hashCode = hashCode * 59 + this.NotifyEventSubscription.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
