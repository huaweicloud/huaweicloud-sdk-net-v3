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
    public class SMNAction 
    {
        /// <summary>
        /// 通知类型
        /// </summary>
        /// <value>通知类型</value>
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

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "notification", NOTIFICATION },
                { "autoscaling", AUTOSCALING },
                { "groupwatch", GROUPWATCH },
                { "ecsRecovery", ECSRECOVERY },
                { "contact", CONTACT },
                { "contactGroup", CONTACTGROUP },
            };

            private string Value;

            public TypeEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 通知类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 告警状态发生变化时，被通知对象的列表。通知对象ID最多可以配置5个。topicUrn可从SMN获取，具体操作请参考查询Topic列表。当type为notification时，notificationList列表不能为空；当type为autoscaling时，列表必须为[]。 说明：若alarm_action_enabled为true，对应的alarm_actions、insufficientdata_actions（该参数已废弃，建议无需配置）、ok_actions至少有一个不能为空。若alarm_actions、insufficientdata_actions（该参数已废弃，建议无需配置）、ok_actions同时存在时，notificationList值保持一致。
        /// </summary>
        [JsonProperty("notification_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NotificationList { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SMNAction {\n");
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
            return this.Equals(input as SMNAction);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SMNAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.NotificationList == input.NotificationList ||
                    this.NotificationList != null &&
                    input.NotificationList != null &&
                    this.NotificationList.SequenceEqual(input.NotificationList)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.NotificationList != null)
                    hashCode = hashCode * 59 + this.NotificationList.GetHashCode();
                return hashCode;
            }
        }
    }
}
