using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EnterprisePersonNew 
    {

        /// <summary>
        /// 法人姓名。
        /// </summary>
        [JsonProperty("legel_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LegelName { get; set; }

        /// <summary>
        /// 法人身份证号。
        /// </summary>
        [JsonProperty("legel_id_number", NullValueHandling = NullValueHandling.Ignore)]
        public string LegelIdNumber { get; set; }

        /// <summary>
        /// 认证人角色。 legalPerson ：法人代表。
        /// </summary>
        [JsonProperty("certifier_role", NullValueHandling = NullValueHandling.Ignore)]
        public string CertifierRole { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnterprisePersonNew {\n");
            sb.Append("  legelName: ").Append(LegelName).Append("\n");
            sb.Append("  legelIdNumber: ").Append(LegelIdNumber).Append("\n");
            sb.Append("  certifierRole: ").Append(CertifierRole).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnterprisePersonNew);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnterprisePersonNew input)
        {
            if (input == null) return false;
            if (this.LegelName != input.LegelName || (this.LegelName != null && !this.LegelName.Equals(input.LegelName))) return false;
            if (this.LegelIdNumber != input.LegelIdNumber || (this.LegelIdNumber != null && !this.LegelIdNumber.Equals(input.LegelIdNumber))) return false;
            if (this.CertifierRole != input.CertifierRole || (this.CertifierRole != null && !this.CertifierRole.Equals(input.CertifierRole))) return false;

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
                if (this.LegelName != null) hashCode = hashCode * 59 + this.LegelName.GetHashCode();
                if (this.LegelIdNumber != null) hashCode = hashCode * 59 + this.LegelIdNumber.GetHashCode();
                if (this.CertifierRole != null) hashCode = hashCode * 59 + this.CertifierRole.GetHashCode();
                return hashCode;
            }
        }
    }
}
