using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRecordCallbackConfigResponse : SdkResponse
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

            /// <summary>
            /// Enum RECORD_OVER for value: RECORD_OVER
            /// </summary>
            public static readonly NotifyEventSubscriptionEnum RECORD_OVER = new NotifyEventSubscriptionEnum("RECORD_OVER");

            /// <summary>
            /// Enum RECORD_FAILED for value: RECORD_FAILED
            /// </summary>
            public static readonly NotifyEventSubscriptionEnum RECORD_FAILED = new NotifyEventSubscriptionEnum("RECORD_FAILED");

            private static readonly Dictionary<string, NotifyEventSubscriptionEnum> StaticFields =
            new Dictionary<string, NotifyEventSubscriptionEnum>()
            {
                { "RECORD_NEW_FILE_START", RECORD_NEW_FILE_START },
                { "RECORD_FILE_COMPLETE", RECORD_FILE_COMPLETE },
                { "RECORD_OVER", RECORD_OVER },
                { "RECORD_FAILED", RECORD_FAILED },
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
        /// 加密类型
        /// </summary>
        /// <value>加密类型</value>
        [JsonConverter(typeof(EnumClassConverter<SignTypeEnum>))]
        public class SignTypeEnum
        {
            /// <summary>
            /// Enum MD5 for value: MD5
            /// </summary>
            public static readonly SignTypeEnum MD5 = new SignTypeEnum("MD5");

            /// <summary>
            /// Enum HMACSHA256 for value: HMACSHA256
            /// </summary>
            public static readonly SignTypeEnum HMACSHA256 = new SignTypeEnum("HMACSHA256");

            private static readonly Dictionary<string, SignTypeEnum> StaticFields =
            new Dictionary<string, SignTypeEnum>()
            {
                { "MD5", MD5 },
                { "HMACSHA256", HMACSHA256 },
            };

            private string _value;

            public SignTypeEnum()
            {

            }

            public SignTypeEnum(string value)
            {
                _value = value;
            }

            public static SignTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SignTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SignTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SignTypeEnum a, SignTypeEnum b)
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

            public static bool operator !=(SignTypeEnum a, SignTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 配置id，由服务端返回。创建或修改的时候不携带
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 直播推流域名
        /// </summary>
        [JsonProperty("publish_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishDomain { get; set; }

        /// <summary>
        /// app名称。如果匹配任意需填写为*。录制规则匹配的时候，优先精确app匹配，如果匹配不到，则匹配*
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 录制回调通知url地址
        /// </summary>
        [JsonProperty("notify_callback_url", NullValueHandling = NullValueHandling.Ignore)]
        public string NotifyCallbackUrl { get; set; }

        /// <summary>
        /// 订阅录制通知消息。消息类型。RECORD_NEW_FILE_START开始创建新的录制文件。RECORD_FILE_COMPLETE录制文件生成完成。RECORD_OVER录制结束。RECORD_FAILED表示录制失败。如果不填写,默认订阅RECORD_FILE_COMPLETE
        /// </summary>
        [JsonProperty("notify_event_subscription", NullValueHandling = NullValueHandling.Ignore)]
        public List<NotifyEventSubscriptionEnum> NotifyEventSubscription { get; set; }
        /// <summary>
        /// 加密类型
        /// </summary>
        [JsonProperty("sign_type", NullValueHandling = NullValueHandling.Ignore)]
        public SignTypeEnum SignType { get; set; }
        /// <summary>
        /// 创建时间，格式：yyyy-mm-ddThh:mm:ssZ，UTC时间。 在查询的时候返回
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 修改时间，格式：yyyy-mm-ddThh:mm:ssZ，UTC时间。 在查询的时候返回
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRecordCallbackConfigResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  publishDomain: ").Append(PublishDomain).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  notifyCallbackUrl: ").Append(NotifyCallbackUrl).Append("\n");
            sb.Append("  notifyEventSubscription: ").Append(NotifyEventSubscription).Append("\n");
            sb.Append("  signType: ").Append(SignType).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRecordCallbackConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRecordCallbackConfigResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.PublishDomain != input.PublishDomain || (this.PublishDomain != null && !this.PublishDomain.Equals(input.PublishDomain))) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.NotifyCallbackUrl != input.NotifyCallbackUrl || (this.NotifyCallbackUrl != null && !this.NotifyCallbackUrl.Equals(input.NotifyCallbackUrl))) return false;
            if (this.NotifyEventSubscription != input.NotifyEventSubscription || (this.NotifyEventSubscription != null && input.NotifyEventSubscription != null && !this.NotifyEventSubscription.SequenceEqual(input.NotifyEventSubscription))) return false;
            if (this.SignType != input.SignType) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PublishDomain != null) hashCode = hashCode * 59 + this.PublishDomain.GetHashCode();
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.NotifyCallbackUrl != null) hashCode = hashCode * 59 + this.NotifyCallbackUrl.GetHashCode();
                hashCode = hashCode * 59 + this.NotifyEventSubscription.GetHashCode();
                hashCode = hashCode * 59 + this.SignType.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
