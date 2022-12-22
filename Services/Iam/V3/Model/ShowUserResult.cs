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
    public class ShowUserResult 
    {

        /// <summary>
        /// IAM用户是否启用。true表示启用，false表示停用，默认为true。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// IAM用户ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// IAM用户所属账号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// IAM用户名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public Links Links { get; set; }

        /// <summary>
        /// IAM用户在外部系统中的ID。
        /// </summary>
        [JsonProperty("xuser_id", NullValueHandling = NullValueHandling.Ignore)]
        public string XuserId { get; set; }

        /// <summary>
        /// IAM用户在外部系统中的类型。
        /// </summary>
        [JsonProperty("xuser_type", NullValueHandling = NullValueHandling.Ignore)]
        public string XuserType { get; set; }

        /// <summary>
        /// IAM用户手机号的国家码。
        /// </summary>
        [JsonProperty("areacode", NullValueHandling = NullValueHandling.Ignore)]
        public string Areacode { get; set; }

        /// <summary>
        /// IAM用户邮箱。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// IAM用户手机号。
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// IAM用户密码状态。true：需要修改密码，false：正常。
        /// </summary>
        [JsonProperty("pwd_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PwdStatus { get; set; }

        /// <summary>
        /// IAM用户更新时间。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// IAM用户创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// IAM用户最后登录时间。
        /// </summary>
        [JsonProperty("last_login_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastLoginTime { get; set; }

        /// <summary>
        /// IAM用户密码强度。结果为Low/Middle/High/None，分别表示密码强度低/中/高/无。
        /// </summary>
        [JsonProperty("pwd_strength", NullValueHandling = NullValueHandling.Ignore)]
        public string PwdStrength { get; set; }

        /// <summary>
        /// IAM用户是否为根用户。
        /// </summary>
        [JsonProperty("is_domain_owner", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDomainOwner { get; set; }

        /// <summary>
        /// IAM用户访问模式。
        /// </summary>
        [JsonProperty("access_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessMode { get; set; }

        /// <summary>
        /// IAM用户描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUserResult {\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  xuserId: ").Append(XuserId).Append("\n");
            sb.Append("  xuserType: ").Append(XuserType).Append("\n");
            sb.Append("  areacode: ").Append(Areacode).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  pwdStatus: ").Append(PwdStatus).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastLoginTime: ").Append(LastLoginTime).Append("\n");
            sb.Append("  pwdStrength: ").Append(PwdStrength).Append("\n");
            sb.Append("  isDomainOwner: ").Append(IsDomainOwner).Append("\n");
            sb.Append("  accessMode: ").Append(AccessMode).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUserResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUserResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.PwdStatus == input.PwdStatus ||
                    (this.PwdStatus != null &&
                    this.PwdStatus.Equals(input.PwdStatus))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.LastLoginTime == input.LastLoginTime ||
                    (this.LastLoginTime != null &&
                    this.LastLoginTime.Equals(input.LastLoginTime))
                ) && 
                (
                    this.PwdStrength == input.PwdStrength ||
                    (this.PwdStrength != null &&
                    this.PwdStrength.Equals(input.PwdStrength))
                ) && 
                (
                    this.IsDomainOwner == input.IsDomainOwner ||
                    (this.IsDomainOwner != null &&
                    this.IsDomainOwner.Equals(input.IsDomainOwner))
                ) && 
                (
                    this.AccessMode == input.AccessMode ||
                    (this.AccessMode != null &&
                    this.AccessMode.Equals(input.AccessMode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.XuserId != null)
                    hashCode = hashCode * 59 + this.XuserId.GetHashCode();
                if (this.XuserType != null)
                    hashCode = hashCode * 59 + this.XuserType.GetHashCode();
                if (this.Areacode != null)
                    hashCode = hashCode * 59 + this.Areacode.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.PwdStatus != null)
                    hashCode = hashCode * 59 + this.PwdStatus.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastLoginTime != null)
                    hashCode = hashCode * 59 + this.LastLoginTime.GetHashCode();
                if (this.PwdStrength != null)
                    hashCode = hashCode * 59 + this.PwdStrength.GetHashCode();
                if (this.IsDomainOwner != null)
                    hashCode = hashCode * 59 + this.IsDomainOwner.GetHashCode();
                if (this.AccessMode != null)
                    hashCode = hashCode * 59 + this.AccessMode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
