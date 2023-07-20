using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowGaussMySqlQuotasResponse : SdkResponse
    {

        /// <summary>
        /// 资源列表对象。
        /// </summary>
        [JsonProperty("quota_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<Quota> QuotaList { get; set; }

        /// <summary>
        /// 配额记录的条数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGaussMySqlQuotasResponse {\n");
            sb.Append("  quotaList: ").Append(QuotaList).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGaussMySqlQuotasResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGaussMySqlQuotasResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuotaList == input.QuotaList ||
                    this.QuotaList != null &&
                    input.QuotaList != null &&
                    this.QuotaList.SequenceEqual(input.QuotaList)
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
                if (this.QuotaList != null)
                    hashCode = hashCode * 59 + this.QuotaList.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
