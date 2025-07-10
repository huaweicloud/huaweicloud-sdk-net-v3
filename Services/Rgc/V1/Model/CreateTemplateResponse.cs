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
    /// Response Object
    /// </summary>
    public class CreateTemplateResponse : SdkResponse
    {

        /// <summary>
        /// 模板ID。
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板版本。
        /// </summary>
        [JsonProperty("template_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// 模板名称。
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTemplateResponse {\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  templateVersion: ").Append(TemplateVersion).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTemplateResponse input)
        {
            if (input == null) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.TemplateVersion != input.TemplateVersion || (this.TemplateVersion != null && !this.TemplateVersion.Equals(input.TemplateVersion))) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;

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
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.TemplateVersion != null) hashCode = hashCode * 59 + this.TemplateVersion.GetHashCode();
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                return hashCode;
            }
        }
    }
}
