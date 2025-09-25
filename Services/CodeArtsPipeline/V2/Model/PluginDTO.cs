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
    public class PluginDTO 
    {

        /// <summary>
        /// **参数解释**： 扩展插件唯一ID。可以通过[查询插件版本详情](ShowPluginVersion.xml)接口，获取响应参数中unique_id。 **约束限制**： 不涉及。 **取值范围**： 32位字符，由数字和字母组成。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueId { get; set; }

        /// <summary>
        /// **参数解释**： 插件展示图标URL。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IconUrl { get; set; }

        /// <summary>
        /// **参数解释**： 运行属性。 **约束限制**： 不涉及。 **取值范围**： - agent：基于agent运行。 - agentless：无需agent运行。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("runtime_attribution", NullValueHandling = NullValueHandling.Ignore)]
        public string RuntimeAttribution { get; set; }

        /// <summary>
        /// **参数解释**： 插件名。 **约束限制**： 仅支持输入大小写英文字母、数字、&#39;-&#39;、&#39;_&#39;。 **取值范围**： 1到50位字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginName { get; set; }

        /// <summary>
        /// **参数解释**： 展示名。 **约束限制**： 仅支持输入大小写英文字母、中文、空格、数字、&#39;-&#39;、&#39;_&#39;、&#39;.&#39;。 **取值范围**： 1到50位字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// **参数解释**： 业务类型。 **约束限制**： 仅支持输入大小写英文字母、数字、&#39;-&#39;、&#39;_&#39;。 **取值范围**： 1到50位字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessType { get; set; }

        /// <summary>
        /// **参数解释**： 插件业务类型展示名。 **约束限制**： 不涉及。 **取值范围**： - 构建。 - 代码检查。 - 部署。 - 测试。 - 通用。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("business_type_display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessTypeDisplayName { get; set; }

        /// <summary>
        /// **参数解释**： 插件描述。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 是否私有插件。 **约束限制**： 不涉及。 **取值范围**： - 1：私有插件。 - 0：公开插件。 **默认取值**： 0。 
        /// </summary>
        [JsonProperty("is_private", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsPrivate { get; set; }

        /// <summary>
        /// **参数解释**： 局点。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// **参数解释**： 插件维护者。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("maintainers", NullValueHandling = NullValueHandling.Ignore)]
        public string Maintainers { get; set; }

        /// <summary>
        /// **参数解释**： 插件的组合类型。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_composition_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginCompositionType { get; set; }

        /// <summary>
        /// **参数解释**： 用于区分新旧版数据版本。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("manifest_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ManifestVersion { get; set; }

        /// <summary>
        /// **参数解释**： 插件版本号。 **约束限制**： 必须是类似 x.xx.xx（例如：1.0.2） 的格式，其中：x 是 1 到 2 位的数字（范围 0 到 99）。xx 是点后跟随的数字部分，且每部分可以是 1 位或 2 位数字。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**： 插件小版本版本号说明。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("version_description", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("execution_info", NullValueHandling = NullValueHandling.Ignore)]
        public PluginDTOExecutionInfo ExecutionInfo { get; set; }

        /// <summary>
        /// **参数解释**： 插件输出相关内容。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("output_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<PluginDTOOutputInfo> OutputInfo { get; set; }

        /// <summary>
        /// **参数解释**： 输入信息。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("input_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<PluginDTOInputInfo> InputInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginDTO {\n");
            sb.Append("  uniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  iconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  runtimeAttribution: ").Append(RuntimeAttribution).Append("\n");
            sb.Append("  pluginName: ").Append(PluginName).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  businessTypeDisplayName: ").Append(BusinessTypeDisplayName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isPrivate: ").Append(IsPrivate).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  maintainers: ").Append(Maintainers).Append("\n");
            sb.Append("  pluginCompositionType: ").Append(PluginCompositionType).Append("\n");
            sb.Append("  manifestVersion: ").Append(ManifestVersion).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  versionDescription: ").Append(VersionDescription).Append("\n");
            sb.Append("  executionInfo: ").Append(ExecutionInfo).Append("\n");
            sb.Append("  outputInfo: ").Append(OutputInfo).Append("\n");
            sb.Append("  inputInfo: ").Append(InputInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PluginDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PluginDTO input)
        {
            if (input == null) return false;
            if (this.UniqueId != input.UniqueId || (this.UniqueId != null && !this.UniqueId.Equals(input.UniqueId))) return false;
            if (this.IconUrl != input.IconUrl || (this.IconUrl != null && !this.IconUrl.Equals(input.IconUrl))) return false;
            if (this.RuntimeAttribution != input.RuntimeAttribution || (this.RuntimeAttribution != null && !this.RuntimeAttribution.Equals(input.RuntimeAttribution))) return false;
            if (this.PluginName != input.PluginName || (this.PluginName != null && !this.PluginName.Equals(input.PluginName))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.BusinessType != input.BusinessType || (this.BusinessType != null && !this.BusinessType.Equals(input.BusinessType))) return false;
            if (this.BusinessTypeDisplayName != input.BusinessTypeDisplayName || (this.BusinessTypeDisplayName != null && !this.BusinessTypeDisplayName.Equals(input.BusinessTypeDisplayName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IsPrivate != input.IsPrivate || (this.IsPrivate != null && !this.IsPrivate.Equals(input.IsPrivate))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Maintainers != input.Maintainers || (this.Maintainers != null && !this.Maintainers.Equals(input.Maintainers))) return false;
            if (this.PluginCompositionType != input.PluginCompositionType || (this.PluginCompositionType != null && !this.PluginCompositionType.Equals(input.PluginCompositionType))) return false;
            if (this.ManifestVersion != input.ManifestVersion || (this.ManifestVersion != null && !this.ManifestVersion.Equals(input.ManifestVersion))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.VersionDescription != input.VersionDescription || (this.VersionDescription != null && !this.VersionDescription.Equals(input.VersionDescription))) return false;
            if (this.ExecutionInfo != input.ExecutionInfo || (this.ExecutionInfo != null && !this.ExecutionInfo.Equals(input.ExecutionInfo))) return false;
            if (this.OutputInfo != input.OutputInfo || (this.OutputInfo != null && input.OutputInfo != null && !this.OutputInfo.SequenceEqual(input.OutputInfo))) return false;
            if (this.InputInfo != input.InputInfo || (this.InputInfo != null && input.InputInfo != null && !this.InputInfo.SequenceEqual(input.InputInfo))) return false;

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
                if (this.IconUrl != null) hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.RuntimeAttribution != null) hashCode = hashCode * 59 + this.RuntimeAttribution.GetHashCode();
                if (this.PluginName != null) hashCode = hashCode * 59 + this.PluginName.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.BusinessType != null) hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.BusinessTypeDisplayName != null) hashCode = hashCode * 59 + this.BusinessTypeDisplayName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsPrivate != null) hashCode = hashCode * 59 + this.IsPrivate.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Maintainers != null) hashCode = hashCode * 59 + this.Maintainers.GetHashCode();
                if (this.PluginCompositionType != null) hashCode = hashCode * 59 + this.PluginCompositionType.GetHashCode();
                if (this.ManifestVersion != null) hashCode = hashCode * 59 + this.ManifestVersion.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VersionDescription != null) hashCode = hashCode * 59 + this.VersionDescription.GetHashCode();
                if (this.ExecutionInfo != null) hashCode = hashCode * 59 + this.ExecutionInfo.GetHashCode();
                if (this.OutputInfo != null) hashCode = hashCode * 59 + this.OutputInfo.GetHashCode();
                if (this.InputInfo != null) hashCode = hashCode * 59 + this.InputInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
