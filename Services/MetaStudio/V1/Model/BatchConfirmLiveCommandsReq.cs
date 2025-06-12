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
    /// 批量确认命令。
    /// </summary>
    public class BatchConfirmLiveCommandsReq 
    {
        /// <summary>
        /// 命令名称。 - REWRITE_PLAY_SCRIPT: 动态编辑未播放剧本。 - REWRITE_INTERACTION_RULES: 动态修改互动规则。
        /// </summary>
        /// <value>命令名称。 - REWRITE_PLAY_SCRIPT: 动态编辑未播放剧本。 - REWRITE_INTERACTION_RULES: 动态修改互动规则。</value>
        [JsonConverter(typeof(EnumClassConverter<CommandEnum>))]
        public class CommandEnum
        {
            /// <summary>
            /// Enum REWRITE_PLAY_SCRIPT for value: REWRITE_PLAY_SCRIPT
            /// </summary>
            public static readonly CommandEnum REWRITE_PLAY_SCRIPT = new CommandEnum("REWRITE_PLAY_SCRIPT");

            /// <summary>
            /// Enum REWRITE_INTERACTION_RULES for value: REWRITE_INTERACTION_RULES
            /// </summary>
            public static readonly CommandEnum REWRITE_INTERACTION_RULES = new CommandEnum("REWRITE_INTERACTION_RULES");

            private static readonly Dictionary<string, CommandEnum> StaticFields =
            new Dictionary<string, CommandEnum>()
            {
                { "REWRITE_PLAY_SCRIPT", REWRITE_PLAY_SCRIPT },
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

            public static bool operator !=(CommandEnum a, CommandEnum b)
            {
                return !(a == b);
            }
        }

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
        /// 命令名称。 - REWRITE_PLAY_SCRIPT: 动态编辑未播放剧本。 - REWRITE_INTERACTION_RULES: 动态修改互动规则。
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public CommandEnum Command { get; set; }
        /// <summary>
        /// 确认操作。 * confirm: 确认。 * reject: 拒绝。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 命令ID列表。不填则为全部未播放的插入命令均清理。
        /// </summary>
        [JsonProperty("command_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CommandIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchConfirmLiveCommandsReq {\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  commandIds: ").Append(CommandIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchConfirmLiveCommandsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchConfirmLiveCommandsReq input)
        {
            if (input == null) return false;
            if (this.Command != input.Command) return false;
            if (this.Action != input.Action) return false;
            if (this.CommandIds != input.CommandIds || (this.CommandIds != null && input.CommandIds != null && !this.CommandIds.SequenceEqual(input.CommandIds))) return false;

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
                hashCode = hashCode * 59 + this.Command.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.CommandIds != null) hashCode = hashCode * 59 + this.CommandIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
