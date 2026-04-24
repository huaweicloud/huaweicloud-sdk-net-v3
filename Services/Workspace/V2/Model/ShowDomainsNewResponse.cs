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
    /// Response Object
    /// </summary>
    public class ShowDomainsNewResponse : SdkResponse
    {

        /// <summary>
        /// 统信域控列表。
        /// </summary>
        [JsonProperty("uos_domain_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<UosDomainInfo> UosDomainList { get; set; }

        /// <summary>
        /// 域信息。
        /// </summary>
        [JsonProperty("domain_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<AdDomain> DomainInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainsNewResponse {\n");
            sb.Append("  uosDomainList: ").Append(UosDomainList).Append("\n");
            sb.Append("  domainInfos: ").Append(DomainInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainsNewResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainsNewResponse input)
        {
            if (input == null) return false;
            if (this.UosDomainList != input.UosDomainList || (this.UosDomainList != null && input.UosDomainList != null && !this.UosDomainList.SequenceEqual(input.UosDomainList))) return false;
            if (this.DomainInfos != input.DomainInfos || (this.DomainInfos != null && input.DomainInfos != null && !this.DomainInfos.SequenceEqual(input.DomainInfos))) return false;

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
                if (this.UosDomainList != null) hashCode = hashCode * 59 + this.UosDomainList.GetHashCode();
                if (this.DomainInfos != null) hashCode = hashCode * 59 + this.DomainInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
