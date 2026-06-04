using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResendEmailReq 
    {

        /// <summary>
        /// 邮件模板ID。
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 短信模板ID。
        /// </summary>
        [JsonProperty("phone_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneTemplateId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResendEmailReq {\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  phoneTemplateId: ").Append(PhoneTemplateId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResendEmailReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResendEmailReq input)
        {
            if (input == null) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.PhoneTemplateId != input.PhoneTemplateId || (this.PhoneTemplateId != null && !this.PhoneTemplateId.Equals(input.PhoneTemplateId))) return false;

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
                if (this.PhoneTemplateId != null) hashCode = hashCode * 59 + this.PhoneTemplateId.GetHashCode();
                return hashCode;
            }
        }
    }
}
