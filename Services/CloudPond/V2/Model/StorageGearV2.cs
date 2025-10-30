using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V2.Model
{
    /// <summary>
    /// StorageGear接口返回层对象模型
    /// </summary>
    public class StorageGearV2 
    {

        /// <summary>
        /// 存储档位ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 存储阶梯值, 如：35TB
        /// </summary>
        [JsonProperty("gear", NullValueHandling = NullValueHandling.Ignore)]
        public int? Gear { get; set; }

        /// <summary>
        /// 存储类型. SAS:高IO,SSD:超高IO [VS_SMALL_CAP,VS_MEDIUM_CAP,VS_LARGE_CAP 视图存储](tag:cmcc)
        /// </summary>
        [JsonProperty("storage_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("product_info", NullValueHandling = NullValueHandling.Ignore)]
        public ProductInfo ProductInfo { get; set; }

        /// <summary>
        /// 部署地区
        /// </summary>
        [JsonProperty("zone_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sale_cycles", NullValueHandling = NullValueHandling.Ignore)]
        public List<SaleCycle> SaleCycles { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageGearV2 {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  gear: ").Append(Gear).Append("\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  productInfo: ").Append(ProductInfo).Append("\n");
            sb.Append("  zoneCode: ").Append(ZoneCode).Append("\n");
            sb.Append("  saleCycles: ").Append(SaleCycles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StorageGearV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StorageGearV2 input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Gear != input.Gear || (this.Gear != null && !this.Gear.Equals(input.Gear))) return false;
            if (this.StorageType != input.StorageType || (this.StorageType != null && !this.StorageType.Equals(input.StorageType))) return false;
            if (this.ProductInfo != input.ProductInfo || (this.ProductInfo != null && !this.ProductInfo.Equals(input.ProductInfo))) return false;
            if (this.ZoneCode != input.ZoneCode || (this.ZoneCode != null && !this.ZoneCode.Equals(input.ZoneCode))) return false;
            if (this.SaleCycles != input.SaleCycles || (this.SaleCycles != null && input.SaleCycles != null && !this.SaleCycles.SequenceEqual(input.SaleCycles))) return false;

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
                if (this.Gear != null) hashCode = hashCode * 59 + this.Gear.GetHashCode();
                if (this.StorageType != null) hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                if (this.ProductInfo != null) hashCode = hashCode * 59 + this.ProductInfo.GetHashCode();
                if (this.ZoneCode != null) hashCode = hashCode * 59 + this.ZoneCode.GetHashCode();
                if (this.SaleCycles != null) hashCode = hashCode * 59 + this.SaleCycles.GetHashCode();
                return hashCode;
            }
        }
    }
}
