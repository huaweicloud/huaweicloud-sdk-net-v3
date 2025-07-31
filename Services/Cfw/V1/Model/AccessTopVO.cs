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
    public class AccessTopVO 
    {

        /// <summary>
        /// **参数解释**： 阻断次数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("deny_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? DenyCount { get; set; }

        /// <summary>
        /// **参数解释**： 高频命中的阻断策略ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("deny_top_one_acl_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DenyTopOneAclId { get; set; }

        /// <summary>
        /// **参数解释**： 高频命中的阻断策略ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("deny_top_one_acl_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DenyTopOneAclName { get; set; }

        /// <summary>
        /// **参数解释**： 命中次数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("hit_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? HitCount { get; set; }

        /// <summary>
        /// **参数解释**： TOP出云阻断目的IP列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("in2out_deny_dst_ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessTopMemberVO> In2outDenyDstIpList { get; set; }

        /// <summary>
        /// **参数解释**： TOP出云阻断端口列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("in2out_deny_dst_port_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessTopMemberVO> In2outDenyDstPortList { get; set; }

        /// <summary>
        /// **参数解释**： TOP出云阻断目的地区列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("in2out_deny_dst_region_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessTopMemberVO> In2outDenyDstRegionList { get; set; }

        /// <summary>
        /// **参数解释**： TOP出云阻断源IP列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("in2out_deny_src_ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessTopMemberVO> In2outDenySrcIpList { get; set; }

        /// <summary>
        /// **参数解释**： TOP入云阻断目的IP列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("out2in_deny_dst_ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessTopMemberVO> Out2inDenyDstIpList { get; set; }

        /// <summary>
        /// **参数解释**： TOP入云阻断目的端口列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("out2in_deny_dst_port_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessTopMemberVO> Out2inDenyDstPortList { get; set; }

        /// <summary>
        /// **参数解释**： TOP入云阻断源IP列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("out2in_deny_src_ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessTopMemberVO> Out2inDenySrcIpList { get; set; }

        /// <summary>
        /// **参数解释**： TOP入云阻断源端口列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("out2in_deny_src_port_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessTopMemberVO> Out2inDenySrcPortList { get; set; }

        /// <summary>
        /// **参数解释**： TOP入云阻断源地区列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("out2in_deny_src_region_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessTopMemberVO> Out2inDenySrcRegionList { get; set; }

        /// <summary>
        /// **参数解释**： 放行次数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("permit_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? PermitCount { get; set; }

        /// <summary>
        /// **参数解释**： 高频命中的放行策略ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("permit_top_one_acl_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PermitTopOneAclId { get; set; }

        /// <summary>
        /// **参数解释**： 高频命中的放行策略名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("permit_top_one_acl_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PermitTopOneAclName { get; set; }

        /// <summary>
        /// **参数解释**： 命中趋势 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("records", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessTopStatisticsVO> Records { get; set; }

        /// <summary>
        /// **参数解释**： TOP阻断规则列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("top_deny_rule_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessTopMemberVO> TopDenyRuleList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessTopVO {\n");
            sb.Append("  denyCount: ").Append(DenyCount).Append("\n");
            sb.Append("  denyTopOneAclId: ").Append(DenyTopOneAclId).Append("\n");
            sb.Append("  denyTopOneAclName: ").Append(DenyTopOneAclName).Append("\n");
            sb.Append("  hitCount: ").Append(HitCount).Append("\n");
            sb.Append("  in2outDenyDstIpList: ").Append(In2outDenyDstIpList).Append("\n");
            sb.Append("  in2outDenyDstPortList: ").Append(In2outDenyDstPortList).Append("\n");
            sb.Append("  in2outDenyDstRegionList: ").Append(In2outDenyDstRegionList).Append("\n");
            sb.Append("  in2outDenySrcIpList: ").Append(In2outDenySrcIpList).Append("\n");
            sb.Append("  out2inDenyDstIpList: ").Append(Out2inDenyDstIpList).Append("\n");
            sb.Append("  out2inDenyDstPortList: ").Append(Out2inDenyDstPortList).Append("\n");
            sb.Append("  out2inDenySrcIpList: ").Append(Out2inDenySrcIpList).Append("\n");
            sb.Append("  out2inDenySrcPortList: ").Append(Out2inDenySrcPortList).Append("\n");
            sb.Append("  out2inDenySrcRegionList: ").Append(Out2inDenySrcRegionList).Append("\n");
            sb.Append("  permitCount: ").Append(PermitCount).Append("\n");
            sb.Append("  permitTopOneAclId: ").Append(PermitTopOneAclId).Append("\n");
            sb.Append("  permitTopOneAclName: ").Append(PermitTopOneAclName).Append("\n");
            sb.Append("  records: ").Append(Records).Append("\n");
            sb.Append("  topDenyRuleList: ").Append(TopDenyRuleList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessTopVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessTopVO input)
        {
            if (input == null) return false;
            if (this.DenyCount != input.DenyCount || (this.DenyCount != null && !this.DenyCount.Equals(input.DenyCount))) return false;
            if (this.DenyTopOneAclId != input.DenyTopOneAclId || (this.DenyTopOneAclId != null && !this.DenyTopOneAclId.Equals(input.DenyTopOneAclId))) return false;
            if (this.DenyTopOneAclName != input.DenyTopOneAclName || (this.DenyTopOneAclName != null && !this.DenyTopOneAclName.Equals(input.DenyTopOneAclName))) return false;
            if (this.HitCount != input.HitCount || (this.HitCount != null && !this.HitCount.Equals(input.HitCount))) return false;
            if (this.In2outDenyDstIpList != input.In2outDenyDstIpList || (this.In2outDenyDstIpList != null && input.In2outDenyDstIpList != null && !this.In2outDenyDstIpList.SequenceEqual(input.In2outDenyDstIpList))) return false;
            if (this.In2outDenyDstPortList != input.In2outDenyDstPortList || (this.In2outDenyDstPortList != null && input.In2outDenyDstPortList != null && !this.In2outDenyDstPortList.SequenceEqual(input.In2outDenyDstPortList))) return false;
            if (this.In2outDenyDstRegionList != input.In2outDenyDstRegionList || (this.In2outDenyDstRegionList != null && input.In2outDenyDstRegionList != null && !this.In2outDenyDstRegionList.SequenceEqual(input.In2outDenyDstRegionList))) return false;
            if (this.In2outDenySrcIpList != input.In2outDenySrcIpList || (this.In2outDenySrcIpList != null && input.In2outDenySrcIpList != null && !this.In2outDenySrcIpList.SequenceEqual(input.In2outDenySrcIpList))) return false;
            if (this.Out2inDenyDstIpList != input.Out2inDenyDstIpList || (this.Out2inDenyDstIpList != null && input.Out2inDenyDstIpList != null && !this.Out2inDenyDstIpList.SequenceEqual(input.Out2inDenyDstIpList))) return false;
            if (this.Out2inDenyDstPortList != input.Out2inDenyDstPortList || (this.Out2inDenyDstPortList != null && input.Out2inDenyDstPortList != null && !this.Out2inDenyDstPortList.SequenceEqual(input.Out2inDenyDstPortList))) return false;
            if (this.Out2inDenySrcIpList != input.Out2inDenySrcIpList || (this.Out2inDenySrcIpList != null && input.Out2inDenySrcIpList != null && !this.Out2inDenySrcIpList.SequenceEqual(input.Out2inDenySrcIpList))) return false;
            if (this.Out2inDenySrcPortList != input.Out2inDenySrcPortList || (this.Out2inDenySrcPortList != null && input.Out2inDenySrcPortList != null && !this.Out2inDenySrcPortList.SequenceEqual(input.Out2inDenySrcPortList))) return false;
            if (this.Out2inDenySrcRegionList != input.Out2inDenySrcRegionList || (this.Out2inDenySrcRegionList != null && input.Out2inDenySrcRegionList != null && !this.Out2inDenySrcRegionList.SequenceEqual(input.Out2inDenySrcRegionList))) return false;
            if (this.PermitCount != input.PermitCount || (this.PermitCount != null && !this.PermitCount.Equals(input.PermitCount))) return false;
            if (this.PermitTopOneAclId != input.PermitTopOneAclId || (this.PermitTopOneAclId != null && !this.PermitTopOneAclId.Equals(input.PermitTopOneAclId))) return false;
            if (this.PermitTopOneAclName != input.PermitTopOneAclName || (this.PermitTopOneAclName != null && !this.PermitTopOneAclName.Equals(input.PermitTopOneAclName))) return false;
            if (this.Records != input.Records || (this.Records != null && input.Records != null && !this.Records.SequenceEqual(input.Records))) return false;
            if (this.TopDenyRuleList != input.TopDenyRuleList || (this.TopDenyRuleList != null && input.TopDenyRuleList != null && !this.TopDenyRuleList.SequenceEqual(input.TopDenyRuleList))) return false;

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
                if (this.DenyCount != null) hashCode = hashCode * 59 + this.DenyCount.GetHashCode();
                if (this.DenyTopOneAclId != null) hashCode = hashCode * 59 + this.DenyTopOneAclId.GetHashCode();
                if (this.DenyTopOneAclName != null) hashCode = hashCode * 59 + this.DenyTopOneAclName.GetHashCode();
                if (this.HitCount != null) hashCode = hashCode * 59 + this.HitCount.GetHashCode();
                if (this.In2outDenyDstIpList != null) hashCode = hashCode * 59 + this.In2outDenyDstIpList.GetHashCode();
                if (this.In2outDenyDstPortList != null) hashCode = hashCode * 59 + this.In2outDenyDstPortList.GetHashCode();
                if (this.In2outDenyDstRegionList != null) hashCode = hashCode * 59 + this.In2outDenyDstRegionList.GetHashCode();
                if (this.In2outDenySrcIpList != null) hashCode = hashCode * 59 + this.In2outDenySrcIpList.GetHashCode();
                if (this.Out2inDenyDstIpList != null) hashCode = hashCode * 59 + this.Out2inDenyDstIpList.GetHashCode();
                if (this.Out2inDenyDstPortList != null) hashCode = hashCode * 59 + this.Out2inDenyDstPortList.GetHashCode();
                if (this.Out2inDenySrcIpList != null) hashCode = hashCode * 59 + this.Out2inDenySrcIpList.GetHashCode();
                if (this.Out2inDenySrcPortList != null) hashCode = hashCode * 59 + this.Out2inDenySrcPortList.GetHashCode();
                if (this.Out2inDenySrcRegionList != null) hashCode = hashCode * 59 + this.Out2inDenySrcRegionList.GetHashCode();
                if (this.PermitCount != null) hashCode = hashCode * 59 + this.PermitCount.GetHashCode();
                if (this.PermitTopOneAclId != null) hashCode = hashCode * 59 + this.PermitTopOneAclId.GetHashCode();
                if (this.PermitTopOneAclName != null) hashCode = hashCode * 59 + this.PermitTopOneAclName.GetHashCode();
                if (this.Records != null) hashCode = hashCode * 59 + this.Records.GetHashCode();
                if (this.TopDenyRuleList != null) hashCode = hashCode * 59 + this.TopDenyRuleList.GetHashCode();
                return hashCode;
            }
        }
    }
}
