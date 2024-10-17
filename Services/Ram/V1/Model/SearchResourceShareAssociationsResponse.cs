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
    public class SearchResourceShareAssociationsResponse : SdkResponse
    {

        /// <summary>
        /// 绑定的详细信息列表。
        /// </summary>
        [JsonProperty("resource_share_associations", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceShareAssociation> ResourceShareAssociations { get; set; }

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
            sb.Append("class SearchResourceShareAssociationsResponse {\n");
            sb.Append("  resourceShareAssociations: ").Append(ResourceShareAssociations).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchResourceShareAssociationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchResourceShareAssociationsResponse input)
        {
            if (input == null) return false;
            if (this.ResourceShareAssociations != input.ResourceShareAssociations || (this.ResourceShareAssociations != null && input.ResourceShareAssociations != null && !this.ResourceShareAssociations.SequenceEqual(input.ResourceShareAssociations))) return false;
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
                if (this.ResourceShareAssociations != null) hashCode = hashCode * 59 + this.ResourceShareAssociations.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
