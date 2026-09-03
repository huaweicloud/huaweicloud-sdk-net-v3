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
    /// 技能列表项响应。
    /// </summary>
    public class SkillListItemVO 
    {

        /// <summary>
        /// 技能id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 技能slug。
        /// </summary>
        [JsonProperty("slug", NullValueHandling = NullValueHandling.Ignore)]
        public string Slug { get; set; }

        /// <summary>
        /// 技能名称。
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 别名。
        /// </summary>
        [JsonProperty("alias_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AliasName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public SkillCategoryEnum? Category { get; set; }

        /// <summary>
        /// 技能描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 技能标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public SkillStatusEnum? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("visibility_scope", NullValueHandling = NullValueHandling.Ignore)]
        public VisibilityScopeEnum? VisibilityScope { get; set; }

        /// <summary>
        /// 当前生效的技能包id。
        /// </summary>
        [JsonProperty("current_package_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentPackageId { get; set; }

        /// <summary>
        /// 当前生效版本号。
        /// </summary>
        [JsonProperty("current_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// 当前生效版本修订号。
        /// </summary>
        [JsonProperty("current_revision", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentRevision { get; set; }

        /// <summary>
        /// 技能封面图 base64 编码。
        /// </summary>
        [JsonProperty("cover", NullValueHandling = NullValueHandling.Ignore)]
        public string Cover { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public SkillSourceEnum? Source { get; set; }

        /// <summary>
        /// 支持的操作系统类型列表。
        /// </summary>
        [JsonProperty("support_os_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportOsTypes { get; set; }

        /// <summary>
        /// 创建时间（ISO8601格式，UTC时区）。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间（ISO8601格式，UTC时区）。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 已绑定实例数量。
        /// </summary>
        [JsonProperty("attach_instance_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachInstanceNumber { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SkillListItemVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  slug: ").Append(Slug).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  aliasName: ").Append(AliasName).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  visibilityScope: ").Append(VisibilityScope).Append("\n");
            sb.Append("  currentPackageId: ").Append(CurrentPackageId).Append("\n");
            sb.Append("  currentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("  currentRevision: ").Append(CurrentRevision).Append("\n");
            sb.Append("  cover: ").Append(Cover).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  supportOsTypes: ").Append(SupportOsTypes).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  attachInstanceNumber: ").Append(AttachInstanceNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SkillListItemVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SkillListItemVO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Slug != input.Slug || (this.Slug != null && !this.Slug.Equals(input.Slug))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.AliasName != input.AliasName || (this.AliasName != null && !this.AliasName.Equals(input.AliasName))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.VisibilityScope != input.VisibilityScope || (this.VisibilityScope != null && !this.VisibilityScope.Equals(input.VisibilityScope))) return false;
            if (this.CurrentPackageId != input.CurrentPackageId || (this.CurrentPackageId != null && !this.CurrentPackageId.Equals(input.CurrentPackageId))) return false;
            if (this.CurrentVersion != input.CurrentVersion || (this.CurrentVersion != null && !this.CurrentVersion.Equals(input.CurrentVersion))) return false;
            if (this.CurrentRevision != input.CurrentRevision || (this.CurrentRevision != null && !this.CurrentRevision.Equals(input.CurrentRevision))) return false;
            if (this.Cover != input.Cover || (this.Cover != null && !this.Cover.Equals(input.Cover))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.SupportOsTypes != input.SupportOsTypes || (this.SupportOsTypes != null && input.SupportOsTypes != null && !this.SupportOsTypes.SequenceEqual(input.SupportOsTypes))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.AttachInstanceNumber != input.AttachInstanceNumber || (this.AttachInstanceNumber != null && !this.AttachInstanceNumber.Equals(input.AttachInstanceNumber))) return false;

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
                if (this.Slug != null) hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.AliasName != null) hashCode = hashCode * 59 + this.AliasName.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VisibilityScope != null) hashCode = hashCode * 59 + this.VisibilityScope.GetHashCode();
                if (this.CurrentPackageId != null) hashCode = hashCode * 59 + this.CurrentPackageId.GetHashCode();
                if (this.CurrentVersion != null) hashCode = hashCode * 59 + this.CurrentVersion.GetHashCode();
                if (this.CurrentRevision != null) hashCode = hashCode * 59 + this.CurrentRevision.GetHashCode();
                if (this.Cover != null) hashCode = hashCode * 59 + this.Cover.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.SupportOsTypes != null) hashCode = hashCode * 59 + this.SupportOsTypes.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.AttachInstanceNumber != null) hashCode = hashCode * 59 + this.AttachInstanceNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
