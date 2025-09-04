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
    public class CustomerInformation 
    {

        /// <summary>
        /// 实名认证名称。
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public string Customer { get; set; }

        /// <summary>
        /// 客户登录名称（如果客户创建了子用户，此处返回主账号登录名称）。
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// 客户账号ID。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 客户和伙伴关联时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”，其中，HH范围是0～23，mm和ss范围是0～59。
        /// </summary>
        [JsonProperty("associated_on", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociatedOn { get; set; }

        /// <summary>
        /// 关联类型： 1：顾问销售2：代售
        /// </summary>
        [JsonProperty("association_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociationType { get; set; }

        /// <summary>
        /// 标签。
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// 客户电话号码。
        /// </summary>
        [JsonProperty("telephone", NullValueHandling = NullValueHandling.Ignore)]
        public string Telephone { get; set; }

        /// <summary>
        /// 实名认证状态： -1：未实名认证0：实名认证审核中1：实名认证不通过2：已实名认证
        /// </summary>
        [JsonProperty("verified_status", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifiedStatus { get; set; }

        /// <summary>
        /// 国家码，电话号码的国家码前缀。 例如：中国 0086。
        /// </summary>
        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        /// <summary>
        /// 客户类型： -1：无类型0：个人1：企业 客户刚注册的时候，没有具体的客户类型，为“-1：无类型”，客户可以在账号中心通过设置客户类型或者在实名认证的时候，选择对应的企业/个人实名认证来决定自己的类型。
        /// </summary>
        [JsonProperty("customer_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerType { get; set; }

        /// <summary>
        /// 是否冻结： 0：否1：客户账号冻结2：客户账号和资源冻结 该字段预留。
        /// </summary>
        [JsonProperty("is_frozen", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsFrozen { get; set; }

        /// <summary>
        /// 该客户对应的客户经理信息，目前只支持1个，具体参见表2。
        /// </summary>
        [JsonProperty("account_managers", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccountManager> AccountManagers { get; set; }

        /// <summary>
        /// 伙伴销售平台的用户唯一标识，该标识的具体值由伙伴分配。
        /// </summary>
        [JsonProperty("xaccount_id", NullValueHandling = NullValueHandling.Ignore)]
        public string XaccountId { get; set; }

        /// <summary>
        /// 华为分配给合作伙伴的平台标识。 该标识的具体值由华为分配。获取方法请参见如何获取xaccountType的取值。
        /// </summary>
        [JsonProperty("xaccount_type", NullValueHandling = NullValueHandling.Ignore)]
        public string XaccountType { get; set; }

        /// <summary>
        /// 客户等级。具体等级体系和权益请参见客户等级体系。 V0V1V2V3V4V5
        /// </summary>
        [JsonProperty("customer_level", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerLevel { get; set; }

        /// <summary>
        /// |参数名称：客户邮箱| |参数的约束及描述：该参数为字符串 范围限制:0-256。|
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerInformation {\n");
            sb.Append("  customer: ").Append(Customer).Append("\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  associatedOn: ").Append(AssociatedOn).Append("\n");
            sb.Append("  associationType: ").Append(AssociationType).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("  telephone: ").Append(Telephone).Append("\n");
            sb.Append("  verifiedStatus: ").Append(VerifiedStatus).Append("\n");
            sb.Append("  countryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  customerType: ").Append(CustomerType).Append("\n");
            sb.Append("  isFrozen: ").Append(IsFrozen).Append("\n");
            sb.Append("  accountManagers: ").Append(AccountManagers).Append("\n");
            sb.Append("  xaccountId: ").Append(XaccountId).Append("\n");
            sb.Append("  xaccountType: ").Append(XaccountType).Append("\n");
            sb.Append("  customerLevel: ").Append(CustomerLevel).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomerInformation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomerInformation input)
        {
            if (input == null) return false;
            if (this.Customer != input.Customer || (this.Customer != null && !this.Customer.Equals(input.Customer))) return false;
            if (this.AccountName != input.AccountName || (this.AccountName != null && !this.AccountName.Equals(input.AccountName))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.AssociatedOn != input.AssociatedOn || (this.AssociatedOn != null && !this.AssociatedOn.Equals(input.AssociatedOn))) return false;
            if (this.AssociationType != input.AssociationType || (this.AssociationType != null && !this.AssociationType.Equals(input.AssociationType))) return false;
            if (this.Label != input.Label || (this.Label != null && !this.Label.Equals(input.Label))) return false;
            if (this.Telephone != input.Telephone || (this.Telephone != null && !this.Telephone.Equals(input.Telephone))) return false;
            if (this.VerifiedStatus != input.VerifiedStatus || (this.VerifiedStatus != null && !this.VerifiedStatus.Equals(input.VerifiedStatus))) return false;
            if (this.CountryCode != input.CountryCode || (this.CountryCode != null && !this.CountryCode.Equals(input.CountryCode))) return false;
            if (this.CustomerType != input.CustomerType || (this.CustomerType != null && !this.CustomerType.Equals(input.CustomerType))) return false;
            if (this.IsFrozen != input.IsFrozen || (this.IsFrozen != null && !this.IsFrozen.Equals(input.IsFrozen))) return false;
            if (this.AccountManagers != input.AccountManagers || (this.AccountManagers != null && input.AccountManagers != null && !this.AccountManagers.SequenceEqual(input.AccountManagers))) return false;
            if (this.XaccountId != input.XaccountId || (this.XaccountId != null && !this.XaccountId.Equals(input.XaccountId))) return false;
            if (this.XaccountType != input.XaccountType || (this.XaccountType != null && !this.XaccountType.Equals(input.XaccountType))) return false;
            if (this.CustomerLevel != input.CustomerLevel || (this.CustomerLevel != null && !this.CustomerLevel.Equals(input.CustomerLevel))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;

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
                if (this.Customer != null) hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.AssociatedOn != null) hashCode = hashCode * 59 + this.AssociatedOn.GetHashCode();
                if (this.AssociationType != null) hashCode = hashCode * 59 + this.AssociationType.GetHashCode();
                if (this.Label != null) hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Telephone != null) hashCode = hashCode * 59 + this.Telephone.GetHashCode();
                if (this.VerifiedStatus != null) hashCode = hashCode * 59 + this.VerifiedStatus.GetHashCode();
                if (this.CountryCode != null) hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.CustomerType != null) hashCode = hashCode * 59 + this.CustomerType.GetHashCode();
                if (this.IsFrozen != null) hashCode = hashCode * 59 + this.IsFrozen.GetHashCode();
                if (this.AccountManagers != null) hashCode = hashCode * 59 + this.AccountManagers.GetHashCode();
                if (this.XaccountId != null) hashCode = hashCode * 59 + this.XaccountId.GetHashCode();
                if (this.XaccountType != null) hashCode = hashCode * 59 + this.XaccountType.GetHashCode();
                if (this.CustomerLevel != null) hashCode = hashCode * 59 + this.CustomerLevel.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                return hashCode;
            }
        }
    }
}
