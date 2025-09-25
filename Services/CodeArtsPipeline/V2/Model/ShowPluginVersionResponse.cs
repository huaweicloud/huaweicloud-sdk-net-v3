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
    /// Response Object
    /// </summary>
    public class ShowPluginVersionResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 扩展插件名称。 **取值范围**： 1到50位字符。 
        /// </summary>
        [JsonProperty("plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginName { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件展示名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

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
        /// **参数解释**： 扩展插件版本号。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件唯一ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueId { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件版本说明。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("version_description", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件版本属性。 **取值范围**： - draft：草稿版本。 - formal：正式版本。 
        /// </summary>
        [JsonProperty("version_attribution", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionAttribution { get; set; }

        /// <summary>
        /// **参数解释**： 用于标识扩展插件是否为多个step组成的组合插件。 **取值范围**： - multi：组合插件。 - single：非组合插件。 
        /// </summary>
        [JsonProperty("plugin_composition_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginCompositionType { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件属性。 **取值范围**： - custom：自定义插件。 - official：官方插件。 - published：已发布的发布商插件。 
        /// </summary>
        [JsonProperty("plugin_attribution", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginAttribution { get; set; }

        /// <summary>
        /// **参数解释**： 插件输入项详细信息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("input_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<PluginInstanceVOInputInfo> InputInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("plugin_execution", NullValueHandling = NullValueHandling.Ignore)]
        public PluginExecutionVO PluginExecution { get; set; }

        /// <summary>
        /// **参数解释**： 运行属性。 **取值范围**： - agent：运行基于流水线agent。 - agentLess：运行无需流水线agent。 
        /// </summary>
        [JsonProperty("runtime_attribution", NullValueHandling = NullValueHandling.Ignore)]
        public string RuntimeAttribution { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPluginVersionResponse {\n");
            sb.Append("  pluginName: ").Append(PluginName).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  opUser: ").Append(OpUser).Append("\n");
            sb.Append("  opTime: ").Append(OpTime).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  uniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  versionDescription: ").Append(VersionDescription).Append("\n");
            sb.Append("  versionAttribution: ").Append(VersionAttribution).Append("\n");
            sb.Append("  pluginCompositionType: ").Append(PluginCompositionType).Append("\n");
            sb.Append("  pluginAttribution: ").Append(PluginAttribution).Append("\n");
            sb.Append("  inputInfo: ").Append(InputInfo).Append("\n");
            sb.Append("  pluginExecution: ").Append(PluginExecution).Append("\n");
            sb.Append("  runtimeAttribution: ").Append(RuntimeAttribution).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPluginVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPluginVersionResponse input)
        {
            if (input == null) return false;
            if (this.PluginName != input.PluginName || (this.PluginName != null && !this.PluginName.Equals(input.PluginName))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.OpUser != input.OpUser || (this.OpUser != null && !this.OpUser.Equals(input.OpUser))) return false;
            if (this.OpTime != input.OpTime || (this.OpTime != null && !this.OpTime.Equals(input.OpTime))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.UniqueId != input.UniqueId || (this.UniqueId != null && !this.UniqueId.Equals(input.UniqueId))) return false;
            if (this.VersionDescription != input.VersionDescription || (this.VersionDescription != null && !this.VersionDescription.Equals(input.VersionDescription))) return false;
            if (this.VersionAttribution != input.VersionAttribution || (this.VersionAttribution != null && !this.VersionAttribution.Equals(input.VersionAttribution))) return false;
            if (this.PluginCompositionType != input.PluginCompositionType || (this.PluginCompositionType != null && !this.PluginCompositionType.Equals(input.PluginCompositionType))) return false;
            if (this.PluginAttribution != input.PluginAttribution || (this.PluginAttribution != null && !this.PluginAttribution.Equals(input.PluginAttribution))) return false;
            if (this.InputInfo != input.InputInfo || (this.InputInfo != null && input.InputInfo != null && !this.InputInfo.SequenceEqual(input.InputInfo))) return false;
            if (this.PluginExecution != input.PluginExecution || (this.PluginExecution != null && !this.PluginExecution.Equals(input.PluginExecution))) return false;
            if (this.RuntimeAttribution != input.RuntimeAttribution || (this.RuntimeAttribution != null && !this.RuntimeAttribution.Equals(input.RuntimeAttribution))) return false;

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
                if (this.OpUser != null) hashCode = hashCode * 59 + this.OpUser.GetHashCode();
                if (this.OpTime != null) hashCode = hashCode * 59 + this.OpTime.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.UniqueId != null) hashCode = hashCode * 59 + this.UniqueId.GetHashCode();
                if (this.VersionDescription != null) hashCode = hashCode * 59 + this.VersionDescription.GetHashCode();
                if (this.VersionAttribution != null) hashCode = hashCode * 59 + this.VersionAttribution.GetHashCode();
                if (this.PluginCompositionType != null) hashCode = hashCode * 59 + this.PluginCompositionType.GetHashCode();
                if (this.PluginAttribution != null) hashCode = hashCode * 59 + this.PluginAttribution.GetHashCode();
                if (this.InputInfo != null) hashCode = hashCode * 59 + this.InputInfo.GetHashCode();
                if (this.PluginExecution != null) hashCode = hashCode * 59 + this.PluginExecution.GetHashCode();
                if (this.RuntimeAttribution != null) hashCode = hashCode * 59 + this.RuntimeAttribution.GetHashCode();
                return hashCode;
            }
        }
    }
}
