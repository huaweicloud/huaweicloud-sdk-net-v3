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
    /// Response Object
    /// </summary>
    public class ShowDesktopPoolDetailResponse : SdkResponse
    {

        /// <summary>
        /// 桌面池ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 桌面池名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 桌面池类型。DYNAMIC：动态池，STATIC：静态池。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 桌面池描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 创建时间，格式为：UTC格式，例如“2022-05-11T11:45:42.000Z”。
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 计费模式，0：包周期，1：按需。
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargingMode { get; set; }

        /// <summary>
        /// 桌面池总桌面数量。
        /// </summary>
        [JsonProperty("desktop_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DesktopCount { get; set; }

        /// <summary>
        /// 桌面池绑定用户的桌面个数。
        /// </summary>
        [JsonProperty("desktop_used", NullValueHandling = NullValueHandling.Ignore)]
        public int? DesktopUsed { get; set; }

        /// <summary>
        /// 可用区。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 子网ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public ProductInfo Product { get; set; }

        /// <summary>
        /// 镜像ID。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 镜像名称。
        /// </summary>
        [JsonProperty("image_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageName { get; set; }

        /// <summary>
        /// 镜像OS类型。
        /// </summary>
        [JsonProperty("image_os_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageOsType { get; set; }

        /// <summary>
        /// 镜像OS版本。
        /// </summary>
        [JsonProperty("image_os_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageOsVersion { get; set; }

        /// <summary>
        /// 镜像OS平台。
        /// </summary>
        [JsonProperty("image_os_platform", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageOsPlatform { get; set; }

        /// <summary>
        /// 镜像的productCode（specCode）。
        /// </summary>
        [JsonProperty("image_product_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageProductCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("root_volume", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeInfo RootVolume { get; set; }

        /// <summary>
        /// 数据盘列表。
        /// </summary>
        [JsonProperty("data_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeInfo> DataVolumes { get; set; }

        /// <summary>
        /// 桌面安全组。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityGroupInfo> SecurityGroups { get; set; }

        /// <summary>
        /// 动态池桌面断连多少分钟内，保留用户与桌面的绑定关系，超时后自动解绑。
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
        /// 桌面池状态。 - STEADY：稳态 - TEMPORARY：临时态 - EXIST_FROZEN：存在冻结桌面 - UNKNOWN：未知态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 桌面池是否处于管理员维护模式。
        /// </summary>
        [JsonProperty("in_maintenance_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InMaintenanceMode { get; set; }

        /// <summary>
        /// 策略id，用于指定生成桌面名称策略。
        /// </summary>
        [JsonProperty("desktop_name_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopNamePolicyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDesktopPoolDetailResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  desktopCount: ").Append(DesktopCount).Append("\n");
            sb.Append("  desktopUsed: ").Append(DesktopUsed).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  product: ").Append(Product).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  imageName: ").Append(ImageName).Append("\n");
            sb.Append("  imageOsType: ").Append(ImageOsType).Append("\n");
            sb.Append("  imageOsVersion: ").Append(ImageOsVersion).Append("\n");
            sb.Append("  imageOsPlatform: ").Append(ImageOsPlatform).Append("\n");
            sb.Append("  imageProductCode: ").Append(ImageProductCode).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  disconnectedRetentionPeriod: ").Append(DisconnectedRetentionPeriod).Append("\n");
            sb.Append("  enableAutoscale: ").Append(EnableAutoscale).Append("\n");
            sb.Append("  autoscalePolicy: ").Append(AutoscalePolicy).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  inMaintenanceMode: ").Append(InMaintenanceMode).Append("\n");
            sb.Append("  desktopNamePolicyId: ").Append(DesktopNamePolicyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDesktopPoolDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDesktopPoolDetailResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.DesktopCount != input.DesktopCount || (this.DesktopCount != null && !this.DesktopCount.Equals(input.DesktopCount))) return false;
            if (this.DesktopUsed != input.DesktopUsed || (this.DesktopUsed != null && !this.DesktopUsed.Equals(input.DesktopUsed))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.Product != input.Product || (this.Product != null && !this.Product.Equals(input.Product))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.ImageName != input.ImageName || (this.ImageName != null && !this.ImageName.Equals(input.ImageName))) return false;
            if (this.ImageOsType != input.ImageOsType || (this.ImageOsType != null && !this.ImageOsType.Equals(input.ImageOsType))) return false;
            if (this.ImageOsVersion != input.ImageOsVersion || (this.ImageOsVersion != null && !this.ImageOsVersion.Equals(input.ImageOsVersion))) return false;
            if (this.ImageOsPlatform != input.ImageOsPlatform || (this.ImageOsPlatform != null && !this.ImageOsPlatform.Equals(input.ImageOsPlatform))) return false;
            if (this.ImageProductCode != input.ImageProductCode || (this.ImageProductCode != null && !this.ImageProductCode.Equals(input.ImageProductCode))) return false;
            if (this.RootVolume != input.RootVolume || (this.RootVolume != null && !this.RootVolume.Equals(input.RootVolume))) return false;
            if (this.DataVolumes != input.DataVolumes || (this.DataVolumes != null && input.DataVolumes != null && !this.DataVolumes.SequenceEqual(input.DataVolumes))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.DisconnectedRetentionPeriod != input.DisconnectedRetentionPeriod || (this.DisconnectedRetentionPeriod != null && !this.DisconnectedRetentionPeriod.Equals(input.DisconnectedRetentionPeriod))) return false;
            if (this.EnableAutoscale != input.EnableAutoscale || (this.EnableAutoscale != null && !this.EnableAutoscale.Equals(input.EnableAutoscale))) return false;
            if (this.AutoscalePolicy != input.AutoscalePolicy || (this.AutoscalePolicy != null && !this.AutoscalePolicy.Equals(input.AutoscalePolicy))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.InMaintenanceMode != input.InMaintenanceMode || (this.InMaintenanceMode != null && !this.InMaintenanceMode.Equals(input.InMaintenanceMode))) return false;
            if (this.DesktopNamePolicyId != input.DesktopNamePolicyId || (this.DesktopNamePolicyId != null && !this.DesktopNamePolicyId.Equals(input.DesktopNamePolicyId))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.DesktopCount != null) hashCode = hashCode * 59 + this.DesktopCount.GetHashCode();
                if (this.DesktopUsed != null) hashCode = hashCode * 59 + this.DesktopUsed.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.Product != null) hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.ImageName != null) hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.ImageOsType != null) hashCode = hashCode * 59 + this.ImageOsType.GetHashCode();
                if (this.ImageOsVersion != null) hashCode = hashCode * 59 + this.ImageOsVersion.GetHashCode();
                if (this.ImageOsPlatform != null) hashCode = hashCode * 59 + this.ImageOsPlatform.GetHashCode();
                if (this.ImageProductCode != null) hashCode = hashCode * 59 + this.ImageProductCode.GetHashCode();
                if (this.RootVolume != null) hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                if (this.DataVolumes != null) hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.DisconnectedRetentionPeriod != null) hashCode = hashCode * 59 + this.DisconnectedRetentionPeriod.GetHashCode();
                if (this.EnableAutoscale != null) hashCode = hashCode * 59 + this.EnableAutoscale.GetHashCode();
                if (this.AutoscalePolicy != null) hashCode = hashCode * 59 + this.AutoscalePolicy.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.InMaintenanceMode != null) hashCode = hashCode * 59 + this.InMaintenanceMode.GetHashCode();
                if (this.DesktopNamePolicyId != null) hashCode = hashCode * 59 + this.DesktopNamePolicyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
