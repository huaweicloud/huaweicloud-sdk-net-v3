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
    public class RegisterOrganizationalUnitResponse : SdkResponse
    {

        /// <summary>
        /// 异步接口的操作ID。
        /// </summary>
        [JsonProperty("organizational_unit_operation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationalUnitOperationId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterOrganizationalUnitResponse {\n");
            sb.Append("  organizationalUnitOperationId: ").Append(OrganizationalUnitOperationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegisterOrganizationalUnitResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegisterOrganizationalUnitResponse input)
        {
            if (input == null) return false;
            if (this.OrganizationalUnitOperationId != input.OrganizationalUnitOperationId || (this.OrganizationalUnitOperationId != null && !this.OrganizationalUnitOperationId.Equals(input.OrganizationalUnitOperationId))) return false;

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
                if (this.OrganizationalUnitOperationId != null) hashCode = hashCode * 59 + this.OrganizationalUnitOperationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
