using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowDependencyVersionRequest 
    {

        /// <summary>
        /// 依赖包的ID。
        /// </summary>
        [SDKProperty("depend_id", IsPath = true)]
        [JsonProperty("depend_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DependId { get; set; }

        /// <summary>
        /// 依赖包版本号。
        /// </summary>
        [SDKProperty("version", IsPath = true)]
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDependencyVersionRequest {\n");
            sb.Append("  dependId: ").Append(DependId).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDependencyVersionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDependencyVersionRequest input)
        {
            if (input == null) return false;
            if (this.DependId != input.DependId || (this.DependId != null && !this.DependId.Equals(input.DependId))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;

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
                if (this.DependId != null) hashCode = hashCode * 59 + this.DependId.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }
}
