using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListKmsByTagsRequest 
    {

        /// <summary>
        /// 资源实例，固定值为resource_instances
        /// </summary>
        [SDKProperty("resource_instances", IsPath = true)]
        [JsonProperty("resource_instances", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceInstances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public ListKmsByTagsRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListKmsByTagsRequest {\n");
            sb.Append("  resourceInstances: ").Append(ResourceInstances).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListKmsByTagsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListKmsByTagsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceInstances == input.ResourceInstances ||
                    (this.ResourceInstances != null &&
                    this.ResourceInstances.Equals(input.ResourceInstances))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.ResourceInstances != null)
                    hashCode = hashCode * 59 + this.ResourceInstances.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
