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
    /// 控制命令。
    /// </summary>
    public class ControlSmartLiveReq 
    {
        /// <summary>
        /// **参数解释**： 命令名称。 **约束限制**： 不限制 **取值范围**： * INSERT_PLAY_SCRIPT：插入表演脚本。用于互动回复。数字人不变，背景不变。params结构定义：[PlayTextInfo](metastudio_02_0014.xml)。 * INSERT_PLAY_AUDIO：插入驱动音频。用于音频直接驱动。数字人不变，背景不变。params结构定义：[PlayAudioInfo](metastudio_02_0014.xml)。 * REWRITE_PLAY_SCRIPT：动态编辑未播放剧本。params结构定义：[scene_scripts](CreateSmartLiveRoom.xml)。 * REWRITE_INTERACTION_RULES：动态修改互动规则。params结构定义：[interaction_rules](CreateSmartLiveRoom.xml)。 * GET_CURRENT_PLAYING_SCRIPTS：查询本轮剧本列表。响应为：[LivePlayingScriptList](metastudio_02_0014.xml)结构。 * SHOW_LAYER：显示导播素材，用于直播导播。params结构定义：LiveGuideRuleInfo。 * REFRESH_OUTPUT_URL：更新当前任务的rtmp推流信息。params结构定义： RefreshOutputUrlConfig。 * GET_LIVE_JOB_CONFIG_INFO：获取任务中的房间信息。params结构定义：与[直播间详情响应体](ShowSmartLiveRoom.xml)一致。 * CLEAN_UP_INSERT_COMMAND：清理未播放的插入命令。params结构定义：[CleanUpInsertCommand](metastudio_02_0014.xml) * RESET_EXIT_CONFIG: 重置退出参数。params结构定义 LiveExitConfig。例：{\&quot;command\&quot;:\&quot;RESET_EXIT_CONFIG\&quot;,\&quot;params\&quot;:{\&quot;max_live_duration\&quot;:168,\&quot;auto_stop_mode\&quot;:\&quot;FORCE_EXIT\&quot;,\&quot;max_exception_waiting_duration\&quot;:60}} **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 命令名称。 **约束限制**： 不限制 **取值范围**： * INSERT_PLAY_SCRIPT：插入表演脚本。用于互动回复。数字人不变，背景不变。params结构定义：[PlayTextInfo](metastudio_02_0014.xml)。 * INSERT_PLAY_AUDIO：插入驱动音频。用于音频直接驱动。数字人不变，背景不变。params结构定义：[PlayAudioInfo](metastudio_02_0014.xml)。 * REWRITE_PLAY_SCRIPT：动态编辑未播放剧本。params结构定义：[scene_scripts](CreateSmartLiveRoom.xml)。 * REWRITE_INTERACTION_RULES：动态修改互动规则。params结构定义：[interaction_rules](CreateSmartLiveRoom.xml)。 * GET_CURRENT_PLAYING_SCRIPTS：查询本轮剧本列表。响应为：[LivePlayingScriptList](metastudio_02_0014.xml)结构。 * SHOW_LAYER：显示导播素材，用于直播导播。params结构定义：LiveGuideRuleInfo。 * REFRESH_OUTPUT_URL：更新当前任务的rtmp推流信息。params结构定义： RefreshOutputUrlConfig。 * GET_LIVE_JOB_CONFIG_INFO：获取任务中的房间信息。params结构定义：与[直播间详情响应体](ShowSmartLiveRoom.xml)一致。 * CLEAN_UP_INSERT_COMMAND：清理未播放的插入命令。params结构定义：[CleanUpInsertCommand](metastudio_02_0014.xml) * RESET_EXIT_CONFIG: 重置退出参数。params结构定义 LiveExitConfig。例：{\&quot;command\&quot;:\&quot;RESET_EXIT_CONFIG\&quot;,\&quot;params\&quot;:{\&quot;max_live_duration\&quot;:168,\&quot;auto_stop_mode\&quot;:\&quot;FORCE_EXIT\&quot;,\&quot;max_exception_waiting_duration\&quot;:60}} **默认取值**： 不涉及</value>
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
            /// Enum REWRITE_INTERACTION_RULES for value: REWRITE_INTERACTION_RULES
            /// </summary>
            public static readonly CommandEnum REWRITE_INTERACTION_RULES = new CommandEnum("REWRITE_INTERACTION_RULES");

            /// <summary>
            /// Enum GET_CURRENT_PLAYING_SCRIPTS for value: GET_CURRENT_PLAYING_SCRIPTS
            /// </summary>
            public static readonly CommandEnum GET_CURRENT_PLAYING_SCRIPTS = new CommandEnum("GET_CURRENT_PLAYING_SCRIPTS");

            /// <summary>
            /// Enum REFRESH_OUTPUT_URL for value: REFRESH_OUTPUT_URL
            /// </summary>
            public static readonly CommandEnum REFRESH_OUTPUT_URL = new CommandEnum("REFRESH_OUTPUT_URL");

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
                { "REWRITE_INTERACTION_RULES", REWRITE_INTERACTION_RULES },
                { "GET_CURRENT_PLAYING_SCRIPTS", GET_CURRENT_PLAYING_SCRIPTS },
                { "REFRESH_OUTPUT_URL", REFRESH_OUTPUT_URL },
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
        /// **参数解释**： 命令名称。 **约束限制**： 不限制 **取值范围**： * INSERT_PLAY_SCRIPT：插入表演脚本。用于互动回复。数字人不变，背景不变。params结构定义：[PlayTextInfo](metastudio_02_0014.xml)。 * INSERT_PLAY_AUDIO：插入驱动音频。用于音频直接驱动。数字人不变，背景不变。params结构定义：[PlayAudioInfo](metastudio_02_0014.xml)。 * REWRITE_PLAY_SCRIPT：动态编辑未播放剧本。params结构定义：[scene_scripts](CreateSmartLiveRoom.xml)。 * REWRITE_INTERACTION_RULES：动态修改互动规则。params结构定义：[interaction_rules](CreateSmartLiveRoom.xml)。 * GET_CURRENT_PLAYING_SCRIPTS：查询本轮剧本列表。响应为：[LivePlayingScriptList](metastudio_02_0014.xml)结构。 * SHOW_LAYER：显示导播素材，用于直播导播。params结构定义：LiveGuideRuleInfo。 * REFRESH_OUTPUT_URL：更新当前任务的rtmp推流信息。params结构定义： RefreshOutputUrlConfig。 * GET_LIVE_JOB_CONFIG_INFO：获取任务中的房间信息。params结构定义：与[直播间详情响应体](ShowSmartLiveRoom.xml)一致。 * CLEAN_UP_INSERT_COMMAND：清理未播放的插入命令。params结构定义：[CleanUpInsertCommand](metastudio_02_0014.xml) * RESET_EXIT_CONFIG: 重置退出参数。params结构定义 LiveExitConfig。例：{\&quot;command\&quot;:\&quot;RESET_EXIT_CONFIG\&quot;,\&quot;params\&quot;:{\&quot;max_live_duration\&quot;:168,\&quot;auto_stop_mode\&quot;:\&quot;FORCE_EXIT\&quot;,\&quot;max_exception_waiting_duration\&quot;:60}} **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public CommandEnum Command { get; set; }
        /// <summary>
        /// **参数解释**： 命令参数。 **约束限制**： 不限制 **取值范围**： 参考COMMNAD说明。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public Object Params { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("review_config", NullValueHandling = NullValueHandling.Ignore)]
        public ReviewConfig ReviewConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ControlSmartLiveReq {\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  reviewConfig: ").Append(ReviewConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ControlSmartLiveReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ControlSmartLiveReq input)
        {
            if (input == null) return false;
            if (this.Command != input.Command) return false;
            if (this.Params != input.Params || (this.Params != null && !this.Params.Equals(input.Params))) return false;
            if (this.ReviewConfig != input.ReviewConfig || (this.ReviewConfig != null && !this.ReviewConfig.Equals(input.ReviewConfig))) return false;

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
                if (this.Params != null) hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.ReviewConfig != null) hashCode = hashCode * 59 + this.ReviewConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
