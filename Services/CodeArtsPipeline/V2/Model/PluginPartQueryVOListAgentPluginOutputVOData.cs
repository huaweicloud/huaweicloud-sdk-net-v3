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
    public class PluginPartQueryVOListAgentPluginOutputVOData 
    {

        /// <summary>
        /// **参数解释**： 唯一ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueId { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("plugin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PluginName { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件版本号。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**： 租户ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**： 定义的插件输出名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("output_key", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputKey { get; set; }

        /// <summary>
        /// **参数解释**： 定义的插件输出内容。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("output_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginPartQueryVOListAgentPluginOutputVOData {\n");
            sb.Append("  uniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  pluginName: ").Append(PluginName).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  outputKey: ").Append(OutputKey).Append("\n");
            sb.Append("  outputValue: ").Append(OutputValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PluginPartQueryVOListAgentPluginOutputVOData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PluginPartQueryVOListAgentPluginOutputVOData input)
        {
            if (input == null) return false;
            if (this.UniqueId != input.UniqueId || (this.UniqueId != null && !this.UniqueId.Equals(input.UniqueId))) return false;
            if (this.PluginName != input.PluginName || (this.PluginName != null && !this.PluginName.Equals(input.PluginName))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.OutputKey != input.OutputKey || (this.OutputKey != null && !this.OutputKey.Equals(input.OutputKey))) return false;
            if (this.OutputValue != input.OutputValue || (this.OutputValue != null && !this.OutputValue.Equals(input.OutputValue))) return false;

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
                if (this.PluginName != null) hashCode = hashCode * 59 + this.PluginName.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.OutputKey != null) hashCode = hashCode * 59 + this.OutputKey.GetHashCode();
                if (this.OutputValue != null) hashCode = hashCode * 59 + this.OutputValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
