using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowQuotaRequest 
    {

        /// <summary>
        /// 账号id
        /// </summary>
        [SDKProperty("domainid", IsPath = true)]
        [JsonProperty("domainid", NullValueHandling = NullValueHandling.Ignore)]
        public string Domainid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowQuotaRequest {\n");
            sb.Append("  domainid: ").Append(Domainid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowQuotaRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowQuotaRequest input)
        {
            if (input == null) return false;
            if (this.Domainid != input.Domainid || (this.Domainid != null && !this.Domainid.Equals(input.Domainid))) return false;

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
                if (this.Domainid != null) hashCode = hashCode * 59 + this.Domainid.GetHashCode();
                return hashCode;
            }
        }
    }
}
