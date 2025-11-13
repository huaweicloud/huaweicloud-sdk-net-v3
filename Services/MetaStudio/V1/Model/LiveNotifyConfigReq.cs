using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 直播通知配置。通过短信，邮件，站内信通知用户直播中断。用户可在华为云消息中心配置接受者信息
    /// </summary>
    public class LiveNotifyConfigReq 
    {
        /// <summary>
        /// 确认操作。 * add: 增加。 * del: 删除。 * replace：替换。
        /// </summary>
        /// <value>确认操作。 * add: 增加。 * del: 删除。 * replace：替换。</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum ADD for value: add
            /// </summary>
            public static readonly ActionEnum ADD = new ActionEnum("add");

            /// <summary>
            /// Enum DEL for value: del
            /// </summary>
            public static readonly ActionEnum DEL = new ActionEnum("del");

            /// <summary>
            /// Enum REPLACE for value: replace
            /// </summary>
            public static readonly ActionEnum REPLACE = new ActionEnum("replace");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "add", ADD },
                { "del", DEL },
                { "replace", REPLACE },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 确认操作。 * add: 增加。 * del: 删除。 * replace：替换。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// **参数解释**： 启用通知事件列表。 **约束限制**： 不涉及 **默认取值**： 无。
        /// </summary>
        [JsonProperty("notify_events", NullValueHandling = NullValueHandling.Ignore)]
        public List<NotifyEventEnum> NotifyEvents { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveNotifyConfigReq {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  notifyEvents: ").Append(NotifyEvents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveNotifyConfigReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveNotifyConfigReq input)
        {
            if (input == null) return false;
            if (this.Action != input.Action) return false;
            if (this.NotifyEvents != input.NotifyEvents || (this.NotifyEvents != null && input.NotifyEvents != null && !this.NotifyEvents.SequenceEqual(input.NotifyEvents))) return false;

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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.NotifyEvents != null) hashCode = hashCode * 59 + this.NotifyEvents.GetHashCode();
                return hashCode;
            }
        }
    }
}
