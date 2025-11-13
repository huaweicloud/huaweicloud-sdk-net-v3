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
    public class ShowLiveWarningInfoResponse : SdkResponse
    {

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
            sb.Append("class ShowLiveWarningInfoResponse {\n");
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
            return this.Equals(input as ShowLiveWarningInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLiveWarningInfoResponse input)
        {
            if (input == null) return false;
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
                if (this.LiveWarningInfo != null) hashCode = hashCode * 59 + this.LiveWarningInfo.GetHashCode();
                if (this.LimitDuration != null) hashCode = hashCode * 59 + this.LimitDuration.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
