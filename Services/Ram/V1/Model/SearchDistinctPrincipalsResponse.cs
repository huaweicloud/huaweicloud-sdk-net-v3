using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ram.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class SearchDistinctPrincipalsResponse : SdkResponse
    {

        /// <summary>
        /// 不同角色的信息列表。
        /// </summary>
        [JsonProperty("distinct_shared_principals", NullValueHandling = NullValueHandling.Ignore)]
        public List<DistinctSharedPrincipal> DistinctSharedPrincipals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchDistinctPrincipalsResponse {\n");
            sb.Append("  distinctSharedPrincipals: ").Append(DistinctSharedPrincipals).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchDistinctPrincipalsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchDistinctPrincipalsResponse input)
        {
            if (input == null) return false;
            if (this.DistinctSharedPrincipals != input.DistinctSharedPrincipals || (this.DistinctSharedPrincipals != null && input.DistinctSharedPrincipals != null && !this.DistinctSharedPrincipals.SequenceEqual(input.DistinctSharedPrincipals))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.DistinctSharedPrincipals != null) hashCode = hashCode * 59 + this.DistinctSharedPrincipals.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
