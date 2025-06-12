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
    /// Response Object
    /// </summary>
    public class ExecuteSmartLiveCommandResponse : SdkResponse
    {
        /// <summary>
        /// 命令名称。 - INSERT_PLAY_SCRIPT：插入表演脚本。用于互动回复。数字人不变，背景不变。params结构定义：ShootScript。 - REWRITE_PLAY_SCRIPT：动态编辑未播放剧本。params结构定义：scene_scripts。 - INSERT_PLAY_AUDIO：插入驱动音频。用于音频直接驱动。数字人不变，背景不变。params结构定义：PlayAudioInfo。 - GET_CURRENT_PLAYING_SCRIPTS：查询本轮剧本列表。响应为LivePlayingScriptList结构。 - REFRESH_OUTPUT_URL：更新当前任务的rtmp推流信息。params结构定义： RefreshOutputUrlConfig。 - REWRITE_INTERACTION_RULES：动态修改互动规则。params结构定义：interaction_rules。 - GET_LIVE_JOB_CONFIG_INFO：获取任务中的房间信息。params结构定义：SmartLiveRoomInfo。 - CLEAN_UP_INSERT_COMMAND：清理未播放的插入命令。params结构定义：[CleanUpInsertCommand](metastudio_02_0014.xml) - RESET_EXIT_CONFIG: 重置退出参数。params结构定义：LiveExitConfig
        /// </summary>
        /// <value>命令名称。 - INSERT_PLAY_SCRIPT：插入表演脚本。用于互动回复。数字人不变，背景不变。params结构定义：ShootScript。 - REWRITE_PLAY_SCRIPT：动态编辑未播放剧本。params结构定义：scene_scripts。 - INSERT_PLAY_AUDIO：插入驱动音频。用于音频直接驱动。数字人不变，背景不变。params结构定义：PlayAudioInfo。 - GET_CURRENT_PLAYING_SCRIPTS：查询本轮剧本列表。响应为LivePlayingScriptList结构。 - REFRESH_OUTPUT_URL：更新当前任务的rtmp推流信息。params结构定义： RefreshOutputUrlConfig。 - REWRITE_INTERACTION_RULES：动态修改互动规则。params结构定义：interaction_rules。 - GET_LIVE_JOB_CONFIG_INFO：获取任务中的房间信息。params结构定义：SmartLiveRoomInfo。 - CLEAN_UP_INSERT_COMMAND：清理未播放的插入命令。params结构定义：[CleanUpInsertCommand](metastudio_02_0014.xml) - RESET_EXIT_CONFIG: 重置退出参数。params结构定义：LiveExitConfig</value>
        [JsonConverter(typeof(EnumClassConverter<CommandEnum>))]
        public class CommandEnum
        {
            /// <summary>
            /// Enum INSERT_PLAY_SCRIPT for value: INSERT_PLAY_SCRIPT
            /// </summary>
            public static readonly CommandEnum INSERT_PLAY_SCRIPT = new CommandEnum("INSERT_PLAY_SCRIPT");

            /// <summary>
            /// Enum REWRITE_PLAY_SCRIPT for value: REWRITE_PLAY_SCRIPT
            /// </summary>
            public static readonly CommandEnum REWRITE_PLAY_SCRIPT = new CommandEnum("REWRITE_PLAY_SCRIPT");

            /// <summary>
            /// Enum INSERT_PLAY_AUDIO for value: INSERT_PLAY_AUDIO
            /// </summary>
            public static readonly CommandEnum INSERT_PLAY_AUDIO = new CommandEnum("INSERT_PLAY_AUDIO");

            /// <summary>
            /// Enum GET_CURRENT_PLAYING_SCRIPTS for value: GET_CURRENT_PLAYING_SCRIPTS
            /// </summary>
            public static readonly CommandEnum GET_CURRENT_PLAYING_SCRIPTS = new CommandEnum("GET_CURRENT_PLAYING_SCRIPTS");

            /// <summary>
            /// Enum REFRESH_OUTPUT_URL for value: REFRESH_OUTPUT_URL
            /// </summary>
            public static readonly CommandEnum REFRESH_OUTPUT_URL = new CommandEnum("REFRESH_OUTPUT_URL");

            /// <summary>
            /// Enum REWRITE_INTERACTION_RULES for value: REWRITE_INTERACTION_RULES
            /// </summary>
            public static readonly CommandEnum REWRITE_INTERACTION_RULES = new CommandEnum("REWRITE_INTERACTION_RULES");

            /// <summary>
            /// Enum GET_LIVE_JOB_CONFIG_INFO for value: GET_LIVE_JOB_CONFIG_INFO
            /// </summary>
            public static readonly CommandEnum GET_LIVE_JOB_CONFIG_INFO = new CommandEnum("GET_LIVE_JOB_CONFIG_INFO");

            /// <summary>
            /// Enum CLEAN_UP_INSERT_COMMAND for value: CLEAN_UP_INSERT_COMMAND
            /// </summary>
            public static readonly CommandEnum CLEAN_UP_INSERT_COMMAND = new CommandEnum("CLEAN_UP_INSERT_COMMAND");

            /// <summary>
            /// Enum RESET_EXIT_CONFIG for value: RESET_EXIT_CONFIG
            /// </summary>
            public static readonly CommandEnum RESET_EXIT_CONFIG = new CommandEnum("RESET_EXIT_CONFIG");

            private static readonly Dictionary<string, CommandEnum> StaticFields =
            new Dictionary<string, CommandEnum>()
            {
                { "INSERT_PLAY_SCRIPT", INSERT_PLAY_SCRIPT },
                { "REWRITE_PLAY_SCRIPT", REWRITE_PLAY_SCRIPT },
                { "INSERT_PLAY_AUDIO", INSERT_PLAY_AUDIO },
                { "GET_CURRENT_PLAYING_SCRIPTS", GET_CURRENT_PLAYING_SCRIPTS },
                { "REFRESH_OUTPUT_URL", REFRESH_OUTPUT_URL },
                { "REWRITE_INTERACTION_RULES", REWRITE_INTERACTION_RULES },
                { "GET_LIVE_JOB_CONFIG_INFO", GET_LIVE_JOB_CONFIG_INFO },
                { "CLEAN_UP_INSERT_COMMAND", CLEAN_UP_INSERT_COMMAND },
                { "RESET_EXIT_CONFIG", RESET_EXIT_CONFIG },
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
        /// 控制命令ID
        /// </summary>
        [JsonProperty("command_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandId { get; set; }

        /// <summary>
        /// 命令名称。 - INSERT_PLAY_SCRIPT：插入表演脚本。用于互动回复。数字人不变，背景不变。params结构定义：ShootScript。 - REWRITE_PLAY_SCRIPT：动态编辑未播放剧本。params结构定义：scene_scripts。 - INSERT_PLAY_AUDIO：插入驱动音频。用于音频直接驱动。数字人不变，背景不变。params结构定义：PlayAudioInfo。 - GET_CURRENT_PLAYING_SCRIPTS：查询本轮剧本列表。响应为LivePlayingScriptList结构。 - REFRESH_OUTPUT_URL：更新当前任务的rtmp推流信息。params结构定义： RefreshOutputUrlConfig。 - REWRITE_INTERACTION_RULES：动态修改互动规则。params结构定义：interaction_rules。 - GET_LIVE_JOB_CONFIG_INFO：获取任务中的房间信息。params结构定义：SmartLiveRoomInfo。 - CLEAN_UP_INSERT_COMMAND：清理未播放的插入命令。params结构定义：[CleanUpInsertCommand](metastudio_02_0014.xml) - RESET_EXIT_CONFIG: 重置退出参数。params结构定义：LiveExitConfig
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public CommandEnum Command { get; set; }
        /// <summary>
        /// 命令执行结果
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteSmartLiveCommandResponse {\n");
            sb.Append("  commandId: ").Append(CommandId).Append("\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteSmartLiveCommandResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteSmartLiveCommandResponse input)
        {
            if (input == null) return false;
            if (this.CommandId != input.CommandId || (this.CommandId != null && !this.CommandId.Equals(input.CommandId))) return false;
            if (this.Command != input.Command) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
