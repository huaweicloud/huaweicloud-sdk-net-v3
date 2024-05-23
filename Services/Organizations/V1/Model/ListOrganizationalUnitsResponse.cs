using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListOrganizationalUnitsResponse : SdkResponse
    {

        /// <summary>
        /// 组织单元列表。
        /// </summary>
        [JsonProperty("organizational_units", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrganizationalUnitDto> OrganizationalUnits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfoDto PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListOrganizationalUnitsResponse {\n");
            sb.Append("  organizationalUnits: ").Append(OrganizationalUnits).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListOrganizationalUnitsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListOrganizationalUnitsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganizationalUnits == input.OrganizationalUnits ||
                    this.OrganizationalUnits != null &&
                    input.OrganizationalUnits != null &&
                    this.OrganizationalUnits.SequenceEqual(input.OrganizationalUnits)
                ) && 
                (
                    this.PageInfo == input.PageInfo ||
                    (this.PageInfo != null &&
                    this.PageInfo.Equals(input.PageInfo))
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
                if (this.OrganizationalUnits != null)
                    hashCode = hashCode * 59 + this.OrganizationalUnits.GetHashCode();
                if (this.PageInfo != null)
                    hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
