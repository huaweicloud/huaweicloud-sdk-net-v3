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
    /// 邮件记录详细信息。
    /// </summary>
    public class AuthorizationMail 
    {

        /// <summary>
        /// 邮件记录id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 用户(组)。
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("account_auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public AccountTypeEnum? AccountAuthType { get; set; }

        /// <summary>
        /// 授权对象名称。
        /// </summary>
        [JsonProperty("account_auth_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountAuthName { get; set; }

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
        /// 授权类型： - ADD_GROUP_AUTHORIZATION 添加组授权邮件 - DEL_GROUP_AUTHORIZATION 删除组授权邮件 - ADD_GROUP_AUTHORIZATION_SMS 添加组授权短信 - DEL_GROUP_AUTHORIZATION_SMS 删除组授权短信。
        /// </summary>
        [JsonProperty("mail_send_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MailSendType { get; set; }

        /// <summary>
        /// 发送结果。 - SUEECESS -发送成功 - FAIL -发送失败。
        /// </summary>
        [JsonProperty("mail_send_result", NullValueHandling = NullValueHandling.Ignore)]
        public string MailSendResult { get; set; }

        /// <summary>
        /// 报错信息。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 发布时间。
        /// </summary>
        [JsonProperty("send_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SendAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizationMail {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("  accountAuthType: ").Append(AccountAuthType).Append("\n");
            sb.Append("  accountAuthName: ").Append(AccountAuthName).Append("\n");
            sb.Append("  appGroupId: ").Append(AppGroupId).Append("\n");
            sb.Append("  appGroupName: ").Append(AppGroupName).Append("\n");
            sb.Append("  mailSendType: ").Append(MailSendType).Append("\n");
            sb.Append("  mailSendResult: ").Append(MailSendResult).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  sendAt: ").Append(SendAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthorizationMail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthorizationMail input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Account != input.Account || (this.Account != null && !this.Account.Equals(input.Account))) return false;
            if (this.AccountAuthType != input.AccountAuthType || (this.AccountAuthType != null && !this.AccountAuthType.Equals(input.AccountAuthType))) return false;
            if (this.AccountAuthName != input.AccountAuthName || (this.AccountAuthName != null && !this.AccountAuthName.Equals(input.AccountAuthName))) return false;
            if (this.AppGroupId != input.AppGroupId || (this.AppGroupId != null && !this.AppGroupId.Equals(input.AppGroupId))) return false;
            if (this.AppGroupName != input.AppGroupName || (this.AppGroupName != null && !this.AppGroupName.Equals(input.AppGroupName))) return false;
            if (this.MailSendType != input.MailSendType || (this.MailSendType != null && !this.MailSendType.Equals(input.MailSendType))) return false;
            if (this.MailSendResult != input.MailSendResult || (this.MailSendResult != null && !this.MailSendResult.Equals(input.MailSendResult))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;
            if (this.SendAt != input.SendAt || (this.SendAt != null && !this.SendAt.Equals(input.SendAt))) return false;

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
                if (this.Account != null) hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.AccountAuthType != null) hashCode = hashCode * 59 + this.AccountAuthType.GetHashCode();
                if (this.AccountAuthName != null) hashCode = hashCode * 59 + this.AccountAuthName.GetHashCode();
                if (this.AppGroupId != null) hashCode = hashCode * 59 + this.AppGroupId.GetHashCode();
                if (this.AppGroupName != null) hashCode = hashCode * 59 + this.AppGroupName.GetHashCode();
                if (this.MailSendType != null) hashCode = hashCode * 59 + this.MailSendType.GetHashCode();
                if (this.MailSendResult != null) hashCode = hashCode * 59 + this.MailSendResult.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.SendAt != null) hashCode = hashCode * 59 + this.SendAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
