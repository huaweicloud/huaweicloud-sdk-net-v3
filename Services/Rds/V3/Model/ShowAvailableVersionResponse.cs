using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAvailableVersionResponse : SdkResponse
    {

        /// <summary>
        /// 可选版本列表。
        /// </summary>
        [JsonProperty("available_versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableVersions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAvailableVersionResponse {\n");
            sb.Append("  availableVersions: ").Append(AvailableVersions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAvailableVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAvailableVersionResponse input)
        {
            if (input == null) return false;
            if (this.AvailableVersions != input.AvailableVersions || (this.AvailableVersions != null && input.AvailableVersions != null && !this.AvailableVersions.SequenceEqual(input.AvailableVersions))) return false;

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
                if (this.AvailableVersions != null) hashCode = hashCode * 59 + this.AvailableVersions.GetHashCode();
                return hashCode;
            }
        }
    }
}
