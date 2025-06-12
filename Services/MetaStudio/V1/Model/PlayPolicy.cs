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
    /// 剧本播放策略
    /// </summary>
    public class PlayPolicy 
    {
        /// <summary>
        /// **参数解释**： 驱动方式。 **约束限制**： 不涉及。 **取值范围**： * TEXT：文本驱动，即通过TTS合成语音。 * AUDIO：语音驱动。 * NO_PRESET：无预置剧本，人工控制模式。
        /// </summary>
        /// <value>**参数解释**： 驱动方式。 **约束限制**： 不涉及。 **取值范围**： * TEXT：文本驱动，即通过TTS合成语音。 * AUDIO：语音驱动。 * NO_PRESET：无预置剧本，人工控制模式。</value>
        [JsonConverter(typeof(EnumClassConverter<PlayModeEnum>))]
        public class PlayModeEnum
        {
            /// <summary>
            /// Enum TEXT for value: TEXT
            /// </summary>
            public static readonly PlayModeEnum TEXT = new PlayModeEnum("TEXT");

            /// <summary>
            /// Enum AUDIO for value: AUDIO
            /// </summary>
            public static readonly PlayModeEnum AUDIO = new PlayModeEnum("AUDIO");

            /// <summary>
            /// Enum NO_PRESET for value: NO_PRESET
            /// </summary>
            public static readonly PlayModeEnum NO_PRESET = new PlayModeEnum("NO_PRESET");

            private static readonly Dictionary<string, PlayModeEnum> StaticFields =
            new Dictionary<string, PlayModeEnum>()
            {
                { "TEXT", TEXT },
                { "AUDIO", AUDIO },
                { "NO_PRESET", NO_PRESET },
            };

            private string _value;

            public PlayModeEnum()
            {

            }

            public PlayModeEnum(string value)
            {
                _value = value;
            }

            public static PlayModeEnum FromValue(string value)
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

                if (this.Equals(obj as PlayModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PlayModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PlayModeEnum a, PlayModeEnum b)
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

            public static bool operator !=(PlayModeEnum a, PlayModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 随机播报模式。 **约束限制**： 从第二轮播报开始随机。 **取值范围**： * NONE：不启动随机播报。 * SCENE：按场景随机播报。场景内段落按顺序播报。 * SCRIPT_ITEM：按段落随机播报。场景按顺序播报。 * SCENE_AND_SCRIPT_ITEM：场景和段落都随机播报。
        /// </summary>
        /// <value>**参数解释**： 随机播报模式。 **约束限制**： 从第二轮播报开始随机。 **取值范围**： * NONE：不启动随机播报。 * SCENE：按场景随机播报。场景内段落按顺序播报。 * SCRIPT_ITEM：按段落随机播报。场景按顺序播报。 * SCENE_AND_SCRIPT_ITEM：场景和段落都随机播报。</value>
        [JsonConverter(typeof(EnumClassConverter<RandomPlayModeEnum>))]
        public class RandomPlayModeEnum
        {
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            public static readonly RandomPlayModeEnum NONE = new RandomPlayModeEnum("NONE");

            /// <summary>
            /// Enum SCENE for value: SCENE
            /// </summary>
            public static readonly RandomPlayModeEnum SCENE = new RandomPlayModeEnum("SCENE");

            /// <summary>
            /// Enum SCRIPT_ITEM for value: SCRIPT_ITEM
            /// </summary>
            public static readonly RandomPlayModeEnum SCRIPT_ITEM = new RandomPlayModeEnum("SCRIPT_ITEM");

            /// <summary>
            /// Enum SCENE_AND_SCRIPT_ITEM for value: SCENE_AND_SCRIPT_ITEM
            /// </summary>
            public static readonly RandomPlayModeEnum SCENE_AND_SCRIPT_ITEM = new RandomPlayModeEnum("SCENE_AND_SCRIPT_ITEM");

            private static readonly Dictionary<string, RandomPlayModeEnum> StaticFields =
            new Dictionary<string, RandomPlayModeEnum>()
            {
                { "NONE", NONE },
                { "SCENE", SCENE },
                { "SCRIPT_ITEM", SCRIPT_ITEM },
                { "SCENE_AND_SCRIPT_ITEM", SCENE_AND_SCRIPT_ITEM },
            };

            private string _value;

            public RandomPlayModeEnum()
            {

            }

            public RandomPlayModeEnum(string value)
            {
                _value = value;
            }

            public static RandomPlayModeEnum FromValue(string value)
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

                if (this.Equals(obj as RandomPlayModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RandomPlayModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RandomPlayModeEnum a, RandomPlayModeEnum b)
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

            public static bool operator !=(RandomPlayModeEnum a, RandomPlayModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 剧本重复播放次数。 * -1：表示持续重复，直至人工停止。 * 0：表示不重复，仅执行一次。 * 其他值n：实际运行次数为n+1次。  **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("repeat_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepeatCount { get; set; }

        /// <summary>
        /// **参数解释**： 是否自动播放剧本。 **约束限制**： 不涉及。 **取值范围**： * true：服务完成任务初始化后，自动播放剧本。 * false：服务完成任务初始化后，等待信号后再开始播放剧本。
        /// </summary>
        [JsonProperty("auto_play_script", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoPlayScript { get; set; }

        /// <summary>
        /// **参数解释**： 驱动方式。 **约束限制**： 不涉及。 **取值范围**： * TEXT：文本驱动，即通过TTS合成语音。 * AUDIO：语音驱动。 * NO_PRESET：无预置剧本，人工控制模式。
        /// </summary>
        [JsonProperty("play_mode", NullValueHandling = NullValueHandling.Ignore)]
        public PlayModeEnum PlayMode { get; set; }
        /// <summary>
        /// **参数解释**： 随机播报模式。 **约束限制**： 从第二轮播报开始随机。 **取值范围**： * NONE：不启动随机播报。 * SCENE：按场景随机播报。场景内段落按顺序播报。 * SCRIPT_ITEM：按段落随机播报。场景按顺序播报。 * SCENE_AND_SCRIPT_ITEM：场景和段落都随机播报。
        /// </summary>
        [JsonProperty("random_play_mode", NullValueHandling = NullValueHandling.Ignore)]
        public RandomPlayModeEnum RandomPlayMode { get; set; }
        /// <summary>
        /// **参数解释**： 是否需要独立采集端。用于客户端播放与命令分离场景。 **约束限制**： 不涉及。 **取值范围**： * true：分配CAPTURE、PLAYER两个RTC用户。 * false：仅分配PLAYER一个RTC用户。
        /// </summary>
        [JsonProperty("need_independent_capture_client", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedIndependentCaptureClient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("live_exit_config", NullValueHandling = NullValueHandling.Ignore)]
        public LiveExitConfig LiveExitConfig { get; set; }

        /// <summary>
        /// **参数解释**： 动态编辑未播放剧本是否需要下一轮生效。 **约束限制**： 不涉及。 **取值范围**： * true：下一轮生效。 * false：马上生效。 **默认取值**： false
        /// </summary>
        [JsonProperty("is_rewrite_delay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRewriteDelay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayPolicy {\n");
            sb.Append("  repeatCount: ").Append(RepeatCount).Append("\n");
            sb.Append("  autoPlayScript: ").Append(AutoPlayScript).Append("\n");
            sb.Append("  playMode: ").Append(PlayMode).Append("\n");
            sb.Append("  randomPlayMode: ").Append(RandomPlayMode).Append("\n");
            sb.Append("  needIndependentCaptureClient: ").Append(NeedIndependentCaptureClient).Append("\n");
            sb.Append("  liveExitConfig: ").Append(LiveExitConfig).Append("\n");
            sb.Append("  isRewriteDelay: ").Append(IsRewriteDelay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PlayPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PlayPolicy input)
        {
            if (input == null) return false;
            if (this.RepeatCount != input.RepeatCount || (this.RepeatCount != null && !this.RepeatCount.Equals(input.RepeatCount))) return false;
            if (this.AutoPlayScript != input.AutoPlayScript || (this.AutoPlayScript != null && !this.AutoPlayScript.Equals(input.AutoPlayScript))) return false;
            if (this.PlayMode != input.PlayMode) return false;
            if (this.RandomPlayMode != input.RandomPlayMode) return false;
            if (this.NeedIndependentCaptureClient != input.NeedIndependentCaptureClient || (this.NeedIndependentCaptureClient != null && !this.NeedIndependentCaptureClient.Equals(input.NeedIndependentCaptureClient))) return false;
            if (this.LiveExitConfig != input.LiveExitConfig || (this.LiveExitConfig != null && !this.LiveExitConfig.Equals(input.LiveExitConfig))) return false;
            if (this.IsRewriteDelay != input.IsRewriteDelay || (this.IsRewriteDelay != null && !this.IsRewriteDelay.Equals(input.IsRewriteDelay))) return false;

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
                if (this.RepeatCount != null) hashCode = hashCode * 59 + this.RepeatCount.GetHashCode();
                if (this.AutoPlayScript != null) hashCode = hashCode * 59 + this.AutoPlayScript.GetHashCode();
                hashCode = hashCode * 59 + this.PlayMode.GetHashCode();
                hashCode = hashCode * 59 + this.RandomPlayMode.GetHashCode();
                if (this.NeedIndependentCaptureClient != null) hashCode = hashCode * 59 + this.NeedIndependentCaptureClient.GetHashCode();
                if (this.LiveExitConfig != null) hashCode = hashCode * 59 + this.LiveExitConfig.GetHashCode();
                if (this.IsRewriteDelay != null) hashCode = hashCode * 59 + this.IsRewriteDelay.GetHashCode();
                return hashCode;
            }
        }
    }
}
