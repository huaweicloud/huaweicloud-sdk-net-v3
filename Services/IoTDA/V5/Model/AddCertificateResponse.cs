using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AddCertificateResponse : SdkResponse
    {

        /// <summary>
        /// CA证书ID，在上传CA证书时由平台分配的唯一标识。
        /// </summary>
        [JsonProperty("certificate_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificateId { get; set; }

        /// <summary>
        /// CA证书CN名称。
        /// </summary>
        [JsonProperty("cn_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CnName { get; set; }

        /// <summary>
        /// CA证书所有者。
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// CA证书验证状态。true代表证书已通过验证，可进行设备证书认证接入。false代表证书未通过验证。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Status { get; set; }

        /// <summary>
        /// CA证书验证码。
        /// </summary>
        [JsonProperty("verify_code", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifyCode { get; set; }

        /// <summary>
        /// 是否开启自注册能力，当为true时该功能必须配合自注册模板使用，true：是，false：否。
        /// </summary>
        [JsonProperty("provision_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProvisionEnable { get; set; }

        /// <summary>
        /// 绑定的自注册模板ID。
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 创建证书日期。格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如20151212T121212Z。
        /// </summary>
        [JsonProperty("create_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateDate { get; set; }

        /// <summary>
        /// CA证书生效日期。格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如20151212T121212Z。
        /// </summary>
        [JsonProperty("effective_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// CA证书失效日期。格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如20151212T121212Z。
        /// </summary>
        [JsonProperty("expiry_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddCertificateResponse {\n");
            sb.Append("  certificateId: ").Append(CertificateId).Append("\n");
            sb.Append("  cnName: ").Append(CnName).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  verifyCode: ").Append(VerifyCode).Append("\n");
            sb.Append("  provisionEnable: ").Append(ProvisionEnable).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  createDate: ").Append(CreateDate).Append("\n");
            sb.Append("  effectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  expiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddCertificateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddCertificateResponse input)
        {
            if (input == null) return false;
            if (this.CertificateId != input.CertificateId || (this.CertificateId != null && !this.CertificateId.Equals(input.CertificateId))) return false;
            if (this.CnName != input.CnName || (this.CnName != null && !this.CnName.Equals(input.CnName))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.VerifyCode != input.VerifyCode || (this.VerifyCode != null && !this.VerifyCode.Equals(input.VerifyCode))) return false;
            if (this.ProvisionEnable != input.ProvisionEnable || (this.ProvisionEnable != null && !this.ProvisionEnable.Equals(input.ProvisionEnable))) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.CreateDate != input.CreateDate || (this.CreateDate != null && !this.CreateDate.Equals(input.CreateDate))) return false;
            if (this.EffectiveDate != input.EffectiveDate || (this.EffectiveDate != null && !this.EffectiveDate.Equals(input.EffectiveDate))) return false;
            if (this.ExpiryDate != input.ExpiryDate || (this.ExpiryDate != null && !this.ExpiryDate.Equals(input.ExpiryDate))) return false;

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
                if (this.CertificateId != null) hashCode = hashCode * 59 + this.CertificateId.GetHashCode();
                if (this.CnName != null) hashCode = hashCode * 59 + this.CnName.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VerifyCode != null) hashCode = hashCode * 59 + this.VerifyCode.GetHashCode();
                if (this.ProvisionEnable != null) hashCode = hashCode * 59 + this.ProvisionEnable.GetHashCode();
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.CreateDate != null) hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.EffectiveDate != null) hashCode = hashCode * 59 + this.EffectiveDate.GetHashCode();
                if (this.ExpiryDate != null) hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
