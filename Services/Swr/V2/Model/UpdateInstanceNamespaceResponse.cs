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
    public class UpdateInstanceNamespaceResponse : SdkResponse
    {

        /// <summary>
        /// 命名空间名称
        /// </summary>
        [JsonProperty("namespace_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public NamespaceMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cve_allowlist", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateCVEAllowlistRequest CveAllowlist { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInstanceNamespaceResponse {\n");
            sb.Append("  namespaceName: ").Append(NamespaceName).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  cveAllowlist: ").Append(CveAllowlist).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInstanceNamespaceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInstanceNamespaceResponse input)
        {
            if (input == null) return false;
            if (this.NamespaceName != input.NamespaceName || (this.NamespaceName != null && !this.NamespaceName.Equals(input.NamespaceName))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;
            if (this.CveAllowlist != input.CveAllowlist || (this.CveAllowlist != null && !this.CveAllowlist.Equals(input.CveAllowlist))) return false;

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
                if (this.NamespaceName != null) hashCode = hashCode * 59 + this.NamespaceName.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.CveAllowlist != null) hashCode = hashCode * 59 + this.CveAllowlist.GetHashCode();
                return hashCode;
            }
        }
    }
}
