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
    /// 开播风险警告
    /// </summary>
    public class LiveWarningItem 
    {
        /// <summary>
        /// 告警类型。 - TOO_LESSS_SCRIPT_ITEMS：段落（话术）数量太少。 - TOO_SHORT_SCRIPT_TIME：段落（话术）总时长太短。 - TOO_LESS_DANMAKU_RULES： 弹幕互动规则太少。 - RANDOM_PLAY_CLOSED: 随机播放开关关闭。 - ROTATION_MODEL_CLOSED: 主播轮转未配置。
        /// </summary>
        /// <value>告警类型。 - TOO_LESSS_SCRIPT_ITEMS：段落（话术）数量太少。 - TOO_SHORT_SCRIPT_TIME：段落（话术）总时长太短。 - TOO_LESS_DANMAKU_RULES： 弹幕互动规则太少。 - RANDOM_PLAY_CLOSED: 随机播放开关关闭。 - ROTATION_MODEL_CLOSED: 主播轮转未配置。</value>
        [JsonConverter(typeof(EnumClassConverter<WarningTypeEnum>))]
        public class WarningTypeEnum
        {
            /// <summary>
            /// Enum TOO_LESSS_SCRIPT_ITEMS for value: TOO_LESSS_SCRIPT_ITEMS
            /// </summary>
            public static readonly WarningTypeEnum TOO_LESSS_SCRIPT_ITEMS = new WarningTypeEnum("TOO_LESSS_SCRIPT_ITEMS");

            /// <summary>
            /// Enum TOO_SHORT_SCRIPT_TIME for value: TOO_SHORT_SCRIPT_TIME
            /// </summary>
            public static readonly WarningTypeEnum TOO_SHORT_SCRIPT_TIME = new WarningTypeEnum("TOO_SHORT_SCRIPT_TIME");

            /// <summary>
            /// Enum TOO_LESS_DANMAKU_RULES for value: TOO_LESS_DANMAKU_RULES
            /// </summary>
            public static readonly WarningTypeEnum TOO_LESS_DANMAKU_RULES = new WarningTypeEnum("TOO_LESS_DANMAKU_RULES");

            /// <summary>
            /// Enum RANDOM_PLAY_CLOSED for value: RANDOM_PLAY_CLOSED
            /// </summary>
            public static readonly WarningTypeEnum RANDOM_PLAY_CLOSED = new WarningTypeEnum("RANDOM_PLAY_CLOSED");

            /// <summary>
            /// Enum ROTATION_MODEL_CLOSED for value: ROTATION_MODEL_CLOSED
            /// </summary>
            public static readonly WarningTypeEnum ROTATION_MODEL_CLOSED = new WarningTypeEnum("ROTATION_MODEL_CLOSED");

            private static readonly Dictionary<string, WarningTypeEnum> StaticFields =
            new Dictionary<string, WarningTypeEnum>()
            {
                { "TOO_LESSS_SCRIPT_ITEMS", TOO_LESSS_SCRIPT_ITEMS },
                { "TOO_SHORT_SCRIPT_TIME", TOO_SHORT_SCRIPT_TIME },
                { "TOO_LESS_DANMAKU_RULES", TOO_LESS_DANMAKU_RULES },
                { "RANDOM_PLAY_CLOSED", RANDOM_PLAY_CLOSED },
                { "ROTATION_MODEL_CLOSED", ROTATION_MODEL_CLOSED },
            };

            private string _value;

            public WarningTypeEnum()
            {

            }

            public WarningTypeEnum(string value)
            {
                _value = value;
            }

            public static WarningTypeEnum FromValue(string value)
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

                if (this.Equals(obj as WarningTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(WarningTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(WarningTypeEnum a, WarningTypeEnum b)
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

            public static bool operator !=(WarningTypeEnum a, WarningTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 告警类型。 - TOO_LESSS_SCRIPT_ITEMS：段落（话术）数量太少。 - TOO_SHORT_SCRIPT_TIME：段落（话术）总时长太短。 - TOO_LESS_DANMAKU_RULES： 弹幕互动规则太少。 - RANDOM_PLAY_CLOSED: 随机播放开关关闭。 - ROTATION_MODEL_CLOSED: 主播轮转未配置。
        /// </summary>
        [JsonProperty("warning_type", NullValueHandling = NullValueHandling.Ignore)]
        public WarningTypeEnum WarningType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveWarningItem {\n");
            sb.Append("  warningType: ").Append(WarningType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveWarningItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveWarningItem input)
        {
            if (input == null) return false;
            if (this.WarningType != input.WarningType) return false;

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
                hashCode = hashCode * 59 + this.WarningType.GetHashCode();
                return hashCode;
            }
        }
    }
}
