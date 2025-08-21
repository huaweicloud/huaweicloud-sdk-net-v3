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
    public class AttackDetailVO 
    {

        /// <summary>
        /// **参数解释**： 应用数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("app_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? AppCount { get; set; }

        /// <summary>
        /// **参数解释**： 攻击规则数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("attack_rule_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? AttackRuleCount { get; set; }

        /// <summary>
        /// **参数解释**： 攻击类型数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("attack_type_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? AttackTypeCount { get; set; }

        /// <summary>
        /// **参数解释**： 攻击次数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        /// <summary>
        /// **参数解释**： 目的IP数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_ip_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? DstIpCount { get; set; }

        /// <summary>
        /// **参数解释**： 攻击端口数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_port_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? DstPortCount { get; set; }

        /// <summary>
        /// **参数解释**： 结束时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 攻击事件明细 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("records", NullValueHandling = NullValueHandling.Ignore)]
        public List<AttackLog> Records { get; set; }

        /// <summary>
        /// **参数解释**： 源IP数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_ip_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? SrcIpCount { get; set; }

        /// <summary>
        /// **参数解释**： 开始时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// **参数解释**： 总数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttackDetailVO {\n");
            sb.Append("  appCount: ").Append(AppCount).Append("\n");
            sb.Append("  attackRuleCount: ").Append(AttackRuleCount).Append("\n");
            sb.Append("  attackTypeCount: ").Append(AttackTypeCount).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  dstIpCount: ").Append(DstIpCount).Append("\n");
            sb.Append("  dstPortCount: ").Append(DstPortCount).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  records: ").Append(Records).Append("\n");
            sb.Append("  srcIpCount: ").Append(SrcIpCount).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttackDetailVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttackDetailVO input)
        {
            if (input == null) return false;
            if (this.AppCount != input.AppCount || (this.AppCount != null && !this.AppCount.Equals(input.AppCount))) return false;
            if (this.AttackRuleCount != input.AttackRuleCount || (this.AttackRuleCount != null && !this.AttackRuleCount.Equals(input.AttackRuleCount))) return false;
            if (this.AttackTypeCount != input.AttackTypeCount || (this.AttackTypeCount != null && !this.AttackTypeCount.Equals(input.AttackTypeCount))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.DstIpCount != input.DstIpCount || (this.DstIpCount != null && !this.DstIpCount.Equals(input.DstIpCount))) return false;
            if (this.DstPortCount != input.DstPortCount || (this.DstPortCount != null && !this.DstPortCount.Equals(input.DstPortCount))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Records != input.Records || (this.Records != null && input.Records != null && !this.Records.SequenceEqual(input.Records))) return false;
            if (this.SrcIpCount != input.SrcIpCount || (this.SrcIpCount != null && !this.SrcIpCount.Equals(input.SrcIpCount))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.AppCount != null) hashCode = hashCode * 59 + this.AppCount.GetHashCode();
                if (this.AttackRuleCount != null) hashCode = hashCode * 59 + this.AttackRuleCount.GetHashCode();
                if (this.AttackTypeCount != null) hashCode = hashCode * 59 + this.AttackTypeCount.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.DstIpCount != null) hashCode = hashCode * 59 + this.DstIpCount.GetHashCode();
                if (this.DstPortCount != null) hashCode = hashCode * 59 + this.DstPortCount.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Records != null) hashCode = hashCode * 59 + this.Records.GetHashCode();
                if (this.SrcIpCount != null) hashCode = hashCode * 59 + this.SrcIpCount.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
