using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Msgsms.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SmsSignatureReq 
    {

        /// <summary>
        /// 应用主键ID
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 申请说明
        /// </summary>
        [JsonProperty("apply_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyDesc { get; set; }

        /// <summary>
        /// 营业执照文件ID
        /// </summary>
        [JsonProperty("file_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FileId { get; set; }

        /// <summary>
        /// 是否涉及第三方权益 1. Yes: 是 2. No:
        /// </summary>
        [JsonProperty("is_involved_third", NullValueHandling = NullValueHandling.Ignore)]
        public string IsInvolvedThird { get; set; }

        /// <summary>
        /// 授权委托书文件ID
        /// </summary>
        [JsonProperty("power_attorney_fileid", NullValueHandling = NullValueHandling.Ignore)]
        public string PowerAttorneyFileid { get; set; }

        /// <summary>
        /// 签名名称
        /// </summary>
        [JsonProperty("signature_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SignatureName { get; set; }

        /// <summary>
        /// 签名来源。支持枚举值： 1. 0：企事业单位的全称或简称 2. 1：工信部备案网站的全称或简称 3. 2： APP应用的全称或简称 4. 3：公众号或小程序的全称或简称 5. 4：电商平台店铺名的全称或简称 6. 5：商标名的全称或简称
        /// </summary>
        [JsonProperty("signature_source", NullValueHandling = NullValueHandling.Ignore)]
        public int? SignatureSource { get; set; }

        /// <summary>
        /// 签名类型。支持枚举值： 1. VERIFY_CODE_TYPE: 验证码类 2. PROMOTION_TYPE: 推广类 3. NOTIFY_TYPE: 通知类
        /// </summary>
        [JsonProperty("signature_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SignatureType { get; set; }

        /// <summary>
        /// 签名来源标题内容
        /// </summary>
        [JsonProperty("source_title_content", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceTitleContent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsSignatureReq {\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  applyDesc: ").Append(ApplyDesc).Append("\n");
            sb.Append("  fileId: ").Append(FileId).Append("\n");
            sb.Append("  isInvolvedThird: ").Append(IsInvolvedThird).Append("\n");
            sb.Append("  powerAttorneyFileid: ").Append(PowerAttorneyFileid).Append("\n");
            sb.Append("  signatureName: ").Append(SignatureName).Append("\n");
            sb.Append("  signatureSource: ").Append(SignatureSource).Append("\n");
            sb.Append("  signatureType: ").Append(SignatureType).Append("\n");
            sb.Append("  sourceTitleContent: ").Append(SourceTitleContent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmsSignatureReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmsSignatureReq input)
        {
            if (input == null) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.ApplyDesc != input.ApplyDesc || (this.ApplyDesc != null && !this.ApplyDesc.Equals(input.ApplyDesc))) return false;
            if (this.FileId != input.FileId || (this.FileId != null && !this.FileId.Equals(input.FileId))) return false;
            if (this.IsInvolvedThird != input.IsInvolvedThird || (this.IsInvolvedThird != null && !this.IsInvolvedThird.Equals(input.IsInvolvedThird))) return false;
            if (this.PowerAttorneyFileid != input.PowerAttorneyFileid || (this.PowerAttorneyFileid != null && !this.PowerAttorneyFileid.Equals(input.PowerAttorneyFileid))) return false;
            if (this.SignatureName != input.SignatureName || (this.SignatureName != null && !this.SignatureName.Equals(input.SignatureName))) return false;
            if (this.SignatureSource != input.SignatureSource || (this.SignatureSource != null && !this.SignatureSource.Equals(input.SignatureSource))) return false;
            if (this.SignatureType != input.SignatureType || (this.SignatureType != null && !this.SignatureType.Equals(input.SignatureType))) return false;
            if (this.SourceTitleContent != input.SourceTitleContent || (this.SourceTitleContent != null && !this.SourceTitleContent.Equals(input.SourceTitleContent))) return false;

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
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.ApplyDesc != null) hashCode = hashCode * 59 + this.ApplyDesc.GetHashCode();
                if (this.FileId != null) hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.IsInvolvedThird != null) hashCode = hashCode * 59 + this.IsInvolvedThird.GetHashCode();
                if (this.PowerAttorneyFileid != null) hashCode = hashCode * 59 + this.PowerAttorneyFileid.GetHashCode();
                if (this.SignatureName != null) hashCode = hashCode * 59 + this.SignatureName.GetHashCode();
                if (this.SignatureSource != null) hashCode = hashCode * 59 + this.SignatureSource.GetHashCode();
                if (this.SignatureType != null) hashCode = hashCode * 59 + this.SignatureType.GetHashCode();
                if (this.SourceTitleContent != null) hashCode = hashCode * 59 + this.SourceTitleContent.GetHashCode();
                return hashCode;
            }
        }
    }
}
