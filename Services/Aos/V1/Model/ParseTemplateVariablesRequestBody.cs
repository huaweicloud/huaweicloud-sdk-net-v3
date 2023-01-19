using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// parse-template-variables request parameters
    /// </summary>
    public class ParseTemplateVariablesRequestBody 
    {

        /// <summary>
        /// HCL模板，描述了资源的目标状态 template_body 和 template_uri 有且仅有一个存在
        /// </summary>
        [JsonProperty("template_body", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// HCL模板文件的uri，代码需从该uri下载HCL模板获取模板内容。其描述了资源的目标状态 template_body 和 template_uri 有且仅有一个存在
        /// </summary>
        [JsonProperty("template_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParseTemplateVariablesRequestBody {\n");
            sb.Append("  templateBody: ").Append(TemplateBody).Append("\n");
            sb.Append("  templateUri: ").Append(TemplateUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParseTemplateVariablesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ParseTemplateVariablesRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateBody == input.TemplateBody ||
                    (this.TemplateBody != null &&
                    this.TemplateBody.Equals(input.TemplateBody))
                ) && 
                (
                    this.TemplateUri == input.TemplateUri ||
                    (this.TemplateUri != null &&
                    this.TemplateUri.Equals(input.TemplateUri))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TemplateBody != null)
                    hashCode = hashCode * 59 + this.TemplateBody.GetHashCode();
                if (this.TemplateUri != null)
                    hashCode = hashCode * 59 + this.TemplateUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
