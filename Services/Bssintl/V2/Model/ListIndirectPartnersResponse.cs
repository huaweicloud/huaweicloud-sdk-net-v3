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
    /// Response Object
    /// </summary>
    public class ListIndirectPartnersResponse : SdkResponse
    {

        /// <summary>
        /// 符合条件的记录个数，只有成功的时候出现。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 云经销商列表，具体参见表1。
        /// </summary>
        [JsonProperty("indirect_partners", NullValueHandling = NullValueHandling.Ignore)]
        public List<IndirectPartnerInfo> IndirectPartners { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListIndirectPartnersResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  indirectPartners: ").Append(IndirectPartners).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListIndirectPartnersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListIndirectPartnersResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.IndirectPartners != input.IndirectPartners || (this.IndirectPartners != null && input.IndirectPartners != null && !this.IndirectPartners.SequenceEqual(input.IndirectPartners))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.IndirectPartners != null) hashCode = hashCode * 59 + this.IndirectPartners.GetHashCode();
                return hashCode;
            }
        }
    }
}
