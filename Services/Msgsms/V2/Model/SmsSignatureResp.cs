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
    public class SmsSignatureResp 
    {

        /// <summary>
        /// 签名主键id，用于获取、修改、删除、申请激活签名的唯一标识
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 创建时间[yyyy-MM-dd HH:mm:ss]
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间[yyyy-MM-dd HH:mm:ss]
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 租户customer id
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tenant", NullValueHandling = NullValueHandling.Ignore)]
        public TenantBasic Tenant { get; set; }

        /// <summary>
        /// 签名名称
        /// </summary>
        [JsonProperty("signature_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SignatureName { get; set; }

        /// <summary>
        /// 签名id
        /// </summary>
        [JsonProperty("signature_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SignatureId { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        [JsonProperty("signature_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SignatureType { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 申请描述
        /// </summary>
        [JsonProperty("apply_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyDesc { get; set; }

        /// <summary>
        /// 国内短信通道号，仅当签名审核成功，运营人员配置完成后返回。
        /// </summary>
        [JsonProperty("channel_num", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelNum { get; set; }

        /// <summary>
        /// 审核意见
        /// </summary>
        [JsonProperty("review_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewDesc { get; set; }

        /// <summary>
        /// 文件id
        /// </summary>
        [JsonProperty("file_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FileId { get; set; }

        /// <summary>
        /// 签名状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 站点
        /// </summary>
        [JsonProperty("site", NullValueHandling = NullValueHandling.Ignore)]
        public string Site { get; set; }

        /// <summary>
        /// 签名来源
        /// </summary>
        [JsonProperty("signature_source", NullValueHandling = NullValueHandling.Ignore)]
        public int? SignatureSource { get; set; }

        /// <summary>
        /// 是否涉及第三方权益
        /// </summary>
        [JsonProperty("is_involved_third", NullValueHandling = NullValueHandling.Ignore)]
        public string IsInvolvedThird { get; set; }

        /// <summary>
        /// 授权委托书文件ID
        /// </summary>
        [JsonProperty("power_attorney_file_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PowerAttorneyFileId { get; set; }

        /// <summary>
        /// 催审状态
        /// </summary>
        [JsonProperty("urge_status", NullValueHandling = NullValueHandling.Ignore)]
        public string UrgeStatus { get; set; }

        /// <summary>
        /// 催审时间
        /// </summary>
        [JsonProperty("urge_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UrgeTime { get; set; }

        /// <summary>
        /// 催审描述
        /// </summary>
        [JsonProperty("urge_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string UrgeDesc { get; set; }

        /// <summary>
        /// 应用key
        /// </summary>
        [JsonProperty("app_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AppKey { get; set; }

        /// <summary>
        /// 标题内容
        /// </summary>
        [JsonProperty("source_title_content", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceTitleContent { get; set; }

        /// <summary>
        /// 签名用途
        /// </summary>
        [JsonProperty("signature_usage", NullValueHandling = NullValueHandling.Ignore)]
        public string SignatureUsage { get; set; }

        /// <summary>
        /// 资质ID
        /// </summary>
        [JsonProperty("qualification_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QualificationId { get; set; }

        /// <summary>
        /// 资质名
        /// </summary>
        [JsonProperty("qualification_name", NullValueHandling = NullValueHandling.Ignore)]
        public string QualificationName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsSignatureResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  tenant: ").Append(Tenant).Append("\n");
            sb.Append("  signatureName: ").Append(SignatureName).Append("\n");
            sb.Append("  signatureId: ").Append(SignatureId).Append("\n");
            sb.Append("  signatureType: ").Append(SignatureType).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  applyDesc: ").Append(ApplyDesc).Append("\n");
            sb.Append("  channelNum: ").Append(ChannelNum).Append("\n");
            sb.Append("  reviewDesc: ").Append(ReviewDesc).Append("\n");
            sb.Append("  fileId: ").Append(FileId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  site: ").Append(Site).Append("\n");
            sb.Append("  signatureSource: ").Append(SignatureSource).Append("\n");
            sb.Append("  isInvolvedThird: ").Append(IsInvolvedThird).Append("\n");
            sb.Append("  powerAttorneyFileId: ").Append(PowerAttorneyFileId).Append("\n");
            sb.Append("  urgeStatus: ").Append(UrgeStatus).Append("\n");
            sb.Append("  urgeTime: ").Append(UrgeTime).Append("\n");
            sb.Append("  urgeDesc: ").Append(UrgeDesc).Append("\n");
            sb.Append("  appKey: ").Append(AppKey).Append("\n");
            sb.Append("  sourceTitleContent: ").Append(SourceTitleContent).Append("\n");
            sb.Append("  signatureUsage: ").Append(SignatureUsage).Append("\n");
            sb.Append("  qualificationId: ").Append(QualificationId).Append("\n");
            sb.Append("  qualificationName: ").Append(QualificationName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmsSignatureResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmsSignatureResp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.Tenant != input.Tenant || (this.Tenant != null && !this.Tenant.Equals(input.Tenant))) return false;
            if (this.SignatureName != input.SignatureName || (this.SignatureName != null && !this.SignatureName.Equals(input.SignatureName))) return false;
            if (this.SignatureId != input.SignatureId || (this.SignatureId != null && !this.SignatureId.Equals(input.SignatureId))) return false;
            if (this.SignatureType != input.SignatureType || (this.SignatureType != null && !this.SignatureType.Equals(input.SignatureType))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.ApplyDesc != input.ApplyDesc || (this.ApplyDesc != null && !this.ApplyDesc.Equals(input.ApplyDesc))) return false;
            if (this.ChannelNum != input.ChannelNum || (this.ChannelNum != null && !this.ChannelNum.Equals(input.ChannelNum))) return false;
            if (this.ReviewDesc != input.ReviewDesc || (this.ReviewDesc != null && !this.ReviewDesc.Equals(input.ReviewDesc))) return false;
            if (this.FileId != input.FileId || (this.FileId != null && !this.FileId.Equals(input.FileId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Site != input.Site || (this.Site != null && !this.Site.Equals(input.Site))) return false;
            if (this.SignatureSource != input.SignatureSource || (this.SignatureSource != null && !this.SignatureSource.Equals(input.SignatureSource))) return false;
            if (this.IsInvolvedThird != input.IsInvolvedThird || (this.IsInvolvedThird != null && !this.IsInvolvedThird.Equals(input.IsInvolvedThird))) return false;
            if (this.PowerAttorneyFileId != input.PowerAttorneyFileId || (this.PowerAttorneyFileId != null && !this.PowerAttorneyFileId.Equals(input.PowerAttorneyFileId))) return false;
            if (this.UrgeStatus != input.UrgeStatus || (this.UrgeStatus != null && !this.UrgeStatus.Equals(input.UrgeStatus))) return false;
            if (this.UrgeTime != input.UrgeTime || (this.UrgeTime != null && !this.UrgeTime.Equals(input.UrgeTime))) return false;
            if (this.UrgeDesc != input.UrgeDesc || (this.UrgeDesc != null && !this.UrgeDesc.Equals(input.UrgeDesc))) return false;
            if (this.AppKey != input.AppKey || (this.AppKey != null && !this.AppKey.Equals(input.AppKey))) return false;
            if (this.SourceTitleContent != input.SourceTitleContent || (this.SourceTitleContent != null && !this.SourceTitleContent.Equals(input.SourceTitleContent))) return false;
            if (this.SignatureUsage != input.SignatureUsage || (this.SignatureUsage != null && !this.SignatureUsage.Equals(input.SignatureUsage))) return false;
            if (this.QualificationId != input.QualificationId || (this.QualificationId != null && !this.QualificationId.Equals(input.QualificationId))) return false;
            if (this.QualificationName != input.QualificationName || (this.QualificationName != null && !this.QualificationName.Equals(input.QualificationName))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.Tenant != null) hashCode = hashCode * 59 + this.Tenant.GetHashCode();
                if (this.SignatureName != null) hashCode = hashCode * 59 + this.SignatureName.GetHashCode();
                if (this.SignatureId != null) hashCode = hashCode * 59 + this.SignatureId.GetHashCode();
                if (this.SignatureType != null) hashCode = hashCode * 59 + this.SignatureType.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.ApplyDesc != null) hashCode = hashCode * 59 + this.ApplyDesc.GetHashCode();
                if (this.ChannelNum != null) hashCode = hashCode * 59 + this.ChannelNum.GetHashCode();
                if (this.ReviewDesc != null) hashCode = hashCode * 59 + this.ReviewDesc.GetHashCode();
                if (this.FileId != null) hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Site != null) hashCode = hashCode * 59 + this.Site.GetHashCode();
                if (this.SignatureSource != null) hashCode = hashCode * 59 + this.SignatureSource.GetHashCode();
                if (this.IsInvolvedThird != null) hashCode = hashCode * 59 + this.IsInvolvedThird.GetHashCode();
                if (this.PowerAttorneyFileId != null) hashCode = hashCode * 59 + this.PowerAttorneyFileId.GetHashCode();
                if (this.UrgeStatus != null) hashCode = hashCode * 59 + this.UrgeStatus.GetHashCode();
                if (this.UrgeTime != null) hashCode = hashCode * 59 + this.UrgeTime.GetHashCode();
                if (this.UrgeDesc != null) hashCode = hashCode * 59 + this.UrgeDesc.GetHashCode();
                if (this.AppKey != null) hashCode = hashCode * 59 + this.AppKey.GetHashCode();
                if (this.SourceTitleContent != null) hashCode = hashCode * 59 + this.SourceTitleContent.GetHashCode();
                if (this.SignatureUsage != null) hashCode = hashCode * 59 + this.SignatureUsage.GetHashCode();
                if (this.QualificationId != null) hashCode = hashCode * 59 + this.QualificationId.GetHashCode();
                if (this.QualificationName != null) hashCode = hashCode * 59 + this.QualificationName.GetHashCode();
                return hashCode;
            }
        }
    }
}
