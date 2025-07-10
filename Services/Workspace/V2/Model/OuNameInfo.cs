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
    /// 
    /// </summary>
    public class OuNameInfo 
    {

        /// <summary>
        /// ouid。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 域id。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 域名称。
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// OU名称。
        /// </summary>
        [JsonProperty("ou_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OuName { get; set; }

        /// <summary>
        /// ouDn。
        /// </summary>
        [JsonProperty("ou_dn", NullValueHandling = NullValueHandling.Ignore)]
        public string OuDn { get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OuNameInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  ouName: ").Append(OuName).Append("\n");
            sb.Append("  ouDn: ").Append(OuDn).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OuNameInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OuNameInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.OuName != input.OuName || (this.OuName != null && !this.OuName.Equals(input.OuName))) return false;
            if (this.OuDn != input.OuDn || (this.OuDn != null && !this.OuDn.Equals(input.OuDn))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.OuName != null) hashCode = hashCode * 59 + this.OuName.GetHashCode();
                if (this.OuDn != null) hashCode = hashCode * 59 + this.OuDn.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
