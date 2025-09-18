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
    /// 
    /// </summary>
    public class SmartChatRoomBaseInfo 
    {
        /// <summary>
        /// 计费模式，默认值CONCURRENCY * CONCURRENCY：并发计费 * CLIENT：按接入端计费 * CLIENT_TOKENS: 按接入端计费（TOKENS）
        /// </summary>
        /// <value>计费模式，默认值CONCURRENCY * CONCURRENCY：并发计费 * CLIENT：按接入端计费 * CLIENT_TOKENS: 按接入端计费（TOKENS）</value>
        [JsonConverter(typeof(EnumClassConverter<BillingModeEnum>))]
        public class BillingModeEnum
        {
            /// <summary>
            /// Enum CONCURRENCY for value: CONCURRENCY
            /// </summary>
            public static readonly BillingModeEnum CONCURRENCY = new BillingModeEnum("CONCURRENCY");

            /// <summary>
            /// Enum CLIENT for value: CLIENT
            /// </summary>
            public static readonly BillingModeEnum CLIENT = new BillingModeEnum("CLIENT");

            /// <summary>
            /// Enum CLIENT_TOKENS for value: CLIENT_TOKENS
            /// </summary>
            public static readonly BillingModeEnum CLIENT_TOKENS = new BillingModeEnum("CLIENT_TOKENS");

            private static readonly Dictionary<string, BillingModeEnum> StaticFields =
            new Dictionary<string, BillingModeEnum>()
            {
                { "CONCURRENCY", CONCURRENCY },
                { "CLIENT", CLIENT },
                { "CLIENT_TOKENS", CLIENT_TOKENS },
            };

            private string _value;

            public BillingModeEnum()
            {

            }

            public BillingModeEnum(string value)
            {
                _value = value;
            }

            public static BillingModeEnum FromValue(string value)
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

                if (this.Equals(obj as BillingModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BillingModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BillingModeEnum a, BillingModeEnum b)
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

            public static bool operator !=(BillingModeEnum a, BillingModeEnum b)
            {
                return !(a == b);
            }
        }

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
        /// 智能交互对话ID
        /// </summary>
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 智能交互对话名称
        /// </summary>
        [JsonProperty("room_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomName { get; set; }

        /// <summary>
        /// 智能交互对话描述。
        /// </summary>
        [JsonProperty("room_description", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomDescription { get; set; }

        /// <summary>
        /// 机器人ID。
        /// </summary>
        [JsonProperty("robot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotId { get; set; }

        /// <summary>
        /// 对话封面图URL
        /// </summary>
        [JsonProperty("cover_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("model_infos", NullValueHandling = NullValueHandling.Ignore)]
        public ModelInfo ModelInfos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("voice_config", NullValueHandling = NullValueHandling.Ignore)]
        public VoiceConfig VoiceConfig { get; set; }

        /// <summary>
        /// 计费模式，默认值CONCURRENCY * CONCURRENCY：并发计费 * CLIENT：按接入端计费 * CLIENT_TOKENS: 按接入端计费（TOKENS）
        /// </summary>
        [JsonProperty("billing_mode", NullValueHandling = NullValueHandling.Ignore)]
        public BillingModeEnum BillingMode { get; set; }
        /// <summary>
        /// 是否允许使用未分配的并发数（端模式下不能复用），默认不使用。
        /// </summary>
        [JsonProperty("reuse_resource", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReuseResource { get; set; }

        /// <summary>
        /// **参数解释**： 并发路数。
        /// </summary>
        [JsonProperty("concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// **参数解释**： 允许接入终端端数量。
        /// </summary>
        [JsonProperty("client_nums", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientNums { get; set; }

        /// <summary>
        /// 语音配置参数列表。
        /// </summary>
        [JsonProperty("voice_config_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<VoiceConfigRsp> VoiceConfigList { get; set; }

        /// <summary>
        /// 默认语言，智能交互接口使用。默认值CN。 * CN：简体中文。 * EN：英语。 * ESP：西班牙语（仅海外站点支持） * por：葡萄牙语（仅海外站点支持） * Arabic：阿拉伯语（仅海外站点支持） * Thai：泰语（仅海外站点支持）
        /// </summary>
        [JsonProperty("default_language", NullValueHandling = NullValueHandling.Ignore)]
        public DefaultLanguageEnum DefaultLanguage { get; set; }
        /// <summary>
        /// 创建时间，格式遵循：RFC 3339 如“2021-01-10T08:43:17Z”。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间，格式遵循：RFC 3339 如“2021-01-10T08:43:17Z”。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// **参数解释**： 静默退出时长。
        /// </summary>
        [JsonProperty("exit_mute_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExitMuteThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartChatRoomBaseInfo {\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  roomName: ").Append(RoomName).Append("\n");
            sb.Append("  roomDescription: ").Append(RoomDescription).Append("\n");
            sb.Append("  robotId: ").Append(RobotId).Append("\n");
            sb.Append("  coverUrl: ").Append(CoverUrl).Append("\n");
            sb.Append("  modelInfos: ").Append(ModelInfos).Append("\n");
            sb.Append("  voiceConfig: ").Append(VoiceConfig).Append("\n");
            sb.Append("  billingMode: ").Append(BillingMode).Append("\n");
            sb.Append("  reuseResource: ").Append(ReuseResource).Append("\n");
            sb.Append("  concurrency: ").Append(Concurrency).Append("\n");
            sb.Append("  clientNums: ").Append(ClientNums).Append("\n");
            sb.Append("  voiceConfigList: ").Append(VoiceConfigList).Append("\n");
            sb.Append("  defaultLanguage: ").Append(DefaultLanguage).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  exitMuteThreshold: ").Append(ExitMuteThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartChatRoomBaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartChatRoomBaseInfo input)
        {
            if (input == null) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.RoomName != input.RoomName || (this.RoomName != null && !this.RoomName.Equals(input.RoomName))) return false;
            if (this.RoomDescription != input.RoomDescription || (this.RoomDescription != null && !this.RoomDescription.Equals(input.RoomDescription))) return false;
            if (this.RobotId != input.RobotId || (this.RobotId != null && !this.RobotId.Equals(input.RobotId))) return false;
            if (this.CoverUrl != input.CoverUrl || (this.CoverUrl != null && !this.CoverUrl.Equals(input.CoverUrl))) return false;
            if (this.ModelInfos != input.ModelInfos || (this.ModelInfos != null && !this.ModelInfos.Equals(input.ModelInfos))) return false;
            if (this.VoiceConfig != input.VoiceConfig || (this.VoiceConfig != null && !this.VoiceConfig.Equals(input.VoiceConfig))) return false;
            if (this.BillingMode != input.BillingMode) return false;
            if (this.ReuseResource != input.ReuseResource || (this.ReuseResource != null && !this.ReuseResource.Equals(input.ReuseResource))) return false;
            if (this.Concurrency != input.Concurrency || (this.Concurrency != null && !this.Concurrency.Equals(input.Concurrency))) return false;
            if (this.ClientNums != input.ClientNums || (this.ClientNums != null && !this.ClientNums.Equals(input.ClientNums))) return false;
            if (this.VoiceConfigList != input.VoiceConfigList || (this.VoiceConfigList != null && input.VoiceConfigList != null && !this.VoiceConfigList.SequenceEqual(input.VoiceConfigList))) return false;
            if (this.DefaultLanguage != input.DefaultLanguage) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.ExitMuteThreshold != input.ExitMuteThreshold || (this.ExitMuteThreshold != null && !this.ExitMuteThreshold.Equals(input.ExitMuteThreshold))) return false;

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
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.RoomName != null) hashCode = hashCode * 59 + this.RoomName.GetHashCode();
                if (this.RoomDescription != null) hashCode = hashCode * 59 + this.RoomDescription.GetHashCode();
                if (this.RobotId != null) hashCode = hashCode * 59 + this.RobotId.GetHashCode();
                if (this.CoverUrl != null) hashCode = hashCode * 59 + this.CoverUrl.GetHashCode();
                if (this.ModelInfos != null) hashCode = hashCode * 59 + this.ModelInfos.GetHashCode();
                if (this.VoiceConfig != null) hashCode = hashCode * 59 + this.VoiceConfig.GetHashCode();
                hashCode = hashCode * 59 + this.BillingMode.GetHashCode();
                if (this.ReuseResource != null) hashCode = hashCode * 59 + this.ReuseResource.GetHashCode();
                if (this.Concurrency != null) hashCode = hashCode * 59 + this.Concurrency.GetHashCode();
                if (this.ClientNums != null) hashCode = hashCode * 59 + this.ClientNums.GetHashCode();
                if (this.VoiceConfigList != null) hashCode = hashCode * 59 + this.VoiceConfigList.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultLanguage.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ExitMuteThreshold != null) hashCode = hashCode * 59 + this.ExitMuteThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
