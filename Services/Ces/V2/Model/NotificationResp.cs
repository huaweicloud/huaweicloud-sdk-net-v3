using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NotificationResp 
    {
        /// <summary>
        /// **参数解释**： 通知类型。 **取值范围**： 枚举值。 - notification：SMN通知。 - contact：云账号联系人。 - contactGroup：通知组。 - autoscaling：AS通知，只在AS中使用，不推荐客户使用。 - groupwatch：已废弃，不推荐使用。 - ecsRecovery：已废弃，不推荐使用。 - iecAction：已废弃，不推荐使用。 
        /// </summary>
        /// <value>**参数解释**： 通知类型。 **取值范围**： 枚举值。 - notification：SMN通知。 - contact：云账号联系人。 - contactGroup：通知组。 - autoscaling：AS通知，只在AS中使用，不推荐客户使用。 - groupwatch：已废弃，不推荐使用。 - ecsRecovery：已废弃，不推荐使用。 - iecAction：已废弃，不推荐使用。 </value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum NOTIFICATION for value: notification
            /// </summary>
            public static readonly TypeEnum NOTIFICATION = new TypeEnum("notification");

            /// <summary>
            /// Enum AUTOSCALING for value: autoscaling
            /// </summary>
            public static readonly TypeEnum AUTOSCALING = new TypeEnum("autoscaling");

            /// <summary>
            /// Enum GROUPWATCH for value: groupwatch
            /// </summary>
            public static readonly TypeEnum GROUPWATCH = new TypeEnum("groupwatch");

            /// <summary>
            /// Enum ECSRECOVERY for value: ecsRecovery
            /// </summary>
            public static readonly TypeEnum ECSRECOVERY = new TypeEnum("ecsRecovery");

            /// <summary>
            /// Enum CONTACT for value: contact
            /// </summary>
            public static readonly TypeEnum CONTACT = new TypeEnum("contact");

            /// <summary>
            /// Enum CONTACTGROUP for value: contactGroup
            /// </summary>
            public static readonly TypeEnum CONTACTGROUP = new TypeEnum("contactGroup");

            /// <summary>
            /// Enum IECACTION for value: iecAction
            /// </summary>
            public static readonly TypeEnum IECACTION = new TypeEnum("iecAction");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "notification", NOTIFICATION },
                { "autoscaling", AUTOSCALING },
                { "groupwatch", GROUPWATCH },
                { "ecsRecovery", ECSRECOVERY },
                { "contact", CONTACT },
                { "contactGroup", CONTACTGROUP },
                { "iecAction", IECACTION },
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 通知类型。 **取值范围**： 枚举值。 - notification：SMN通知。 - contact：云账号联系人。 - contactGroup：通知组。 - autoscaling：AS通知，只在AS中使用，不推荐客户使用。 - groupwatch：已废弃，不推荐使用。 - ecsRecovery：已废弃，不推荐使用。 - iecAction：已废弃，不推荐使用。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**：  告警状态发生变化时，被通知对象的列表。topicUrn可从SMN获取，具体操作请参考查询Topic列表。 
        /// </summary>
        [JsonProperty("notification_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NotificationList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationResp {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  notificationList: ").Append(NotificationList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotificationResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NotificationResp input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.NotificationList != input.NotificationList || (this.NotificationList != null && input.NotificationList != null && !this.NotificationList.SequenceEqual(input.NotificationList))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.NotificationList != null) hashCode = hashCode * 59 + this.NotificationList.GetHashCode();
                return hashCode;
            }
        }
    }
}
