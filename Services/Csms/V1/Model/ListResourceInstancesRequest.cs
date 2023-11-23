using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListResourceInstancesRequest 
    {

        /// <summary>
        /// 定值为resource_instances。
        /// </summary>
        [SDKProperty("resource_instances", IsPath = true)]
        [JsonProperty("resource_instances", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceInstances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public ListResourceInstancesRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResourceInstancesRequest {\n");
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
            return this.Equals(input as ListResourceInstancesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResourceInstancesRequest input)
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
