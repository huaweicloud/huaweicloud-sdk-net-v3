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
    public class ListInconsistentStaticsResponse : SdkResponse
    {

        /// <summary>
        /// 统计productID与桌面池套餐ID不一致的桌面数量
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

        /// <summary>
        /// 统计imageID与桌面池镜像ID不一致的桌面数量
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ImageId { get; set; }

        /// <summary>
        /// 统计数据盘数量与桌面池配置不一致的桌面数量
        /// </summary>
        [JsonProperty("disk_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiskNum { get; set; }

        /// <summary>
        /// 统计磁盘累加容量与桌面池配置不一致的桌面数量
        /// </summary>
        [JsonProperty("disk_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiskSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInconsistentStaticsResponse {\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  diskNum: ").Append(DiskNum).Append("\n");
            sb.Append("  diskSize: ").Append(DiskSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInconsistentStaticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInconsistentStaticsResponse input)
        {
            if (input == null) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.DiskNum != input.DiskNum || (this.DiskNum != null && !this.DiskNum.Equals(input.DiskNum))) return false;
            if (this.DiskSize != input.DiskSize || (this.DiskSize != null && !this.DiskSize.Equals(input.DiskSize))) return false;

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
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.DiskNum != null) hashCode = hashCode * 59 + this.DiskNum.GetHashCode();
                if (this.DiskSize != null) hashCode = hashCode * 59 + this.DiskSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
