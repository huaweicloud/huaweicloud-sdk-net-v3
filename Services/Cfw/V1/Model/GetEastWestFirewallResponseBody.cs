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
    /// 查询东西向防火墙接口响应Body体
    /// </summary>
    public class GetEastWestFirewallResponseBody 
    {

        /// <summary>
        /// **参数解释**： 防护对象id，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志id，可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)获得，通过返回值中的data.records.protect_objects.object_id（.表示各对象之间层级的区分）获得。type为0时，object_id为互联网边界防护对象ID，type为1时，object_id为VPC边界防护对象ID。此处仅取type为1的防护对象id，可通过data.records.protect_objects.type（.表示各对象之间层级的区分）获得。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// **参数解释**： 项目ID，可以通过调用API获取，也可以从控制台获取。[项目ID获取方式](cfw_02_0015.xml) **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 防护状态： 不涉及 **取值范围**： 0：已开启防护 1：未开启防护
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// **参数解释**： 云防火墙关联子网信息 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("firewall_associated_subnets", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubnetInfo> FirewallAssociatedSubnets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("er", NullValueHandling = NullValueHandling.Ignore)]
        public ErInstance Er { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inspection_vpc", NullValueHandling = NullValueHandling.Ignore)]
        public VpcDetail InspectionVpc { get; set; }

        /// <summary>
        /// **参数解释**： 东西向防护资源信息 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("protect_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<EwProtectResourceInfo> ProtectInfos { get; set; }

        /// <summary>
        /// **参数解释**： 防护VPC总数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**： 偏移量：指定返回记录的开始位置 **取值范围**： 大于或等于0
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释**： 每页显示个数 **取值范围**： 1-1024
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**： 防护模式，值为er **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetEastWestFirewallResponseBody {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  firewallAssociatedSubnets: ").Append(FirewallAssociatedSubnets).Append("\n");
            sb.Append("  er: ").Append(Er).Append("\n");
            sb.Append("  inspectionVpc: ").Append(InspectionVpc).Append("\n");
            sb.Append("  protectInfos: ").Append(ProtectInfos).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetEastWestFirewallResponseBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetEastWestFirewallResponseBody input)
        {
            if (input == null) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.FirewallAssociatedSubnets != input.FirewallAssociatedSubnets || (this.FirewallAssociatedSubnets != null && input.FirewallAssociatedSubnets != null && !this.FirewallAssociatedSubnets.SequenceEqual(input.FirewallAssociatedSubnets))) return false;
            if (this.Er != input.Er || (this.Er != null && !this.Er.Equals(input.Er))) return false;
            if (this.InspectionVpc != input.InspectionVpc || (this.InspectionVpc != null && !this.InspectionVpc.Equals(input.InspectionVpc))) return false;
            if (this.ProtectInfos != input.ProtectInfos || (this.ProtectInfos != null && input.ProtectInfos != null && !this.ProtectInfos.SequenceEqual(input.ProtectInfos))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;

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
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.FirewallAssociatedSubnets != null) hashCode = hashCode * 59 + this.FirewallAssociatedSubnets.GetHashCode();
                if (this.Er != null) hashCode = hashCode * 59 + this.Er.GetHashCode();
                if (this.InspectionVpc != null) hashCode = hashCode * 59 + this.InspectionVpc.GetHashCode();
                if (this.ProtectInfos != null) hashCode = hashCode * 59 + this.ProtectInfos.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
