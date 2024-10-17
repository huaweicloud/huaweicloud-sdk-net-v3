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
    public class SearchSharedPrincipalsResponse : SdkResponse
    {

        /// <summary>
        /// 资源使用者的详细信息列表。
        /// </summary>
        [JsonProperty("shared_principals", NullValueHandling = NullValueHandling.Ignore)]
        public List<SharedPrincipal> SharedPrincipals { get; set; }

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
            sb.Append("class SearchSharedPrincipalsResponse {\n");
            sb.Append("  sharedPrincipals: ").Append(SharedPrincipals).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchSharedPrincipalsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchSharedPrincipalsResponse input)
        {
            if (input == null) return false;
            if (this.SharedPrincipals != input.SharedPrincipals || (this.SharedPrincipals != null && input.SharedPrincipals != null && !this.SharedPrincipals.SequenceEqual(input.SharedPrincipals))) return false;
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
                if (this.SharedPrincipals != null) hashCode = hashCode * 59 + this.SharedPrincipals.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
