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
    /// HDP最新版本信息。
    /// </summary>
    public class LatestVersionInfo 
    {

        /// <summary>
        /// 租户的HDP最新版本。
        /// </summary>
        [JsonProperty("latest_version", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestVersion { get; set; }

        /// <summary>
        /// HDA类型： * &#x60;SBC&#x60; - 非VDI下SBC类型 * &#x60;OA_APP&#x60; - VDI下非GPU类型 * &#x60;PT_APP&#x60; - VDI下GPU类型
        /// </summary>
        [JsonProperty("hda_type", NullValueHandling = NullValueHandling.Ignore)]
        public string HdaType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LatestVersionInfo {\n");
            sb.Append("  latestVersion: ").Append(LatestVersion).Append("\n");
            sb.Append("  hdaType: ").Append(HdaType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LatestVersionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LatestVersionInfo input)
        {
            if (input == null) return false;
            if (this.LatestVersion != input.LatestVersion || (this.LatestVersion != null && !this.LatestVersion.Equals(input.LatestVersion))) return false;
            if (this.HdaType != input.HdaType || (this.HdaType != null && !this.HdaType.Equals(input.HdaType))) return false;

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
                if (this.HdaType != null) hashCode = hashCode * 59 + this.HdaType.GetHashCode();
                return hashCode;
            }
        }
    }
}
