using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 创建服务器组请求。
    /// </summary>
    public class CreateServerGroupReq 
    {

        /// <summary>
        /// 服务器组名称，名称需满足如下规则: 1. 由中文，英文大小写，数字，_-组成，不能有空格。 2. 长度范围1~64个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 服务器组关联的镜像ID，用于创建对应组下的云服务器。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 服务器组的镜像产品ID，当镜像为云市场镜像时，该字段必填。
        /// </summary>
        [JsonProperty("image_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_type", NullValueHandling = NullValueHandling.Ignore)]
        public ImageTypeEnum ImageType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public OsTypeEnum OsType { get; set; }
        /// <summary>
        /// 服务器组描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("route_policy", NullValueHandling = NullValueHandling.Ignore)]
        public RoutePolicy RoutePolicy { get; set; }

        /// <summary>
        /// 产品ID。 &gt; - 获取方式详见产品套餐管理ListProduct：\&quot;GET  /v1/{project_id}/product\&quot;。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 规格ID。
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// 虚拟私有云ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 网卡对应的子网ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("system_disk_type", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeType SystemDiskType { get; set; }
        /// <summary>
        /// 磁盘容量，单位GB。
        /// </summary>
        [JsonProperty("system_disk_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// 默认组织名称。
        /// </summary>
        [JsonProperty("ou_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OuName { get; set; }

        /// <summary>
        /// 云服务器系统盘对应的存储池的ID。
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 可用分区。 &gt; - 将服务创建到指定的可用分区，如果不指定则使用系统随机的可用分区。 &gt; - 获取方式详见可用区管理ListAvailabilityZone：\&quot;GET  /v1/{project_id}/availability-zone\&quot;。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ip_virtual", NullValueHandling = NullValueHandling.Ignore)]
        public IpVirtual IpVirtual { get; set; }

        /// <summary>
        /// 是否为vdi单会话模式。
        /// </summary>
        [JsonProperty("is_vdi", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVdi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("app_type", NullValueHandling = NullValueHandling.Ignore)]
        public AppTypeEnum? AppType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extra_session_type", NullValueHandling = NullValueHandling.Ignore)]
        public ExtraSessionTypeEnum? ExtraSessionType { get; set; }

        /// <summary>
        /// 付费会话数，单位/个。
        /// </summary>
        [JsonProperty("extra_session_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExtraSessionSize { get; set; }

        /// <summary>
        /// 标签信息，最多包含20个key,不允许重复。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TmsTag> Tags { get; set; }

        /// <summary>
        /// 企业项目ID,仅企业项目需配置(字段为空或者0表示使用默认default企业项目)。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 主服务器组id,绑定主服务器组，则创建的是备服务器。
        /// </summary>
        [JsonProperty("primary_server_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryServerGroupId { get; set; }

        /// <summary>
        /// 是否启用服务器组。
        /// </summary>
        [JsonProperty("server_group_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ServerGroupStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateServerGroupReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  imageProductId: ").Append(ImageProductId).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  routePolicy: ").Append(RoutePolicy).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  systemDiskType: ").Append(SystemDiskType).Append("\n");
            sb.Append("  systemDiskSize: ").Append(SystemDiskSize).Append("\n");
            sb.Append("  ouName: ").Append(OuName).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  ipVirtual: ").Append(IpVirtual).Append("\n");
            sb.Append("  isVdi: ").Append(IsVdi).Append("\n");
            sb.Append("  appType: ").Append(AppType).Append("\n");
            sb.Append("  extraSessionType: ").Append(ExtraSessionType).Append("\n");
            sb.Append("  extraSessionSize: ").Append(ExtraSessionSize).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  primaryServerGroupId: ").Append(PrimaryServerGroupId).Append("\n");
            sb.Append("  serverGroupStatus: ").Append(ServerGroupStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateServerGroupReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateServerGroupReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.ImageProductId != input.ImageProductId || (this.ImageProductId != null && !this.ImageProductId.Equals(input.ImageProductId))) return false;
            if (this.ImageType != input.ImageType) return false;
            if (this.OsType != input.OsType) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.RoutePolicy != input.RoutePolicy || (this.RoutePolicy != null && !this.RoutePolicy.Equals(input.RoutePolicy))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.SystemDiskType != input.SystemDiskType) return false;
            if (this.SystemDiskSize != input.SystemDiskSize || (this.SystemDiskSize != null && !this.SystemDiskSize.Equals(input.SystemDiskSize))) return false;
            if (this.OuName != input.OuName || (this.OuName != null && !this.OuName.Equals(input.OuName))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.IpVirtual != input.IpVirtual || (this.IpVirtual != null && !this.IpVirtual.Equals(input.IpVirtual))) return false;
            if (this.IsVdi != input.IsVdi || (this.IsVdi != null && !this.IsVdi.Equals(input.IsVdi))) return false;
            if (this.AppType != input.AppType || (this.AppType != null && !this.AppType.Equals(input.AppType))) return false;
            if (this.ExtraSessionType != input.ExtraSessionType || (this.ExtraSessionType != null && !this.ExtraSessionType.Equals(input.ExtraSessionType))) return false;
            if (this.ExtraSessionSize != input.ExtraSessionSize || (this.ExtraSessionSize != null && !this.ExtraSessionSize.Equals(input.ExtraSessionSize))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.PrimaryServerGroupId != input.PrimaryServerGroupId || (this.PrimaryServerGroupId != null && !this.PrimaryServerGroupId.Equals(input.PrimaryServerGroupId))) return false;
            if (this.ServerGroupStatus != input.ServerGroupStatus || (this.ServerGroupStatus != null && !this.ServerGroupStatus.Equals(input.ServerGroupStatus))) return false;

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
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.ImageProductId != null) hashCode = hashCode * 59 + this.ImageProductId.GetHashCode();
                hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RoutePolicy != null) hashCode = hashCode * 59 + this.RoutePolicy.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                hashCode = hashCode * 59 + this.SystemDiskType.GetHashCode();
                if (this.SystemDiskSize != null) hashCode = hashCode * 59 + this.SystemDiskSize.GetHashCode();
                if (this.OuName != null) hashCode = hashCode * 59 + this.OuName.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.IpVirtual != null) hashCode = hashCode * 59 + this.IpVirtual.GetHashCode();
                if (this.IsVdi != null) hashCode = hashCode * 59 + this.IsVdi.GetHashCode();
                if (this.AppType != null) hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.ExtraSessionType != null) hashCode = hashCode * 59 + this.ExtraSessionType.GetHashCode();
                if (this.ExtraSessionSize != null) hashCode = hashCode * 59 + this.ExtraSessionSize.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.PrimaryServerGroupId != null) hashCode = hashCode * 59 + this.PrimaryServerGroupId.GetHashCode();
                if (this.ServerGroupStatus != null) hashCode = hashCode * 59 + this.ServerGroupStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
