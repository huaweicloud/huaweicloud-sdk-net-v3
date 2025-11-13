using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListPublications4SubscriptionResponse : SdkResponse
    {

        /// <summary>
        /// 实例发布列表。
        /// </summary>
        [JsonProperty("instance_publications", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstancePublicatiosInfo> InstancePublications { get; set; }

        /// <summary>
        /// 发布总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPublications4SubscriptionResponse {\n");
            sb.Append("  instancePublications: ").Append(InstancePublications).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPublications4SubscriptionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPublications4SubscriptionResponse input)
        {
            if (input == null) return false;
            if (this.InstancePublications != input.InstancePublications || (this.InstancePublications != null && input.InstancePublications != null && !this.InstancePublications.SequenceEqual(input.InstancePublications))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.InstancePublications != null) hashCode = hashCode * 59 + this.InstancePublications.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
