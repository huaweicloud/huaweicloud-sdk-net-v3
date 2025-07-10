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
    public class ShowControlsForOrganizationalUnitRequest 
    {

        /// <summary>
        /// 注册OU ID。
        /// </summary>
        [SDKProperty("managed_organizational_unit_id", IsPath = true)]
        [JsonProperty("managed_organizational_unit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedOrganizationalUnitId { get; set; }

        /// <summary>
        /// 控制策略ID。
        /// </summary>
        [SDKProperty("control_id", IsPath = true)]
        [JsonProperty("control_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ControlId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowControlsForOrganizationalUnitRequest {\n");
            sb.Append("  managedOrganizationalUnitId: ").Append(ManagedOrganizationalUnitId).Append("\n");
            sb.Append("  controlId: ").Append(ControlId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowControlsForOrganizationalUnitRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowControlsForOrganizationalUnitRequest input)
        {
            if (input == null) return false;
            if (this.ManagedOrganizationalUnitId != input.ManagedOrganizationalUnitId || (this.ManagedOrganizationalUnitId != null && !this.ManagedOrganizationalUnitId.Equals(input.ManagedOrganizationalUnitId))) return false;
            if (this.ControlId != input.ControlId || (this.ControlId != null && !this.ControlId.Equals(input.ControlId))) return false;

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
                if (this.ControlId != null) hashCode = hashCode * 59 + this.ControlId.GetHashCode();
                return hashCode;
            }
        }
    }
}
