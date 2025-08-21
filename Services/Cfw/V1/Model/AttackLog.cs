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
    public class AttackLog 
    {

        /// <summary>
        /// **参数解释**： 动作 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// **参数解释**： 应用 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// **参数解释**： 攻击规则 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("attack_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackRule { get; set; }

        /// <summary>
        /// **参数解释**： 攻击规则ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("attack_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackRuleId { get; set; }

        /// <summary>
        /// **参数解释**： 攻击类型 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("attack_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackType { get; set; }

        /// <summary>
        /// **参数解释**： 攻击方向 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// **参数解释**： 目的IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DstIp { get; set; }

        /// <summary>
        /// **参数解释**： 目的端口 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DstPort { get; set; }

        /// <summary>
        /// **参数解释**： 目的地区Id **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DstRegionId { get; set; }

        /// <summary>
        /// **参数解释**： 目的地区名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DstRegionName { get; set; }

        /// <summary>
        /// **参数解释**： 目的省份ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_province_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DstProvinceId { get; set; }

        /// <summary>
        /// **参数解释**： 目的省份名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_province_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DstProvinceName { get; set; }

        /// <summary>
        /// **参数解释**： 目的城市Id **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_city_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DstCityId { get; set; }

        /// <summary>
        /// **参数解释**： 目的城市名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DstCityName { get; set; }

        /// <summary>
        /// **参数解释**： 发生时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("event_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EventTime { get; set; }

        /// <summary>
        /// **参数解释**： 危险等级 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        /// **参数解释**： 协议 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// **参数解释**： 来源 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// **参数解释**： 源IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcIp { get; set; }

        /// <summary>
        /// **参数解释**： 真实IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("real_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string RealIp { get; set; }

        /// <summary>
        /// **参数解释**： 标签 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public int? Tag { get; set; }

        /// <summary>
        /// **参数解释**： 源端口 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? SrcPort { get; set; }

        /// <summary>
        /// **参数解释**： 源地区Id **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcRegionId { get; set; }

        /// <summary>
        /// **参数解释**： 源地区名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcRegionName { get; set; }

        /// <summary>
        /// **参数解释**： 源省份Id **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_province_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcProvinceId { get; set; }

        /// <summary>
        /// **参数解释**： 源省份名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_province_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcProvinceName { get; set; }

        /// <summary>
        /// **参数解释**： 源城市Id **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_city_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcCityId { get; set; }

        /// <summary>
        /// **参数解释**： 源城市 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcCityName { get; set; }

        /// <summary>
        /// **参数解释**： VGW Id **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("vgw_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VgwId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttackLog {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  attackRule: ").Append(AttackRule).Append("\n");
            sb.Append("  attackRuleId: ").Append(AttackRuleId).Append("\n");
            sb.Append("  attackType: ").Append(AttackType).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  dstIp: ").Append(DstIp).Append("\n");
            sb.Append("  dstPort: ").Append(DstPort).Append("\n");
            sb.Append("  dstRegionId: ").Append(DstRegionId).Append("\n");
            sb.Append("  dstRegionName: ").Append(DstRegionName).Append("\n");
            sb.Append("  dstProvinceId: ").Append(DstProvinceId).Append("\n");
            sb.Append("  dstProvinceName: ").Append(DstProvinceName).Append("\n");
            sb.Append("  dstCityId: ").Append(DstCityId).Append("\n");
            sb.Append("  dstCityName: ").Append(DstCityName).Append("\n");
            sb.Append("  eventTime: ").Append(EventTime).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  srcIp: ").Append(SrcIp).Append("\n");
            sb.Append("  realIp: ").Append(RealIp).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  srcPort: ").Append(SrcPort).Append("\n");
            sb.Append("  srcRegionId: ").Append(SrcRegionId).Append("\n");
            sb.Append("  srcRegionName: ").Append(SrcRegionName).Append("\n");
            sb.Append("  srcProvinceId: ").Append(SrcProvinceId).Append("\n");
            sb.Append("  srcProvinceName: ").Append(SrcProvinceName).Append("\n");
            sb.Append("  srcCityId: ").Append(SrcCityId).Append("\n");
            sb.Append("  srcCityName: ").Append(SrcCityName).Append("\n");
            sb.Append("  vgwId: ").Append(VgwId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttackLog);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttackLog input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.AttackRule != input.AttackRule || (this.AttackRule != null && !this.AttackRule.Equals(input.AttackRule))) return false;
            if (this.AttackRuleId != input.AttackRuleId || (this.AttackRuleId != null && !this.AttackRuleId.Equals(input.AttackRuleId))) return false;
            if (this.AttackType != input.AttackType || (this.AttackType != null && !this.AttackType.Equals(input.AttackType))) return false;
            if (this.Direction != input.Direction || (this.Direction != null && !this.Direction.Equals(input.Direction))) return false;
            if (this.DstIp != input.DstIp || (this.DstIp != null && !this.DstIp.Equals(input.DstIp))) return false;
            if (this.DstPort != input.DstPort || (this.DstPort != null && !this.DstPort.Equals(input.DstPort))) return false;
            if (this.DstRegionId != input.DstRegionId || (this.DstRegionId != null && !this.DstRegionId.Equals(input.DstRegionId))) return false;
            if (this.DstRegionName != input.DstRegionName || (this.DstRegionName != null && !this.DstRegionName.Equals(input.DstRegionName))) return false;
            if (this.DstProvinceId != input.DstProvinceId || (this.DstProvinceId != null && !this.DstProvinceId.Equals(input.DstProvinceId))) return false;
            if (this.DstProvinceName != input.DstProvinceName || (this.DstProvinceName != null && !this.DstProvinceName.Equals(input.DstProvinceName))) return false;
            if (this.DstCityId != input.DstCityId || (this.DstCityId != null && !this.DstCityId.Equals(input.DstCityId))) return false;
            if (this.DstCityName != input.DstCityName || (this.DstCityName != null && !this.DstCityName.Equals(input.DstCityName))) return false;
            if (this.EventTime != input.EventTime || (this.EventTime != null && !this.EventTime.Equals(input.EventTime))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.SrcIp != input.SrcIp || (this.SrcIp != null && !this.SrcIp.Equals(input.SrcIp))) return false;
            if (this.RealIp != input.RealIp || (this.RealIp != null && !this.RealIp.Equals(input.RealIp))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;
            if (this.SrcPort != input.SrcPort || (this.SrcPort != null && !this.SrcPort.Equals(input.SrcPort))) return false;
            if (this.SrcRegionId != input.SrcRegionId || (this.SrcRegionId != null && !this.SrcRegionId.Equals(input.SrcRegionId))) return false;
            if (this.SrcRegionName != input.SrcRegionName || (this.SrcRegionName != null && !this.SrcRegionName.Equals(input.SrcRegionName))) return false;
            if (this.SrcProvinceId != input.SrcProvinceId || (this.SrcProvinceId != null && !this.SrcProvinceId.Equals(input.SrcProvinceId))) return false;
            if (this.SrcProvinceName != input.SrcProvinceName || (this.SrcProvinceName != null && !this.SrcProvinceName.Equals(input.SrcProvinceName))) return false;
            if (this.SrcCityId != input.SrcCityId || (this.SrcCityId != null && !this.SrcCityId.Equals(input.SrcCityId))) return false;
            if (this.SrcCityName != input.SrcCityName || (this.SrcCityName != null && !this.SrcCityName.Equals(input.SrcCityName))) return false;
            if (this.VgwId != input.VgwId || (this.VgwId != null && !this.VgwId.Equals(input.VgwId))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.AttackRule != null) hashCode = hashCode * 59 + this.AttackRule.GetHashCode();
                if (this.AttackRuleId != null) hashCode = hashCode * 59 + this.AttackRuleId.GetHashCode();
                if (this.AttackType != null) hashCode = hashCode * 59 + this.AttackType.GetHashCode();
                if (this.Direction != null) hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.DstIp != null) hashCode = hashCode * 59 + this.DstIp.GetHashCode();
                if (this.DstPort != null) hashCode = hashCode * 59 + this.DstPort.GetHashCode();
                if (this.DstRegionId != null) hashCode = hashCode * 59 + this.DstRegionId.GetHashCode();
                if (this.DstRegionName != null) hashCode = hashCode * 59 + this.DstRegionName.GetHashCode();
                if (this.DstProvinceId != null) hashCode = hashCode * 59 + this.DstProvinceId.GetHashCode();
                if (this.DstProvinceName != null) hashCode = hashCode * 59 + this.DstProvinceName.GetHashCode();
                if (this.DstCityId != null) hashCode = hashCode * 59 + this.DstCityId.GetHashCode();
                if (this.DstCityName != null) hashCode = hashCode * 59 + this.DstCityName.GetHashCode();
                if (this.EventTime != null) hashCode = hashCode * 59 + this.EventTime.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.SrcIp != null) hashCode = hashCode * 59 + this.SrcIp.GetHashCode();
                if (this.RealIp != null) hashCode = hashCode * 59 + this.RealIp.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.SrcPort != null) hashCode = hashCode * 59 + this.SrcPort.GetHashCode();
                if (this.SrcRegionId != null) hashCode = hashCode * 59 + this.SrcRegionId.GetHashCode();
                if (this.SrcRegionName != null) hashCode = hashCode * 59 + this.SrcRegionName.GetHashCode();
                if (this.SrcProvinceId != null) hashCode = hashCode * 59 + this.SrcProvinceId.GetHashCode();
                if (this.SrcProvinceName != null) hashCode = hashCode * 59 + this.SrcProvinceName.GetHashCode();
                if (this.SrcCityId != null) hashCode = hashCode * 59 + this.SrcCityId.GetHashCode();
                if (this.SrcCityName != null) hashCode = hashCode * 59 + this.SrcCityName.GetHashCode();
                if (this.VgwId != null) hashCode = hashCode * 59 + this.VgwId.GetHashCode();
                return hashCode;
            }
        }
    }
}
