using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowQuotaResponse : SdkResponse
    {

        /// <summary>
        /// 配额数组
        /// </summary>
        [JsonProperty("quotas", NullValueHandling = NullValueHandling.Ignore)]
        public List<Quotas> Quotas { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowQuotaResponse {\n");
            sb.Append("  quotas: ").Append(Quotas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowQuotaResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowQuotaResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Quotas == input.Quotas ||
                    this.Quotas != null &&
                    input.Quotas != null &&
                    this.Quotas.SequenceEqual(input.Quotas)
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
                if (this.Quotas != null)
                    hashCode = hashCode * 59 + this.Quotas.GetHashCode();
                return hashCode;
            }
        }
    }
}
