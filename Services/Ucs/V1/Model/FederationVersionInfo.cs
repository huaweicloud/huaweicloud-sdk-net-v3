using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FederationVersionInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("currentVersion", NullValueHandling = NullValueHandling.Ignore)]
        public FederationVersionSpec CurrentVersion { get; set; }

        /// <summary>
        /// 目标联邦版本列表
        /// </summary>
        [JsonProperty("targetVersions", NullValueHandling = NullValueHandling.Ignore)]
        public List<FederationVersionSpec> TargetVersions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FederationVersionInfo {\n");
            sb.Append("  currentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("  targetVersions: ").Append(TargetVersions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FederationVersionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FederationVersionInfo input)
        {
            if (input == null) return false;
            if (this.CurrentVersion != input.CurrentVersion || (this.CurrentVersion != null && !this.CurrentVersion.Equals(input.CurrentVersion))) return false;
            if (this.TargetVersions != input.TargetVersions || (this.TargetVersions != null && input.TargetVersions != null && !this.TargetVersions.SequenceEqual(input.TargetVersions))) return false;

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
                if (this.CurrentVersion != null) hashCode = hashCode * 59 + this.CurrentVersion.GetHashCode();
                if (this.TargetVersions != null) hashCode = hashCode * 59 + this.TargetVersions.GetHashCode();
                return hashCode;
            }
        }
    }
}
