using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListEpsQuotasResponse : SdkResponse
    {

        /// <summary>
        /// 企业配额列表。
        /// </summary>
        [JsonProperty("eps_quotas", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListQuotaResult> EpsQuotas { get; set; }

        /// <summary>
        /// 配额组数量。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEpsQuotasResponse {\n");
            sb.Append("  epsQuotas: ").Append(EpsQuotas).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEpsQuotasResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEpsQuotasResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EpsQuotas == input.EpsQuotas ||
                    this.EpsQuotas != null &&
                    input.EpsQuotas != null &&
                    this.EpsQuotas.SequenceEqual(input.EpsQuotas)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.EpsQuotas != null)
                    hashCode = hashCode * 59 + this.EpsQuotas.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
