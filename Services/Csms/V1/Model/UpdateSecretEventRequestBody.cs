using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// 更新凭据事件通知请求体。
    /// </summary>
    public class UpdateSecretEventRequestBody 
    {
        /// <summary>
        /// 事件通知状态，取值如下。  ENABLED：表示启用状态 DISABLED：表示禁用状态
        /// </summary>
        /// <value>事件通知状态，取值如下。  ENABLED：表示启用状态 DISABLED：表示禁用状态</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum ENABLED for value: ENABLED
            /// </summary>
            public static readonly StateEnum ENABLED = new StateEnum("ENABLED");

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly StateEnum DISABLED = new StateEnum("DISABLED");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "ENABLED", ENABLED },
                { "DISABLED", DISABLED },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 基础事件类型。
        /// </summary>
        /// <value>基础事件类型。</value>
        [JsonConverter(typeof(EnumClassConverter<EventTypesEnum>))]
        public class EventTypesEnum
        {
            /// <summary>
            /// Enum SECRET_VERSION_CREATED for value: SECRET_VERSION_CREATED
            /// </summary>
            public static readonly EventTypesEnum SECRET_VERSION_CREATED = new EventTypesEnum("SECRET_VERSION_CREATED");

            /// <summary>
            /// Enum SECRET_VERSION_EXPIRED for value: SECRET_VERSION_EXPIRED
            /// </summary>
            public static readonly EventTypesEnum SECRET_VERSION_EXPIRED = new EventTypesEnum("SECRET_VERSION_EXPIRED");

            /// <summary>
            /// Enum SECRET_ROTATED for value: SECRET_ROTATED
            /// </summary>
            public static readonly EventTypesEnum SECRET_ROTATED = new EventTypesEnum("SECRET_ROTATED");

            /// <summary>
            /// Enum SECRET_DELETED for value: SECRET_DELETED
            /// </summary>
            public static readonly EventTypesEnum SECRET_DELETED = new EventTypesEnum("SECRET_DELETED");

            /// <summary>
            /// Enum SECRET_ROTATED_FAILED for value: SECRET_ROTATED_FAILED
            /// </summary>
            public static readonly EventTypesEnum SECRET_ROTATED_FAILED = new EventTypesEnum("SECRET_ROTATED_FAILED");

            private static readonly Dictionary<string, EventTypesEnum> StaticFields =
            new Dictionary<string, EventTypesEnum>()
            {
                { "SECRET_VERSION_CREATED", SECRET_VERSION_CREATED },
                { "SECRET_VERSION_EXPIRED", SECRET_VERSION_EXPIRED },
                { "SECRET_ROTATED", SECRET_ROTATED },
                { "SECRET_DELETED", SECRET_DELETED },
                { "SECRET_ROTATED_FAILED", SECRET_ROTATED_FAILED },
            };

            private string _value;

            public EventTypesEnum()
            {

            }

            public EventTypesEnum(string value)
            {
                _value = value;
            }

            public static EventTypesEnum FromValue(string value)
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

                if (this.Equals(obj as EventTypesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EventTypesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EventTypesEnum a, EventTypesEnum b)
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

            public static bool operator !=(EventTypesEnum a, EventTypesEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 事件通知状态，取值如下。  ENABLED：表示启用状态 DISABLED：表示禁用状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 本次事件通知的基础事件列表，基础事件类型如下。  - SECRET_VERSION_CREATED:版本创建 - SECRET_VERSION_EXPIRED:版本过期 - SECRET_ROTATED:凭据轮转成功 - SECRET_DELETED:凭据删除 - SECRET_ROTATED_FAILED:凭据轮转失败  列表包含的基础事件类型不能重复。
        /// </summary>
        [JsonProperty("event_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<EventTypesEnum> EventTypes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("notification", NullValueHandling = NullValueHandling.Ignore)]
        public Notification Notification { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSecretEventRequestBody {\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  eventTypes: ").Append(EventTypes).Append("\n");
            sb.Append("  notification: ").Append(Notification).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSecretEventRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSecretEventRequestBody input)
        {
            if (input == null) return false;
            if (this.State != input.State) return false;
            if (this.EventTypes != input.EventTypes || (this.EventTypes != null && input.EventTypes != null && !this.EventTypes.SequenceEqual(input.EventTypes))) return false;
            if (this.Notification != input.Notification || (this.Notification != null && !this.Notification.Equals(input.Notification))) return false;

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
                hashCode = hashCode * 59 + this.State.GetHashCode();
                hashCode = hashCode * 59 + this.EventTypes.GetHashCode();
                if (this.Notification != null) hashCode = hashCode * 59 + this.Notification.GetHashCode();
                return hashCode;
            }
        }
    }
}
