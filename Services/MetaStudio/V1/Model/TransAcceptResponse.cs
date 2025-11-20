using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TransAcceptResponse 
    {

        /// <summary>
        /// 资产转移时，是否需要从接收方扣减资源（产生计费话单)
        /// </summary>
        [JsonProperty("is_need_billing", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNeedBilling { get; set; }

        /// <summary>
        /// 需要扣减的资源列表。
        /// </summary>
        [JsonProperty("required_resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<BillResources> RequiredResources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransAcceptResponse {\n");
            sb.Append("  isNeedBilling: ").Append(IsNeedBilling).Append("\n");
            sb.Append("  requiredResources: ").Append(RequiredResources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransAcceptResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransAcceptResponse input)
        {
            if (input == null) return false;
            if (this.IsNeedBilling != input.IsNeedBilling || (this.IsNeedBilling != null && !this.IsNeedBilling.Equals(input.IsNeedBilling))) return false;
            if (this.RequiredResources != input.RequiredResources || (this.RequiredResources != null && input.RequiredResources != null && !this.RequiredResources.SequenceEqual(input.RequiredResources))) return false;

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
                if (this.IsNeedBilling != null) hashCode = hashCode * 59 + this.IsNeedBilling.GetHashCode();
                if (this.RequiredResources != null) hashCode = hashCode * 59 + this.RequiredResources.GetHashCode();
                return hashCode;
            }
        }
    }
}
