using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDatabaseAvailableVersionsResponse : SdkResponse
    {

        /// <summary>
        /// 可变更版本
        /// </summary>
        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Versions { get; set; }

        /// <summary>
        /// 当前版本
        /// </summary>
        [JsonProperty("current_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// 最新优选版本
        /// </summary>
        [JsonProperty("latest_version", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestVersion { get; set; }

        /// <summary>
        /// 本系列优选版本，如3.0.8系列优选版本为3.0.8.5
        /// </summary>
        [JsonProperty("current_favored_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentFavoredVersion { get; set; }

        /// <summary>
        /// 当前实例上一个版本
        /// </summary>
        [JsonProperty("previous_version", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDatabaseAvailableVersionsResponse {\n");
            sb.Append("  versions: ").Append(Versions).Append("\n");
            sb.Append("  currentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("  latestVersion: ").Append(LatestVersion).Append("\n");
            sb.Append("  currentFavoredVersion: ").Append(CurrentFavoredVersion).Append("\n");
            sb.Append("  previousVersion: ").Append(PreviousVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDatabaseAvailableVersionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDatabaseAvailableVersionsResponse input)
        {
            if (input == null) return false;
            if (this.Versions != input.Versions || (this.Versions != null && input.Versions != null && !this.Versions.SequenceEqual(input.Versions))) return false;
            if (this.CurrentVersion != input.CurrentVersion || (this.CurrentVersion != null && !this.CurrentVersion.Equals(input.CurrentVersion))) return false;
            if (this.LatestVersion != input.LatestVersion || (this.LatestVersion != null && !this.LatestVersion.Equals(input.LatestVersion))) return false;
            if (this.CurrentFavoredVersion != input.CurrentFavoredVersion || (this.CurrentFavoredVersion != null && !this.CurrentFavoredVersion.Equals(input.CurrentFavoredVersion))) return false;
            if (this.PreviousVersion != input.PreviousVersion || (this.PreviousVersion != null && !this.PreviousVersion.Equals(input.PreviousVersion))) return false;

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
                if (this.Versions != null) hashCode = hashCode * 59 + this.Versions.GetHashCode();
                if (this.CurrentVersion != null) hashCode = hashCode * 59 + this.CurrentVersion.GetHashCode();
                if (this.LatestVersion != null) hashCode = hashCode * 59 + this.LatestVersion.GetHashCode();
                if (this.CurrentFavoredVersion != null) hashCode = hashCode * 59 + this.CurrentFavoredVersion.GetHashCode();
                if (this.PreviousVersion != null) hashCode = hashCode * 59 + this.PreviousVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
