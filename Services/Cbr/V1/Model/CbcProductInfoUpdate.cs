using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CbcProductInfoUpdate 
    {

        /// <summary>
        /// 产品标识，通过订购询价接口获得，长度限制：1-64，只能由字母、数字、“_”、“-”组成。。
        /// </summary>
        [JsonProperty("productId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 资源容量大小，取值范围：10-10485760
        /// </summary>
        [JsonProperty("resourceSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceSize { get; set; }

        /// <summary>
        /// 资源容量度量标识，枚举值17：GB
        /// </summary>
        [JsonProperty("resourceSizeMeasureId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceSizeMeasureId { get; set; }

        /// <summary>
        /// 用户购买云服务产品的资源规格 Enum:  - vault.backup.server.normal - vault.backup.turbo.normal - vault.backup.database.normal - vault.backup.volume.normal - vault.backup.rds.normal - vault.replication.server.normal - vault.hybrid.server.normal
        /// </summary>
        [JsonProperty("resourceSpecCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CbcProductInfoUpdate {\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  resourceSize: ").Append(ResourceSize).Append("\n");
            sb.Append("  resourceSizeMeasureId: ").Append(ResourceSizeMeasureId).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CbcProductInfoUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CbcProductInfoUpdate input)
        {
            if (input == null) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ResourceSize != input.ResourceSize || (this.ResourceSize != null && !this.ResourceSize.Equals(input.ResourceSize))) return false;
            if (this.ResourceSizeMeasureId != input.ResourceSizeMeasureId || (this.ResourceSizeMeasureId != null && !this.ResourceSizeMeasureId.Equals(input.ResourceSizeMeasureId))) return false;
            if (this.ResourceSpecCode != input.ResourceSpecCode || (this.ResourceSpecCode != null && !this.ResourceSpecCode.Equals(input.ResourceSpecCode))) return false;

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
                if (this.ResourceSize != null) hashCode = hashCode * 59 + this.ResourceSize.GetHashCode();
                if (this.ResourceSizeMeasureId != null) hashCode = hashCode * 59 + this.ResourceSizeMeasureId.GetHashCode();
                if (this.ResourceSpecCode != null) hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
