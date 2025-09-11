using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDbEncryptInstancesResponse : SdkResponse
    {

        /// <summary>
        /// 实例列表
        /// </summary>
        [JsonProperty("clusters", NullValueHandling = NullValueHandling.Ignore)]
        public List<Cluster> Clusters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDbEncryptInstancesResponse {\n");
            sb.Append("  clusters: ").Append(Clusters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDbEncryptInstancesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDbEncryptInstancesResponse input)
        {
            if (input == null) return false;
            if (this.Clusters != input.Clusters || (this.Clusters != null && input.Clusters != null && !this.Clusters.SequenceEqual(input.Clusters))) return false;

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
                if (this.Clusters != null) hashCode = hashCode * 59 + this.Clusters.GetHashCode();
                return hashCode;
            }
        }
    }
}
