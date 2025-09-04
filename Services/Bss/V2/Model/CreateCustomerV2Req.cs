using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateCustomerV2Req 
    {

        /// <summary>
        /// 客户的华为云账号名。 如果为空，随机生成。 不能以“op_”或“shadow_”开头且不能全为数字。 校验长度（5到32位）和规则^([a-zA-Z_-]([a-zA-Z0-9_-])*)$。 此参数不携带或携带值为空串或携带值为null时，随机生成。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 手机号。 目前系统只支持中国的手机号。 示例：13XXXXXXXXX 此参数不携带或携带值为null时，不被赋值；携带值为空串时，赋值为空串。
        /// </summary>
        [JsonProperty("mobile_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 验证码。 请调用“发送验证码”接口获取。 如果手机号不存在，则不需要输入验证码。 此参数不携带或携带值为null时，不做处理；不支持携带值为空串。
        /// </summary>
        [JsonProperty("verification_code", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationCode { get; set; }

        /// <summary>
        /// 伙伴销售平台的用户唯一标识，该标识的具体值由伙伴分配。
        /// </summary>
        [JsonProperty("xaccount_id", NullValueHandling = NullValueHandling.Ignore)]
        public string XaccountId { get; set; }

        /// <summary>
        /// 华为分给合作伙伴的平台标识。 该标识的具体值由华为分配。获取方法请参见如何获取xaccountType的取值。
        /// </summary>
        [JsonProperty("xaccount_type", NullValueHandling = NullValueHandling.Ignore)]
        public string XaccountType { get; set; }

        /// <summary>
        /// 密码规则如下： 至少包含以下四种字符中的两种： 大写字母、小写字母、数字、特殊字符；不能和账号名或倒序的账号名相同；不能包含手机号。 如果为空，用户没有密码，则不能直接在华为云登录，只能通过伙伴系统SSO方式跳转到华为云。 此参数不携带或携带值为null时，密码随机生成；不支持携带值为空串。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 是否关闭营销消息的发送。 true：关闭false：不关闭（默认） 此参数不携带或携带值为空串或携带值为null时，赋值为false。
        /// </summary>
        [JsonProperty("is_close_market_ms", NullValueHandling = NullValueHandling.Ignore)]
        public string IsCloseMarketMs { get; set; }

        /// <summary>
        /// 合作类型。 1：顾问销售。 不传递或传递非1的值，默认会创建成代售模式的客户。(字段预下线，新用户不再提供)
        /// </summary>
        [JsonProperty("cooperation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CooperationType { get; set; }

        /// <summary>
        /// 云经销商ID。获取方法请参见[查询云经销商列表](https://support.huaweicloud.com/api-bpconsole/espp_00003.html)。 如果需要创建云经销商的子客户，必须携带该字段。除此之外，此参数不做处理。
        /// </summary>
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }

        /// <summary>
        /// 是否返回子客户的关联结果。 true：返回子客户和伙伴的关联结果false：不返回子客户和伙伴的关联结果 默认值为false。 此参数不携带或携带值为空串或携带值为null时，赋值为false。
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
            sb.Append("  mobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  verificationCode: ").Append(VerificationCode).Append("\n");
            sb.Append("  xaccountId: ").Append(XaccountId).Append("\n");
            sb.Append("  xaccountType: ").Append(XaccountType).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  isCloseMarketMs: ").Append(IsCloseMarketMs).Append("\n");
            sb.Append("  cooperationType: ").Append(CooperationType).Append("\n");
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
            if (this.MobilePhone != input.MobilePhone || (this.MobilePhone != null && !this.MobilePhone.Equals(input.MobilePhone))) return false;
            if (this.VerificationCode != input.VerificationCode || (this.VerificationCode != null && !this.VerificationCode.Equals(input.VerificationCode))) return false;
            if (this.XaccountId != input.XaccountId || (this.XaccountId != null && !this.XaccountId.Equals(input.XaccountId))) return false;
            if (this.XaccountType != input.XaccountType || (this.XaccountType != null && !this.XaccountType.Equals(input.XaccountType))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.IsCloseMarketMs != input.IsCloseMarketMs || (this.IsCloseMarketMs != null && !this.IsCloseMarketMs.Equals(input.IsCloseMarketMs))) return false;
            if (this.CooperationType != input.CooperationType || (this.CooperationType != null && !this.CooperationType.Equals(input.CooperationType))) return false;
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
                if (this.MobilePhone != null) hashCode = hashCode * 59 + this.MobilePhone.GetHashCode();
                if (this.VerificationCode != null) hashCode = hashCode * 59 + this.VerificationCode.GetHashCode();
                if (this.XaccountId != null) hashCode = hashCode * 59 + this.XaccountId.GetHashCode();
                if (this.XaccountType != null) hashCode = hashCode * 59 + this.XaccountType.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.IsCloseMarketMs != null) hashCode = hashCode * 59 + this.IsCloseMarketMs.GetHashCode();
                if (this.CooperationType != null) hashCode = hashCode * 59 + this.CooperationType.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                if (this.IncludeAssociationResult != null) hashCode = hashCode * 59 + this.IncludeAssociationResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
