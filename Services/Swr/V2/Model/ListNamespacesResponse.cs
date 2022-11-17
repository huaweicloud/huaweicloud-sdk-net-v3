using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListNamespacesResponse : SdkResponse
    {

        /// <summary>
        /// 组织列表
        /// </summary>
        [JsonProperty("namespaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowNamespace> Namespaces { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNamespacesResponse {\n");
            sb.Append("  namespaces: ").Append(Namespaces).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNamespacesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNamespacesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Namespaces == input.Namespaces ||
                    this.Namespaces != null &&
                    input.Namespaces != null &&
                    this.Namespaces.SequenceEqual(input.Namespaces)
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
                if (this.Namespaces != null)
                    hashCode = hashCode * 59 + this.Namespaces.GetHashCode();
                return hashCode;
            }
        }
    }
}
