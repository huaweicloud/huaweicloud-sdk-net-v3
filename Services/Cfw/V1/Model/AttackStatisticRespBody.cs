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
    public class AttackStatisticRespBody 
    {

        /// <summary>
        /// **参数解释**： 应用列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("apps", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopInfo> Apps { get; set; }

        /// <summary>
        /// **参数解释**： 绑定资源名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("associated_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociatedName { get; set; }

        /// <summary>
        /// **参数解释**： 绑定资源类型 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("associated_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociatedType { get; set; }

        /// <summary>
        /// **参数解释**： 攻击次数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("attack_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? AttackCount { get; set; }

        /// <summary>
        /// **参数解释**： 攻击类型 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("attack_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackType { get; set; }

        /// <summary>
        /// **参数解释**： 拦截次数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("deny_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? DenyCount { get; set; }

        /// <summary>
        /// **参数解释**： 目的端口列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_ports", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopInfo> DstPorts { get; set; }

        /// <summary>
        /// **参数解释**： IP地址 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// **参数解释**： 最近攻击时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("latest_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LatestTime { get; set; }

        /// <summary>
        /// **参数解释**： 地区ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// **参数解释**： 地区名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionName { get; set; }

        /// <summary>
        /// **参数解释**： 攻击来源类型 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcType { get; set; }

        /// <summary>
        /// **参数解释**： vgw Id **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("vgw_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VgwId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttackStatisticRespBody {\n");
            sb.Append("  apps: ").Append(Apps).Append("\n");
            sb.Append("  associatedName: ").Append(AssociatedName).Append("\n");
            sb.Append("  associatedType: ").Append(AssociatedType).Append("\n");
            sb.Append("  attackCount: ").Append(AttackCount).Append("\n");
            sb.Append("  attackType: ").Append(AttackType).Append("\n");
            sb.Append("  denyCount: ").Append(DenyCount).Append("\n");
            sb.Append("  dstPorts: ").Append(DstPorts).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  latestTime: ").Append(LatestTime).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  regionName: ").Append(RegionName).Append("\n");
            sb.Append("  srcType: ").Append(SrcType).Append("\n");
            sb.Append("  vgwId: ").Append(VgwId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttackStatisticRespBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttackStatisticRespBody input)
        {
            if (input == null) return false;
            if (this.Apps != input.Apps || (this.Apps != null && input.Apps != null && !this.Apps.SequenceEqual(input.Apps))) return false;
            if (this.AssociatedName != input.AssociatedName || (this.AssociatedName != null && !this.AssociatedName.Equals(input.AssociatedName))) return false;
            if (this.AssociatedType != input.AssociatedType || (this.AssociatedType != null && !this.AssociatedType.Equals(input.AssociatedType))) return false;
            if (this.AttackCount != input.AttackCount || (this.AttackCount != null && !this.AttackCount.Equals(input.AttackCount))) return false;
            if (this.AttackType != input.AttackType || (this.AttackType != null && !this.AttackType.Equals(input.AttackType))) return false;
            if (this.DenyCount != input.DenyCount || (this.DenyCount != null && !this.DenyCount.Equals(input.DenyCount))) return false;
            if (this.DstPorts != input.DstPorts || (this.DstPorts != null && input.DstPorts != null && !this.DstPorts.SequenceEqual(input.DstPorts))) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.LatestTime != input.LatestTime || (this.LatestTime != null && !this.LatestTime.Equals(input.LatestTime))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.RegionName != input.RegionName || (this.RegionName != null && !this.RegionName.Equals(input.RegionName))) return false;
            if (this.SrcType != input.SrcType || (this.SrcType != null && !this.SrcType.Equals(input.SrcType))) return false;
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
                if (this.Apps != null) hashCode = hashCode * 59 + this.Apps.GetHashCode();
                if (this.AssociatedName != null) hashCode = hashCode * 59 + this.AssociatedName.GetHashCode();
                if (this.AssociatedType != null) hashCode = hashCode * 59 + this.AssociatedType.GetHashCode();
                if (this.AttackCount != null) hashCode = hashCode * 59 + this.AttackCount.GetHashCode();
                if (this.AttackType != null) hashCode = hashCode * 59 + this.AttackType.GetHashCode();
                if (this.DenyCount != null) hashCode = hashCode * 59 + this.DenyCount.GetHashCode();
                if (this.DstPorts != null) hashCode = hashCode * 59 + this.DstPorts.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.LatestTime != null) hashCode = hashCode * 59 + this.LatestTime.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.RegionName != null) hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                if (this.SrcType != null) hashCode = hashCode * 59 + this.SrcType.GetHashCode();
                if (this.VgwId != null) hashCode = hashCode * 59 + this.VgwId.GetHashCode();
                return hashCode;
            }
        }
    }
}
