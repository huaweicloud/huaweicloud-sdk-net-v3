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
    public class ShowBasicPluginResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 插件类型。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 插件名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 插件展示名。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("friendly_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FriendlyName { get; set; }

        /// <summary>
        /// **参数解释**： 业务类型。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**： 插件描述。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 插件版本。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**： 插件版本说明。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("version_description", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// **参数解释**： 输入信息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<NewExtensionInputs> Inputs { get; set; }

        /// <summary>
        /// **参数解释**： 数据源绑定信息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("data_source_bindings", NullValueHandling = NullValueHandling.Ignore)]
        public List<NewExtensionDataSourceBindings> DataSourceBindings { get; set; }

        /// <summary>
        /// **参数解释**： 输出信息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("outputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<NewExtensionOutputs> Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("execution", NullValueHandling = NullValueHandling.Ignore)]
        public NewExtensionExecution Execution { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBasicPluginResponse {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  friendlyName: ").Append(FriendlyName).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  versionDescription: ").Append(VersionDescription).Append("\n");
            sb.Append("  inputs: ").Append(Inputs).Append("\n");
            sb.Append("  dataSourceBindings: ").Append(DataSourceBindings).Append("\n");
            sb.Append("  outputs: ").Append(Outputs).Append("\n");
            sb.Append("  execution: ").Append(Execution).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBasicPluginResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBasicPluginResponse input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.FriendlyName != input.FriendlyName || (this.FriendlyName != null && !this.FriendlyName.Equals(input.FriendlyName))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.VersionDescription != input.VersionDescription || (this.VersionDescription != null && !this.VersionDescription.Equals(input.VersionDescription))) return false;
            if (this.Inputs != input.Inputs || (this.Inputs != null && input.Inputs != null && !this.Inputs.SequenceEqual(input.Inputs))) return false;
            if (this.DataSourceBindings != input.DataSourceBindings || (this.DataSourceBindings != null && input.DataSourceBindings != null && !this.DataSourceBindings.SequenceEqual(input.DataSourceBindings))) return false;
            if (this.Outputs != input.Outputs || (this.Outputs != null && input.Outputs != null && !this.Outputs.SequenceEqual(input.Outputs))) return false;
            if (this.Execution != input.Execution || (this.Execution != null && !this.Execution.Equals(input.Execution))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FriendlyName != null) hashCode = hashCode * 59 + this.FriendlyName.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VersionDescription != null) hashCode = hashCode * 59 + this.VersionDescription.GetHashCode();
                if (this.Inputs != null) hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.DataSourceBindings != null) hashCode = hashCode * 59 + this.DataSourceBindings.GetHashCode();
                if (this.Outputs != null) hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                if (this.Execution != null) hashCode = hashCode * 59 + this.Execution.GetHashCode();
                return hashCode;
            }
        }
    }
}
