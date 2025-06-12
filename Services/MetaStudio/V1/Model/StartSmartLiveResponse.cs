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
    public class StartSmartLiveResponse : SdkResponse
    {

        /// <summary>
        /// 直播任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rtc_room_info", NullValueHandling = NullValueHandling.Ignore)]
        public RTCRoomInfoList RtcRoomInfo { get; set; }

        /// <summary>
        /// 直播事件上报地址。用户将自行获取的直播间事件上报到此地址，用于触发智能互动，自动回复话术。
        /// </summary>
        [JsonProperty("live_event_report_url", NullValueHandling = NullValueHandling.Ignore)]
        public string LiveEventReportUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("live_event_callback_config", NullValueHandling = NullValueHandling.Ignore)]
        public LiveEventCallBackConfig LiveEventCallbackConfig { get; set; }

        /// <summary>
        /// 开播风险告警列表。
        /// </summary>
        [JsonProperty("live_warning_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<LiveWarningItem> LiveWarningInfo { get; set; }

        /// <summary>
        /// **参数解释**： 配置的最大直播时长。单位小时。 0 为不限制。 **约束限制**： 停止直播逻辑配置为立即停止则直播停止误差在5分钟之内。其他逻辑则加上处理时长。 **默认取值**： 不设置则表示不限时。
        /// </summary>
        [JsonProperty("limit_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? LimitDuration { get; set; }

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
            sb.Append("class StartSmartLiveResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  rtcRoomInfo: ").Append(RtcRoomInfo).Append("\n");
            sb.Append("  liveEventReportUrl: ").Append(LiveEventReportUrl).Append("\n");
            sb.Append("  liveEventCallbackConfig: ").Append(LiveEventCallbackConfig).Append("\n");
            sb.Append("  liveWarningInfo: ").Append(LiveWarningInfo).Append("\n");
            sb.Append("  limitDuration: ").Append(LimitDuration).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartSmartLiveResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartSmartLiveResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.RtcRoomInfo != input.RtcRoomInfo || (this.RtcRoomInfo != null && !this.RtcRoomInfo.Equals(input.RtcRoomInfo))) return false;
            if (this.LiveEventReportUrl != input.LiveEventReportUrl || (this.LiveEventReportUrl != null && !this.LiveEventReportUrl.Equals(input.LiveEventReportUrl))) return false;
            if (this.LiveEventCallbackConfig != input.LiveEventCallbackConfig || (this.LiveEventCallbackConfig != null && !this.LiveEventCallbackConfig.Equals(input.LiveEventCallbackConfig))) return false;
            if (this.LiveWarningInfo != input.LiveWarningInfo || (this.LiveWarningInfo != null && input.LiveWarningInfo != null && !this.LiveWarningInfo.SequenceEqual(input.LiveWarningInfo))) return false;
            if (this.LimitDuration != input.LimitDuration || (this.LimitDuration != null && !this.LimitDuration.Equals(input.LimitDuration))) return false;
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
                if (this.RtcRoomInfo != null) hashCode = hashCode * 59 + this.RtcRoomInfo.GetHashCode();
                if (this.LiveEventReportUrl != null) hashCode = hashCode * 59 + this.LiveEventReportUrl.GetHashCode();
                if (this.LiveEventCallbackConfig != null) hashCode = hashCode * 59 + this.LiveEventCallbackConfig.GetHashCode();
                if (this.LiveWarningInfo != null) hashCode = hashCode * 59 + this.LiveWarningInfo.GetHashCode();
                if (this.LimitDuration != null) hashCode = hashCode * 59 + this.LimitDuration.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
