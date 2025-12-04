using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateDdmInstanceReq 
    {

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 可用区。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// 节点数量。
        /// </summary>
        [JsonProperty("node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNum { get; set; }

        /// <summary>
        /// 引擎版本。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 规格。
        /// </summary>
        [JsonProperty("flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 虚拟私有云id。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网id。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 安全组id。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 参数组id。
        /// </summary>
        [JsonProperty("param_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamGroupId { get; set; }

        /// <summary>
        /// 企业项目id。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 时区。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 账号。
        /// </summary>
        [JsonProperty("admin_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminUserName { get; set; }

        /// <summary>
        /// 密码。
        /// </summary>
        [JsonProperty("admin_user_password", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminUserPassword { get; set; }

        /// <summary>
        /// 付费信息。
        /// </summary>
        [JsonProperty("charge_info", NullValueHandling = NullValueHandling.Ignore)]
        public Object ChargeInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDdmInstanceReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  nodeNum: ").Append(NodeNum).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  paramGroupId: ").Append(ParamGroupId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  adminUserName: ").Append(AdminUserName).Append("\n");
            sb.Append("  adminUserPassword: ").Append(AdminUserPassword).Append("\n");
            sb.Append("  chargeInfo: ").Append(ChargeInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDdmInstanceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDdmInstanceReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AvailableZones != input.AvailableZones || (this.AvailableZones != null && input.AvailableZones != null && !this.AvailableZones.SequenceEqual(input.AvailableZones))) return false;
            if (this.NodeNum != input.NodeNum || (this.NodeNum != null && !this.NodeNum.Equals(input.NodeNum))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.FlavorRef != input.FlavorRef || (this.FlavorRef != null && !this.FlavorRef.Equals(input.FlavorRef))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.SecurityGroupId != input.SecurityGroupId || (this.SecurityGroupId != null && !this.SecurityGroupId.Equals(input.SecurityGroupId))) return false;
            if (this.ParamGroupId != input.ParamGroupId || (this.ParamGroupId != null && !this.ParamGroupId.Equals(input.ParamGroupId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.TimeZone != input.TimeZone || (this.TimeZone != null && !this.TimeZone.Equals(input.TimeZone))) return false;
            if (this.AdminUserName != input.AdminUserName || (this.AdminUserName != null && !this.AdminUserName.Equals(input.AdminUserName))) return false;
            if (this.AdminUserPassword != input.AdminUserPassword || (this.AdminUserPassword != null && !this.AdminUserPassword.Equals(input.AdminUserPassword))) return false;
            if (this.ChargeInfo != input.ChargeInfo || (this.ChargeInfo != null && !this.ChargeInfo.Equals(input.ChargeInfo))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AvailableZones != null) hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.NodeNum != null) hashCode = hashCode * 59 + this.NodeNum.GetHashCode();
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.FlavorRef != null) hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SecurityGroupId != null) hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.ParamGroupId != null) hashCode = hashCode * 59 + this.ParamGroupId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.TimeZone != null) hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.AdminUserName != null) hashCode = hashCode * 59 + this.AdminUserName.GetHashCode();
                if (this.AdminUserPassword != null) hashCode = hashCode * 59 + this.AdminUserPassword.GetHashCode();
                if (this.ChargeInfo != null) hashCode = hashCode * 59 + this.ChargeInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
