using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.SMSApi.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SmsContent 
    {

        /// <summary>
        /// 群发短信接收方的号码
        /// </summary>
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> To { get; set; }

        /// <summary>
        /// 短信模板ID
        /// </summary>
        [JsonProperty("templateId", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 短信模板的变量值列表
        /// </summary>
        [JsonProperty("templateParas", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TemplateParas { get; set; }

        /// <summary>
        /// 短信签名
        /// </summary>
        [JsonProperty("signature", NullValueHandling = NullValueHandling.Ignore)]
        public string Signature { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsContent {\n");
            sb.Append("  to: ").Append(To).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  templateParas: ").Append(TemplateParas).Append("\n");
            sb.Append("  signature: ").Append(Signature).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmsContent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmsContent input)
        {
            if (input == null) return false;
            if (this.To != input.To || (this.To != null && input.To != null && !this.To.SequenceEqual(input.To))) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.TemplateParas != input.TemplateParas || (this.TemplateParas != null && input.TemplateParas != null && !this.TemplateParas.SequenceEqual(input.TemplateParas))) return false;
            if (this.Signature != input.Signature || (this.Signature != null && !this.Signature.Equals(input.Signature))) return false;

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
                if (this.To != null) hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.TemplateParas != null) hashCode = hashCode * 59 + this.TemplateParas.GetHashCode();
                if (this.Signature != null) hashCode = hashCode * 59 + this.Signature.GetHashCode();
                return hashCode;
            }
        }
    }
}
