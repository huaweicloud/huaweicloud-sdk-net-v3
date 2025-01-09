using System;
using System.Collections.Generic;
using System.IO;
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
    public class BatchSendSmsRequestBody : IFormDataBody
    {

        /// <summary>
        /// 短信发送方的号码
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public string From { get; set; }

        /// <summary>
        /// 短信接收方的号码
        /// </summary>
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public string To { get; set; }

        /// <summary>
        /// 短信模板ID
        /// </summary>
        [JsonProperty("templateId", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 短信模板的变量值
        /// </summary>
        [JsonProperty("templateParas", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateParas { get; set; }

        /// <summary>
        /// SP的回调地址
        /// </summary>
        [JsonProperty("statusCallback", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusCallback { get; set; }

        /// <summary>
        /// 扩展参数，在状态报告中会原样返回。
        /// </summary>
        [JsonProperty("extend", NullValueHandling = NullValueHandling.Ignore)]
        public string Extend { get; set; }

        /// <summary>
        /// 短信签名
        /// </summary>
        [JsonProperty("signature", NullValueHandling = NullValueHandling.Ignore)]
        public string Signature { get; set; }


        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            if (From != null) {
                formData.Add("from", new FormDataPart<string>(From));
            }
            if (To != null) {
                formData.Add("to", new FormDataPart<string>(To));
            }
            if (TemplateId != null) {
                formData.Add("templateId", new FormDataPart<string>(TemplateId));
            }
            if (TemplateParas != null) {
                formData.Add("templateParas", new FormDataPart<string>(TemplateParas));
            }
            if (StatusCallback != null) {
                formData.Add("statusCallback", new FormDataPart<string>(StatusCallback));
            }
            if (Extend != null) {
                formData.Add("extend", new FormDataPart<string>(Extend));
            }
            if (Signature != null) {
                formData.Add("signature", new FormDataPart<string>(Signature));
            }

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchSendSmsRequestBody {\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  to: ").Append(To).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  templateParas: ").Append(TemplateParas).Append("\n");
            sb.Append("  statusCallback: ").Append(StatusCallback).Append("\n");
            sb.Append("  extend: ").Append(Extend).Append("\n");
            sb.Append("  signature: ").Append(Signature).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchSendSmsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchSendSmsRequestBody input)
        {
            if (input == null) return false;
            if (this.From != input.From || (this.From != null && !this.From.Equals(input.From))) return false;
            if (this.To != input.To || (this.To != null && !this.To.Equals(input.To))) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.TemplateParas != input.TemplateParas || (this.TemplateParas != null && !this.TemplateParas.Equals(input.TemplateParas))) return false;
            if (this.StatusCallback != input.StatusCallback || (this.StatusCallback != null && !this.StatusCallback.Equals(input.StatusCallback))) return false;
            if (this.Extend != input.Extend || (this.Extend != null && !this.Extend.Equals(input.Extend))) return false;
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
                if (this.From != null) hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null) hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.TemplateParas != null) hashCode = hashCode * 59 + this.TemplateParas.GetHashCode();
                if (this.StatusCallback != null) hashCode = hashCode * 59 + this.StatusCallback.GetHashCode();
                if (this.Extend != null) hashCode = hashCode * 59 + this.Extend.GetHashCode();
                if (this.Signature != null) hashCode = hashCode * 59 + this.Signature.GetHashCode();
                return hashCode;
            }
        }
    }
}
