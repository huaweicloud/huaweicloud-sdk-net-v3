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
    /// 机柜
    /// </summary>
    public class Rack 
    {

        /// <summary>
        /// 机柜ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 机柜名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 边缘小站ID
        /// </summary>
        [JsonProperty("edge_site_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EdgeSiteId { get; set; }

        /// <summary>
        /// 机柜目录ID
        /// </summary>
        [JsonProperty("rack_category_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RackCategoryId { get; set; }

        /// <summary>
        /// 机柜类型
        /// </summary>
        [JsonProperty("rack_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RackType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public RackStatus? Status { get; set; }

        /// <summary>
        /// 已分配存储容量
        /// </summary>
        [JsonProperty("storage_assigned_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? StorageAssignedSize { get; set; }

        /// <summary>
        /// 机柜描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 机柜SN号
        /// </summary>
        [JsonProperty("rack_sn_no", NullValueHandling = NullValueHandling.Ignore)]
        public string RackSnNo { get; set; }

        /// <summary>
        /// 机柜位置号
        /// </summary>
        [JsonProperty("rack_location_no", NullValueHandling = NullValueHandling.Ignore)]
        public string RackLocationNo { get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("market_options", NullValueHandling = NullValueHandling.Ignore)]
        public MarketOptions MarketOptions { get; set; }

        /// <summary>
        /// 计算单元信息
        /// </summary>
        [JsonProperty("compute_unit", NullValueHandling = NullValueHandling.Ignore)]
        public List<ComputeSpec> ComputeUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("storage_unit", NullValueHandling = NullValueHandling.Ignore)]
        public StorageUnit StorageUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rack_info", NullValueHandling = NullValueHandling.Ignore)]
        public RackInfo RackInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("product_info", NullValueHandling = NullValueHandling.Ignore)]
        public ProductInfo ProductInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rack {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  edgeSiteId: ").Append(EdgeSiteId).Append("\n");
            sb.Append("  rackCategoryId: ").Append(RackCategoryId).Append("\n");
            sb.Append("  rackType: ").Append(RackType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  storageAssignedSize: ").Append(StorageAssignedSize).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  rackSnNo: ").Append(RackSnNo).Append("\n");
            sb.Append("  rackLocationNo: ").Append(RackLocationNo).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  effectedAt: ").Append(EffectedAt).Append("\n");
            sb.Append("  marketOptions: ").Append(MarketOptions).Append("\n");
            sb.Append("  computeUnit: ").Append(ComputeUnit).Append("\n");
            sb.Append("  storageUnit: ").Append(StorageUnit).Append("\n");
            sb.Append("  rackInfo: ").Append(RackInfo).Append("\n");
            sb.Append("  productInfo: ").Append(ProductInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Rack);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Rack input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.EdgeSiteId != input.EdgeSiteId || (this.EdgeSiteId != null && !this.EdgeSiteId.Equals(input.EdgeSiteId))) return false;
            if (this.RackCategoryId != input.RackCategoryId || (this.RackCategoryId != null && !this.RackCategoryId.Equals(input.RackCategoryId))) return false;
            if (this.RackType != input.RackType || (this.RackType != null && !this.RackType.Equals(input.RackType))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.StorageAssignedSize != input.StorageAssignedSize || (this.StorageAssignedSize != null && !this.StorageAssignedSize.Equals(input.StorageAssignedSize))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.RackSnNo != input.RackSnNo || (this.RackSnNo != null && !this.RackSnNo.Equals(input.RackSnNo))) return false;
            if (this.RackLocationNo != input.RackLocationNo || (this.RackLocationNo != null && !this.RackLocationNo.Equals(input.RackLocationNo))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.EffectedAt != input.EffectedAt || (this.EffectedAt != null && !this.EffectedAt.Equals(input.EffectedAt))) return false;
            if (this.MarketOptions != input.MarketOptions || (this.MarketOptions != null && !this.MarketOptions.Equals(input.MarketOptions))) return false;
            if (this.ComputeUnit != input.ComputeUnit || (this.ComputeUnit != null && input.ComputeUnit != null && !this.ComputeUnit.SequenceEqual(input.ComputeUnit))) return false;
            if (this.StorageUnit != input.StorageUnit || (this.StorageUnit != null && !this.StorageUnit.Equals(input.StorageUnit))) return false;
            if (this.RackInfo != input.RackInfo || (this.RackInfo != null && !this.RackInfo.Equals(input.RackInfo))) return false;
            if (this.ProductInfo != input.ProductInfo || (this.ProductInfo != null && !this.ProductInfo.Equals(input.ProductInfo))) return false;

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
                if (this.RackCategoryId != null) hashCode = hashCode * 59 + this.RackCategoryId.GetHashCode();
                if (this.RackType != null) hashCode = hashCode * 59 + this.RackType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StorageAssignedSize != null) hashCode = hashCode * 59 + this.StorageAssignedSize.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RackSnNo != null) hashCode = hashCode * 59 + this.RackSnNo.GetHashCode();
                if (this.RackLocationNo != null) hashCode = hashCode * 59 + this.RackLocationNo.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.EffectedAt != null) hashCode = hashCode * 59 + this.EffectedAt.GetHashCode();
                if (this.MarketOptions != null) hashCode = hashCode * 59 + this.MarketOptions.GetHashCode();
                if (this.ComputeUnit != null) hashCode = hashCode * 59 + this.ComputeUnit.GetHashCode();
                if (this.StorageUnit != null) hashCode = hashCode * 59 + this.StorageUnit.GetHashCode();
                if (this.RackInfo != null) hashCode = hashCode * 59 + this.RackInfo.GetHashCode();
                if (this.ProductInfo != null) hashCode = hashCode * 59 + this.ProductInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
