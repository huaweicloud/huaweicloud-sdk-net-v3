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
    /// 
    /// </summary>
    public class NetworkDeviceOffering 
    {

        /// <summary>
        /// 销售策略ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 地区编码，表示允许在这个地区购买部署
        /// </summary>
        [JsonProperty("zone_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneCode { get; set; }

        /// <summary>
        /// 销售场景编码
        /// </summary>
        [JsonProperty("scene_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SceneCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public OfferingStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public NetworkDeviceSpec Spec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("product_info", NullValueHandling = NullValueHandling.Ignore)]
        public ProductInfo ProductInfo { get; set; }

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
            sb.Append("class NetworkDeviceOffering {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  zoneCode: ").Append(ZoneCode).Append("\n");
            sb.Append("  sceneCode: ").Append(SceneCode).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  spec: ").Append(Spec).Append("\n");
            sb.Append("  productInfo: ").Append(ProductInfo).Append("\n");
            sb.Append("  saleCycles: ").Append(SaleCycles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkDeviceOffering);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NetworkDeviceOffering input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ZoneCode != input.ZoneCode || (this.ZoneCode != null && !this.ZoneCode.Equals(input.ZoneCode))) return false;
            if (this.SceneCode != input.SceneCode || (this.SceneCode != null && !this.SceneCode.Equals(input.SceneCode))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Spec != input.Spec || (this.Spec != null && !this.Spec.Equals(input.Spec))) return false;
            if (this.ProductInfo != input.ProductInfo || (this.ProductInfo != null && !this.ProductInfo.Equals(input.ProductInfo))) return false;
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
                if (this.ZoneCode != null) hashCode = hashCode * 59 + this.ZoneCode.GetHashCode();
                if (this.SceneCode != null) hashCode = hashCode * 59 + this.SceneCode.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Spec != null) hashCode = hashCode * 59 + this.Spec.GetHashCode();
                if (this.ProductInfo != null) hashCode = hashCode * 59 + this.ProductInfo.GetHashCode();
                if (this.SaleCycles != null) hashCode = hashCode * 59 + this.SaleCycles.GetHashCode();
                return hashCode;
            }
        }
    }
}
