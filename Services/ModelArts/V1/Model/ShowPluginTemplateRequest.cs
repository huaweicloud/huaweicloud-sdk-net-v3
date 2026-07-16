using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowPluginTemplateRequest 
    {

        /// <summary>
        /// **参数解释**：插件模板的名称。 **约束限制**：不涉及。 **取值范围**：可选值如下： - gpu-driver：GPU驱动插件模板信息 - npu-driver：NPU驱动插件模板信息 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("plugintemplate_name", IsPath = true)]
        [JsonProperty("plugintemplate_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PlugintemplateName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPluginTemplateRequest {\n");
            sb.Append("  plugintemplateName: ").Append(PlugintemplateName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPluginTemplateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPluginTemplateRequest input)
        {
            if (input == null) return false;
            if (this.PlugintemplateName != input.PlugintemplateName || (this.PlugintemplateName != null && !this.PlugintemplateName.Equals(input.PlugintemplateName))) return false;

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
                if (this.PlugintemplateName != null) hashCode = hashCode * 59 + this.PlugintemplateName.GetHashCode();
                return hashCode;
            }
        }
    }
}
