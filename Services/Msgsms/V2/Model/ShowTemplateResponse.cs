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
    /// Response Object
    /// </summary>
    public class ShowTemplateResponse : SdkResponse
    {

        /// <summary>
        /// 模板主键ID，用于获取、修改、删除模板以及查询模板变量的唯一标识
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
        /// 模板名称
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板类型
        /// </summary>
        [JsonProperty("template_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateType { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 应用key
        /// </summary>
        [JsonProperty("app_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AppKey { get; set; }

        /// <summary>
        /// 签名主键id
        /// </summary>
        [JsonProperty("sign_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SignId { get; set; }

        /// <summary>
        /// 模板内容
        /// </summary>
        [JsonProperty("template_content", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateContent { get; set; }

        /// <summary>
        /// 是否有变量
        /// </summary>
        [JsonProperty("has_variable", NullValueHandling = NullValueHandling.Ignore)]
        public string HasVariable { get; set; }

        /// <summary>
        /// 申请描述
        /// </summary>
        [JsonProperty("template_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateDesc { get; set; }

        /// <summary>
        /// 审核意见
        /// </summary>
        [JsonProperty("review_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewDesc { get; set; }

        /// <summary>
        /// 审核人账号
        /// </summary>
        [JsonProperty("review_order", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewOrder { get; set; }

        /// <summary>
        /// 流程状态
        /// </summary>
        [JsonProperty("flow_status", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowStatus { get; set; }

        /// <summary>
        /// 是否是通用模板
        /// </summary>
        [JsonProperty("universal_template", NullValueHandling = NullValueHandling.Ignore)]
        public int? UniversalTemplate { get; set; }

        /// <summary>
        /// 模板状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 地域 1. cn：国内 2. intl：国际
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 中括号类型 支持枚举值：  CN: 中文类型  GB: 英文类型
        /// </summary>
        [JsonProperty("brackets", NullValueHandling = NullValueHandling.Ignore)]
        public string Brackets { get; set; }

        /// <summary>
        /// 站点
        /// </summary>
        [JsonProperty("site", NullValueHandling = NullValueHandling.Ignore)]
        public string Site { get; set; }

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
        /// 发送国家1
        /// </summary>
        [JsonProperty("send_country1", NullValueHandling = NullValueHandling.Ignore)]
        public long? SendCountry1 { get; set; }

        /// <summary>
        /// 发送国家2
        /// </summary>
        [JsonProperty("send_country2", NullValueHandling = NullValueHandling.Ignore)]
        public long? SendCountry2 { get; set; }

        /// <summary>
        /// 发送国家3
        /// </summary>
        [JsonProperty("send_country3", NullValueHandling = NullValueHandling.Ignore)]
        public long? SendCountry3 { get; set; }

        /// <summary>
        /// 是否支持多OMP
        /// </summary>
        [JsonProperty("is_support_multiomp", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportMultiomp { get; set; }

        /// <summary>
        /// 国家名称列表，返回发送国家前三名的国家名称，国家名称间以\&quot;~\&quot;分隔
        /// </summary>
        [JsonProperty("country_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTemplateResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  tenant: ").Append(Tenant).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  templateType: ").Append(TemplateType).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  appKey: ").Append(AppKey).Append("\n");
            sb.Append("  signId: ").Append(SignId).Append("\n");
            sb.Append("  templateContent: ").Append(TemplateContent).Append("\n");
            sb.Append("  hasVariable: ").Append(HasVariable).Append("\n");
            sb.Append("  templateDesc: ").Append(TemplateDesc).Append("\n");
            sb.Append("  reviewDesc: ").Append(ReviewDesc).Append("\n");
            sb.Append("  reviewOrder: ").Append(ReviewOrder).Append("\n");
            sb.Append("  flowStatus: ").Append(FlowStatus).Append("\n");
            sb.Append("  universalTemplate: ").Append(UniversalTemplate).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  brackets: ").Append(Brackets).Append("\n");
            sb.Append("  site: ").Append(Site).Append("\n");
            sb.Append("  urgeStatus: ").Append(UrgeStatus).Append("\n");
            sb.Append("  urgeTime: ").Append(UrgeTime).Append("\n");
            sb.Append("  urgeDesc: ").Append(UrgeDesc).Append("\n");
            sb.Append("  sendCountry1: ").Append(SendCountry1).Append("\n");
            sb.Append("  sendCountry2: ").Append(SendCountry2).Append("\n");
            sb.Append("  sendCountry3: ").Append(SendCountry3).Append("\n");
            sb.Append("  isSupportMultiomp: ").Append(IsSupportMultiomp).Append("\n");
            sb.Append("  countryName: ").Append(CountryName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTemplateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.Tenant == input.Tenant ||
                    (this.Tenant != null &&
                    this.Tenant.Equals(input.Tenant))
                ) && 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.TemplateType == input.TemplateType ||
                    (this.TemplateType != null &&
                    this.TemplateType.Equals(input.TemplateType))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.AppKey == input.AppKey ||
                    (this.AppKey != null &&
                    this.AppKey.Equals(input.AppKey))
                ) && 
                (
                    this.SignId == input.SignId ||
                    (this.SignId != null &&
                    this.SignId.Equals(input.SignId))
                ) && 
                (
                    this.TemplateContent == input.TemplateContent ||
                    (this.TemplateContent != null &&
                    this.TemplateContent.Equals(input.TemplateContent))
                ) && 
                (
                    this.HasVariable == input.HasVariable ||
                    (this.HasVariable != null &&
                    this.HasVariable.Equals(input.HasVariable))
                ) && 
                (
                    this.TemplateDesc == input.TemplateDesc ||
                    (this.TemplateDesc != null &&
                    this.TemplateDesc.Equals(input.TemplateDesc))
                ) && 
                (
                    this.ReviewDesc == input.ReviewDesc ||
                    (this.ReviewDesc != null &&
                    this.ReviewDesc.Equals(input.ReviewDesc))
                ) && 
                (
                    this.ReviewOrder == input.ReviewOrder ||
                    (this.ReviewOrder != null &&
                    this.ReviewOrder.Equals(input.ReviewOrder))
                ) && 
                (
                    this.FlowStatus == input.FlowStatus ||
                    (this.FlowStatus != null &&
                    this.FlowStatus.Equals(input.FlowStatus))
                ) && 
                (
                    this.UniversalTemplate == input.UniversalTemplate ||
                    (this.UniversalTemplate != null &&
                    this.UniversalTemplate.Equals(input.UniversalTemplate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.Brackets == input.Brackets ||
                    (this.Brackets != null &&
                    this.Brackets.Equals(input.Brackets))
                ) && 
                (
                    this.Site == input.Site ||
                    (this.Site != null &&
                    this.Site.Equals(input.Site))
                ) && 
                (
                    this.UrgeStatus == input.UrgeStatus ||
                    (this.UrgeStatus != null &&
                    this.UrgeStatus.Equals(input.UrgeStatus))
                ) && 
                (
                    this.UrgeTime == input.UrgeTime ||
                    (this.UrgeTime != null &&
                    this.UrgeTime.Equals(input.UrgeTime))
                ) && 
                (
                    this.UrgeDesc == input.UrgeDesc ||
                    (this.UrgeDesc != null &&
                    this.UrgeDesc.Equals(input.UrgeDesc))
                ) && 
                (
                    this.SendCountry1 == input.SendCountry1 ||
                    (this.SendCountry1 != null &&
                    this.SendCountry1.Equals(input.SendCountry1))
                ) && 
                (
                    this.SendCountry2 == input.SendCountry2 ||
                    (this.SendCountry2 != null &&
                    this.SendCountry2.Equals(input.SendCountry2))
                ) && 
                (
                    this.SendCountry3 == input.SendCountry3 ||
                    (this.SendCountry3 != null &&
                    this.SendCountry3.Equals(input.SendCountry3))
                ) && 
                (
                    this.IsSupportMultiomp == input.IsSupportMultiomp ||
                    (this.IsSupportMultiomp != null &&
                    this.IsSupportMultiomp.Equals(input.IsSupportMultiomp))
                ) && 
                (
                    this.CountryName == input.CountryName ||
                    (this.CountryName != null &&
                    this.CountryName.Equals(input.CountryName))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.Tenant != null)
                    hashCode = hashCode * 59 + this.Tenant.GetHashCode();
                if (this.TemplateName != null)
                    hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.TemplateType != null)
                    hashCode = hashCode * 59 + this.TemplateType.GetHashCode();
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.AppKey != null)
                    hashCode = hashCode * 59 + this.AppKey.GetHashCode();
                if (this.SignId != null)
                    hashCode = hashCode * 59 + this.SignId.GetHashCode();
                if (this.TemplateContent != null)
                    hashCode = hashCode * 59 + this.TemplateContent.GetHashCode();
                if (this.HasVariable != null)
                    hashCode = hashCode * 59 + this.HasVariable.GetHashCode();
                if (this.TemplateDesc != null)
                    hashCode = hashCode * 59 + this.TemplateDesc.GetHashCode();
                if (this.ReviewDesc != null)
                    hashCode = hashCode * 59 + this.ReviewDesc.GetHashCode();
                if (this.ReviewOrder != null)
                    hashCode = hashCode * 59 + this.ReviewOrder.GetHashCode();
                if (this.FlowStatus != null)
                    hashCode = hashCode * 59 + this.FlowStatus.GetHashCode();
                if (this.UniversalTemplate != null)
                    hashCode = hashCode * 59 + this.UniversalTemplate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Brackets != null)
                    hashCode = hashCode * 59 + this.Brackets.GetHashCode();
                if (this.Site != null)
                    hashCode = hashCode * 59 + this.Site.GetHashCode();
                if (this.UrgeStatus != null)
                    hashCode = hashCode * 59 + this.UrgeStatus.GetHashCode();
                if (this.UrgeTime != null)
                    hashCode = hashCode * 59 + this.UrgeTime.GetHashCode();
                if (this.UrgeDesc != null)
                    hashCode = hashCode * 59 + this.UrgeDesc.GetHashCode();
                if (this.SendCountry1 != null)
                    hashCode = hashCode * 59 + this.SendCountry1.GetHashCode();
                if (this.SendCountry2 != null)
                    hashCode = hashCode * 59 + this.SendCountry2.GetHashCode();
                if (this.SendCountry3 != null)
                    hashCode = hashCode * 59 + this.SendCountry3.GetHashCode();
                if (this.IsSupportMultiomp != null)
                    hashCode = hashCode * 59 + this.IsSupportMultiomp.GetHashCode();
                if (this.CountryName != null)
                    hashCode = hashCode * 59 + this.CountryName.GetHashCode();
                return hashCode;
            }
        }
    }
}
