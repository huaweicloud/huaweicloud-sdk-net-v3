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
    /// 镜像信息。
    /// </summary>
    public class Image 
    {

        /// <summary>
        /// 镜像id。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 镜像运行需要的最小磁盘容量，单位为GB。取值为40～1024GB。。
        /// </summary>
        [JsonProperty("min_disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinDisk { get; set; }

        /// <summary>
        /// 创建时间，格式为UTC时间，yyyy-MM-ddTHH:mm:ssZ。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 镜像文件的大小，单位为字节。
        /// </summary>
        [JsonProperty("image_size", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageSize { get; set; }

        /// <summary>
        /// 更新时间，格式为UTC时间，yyyy-MM-ddTHH:mm:ssZ。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 市场镜像的产品ID。
        /// </summary>
        [JsonProperty("product_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductCode { get; set; }

        /// <summary>
        /// 镜像支持的最大内存，单位为MB。取值可以参考云服务器规格限制，一般不设置。
        /// </summary>
        [JsonProperty("max_ram", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxRam { get; set; }

        /// <summary>
        /// 云市场资源类型编码。
        /// </summary>
        [JsonProperty("market_resource_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string MarketResourceTypeCode { get; set; }

        /// <summary>
        /// 镜像运行需要的最小内存，单位为MB。参数取值依据弹性云服务器的规格限制，默认设置为0。
        /// </summary>
        [JsonProperty("min_ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinRam { get; set; }

        /// <summary>
        /// 操作系统类型，目前取值Linux， Windows，Other。
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OsType { get; set; }

        /// <summary>
        /// 镜像类型，目前支持以下类型： 公共镜像：gold 私有镜像：private 共享镜像：shared。
        /// </summary>
        [JsonProperty("image_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageType { get; set; }

        /// <summary>
        /// 镜像标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 镜像平台分类。
        /// </summary>
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// 操作系统位数，一般取值为“32”或者“64”。
        /// </summary>
        [JsonProperty("os_bit", NullValueHandling = NullValueHandling.Ignore)]
        public string OsBit { get; set; }

        /// <summary>
        /// 操作系统具体版本。
        /// </summary>
        [JsonProperty("os_version", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        /// <summary>
        /// 镜像名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 云市场服务类型编码。
        /// </summary>
        [JsonProperty("market_service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string MarketServiceTypeCode { get; set; }

        /// <summary>
        /// 镜像状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Image {\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  minDisk: ").Append(MinDisk).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  imageSize: ").Append(ImageSize).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  productCode: ").Append(ProductCode).Append("\n");
            sb.Append("  maxRam: ").Append(MaxRam).Append("\n");
            sb.Append("  marketResourceTypeCode: ").Append(MarketResourceTypeCode).Append("\n");
            sb.Append("  minRam: ").Append(MinRam).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("  osBit: ").Append(OsBit).Append("\n");
            sb.Append("  osVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  marketServiceTypeCode: ").Append(MarketServiceTypeCode).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Image);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Image input)
        {
            if (input == null) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.MinDisk != input.MinDisk || (this.MinDisk != null && !this.MinDisk.Equals(input.MinDisk))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.ImageSize != input.ImageSize || (this.ImageSize != null && !this.ImageSize.Equals(input.ImageSize))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.ProductCode != input.ProductCode || (this.ProductCode != null && !this.ProductCode.Equals(input.ProductCode))) return false;
            if (this.MaxRam != input.MaxRam || (this.MaxRam != null && !this.MaxRam.Equals(input.MaxRam))) return false;
            if (this.MarketResourceTypeCode != input.MarketResourceTypeCode || (this.MarketResourceTypeCode != null && !this.MarketResourceTypeCode.Equals(input.MarketResourceTypeCode))) return false;
            if (this.MinRam != input.MinRam || (this.MinRam != null && !this.MinRam.Equals(input.MinRam))) return false;
            if (this.OsType != input.OsType || (this.OsType != null && !this.OsType.Equals(input.OsType))) return false;
            if (this.ImageType != input.ImageType || (this.ImageType != null && !this.ImageType.Equals(input.ImageType))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Platform != input.Platform || (this.Platform != null && !this.Platform.Equals(input.Platform))) return false;
            if (this.OsBit != input.OsBit || (this.OsBit != null && !this.OsBit.Equals(input.OsBit))) return false;
            if (this.OsVersion != input.OsVersion || (this.OsVersion != null && !this.OsVersion.Equals(input.OsVersion))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.MarketServiceTypeCode != input.MarketServiceTypeCode || (this.MarketServiceTypeCode != null && !this.MarketServiceTypeCode.Equals(input.MarketServiceTypeCode))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.MinDisk != null) hashCode = hashCode * 59 + this.MinDisk.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ImageSize != null) hashCode = hashCode * 59 + this.ImageSize.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.ProductCode != null) hashCode = hashCode * 59 + this.ProductCode.GetHashCode();
                if (this.MaxRam != null) hashCode = hashCode * 59 + this.MaxRam.GetHashCode();
                if (this.MarketResourceTypeCode != null) hashCode = hashCode * 59 + this.MarketResourceTypeCode.GetHashCode();
                if (this.MinRam != null) hashCode = hashCode * 59 + this.MinRam.GetHashCode();
                if (this.OsType != null) hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.ImageType != null) hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Platform != null) hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.OsBit != null) hashCode = hashCode * 59 + this.OsBit.GetHashCode();
                if (this.OsVersion != null) hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MarketServiceTypeCode != null) hashCode = hashCode * 59 + this.MarketServiceTypeCode.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
