using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 会议已购资源使用数据的单个时间点数据。
    /// </summary>
    public class StatisticResourceDataItem 
    {

        /// <summary>
        /// 日期/月份。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// VMR方数。 category &#x3D; used_vmr_info时有效。
        /// </summary>
        [JsonProperty("vmrParties", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrParties { get; set; }

        /// <summary>
        /// VMR并发使用数。 category &#x3D; used_vmr_info时有效。
        /// </summary>
        [JsonProperty("maxConcurrencyVmrCount", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxConcurrencyVmrCount { get; set; }

        /// <summary>
        /// 直播端口并发使用数。 category &#x3D; used_live_info时有效。
        /// </summary>
        [JsonProperty("livePortUsedCount", NullValueHandling = NullValueHandling.Ignore)]
        public string LivePortUsedCount { get; set; }

        /// <summary>
        /// 录播使用空间(G)。 category &#x3D; used_record_info时有效。
        /// </summary>
        [JsonProperty("recordUsedSize", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordUsedSize { get; set; }

        /// <summary>
        /// PSTN外呼时长(分钟)。 category &#x3D; used_pstn_info时有效。
        /// </summary>
        [JsonProperty("pstnUsedDuration", NullValueHandling = NullValueHandling.Ignore)]
        public string PstnUsedDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatisticResourceDataItem {\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  vmrParties: ").Append(VmrParties).Append("\n");
            sb.Append("  maxConcurrencyVmrCount: ").Append(MaxConcurrencyVmrCount).Append("\n");
            sb.Append("  livePortUsedCount: ").Append(LivePortUsedCount).Append("\n");
            sb.Append("  recordUsedSize: ").Append(RecordUsedSize).Append("\n");
            sb.Append("  pstnUsedDuration: ").Append(PstnUsedDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StatisticResourceDataItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StatisticResourceDataItem input)
        {
            if (input == null) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.VmrParties != input.VmrParties || (this.VmrParties != null && !this.VmrParties.Equals(input.VmrParties))) return false;
            if (this.MaxConcurrencyVmrCount != input.MaxConcurrencyVmrCount || (this.MaxConcurrencyVmrCount != null && !this.MaxConcurrencyVmrCount.Equals(input.MaxConcurrencyVmrCount))) return false;
            if (this.LivePortUsedCount != input.LivePortUsedCount || (this.LivePortUsedCount != null && !this.LivePortUsedCount.Equals(input.LivePortUsedCount))) return false;
            if (this.RecordUsedSize != input.RecordUsedSize || (this.RecordUsedSize != null && !this.RecordUsedSize.Equals(input.RecordUsedSize))) return false;
            if (this.PstnUsedDuration != input.PstnUsedDuration || (this.PstnUsedDuration != null && !this.PstnUsedDuration.Equals(input.PstnUsedDuration))) return false;

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
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.VmrParties != null) hashCode = hashCode * 59 + this.VmrParties.GetHashCode();
                if (this.MaxConcurrencyVmrCount != null) hashCode = hashCode * 59 + this.MaxConcurrencyVmrCount.GetHashCode();
                if (this.LivePortUsedCount != null) hashCode = hashCode * 59 + this.LivePortUsedCount.GetHashCode();
                if (this.RecordUsedSize != null) hashCode = hashCode * 59 + this.RecordUsedSize.GetHashCode();
                if (this.PstnUsedDuration != null) hashCode = hashCode * 59 + this.PstnUsedDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
