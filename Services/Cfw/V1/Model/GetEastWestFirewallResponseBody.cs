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
        /// 防护对象id，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志id，可通过调用查询防火墙实例接口获得，注意type为0的为互联网边界防护对象id，type为1的为VPC边界防护对象id。具体可参考APIExlorer和帮助中心FAQ。
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 租户project_id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 防护状态：0 已开启防护， 1 未开启防护
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("er_associated_subnet", NullValueHandling = NullValueHandling.Ignore)]
        public SubnetInfo ErAssociatedSubnet { get; set; }

        /// <summary>
        /// 云防火墙关联子网信息
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
        /// 东西向防护资源信息
        /// </summary>
        [JsonProperty("protect_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<EwProtectResourceInfo> ProtectInfos { get; set; }

        /// <summary>
        /// 防护VPC总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 偏移量：指定返回记录的开始位置，必须为数字，取值范围为大于或等于0，默认0
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示个数，范围为1-1024
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 防护模式
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// 东西向路由限制
        /// </summary>
        [JsonProperty("ew_vpc_route_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? EwVpcRouteLimit { get; set; }



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
            sb.Append("  erAssociatedSubnet: ").Append(ErAssociatedSubnet).Append("\n");
            sb.Append("  firewallAssociatedSubnets: ").Append(FirewallAssociatedSubnets).Append("\n");
            sb.Append("  er: ").Append(Er).Append("\n");
            sb.Append("  inspectionVpc: ").Append(InspectionVpc).Append("\n");
            sb.Append("  protectInfos: ").Append(ProtectInfos).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  ewVpcRouteLimit: ").Append(EwVpcRouteLimit).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ErAssociatedSubnet == input.ErAssociatedSubnet ||
                    (this.ErAssociatedSubnet != null &&
                    this.ErAssociatedSubnet.Equals(input.ErAssociatedSubnet))
                ) && 
                (
                    this.FirewallAssociatedSubnets == input.FirewallAssociatedSubnets ||
                    this.FirewallAssociatedSubnets != null &&
                    input.FirewallAssociatedSubnets != null &&
                    this.FirewallAssociatedSubnets.SequenceEqual(input.FirewallAssociatedSubnets)
                ) && 
                (
                    this.Er == input.Er ||
                    (this.Er != null &&
                    this.Er.Equals(input.Er))
                ) && 
                (
                    this.InspectionVpc == input.InspectionVpc ||
                    (this.InspectionVpc != null &&
                    this.InspectionVpc.Equals(input.InspectionVpc))
                ) && 
                (
                    this.ProtectInfos == input.ProtectInfos ||
                    this.ProtectInfos != null &&
                    input.ProtectInfos != null &&
                    this.ProtectInfos.SequenceEqual(input.ProtectInfos)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.EwVpcRouteLimit == input.EwVpcRouteLimit ||
                    (this.EwVpcRouteLimit != null &&
                    this.EwVpcRouteLimit.Equals(input.EwVpcRouteLimit))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ErAssociatedSubnet != null)
                    hashCode = hashCode * 59 + this.ErAssociatedSubnet.GetHashCode();
                if (this.FirewallAssociatedSubnets != null)
                    hashCode = hashCode * 59 + this.FirewallAssociatedSubnets.GetHashCode();
                if (this.Er != null)
                    hashCode = hashCode * 59 + this.Er.GetHashCode();
                if (this.InspectionVpc != null)
                    hashCode = hashCode * 59 + this.InspectionVpc.GetHashCode();
                if (this.ProtectInfos != null)
                    hashCode = hashCode * 59 + this.ProtectInfos.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.EwVpcRouteLimit != null)
                    hashCode = hashCode * 59 + this.EwVpcRouteLimit.GetHashCode();
                return hashCode;
            }
        }
    }
}
