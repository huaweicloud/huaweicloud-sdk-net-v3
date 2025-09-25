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
    public class FullStagePluginsRelationVOPluginsList 
    {

        /// <summary>
        /// **参数解释**： 唯一ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueId { get; set; }

        /// <summary>
        /// **参数解释**： 展示名。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// **参数解释**： 插件名。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginName { get; set; }

        /// <summary>
        /// **参数解释**： 当前插件对后续选择使用的流水线是否为禁用状态，默认为false。 **取值范围**： - true：被禁用。 - false：未被禁用。 
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// **参数解释**： 插件记录展示名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("db_record_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbRecordName { get; set; }

        /// <summary>
        /// **参数解释**： 流水线stage下的分组名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// **参数解释**： 流水线stage下的分组类型。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("group_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupType { get; set; }

        /// <summary>
        /// **参数解释**： 标识是否为官方插件。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_attribution", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginAttribution { get; set; }

        /// <summary>
        /// **参数解释**： 标识是否为多个step组成的组。 **取值范围**： - single：单step插件。 - multi：组合插件。 
        /// </summary>
        [JsonProperty("plugin_composition_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginCompositionType { get; set; }

        /// <summary>
        /// **参数解释**： 运行属性。 **取值范围**： - agent：运行基于流水线agent。 - agentLess：运行无需流水线agent。 
        /// </summary>
        [JsonProperty("runtime_attribution", NullValueHandling = NullValueHandling.Ignore)]
        public string RuntimeAttribution { get; set; }

        /// <summary>
        /// **参数解释**： 基础插件列表。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("all_steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<FullStagePluginsRelationVOAllSteps> AllSteps { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件描述。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 标识是否为一个草稿。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("version_attribution", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionAttribution { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件图标URL。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IconUrl { get; set; }

        /// <summary>
        /// **参数解释**： 标识是否可继续进行添加步骤，默认是1，可进行添加。 **取值范围**： - 0：不可继续进行添加步骤。 - 1：可继续进行添加步骤。 
        /// </summary>
        [JsonProperty("multi_step_editable", NullValueHandling = NullValueHandling.Ignore)]
        public int? MultiStepEditable { get; set; }

        /// <summary>
        /// **参数解释**： 使用位置。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// **参数解释**： 发布商ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("publisher_unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublisherUniqueId { get; set; }

        /// <summary>
        /// **参数解释**： 插件版本标识符。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("manifest_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ManifestVersion { get; set; }

        /// <summary>
        /// **参数解释**： 标识是否为标准化的插件。 **取值范围**： - true：是标准化的插件。 - false：不是标准化的插件。 
        /// </summary>
        [JsonProperty("standard", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Standard { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullStagePluginsRelationVOPluginsList {\n");
            sb.Append("  uniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  pluginName: ").Append(PluginName).Append("\n");
            sb.Append("  disabled: ").Append(Disabled).Append("\n");
            sb.Append("  dbRecordName: ").Append(DbRecordName).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  groupType: ").Append(GroupType).Append("\n");
            sb.Append("  pluginAttribution: ").Append(PluginAttribution).Append("\n");
            sb.Append("  pluginCompositionType: ").Append(PluginCompositionType).Append("\n");
            sb.Append("  runtimeAttribution: ").Append(RuntimeAttribution).Append("\n");
            sb.Append("  allSteps: ").Append(AllSteps).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  versionAttribution: ").Append(VersionAttribution).Append("\n");
            sb.Append("  iconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  multiStepEditable: ").Append(MultiStepEditable).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  publisherUniqueId: ").Append(PublisherUniqueId).Append("\n");
            sb.Append("  manifestVersion: ").Append(ManifestVersion).Append("\n");
            sb.Append("  standard: ").Append(Standard).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FullStagePluginsRelationVOPluginsList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FullStagePluginsRelationVOPluginsList input)
        {
            if (input == null) return false;
            if (this.UniqueId != input.UniqueId || (this.UniqueId != null && !this.UniqueId.Equals(input.UniqueId))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.PluginName != input.PluginName || (this.PluginName != null && !this.PluginName.Equals(input.PluginName))) return false;
            if (this.Disabled != input.Disabled || (this.Disabled != null && !this.Disabled.Equals(input.Disabled))) return false;
            if (this.DbRecordName != input.DbRecordName || (this.DbRecordName != null && !this.DbRecordName.Equals(input.DbRecordName))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.GroupType != input.GroupType || (this.GroupType != null && !this.GroupType.Equals(input.GroupType))) return false;
            if (this.PluginAttribution != input.PluginAttribution || (this.PluginAttribution != null && !this.PluginAttribution.Equals(input.PluginAttribution))) return false;
            if (this.PluginCompositionType != input.PluginCompositionType || (this.PluginCompositionType != null && !this.PluginCompositionType.Equals(input.PluginCompositionType))) return false;
            if (this.RuntimeAttribution != input.RuntimeAttribution || (this.RuntimeAttribution != null && !this.RuntimeAttribution.Equals(input.RuntimeAttribution))) return false;
            if (this.AllSteps != input.AllSteps || (this.AllSteps != null && input.AllSteps != null && !this.AllSteps.SequenceEqual(input.AllSteps))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.VersionAttribution != input.VersionAttribution || (this.VersionAttribution != null && !this.VersionAttribution.Equals(input.VersionAttribution))) return false;
            if (this.IconUrl != input.IconUrl || (this.IconUrl != null && !this.IconUrl.Equals(input.IconUrl))) return false;
            if (this.MultiStepEditable != input.MultiStepEditable || (this.MultiStepEditable != null && !this.MultiStepEditable.Equals(input.MultiStepEditable))) return false;
            if (this.Location != input.Location || (this.Location != null && !this.Location.Equals(input.Location))) return false;
            if (this.PublisherUniqueId != input.PublisherUniqueId || (this.PublisherUniqueId != null && !this.PublisherUniqueId.Equals(input.PublisherUniqueId))) return false;
            if (this.ManifestVersion != input.ManifestVersion || (this.ManifestVersion != null && !this.ManifestVersion.Equals(input.ManifestVersion))) return false;
            if (this.Standard != input.Standard || (this.Standard != null && !this.Standard.Equals(input.Standard))) return false;

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
                if (this.UniqueId != null) hashCode = hashCode * 59 + this.UniqueId.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.PluginName != null) hashCode = hashCode * 59 + this.PluginName.GetHashCode();
                if (this.Disabled != null) hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.DbRecordName != null) hashCode = hashCode * 59 + this.DbRecordName.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.GroupType != null) hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.PluginAttribution != null) hashCode = hashCode * 59 + this.PluginAttribution.GetHashCode();
                if (this.PluginCompositionType != null) hashCode = hashCode * 59 + this.PluginCompositionType.GetHashCode();
                if (this.RuntimeAttribution != null) hashCode = hashCode * 59 + this.RuntimeAttribution.GetHashCode();
                if (this.AllSteps != null) hashCode = hashCode * 59 + this.AllSteps.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VersionAttribution != null) hashCode = hashCode * 59 + this.VersionAttribution.GetHashCode();
                if (this.IconUrl != null) hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.MultiStepEditable != null) hashCode = hashCode * 59 + this.MultiStepEditable.GetHashCode();
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.PublisherUniqueId != null) hashCode = hashCode * 59 + this.PublisherUniqueId.GetHashCode();
                if (this.ManifestVersion != null) hashCode = hashCode * 59 + this.ManifestVersion.GetHashCode();
                if (this.Standard != null) hashCode = hashCode * 59 + this.Standard.GetHashCode();
                return hashCode;
            }
        }
    }
}
