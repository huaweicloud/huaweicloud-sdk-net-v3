using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Landing Zone版本详细信息。
    /// </summary>
    public class LandingZoneVersionDetail 
    {

        /// <summary>
        /// Landing Zone版本。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// Landing Zone版本发布时间。
        /// </summary>
        [JsonProperty("release_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// Landing Zone版本发布说明。
        /// </summary>
        [JsonProperty("release_notes", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseNotes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LandingZoneVersionDetail {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  releaseDate: ").Append(ReleaseDate).Append("\n");
            sb.Append("  releaseNotes: ").Append(ReleaseNotes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LandingZoneVersionDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LandingZoneVersionDetail input)
        {
            if (input == null) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.ReleaseDate != input.ReleaseDate || (this.ReleaseDate != null && !this.ReleaseDate.Equals(input.ReleaseDate))) return false;
            if (this.ReleaseNotes != input.ReleaseNotes || (this.ReleaseNotes != null && !this.ReleaseNotes.Equals(input.ReleaseNotes))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ReleaseDate != null) hashCode = hashCode * 59 + this.ReleaseDate.GetHashCode();
                if (this.ReleaseNotes != null) hashCode = hashCode * 59 + this.ReleaseNotes.GetHashCode();
                return hashCode;
            }
        }
    }
}
