using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowTemplateDeployParamsRequest 
    {

        /// <summary>
        /// 模板名称。
        /// </summary>
        [SDKProperty("template_name", IsPath = true)]
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板版本。
        /// </summary>
        [SDKProperty("version", IsQuery = true)]
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTemplateDeployParamsRequest {\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTemplateDeployParamsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTemplateDeployParamsRequest input)
        {
            if (input == null) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }
}
