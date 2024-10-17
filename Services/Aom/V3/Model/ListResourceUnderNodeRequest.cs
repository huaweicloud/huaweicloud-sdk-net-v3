using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListResourceUnderNodeRequest 
    {

        /// <summary>
        /// 云服务资源,同rms服务的provider
        /// </summary>
        [SDKProperty("rf_resource_type", IsPath = true)]
        [JsonProperty("rf_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RfResourceType { get; set; }

        /// <summary>
        /// 云服务资源类型,同rms服务的type
        /// </summary>
        [SDKProperty("type", IsPath = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public PageResourceListParam Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResourceUnderNodeRequest {\n");
            sb.Append("  rfResourceType: ").Append(RfResourceType).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResourceUnderNodeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResourceUnderNodeRequest input)
        {
            if (input == null) return false;
            if (this.RfResourceType != input.RfResourceType || (this.RfResourceType != null && !this.RfResourceType.Equals(input.RfResourceType))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.RfResourceType != null) hashCode = hashCode * 59 + this.RfResourceType.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
