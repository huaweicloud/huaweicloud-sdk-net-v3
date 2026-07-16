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
    public class ShowNodeConfigTemplateRequest 
    {

        /// <summary>
        /// **参数解释**：节点配置模板的名称。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("nodeconfigtemplate_name", IsPath = true)]
        [JsonProperty("nodeconfigtemplate_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeconfigtemplateName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowNodeConfigTemplateRequest {\n");
            sb.Append("  nodeconfigtemplateName: ").Append(NodeconfigtemplateName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowNodeConfigTemplateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowNodeConfigTemplateRequest input)
        {
            if (input == null) return false;
            if (this.NodeconfigtemplateName != input.NodeconfigtemplateName || (this.NodeconfigtemplateName != null && !this.NodeconfigtemplateName.Equals(input.NodeconfigtemplateName))) return false;

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
                if (this.NodeconfigtemplateName != null) hashCode = hashCode * 59 + this.NodeconfigtemplateName.GetHashCode();
                return hashCode;
            }
        }
    }
}
