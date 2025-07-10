using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListManagedOrganizationalUnitsResponse : SdkResponse
    {

        /// <summary>
        /// 注册OU信息。
        /// </summary>
        [JsonProperty("managed_organizational_units", NullValueHandling = NullValueHandling.Ignore)]
        public List<ManagedOrganizationalUnit> ManagedOrganizationalUnits { get; set; }

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
            sb.Append("class ListManagedOrganizationalUnitsResponse {\n");
            sb.Append("  managedOrganizationalUnits: ").Append(ManagedOrganizationalUnits).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListManagedOrganizationalUnitsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListManagedOrganizationalUnitsResponse input)
        {
            if (input == null) return false;
            if (this.ManagedOrganizationalUnits != input.ManagedOrganizationalUnits || (this.ManagedOrganizationalUnits != null && input.ManagedOrganizationalUnits != null && !this.ManagedOrganizationalUnits.SequenceEqual(input.ManagedOrganizationalUnits))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.ManagedOrganizationalUnits != null) hashCode = hashCode * 59 + this.ManagedOrganizationalUnits.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
