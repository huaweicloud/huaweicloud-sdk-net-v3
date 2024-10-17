using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CinderListQuotasResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("quota_set", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaList QuotaSet { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CinderListQuotasResponse {\n");
            sb.Append("  quotaSet: ").Append(QuotaSet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CinderListQuotasResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CinderListQuotasResponse input)
        {
            if (input == null) return false;
            if (this.QuotaSet != input.QuotaSet || (this.QuotaSet != null && !this.QuotaSet.Equals(input.QuotaSet))) return false;

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
                if (this.QuotaSet != null) hashCode = hashCode * 59 + this.QuotaSet.GetHashCode();
                return hashCode;
            }
        }
    }
}
