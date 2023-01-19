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
    /// Response Object
    /// </summary>
    public class ShowTopDomainNamesResponse : SdkResponse
    {

        /// <summary>
        /// top域名信息
        /// </summary>
        [JsonProperty("top_domain_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, Object>> TopDomainNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTopDomainNamesResponse {\n");
            sb.Append("  topDomainNames: ").Append(TopDomainNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTopDomainNamesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTopDomainNamesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TopDomainNames == input.TopDomainNames ||
                    this.TopDomainNames != null &&
                    input.TopDomainNames != null &&
                    this.TopDomainNames.SequenceEqual(input.TopDomainNames)
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
                if (this.TopDomainNames != null)
                    hashCode = hashCode * 59 + this.TopDomainNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
