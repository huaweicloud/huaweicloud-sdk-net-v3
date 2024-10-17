using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Demo.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDemoResourcesResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("demo_resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<DemoResource> DemoResources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDemoResourcesResponse {\n");
            sb.Append("  demoResources: ").Append(DemoResources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDemoResourcesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDemoResourcesResponse input)
        {
            if (input == null) return false;
            if (this.DemoResources != input.DemoResources || (this.DemoResources != null && input.DemoResources != null && !this.DemoResources.SequenceEqual(input.DemoResources))) return false;

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
                if (this.DemoResources != null) hashCode = hashCode * 59 + this.DemoResources.GetHashCode();
                return hashCode;
            }
        }
    }
}
