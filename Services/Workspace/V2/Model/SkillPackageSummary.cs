using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 技能包摘要信息（用于技能详情中的 packages 列表）。
    /// </summary>
    public class SkillPackageSummary 
    {

        /// <summary>
        /// 技能包id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 版本号。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 版本修订号。
        /// </summary>
        [JsonProperty("revision", NullValueHandling = NullValueHandling.Ignore)]
        public int? Revision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("package_status", NullValueHandling = NullValueHandling.Ignore)]
        public PackageStatusEnum? PackageStatus { get; set; }

        /// <summary>
        /// 已部署的区域标识列表。
        /// </summary>
        [JsonProperty("regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Regions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SkillPackageSummary {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  revision: ").Append(Revision).Append("\n");
            sb.Append("  packageStatus: ").Append(PackageStatus).Append("\n");
            sb.Append("  regions: ").Append(Regions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SkillPackageSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SkillPackageSummary input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Revision != input.Revision || (this.Revision != null && !this.Revision.Equals(input.Revision))) return false;
            if (this.PackageStatus != input.PackageStatus || (this.PackageStatus != null && !this.PackageStatus.Equals(input.PackageStatus))) return false;
            if (this.Regions != input.Regions || (this.Regions != null && input.Regions != null && !this.Regions.SequenceEqual(input.Regions))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Revision != null) hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.PackageStatus != null) hashCode = hashCode * 59 + this.PackageStatus.GetHashCode();
                if (this.Regions != null) hashCode = hashCode * 59 + this.Regions.GetHashCode();
                return hashCode;
            }
        }
    }
}
