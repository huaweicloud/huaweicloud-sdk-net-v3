using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDomainItemDetailsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("domain_item_details", NullValueHandling = NullValueHandling.Ignore)]
        public DomainItemDetail DomainItemDetails { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainItemDetailsResponse {\n");
            sb.Append("  domainItemDetails: ").Append(DomainItemDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainItemDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainItemDetailsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainItemDetails == input.DomainItemDetails ||
                    (this.DomainItemDetails != null &&
                    this.DomainItemDetails.Equals(input.DomainItemDetails))
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
                if (this.DomainItemDetails != null)
                    hashCode = hashCode * 59 + this.DomainItemDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
