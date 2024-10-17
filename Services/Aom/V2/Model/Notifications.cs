using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 发送结果
    /// </summary>
    public class Notifications 
    {
        /// <summary>
        /// 通知类型。SMN：消息通知服务
        /// </summary>
        /// <value>通知类型。SMN：消息通知服务</value>
        [JsonConverter(typeof(EnumClassConverter<NotifierChannelEnum>))]
        public class NotifierChannelEnum
        {
            /// <summary>
            /// Enum SMN for value: SMN
            /// </summary>
            public static readonly NotifierChannelEnum SMN = new NotifierChannelEnum("SMN");

            private static readonly Dictionary<string, NotifierChannelEnum> StaticFields =
            new Dictionary<string, NotifierChannelEnum>()
            {
                { "SMN", SMN },
            };

            private string _value;

            public NotifierChannelEnum()
            {

            }

            public NotifierChannelEnum(string value)
            {
                _value = value;
            }

            public static NotifierChannelEnum FromValue(string value)
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

                if (this.Equals(obj as NotifierChannelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NotifierChannelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NotifierChannelEnum a, NotifierChannelEnum b)
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

            public static bool operator !=(NotifierChannelEnum a, NotifierChannelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 告警行动规则名称
        /// </summary>
        [JsonProperty("action_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionRule { get; set; }

        /// <summary>
        /// 通知类型。SMN：消息通知服务
        /// </summary>
        [JsonProperty("notifier_channel", NullValueHandling = NullValueHandling.Ignore)]
        public NotifierChannelEnum NotifierChannel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("smn_channel", NullValueHandling = NullValueHandling.Ignore)]
        public SmnResponse SmnChannel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notifications {\n");
            sb.Append("  actionRule: ").Append(ActionRule).Append("\n");
            sb.Append("  notifierChannel: ").Append(NotifierChannel).Append("\n");
            sb.Append("  smnChannel: ").Append(SmnChannel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Notifications);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Notifications input)
        {
            if (input == null) return false;
            if (this.ActionRule != input.ActionRule || (this.ActionRule != null && !this.ActionRule.Equals(input.ActionRule))) return false;
            if (this.NotifierChannel != input.NotifierChannel) return false;
            if (this.SmnChannel != input.SmnChannel || (this.SmnChannel != null && !this.SmnChannel.Equals(input.SmnChannel))) return false;

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
                if (this.ActionRule != null) hashCode = hashCode * 59 + this.ActionRule.GetHashCode();
                hashCode = hashCode * 59 + this.NotifierChannel.GetHashCode();
                if (this.SmnChannel != null) hashCode = hashCode * 59 + this.SmnChannel.GetHashCode();
                return hashCode;
            }
        }
    }
}
