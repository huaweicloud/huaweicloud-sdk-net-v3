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
    /// 主机信息
    /// </summary>
    public class Hosts 
    {

        /// <summary>
        /// 主机所属AZ。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 主机名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 在创建云服务器时（未指定主机ID），是否允许云服务器自动分配在一台可用的主机上。取值范围：“on”或“off”默认为 “on”。
        /// </summary>
        [JsonProperty("auto_placement", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoPlacement { get; set; }

        /// <summary>
        /// 主机类型。
        /// </summary>
        [JsonProperty("host_type", NullValueHandling = NullValueHandling.Ignore)]
        public string HostType { get; set; }

        /// <summary>
        /// 待分配的主机数量
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// 主机产品Id
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Hosts {\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  autoPlacement: ").Append(AutoPlacement).Append("\n");
            sb.Append("  hostType: ").Append(HostType).Append("\n");
            sb.Append("  quantity: ").Append(Quantity).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Hosts);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Hosts input)
        {
            if (input == null) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AutoPlacement != input.AutoPlacement || (this.AutoPlacement != null && !this.AutoPlacement.Equals(input.AutoPlacement))) return false;
            if (this.HostType != input.HostType || (this.HostType != null && !this.HostType.Equals(input.HostType))) return false;
            if (this.Quantity != input.Quantity || (this.Quantity != null && !this.Quantity.Equals(input.Quantity))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;

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
                if (this.AutoPlacement != null) hashCode = hashCode * 59 + this.AutoPlacement.GetHashCode();
                if (this.HostType != null) hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.Quantity != null) hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                return hashCode;
            }
        }
    }
}
