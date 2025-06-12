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
    /// 确认直播间剧本请求
    /// </summary>
    public class ConfirmSmarLiveRoomReq 
    {
        /// <summary>
        /// 确认操作。 * confirm: 确认。 * reject: 拒绝。
        /// </summary>
        /// <value>确认操作。 * confirm: 确认。 * reject: 拒绝。</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum CONFIRM for value: confirm
            /// </summary>
            public static readonly ActionEnum CONFIRM = new ActionEnum("confirm");

            /// <summary>
            /// Enum REJECT for value: reject
            /// </summary>
            public static readonly ActionEnum REJECT = new ActionEnum("reject");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "confirm", CONFIRM },
                { "reject", REJECT },
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 确认操作。 * confirm: 确认。 * reject: 拒绝。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 剧本版本。从查询直播间详情接口中获取。
        /// </summary>
        [JsonProperty("script_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfirmSmarLiveRoomReq {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  scriptVersion: ").Append(ScriptVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfirmSmarLiveRoomReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfirmSmarLiveRoomReq input)
        {
            if (input == null) return false;
            if (this.Action != input.Action) return false;
            if (this.ScriptVersion != input.ScriptVersion || (this.ScriptVersion != null && !this.ScriptVersion.Equals(input.ScriptVersion))) return false;

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
                if (this.ScriptVersion != null) hashCode = hashCode * 59 + this.ScriptVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
