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
    /// 
    /// </summary>
    public class ImageInfo 
    {

        /// <summary>
        /// 镜像ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 镜像类型，目前支持以下类型： 公共镜像：gold 私有镜像：private。
        /// </summary>
        [JsonProperty("image_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageType { get; set; }

        /// <summary>
        /// 操作系统类型，目前取值Linux， Windows，Other。
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OsType { get; set; }

        /// <summary>
        /// 操作系统架构，目前取值arm，x86。
        /// </summary>
        [JsonProperty("architecture", NullValueHandling = NullValueHandling.Ignore)]
        public string Architecture { get; set; }

        /// <summary>
        /// 操作系统具体版本。
        /// </summary>
        [JsonProperty("os_version", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        /// <summary>
        /// 镜像格式，目前支持vhd，raw，qcow2，zvhd2格式。
        /// </summary>
        [JsonProperty("disk_format", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskFormat { get; set; }

        /// <summary>
        /// 镜像名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 镜像运行需要的最小内存，单位为MB。参数取值依据弹性云服务器的规格限制，一般设置为0。
        /// </summary>
        [JsonProperty("min_ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinRam { get; set; }

        /// <summary>
        /// 镜像运行需要的最小磁盘，单位为GB 。取值为40～1024GB。
        /// </summary>
        [JsonProperty("min_disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinDisk { get; set; }

        /// <summary>
        /// 镜像的产品编码。
        /// </summary>
        [JsonProperty("product_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductCode { get; set; }

        /// <summary>
        /// 创建时间。格式为UTC时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  architecture: ").Append(Architecture).Append("\n");
            sb.Append("  osVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  diskFormat: ").Append(DiskFormat).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  minRam: ").Append(MinRam).Append("\n");
            sb.Append("  minDisk: ").Append(MinDisk).Append("\n");
            sb.Append("  productCode: ").Append(ProductCode).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ImageType != input.ImageType || (this.ImageType != null && !this.ImageType.Equals(input.ImageType))) return false;
            if (this.OsType != input.OsType || (this.OsType != null && !this.OsType.Equals(input.OsType))) return false;
            if (this.Architecture != input.Architecture || (this.Architecture != null && !this.Architecture.Equals(input.Architecture))) return false;
            if (this.OsVersion != input.OsVersion || (this.OsVersion != null && !this.OsVersion.Equals(input.OsVersion))) return false;
            if (this.DiskFormat != input.DiskFormat || (this.DiskFormat != null && !this.DiskFormat.Equals(input.DiskFormat))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.MinRam != input.MinRam || (this.MinRam != null && !this.MinRam.Equals(input.MinRam))) return false;
            if (this.MinDisk != input.MinDisk || (this.MinDisk != null && !this.MinDisk.Equals(input.MinDisk))) return false;
            if (this.ProductCode != input.ProductCode || (this.ProductCode != null && !this.ProductCode.Equals(input.ProductCode))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;

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
                if (this.ImageType != null) hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.OsType != null) hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.Architecture != null) hashCode = hashCode * 59 + this.Architecture.GetHashCode();
                if (this.OsVersion != null) hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.DiskFormat != null) hashCode = hashCode * 59 + this.DiskFormat.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MinRam != null) hashCode = hashCode * 59 + this.MinRam.GetHashCode();
                if (this.MinDisk != null) hashCode = hashCode * 59 + this.MinDisk.GetHashCode();
                if (this.ProductCode != null) hashCode = hashCode * 59 + this.ProductCode.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
