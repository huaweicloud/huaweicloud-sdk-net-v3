using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListStackResourcesResponse : SdkResponse
    {

        /// <summary>
        /// 资源栈中所管理的资源信息列表
        /// </summary>
        [JsonProperty("stack_resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<StackResource> StackResources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStackResourcesResponse {\n");
            sb.Append("  stackResources: ").Append(StackResources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStackResourcesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStackResourcesResponse input)
        {
            if (input == null) return false;
            if (this.StackResources != input.StackResources || (this.StackResources != null && input.StackResources != null && !this.StackResources.SequenceEqual(input.StackResources))) return false;

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
                if (this.StackResources != null) hashCode = hashCode * 59 + this.StackResources.GetHashCode();
                return hashCode;
            }
        }
    }
}
