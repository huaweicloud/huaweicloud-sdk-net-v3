using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// 创建账号的基本信息。
    /// </summary>
    public class CreateManagedAccountRequest 
    {

        /// <summary>
        /// 纳管账号名。
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// 纳管账号邮箱。
        /// </summary>
        [JsonProperty("account_email", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountEmail { get; set; }

        /// <summary>
        /// 手机号码。
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// Identity Center用户名。
        /// </summary>
        [JsonProperty("identity_store_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityStoreUserName { get; set; }

        /// <summary>
        /// Identity Center邮箱。
        /// </summary>
        [JsonProperty("identity_store_email", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityStoreEmail { get; set; }

        /// <summary>
        /// 父注册OU ID。
        /// </summary>
        [JsonProperty("parent_organizational_unit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentOrganizationalUnitId { get; set; }

        /// <summary>
        /// 父注册OU名称。
        /// </summary>
        [JsonProperty("parent_organizational_unit_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentOrganizationalUnitName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("blueprint", NullValueHandling = NullValueHandling.Ignore)]
        public Blueprint Blueprint { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateManagedAccountRequest {\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("  accountEmail: ").Append(AccountEmail).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  identityStoreUserName: ").Append(IdentityStoreUserName).Append("\n");
            sb.Append("  identityStoreEmail: ").Append(IdentityStoreEmail).Append("\n");
            sb.Append("  parentOrganizationalUnitId: ").Append(ParentOrganizationalUnitId).Append("\n");
            sb.Append("  parentOrganizationalUnitName: ").Append(ParentOrganizationalUnitName).Append("\n");
            sb.Append("  blueprint: ").Append(Blueprint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateManagedAccountRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateManagedAccountRequest input)
        {
            if (input == null) return false;
            if (this.AccountName != input.AccountName || (this.AccountName != null && !this.AccountName.Equals(input.AccountName))) return false;
            if (this.AccountEmail != input.AccountEmail || (this.AccountEmail != null && !this.AccountEmail.Equals(input.AccountEmail))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.IdentityStoreUserName != input.IdentityStoreUserName || (this.IdentityStoreUserName != null && !this.IdentityStoreUserName.Equals(input.IdentityStoreUserName))) return false;
            if (this.IdentityStoreEmail != input.IdentityStoreEmail || (this.IdentityStoreEmail != null && !this.IdentityStoreEmail.Equals(input.IdentityStoreEmail))) return false;
            if (this.ParentOrganizationalUnitId != input.ParentOrganizationalUnitId || (this.ParentOrganizationalUnitId != null && !this.ParentOrganizationalUnitId.Equals(input.ParentOrganizationalUnitId))) return false;
            if (this.ParentOrganizationalUnitName != input.ParentOrganizationalUnitName || (this.ParentOrganizationalUnitName != null && !this.ParentOrganizationalUnitName.Equals(input.ParentOrganizationalUnitName))) return false;
            if (this.Blueprint != input.Blueprint || (this.Blueprint != null && !this.Blueprint.Equals(input.Blueprint))) return false;

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
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.AccountEmail != null) hashCode = hashCode * 59 + this.AccountEmail.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.IdentityStoreUserName != null) hashCode = hashCode * 59 + this.IdentityStoreUserName.GetHashCode();
                if (this.IdentityStoreEmail != null) hashCode = hashCode * 59 + this.IdentityStoreEmail.GetHashCode();
                if (this.ParentOrganizationalUnitId != null) hashCode = hashCode * 59 + this.ParentOrganizationalUnitId.GetHashCode();
                if (this.ParentOrganizationalUnitName != null) hashCode = hashCode * 59 + this.ParentOrganizationalUnitName.GetHashCode();
                if (this.Blueprint != null) hashCode = hashCode * 59 + this.Blueprint.GetHashCode();
                return hashCode;
            }
        }
    }
}
