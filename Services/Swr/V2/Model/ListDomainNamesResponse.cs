using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDomainNamesResponse : SdkResponse
    {

        /// <summary>
        /// 域名信息
        /// </summary>
        [JsonProperty("domain_name_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<DomainNameInfo> DomainNameInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDomainNamesResponse {\n");
            sb.Append("  domainNameInfos: ").Append(DomainNameInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDomainNamesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDomainNamesResponse input)
        {
            if (input == null) return false;
            if (this.DomainNameInfos != input.DomainNameInfos || (this.DomainNameInfos != null && input.DomainNameInfos != null && !this.DomainNameInfos.SequenceEqual(input.DomainNameInfos))) return false;

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
                if (this.DomainNameInfos != null) hashCode = hashCode * 59 + this.DomainNameInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
