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
    /// 更新服务器组请求。
    /// </summary>
    public class UpdateServerGroupReq 
    {

        /// <summary>
        /// 服务器组名称，名称需满足如下规则: 1. 由中文，英文大小写，数字，_-组成，不能有空格。 2. 长度范围1~64个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("storage_mount_policy", NullValueHandling = NullValueHandling.Ignore)]
        public StorageFolderMountType? StorageMountPolicy { get; set; }

        /// <summary>
        /// 服务器组关联的镜像ID，更新镜像ID只对组下新创建的云服务器生效。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 服务器组的镜像的productId。
        /// </summary>
        [JsonProperty("image_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_type", NullValueHandling = NullValueHandling.Ignore)]
        public ImageTypeEnum? ImageType { get; set; }

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
        /// 默认组织名称。
        /// </summary>
        [JsonProperty("ou_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OuName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("app_type", NullValueHandling = NullValueHandling.Ignore)]
        public AppTypeEnum? AppType { get; set; }

        /// <summary>
        /// 服务器是否处于禁用状态： * &#x60;true&#x60; - 启用状态 * &#x60;false&#x60; - 禁用状态
        /// </summary>
        [JsonProperty("server_group_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ServerGroupStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateServerGroupReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  routePolicy: ").Append(RoutePolicy).Append("\n");
            sb.Append("  storageMountPolicy: ").Append(StorageMountPolicy).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  imageProductId: ").Append(ImageProductId).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  systemDiskType: ").Append(SystemDiskType).Append("\n");
            sb.Append("  systemDiskSize: ").Append(SystemDiskSize).Append("\n");
            sb.Append("  ouName: ").Append(OuName).Append("\n");
            sb.Append("  appType: ").Append(AppType).Append("\n");
            sb.Append("  serverGroupStatus: ").Append(ServerGroupStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateServerGroupReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateServerGroupReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.RoutePolicy != input.RoutePolicy || (this.RoutePolicy != null && !this.RoutePolicy.Equals(input.RoutePolicy))) return false;
            if (this.StorageMountPolicy != input.StorageMountPolicy || (this.StorageMountPolicy != null && !this.StorageMountPolicy.Equals(input.StorageMountPolicy))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.ImageProductId != input.ImageProductId || (this.ImageProductId != null && !this.ImageProductId.Equals(input.ImageProductId))) return false;
            if (this.ImageType != input.ImageType || (this.ImageType != null && !this.ImageType.Equals(input.ImageType))) return false;
            if (this.SystemDiskType != input.SystemDiskType || (this.SystemDiskType != null && !this.SystemDiskType.Equals(input.SystemDiskType))) return false;
            if (this.SystemDiskSize != input.SystemDiskSize || (this.SystemDiskSize != null && !this.SystemDiskSize.Equals(input.SystemDiskSize))) return false;
            if (this.OuName != input.OuName || (this.OuName != null && !this.OuName.Equals(input.OuName))) return false;
            if (this.AppType != input.AppType || (this.AppType != null && !this.AppType.Equals(input.AppType))) return false;
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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RoutePolicy != null) hashCode = hashCode * 59 + this.RoutePolicy.GetHashCode();
                if (this.StorageMountPolicy != null) hashCode = hashCode * 59 + this.StorageMountPolicy.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.ImageProductId != null) hashCode = hashCode * 59 + this.ImageProductId.GetHashCode();
                if (this.ImageType != null) hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.SystemDiskType != null) hashCode = hashCode * 59 + this.SystemDiskType.GetHashCode();
                if (this.SystemDiskSize != null) hashCode = hashCode * 59 + this.SystemDiskSize.GetHashCode();
                if (this.OuName != null) hashCode = hashCode * 59 + this.OuName.GetHashCode();
                if (this.AppType != null) hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.ServerGroupStatus != null) hashCode = hashCode * 59 + this.ServerGroupStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
