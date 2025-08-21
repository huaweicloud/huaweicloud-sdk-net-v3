using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AccessDetailVO 
    {

        /// <summary>
        /// **参数解释**： 目的IP数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_ip_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? DstIpCount { get; set; }

        /// <summary>
        /// **参数解释**： 目的端口数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_port_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? DstPortCount { get; set; }

        /// <summary>
        /// **参数解释**： 命中次数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("hit_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? HitCount { get; set; }

        /// <summary>
        /// **参数解释**： 协议数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("protocol_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProtocolCount { get; set; }

        /// <summary>
        /// **参数解释**： 结束时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("recent_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RecentEndTime { get; set; }

        /// <summary>
        /// **参数解释**： 开始时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("recent_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RecentStartTime { get; set; }

        /// <summary>
        /// **参数解释**： 记录数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("record_total", NullValueHandling = NullValueHandling.Ignore)]
        public long? RecordTotal { get; set; }

        /// <summary>
        /// **参数解释**： 命中详情 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("records", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessLogInfo> Records { get; set; }

        /// <summary>
        /// **参数解释**： 命中规则数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("rule_hit_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? RuleHitCount { get; set; }

        /// <summary>
        /// **参数解释**： 源IP数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_ip_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? SrcIpCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessDetailVO {\n");
            sb.Append("  dstIpCount: ").Append(DstIpCount).Append("\n");
            sb.Append("  dstPortCount: ").Append(DstPortCount).Append("\n");
            sb.Append("  hitCount: ").Append(HitCount).Append("\n");
            sb.Append("  protocolCount: ").Append(ProtocolCount).Append("\n");
            sb.Append("  recentEndTime: ").Append(RecentEndTime).Append("\n");
            sb.Append("  recentStartTime: ").Append(RecentStartTime).Append("\n");
            sb.Append("  recordTotal: ").Append(RecordTotal).Append("\n");
            sb.Append("  records: ").Append(Records).Append("\n");
            sb.Append("  ruleHitCount: ").Append(RuleHitCount).Append("\n");
            sb.Append("  srcIpCount: ").Append(SrcIpCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessDetailVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessDetailVO input)
        {
            if (input == null) return false;
            if (this.DstIpCount != input.DstIpCount || (this.DstIpCount != null && !this.DstIpCount.Equals(input.DstIpCount))) return false;
            if (this.DstPortCount != input.DstPortCount || (this.DstPortCount != null && !this.DstPortCount.Equals(input.DstPortCount))) return false;
            if (this.HitCount != input.HitCount || (this.HitCount != null && !this.HitCount.Equals(input.HitCount))) return false;
            if (this.ProtocolCount != input.ProtocolCount || (this.ProtocolCount != null && !this.ProtocolCount.Equals(input.ProtocolCount))) return false;
            if (this.RecentEndTime != input.RecentEndTime || (this.RecentEndTime != null && !this.RecentEndTime.Equals(input.RecentEndTime))) return false;
            if (this.RecentStartTime != input.RecentStartTime || (this.RecentStartTime != null && !this.RecentStartTime.Equals(input.RecentStartTime))) return false;
            if (this.RecordTotal != input.RecordTotal || (this.RecordTotal != null && !this.RecordTotal.Equals(input.RecordTotal))) return false;
            if (this.Records != input.Records || (this.Records != null && input.Records != null && !this.Records.SequenceEqual(input.Records))) return false;
            if (this.RuleHitCount != input.RuleHitCount || (this.RuleHitCount != null && !this.RuleHitCount.Equals(input.RuleHitCount))) return false;
            if (this.SrcIpCount != input.SrcIpCount || (this.SrcIpCount != null && !this.SrcIpCount.Equals(input.SrcIpCount))) return false;

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
                if (this.DstIpCount != null) hashCode = hashCode * 59 + this.DstIpCount.GetHashCode();
                if (this.DstPortCount != null) hashCode = hashCode * 59 + this.DstPortCount.GetHashCode();
                if (this.HitCount != null) hashCode = hashCode * 59 + this.HitCount.GetHashCode();
                if (this.ProtocolCount != null) hashCode = hashCode * 59 + this.ProtocolCount.GetHashCode();
                if (this.RecentEndTime != null) hashCode = hashCode * 59 + this.RecentEndTime.GetHashCode();
                if (this.RecentStartTime != null) hashCode = hashCode * 59 + this.RecentStartTime.GetHashCode();
                if (this.RecordTotal != null) hashCode = hashCode * 59 + this.RecordTotal.GetHashCode();
                if (this.Records != null) hashCode = hashCode * 59 + this.Records.GetHashCode();
                if (this.RuleHitCount != null) hashCode = hashCode * 59 + this.RuleHitCount.GetHashCode();
                if (this.SrcIpCount != null) hashCode = hashCode * 59 + this.SrcIpCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
