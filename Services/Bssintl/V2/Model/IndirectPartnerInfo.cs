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
    public class IndirectPartnerInfo 
    {

        /// <summary>
        /// 云经销商ID。
        /// </summary>
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }

        /// <summary>
        /// 云经销商的手机号码。
        /// </summary>
        [JsonProperty("mobile_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 云经销商的邮箱。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 云经销商的账户名。
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// 云经销商的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 云经销商关联华为云总经销商的时间。 UTC时间（包括时区），例如2016-03-28T00:00:00Z。
        /// </summary>
        [JsonProperty("associated_on", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociatedOn { get; set; }

        /// <summary>
        /// 客户经理登录账户名。
        /// </summary>
        [JsonProperty("account_manager_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountManagerId { get; set; }

        /// <summary>
        /// 客户经理的名称。
        /// </summary>
        [JsonProperty("account_manager_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountManagerName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndirectPartnerInfo {\n");
            sb.Append("  indirectPartnerId: ").Append(IndirectPartnerId).Append("\n");
            sb.Append("  mobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  associatedOn: ").Append(AssociatedOn).Append("\n");
            sb.Append("  accountManagerId: ").Append(AccountManagerId).Append("\n");
            sb.Append("  accountManagerName: ").Append(AccountManagerName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IndirectPartnerInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IndirectPartnerInfo input)
        {
            if (input == null) return false;
            if (this.IndirectPartnerId != input.IndirectPartnerId || (this.IndirectPartnerId != null && !this.IndirectPartnerId.Equals(input.IndirectPartnerId))) return false;
            if (this.MobilePhone != input.MobilePhone || (this.MobilePhone != null && !this.MobilePhone.Equals(input.MobilePhone))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.AccountName != input.AccountName || (this.AccountName != null && !this.AccountName.Equals(input.AccountName))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AssociatedOn != input.AssociatedOn || (this.AssociatedOn != null && !this.AssociatedOn.Equals(input.AssociatedOn))) return false;
            if (this.AccountManagerId != input.AccountManagerId || (this.AccountManagerId != null && !this.AccountManagerId.Equals(input.AccountManagerId))) return false;
            if (this.AccountManagerName != input.AccountManagerName || (this.AccountManagerName != null && !this.AccountManagerName.Equals(input.AccountManagerName))) return false;

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
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                if (this.MobilePhone != null) hashCode = hashCode * 59 + this.MobilePhone.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AssociatedOn != null) hashCode = hashCode * 59 + this.AssociatedOn.GetHashCode();
                if (this.AccountManagerId != null) hashCode = hashCode * 59 + this.AccountManagerId.GetHashCode();
                if (this.AccountManagerName != null) hashCode = hashCode * 59 + this.AccountManagerName.GetHashCode();
                return hashCode;
            }
        }
    }
}
