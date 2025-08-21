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
    public class AttackReport 
    {

        /// <summary>
        /// **参数解释**： TOP攻击目的IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemVO> DstIp { get; set; }

        /// <summary>
        /// **参数解释**： 入侵防御状态 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("ips_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpsMode { get; set; }

        /// <summary>
        /// **参数解释**： 攻击等级分布 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemVO> Level { get; set; }

        /// <summary>
        /// **参数解释**： TOP攻击规则 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("rule", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemVO> Rule { get; set; }

        /// <summary>
        /// **参数解释**： TOP来源IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemVO> SrcIp { get; set; }

        /// <summary>
        /// **参数解释**： 攻击趋势 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("trend", NullValueHandling = NullValueHandling.Ignore)]
        public List<TrendVO> Trend { get; set; }

        /// <summary>
        /// **参数解释**： TOP攻击分布 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemVO> Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttackReport {\n");
            sb.Append("  dstIp: ").Append(DstIp).Append("\n");
            sb.Append("  ipsMode: ").Append(IpsMode).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  rule: ").Append(Rule).Append("\n");
            sb.Append("  srcIp: ").Append(SrcIp).Append("\n");
            sb.Append("  trend: ").Append(Trend).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttackReport);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttackReport input)
        {
            if (input == null) return false;
            if (this.DstIp != input.DstIp || (this.DstIp != null && input.DstIp != null && !this.DstIp.SequenceEqual(input.DstIp))) return false;
            if (this.IpsMode != input.IpsMode || (this.IpsMode != null && !this.IpsMode.Equals(input.IpsMode))) return false;
            if (this.Level != input.Level || (this.Level != null && input.Level != null && !this.Level.SequenceEqual(input.Level))) return false;
            if (this.Rule != input.Rule || (this.Rule != null && input.Rule != null && !this.Rule.SequenceEqual(input.Rule))) return false;
            if (this.SrcIp != input.SrcIp || (this.SrcIp != null && input.SrcIp != null && !this.SrcIp.SequenceEqual(input.SrcIp))) return false;
            if (this.Trend != input.Trend || (this.Trend != null && input.Trend != null && !this.Trend.SequenceEqual(input.Trend))) return false;
            if (this.Type != input.Type || (this.Type != null && input.Type != null && !this.Type.SequenceEqual(input.Type))) return false;

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
                if (this.DstIp != null) hashCode = hashCode * 59 + this.DstIp.GetHashCode();
                if (this.IpsMode != null) hashCode = hashCode * 59 + this.IpsMode.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Rule != null) hashCode = hashCode * 59 + this.Rule.GetHashCode();
                if (this.SrcIp != null) hashCode = hashCode * 59 + this.SrcIp.GetHashCode();
                if (this.Trend != null) hashCode = hashCode * 59 + this.Trend.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
