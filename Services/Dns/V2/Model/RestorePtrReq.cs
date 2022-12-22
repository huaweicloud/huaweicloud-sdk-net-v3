using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RestorePtrReq 
    {

        /// <summary>
        /// PTR记录对应的域名。  此处值为null。
        /// </summary>
        [JsonProperty("ptrdname", NullValueHandling = NullValueHandling.Ignore)]
        public string Ptrdname { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestorePtrReq {\n");
            sb.Append("  ptrdname: ").Append(Ptrdname).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestorePtrReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestorePtrReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ptrdname == input.Ptrdname ||
                    (this.Ptrdname != null &&
                    this.Ptrdname.Equals(input.Ptrdname))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Ptrdname != null)
                    hashCode = hashCode * 59 + this.Ptrdname.GetHashCode();
                return hashCode;
            }
        }
    }
}
