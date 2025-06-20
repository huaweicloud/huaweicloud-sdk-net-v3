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
    public class UpdateSmartChatRoomResponse : SdkResponse
    {
        /// <summary>
        /// 默认语言，智能交互接口使用。默认值CN。 * CN：简体中文。 * EN：英语。 * ESP：西班牙语（仅海外站点支持） * por：葡萄牙语（仅海外站点支持） * Arabic：阿拉伯语（仅海外站点支持） * Thai：泰语（仅海外站点支持）
        /// </summary>
        /// <value>默认语言，智能交互接口使用。默认值CN。 * CN：简体中文。 * EN：英语。 * ESP：西班牙语（仅海外站点支持） * por：葡萄牙语（仅海外站点支持） * Arabic：阿拉伯语（仅海外站点支持） * Thai：泰语（仅海外站点支持）</value>
        [JsonConverter(typeof(EnumClassConverter<DefaultLanguageEnum>))]
        public class DefaultLanguageEnum
        {
            /// <summary>
            /// Enum CN for value: CN
            /// </summary>
            public static readonly DefaultLanguageEnum CN = new DefaultLanguageEnum("CN");

            /// <summary>
            /// Enum EN for value: EN
            /// </summary>
            public static readonly DefaultLanguageEnum EN = new DefaultLanguageEnum("EN");

            /// <summary>
            /// Enum ESP for value: ESP
            /// </summary>
            public static readonly DefaultLanguageEnum ESP = new DefaultLanguageEnum("ESP");

            /// <summary>
            /// Enum POR for value: por
            /// </summary>
            public static readonly DefaultLanguageEnum POR = new DefaultLanguageEnum("por");

            /// <summary>
            /// Enum ARABIC for value: Arabic
            /// </summary>
            public static readonly DefaultLanguageEnum ARABIC = new DefaultLanguageEnum("Arabic");

            /// <summary>
            /// Enum THAI for value: Thai
            /// </summary>
            public static readonly DefaultLanguageEnum THAI = new DefaultLanguageEnum("Thai");

            private static readonly Dictionary<string, DefaultLanguageEnum> StaticFields =
            new Dictionary<string, DefaultLanguageEnum>()
            {
                { "CN", CN },
                { "EN", EN },
                { "ESP", ESP },
                { "por", POR },
                { "Arabic", ARABIC },
                { "Thai", THAI },
            };

            private string _value;

            public DefaultLanguageEnum()
            {

            }

            public DefaultLanguageEnum(string value)
            {
                _value = value;
            }

            public static DefaultLanguageEnum FromValue(string value)
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

                if (this.Equals(obj as DefaultLanguageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DefaultLanguageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DefaultLanguageEnum a, DefaultLanguageEnum b)
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

            public static bool operator !=(DefaultLanguageEnum a, DefaultLanguageEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 智能交互对话端配置。 * COMPUTER: 电脑端 * MOBILE: 手机端 * HUB: 大屏
        /// </summary>
        /// <value>智能交互对话端配置。 * COMPUTER: 电脑端 * MOBILE: 手机端 * HUB: 大屏</value>
        [JsonConverter(typeof(EnumClassConverter<ChatVideoTypeEnum>))]
        public class ChatVideoTypeEnum
        {
            /// <summary>
            /// Enum COMPUTER for value: COMPUTER
            /// </summary>
            public static readonly ChatVideoTypeEnum COMPUTER = new ChatVideoTypeEnum("COMPUTER");

            /// <summary>
            /// Enum MOBILE for value: MOBILE
            /// </summary>
            public static readonly ChatVideoTypeEnum MOBILE = new ChatVideoTypeEnum("MOBILE");

            /// <summary>
            /// Enum HUB for value: HUB
            /// </summary>
            public static readonly ChatVideoTypeEnum HUB = new ChatVideoTypeEnum("HUB");

            private static readonly Dictionary<string, ChatVideoTypeEnum> StaticFields =
            new Dictionary<string, ChatVideoTypeEnum>()
            {
                { "COMPUTER", COMPUTER },
                { "MOBILE", MOBILE },
                { "HUB", HUB },
            };

            private string _value;

            public ChatVideoTypeEnum()
            {

            }

            public ChatVideoTypeEnum(string value)
            {
                _value = value;
            }

            public static ChatVideoTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ChatVideoTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChatVideoTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChatVideoTypeEnum a, ChatVideoTypeEnum b)
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

            public static bool operator !=(ChatVideoTypeEnum a, ChatVideoTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 对话名称
        /// </summary>
        [JsonProperty("room_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomName { get; set; }

        /// <summary>
        /// 对话描述。
        /// </summary>
        [JsonProperty("room_description", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_config", NullValueHandling = NullValueHandling.Ignore)]
        public VideoConfig VideoConfig { get; set; }

        /// <summary>
        /// 数字人模型资产ID。
        /// </summary>
        [JsonProperty("model_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelAssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("voice_config", NullValueHandling = NullValueHandling.Ignore)]
        public VoiceConfig VoiceConfig { get; set; }

        /// <summary>
        /// 语音配置参数列表。
        /// </summary>
        [JsonProperty("voice_config_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChatVoiceConfig> VoiceConfigList { get; set; }

        /// <summary>
        /// 机器人ID。获取方法请参考[创建应用](CreateRobot.xml)。
        /// </summary>
        [JsonProperty("robot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotId { get; set; }

        /// <summary>
        /// **参数解释**： 并发路数。 **约束限制**： 默认没有并发路数，如果不配置并发数量，则无法启动智能交互对话任务。
        /// </summary>
        [JsonProperty("concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// 默认语言，智能交互接口使用。默认值CN。 * CN：简体中文。 * EN：英语。 * ESP：西班牙语（仅海外站点支持） * por：葡萄牙语（仅海外站点支持） * Arabic：阿拉伯语（仅海外站点支持） * Thai：泰语（仅海外站点支持）
        /// </summary>
        [JsonProperty("default_language", NullValueHandling = NullValueHandling.Ignore)]
        public DefaultLanguageEnum DefaultLanguage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("background_config", NullValueHandling = NullValueHandling.Ignore)]
        public BackgroundConfigInfo BackgroundConfig { get; set; }

        /// <summary>
        /// 图层配置。
        /// </summary>
        [JsonProperty("layer_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<LayerConfig> LayerConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("review_config", NullValueHandling = NullValueHandling.Ignore)]
        public ReviewConfig ReviewConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("chat_subtitle_config", NullValueHandling = NullValueHandling.Ignore)]
        public ChatSubtitleConfig ChatSubtitleConfig { get; set; }

        /// <summary>
        /// 智能交互对话端配置。 * COMPUTER: 电脑端 * MOBILE: 手机端 * HUB: 大屏
        /// </summary>
        [JsonProperty("chat_video_type", NullValueHandling = NullValueHandling.Ignore)]
        public ChatVideoTypeEnum ChatVideoType { get; set; }
        /// <summary>
        /// **参数解释**： 静默退出时长。
        /// </summary>
        [JsonProperty("exit_mute_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExitMuteThreshold { get; set; }

        /// <summary>
        /// 对话ID。
        /// </summary>
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 智能交互对话创建时间，格式遵循：RFC 3339 如“2021-01-10T08:43:17Z”。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 智能交互对话更新时间，格式遵循：RFC 3339 如“2021-01-10T08:43:17Z”。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 对话封面图URL
        /// </summary>
        [JsonProperty("cover_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 是否是资源池模式
        /// </summary>
        [JsonProperty("is_pool_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPoolMode { get; set; }

        /// <summary>
        /// 资源配置。
        /// </summary>
        [JsonProperty("chat_resource_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChatResourceConfigInfo> ChatResourceConfig { get; set; }

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
            sb.Append("class UpdateSmartChatRoomResponse {\n");
            sb.Append("  roomName: ").Append(RoomName).Append("\n");
            sb.Append("  roomDescription: ").Append(RoomDescription).Append("\n");
            sb.Append("  videoConfig: ").Append(VideoConfig).Append("\n");
            sb.Append("  modelAssetId: ").Append(ModelAssetId).Append("\n");
            sb.Append("  voiceConfig: ").Append(VoiceConfig).Append("\n");
            sb.Append("  voiceConfigList: ").Append(VoiceConfigList).Append("\n");
            sb.Append("  robotId: ").Append(RobotId).Append("\n");
            sb.Append("  concurrency: ").Append(Concurrency).Append("\n");
            sb.Append("  defaultLanguage: ").Append(DefaultLanguage).Append("\n");
            sb.Append("  backgroundConfig: ").Append(BackgroundConfig).Append("\n");
            sb.Append("  layerConfig: ").Append(LayerConfig).Append("\n");
            sb.Append("  reviewConfig: ").Append(ReviewConfig).Append("\n");
            sb.Append("  chatSubtitleConfig: ").Append(ChatSubtitleConfig).Append("\n");
            sb.Append("  chatVideoType: ").Append(ChatVideoType).Append("\n");
            sb.Append("  exitMuteThreshold: ").Append(ExitMuteThreshold).Append("\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  coverUrl: ").Append(CoverUrl).Append("\n");
            sb.Append("  isPoolMode: ").Append(IsPoolMode).Append("\n");
            sb.Append("  chatResourceConfig: ").Append(ChatResourceConfig).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSmartChatRoomResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSmartChatRoomResponse input)
        {
            if (input == null) return false;
            if (this.RoomName != input.RoomName || (this.RoomName != null && !this.RoomName.Equals(input.RoomName))) return false;
            if (this.RoomDescription != input.RoomDescription || (this.RoomDescription != null && !this.RoomDescription.Equals(input.RoomDescription))) return false;
            if (this.VideoConfig != input.VideoConfig || (this.VideoConfig != null && !this.VideoConfig.Equals(input.VideoConfig))) return false;
            if (this.ModelAssetId != input.ModelAssetId || (this.ModelAssetId != null && !this.ModelAssetId.Equals(input.ModelAssetId))) return false;
            if (this.VoiceConfig != input.VoiceConfig || (this.VoiceConfig != null && !this.VoiceConfig.Equals(input.VoiceConfig))) return false;
            if (this.VoiceConfigList != input.VoiceConfigList || (this.VoiceConfigList != null && input.VoiceConfigList != null && !this.VoiceConfigList.SequenceEqual(input.VoiceConfigList))) return false;
            if (this.RobotId != input.RobotId || (this.RobotId != null && !this.RobotId.Equals(input.RobotId))) return false;
            if (this.Concurrency != input.Concurrency || (this.Concurrency != null && !this.Concurrency.Equals(input.Concurrency))) return false;
            if (this.DefaultLanguage != input.DefaultLanguage) return false;
            if (this.BackgroundConfig != input.BackgroundConfig || (this.BackgroundConfig != null && !this.BackgroundConfig.Equals(input.BackgroundConfig))) return false;
            if (this.LayerConfig != input.LayerConfig || (this.LayerConfig != null && input.LayerConfig != null && !this.LayerConfig.SequenceEqual(input.LayerConfig))) return false;
            if (this.ReviewConfig != input.ReviewConfig || (this.ReviewConfig != null && !this.ReviewConfig.Equals(input.ReviewConfig))) return false;
            if (this.ChatSubtitleConfig != input.ChatSubtitleConfig || (this.ChatSubtitleConfig != null && !this.ChatSubtitleConfig.Equals(input.ChatSubtitleConfig))) return false;
            if (this.ChatVideoType != input.ChatVideoType) return false;
            if (this.ExitMuteThreshold != input.ExitMuteThreshold || (this.ExitMuteThreshold != null && !this.ExitMuteThreshold.Equals(input.ExitMuteThreshold))) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.CoverUrl != input.CoverUrl || (this.CoverUrl != null && !this.CoverUrl.Equals(input.CoverUrl))) return false;
            if (this.IsPoolMode != input.IsPoolMode || (this.IsPoolMode != null && !this.IsPoolMode.Equals(input.IsPoolMode))) return false;
            if (this.ChatResourceConfig != input.ChatResourceConfig || (this.ChatResourceConfig != null && input.ChatResourceConfig != null && !this.ChatResourceConfig.SequenceEqual(input.ChatResourceConfig))) return false;
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
                if (this.RoomName != null) hashCode = hashCode * 59 + this.RoomName.GetHashCode();
                if (this.RoomDescription != null) hashCode = hashCode * 59 + this.RoomDescription.GetHashCode();
                if (this.VideoConfig != null) hashCode = hashCode * 59 + this.VideoConfig.GetHashCode();
                if (this.ModelAssetId != null) hashCode = hashCode * 59 + this.ModelAssetId.GetHashCode();
                if (this.VoiceConfig != null) hashCode = hashCode * 59 + this.VoiceConfig.GetHashCode();
                if (this.VoiceConfigList != null) hashCode = hashCode * 59 + this.VoiceConfigList.GetHashCode();
                if (this.RobotId != null) hashCode = hashCode * 59 + this.RobotId.GetHashCode();
                if (this.Concurrency != null) hashCode = hashCode * 59 + this.Concurrency.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultLanguage.GetHashCode();
                if (this.BackgroundConfig != null) hashCode = hashCode * 59 + this.BackgroundConfig.GetHashCode();
                if (this.LayerConfig != null) hashCode = hashCode * 59 + this.LayerConfig.GetHashCode();
                if (this.ReviewConfig != null) hashCode = hashCode * 59 + this.ReviewConfig.GetHashCode();
                if (this.ChatSubtitleConfig != null) hashCode = hashCode * 59 + this.ChatSubtitleConfig.GetHashCode();
                hashCode = hashCode * 59 + this.ChatVideoType.GetHashCode();
                if (this.ExitMuteThreshold != null) hashCode = hashCode * 59 + this.ExitMuteThreshold.GetHashCode();
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.CoverUrl != null) hashCode = hashCode * 59 + this.CoverUrl.GetHashCode();
                if (this.IsPoolMode != null) hashCode = hashCode * 59 + this.IsPoolMode.GetHashCode();
                if (this.ChatResourceConfig != null) hashCode = hashCode * 59 + this.ChatResourceConfig.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
