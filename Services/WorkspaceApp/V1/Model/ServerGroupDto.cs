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
    /// 分页查询分组信息。
    /// </summary>
    public class ServerGroupDto 
    {

        /// <summary>
        /// 服务器组的唯一标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 服务器组名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 服务器组描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 服务器组关联的镜像ID，用于创建对应组下的云服务器。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public OsTypeEnum? OsType { get; set; }

        /// <summary>
        /// 产品id。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 网卡对应的子网ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("system_disk_type", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeType? SystemDiskType { get; set; }

        /// <summary>
        /// 磁盘容量，单位GB。
        /// </summary>
        [JsonProperty("system_disk_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// 是否为vdi单会话模式。
        /// </summary>
        [JsonProperty("is_vdi", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVdi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extra_session_type", NullValueHandling = NullValueHandling.Ignore)]
        public ExtraSessionTypeEnum? ExtraSessionType { get; set; }

        /// <summary>
        /// 付费会话个数。
        /// </summary>
        [JsonProperty("extra_session_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExtraSessionSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("app_type", NullValueHandling = NullValueHandling.Ignore)]
        public AppTypeEnum? AppType { get; set; }

        /// <summary>
        /// 服务器组创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 服务器组更新时间。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("storage_mount_policy", NullValueHandling = NullValueHandling.Ignore)]
        public StorageFolderMountType? StorageMountPolicy { get; set; }

        /// <summary>
        /// 企业项目ID(0表示默认企业项目Id)。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 主服务器组id列表。
        /// </summary>
        [JsonProperty("primary_server_group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PrimaryServerGroupIds { get; set; }

        /// <summary>
        /// 备服务器组id列表。
        /// </summary>
        [JsonProperty("secondary_server_group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecondaryServerGroupIds { get; set; }

        /// <summary>
        /// 服务器是否处于启用状态，true表示处于启用状态 false表示处于禁用状态。
        /// </summary>
        [JsonProperty("server_group_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ServerGroupStatus { get; set; }

        /// <summary>
        /// 站点类型 - CENTER/IES。
        /// </summary>
        [JsonProperty("site_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteType { get; set; }

        /// <summary>
        /// 站点id。
        /// </summary>
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteId { get; set; }

        /// <summary>
        /// 关联应用组的总数量。
        /// </summary>
        [JsonProperty("app_group_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppGroupCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerGroupDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  systemDiskType: ").Append(SystemDiskType).Append("\n");
            sb.Append("  systemDiskSize: ").Append(SystemDiskSize).Append("\n");
            sb.Append("  isVdi: ").Append(IsVdi).Append("\n");
            sb.Append("  extraSessionType: ").Append(ExtraSessionType).Append("\n");
            sb.Append("  extraSessionSize: ").Append(ExtraSessionSize).Append("\n");
            sb.Append("  appType: ").Append(AppType).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  storageMountPolicy: ").Append(StorageMountPolicy).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  primaryServerGroupIds: ").Append(PrimaryServerGroupIds).Append("\n");
            sb.Append("  secondaryServerGroupIds: ").Append(SecondaryServerGroupIds).Append("\n");
            sb.Append("  serverGroupStatus: ").Append(ServerGroupStatus).Append("\n");
            sb.Append("  siteType: ").Append(SiteType).Append("\n");
            sb.Append("  siteId: ").Append(SiteId).Append("\n");
            sb.Append("  appGroupCount: ").Append(AppGroupCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerGroupDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerGroupDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.OsType != input.OsType || (this.OsType != null && !this.OsType.Equals(input.OsType))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.SystemDiskType != input.SystemDiskType || (this.SystemDiskType != null && !this.SystemDiskType.Equals(input.SystemDiskType))) return false;
            if (this.SystemDiskSize != input.SystemDiskSize || (this.SystemDiskSize != null && !this.SystemDiskSize.Equals(input.SystemDiskSize))) return false;
            if (this.IsVdi != input.IsVdi || (this.IsVdi != null && !this.IsVdi.Equals(input.IsVdi))) return false;
            if (this.ExtraSessionType != input.ExtraSessionType || (this.ExtraSessionType != null && !this.ExtraSessionType.Equals(input.ExtraSessionType))) return false;
            if (this.ExtraSessionSize != input.ExtraSessionSize || (this.ExtraSessionSize != null && !this.ExtraSessionSize.Equals(input.ExtraSessionSize))) return false;
            if (this.AppType != input.AppType || (this.AppType != null && !this.AppType.Equals(input.AppType))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.StorageMountPolicy != input.StorageMountPolicy || (this.StorageMountPolicy != null && !this.StorageMountPolicy.Equals(input.StorageMountPolicy))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.PrimaryServerGroupIds != input.PrimaryServerGroupIds || (this.PrimaryServerGroupIds != null && input.PrimaryServerGroupIds != null && !this.PrimaryServerGroupIds.SequenceEqual(input.PrimaryServerGroupIds))) return false;
            if (this.SecondaryServerGroupIds != input.SecondaryServerGroupIds || (this.SecondaryServerGroupIds != null && input.SecondaryServerGroupIds != null && !this.SecondaryServerGroupIds.SequenceEqual(input.SecondaryServerGroupIds))) return false;
            if (this.ServerGroupStatus != input.ServerGroupStatus || (this.ServerGroupStatus != null && !this.ServerGroupStatus.Equals(input.ServerGroupStatus))) return false;
            if (this.SiteType != input.SiteType || (this.SiteType != null && !this.SiteType.Equals(input.SiteType))) return false;
            if (this.SiteId != input.SiteId || (this.SiteId != null && !this.SiteId.Equals(input.SiteId))) return false;
            if (this.AppGroupCount != input.AppGroupCount || (this.AppGroupCount != null && !this.AppGroupCount.Equals(input.AppGroupCount))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.OsType != null) hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SystemDiskType != null) hashCode = hashCode * 59 + this.SystemDiskType.GetHashCode();
                if (this.SystemDiskSize != null) hashCode = hashCode * 59 + this.SystemDiskSize.GetHashCode();
                if (this.IsVdi != null) hashCode = hashCode * 59 + this.IsVdi.GetHashCode();
                if (this.ExtraSessionType != null) hashCode = hashCode * 59 + this.ExtraSessionType.GetHashCode();
                if (this.ExtraSessionSize != null) hashCode = hashCode * 59 + this.ExtraSessionSize.GetHashCode();
                if (this.AppType != null) hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.StorageMountPolicy != null) hashCode = hashCode * 59 + this.StorageMountPolicy.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.PrimaryServerGroupIds != null) hashCode = hashCode * 59 + this.PrimaryServerGroupIds.GetHashCode();
                if (this.SecondaryServerGroupIds != null) hashCode = hashCode * 59 + this.SecondaryServerGroupIds.GetHashCode();
                if (this.ServerGroupStatus != null) hashCode = hashCode * 59 + this.ServerGroupStatus.GetHashCode();
                if (this.SiteType != null) hashCode = hashCode * 59 + this.SiteType.GetHashCode();
                if (this.SiteId != null) hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                if (this.AppGroupCount != null) hashCode = hashCode * 59 + this.AppGroupCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
