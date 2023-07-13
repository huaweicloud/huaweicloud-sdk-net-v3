using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowChargeModesRequest 
    {

        /// <summary>
        /// 加速类型，base（基础加速）
        /// </summary>
        [SDKProperty("product_type", IsQuery = true)]
        [JsonProperty("product_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductType { get; set; }

        /// <summary>
        /// 查询计费模式状态，active（已生效），upcoming（待生效），不传默认为active(已生效)
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 服务区域，mainland_china（国内），outside_mainland_china（海外），不传默认为mainland_china(国内)
        /// </summary>
        [SDKProperty("service_area", IsQuery = true)]
        [JsonProperty("service_area", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceArea { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowChargeModesRequest {\n");
            sb.Append("  productType: ").Append(ProductType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  serviceArea: ").Append(ServiceArea).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowChargeModesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowChargeModesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductType == input.ProductType ||
                    (this.ProductType != null &&
                    this.ProductType.Equals(input.ProductType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ServiceArea == input.ServiceArea ||
                    (this.ServiceArea != null &&
                    this.ServiceArea.Equals(input.ServiceArea))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ProductType != null)
                    hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ServiceArea != null)
                    hashCode = hashCode * 59 + this.ServiceArea.GetHashCode();
                return hashCode;
            }
        }
    }
}
