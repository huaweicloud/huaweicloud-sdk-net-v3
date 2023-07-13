using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateUserResult 
    {

        /// <summary>
        /// IAM用户访问方式。 - default：默认访问模式，编程访问和管理控制台访问。 - programmatic：编程访问。 - console：管理控制台访问。
        /// </summary>
        [JsonProperty("access_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessMode { get; set; }

        /// <summary>
        /// IAM用户状态信息。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// IAM用户首次登录是否重置密码。
        /// </summary>
        [JsonProperty("pwd_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PwdStatus { get; set; }

        /// <summary>
        /// IAM用户在外部系统中的ID。 &gt;外部系统指与华为云对接的外部企业管理系统，xaccount_type、xaccount_id、xdomain_type、xdomain_id、xuser_type、xuser_id等参数值，无法在华为云获取，请咨询企业管理员。
        /// </summary>
        [JsonProperty("xuser_id", NullValueHandling = NullValueHandling.Ignore)]
        public string XuserId { get; set; }

        /// <summary>
        /// 用户在外部系统中的类型。 &gt;外部系统指与华为云对接的外部企业管理系统，xaccount_type、xaccount_id、xdomain_type、xdomain_id、xuser_type、xuser_id等参数值，无法在华为云获取，请咨询企业管理员。
        /// </summary>
        [JsonProperty("xuser_type", NullValueHandling = NullValueHandling.Ignore)]
        public string XuserType { get; set; }

        /// <summary>
        /// IAM用户描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// IAM用户新用户名，长度1~64之间，只能包含如下字符：大小写字母、空格、数字或特殊字符（-_.）且不能以数字开头。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// IAM用户手机号，纯数字，长度小于等于32字符。必须与国家码同时存在。
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// IAM用户是否为账号管理员。
        /// </summary>
        [JsonProperty("is_domain_owner", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDomainOwner { get; set; }

        /// <summary>
        /// IAM用户所属账号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 是否启用IAM用户。true为启用，false为停用，默认为true。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 国家码。中国大陆为“0086”。
        /// </summary>
        [JsonProperty("areacode", NullValueHandling = NullValueHandling.Ignore)]
        public string Areacode { get; set; }

        /// <summary>
        /// IAM用户邮箱。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// IAM用户创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 运营主体的客户编码。
        /// </summary>
        [JsonProperty("xdomain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string XdomainId { get; set; }

        /// <summary>
        /// 运营主体。
        /// </summary>
        [JsonProperty("xdomain_type", NullValueHandling = NullValueHandling.Ignore)]
        public string XdomainType { get; set; }

        /// <summary>
        /// IAM用户ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 密码过期时间（UTC时间），“null”表示密码不过期。
        /// </summary>
        [JsonProperty("password_expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public string PasswordExpiresAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUserResult {\n");
            sb.Append("  accessMode: ").Append(AccessMode).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  pwdStatus: ").Append(PwdStatus).Append("\n");
            sb.Append("  xuserId: ").Append(XuserId).Append("\n");
            sb.Append("  xuserType: ").Append(XuserType).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  isDomainOwner: ").Append(IsDomainOwner).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  areacode: ").Append(Areacode).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  xdomainId: ").Append(XdomainId).Append("\n");
            sb.Append("  xdomainType: ").Append(XdomainType).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  passwordExpiresAt: ").Append(PasswordExpiresAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateUserResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateUserResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessMode == input.AccessMode ||
                    (this.AccessMode != null &&
                    this.AccessMode.Equals(input.AccessMode))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.PwdStatus == input.PwdStatus ||
                    (this.PwdStatus != null &&
                    this.PwdStatus.Equals(input.PwdStatus))
                ) && 
                (
                    this.XuserId == input.XuserId ||
                    (this.XuserId != null &&
                    this.XuserId.Equals(input.XuserId))
                ) && 
                (
                    this.XuserType == input.XuserType ||
                    (this.XuserType != null &&
                    this.XuserType.Equals(input.XuserType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.IsDomainOwner == input.IsDomainOwner ||
                    (this.IsDomainOwner != null &&
                    this.IsDomainOwner.Equals(input.IsDomainOwner))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Areacode == input.Areacode ||
                    (this.Areacode != null &&
                    this.Areacode.Equals(input.Areacode))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.XdomainId == input.XdomainId ||
                    (this.XdomainId != null &&
                    this.XdomainId.Equals(input.XdomainId))
                ) && 
                (
                    this.XdomainType == input.XdomainType ||
                    (this.XdomainType != null &&
                    this.XdomainType.Equals(input.XdomainType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PasswordExpiresAt == input.PasswordExpiresAt ||
                    (this.PasswordExpiresAt != null &&
                    this.PasswordExpiresAt.Equals(input.PasswordExpiresAt))
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
                if (this.AccessMode != null)
                    hashCode = hashCode * 59 + this.AccessMode.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PwdStatus != null)
                    hashCode = hashCode * 59 + this.PwdStatus.GetHashCode();
                if (this.XuserId != null)
                    hashCode = hashCode * 59 + this.XuserId.GetHashCode();
                if (this.XuserType != null)
                    hashCode = hashCode * 59 + this.XuserType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.IsDomainOwner != null)
                    hashCode = hashCode * 59 + this.IsDomainOwner.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Areacode != null)
                    hashCode = hashCode * 59 + this.Areacode.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.XdomainId != null)
                    hashCode = hashCode * 59 + this.XdomainId.GetHashCode();
                if (this.XdomainType != null)
                    hashCode = hashCode * 59 + this.XdomainType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PasswordExpiresAt != null)
                    hashCode = hashCode * 59 + this.PasswordExpiresAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
