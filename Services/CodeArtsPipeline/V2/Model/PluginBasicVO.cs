using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PluginBasicVO 
    {

        /// <summary>
        /// **参数解释**： 扩展插件名称。 **取值范围**： 1到50位字符。 
        /// </summary>
        [JsonProperty("plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginName { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// **参数解释**： 插件记录展示名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("db_record_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbRecordName { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件版本号。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件版本号说明。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("version_description", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件描述。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件版本属性。 **取值范围**： - draft：草稿版本。 - formal：正式版本。 
        /// </summary>
        [JsonProperty("version_attribution", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionAttribution { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件唯一ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueId { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件最后更新人。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("op_user", NullValueHandling = NullValueHandling.Ignore)]
        public string OpUser { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件最后更新时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("op_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OpTime { get; set; }

        /// <summary>
        /// **参数解释**： 用于标识插件是否为多个step组成的组合插件。 **取值范围**： - multi：组合插件。 - single：非组合插件。 
        /// </summary>
        [JsonProperty("plugin_composition_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginCompositionType { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件属性。 **取值范围**： - custom：自定义插件。 - official：官方插件。 - published：已发布的发布商插件。 
        /// </summary>
        [JsonProperty("plugin_attribution", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginAttribution { get; set; }

        /// <summary>
        /// **参数解释**： 租户ID，用户的domainId。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件业务类型。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessType { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件业务类型展示名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("business_type_display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessTypeDisplayName { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件维护人。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("maintainers", NullValueHandling = NullValueHandling.Ignore)]
        public string Maintainers { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件图标地址。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IconUrl { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件被流水线引用次数。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("refer_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReferCount { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件被流水线使用次数。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("usage_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsageCount { get; set; }

        /// <summary>
        /// **参数解释**： 运行属性。 **取值范围**： - agent：运行基于流水线agent。 - agentLess：运行无需流水线agent。 
        /// </summary>
        [JsonProperty("runtime_attribution", NullValueHandling = NullValueHandling.Ignore)]
        public string RuntimeAttribution { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件是否激活。 **取值范围**： - true：激活。 - false：未激活。 
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public int? Active { get; set; }

        /// <summary>
        /// **参数解释**： 当前插件版本状态。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("version_state", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionState { get; set; }

        /// <summary>
        /// **参数解释**： 发布商ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("publisher_unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublisherUniqueId { get; set; }

        /// <summary>
        /// **参数解释**： 创建者名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// **参数解释**： 创建时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// **参数解释**： 插件版本标识符。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("manifest_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ManifestVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginBasicVO {\n");
            sb.Append("  pluginName: ").Append(PluginName).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  dbRecordName: ").Append(DbRecordName).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  versionDescription: ").Append(VersionDescription).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  versionAttribution: ").Append(VersionAttribution).Append("\n");
            sb.Append("  uniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  opUser: ").Append(OpUser).Append("\n");
            sb.Append("  opTime: ").Append(OpTime).Append("\n");
            sb.Append("  pluginCompositionType: ").Append(PluginCompositionType).Append("\n");
            sb.Append("  pluginAttribution: ").Append(PluginAttribution).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  businessTypeDisplayName: ").Append(BusinessTypeDisplayName).Append("\n");
            sb.Append("  maintainers: ").Append(Maintainers).Append("\n");
            sb.Append("  iconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  referCount: ").Append(ReferCount).Append("\n");
            sb.Append("  usageCount: ").Append(UsageCount).Append("\n");
            sb.Append("  runtimeAttribution: ").Append(RuntimeAttribution).Append("\n");
            sb.Append("  active: ").Append(Active).Append("\n");
            sb.Append("  versionState: ").Append(VersionState).Append("\n");
            sb.Append("  publisherUniqueId: ").Append(PublisherUniqueId).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  manifestVersion: ").Append(ManifestVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PluginBasicVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PluginBasicVO input)
        {
            if (input == null) return false;
            if (this.PluginName != input.PluginName || (this.PluginName != null && !this.PluginName.Equals(input.PluginName))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.DbRecordName != input.DbRecordName || (this.DbRecordName != null && !this.DbRecordName.Equals(input.DbRecordName))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.VersionDescription != input.VersionDescription || (this.VersionDescription != null && !this.VersionDescription.Equals(input.VersionDescription))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.VersionAttribution != input.VersionAttribution || (this.VersionAttribution != null && !this.VersionAttribution.Equals(input.VersionAttribution))) return false;
            if (this.UniqueId != input.UniqueId || (this.UniqueId != null && !this.UniqueId.Equals(input.UniqueId))) return false;
            if (this.OpUser != input.OpUser || (this.OpUser != null && !this.OpUser.Equals(input.OpUser))) return false;
            if (this.OpTime != input.OpTime || (this.OpTime != null && !this.OpTime.Equals(input.OpTime))) return false;
            if (this.PluginCompositionType != input.PluginCompositionType || (this.PluginCompositionType != null && !this.PluginCompositionType.Equals(input.PluginCompositionType))) return false;
            if (this.PluginAttribution != input.PluginAttribution || (this.PluginAttribution != null && !this.PluginAttribution.Equals(input.PluginAttribution))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.BusinessType != input.BusinessType || (this.BusinessType != null && !this.BusinessType.Equals(input.BusinessType))) return false;
            if (this.BusinessTypeDisplayName != input.BusinessTypeDisplayName || (this.BusinessTypeDisplayName != null && !this.BusinessTypeDisplayName.Equals(input.BusinessTypeDisplayName))) return false;
            if (this.Maintainers != input.Maintainers || (this.Maintainers != null && !this.Maintainers.Equals(input.Maintainers))) return false;
            if (this.IconUrl != input.IconUrl || (this.IconUrl != null && !this.IconUrl.Equals(input.IconUrl))) return false;
            if (this.ReferCount != input.ReferCount || (this.ReferCount != null && !this.ReferCount.Equals(input.ReferCount))) return false;
            if (this.UsageCount != input.UsageCount || (this.UsageCount != null && !this.UsageCount.Equals(input.UsageCount))) return false;
            if (this.RuntimeAttribution != input.RuntimeAttribution || (this.RuntimeAttribution != null && !this.RuntimeAttribution.Equals(input.RuntimeAttribution))) return false;
            if (this.Active != input.Active || (this.Active != null && !this.Active.Equals(input.Active))) return false;
            if (this.VersionState != input.VersionState || (this.VersionState != null && !this.VersionState.Equals(input.VersionState))) return false;
            if (this.PublisherUniqueId != input.PublisherUniqueId || (this.PublisherUniqueId != null && !this.PublisherUniqueId.Equals(input.PublisherUniqueId))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.ManifestVersion != input.ManifestVersion || (this.ManifestVersion != null && !this.ManifestVersion.Equals(input.ManifestVersion))) return false;

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
                if (this.PluginName != null) hashCode = hashCode * 59 + this.PluginName.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DbRecordName != null) hashCode = hashCode * 59 + this.DbRecordName.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VersionDescription != null) hashCode = hashCode * 59 + this.VersionDescription.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VersionAttribution != null) hashCode = hashCode * 59 + this.VersionAttribution.GetHashCode();
                if (this.UniqueId != null) hashCode = hashCode * 59 + this.UniqueId.GetHashCode();
                if (this.OpUser != null) hashCode = hashCode * 59 + this.OpUser.GetHashCode();
                if (this.OpTime != null) hashCode = hashCode * 59 + this.OpTime.GetHashCode();
                if (this.PluginCompositionType != null) hashCode = hashCode * 59 + this.PluginCompositionType.GetHashCode();
                if (this.PluginAttribution != null) hashCode = hashCode * 59 + this.PluginAttribution.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.BusinessType != null) hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.BusinessTypeDisplayName != null) hashCode = hashCode * 59 + this.BusinessTypeDisplayName.GetHashCode();
                if (this.Maintainers != null) hashCode = hashCode * 59 + this.Maintainers.GetHashCode();
                if (this.IconUrl != null) hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.ReferCount != null) hashCode = hashCode * 59 + this.ReferCount.GetHashCode();
                if (this.UsageCount != null) hashCode = hashCode * 59 + this.UsageCount.GetHashCode();
                if (this.RuntimeAttribution != null) hashCode = hashCode * 59 + this.RuntimeAttribution.GetHashCode();
                if (this.Active != null) hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.VersionState != null) hashCode = hashCode * 59 + this.VersionState.GetHashCode();
                if (this.PublisherUniqueId != null) hashCode = hashCode * 59 + this.PublisherUniqueId.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ManifestVersion != null) hashCode = hashCode * 59 + this.ManifestVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
