using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductObject 
    {

        /// <summary>
        /// 产品ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 产品规格描述。
        /// </summary>
        [JsonProperty("product_spec_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductSpecDesc { get; set; }

        /// <summary>
        /// 产品目录编码。
        /// </summary>
        [JsonProperty("category_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 产品归属的云服务类型编码。
        /// </summary>
        [JsonProperty("product_owner_service", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductOwnerService { get; set; }

        /// <summary>
        /// 商务归属的资源类型编码。
        /// </summary>
        [JsonProperty("commercial_resource", NullValueHandling = NullValueHandling.Ignore)]
        public string CommercialResource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductObject {\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  productSpecDesc: ").Append(ProductSpecDesc).Append("\n");
            sb.Append("  categoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  productOwnerService: ").Append(ProductOwnerService).Append("\n");
            sb.Append("  commercialResource: ").Append(CommercialResource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductObject input)
        {
            if (input == null) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ProductSpecDesc != input.ProductSpecDesc || (this.ProductSpecDesc != null && !this.ProductSpecDesc.Equals(input.ProductSpecDesc))) return false;
            if (this.CategoryCode != input.CategoryCode || (this.CategoryCode != null && !this.CategoryCode.Equals(input.CategoryCode))) return false;
            if (this.ProductOwnerService != input.ProductOwnerService || (this.ProductOwnerService != null && !this.ProductOwnerService.Equals(input.ProductOwnerService))) return false;
            if (this.CommercialResource != input.CommercialResource || (this.CommercialResource != null && !this.CommercialResource.Equals(input.CommercialResource))) return false;

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
                if (this.ProductSpecDesc != null) hashCode = hashCode * 59 + this.ProductSpecDesc.GetHashCode();
                if (this.CategoryCode != null) hashCode = hashCode * 59 + this.CategoryCode.GetHashCode();
                if (this.ProductOwnerService != null) hashCode = hashCode * 59 + this.ProductOwnerService.GetHashCode();
                if (this.CommercialResource != null) hashCode = hashCode * 59 + this.CommercialResource.GetHashCode();
                return hashCode;
            }
        }
    }
}
