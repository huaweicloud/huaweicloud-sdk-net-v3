using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V1.Model
{
    /// <summary>
    /// 存储池
    /// </summary>
    public class StoragePool 
    {

        /// <summary>
        /// 机柜ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 存储池名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 边缘小站ID
        /// </summary>
        [JsonProperty("edge_site_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EdgeSiteId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("storage_type", NullValueHandling = NullValueHandling.Ignore)]
        public StorageType? StorageType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StoragePoolStatus? Status { get; set; }

        /// <summary>
        /// 存储池大小。 当前购买的存储容量。
        /// </summary>
        [JsonProperty("assigned_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? AssignedSize { get; set; }

        /// <summary>
        /// 资源规格编码
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("product_info", NullValueHandling = NullValueHandling.Ignore)]
        public ProductInfo ProductInfo { get; set; }

        /// <summary>
        /// 总容量
        /// </summary>
        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Capacity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("market_options", NullValueHandling = NullValueHandling.Ignore)]
        public MarketOptions MarketOptions { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [JsonProperty("effected_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EffectedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoragePool {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  edgeSiteId: ").Append(EdgeSiteId).Append("\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  assignedSize: ").Append(AssignedSize).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("  productInfo: ").Append(ProductInfo).Append("\n");
            sb.Append("  capacity: ").Append(Capacity).Append("\n");
            sb.Append("  marketOptions: ").Append(MarketOptions).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  effectedAt: ").Append(EffectedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StoragePool);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StoragePool input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.EdgeSiteId != input.EdgeSiteId || (this.EdgeSiteId != null && !this.EdgeSiteId.Equals(input.EdgeSiteId))) return false;
            if (this.StorageType != input.StorageType || (this.StorageType != null && !this.StorageType.Equals(input.StorageType))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.AssignedSize != input.AssignedSize || (this.AssignedSize != null && !this.AssignedSize.Equals(input.AssignedSize))) return false;
            if (this.ResourceSpecCode != input.ResourceSpecCode || (this.ResourceSpecCode != null && !this.ResourceSpecCode.Equals(input.ResourceSpecCode))) return false;
            if (this.ProductInfo != input.ProductInfo || (this.ProductInfo != null && !this.ProductInfo.Equals(input.ProductInfo))) return false;
            if (this.Capacity != input.Capacity || (this.Capacity != null && !this.Capacity.Equals(input.Capacity))) return false;
            if (this.MarketOptions != input.MarketOptions || (this.MarketOptions != null && !this.MarketOptions.Equals(input.MarketOptions))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.EffectedAt != input.EffectedAt || (this.EffectedAt != null && !this.EffectedAt.Equals(input.EffectedAt))) return false;

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
                if (this.EdgeSiteId != null) hashCode = hashCode * 59 + this.EdgeSiteId.GetHashCode();
                if (this.StorageType != null) hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AssignedSize != null) hashCode = hashCode * 59 + this.AssignedSize.GetHashCode();
                if (this.ResourceSpecCode != null) hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.ProductInfo != null) hashCode = hashCode * 59 + this.ProductInfo.GetHashCode();
                if (this.Capacity != null) hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.MarketOptions != null) hashCode = hashCode * 59 + this.MarketOptions.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.EffectedAt != null) hashCode = hashCode * 59 + this.EffectedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
