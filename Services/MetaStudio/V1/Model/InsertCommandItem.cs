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
    /// 插入播放命令列表
    /// </summary>
    public class InsertCommandItem 
    {
        /// <summary>
        /// 命令名称。 - INSERT_PLAY_SCRIPT: 插入表演脚本。用于互动回复。数字人不变，背景不变。params结构定义：[PlayTextInfo](metastudio_02_0014.xml) - INSERT_PLAY_AUDIO:插入驱动音频。用于音频直接驱动。数字人不变，背景不变。params结构定义：[PlayAudioInfo](metastudio_02_0014.xml) - REWRITE_INTERACTION_RULES: 修改互动规则。params结构定义：[PlayAudioInfo](metastudio_02_0014.xml)
        /// </summary>
        /// <value>命令名称。 - INSERT_PLAY_SCRIPT: 插入表演脚本。用于互动回复。数字人不变，背景不变。params结构定义：[PlayTextInfo](metastudio_02_0014.xml) - INSERT_PLAY_AUDIO:插入驱动音频。用于音频直接驱动。数字人不变，背景不变。params结构定义：[PlayAudioInfo](metastudio_02_0014.xml) - REWRITE_INTERACTION_RULES: 修改互动规则。params结构定义：[PlayAudioInfo](metastudio_02_0014.xml)</value>
        [JsonConverter(typeof(EnumClassConverter<CommandEnum>))]
        public class CommandEnum
        {
            /// <summary>
            /// Enum INSERT_PLAY_SCRIPT for value: INSERT_PLAY_SCRIPT
            /// </summary>
            public static readonly CommandEnum INSERT_PLAY_SCRIPT = new CommandEnum("INSERT_PLAY_SCRIPT");

            /// <summary>
            /// Enum INSERT_PLAY_AUDIO for value: INSERT_PLAY_AUDIO
            /// </summary>
            public static readonly CommandEnum INSERT_PLAY_AUDIO = new CommandEnum("INSERT_PLAY_AUDIO");

            /// <summary>
            /// Enum REWRITE_INTERACTION_RULES for value: REWRITE_INTERACTION_RULES
            /// </summary>
            public static readonly CommandEnum REWRITE_INTERACTION_RULES = new CommandEnum("REWRITE_INTERACTION_RULES");

            private static readonly Dictionary<string, CommandEnum> StaticFields =
            new Dictionary<string, CommandEnum>()
            {
                { "INSERT_PLAY_SCRIPT", INSERT_PLAY_SCRIPT },
                { "INSERT_PLAY_AUDIO", INSERT_PLAY_AUDIO },
                { "REWRITE_INTERACTION_RULES", REWRITE_INTERACTION_RULES },
            };

            private string _value;

            public CommandEnum()
            {

            }

            public CommandEnum(string value)
            {
                _value = value;
            }

            public static CommandEnum FromValue(string value)
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

                if (this.Equals(obj as CommandEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CommandEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CommandEnum a, CommandEnum b)
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

            public static bool operator !=(CommandEnum a, CommandEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 命令来源。 * EXTERNAL： 外部命令 * AUTO: 系统自动触发
        /// </summary>
        /// <value>命令来源。 * EXTERNAL： 外部命令 * AUTO: 系统自动触发</value>
        [JsonConverter(typeof(EnumClassConverter<SourceEnum>))]
        public class SourceEnum
        {
            /// <summary>
            /// Enum EXTERNAL for value: EXTERNAL
            /// </summary>
            public static readonly SourceEnum EXTERNAL = new SourceEnum("EXTERNAL");

            /// <summary>
            /// Enum AUTO for value: AUTO
            /// </summary>
            public static readonly SourceEnum AUTO = new SourceEnum("AUTO");

            private static readonly Dictionary<string, SourceEnum> StaticFields =
            new Dictionary<string, SourceEnum>()
            {
                { "EXTERNAL", EXTERNAL },
                { "AUTO", AUTO },
            };

            private string _value;

            public SourceEnum()
            {

            }

            public SourceEnum(string value)
            {
                _value = value;
            }

            public static SourceEnum FromValue(string value)
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

                if (this.Equals(obj as SourceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SourceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SourceEnum a, SourceEnum b)
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

            public static bool operator !=(SourceEnum a, SourceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 控制命令ID
        /// </summary>
        [JsonProperty("command_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandId { get; set; }

        /// <summary>
        /// 命令名称。 - INSERT_PLAY_SCRIPT: 插入表演脚本。用于互动回复。数字人不变，背景不变。params结构定义：[PlayTextInfo](metastudio_02_0014.xml) - INSERT_PLAY_AUDIO:插入驱动音频。用于音频直接驱动。数字人不变，背景不变。params结构定义：[PlayAudioInfo](metastudio_02_0014.xml) - REWRITE_INTERACTION_RULES: 修改互动规则。params结构定义：[PlayAudioInfo](metastudio_02_0014.xml)
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public CommandEnum Command { get; set; }
        /// <summary>
        /// 命令参数。
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public Object Params { get; set; }

        /// <summary>
        /// 命令来源。 * EXTERNAL： 外部命令 * AUTO: 系统自动触发
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public SourceEnum Source { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsertCommandItem {\n");
            sb.Append("  commandId: ").Append(CommandId).Append("\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InsertCommandItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InsertCommandItem input)
        {
            if (input == null) return false;
            if (this.CommandId != input.CommandId || (this.CommandId != null && !this.CommandId.Equals(input.CommandId))) return false;
            if (this.Command != input.Command) return false;
            if (this.Params != input.Params || (this.Params != null && !this.Params.Equals(input.Params))) return false;
            if (this.Source != input.Source) return false;

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
                if (this.CommandId != null) hashCode = hashCode * 59 + this.CommandId.GetHashCode();
                hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Params != null) hashCode = hashCode * 59 + this.Params.GetHashCode();
                hashCode = hashCode * 59 + this.Source.GetHashCode();
                return hashCode;
            }
        }
    }
}
