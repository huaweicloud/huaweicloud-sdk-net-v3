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
    /// 创建专享主机请求体。
    /// </summary>
    public class CreateExclusiveHostsReq 
    {

        /// <summary>
        /// 可用分区。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 追加桌面数量。
        /// </summary>
        [JsonProperty("apply_desktop_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? ApplyDesktopQuantity { get; set; }

        /// <summary>
        /// 购买数量。
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// 订单ID。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 产品套餐ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 镜像盘列表。
        /// </summary>
        [JsonProperty("image_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Volume> ImageVolumes { get; set; }

        /// <summary>
        /// 企业项目ID，默认\&quot;0\&quot;
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 存储盘列表。
        /// </summary>
        [JsonProperty("memory_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Volume> MemoryVolumes { get; set; }

        /// <summary>
        /// vpc id。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网id。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resize_exclusive_lites", NullValueHandling = NullValueHandling.Ignore)]
        public ResizeExclusiveLitesReq ResizeExclusiveLites { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateExclusiveHostsReq {\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  applyDesktopQuantity: ").Append(ApplyDesktopQuantity).Append("\n");
            sb.Append("  quantity: ").Append(Quantity).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  imageVolumes: ").Append(ImageVolumes).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  memoryVolumes: ").Append(MemoryVolumes).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  resizeExclusiveLites: ").Append(ResizeExclusiveLites).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateExclusiveHostsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateExclusiveHostsReq input)
        {
            if (input == null) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ApplyDesktopQuantity != input.ApplyDesktopQuantity || (this.ApplyDesktopQuantity != null && !this.ApplyDesktopQuantity.Equals(input.ApplyDesktopQuantity))) return false;
            if (this.Quantity != input.Quantity || (this.Quantity != null && !this.Quantity.Equals(input.Quantity))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ImageVolumes != input.ImageVolumes || (this.ImageVolumes != null && input.ImageVolumes != null && !this.ImageVolumes.SequenceEqual(input.ImageVolumes))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.MemoryVolumes != input.MemoryVolumes || (this.MemoryVolumes != null && input.MemoryVolumes != null && !this.MemoryVolumes.SequenceEqual(input.MemoryVolumes))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.ResizeExclusiveLites != input.ResizeExclusiveLites || (this.ResizeExclusiveLites != null && !this.ResizeExclusiveLites.Equals(input.ResizeExclusiveLites))) return false;

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
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ApplyDesktopQuantity != null) hashCode = hashCode * 59 + this.ApplyDesktopQuantity.GetHashCode();
                if (this.Quantity != null) hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ImageVolumes != null) hashCode = hashCode * 59 + this.ImageVolumes.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.MemoryVolumes != null) hashCode = hashCode * 59 + this.MemoryVolumes.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.ResizeExclusiveLites != null) hashCode = hashCode * 59 + this.ResizeExclusiveLites.GetHashCode();
                return hashCode;
            }
        }
    }
}
