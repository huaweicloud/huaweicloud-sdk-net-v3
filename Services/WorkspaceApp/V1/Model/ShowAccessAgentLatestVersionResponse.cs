using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAccessAgentLatestVersionResponse : SdkResponse
    {

        /// <summary>
        /// 租户的HDA最新版本。
        /// </summary>
        [JsonProperty("latest_version", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAccessAgentLatestVersionResponse {\n");
            sb.Append("  latestVersion: ").Append(LatestVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAccessAgentLatestVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAccessAgentLatestVersionResponse input)
        {
            if (input == null) return false;
            if (this.LatestVersion != input.LatestVersion || (this.LatestVersion != null && !this.LatestVersion.Equals(input.LatestVersion))) return false;

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
                if (this.LatestVersion != null) hashCode = hashCode * 59 + this.LatestVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
