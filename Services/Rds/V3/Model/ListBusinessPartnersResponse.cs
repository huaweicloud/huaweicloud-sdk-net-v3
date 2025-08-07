using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListBusinessPartnersResponse : SdkResponse
    {

        /// <summary>
        /// 服务商列表。
        /// </summary>
        [JsonProperty("business_partners", NullValueHandling = NullValueHandling.Ignore)]
        public List<BusinessPartner> BusinessPartners { get; set; }

        /// <summary>
        /// 总服务商数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBusinessPartnersResponse {\n");
            sb.Append("  businessPartners: ").Append(BusinessPartners).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBusinessPartnersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBusinessPartnersResponse input)
        {
            if (input == null) return false;
            if (this.BusinessPartners != input.BusinessPartners || (this.BusinessPartners != null && input.BusinessPartners != null && !this.BusinessPartners.SequenceEqual(input.BusinessPartners))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.BusinessPartners != null) hashCode = hashCode * 59 + this.BusinessPartners.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
