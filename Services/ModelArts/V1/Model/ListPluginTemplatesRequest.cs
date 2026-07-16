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
    public class ListPluginTemplatesRequest 
    {

        /// <summary>
        /// **参数解释**：指定的插件名称，填写则查询指定名称的插件。 **约束限制**：不涉及 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("templateName", IsQuery = true)]
        [JsonProperty("templateName", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// **参数解释**：指定的资源池名称，填写则查询符合资源池安装条件的插件列表。 **约束限制**：不涉及 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("poolName", IsQuery = true)]
        [JsonProperty("poolName", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPluginTemplatesRequest {\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  poolName: ").Append(PoolName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPluginTemplatesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPluginTemplatesRequest input)
        {
            if (input == null) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.PoolName != input.PoolName || (this.PoolName != null && !this.PoolName.Equals(input.PoolName))) return false;

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
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.PoolName != null) hashCode = hashCode * 59 + this.PoolName.GetHashCode();
                return hashCode;
            }
        }
    }
}
