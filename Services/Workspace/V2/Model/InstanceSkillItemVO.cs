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
    /// 实例绑定的技能列表项响应。
    /// </summary>
    public class InstanceSkillItemVO 
    {

        /// <summary>
        /// 技能id。
        /// </summary>
        [JsonProperty("skill_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SkillId { get; set; }

        /// <summary>
        /// 技能名称。
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 技能slug。
        /// </summary>
        [JsonProperty("slug", NullValueHandling = NullValueHandling.Ignore)]
        public string Slug { get; set; }

        /// <summary>
        /// 别名。
        /// </summary>
        [JsonProperty("alias_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AliasName { get; set; }

        /// <summary>
        /// 技能描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("owner_type", NullValueHandling = NullValueHandling.Ignore)]
        public SkillOwnerTypeEnum? OwnerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("install_status", NullValueHandling = NullValueHandling.Ignore)]
        public InstallStatusEnum? InstallStatus { get; set; }

        /// <summary>
        /// 安装的技能包id。
        /// </summary>
        [JsonProperty("package_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageId { get; set; }

        /// <summary>
        /// 安装的技能包版本号。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 安装时间（ISO8601格式，UTC时区）。
        /// </summary>
        [JsonProperty("installed_at", NullValueHandling = NullValueHandling.Ignore)]
        public string InstalledAt { get; set; }

        /// <summary>
        /// 技能封面图 base64 编码。
        /// </summary>
        [JsonProperty("cover", NullValueHandling = NullValueHandling.Ignore)]
        public string Cover { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceSkillItemVO {\n");
            sb.Append("  skillId: ").Append(SkillId).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  slug: ").Append(Slug).Append("\n");
            sb.Append("  aliasName: ").Append(AliasName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  ownerType: ").Append(OwnerType).Append("\n");
            sb.Append("  installStatus: ").Append(InstallStatus).Append("\n");
            sb.Append("  packageId: ").Append(PackageId).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  installedAt: ").Append(InstalledAt).Append("\n");
            sb.Append("  cover: ").Append(Cover).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceSkillItemVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceSkillItemVO input)
        {
            if (input == null) return false;
            if (this.SkillId != input.SkillId || (this.SkillId != null && !this.SkillId.Equals(input.SkillId))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.Slug != input.Slug || (this.Slug != null && !this.Slug.Equals(input.Slug))) return false;
            if (this.AliasName != input.AliasName || (this.AliasName != null && !this.AliasName.Equals(input.AliasName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.OwnerType != input.OwnerType || (this.OwnerType != null && !this.OwnerType.Equals(input.OwnerType))) return false;
            if (this.InstallStatus != input.InstallStatus || (this.InstallStatus != null && !this.InstallStatus.Equals(input.InstallStatus))) return false;
            if (this.PackageId != input.PackageId || (this.PackageId != null && !this.PackageId.Equals(input.PackageId))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.InstalledAt != input.InstalledAt || (this.InstalledAt != null && !this.InstalledAt.Equals(input.InstalledAt))) return false;
            if (this.Cover != input.Cover || (this.Cover != null && !this.Cover.Equals(input.Cover))) return false;

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
                if (this.SkillId != null) hashCode = hashCode * 59 + this.SkillId.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Slug != null) hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.AliasName != null) hashCode = hashCode * 59 + this.AliasName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.OwnerType != null) hashCode = hashCode * 59 + this.OwnerType.GetHashCode();
                if (this.InstallStatus != null) hashCode = hashCode * 59 + this.InstallStatus.GetHashCode();
                if (this.PackageId != null) hashCode = hashCode * 59 + this.PackageId.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.InstalledAt != null) hashCode = hashCode * 59 + this.InstalledAt.GetHashCode();
                if (this.Cover != null) hashCode = hashCode * 59 + this.Cover.GetHashCode();
                return hashCode;
            }
        }
    }
}
