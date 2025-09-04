using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateCustomerV2Req 
    {

        /// <summary>
        /// 客户的华为云账号名。 如果为空，随机生成。 不能以“op_”或“shadow_”开头且不能全为数字。 校验长度（5到32位）和规则^\\(\\[a-zA-Z_-\\]\\(\\[a-zA-Z0-9_-\\]\\)\\*\\)$。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 邮箱地址。 格式：必须含有@。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 验证码。 请调用“发送验证码”接口获取。 如果邮箱不存在，不需要输入验证码。
        /// </summary>
        [JsonProperty("verification_code", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationCode { get; set; }

        /// <summary>
        /// 客户所属国家地区的两位字母编号。该字母编号遵循ISO 3166标准。 例如：墨西哥 MX
        /// </summary>
        [JsonProperty("domain_area", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainArea { get; set; }

        /// <summary>
        /// 伙伴销售平台的用户唯一标识，该标识的具体值由伙伴分配。
        /// </summary>
        [JsonProperty("xaccount_id", NullValueHandling = NullValueHandling.Ignore)]
        public string XaccountId { get; set; }

        /// <summary>
        /// 华为分给合作伙伴的平台标识。 该标识的具体值由华为分配。获取方法请参见[如何获取xaccountType的取值](https://support.huaweicloud.com/intl/zh-cn/api-bpconsole/bpconsole_apifaq_00002.html)。
        /// </summary>
        [JsonProperty("xaccount_type", NullValueHandling = NullValueHandling.Ignore)]
        public string XaccountType { get; set; }

        /// <summary>
        /// 密码规则如下： 至少包含以下四种字符中的两种： 大写字母、小写字母、数字、特殊字符；不能和账号名或倒序的账号名相同；不能包含邮箱。 如果为空，用户没有密码，则不能直接在华为云登录，只能通过伙伴系统SSO方式跳转到华为云。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 是否关闭营销消息的发送： true：关闭false：不关闭（默认）
        /// </summary>
        [JsonProperty("is_close_market_ms", NullValueHandling = NullValueHandling.Ignore)]
        public string IsCloseMarketMs { get; set; }

        /// <summary>
        /// 云经销商ID。获取方法请参见查询云经销商列表。 如果需要创建云经销商的子客户，必须携带该字段。除此之外，此参数不做处理。
        /// </summary>
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }

        /// <summary>
        /// 是否返回子客户的关联结果。 true：返回子客户和伙伴的关联结果false：不返回子客户和伙伴的关联结果 默认值为false。
        /// </summary>
        [JsonProperty("include_association_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeAssociationResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCustomerV2Req {\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  verificationCode: ").Append(VerificationCode).Append("\n");
            sb.Append("  domainArea: ").Append(DomainArea).Append("\n");
            sb.Append("  xaccountId: ").Append(XaccountId).Append("\n");
            sb.Append("  xaccountType: ").Append(XaccountType).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  isCloseMarketMs: ").Append(IsCloseMarketMs).Append("\n");
            sb.Append("  indirectPartnerId: ").Append(IndirectPartnerId).Append("\n");
            sb.Append("  includeAssociationResult: ").Append(IncludeAssociationResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCustomerV2Req);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateCustomerV2Req input)
        {
            if (input == null) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.VerificationCode != input.VerificationCode || (this.VerificationCode != null && !this.VerificationCode.Equals(input.VerificationCode))) return false;
            if (this.DomainArea != input.DomainArea || (this.DomainArea != null && !this.DomainArea.Equals(input.DomainArea))) return false;
            if (this.XaccountId != input.XaccountId || (this.XaccountId != null && !this.XaccountId.Equals(input.XaccountId))) return false;
            if (this.XaccountType != input.XaccountType || (this.XaccountType != null && !this.XaccountType.Equals(input.XaccountType))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.IsCloseMarketMs != input.IsCloseMarketMs || (this.IsCloseMarketMs != null && !this.IsCloseMarketMs.Equals(input.IsCloseMarketMs))) return false;
            if (this.IndirectPartnerId != input.IndirectPartnerId || (this.IndirectPartnerId != null && !this.IndirectPartnerId.Equals(input.IndirectPartnerId))) return false;
            if (this.IncludeAssociationResult != input.IncludeAssociationResult || (this.IncludeAssociationResult != null && !this.IncludeAssociationResult.Equals(input.IncludeAssociationResult))) return false;

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
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.VerificationCode != null) hashCode = hashCode * 59 + this.VerificationCode.GetHashCode();
                if (this.DomainArea != null) hashCode = hashCode * 59 + this.DomainArea.GetHashCode();
                if (this.XaccountId != null) hashCode = hashCode * 59 + this.XaccountId.GetHashCode();
                if (this.XaccountType != null) hashCode = hashCode * 59 + this.XaccountType.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.IsCloseMarketMs != null) hashCode = hashCode * 59 + this.IsCloseMarketMs.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                if (this.IncludeAssociationResult != null) hashCode = hashCode * 59 + this.IncludeAssociationResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
