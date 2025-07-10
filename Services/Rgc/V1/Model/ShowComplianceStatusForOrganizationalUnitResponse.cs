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
    public class ShowComplianceStatusForOrganizationalUnitResponse : SdkResponse
    {

        /// <summary>
        /// 合规状态。
        /// </summary>
        [JsonProperty("compliance_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ComplianceStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowComplianceStatusForOrganizationalUnitResponse {\n");
            sb.Append("  complianceStatus: ").Append(ComplianceStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowComplianceStatusForOrganizationalUnitResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowComplianceStatusForOrganizationalUnitResponse input)
        {
            if (input == null) return false;
            if (this.ComplianceStatus != input.ComplianceStatus || (this.ComplianceStatus != null && !this.ComplianceStatus.Equals(input.ComplianceStatus))) return false;

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
                if (this.ComplianceStatus != null) hashCode = hashCode * 59 + this.ComplianceStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
