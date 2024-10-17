using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListResourceGroupResponse : SdkResponse
    {

        /// <summary>
        /// 一个或者多个资源分组信息。
        /// </summary>
        [JsonProperty("resource_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceGroupInfo> ResourceGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("meta_data", NullValueHandling = NullValueHandling.Ignore)]
        public TotalMetaData MetaData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResourceGroupResponse {\n");
            sb.Append("  resourceGroups: ").Append(ResourceGroups).Append("\n");
            sb.Append("  metaData: ").Append(MetaData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResourceGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResourceGroupResponse input)
        {
            if (input == null) return false;
            if (this.ResourceGroups != input.ResourceGroups || (this.ResourceGroups != null && input.ResourceGroups != null && !this.ResourceGroups.SequenceEqual(input.ResourceGroups))) return false;
            if (this.MetaData != input.MetaData || (this.MetaData != null && !this.MetaData.Equals(input.MetaData))) return false;

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
                if (this.ResourceGroups != null) hashCode = hashCode * 59 + this.ResourceGroups.GetHashCode();
                if (this.MetaData != null) hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                return hashCode;
            }
        }
    }
}
