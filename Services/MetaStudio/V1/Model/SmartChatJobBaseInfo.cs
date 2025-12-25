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
    /// 数字人智能交互对话任务信息。
    /// </summary>
    public class SmartChatJobBaseInfo 
    {
        /// <summary>
        /// 数字人智能交互对话任务的状态。 * WAITING: 等待 * PROCESSING: 处理中 * SUCCEED: 成功 * FAILED: 失败 * DELETING: 删除中
        /// </summary>
        /// <value>数字人智能交互对话任务的状态。 * WAITING: 等待 * PROCESSING: 处理中 * SUCCEED: 成功 * FAILED: 失败 * DELETING: 删除中</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            public static readonly StateEnum WAITING = new StateEnum("WAITING");

            /// <summary>
            /// Enum PROCESSING for value: PROCESSING
            /// </summary>
            public static readonly StateEnum PROCESSING = new StateEnum("PROCESSING");

            /// <summary>
            /// Enum SUCCEED for value: SUCCEED
            /// </summary>
            public static readonly StateEnum SUCCEED = new StateEnum("SUCCEED");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly StateEnum FAILED = new StateEnum("FAILED");

            /// <summary>
            /// Enum CANCELED for value: CANCELED
            /// </summary>
            public static readonly StateEnum CANCELED = new StateEnum("CANCELED");

            /// <summary>
            /// Enum HEARTBEAT for value: HEARTBEAT
            /// </summary>
            public static readonly StateEnum HEARTBEAT = new StateEnum("HEARTBEAT");

            /// <summary>
            /// Enum IDLE for value: IDLE
            /// </summary>
            public static readonly StateEnum IDLE = new StateEnum("IDLE");

            /// <summary>
            /// Enum DELETING for value: DELETING
            /// </summary>
            public static readonly StateEnum DELETING = new StateEnum("DELETING");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "WAITING", WAITING },
                { "PROCESSING", PROCESSING },
                { "SUCCEED", SUCCEED },
                { "FAILED", FAILED },
                { "CANCELED", CANCELED },
                { "HEARTBEAT", HEARTBEAT },
                { "IDLE", IDLE },
                { "DELETING", DELETING },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
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
        /// 对话结束原因 * NORMAL：正常结束 * MUTE_TIMEOUT：静音超时
        /// </summary>
        /// <value>对话结束原因 * NORMAL：正常结束 * MUTE_TIMEOUT：静音超时</value>
        [JsonConverter(typeof(EnumClassConverter<JobFinishReasonEnum>))]
        public class JobFinishReasonEnum
        {
            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            public static readonly JobFinishReasonEnum NORMAL = new JobFinishReasonEnum("NORMAL");

            /// <summary>
            /// Enum MUTE_TIMEOUT for value: MUTE_TIMEOUT
            /// </summary>
            public static readonly JobFinishReasonEnum MUTE_TIMEOUT = new JobFinishReasonEnum("MUTE_TIMEOUT");

            private static readonly Dictionary<string, JobFinishReasonEnum> StaticFields =
            new Dictionary<string, JobFinishReasonEnum>()
            {
                { "NORMAL", NORMAL },
                { "MUTE_TIMEOUT", MUTE_TIMEOUT },
            };

            private string _value;

            public JobFinishReasonEnum()
            {

            }

            public JobFinishReasonEnum(string value)
            {
                _value = value;
            }

            public static JobFinishReasonEnum FromValue(string value)
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

                if (this.Equals(obj as JobFinishReasonEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(JobFinishReasonEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(JobFinishReasonEnum a, JobFinishReasonEnum b)
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

            public static bool operator !=(JobFinishReasonEnum a, JobFinishReasonEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数字人智能交互对话任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 数字人智能交互对话任务的状态。 * WAITING: 等待 * PROCESSING: 处理中 * SUCCEED: 成功 * FAILED: 失败 * DELETING: 删除中
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 数字人智能交互对话时长，单位秒。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? Duration { get; set; }

        /// <summary>
        /// 数字人智能交互对话任务开始时间。格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 数字人智能交互对话任务结束时间。格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_info", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorResponse ErrorInfo { get; set; }

        /// <summary>
        /// 数字人智能交互对话任务创建时间。格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 数字人智能交互对话任务最后更新时间。格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("lastupdate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastupdateTime { get; set; }

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
        /// clientId
        /// </summary>
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// 是否是资源池模式
        /// </summary>
        [JsonProperty("is_pool_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPoolMode { get; set; }

        /// <summary>
        /// 对话结束原因 * NORMAL：正常结束 * MUTE_TIMEOUT：静音超时
        /// </summary>
        [JsonProperty("job_finish_reason", NullValueHandling = NullValueHandling.Ignore)]
        public JobFinishReasonEnum JobFinishReason { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartChatJobBaseInfo {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  errorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastupdateTime: ").Append(LastupdateTime).Append("\n");
            sb.Append("  chatSubtitleConfig: ").Append(ChatSubtitleConfig).Append("\n");
            sb.Append("  videoConfig: ").Append(VideoConfig).Append("\n");
            sb.Append("  voiceConfigList: ").Append(VoiceConfigList).Append("\n");
            sb.Append("  chatVideoType: ").Append(ChatVideoType).Append("\n");
            sb.Append("  isTransparent: ").Append(IsTransparent).Append("\n");
            sb.Append("  defaultLanguage: ").Append(DefaultLanguage).Append("\n");
            sb.Append("  clientId: ").Append(ClientId).Append("\n");
            sb.Append("  isPoolMode: ").Append(IsPoolMode).Append("\n");
            sb.Append("  jobFinishReason: ").Append(JobFinishReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartChatJobBaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartChatJobBaseInfo input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.State != input.State) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ErrorInfo != input.ErrorInfo || (this.ErrorInfo != null && !this.ErrorInfo.Equals(input.ErrorInfo))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.LastupdateTime != input.LastupdateTime || (this.LastupdateTime != null && !this.LastupdateTime.Equals(input.LastupdateTime))) return false;
            if (this.ChatSubtitleConfig != input.ChatSubtitleConfig || (this.ChatSubtitleConfig != null && !this.ChatSubtitleConfig.Equals(input.ChatSubtitleConfig))) return false;
            if (this.VideoConfig != input.VideoConfig || (this.VideoConfig != null && !this.VideoConfig.Equals(input.VideoConfig))) return false;
            if (this.VoiceConfigList != input.VoiceConfigList || (this.VoiceConfigList != null && input.VoiceConfigList != null && !this.VoiceConfigList.SequenceEqual(input.VoiceConfigList))) return false;
            if (this.ChatVideoType != input.ChatVideoType) return false;
            if (this.IsTransparent != input.IsTransparent || (this.IsTransparent != null && !this.IsTransparent.Equals(input.IsTransparent))) return false;
            if (this.DefaultLanguage != input.DefaultLanguage) return false;
            if (this.ClientId != input.ClientId || (this.ClientId != null && !this.ClientId.Equals(input.ClientId))) return false;
            if (this.IsPoolMode != input.IsPoolMode || (this.IsPoolMode != null && !this.IsPoolMode.Equals(input.IsPoolMode))) return false;
            if (this.JobFinishReason != input.JobFinishReason) return false;

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
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ErrorInfo != null) hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastupdateTime != null) hashCode = hashCode * 59 + this.LastupdateTime.GetHashCode();
                if (this.ChatSubtitleConfig != null) hashCode = hashCode * 59 + this.ChatSubtitleConfig.GetHashCode();
                if (this.VideoConfig != null) hashCode = hashCode * 59 + this.VideoConfig.GetHashCode();
                if (this.VoiceConfigList != null) hashCode = hashCode * 59 + this.VoiceConfigList.GetHashCode();
                hashCode = hashCode * 59 + this.ChatVideoType.GetHashCode();
                if (this.IsTransparent != null) hashCode = hashCode * 59 + this.IsTransparent.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultLanguage.GetHashCode();
                if (this.ClientId != null) hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.IsPoolMode != null) hashCode = hashCode * 59 + this.IsPoolMode.GetHashCode();
                hashCode = hashCode * 59 + this.JobFinishReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
