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
    public class GcbRemoteSiteCode 
    {

        /// <summary>
        /// 功能说明：远端接入点的编码。
        /// </summary>
        [JsonProperty("remote_site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteSiteCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcbRemoteSiteCode {\n");
            sb.Append("  remoteSiteCode: ").Append(RemoteSiteCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GcbRemoteSiteCode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GcbRemoteSiteCode input)
        {
            if (input == null) return false;
            if (this.RemoteSiteCode != input.RemoteSiteCode || (this.RemoteSiteCode != null && !this.RemoteSiteCode.Equals(input.RemoteSiteCode))) return false;

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
                if (this.RemoteSiteCode != null) hashCode = hashCode * 59 + this.RemoteSiteCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
