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
    /// 
    /// </summary>
    public class ResourceRequirements 
    {

        /// <summary>
        /// 资源限制，创建时指定无效
        /// </summary>
        [JsonProperty("limits", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Limits { get; set; }

        /// <summary>
        /// 资源需求，创建时指定无效
        /// </summary>
        [JsonProperty("requests", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Requests { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceRequirements {\n");
            sb.Append("  limits: ").Append(Limits).Append("\n");
            sb.Append("  requests: ").Append(Requests).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceRequirements);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceRequirements input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limits == input.Limits ||
                    this.Limits != null &&
                    input.Limits != null &&
                    this.Limits.SequenceEqual(input.Limits)
                ) && 
                (
                    this.Requests == input.Requests ||
                    this.Requests != null &&
                    input.Requests != null &&
                    this.Requests.SequenceEqual(input.Requests)
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
                if (this.Limits != null)
                    hashCode = hashCode * 59 + this.Limits.GetHashCode();
                if (this.Requests != null)
                    hashCode = hashCode * 59 + this.Requests.GetHashCode();
                return hashCode;
            }
        }
    }
}
