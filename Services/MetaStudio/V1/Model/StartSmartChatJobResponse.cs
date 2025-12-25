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
    public class StartSmartChatJobResponse : SdkResponse
    {
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

            public static bool operator !=(ChatVideoTypeEnum a, ChatVideoTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 默认语言，智能交互接口使用。默认值CN。 * CN：中文。 * EN：英文。 * ESP：西班牙语（仅海外站点支持） * por：葡萄牙语（仅海外站点支持） * Arabic：阿拉伯语（仅海外站点支持） * Thai：泰语（仅海外站点支持） * fr：法语（仅海外站点支持）
        /// </summary>
        /// <value>默认语言，智能交互接口使用。默认值CN。 * CN：中文。 * EN：英文。 * ESP：西班牙语（仅海外站点支持） * por：葡萄牙语（仅海外站点支持） * Arabic：阿拉伯语（仅海外站点支持） * Thai：泰语（仅海外站点支持） * fr：法语（仅海外站点支持）</value>
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

            /// <summary>
            /// Enum FR for value: fr
            /// </summary>
            public static readonly DefaultLanguageEnum FR = new DefaultLanguageEnum("fr");

            private static readonly Dictionary<string, DefaultLanguageEnum> StaticFields =
            new Dictionary<string, DefaultLanguageEnum>()
            {
                { "CN", CN },
                { "EN", EN },
                { "ESP", ESP },
                { "por", POR },
                { "Arabic", ARABIC },
                { "Thai", THAI },
                { "fr", FR },
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

            public static bool operator !=(DefaultLanguageEnum a, DefaultLanguageEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 智能交互对话任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rtc_room_info", NullValueHandling = NullValueHandling.Ignore)]
        public RTCRoomInfoList RtcRoomInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("chat_subtitle_config", NullValueHandling = NullValueHandling.Ignore)]
        public SmartChatSubtitleConfig ChatSubtitleConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_config", NullValueHandling = NullValueHandling.Ignore)]
        public SmartChatVideoConfig VideoConfig { get; set; }

        /// <summary>
        /// 语音配置参数列表。
        /// </summary>
        [JsonProperty("voice_config_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SmartChatVoiceConfig> VoiceConfigList { get; set; }

        /// <summary>
        /// 智能交互对话端配置。 * COMPUTER: 电脑端 * MOBILE: 手机端 * HUB: 大屏
        /// </summary>
        [JsonProperty("chat_video_type", NullValueHandling = NullValueHandling.Ignore)]
        public ChatVideoTypeEnum ChatVideoType { get; set; }
        /// <summary>
        /// 算力所在region。 * cn-north-4: 北京4 * cn-southwest-2: 贵阳1
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 智能交互接入地址。
        /// </summary>
        [JsonProperty("chat_access_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ChatAccessAddress { get; set; }

        /// <summary>
        /// 智能交互Rest接口接入地址。
        /// </summary>
        [JsonProperty("chat_access_rest_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ChatAccessRestAddress { get; set; }

        /// <summary>
        /// 是否透明背景
        /// </summary>
        [JsonProperty("is_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTransparent { get; set; }

        /// <summary>
        /// 默认语言，智能交互接口使用。默认值CN。 * CN：中文。 * EN：英文。 * ESP：西班牙语（仅海外站点支持） * por：葡萄牙语（仅海外站点支持） * Arabic：阿拉伯语（仅海外站点支持） * Thai：泰语（仅海外站点支持） * fr：法语（仅海外站点支持）
        /// </summary>
        [JsonProperty("default_language", NullValueHandling = NullValueHandling.Ignore)]
        public DefaultLanguageEnum DefaultLanguage { get; set; }
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
            sb.Append("class StartSmartChatJobResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  rtcRoomInfo: ").Append(RtcRoomInfo).Append("\n");
            sb.Append("  chatSubtitleConfig: ").Append(ChatSubtitleConfig).Append("\n");
            sb.Append("  videoConfig: ").Append(VideoConfig).Append("\n");
            sb.Append("  voiceConfigList: ").Append(VoiceConfigList).Append("\n");
            sb.Append("  chatVideoType: ").Append(ChatVideoType).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  chatAccessAddress: ").Append(ChatAccessAddress).Append("\n");
            sb.Append("  chatAccessRestAddress: ").Append(ChatAccessRestAddress).Append("\n");
            sb.Append("  isTransparent: ").Append(IsTransparent).Append("\n");
            sb.Append("  defaultLanguage: ").Append(DefaultLanguage).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartSmartChatJobResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartSmartChatJobResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.RtcRoomInfo != input.RtcRoomInfo || (this.RtcRoomInfo != null && !this.RtcRoomInfo.Equals(input.RtcRoomInfo))) return false;
            if (this.ChatSubtitleConfig != input.ChatSubtitleConfig || (this.ChatSubtitleConfig != null && !this.ChatSubtitleConfig.Equals(input.ChatSubtitleConfig))) return false;
            if (this.VideoConfig != input.VideoConfig || (this.VideoConfig != null && !this.VideoConfig.Equals(input.VideoConfig))) return false;
            if (this.VoiceConfigList != input.VoiceConfigList || (this.VoiceConfigList != null && input.VoiceConfigList != null && !this.VoiceConfigList.SequenceEqual(input.VoiceConfigList))) return false;
            if (this.ChatVideoType != input.ChatVideoType) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.ChatAccessAddress != input.ChatAccessAddress || (this.ChatAccessAddress != null && !this.ChatAccessAddress.Equals(input.ChatAccessAddress))) return false;
            if (this.ChatAccessRestAddress != input.ChatAccessRestAddress || (this.ChatAccessRestAddress != null && !this.ChatAccessRestAddress.Equals(input.ChatAccessRestAddress))) return false;
            if (this.IsTransparent != input.IsTransparent || (this.IsTransparent != null && !this.IsTransparent.Equals(input.IsTransparent))) return false;
            if (this.DefaultLanguage != input.DefaultLanguage) return false;
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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.RtcRoomInfo != null) hashCode = hashCode * 59 + this.RtcRoomInfo.GetHashCode();
                if (this.ChatSubtitleConfig != null) hashCode = hashCode * 59 + this.ChatSubtitleConfig.GetHashCode();
                if (this.VideoConfig != null) hashCode = hashCode * 59 + this.VideoConfig.GetHashCode();
                if (this.VoiceConfigList != null) hashCode = hashCode * 59 + this.VoiceConfigList.GetHashCode();
                hashCode = hashCode * 59 + this.ChatVideoType.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.ChatAccessAddress != null) hashCode = hashCode * 59 + this.ChatAccessAddress.GetHashCode();
                if (this.ChatAccessRestAddress != null) hashCode = hashCode * 59 + this.ChatAccessRestAddress.GetHashCode();
                if (this.IsTransparent != null) hashCode = hashCode * 59 + this.IsTransparent.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultLanguage.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
