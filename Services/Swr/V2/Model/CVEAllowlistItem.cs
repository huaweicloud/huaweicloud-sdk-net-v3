using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// CVE漏洞列表
    /// </summary>
    public class CVEAllowlistItem 
    {

        /// <summary>
        /// CVE的ID, 比如：CVE-2019-10164
        /// </summary>
        [JsonProperty("cve_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CveId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CVEAllowlistItem {\n");
            sb.Append("  cveId: ").Append(CveId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CVEAllowlistItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CVEAllowlistItem input)
        {
            if (input == null) return false;
            if (this.CveId != input.CveId || (this.CveId != null && !this.CveId.Equals(input.CveId))) return false;

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
                if (this.CveId != null) hashCode = hashCode * 59 + this.CveId.GetHashCode();
                return hashCode;
            }
        }
    }
}
