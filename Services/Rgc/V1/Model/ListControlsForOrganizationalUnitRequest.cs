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
    /// Request Object
    /// </summary>
    public class ListControlsForOrganizationalUnitRequest 
    {

        /// <summary>
        /// 注册OU ID。
        /// </summary>
        [SDKProperty("managed_organizational_unit_id", IsPath = true)]
        [JsonProperty("managed_organizational_unit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedOrganizationalUnitId { get; set; }

        /// <summary>
        /// 分页页面的最大值。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 页面标记。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListControlsForOrganizationalUnitRequest {\n");
            sb.Append("  managedOrganizationalUnitId: ").Append(ManagedOrganizationalUnitId).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListControlsForOrganizationalUnitRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListControlsForOrganizationalUnitRequest input)
        {
            if (input == null) return false;
            if (this.ManagedOrganizationalUnitId != input.ManagedOrganizationalUnitId || (this.ManagedOrganizationalUnitId != null && !this.ManagedOrganizationalUnitId.Equals(input.ManagedOrganizationalUnitId))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;

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
                if (this.ManagedOrganizationalUnitId != null) hashCode = hashCode * 59 + this.ManagedOrganizationalUnitId.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
