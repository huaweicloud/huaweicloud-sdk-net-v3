using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreatePostCheckResponse : SdkResponse
    {

        /// <summary>
        /// API版本
        /// </summary>
        [JsonProperty("apiVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public PostcheckCluserResponseMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public PostcheckSpec Spec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public PostcheckClusterResponseBodyStatus Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePostCheckResponse {\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  kind: ").Append(Kind).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  spec: ").Append(Spec).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePostCheckResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePostCheckResponse input)
        {
            if (input == null) return false;
            if (this.ApiVersion != input.ApiVersion || (this.ApiVersion != null && !this.ApiVersion.Equals(input.ApiVersion))) return false;
            if (this.Kind != input.Kind || (this.Kind != null && !this.Kind.Equals(input.Kind))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;
            if (this.Spec != input.Spec || (this.Spec != null && !this.Spec.Equals(input.Spec))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.ApiVersion != null) hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Kind != null) hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Spec != null) hashCode = hashCode * 59 + this.Spec.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
