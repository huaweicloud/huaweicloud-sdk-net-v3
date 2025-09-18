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
    /// 数字人直播任务请求。
    /// </summary>
    public class StartSmartLiveReq 
    {
        /// <summary>
        /// **参数解释**： 横竖屏类型。 **约束限制**： 用户无需填写，通过video_config中分辨率判断 **取值范围**： * LANDSCAPE：横屏。 * VERTICAL： 竖屏。
        /// </summary>
        /// <value>**参数解释**： 横竖屏类型。 **约束限制**： 用户无需填写，通过video_config中分辨率判断 **取值范围**： * LANDSCAPE：横屏。 * VERTICAL： 竖屏。</value>
        [JsonConverter(typeof(EnumClassConverter<ViewModeEnum>))]
        public class ViewModeEnum
        {
            /// <summary>
            /// Enum LANDSCAPE for value: LANDSCAPE
            /// </summary>
            public static readonly ViewModeEnum LANDSCAPE = new ViewModeEnum("LANDSCAPE");

            /// <summary>
            /// Enum VERTICAL for value: VERTICAL
            /// </summary>
            public static readonly ViewModeEnum VERTICAL = new ViewModeEnum("VERTICAL");

            private static readonly Dictionary<string, ViewModeEnum> StaticFields =
            new Dictionary<string, ViewModeEnum>()
            {
                { "LANDSCAPE", LANDSCAPE },
                { "VERTICAL", VERTICAL },
            };

            private string _value;

            public ViewModeEnum()
            {

            }

            public ViewModeEnum(string value)
            {
                _value = value;
            }

            public static ViewModeEnum FromValue(string value)
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

                if (this.Equals(obj as ViewModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ViewModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ViewModeEnum a, ViewModeEnum b)
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

            public static bool operator !=(ViewModeEnum a, ViewModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_config", NullValueHandling = NullValueHandling.Ignore)]
        public VideoConfig VideoConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("play_policy", NullValueHandling = NullValueHandling.Ignore)]
        public PlayPolicy PlayPolicy { get; set; }

        /// <summary>
        /// **参数解释**： RTMP视频推流第三方直播平台地址。 &gt; 直播过程中刷新地址，需要调用COMMAND命令REFRESH_OUTPUT_URL。  **约束限制**： 不涉及 **取值范围**： 当前仅支持一条RTMP出流地址。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("output_urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OutputUrls { get; set; }

        /// <summary>
        /// **参数解释**： RTMP视频推流第三方直播平台流密钥，与推流地址对应。 &gt; 直播过程中刷新地址，需要调用COMMAND命令REFRESH_OUTPUT_URL。  **约束限制**： 不涉及 **取值范围**： 当前仅支持一条RTMP出流地址。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("stream_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> StreamKeys { get; set; }

        /// <summary>
        /// **参数解释**： 互动回调URL，含鉴权信息。 互动规则trigger.reply_mode配置为CALLBACK时填写 **约束限制**： 不涉及 **取值范围**： 字符长度0-2048位 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("interaction_callback_url", NullValueHandling = NullValueHandling.Ignore)]
        public string InteractionCallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("live_event_callback_config", NullValueHandling = NullValueHandling.Ignore)]
        public LiveEventCallBackConfig LiveEventCallbackConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rtc_callback_config", NullValueHandling = NullValueHandling.Ignore)]
        public RTCLiveEventCallBackConfig RtcCallbackConfig { get; set; }

        /// <summary>
        /// **参数解释**： 横竖屏类型。 **约束限制**： 用户无需填写，通过video_config中分辨率判断 **取值范围**： * LANDSCAPE：横屏。 * VERTICAL： 竖屏。
        /// </summary>
        [JsonProperty("view_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ViewModeEnum ViewMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("co_streamer_config", NullValueHandling = NullValueHandling.Ignore)]
        public CoStreamerConfig CoStreamerConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_run_config", NullValueHandling = NullValueHandling.Ignore)]
        public LiveJobRunConfig JobRunConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartSmartLiveReq {\n");
            sb.Append("  videoConfig: ").Append(VideoConfig).Append("\n");
            sb.Append("  playPolicy: ").Append(PlayPolicy).Append("\n");
            sb.Append("  outputUrls: ").Append(OutputUrls).Append("\n");
            sb.Append("  streamKeys: ").Append(StreamKeys).Append("\n");
            sb.Append("  interactionCallbackUrl: ").Append(InteractionCallbackUrl).Append("\n");
            sb.Append("  liveEventCallbackConfig: ").Append(LiveEventCallbackConfig).Append("\n");
            sb.Append("  rtcCallbackConfig: ").Append(RtcCallbackConfig).Append("\n");
            sb.Append("  viewMode: ").Append(ViewMode).Append("\n");
            sb.Append("  coStreamerConfig: ").Append(CoStreamerConfig).Append("\n");
            sb.Append("  jobRunConfig: ").Append(JobRunConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartSmartLiveReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartSmartLiveReq input)
        {
            if (input == null) return false;
            if (this.VideoConfig != input.VideoConfig || (this.VideoConfig != null && !this.VideoConfig.Equals(input.VideoConfig))) return false;
            if (this.PlayPolicy != input.PlayPolicy || (this.PlayPolicy != null && !this.PlayPolicy.Equals(input.PlayPolicy))) return false;
            if (this.OutputUrls != input.OutputUrls || (this.OutputUrls != null && input.OutputUrls != null && !this.OutputUrls.SequenceEqual(input.OutputUrls))) return false;
            if (this.StreamKeys != input.StreamKeys || (this.StreamKeys != null && input.StreamKeys != null && !this.StreamKeys.SequenceEqual(input.StreamKeys))) return false;
            if (this.InteractionCallbackUrl != input.InteractionCallbackUrl || (this.InteractionCallbackUrl != null && !this.InteractionCallbackUrl.Equals(input.InteractionCallbackUrl))) return false;
            if (this.LiveEventCallbackConfig != input.LiveEventCallbackConfig || (this.LiveEventCallbackConfig != null && !this.LiveEventCallbackConfig.Equals(input.LiveEventCallbackConfig))) return false;
            if (this.RtcCallbackConfig != input.RtcCallbackConfig || (this.RtcCallbackConfig != null && !this.RtcCallbackConfig.Equals(input.RtcCallbackConfig))) return false;
            if (this.ViewMode != input.ViewMode) return false;
            if (this.CoStreamerConfig != input.CoStreamerConfig || (this.CoStreamerConfig != null && !this.CoStreamerConfig.Equals(input.CoStreamerConfig))) return false;
            if (this.JobRunConfig != input.JobRunConfig || (this.JobRunConfig != null && !this.JobRunConfig.Equals(input.JobRunConfig))) return false;

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
                if (this.VideoConfig != null) hashCode = hashCode * 59 + this.VideoConfig.GetHashCode();
                if (this.PlayPolicy != null) hashCode = hashCode * 59 + this.PlayPolicy.GetHashCode();
                if (this.OutputUrls != null) hashCode = hashCode * 59 + this.OutputUrls.GetHashCode();
                if (this.StreamKeys != null) hashCode = hashCode * 59 + this.StreamKeys.GetHashCode();
                if (this.InteractionCallbackUrl != null) hashCode = hashCode * 59 + this.InteractionCallbackUrl.GetHashCode();
                if (this.LiveEventCallbackConfig != null) hashCode = hashCode * 59 + this.LiveEventCallbackConfig.GetHashCode();
                if (this.RtcCallbackConfig != null) hashCode = hashCode * 59 + this.RtcCallbackConfig.GetHashCode();
                hashCode = hashCode * 59 + this.ViewMode.GetHashCode();
                if (this.CoStreamerConfig != null) hashCode = hashCode * 59 + this.CoStreamerConfig.GetHashCode();
                if (this.JobRunConfig != null) hashCode = hashCode * 59 + this.JobRunConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
