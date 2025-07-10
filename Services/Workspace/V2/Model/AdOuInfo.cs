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
    public class AdOuInfo 
    {

        /// <summary>
        /// 名称。
        /// </summary>
        [JsonProperty("ou_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OuName { get; set; }

        /// <summary>
        /// 域名地址。
        /// </summary>
        [JsonProperty("ou_dn", NullValueHandling = NullValueHandling.Ignore)]
        public string OuDn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdOuInfo {\n");
            sb.Append("  ouName: ").Append(OuName).Append("\n");
            sb.Append("  ouDn: ").Append(OuDn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdOuInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdOuInfo input)
        {
            if (input == null) return false;
            if (this.OuName != input.OuName || (this.OuName != null && !this.OuName.Equals(input.OuName))) return false;
            if (this.OuDn != input.OuDn || (this.OuDn != null && !this.OuDn.Equals(input.OuDn))) return false;

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
                if (this.OuName != null) hashCode = hashCode * 59 + this.OuName.GetHashCode();
                if (this.OuDn != null) hashCode = hashCode * 59 + this.OuDn.GetHashCode();
                return hashCode;
            }
        }
    }
}
