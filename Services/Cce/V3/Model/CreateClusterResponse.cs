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
    public class CreateClusterResponse : SdkResponse
    {

        /// <summary>
        /// API类型，固定值“Cluster”或“cluster”，该值不可修改。  
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// API版本，固定值“v3”，该值不可修改。  
        /// </summary>
        [JsonProperty("apiVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public ClusterMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public V3ClusterSpec Spec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public ClusterStatus Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateClusterResponse {\n");
            sb.Append("  kind: ").Append(Kind).Append("\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
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
            return this.Equals(input as CreateClusterResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateClusterResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
                ) && 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Spec == input.Spec ||
                    (this.Spec != null &&
                    this.Spec.Equals(input.Spec))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Spec != null)
                    hashCode = hashCode * 59 + this.Spec.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
