using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowReplayDelayStatusResponse : SdkResponse
    {

        /// <summary>
        /// 当前配置的延迟时间，单位ms
        /// </summary>
        [JsonProperty("cur_delay_time_mills", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurDelayTimeMills { get; set; }

        /// <summary>
        /// 延迟时间参数取值范围
        /// </summary>
        [JsonProperty("delay_time_value_range", NullValueHandling = NullValueHandling.Ignore)]
        public string DelayTimeValueRange { get; set; }

        /// <summary>
        /// 真实延迟时间，单位ms
        /// </summary>
        [JsonProperty("real_delay_time_mills", NullValueHandling = NullValueHandling.Ignore)]
        public int? RealDelayTimeMills { get; set; }

        /// <summary>
        /// 当前日志回放状态。true表示回放暂停，false表示回放正常
        /// </summary>
        [JsonProperty("cur_log_replay_paused", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CurLogReplayPaused { get; set; }

        /// <summary>
        /// 最新接收的日志
        /// </summary>
        [JsonProperty("latest_receive_log", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestReceiveLog { get; set; }

        /// <summary>
        /// 最新回放的日志位点
        /// </summary>
        [JsonProperty("latest_replay_log", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestReplayLog { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowReplayDelayStatusResponse {\n");
            sb.Append("  curDelayTimeMills: ").Append(CurDelayTimeMills).Append("\n");
            sb.Append("  delayTimeValueRange: ").Append(DelayTimeValueRange).Append("\n");
            sb.Append("  realDelayTimeMills: ").Append(RealDelayTimeMills).Append("\n");
            sb.Append("  curLogReplayPaused: ").Append(CurLogReplayPaused).Append("\n");
            sb.Append("  latestReceiveLog: ").Append(LatestReceiveLog).Append("\n");
            sb.Append("  latestReplayLog: ").Append(LatestReplayLog).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowReplayDelayStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowReplayDelayStatusResponse input)
        {
            if (input == null) return false;
            if (this.CurDelayTimeMills != input.CurDelayTimeMills || (this.CurDelayTimeMills != null && !this.CurDelayTimeMills.Equals(input.CurDelayTimeMills))) return false;
            if (this.DelayTimeValueRange != input.DelayTimeValueRange || (this.DelayTimeValueRange != null && !this.DelayTimeValueRange.Equals(input.DelayTimeValueRange))) return false;
            if (this.RealDelayTimeMills != input.RealDelayTimeMills || (this.RealDelayTimeMills != null && !this.RealDelayTimeMills.Equals(input.RealDelayTimeMills))) return false;
            if (this.CurLogReplayPaused != input.CurLogReplayPaused || (this.CurLogReplayPaused != null && !this.CurLogReplayPaused.Equals(input.CurLogReplayPaused))) return false;
            if (this.LatestReceiveLog != input.LatestReceiveLog || (this.LatestReceiveLog != null && !this.LatestReceiveLog.Equals(input.LatestReceiveLog))) return false;
            if (this.LatestReplayLog != input.LatestReplayLog || (this.LatestReplayLog != null && !this.LatestReplayLog.Equals(input.LatestReplayLog))) return false;

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
                if (this.CurDelayTimeMills != null) hashCode = hashCode * 59 + this.CurDelayTimeMills.GetHashCode();
                if (this.DelayTimeValueRange != null) hashCode = hashCode * 59 + this.DelayTimeValueRange.GetHashCode();
                if (this.RealDelayTimeMills != null) hashCode = hashCode * 59 + this.RealDelayTimeMills.GetHashCode();
                if (this.CurLogReplayPaused != null) hashCode = hashCode * 59 + this.CurLogReplayPaused.GetHashCode();
                if (this.LatestReceiveLog != null) hashCode = hashCode * 59 + this.LatestReceiveLog.GetHashCode();
                if (this.LatestReplayLog != null) hashCode = hashCode * 59 + this.LatestReplayLog.GetHashCode();
                return hashCode;
            }
        }
    }
}
