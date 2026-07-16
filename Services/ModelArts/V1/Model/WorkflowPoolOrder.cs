using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// pool order struct
    /// </summary>
    public class WorkflowPoolOrder 
    {

        /// <summary>
        /// 订阅ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore)]
        public SkuInfo Sku { get; set; }

        /// <summary>
        /// 订阅计数。
        /// </summary>
        [JsonProperty("sku_count", NullValueHandling = NullValueHandling.Ignore)]
        public string SkuCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowPoolOrder {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  sku: ").Append(Sku).Append("\n");
            sb.Append("  skuCount: ").Append(SkuCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowPoolOrder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowPoolOrder input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Sku != input.Sku || (this.Sku != null && !this.Sku.Equals(input.Sku))) return false;
            if (this.SkuCount != input.SkuCount || (this.SkuCount != null && !this.SkuCount.Equals(input.SkuCount))) return false;

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
                if (this.Sku != null) hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.SkuCount != null) hashCode = hashCode * 59 + this.SkuCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
