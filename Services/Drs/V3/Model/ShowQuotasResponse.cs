using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowQuotasResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("quotas", NullValueHandling = NullValueHandling.Ignore)]
        public QueryQuotaInfo Quotas { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowQuotasResponse {\n");
            sb.Append("  quotas: ").Append(Quotas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowQuotasResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowQuotasResponse input)
        {
            if (input == null) return false;
            if (this.Quotas != input.Quotas || (this.Quotas != null && !this.Quotas.Equals(input.Quotas))) return false;

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
                if (this.Quotas != null) hashCode = hashCode * 59 + this.Quotas.GetHashCode();
                return hashCode;
            }
        }
    }
}
