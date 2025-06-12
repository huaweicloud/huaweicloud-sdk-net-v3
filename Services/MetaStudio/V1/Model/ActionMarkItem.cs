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
    /// 标注的动作信息。
    /// </summary>
    public class ActionMarkItem 
    {
        /// <summary>
        /// 动作类型。 * SILENCE: 静默 * ACTION：动作
        /// </summary>
        /// <value>动作类型。 * SILENCE: 静默 * ACTION：动作</value>
        [JsonConverter(typeof(EnumClassConverter<ActionTypeEnum>))]
        public class ActionTypeEnum
        {
            /// <summary>
            /// Enum SILENCE for value: SILENCE
            /// </summary>
            public static readonly ActionTypeEnum SILENCE = new ActionTypeEnum("SILENCE");

            /// <summary>
            /// Enum ACTION for value: ACTION
            /// </summary>
            public static readonly ActionTypeEnum ACTION = new ActionTypeEnum("ACTION");

            private static readonly Dictionary<string, ActionTypeEnum> StaticFields =
            new Dictionary<string, ActionTypeEnum>()
            {
                { "SILENCE", SILENCE },
                { "ACTION", ACTION },
            };

            private string _value;

            public ActionTypeEnum()
            {

            }

            public ActionTypeEnum(string value)
            {
                _value = value;
            }

            public static ActionTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ActionTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionTypeEnum a, ActionTypeEnum b)
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

            public static bool operator !=(ActionTypeEnum a, ActionTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 选取推理数据预处理视频起始时间。格式：“HH:MM:SS.mmm”。
        /// </summary>
        [JsonProperty("action_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionStartTime { get; set; }

        /// <summary>
        /// 选取推理数据预处理视频结束时间。格式：“HH:MM:SS.mmm”。
        /// </summary>
        [JsonProperty("action_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionEndTime { get; set; }

        /// <summary>
        /// 动作类型。 * SILENCE: 静默 * ACTION：动作
        /// </summary>
        [JsonProperty("action_type", NullValueHandling = NullValueHandling.Ignore)]
        public ActionTypeEnum ActionType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionMarkItem {\n");
            sb.Append("  actionStartTime: ").Append(ActionStartTime).Append("\n");
            sb.Append("  actionEndTime: ").Append(ActionEndTime).Append("\n");
            sb.Append("  actionType: ").Append(ActionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionMarkItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActionMarkItem input)
        {
            if (input == null) return false;
            if (this.ActionStartTime != input.ActionStartTime || (this.ActionStartTime != null && !this.ActionStartTime.Equals(input.ActionStartTime))) return false;
            if (this.ActionEndTime != input.ActionEndTime || (this.ActionEndTime != null && !this.ActionEndTime.Equals(input.ActionEndTime))) return false;
            if (this.ActionType != input.ActionType) return false;

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
                if (this.ActionStartTime != null) hashCode = hashCode * 59 + this.ActionStartTime.GetHashCode();
                if (this.ActionEndTime != null) hashCode = hashCode * 59 + this.ActionEndTime.GetHashCode();
                hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
