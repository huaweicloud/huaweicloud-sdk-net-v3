using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 用户授权信息。
    /// </summary>
    public class Authorization 
    {

        /// <summary>
        /// 授权ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 用户ID(或用户组ID)。
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 用户名(或用户组名)。
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 应用ID (按照组授权时,该字段为空)。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 应用名称 (按照组授权时,该字段为空)。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 应用组ID。
        /// </summary>
        [JsonProperty("app_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppGroupId { get; set; }

        /// <summary>
        /// 应用组名称。
        /// </summary>
        [JsonProperty("app_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppGroupName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("authorization_type", NullValueHandling = NullValueHandling.Ignore)]
        public AuthorizationTypeEnum? AuthorizationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("account_type", NullValueHandling = NullValueHandling.Ignore)]
        public AccountTypeEnum? AccountType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("platform_type", NullValueHandling = NullValueHandling.Ignore)]
        public PlatformTypeEnum? PlatformType { get; set; }

        /// <summary>
        /// 域名城。
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 发布时间。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Authorization {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  appGroupId: ").Append(AppGroupId).Append("\n");
            sb.Append("  appGroupName: ").Append(AppGroupName).Append("\n");
            sb.Append("  authorizationType: ").Append(AuthorizationType).Append("\n");
            sb.Append("  accountType: ").Append(AccountType).Append("\n");
            sb.Append("  platformType: ").Append(PlatformType).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Authorization);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Authorization input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.Account != input.Account || (this.Account != null && !this.Account.Equals(input.Account))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.AppGroupId != input.AppGroupId || (this.AppGroupId != null && !this.AppGroupId.Equals(input.AppGroupId))) return false;
            if (this.AppGroupName != input.AppGroupName || (this.AppGroupName != null && !this.AppGroupName.Equals(input.AppGroupName))) return false;
            if (this.AuthorizationType != input.AuthorizationType || (this.AuthorizationType != null && !this.AuthorizationType.Equals(input.AuthorizationType))) return false;
            if (this.AccountType != input.AccountType || (this.AccountType != null && !this.AccountType.Equals(input.AccountType))) return false;
            if (this.PlatformType != input.PlatformType || (this.PlatformType != null && !this.PlatformType.Equals(input.PlatformType))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;

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
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.Account != null) hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.AppGroupId != null) hashCode = hashCode * 59 + this.AppGroupId.GetHashCode();
                if (this.AppGroupName != null) hashCode = hashCode * 59 + this.AppGroupName.GetHashCode();
                if (this.AuthorizationType != null) hashCode = hashCode * 59 + this.AuthorizationType.GetHashCode();
                if (this.AccountType != null) hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.PlatformType != null) hashCode = hashCode * 59 + this.PlatformType.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
