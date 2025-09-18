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
    /// 触发器处理
    /// </summary>
    public class TriggerProcess 
    {
        /// <summary>
        /// **参数解释**： 回复类型。 **约束限制**： 不涉及 **取值范围**： * SYSTEM_REPLY：系统自动回复预先设置的话术。 * CALLBACK：回调给其他服务，携带设置的话术。 * SYSTEM_REPLY_AND_CALLBACK：系统自动回复预先设置的话术，同时回调给用户,携带设置的话术。 * SHOW_LAYER：仅显示叠加图层，不影响话术。 * INTELLIGENT_REPLY：使用配置的大模型生成回复话术。  **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 回复类型。 **约束限制**： 不涉及 **取值范围**： * SYSTEM_REPLY：系统自动回复预先设置的话术。 * CALLBACK：回调给其他服务，携带设置的话术。 * SYSTEM_REPLY_AND_CALLBACK：系统自动回复预先设置的话术，同时回调给用户,携带设置的话术。 * SHOW_LAYER：仅显示叠加图层，不影响话术。 * INTELLIGENT_REPLY：使用配置的大模型生成回复话术。  **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<ReplyModeEnum>))]
        public class ReplyModeEnum
        {
            /// <summary>
            /// Enum SYSTEM_REPLY for value: SYSTEM_REPLY
            /// </summary>
            public static readonly ReplyModeEnum SYSTEM_REPLY = new ReplyModeEnum("SYSTEM_REPLY");

            /// <summary>
            /// Enum CALLBACK for value: CALLBACK
            /// </summary>
            public static readonly ReplyModeEnum CALLBACK = new ReplyModeEnum("CALLBACK");

            /// <summary>
            /// Enum SYSTEM_REPLY_AND_CALLBACK for value: SYSTEM_REPLY_AND_CALLBACK
            /// </summary>
            public static readonly ReplyModeEnum SYSTEM_REPLY_AND_CALLBACK = new ReplyModeEnum("SYSTEM_REPLY_AND_CALLBACK");

            /// <summary>
            /// Enum SHOW_LAYER for value: SHOW_LAYER
            /// </summary>
            public static readonly ReplyModeEnum SHOW_LAYER = new ReplyModeEnum("SHOW_LAYER");

            /// <summary>
            /// Enum INTELLIGENT_REPLY for value: INTELLIGENT_REPLY
            /// </summary>
            public static readonly ReplyModeEnum INTELLIGENT_REPLY = new ReplyModeEnum("INTELLIGENT_REPLY");

            private static readonly Dictionary<string, ReplyModeEnum> StaticFields =
            new Dictionary<string, ReplyModeEnum>()
            {
                { "SYSTEM_REPLY", SYSTEM_REPLY },
                { "CALLBACK", CALLBACK },
                { "SYSTEM_REPLY_AND_CALLBACK", SYSTEM_REPLY_AND_CALLBACK },
                { "SHOW_LAYER", SHOW_LAYER },
                { "INTELLIGENT_REPLY", INTELLIGENT_REPLY },
            };

            private string _value;

            public ReplyModeEnum()
            {

            }

            public ReplyModeEnum(string value)
            {
                _value = value;
            }

            public static ReplyModeEnum FromValue(string value)
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

                if (this.Equals(obj as ReplyModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ReplyModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ReplyModeEnum a, ReplyModeEnum b)
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

            public static bool operator !=(ReplyModeEnum a, ReplyModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 回复话术选择次序。 **约束限制**： 不涉及 **取值范围**： * RANDOM：随机 * ORDER：顺序循环  **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 回复话术选择次序。 **约束限制**： 不涉及 **取值范围**： * RANDOM：随机 * ORDER：顺序循环  **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<ReplyOrderEnum>))]
        public class ReplyOrderEnum
        {
            /// <summary>
            /// Enum RANDOM for value: RANDOM
            /// </summary>
            public static readonly ReplyOrderEnum RANDOM = new ReplyOrderEnum("RANDOM");

            /// <summary>
            /// Enum ORDER for value: ORDER
            /// </summary>
            public static readonly ReplyOrderEnum ORDER = new ReplyOrderEnum("ORDER");

            private static readonly Dictionary<string, ReplyOrderEnum> StaticFields =
            new Dictionary<string, ReplyOrderEnum>()
            {
                { "RANDOM", RANDOM },
                { "ORDER", ORDER },
            };

            private string _value;

            public ReplyOrderEnum()
            {

            }

            public ReplyOrderEnum(string value)
            {
                _value = value;
            }

            public static ReplyOrderEnum FromValue(string value)
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

                if (this.Equals(obj as ReplyOrderEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ReplyOrderEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ReplyOrderEnum a, ReplyOrderEnum b)
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

            public static bool operator !=(ReplyOrderEnum a, ReplyOrderEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 回复角色。 **约束限制**： 不涉及 **取值范围**： * STREAMER：主播 * CO_STREAMER：助播，仅声音。
        /// </summary>
        /// <value>**参数解释**： 回复角色。 **约束限制**： 不涉及 **取值范围**： * STREAMER：主播 * CO_STREAMER：助播，仅声音。</value>
        [JsonConverter(typeof(EnumClassConverter<ReplyRoleEnum>))]
        public class ReplyRoleEnum
        {
            /// <summary>
            /// Enum STREAMER for value: STREAMER
            /// </summary>
            public static readonly ReplyRoleEnum STREAMER = new ReplyRoleEnum("STREAMER");

            /// <summary>
            /// Enum CO_STREAMER for value: CO_STREAMER
            /// </summary>
            public static readonly ReplyRoleEnum CO_STREAMER = new ReplyRoleEnum("CO_STREAMER");

            private static readonly Dictionary<string, ReplyRoleEnum> StaticFields =
            new Dictionary<string, ReplyRoleEnum>()
            {
                { "STREAMER", STREAMER },
                { "CO_STREAMER", CO_STREAMER },
            };

            private string _value;

            public ReplyRoleEnum()
            {

            }

            public ReplyRoleEnum(string value)
            {
                _value = value;
            }

            public static ReplyRoleEnum FromValue(string value)
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

                if (this.Equals(obj as ReplyRoleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ReplyRoleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ReplyRoleEnum a, ReplyRoleEnum b)
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

            public static bool operator !=(ReplyRoleEnum a, ReplyRoleEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 回复播放类型。 - APPEND：追加，放置在场景播放队列尾部 - INSERT： 插入，在两个音频文件，或者文本句末添加。 - PLAY_NOW : 立即插入，收到指令后，立即播放，无需等待句末。
        /// </summary>
        /// <value>回复播放类型。 - APPEND：追加，放置在场景播放队列尾部 - INSERT： 插入，在两个音频文件，或者文本句末添加。 - PLAY_NOW : 立即插入，收到指令后，立即播放，无需等待句末。</value>
        [JsonConverter(typeof(EnumClassConverter<PlayTypeEnum>))]
        public class PlayTypeEnum
        {
            /// <summary>
            /// Enum APPEND for value: APPEND
            /// </summary>
            public static readonly PlayTypeEnum APPEND = new PlayTypeEnum("APPEND");

            /// <summary>
            /// Enum INSERT for value: INSERT
            /// </summary>
            public static readonly PlayTypeEnum INSERT = new PlayTypeEnum("INSERT");

            /// <summary>
            /// Enum PLAY_NOW for value: PLAY_NOW
            /// </summary>
            public static readonly PlayTypeEnum PLAY_NOW = new PlayTypeEnum("PLAY_NOW");

            private static readonly Dictionary<string, PlayTypeEnum> StaticFields =
            new Dictionary<string, PlayTypeEnum>()
            {
                { "APPEND", APPEND },
                { "INSERT", INSERT },
                { "PLAY_NOW", PLAY_NOW },
            };

            private string _value;

            public PlayTypeEnum()
            {

            }

            public PlayTypeEnum(string value)
            {
                _value = value;
            }

            public static PlayTypeEnum FromValue(string value)
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

                if (this.Equals(obj as PlayTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PlayTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PlayTypeEnum a, PlayTypeEnum b)
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

            public static bool operator !=(PlayTypeEnum a, PlayTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 处理抑制时长。单位秒。 - -1：表示整场直播仅触发一次。 - 0：表示无抑制，每次都触发。 - 其他值n：表示n秒内仅触发一次。  **约束限制**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("time_window", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeWindow { get; set; }

        /// <summary>
        /// **参数解释**： 回复类型。 **约束限制**： 不涉及 **取值范围**： * SYSTEM_REPLY：系统自动回复预先设置的话术。 * CALLBACK：回调给其他服务，携带设置的话术。 * SYSTEM_REPLY_AND_CALLBACK：系统自动回复预先设置的话术，同时回调给用户,携带设置的话术。 * SHOW_LAYER：仅显示叠加图层，不影响话术。 * INTELLIGENT_REPLY：使用配置的大模型生成回复话术。  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("reply_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ReplyModeEnum ReplyMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("layer_config", NullValueHandling = NullValueHandling.Ignore)]
        public SmartLayerConfig LayerConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extra_layer_config", NullValueHandling = NullValueHandling.Ignore)]
        public SmartLayerConfig ExtraLayerConfig { get; set; }

        /// <summary>
        /// **参数解释**： 回复话术集。 **约束限制**： 不涉及 **取值范围**： 最大支持5条预置话术。 单条话术字符长度0-1024位。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("reply_texts", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReplyTexts { get; set; }

        /// <summary>
        /// **参数解释**： 回复音频集。填写audio_url。 **约束限制**： 不涉及 **取值范围**： 最大支持5条预置音频。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("reply_audios", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReplyAudioInfo> ReplyAudios { get; set; }

        /// <summary>
        /// **参数解释**： 回复话术选择次序。 **约束限制**： 不涉及 **取值范围**： * RANDOM：随机 * ORDER：顺序循环  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("reply_order", NullValueHandling = NullValueHandling.Ignore)]
        public ReplyOrderEnum ReplyOrder { get; set; }
        /// <summary>
        /// **参数解释**： 回复角色。 **约束限制**： 不涉及 **取值范围**： * STREAMER：主播 * CO_STREAMER：助播，仅声音。
        /// </summary>
        [JsonProperty("reply_role", NullValueHandling = NullValueHandling.Ignore)]
        public ReplyRoleEnum ReplyRole { get; set; }
        /// <summary>
        /// **参数解释**： 机器人ID。 **约束限制**： reply_mode为INTELLIGENT_REPLY时必填，智能交互配置的大模型机器人ID。 获取方法请参考[创建应用](CreateRobot.xml)。 **取值范围**： 字符长度0-64位。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("robot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotId { get; set; }

        /// <summary>
        /// 回复播放类型。 - APPEND：追加，放置在场景播放队列尾部 - INSERT： 插入，在两个音频文件，或者文本句末添加。 - PLAY_NOW : 立即插入，收到指令后，立即播放，无需等待句末。
        /// </summary>
        [JsonProperty("play_type", NullValueHandling = NullValueHandling.Ignore)]
        public PlayTypeEnum PlayType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TriggerProcess {\n");
            sb.Append("  timeWindow: ").Append(TimeWindow).Append("\n");
            sb.Append("  replyMode: ").Append(ReplyMode).Append("\n");
            sb.Append("  layerConfig: ").Append(LayerConfig).Append("\n");
            sb.Append("  extraLayerConfig: ").Append(ExtraLayerConfig).Append("\n");
            sb.Append("  replyTexts: ").Append(ReplyTexts).Append("\n");
            sb.Append("  replyAudios: ").Append(ReplyAudios).Append("\n");
            sb.Append("  replyOrder: ").Append(ReplyOrder).Append("\n");
            sb.Append("  replyRole: ").Append(ReplyRole).Append("\n");
            sb.Append("  robotId: ").Append(RobotId).Append("\n");
            sb.Append("  playType: ").Append(PlayType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TriggerProcess);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TriggerProcess input)
        {
            if (input == null) return false;
            if (this.TimeWindow != input.TimeWindow || (this.TimeWindow != null && !this.TimeWindow.Equals(input.TimeWindow))) return false;
            if (this.ReplyMode != input.ReplyMode) return false;
            if (this.LayerConfig != input.LayerConfig || (this.LayerConfig != null && !this.LayerConfig.Equals(input.LayerConfig))) return false;
            if (this.ExtraLayerConfig != input.ExtraLayerConfig || (this.ExtraLayerConfig != null && !this.ExtraLayerConfig.Equals(input.ExtraLayerConfig))) return false;
            if (this.ReplyTexts != input.ReplyTexts || (this.ReplyTexts != null && input.ReplyTexts != null && !this.ReplyTexts.SequenceEqual(input.ReplyTexts))) return false;
            if (this.ReplyAudios != input.ReplyAudios || (this.ReplyAudios != null && input.ReplyAudios != null && !this.ReplyAudios.SequenceEqual(input.ReplyAudios))) return false;
            if (this.ReplyOrder != input.ReplyOrder) return false;
            if (this.ReplyRole != input.ReplyRole) return false;
            if (this.RobotId != input.RobotId || (this.RobotId != null && !this.RobotId.Equals(input.RobotId))) return false;
            if (this.PlayType != input.PlayType) return false;

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
                if (this.TimeWindow != null) hashCode = hashCode * 59 + this.TimeWindow.GetHashCode();
                hashCode = hashCode * 59 + this.ReplyMode.GetHashCode();
                if (this.LayerConfig != null) hashCode = hashCode * 59 + this.LayerConfig.GetHashCode();
                if (this.ExtraLayerConfig != null) hashCode = hashCode * 59 + this.ExtraLayerConfig.GetHashCode();
                if (this.ReplyTexts != null) hashCode = hashCode * 59 + this.ReplyTexts.GetHashCode();
                if (this.ReplyAudios != null) hashCode = hashCode * 59 + this.ReplyAudios.GetHashCode();
                hashCode = hashCode * 59 + this.ReplyOrder.GetHashCode();
                hashCode = hashCode * 59 + this.ReplyRole.GetHashCode();
                if (this.RobotId != null) hashCode = hashCode * 59 + this.RobotId.GetHashCode();
                hashCode = hashCode * 59 + this.PlayType.GetHashCode();
                return hashCode;
            }
        }
    }
}
