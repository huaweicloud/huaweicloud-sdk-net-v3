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
    public class AttackTopRespBody 
    {

        /// <summary>
        /// **参数解释**： TOP攻击规则 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("attack_rule", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopInfo> AttackRule { get; set; }

        /// <summary>
        /// **参数解释**： TOP攻击类型 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("attack_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopInfo> AttackType { get; set; }

        /// <summary>
        /// **参数解释**： TOP攻击目的IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopInfo> DstIp { get; set; }

        /// <summary>
        /// **参数解释**： TOP被攻击端口 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_port", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopInfo> DstPort { get; set; }

        /// <summary>
        /// **参数解释**： TOP内部攻击来源IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("in_src_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopInfo> InSrcIp { get; set; }

        /// <summary>
        /// **参数解释**： TOP威胁等级 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopInfo> Level { get; set; }

        /// <summary>
        /// **参数解释**： TOP外部攻击来源IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("out_src_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopInfo> OutSrcIp { get; set; }

        /// <summary>
        /// **参数解释**： TOP攻击来源IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopInfo> SrcIp { get; set; }

        /// <summary>
        /// **参数解释**： 源地区ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopInfo> SrcRegionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttackTopRespBody {\n");
            sb.Append("  attackRule: ").Append(AttackRule).Append("\n");
            sb.Append("  attackType: ").Append(AttackType).Append("\n");
            sb.Append("  dstIp: ").Append(DstIp).Append("\n");
            sb.Append("  dstPort: ").Append(DstPort).Append("\n");
            sb.Append("  inSrcIp: ").Append(InSrcIp).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  outSrcIp: ").Append(OutSrcIp).Append("\n");
            sb.Append("  srcIp: ").Append(SrcIp).Append("\n");
            sb.Append("  srcRegionId: ").Append(SrcRegionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttackTopRespBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttackTopRespBody input)
        {
            if (input == null) return false;
            if (this.AttackRule != input.AttackRule || (this.AttackRule != null && input.AttackRule != null && !this.AttackRule.SequenceEqual(input.AttackRule))) return false;
            if (this.AttackType != input.AttackType || (this.AttackType != null && input.AttackType != null && !this.AttackType.SequenceEqual(input.AttackType))) return false;
            if (this.DstIp != input.DstIp || (this.DstIp != null && input.DstIp != null && !this.DstIp.SequenceEqual(input.DstIp))) return false;
            if (this.DstPort != input.DstPort || (this.DstPort != null && input.DstPort != null && !this.DstPort.SequenceEqual(input.DstPort))) return false;
            if (this.InSrcIp != input.InSrcIp || (this.InSrcIp != null && input.InSrcIp != null && !this.InSrcIp.SequenceEqual(input.InSrcIp))) return false;
            if (this.Level != input.Level || (this.Level != null && input.Level != null && !this.Level.SequenceEqual(input.Level))) return false;
            if (this.OutSrcIp != input.OutSrcIp || (this.OutSrcIp != null && input.OutSrcIp != null && !this.OutSrcIp.SequenceEqual(input.OutSrcIp))) return false;
            if (this.SrcIp != input.SrcIp || (this.SrcIp != null && input.SrcIp != null && !this.SrcIp.SequenceEqual(input.SrcIp))) return false;
            if (this.SrcRegionId != input.SrcRegionId || (this.SrcRegionId != null && input.SrcRegionId != null && !this.SrcRegionId.SequenceEqual(input.SrcRegionId))) return false;

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
                if (this.AttackRule != null) hashCode = hashCode * 59 + this.AttackRule.GetHashCode();
                if (this.AttackType != null) hashCode = hashCode * 59 + this.AttackType.GetHashCode();
                if (this.DstIp != null) hashCode = hashCode * 59 + this.DstIp.GetHashCode();
                if (this.DstPort != null) hashCode = hashCode * 59 + this.DstPort.GetHashCode();
                if (this.InSrcIp != null) hashCode = hashCode * 59 + this.InSrcIp.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.OutSrcIp != null) hashCode = hashCode * 59 + this.OutSrcIp.GetHashCode();
                if (this.SrcIp != null) hashCode = hashCode * 59 + this.SrcIp.GetHashCode();
                if (this.SrcRegionId != null) hashCode = hashCode * 59 + this.SrcRegionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
