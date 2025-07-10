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
    /// 预置模板信息。
    /// </summary>
    public class PredefinedTemplate 
    {

        /// <summary>
        /// 模板名称。
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板描述。
        /// </summary>
        [JsonProperty("template_description", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateDescription { get; set; }

        /// <summary>
        /// 模板类别
        /// </summary>
        [JsonProperty("template_category", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateCategory { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PredefinedTemplate {\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  templateDescription: ").Append(TemplateDescription).Append("\n");
            sb.Append("  templateCategory: ").Append(TemplateCategory).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PredefinedTemplate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PredefinedTemplate input)
        {
            if (input == null) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.TemplateDescription != input.TemplateDescription || (this.TemplateDescription != null && !this.TemplateDescription.Equals(input.TemplateDescription))) return false;
            if (this.TemplateCategory != input.TemplateCategory || (this.TemplateCategory != null && !this.TemplateCategory.Equals(input.TemplateCategory))) return false;

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
                if (this.TemplateDescription != null) hashCode = hashCode * 59 + this.TemplateDescription.GetHashCode();
                if (this.TemplateCategory != null) hashCode = hashCode * 59 + this.TemplateCategory.GetHashCode();
                return hashCode;
            }
        }
    }
}
