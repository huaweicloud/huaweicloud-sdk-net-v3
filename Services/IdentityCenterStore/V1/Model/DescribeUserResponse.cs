using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DescribeUserResponse : SdkResponse
    {

        /// <summary>
        /// 用户的地址信息列表
        /// </summary>
        [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddressDto> Addresses { get; set; }

        /// <summary>
        /// 用户的显示名称
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 用户的电子邮箱信息列表
        /// </summary>
        [JsonProperty("emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<EmailDto> Emails { get; set; }

        /// <summary>
        /// 外部身份源分配给此资源的标识符
        /// </summary>
        [JsonProperty("external_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        /// <summary>
        /// 用户的外部标识符信息列表
        /// </summary>
        [JsonProperty("external_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExternalIdDto> ExternalIds { get; set; }

        /// <summary>
        /// 身份源的全局唯一标识符（ID）
        /// </summary>
        [JsonProperty("identity_store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// 用户的地理区域或位置信息
        /// </summary>
        [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore)]
        public string Locale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public NameDto Name { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("nickname", NullValueHandling = NullValueHandling.Ignore)]
        public string Nickname { get; set; }

        /// <summary>
        /// 用户的电话号码信息列表
        /// </summary>
        [JsonProperty("phone_numbers", NullValueHandling = NullValueHandling.Ignore)]
        public List<PhoneNumberDto> PhoneNumbers { get; set; }

        /// <summary>
        /// 用户语言首选项
        /// </summary>
        [JsonProperty("preferred_language", NullValueHandling = NullValueHandling.Ignore)]
        public string PreferredLanguage { get; set; }

        /// <summary>
        /// 与用户关联的URL
        /// </summary>
        [JsonProperty("profile_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// 用户时区
        /// </summary>
        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }

        /// <summary>
        /// 用户头衔
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 身份源中IAM身份中心用户的全局唯一标识符（ID）
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名，用于标识用户的唯一字符串
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [JsonProperty("user_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UserType { get; set; }

        /// <summary>
        /// 创建用户时的时间戳
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 更新用户时的时间戳
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        [JsonProperty("updated_by", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// 一个布尔值，表示用户主的电子邮箱是否验证
        /// </summary>
        [JsonProperty("email_verified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// 一个布尔值，表示用户是否启用
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enterprise", NullValueHandling = NullValueHandling.Ignore)]
        public EnterpriseDto Enterprise { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DescribeUserResponse {\n");
            sb.Append("  addresses: ").Append(Addresses).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  emails: ").Append(Emails).Append("\n");
            sb.Append("  externalId: ").Append(ExternalId).Append("\n");
            sb.Append("  externalIds: ").Append(ExternalIds).Append("\n");
            sb.Append("  identityStoreId: ").Append(IdentityStoreId).Append("\n");
            sb.Append("  locale: ").Append(Locale).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nickname: ").Append(Nickname).Append("\n");
            sb.Append("  phoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  preferredLanguage: ").Append(PreferredLanguage).Append("\n");
            sb.Append("  profileUrl: ").Append(ProfileUrl).Append("\n");
            sb.Append("  timezone: ").Append(Timezone).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  userType: ").Append(UserType).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  updatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  emailVerified: ").Append(EmailVerified).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  enterprise: ").Append(Enterprise).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DescribeUserResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DescribeUserResponse input)
        {
            if (input == null) return false;
            if (this.Addresses != input.Addresses || (this.Addresses != null && input.Addresses != null && !this.Addresses.SequenceEqual(input.Addresses))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.Emails != input.Emails || (this.Emails != null && input.Emails != null && !this.Emails.SequenceEqual(input.Emails))) return false;
            if (this.ExternalId != input.ExternalId || (this.ExternalId != null && !this.ExternalId.Equals(input.ExternalId))) return false;
            if (this.ExternalIds != input.ExternalIds || (this.ExternalIds != null && input.ExternalIds != null && !this.ExternalIds.SequenceEqual(input.ExternalIds))) return false;
            if (this.IdentityStoreId != input.IdentityStoreId || (this.IdentityStoreId != null && !this.IdentityStoreId.Equals(input.IdentityStoreId))) return false;
            if (this.Locale != input.Locale || (this.Locale != null && !this.Locale.Equals(input.Locale))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Nickname != input.Nickname || (this.Nickname != null && !this.Nickname.Equals(input.Nickname))) return false;
            if (this.PhoneNumbers != input.PhoneNumbers || (this.PhoneNumbers != null && input.PhoneNumbers != null && !this.PhoneNumbers.SequenceEqual(input.PhoneNumbers))) return false;
            if (this.PreferredLanguage != input.PreferredLanguage || (this.PreferredLanguage != null && !this.PreferredLanguage.Equals(input.PreferredLanguage))) return false;
            if (this.ProfileUrl != input.ProfileUrl || (this.ProfileUrl != null && !this.ProfileUrl.Equals(input.ProfileUrl))) return false;
            if (this.Timezone != input.Timezone || (this.Timezone != null && !this.Timezone.Equals(input.Timezone))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.UserType != input.UserType || (this.UserType != null && !this.UserType.Equals(input.UserType))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.UpdatedBy != input.UpdatedBy || (this.UpdatedBy != null && !this.UpdatedBy.Equals(input.UpdatedBy))) return false;
            if (this.EmailVerified != input.EmailVerified || (this.EmailVerified != null && !this.EmailVerified.Equals(input.EmailVerified))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.Enterprise != input.Enterprise || (this.Enterprise != null && !this.Enterprise.Equals(input.Enterprise))) return false;

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
                if (this.Addresses != null) hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Emails != null) hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.ExternalId != null) hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.ExternalIds != null) hashCode = hashCode * 59 + this.ExternalIds.GetHashCode();
                if (this.IdentityStoreId != null) hashCode = hashCode * 59 + this.IdentityStoreId.GetHashCode();
                if (this.Locale != null) hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Nickname != null) hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.PhoneNumbers != null) hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
                if (this.PreferredLanguage != null) hashCode = hashCode * 59 + this.PreferredLanguage.GetHashCode();
                if (this.ProfileUrl != null) hashCode = hashCode * 59 + this.ProfileUrl.GetHashCode();
                if (this.Timezone != null) hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.UserType != null) hashCode = hashCode * 59 + this.UserType.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.UpdatedBy != null) hashCode = hashCode * 59 + this.UpdatedBy.GetHashCode();
                if (this.EmailVerified != null) hashCode = hashCode * 59 + this.EmailVerified.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Enterprise != null) hashCode = hashCode * 59 + this.Enterprise.GetHashCode();
                return hashCode;
            }
        }
    }
}
