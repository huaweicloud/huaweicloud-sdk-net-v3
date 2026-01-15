using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 修改桌面池属性请求。
    /// </summary>
    public class UpdateDesktopPoolAttributesReq 
    {

        /// <summary>
        /// 桌面池名称，桌面池名称必须保证唯一。桌面名称只允许输入中文、大写字母、小写字母、数字、中划线，长度范围为1~255。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 桌面池描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// OU名称，在对接AD时使用，需提前在AD中创建OU。
        /// </summary>
        [JsonProperty("ou_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OuName { get; set; }

        /// <summary>
        /// 标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 桌面断连多少分钟内，保留用户与桌面的绑定关系，超时后自动解绑。
        /// </summary>
        [JsonProperty("disconnected_retention_period", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisconnectedRetentionPeriod { get; set; }

        /// <summary>
        /// 桌面池是否开启弹性伸缩类型，为false则表示不开启弹性伸缩，为true则表示开启弹性伸缩。
        /// </summary>
        [JsonProperty("enable_autoscale", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoscale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("autoscale_policy", NullValueHandling = NullValueHandling.Ignore)]
        public AutoscalePolicy AutoscalePolicy { get; set; }

        /// <summary>
        /// 是否处于管理员维护模式。
        /// </summary>
        [JsonProperty("in_maintenance_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InMaintenanceMode { get; set; }

        /// <summary>
        /// 策略id，用于指定生成桌面名称策略。
        /// </summary>
        [JsonProperty("desktop_name_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopNamePolicyId { get; set; }

        /// <summary>
        /// 桌面池的可用区。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("root_volume", NullValueHandling = NullValueHandling.Ignore)]
        public DesktopPoolVolumeInfo RootVolume { get; set; }

        /// <summary>
        /// 数据盘列表。
        /// </summary>
        [JsonProperty("data_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<DesktopPoolVolumeInfo> DataVolumes { get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 桌面池子网ID列表
        /// </summary>
        [JsonProperty("subnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubnetIds { get; set; }

        /// <summary>
        /// 桌面使用的安全组，如果不指定则默认使用桌面代理中指定的安全组
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityGroupIdInfo> SecurityGroups { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDesktopPoolAttributesReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  ouName: ").Append(OuName).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  disconnectedRetentionPeriod: ").Append(DisconnectedRetentionPeriod).Append("\n");
            sb.Append("  enableAutoscale: ").Append(EnableAutoscale).Append("\n");
            sb.Append("  autoscalePolicy: ").Append(AutoscalePolicy).Append("\n");
            sb.Append("  inMaintenanceMode: ").Append(InMaintenanceMode).Append("\n");
            sb.Append("  desktopNamePolicyId: ").Append(DesktopNamePolicyId).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetIds: ").Append(SubnetIds).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDesktopPoolAttributesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDesktopPoolAttributesReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.OuName != input.OuName || (this.OuName != null && !this.OuName.Equals(input.OuName))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.DisconnectedRetentionPeriod != input.DisconnectedRetentionPeriod || (this.DisconnectedRetentionPeriod != null && !this.DisconnectedRetentionPeriod.Equals(input.DisconnectedRetentionPeriod))) return false;
            if (this.EnableAutoscale != input.EnableAutoscale || (this.EnableAutoscale != null && !this.EnableAutoscale.Equals(input.EnableAutoscale))) return false;
            if (this.AutoscalePolicy != input.AutoscalePolicy || (this.AutoscalePolicy != null && !this.AutoscalePolicy.Equals(input.AutoscalePolicy))) return false;
            if (this.InMaintenanceMode != input.InMaintenanceMode || (this.InMaintenanceMode != null && !this.InMaintenanceMode.Equals(input.InMaintenanceMode))) return false;
            if (this.DesktopNamePolicyId != input.DesktopNamePolicyId || (this.DesktopNamePolicyId != null && !this.DesktopNamePolicyId.Equals(input.DesktopNamePolicyId))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.RootVolume != input.RootVolume || (this.RootVolume != null && !this.RootVolume.Equals(input.RootVolume))) return false;
            if (this.DataVolumes != input.DataVolumes || (this.DataVolumes != null && input.DataVolumes != null && !this.DataVolumes.SequenceEqual(input.DataVolumes))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetIds != input.SubnetIds || (this.SubnetIds != null && input.SubnetIds != null && !this.SubnetIds.SequenceEqual(input.SubnetIds))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.OuName != null) hashCode = hashCode * 59 + this.OuName.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.DisconnectedRetentionPeriod != null) hashCode = hashCode * 59 + this.DisconnectedRetentionPeriod.GetHashCode();
                if (this.EnableAutoscale != null) hashCode = hashCode * 59 + this.EnableAutoscale.GetHashCode();
                if (this.AutoscalePolicy != null) hashCode = hashCode * 59 + this.AutoscalePolicy.GetHashCode();
                if (this.InMaintenanceMode != null) hashCode = hashCode * 59 + this.InMaintenanceMode.GetHashCode();
                if (this.DesktopNamePolicyId != null) hashCode = hashCode * 59 + this.DesktopNamePolicyId.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.RootVolume != null) hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                if (this.DataVolumes != null) hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetIds != null) hashCode = hashCode * 59 + this.SubnetIds.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
