using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CloudConnectionEnterpriseSupportSitesCapabilityValue 
    {

        /// <summary>
        /// 租户支持的Site列表。
        /// </summary>
        [JsonProperty("support_sites", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportSites { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudConnectionEnterpriseSupportSitesCapabilityValue {\n");
            sb.Append("  supportSites: ").Append(SupportSites).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloudConnectionEnterpriseSupportSitesCapabilityValue);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloudConnectionEnterpriseSupportSitesCapabilityValue input)
        {
            if (input == null) return false;
            if (this.SupportSites != input.SupportSites || (this.SupportSites != null && input.SupportSites != null && !this.SupportSites.SequenceEqual(input.SupportSites))) return false;

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
                if (this.SupportSites != null) hashCode = hashCode * 59 + this.SupportSites.GetHashCode();
                return hashCode;
            }
        }
    }
}
