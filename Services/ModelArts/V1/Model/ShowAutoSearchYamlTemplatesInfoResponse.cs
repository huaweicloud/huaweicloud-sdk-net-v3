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
    /// Response Object
    /// </summary>
    public class ShowAutoSearchYamlTemplatesInfoResponse : SdkResponse
    {

        /// <summary>
        /// 所有yaml文件的目录和文件名信息。
        /// </summary>
        [JsonProperty("yaml_templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<YamlTemplate> YamlTemplates { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAutoSearchYamlTemplatesInfoResponse {\n");
            sb.Append("  yamlTemplates: ").Append(YamlTemplates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAutoSearchYamlTemplatesInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAutoSearchYamlTemplatesInfoResponse input)
        {
            if (input == null) return false;
            if (this.YamlTemplates != input.YamlTemplates || (this.YamlTemplates != null && input.YamlTemplates != null && !this.YamlTemplates.SequenceEqual(input.YamlTemplates))) return false;

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
                if (this.YamlTemplates != null) hashCode = hashCode * 59 + this.YamlTemplates.GetHashCode();
                return hashCode;
            }
        }
    }
}
