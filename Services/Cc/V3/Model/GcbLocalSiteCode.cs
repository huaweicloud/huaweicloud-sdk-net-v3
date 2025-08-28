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
    public class GcbLocalSiteCode 
    {

        /// <summary>
        /// 功能说明：本端接入点的编码。
        /// </summary>
        [JsonProperty("local_site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalSiteCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcbLocalSiteCode {\n");
            sb.Append("  localSiteCode: ").Append(LocalSiteCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GcbLocalSiteCode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GcbLocalSiteCode input)
        {
            if (input == null) return false;
            if (this.LocalSiteCode != input.LocalSiteCode || (this.LocalSiteCode != null && !this.LocalSiteCode.Equals(input.LocalSiteCode))) return false;

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
                if (this.LocalSiteCode != null) hashCode = hashCode * 59 + this.LocalSiteCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
