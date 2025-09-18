using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListNotificationsRequest 
    {
        /// <summary>
        /// 通知类型。
        /// </summary>
        /// <value>通知类型。</value>
        [JsonConverter(typeof(EnumClassConverter<NotificationTypeEnum>))]
        public class NotificationTypeEnum
        {
            /// <summary>
            /// Enum SMN for value: smn
            /// </summary>
            public static readonly NotificationTypeEnum SMN = new NotificationTypeEnum("smn");

            /// <summary>
            /// Enum FUN for value: fun
            /// </summary>
            public static readonly NotificationTypeEnum FUN = new NotificationTypeEnum("fun");

            private static readonly Dictionary<string, NotificationTypeEnum> StaticFields =
            new Dictionary<string, NotificationTypeEnum>()
            {
                { "smn", SMN },
                { "fun", FUN },
            };

            private string _value;

            public NotificationTypeEnum()
            {

            }

            public NotificationTypeEnum(string value)
            {
                _value = value;
            }

            public static NotificationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as NotificationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NotificationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NotificationTypeEnum a, NotificationTypeEnum b)
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

            public static bool operator !=(NotificationTypeEnum a, NotificationTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 通知类型。
        /// </summary>
        [SDKProperty("notification_type", IsPath = true)]
        [JsonProperty("notification_type", NullValueHandling = NullValueHandling.Ignore)]
        public NotificationTypeEnum NotificationType { get; set; }
        /// <summary>
        /// 标识关键操作通知名称。 在不传入该字段的情况下，将查询当前租户所有的关键操作通知。
        /// </summary>
        [SDKProperty("notification_name", IsQuery = true)]
        [JsonProperty("notification_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNotificationsRequest {\n");
            sb.Append("  notificationType: ").Append(NotificationType).Append("\n");
            sb.Append("  notificationName: ").Append(NotificationName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNotificationsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNotificationsRequest input)
        {
            if (input == null) return false;
            if (this.NotificationType != input.NotificationType) return false;
            if (this.NotificationName != input.NotificationName || (this.NotificationName != null && !this.NotificationName.Equals(input.NotificationName))) return false;

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
                hashCode = hashCode * 59 + this.NotificationType.GetHashCode();
                if (this.NotificationName != null) hashCode = hashCode * 59 + this.NotificationName.GetHashCode();
                return hashCode;
            }
        }
    }
}
