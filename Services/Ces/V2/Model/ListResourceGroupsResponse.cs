using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListResourceGroupsResponse : SdkResponse
    {

        /// <summary>
        /// 资源分组总数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 资源分组列表
        /// </summary>
        [JsonProperty("resource_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<OneResourceGroupResp> ResourceGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResourceGroupsResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  resourceGroups: ").Append(ResourceGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResourceGroupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResourceGroupsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.ResourceGroups == input.ResourceGroups ||
                    this.ResourceGroups != null &&
                    input.ResourceGroups != null &&
                    this.ResourceGroups.SequenceEqual(input.ResourceGroups)
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.ResourceGroups != null)
                    hashCode = hashCode * 59 + this.ResourceGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
