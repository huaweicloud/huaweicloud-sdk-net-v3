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
    /// 版本信息
    /// </summary>
    public class UpgradeVersionInfo 
    {

        /// <summary>
        /// 正式版本号，如：v1.19.10
        /// </summary>
        [JsonProperty("release", NullValueHandling = NullValueHandling.Ignore)]
        public string Release { get; set; }

        /// <summary>
        /// 补丁版本号，如r0
        /// </summary>
        [JsonProperty("patch", NullValueHandling = NullValueHandling.Ignore)]
        public string Patch { get; set; }

        /// <summary>
        /// 推荐升级的目标补丁版本号，如r0
        /// </summary>
        [JsonProperty("suggestPatch", NullValueHandling = NullValueHandling.Ignore)]
        public string SuggestPatch { get; set; }

        /// <summary>
        /// 升级目标版本集合
        /// </summary>
        [JsonProperty("targetVersions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TargetVersions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeVersionInfo {\n");
            sb.Append("  release: ").Append(Release).Append("\n");
            sb.Append("  patch: ").Append(Patch).Append("\n");
            sb.Append("  suggestPatch: ").Append(SuggestPatch).Append("\n");
            sb.Append("  targetVersions: ").Append(TargetVersions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeVersionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeVersionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Release == input.Release ||
                    (this.Release != null &&
                    this.Release.Equals(input.Release))
                ) && 
                (
                    this.Patch == input.Patch ||
                    (this.Patch != null &&
                    this.Patch.Equals(input.Patch))
                ) && 
                (
                    this.SuggestPatch == input.SuggestPatch ||
                    (this.SuggestPatch != null &&
                    this.SuggestPatch.Equals(input.SuggestPatch))
                ) && 
                (
                    this.TargetVersions == input.TargetVersions ||
                    this.TargetVersions != null &&
                    input.TargetVersions != null &&
                    this.TargetVersions.SequenceEqual(input.TargetVersions)
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
                if (this.Release != null)
                    hashCode = hashCode * 59 + this.Release.GetHashCode();
                if (this.Patch != null)
                    hashCode = hashCode * 59 + this.Patch.GetHashCode();
                if (this.SuggestPatch != null)
                    hashCode = hashCode * 59 + this.SuggestPatch.GetHashCode();
                if (this.TargetVersions != null)
                    hashCode = hashCode * 59 + this.TargetVersions.GetHashCode();
                return hashCode;
            }
        }
    }
}
