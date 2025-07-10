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
    /// 纳管账号体系基础设置。
    /// </summary>
    public class OrganizationStructureBaseLineRsp 
    {

        /// <summary>
        /// 注册OU名称。
        /// </summary>
        [JsonProperty("organizational_unit_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationalUnitName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("organizational_unit_type", NullValueHandling = NullValueHandling.Ignore)]
        public OrganizationalUnitTypeForSetup OrganizationalUnitType { get; set; }
        /// <summary>
        /// 纳管账号基本信息。
        /// </summary>
        [JsonProperty("accounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccountBaselineRsp> Accounts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationStructureBaseLineRsp {\n");
            sb.Append("  organizationalUnitName: ").Append(OrganizationalUnitName).Append("\n");
            sb.Append("  organizationalUnitType: ").Append(OrganizationalUnitType).Append("\n");
            sb.Append("  accounts: ").Append(Accounts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrganizationStructureBaseLineRsp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrganizationStructureBaseLineRsp input)
        {
            if (input == null) return false;
            if (this.OrganizationalUnitName != input.OrganizationalUnitName || (this.OrganizationalUnitName != null && !this.OrganizationalUnitName.Equals(input.OrganizationalUnitName))) return false;
            if (this.OrganizationalUnitType != input.OrganizationalUnitType) return false;
            if (this.Accounts != input.Accounts || (this.Accounts != null && input.Accounts != null && !this.Accounts.SequenceEqual(input.Accounts))) return false;

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
                if (this.OrganizationalUnitName != null) hashCode = hashCode * 59 + this.OrganizationalUnitName.GetHashCode();
                hashCode = hashCode * 59 + this.OrganizationalUnitType.GetHashCode();
                if (this.Accounts != null) hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                return hashCode;
            }
        }
    }
}
