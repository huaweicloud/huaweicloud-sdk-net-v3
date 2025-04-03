using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterSCIM.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class PatchUserResponse : SdkResponse
    {

        /// <summary>
        /// 用户的全局唯一标识符（ID）
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 外部标识符
        /// </summary>
        [JsonProperty("externalId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public MetaDto Meta { get; set; }

        /// <summary>
        /// 概要
        /// </summary>
        [JsonProperty("schemas", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Schemas { get; set; }

        /// <summary>
        /// 用户名，用于标识用户的唯一字符串
        /// </summary>
        [JsonProperty("userName", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public NameDto Name { get; set; }

        /// <summary>
        /// 包含用户显示名称的字符串
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 包含用户昵称的字符串
        /// </summary>
        [JsonProperty("nickName", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// 包含用户头衔的字符串
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 指示用户类型的字符串
        /// </summary>
        [JsonProperty("userType", NullValueHandling = NullValueHandling.Ignore)]
        public string UserType { get; set; }

        /// <summary>
        /// 包含用户首选语言的字符串
        /// </summary>
        [JsonProperty("preferredLanguage", NullValueHandling = NullValueHandling.Ignore)]
        public string PreferredLanguage { get; set; }

        /// <summary>
        /// 包含用户地理区域或位置的字符串
        /// </summary>
        [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore)]
        public string Locale { get; set; }

        /// <summary>
        /// 包含用户时区的字符串
        /// </summary>
        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }

        /// <summary>
        /// 表示用户是否启用
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <summary>
        /// 包含用户的电子邮箱信息的对象列表
        /// </summary>
        [JsonProperty("emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<EmailItemDto> Emails { get; set; }

        /// <summary>
        /// 包含用户地址信息的对象列表
        /// </summary>
        [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddressItemDto> Addresses { get; set; }

        /// <summary>
        /// 包含用户电话号码信息的对象列表
        /// </summary>
        [JsonProperty("phoneNumbers", NullValueHandling = NullValueHandling.Ignore)]
        public List<PhoneNumberItemDto> PhoneNumbers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("urn:ietf:params:scim:schemas:extension:enterprise:2.0:User", NullValueHandling = NullValueHandling.Ignore)]
        public EnterpriseDto Urnietfparamsscimschemasextensionenterprise20User { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchUserResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  externalId: ").Append(ExternalId).Append("\n");
            sb.Append("  meta: ").Append(Meta).Append("\n");
            sb.Append("  schemas: ").Append(Schemas).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  userType: ").Append(UserType).Append("\n");
            sb.Append("  preferredLanguage: ").Append(PreferredLanguage).Append("\n");
            sb.Append("  locale: ").Append(Locale).Append("\n");
            sb.Append("  timezone: ").Append(Timezone).Append("\n");
            sb.Append("  active: ").Append(Active).Append("\n");
            sb.Append("  emails: ").Append(Emails).Append("\n");
            sb.Append("  addresses: ").Append(Addresses).Append("\n");
            sb.Append("  phoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  urnietfparamsscimschemasextensionenterprise20User: ").Append(Urnietfparamsscimschemasextensionenterprise20User).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PatchUserResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PatchUserResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ExternalId != input.ExternalId || (this.ExternalId != null && !this.ExternalId.Equals(input.ExternalId))) return false;
            if (this.Meta != input.Meta || (this.Meta != null && !this.Meta.Equals(input.Meta))) return false;
            if (this.Schemas != input.Schemas || (this.Schemas != null && input.Schemas != null && !this.Schemas.SequenceEqual(input.Schemas))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.NickName != input.NickName || (this.NickName != null && !this.NickName.Equals(input.NickName))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.UserType != input.UserType || (this.UserType != null && !this.UserType.Equals(input.UserType))) return false;
            if (this.PreferredLanguage != input.PreferredLanguage || (this.PreferredLanguage != null && !this.PreferredLanguage.Equals(input.PreferredLanguage))) return false;
            if (this.Locale != input.Locale || (this.Locale != null && !this.Locale.Equals(input.Locale))) return false;
            if (this.Timezone != input.Timezone || (this.Timezone != null && !this.Timezone.Equals(input.Timezone))) return false;
            if (this.Active != input.Active || (this.Active != null && !this.Active.Equals(input.Active))) return false;
            if (this.Emails != input.Emails || (this.Emails != null && input.Emails != null && !this.Emails.SequenceEqual(input.Emails))) return false;
            if (this.Addresses != input.Addresses || (this.Addresses != null && input.Addresses != null && !this.Addresses.SequenceEqual(input.Addresses))) return false;
            if (this.PhoneNumbers != input.PhoneNumbers || (this.PhoneNumbers != null && input.PhoneNumbers != null && !this.PhoneNumbers.SequenceEqual(input.PhoneNumbers))) return false;
            if (this.Urnietfparamsscimschemasextensionenterprise20User != input.Urnietfparamsscimschemasextensionenterprise20User || (this.Urnietfparamsscimschemasextensionenterprise20User != null && !this.Urnietfparamsscimschemasextensionenterprise20User.Equals(input.Urnietfparamsscimschemasextensionenterprise20User))) return false;

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
                if (this.ExternalId != null) hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Meta != null) hashCode = hashCode * 59 + this.Meta.GetHashCode();
                if (this.Schemas != null) hashCode = hashCode * 59 + this.Schemas.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.UserType != null) hashCode = hashCode * 59 + this.UserType.GetHashCode();
                if (this.PreferredLanguage != null) hashCode = hashCode * 59 + this.PreferredLanguage.GetHashCode();
                if (this.Locale != null) hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.Timezone != null) hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Active != null) hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Emails != null) hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.Addresses != null) hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.PhoneNumbers != null) hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
                if (this.Urnietfparamsscimschemasextensionenterprise20User != null) hashCode = hashCode * 59 + this.Urnietfparamsscimschemasextensionenterprise20User.GetHashCode();
                return hashCode;
            }
        }
    }
}
