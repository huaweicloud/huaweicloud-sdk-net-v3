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
    /// Request Object
    /// </summary>
    public class ListAuthorizationMailRecordRequest 
    {

        /// <summary>
        /// 单次查询的大小[1-100]。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询的偏移量。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 应用组ID。
        /// </summary>
        [SDKProperty("app_group_id", IsQuery = true)]
        [JsonProperty("app_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppGroupId { get; set; }

        /// <summary>
        /// 用户(组)名称。
        /// </summary>
        [SDKProperty("account", IsQuery = true)]
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 授权类型： - ADD_GROUP_AUTHORIZATION 添加组授权 - DEL_GROUP_AUTHORIZATION 删除组授权
        /// </summary>
        [SDKProperty("mail_send_type", IsQuery = true)]
        [JsonProperty("mail_send_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MailSendType { get; set; }

        /// <summary>
        /// 邮件发送结果(SUCCESS|FAIL)。
        /// </summary>
        [SDKProperty("mail_send_result", IsQuery = true)]
        [JsonProperty("mail_send_result", NullValueHandling = NullValueHandling.Ignore)]
        public string MailSendResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAuthorizationMailRecordRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  appGroupId: ").Append(AppGroupId).Append("\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("  mailSendType: ").Append(MailSendType).Append("\n");
            sb.Append("  mailSendResult: ").Append(MailSendResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAuthorizationMailRecordRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAuthorizationMailRecordRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.AppGroupId != input.AppGroupId || (this.AppGroupId != null && !this.AppGroupId.Equals(input.AppGroupId))) return false;
            if (this.Account != input.Account || (this.Account != null && !this.Account.Equals(input.Account))) return false;
            if (this.MailSendType != input.MailSendType || (this.MailSendType != null && !this.MailSendType.Equals(input.MailSendType))) return false;
            if (this.MailSendResult != input.MailSendResult || (this.MailSendResult != null && !this.MailSendResult.Equals(input.MailSendResult))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.AppGroupId != null) hashCode = hashCode * 59 + this.AppGroupId.GetHashCode();
                if (this.Account != null) hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.MailSendType != null) hashCode = hashCode * 59 + this.MailSendType.GetHashCode();
                if (this.MailSendResult != null) hashCode = hashCode * 59 + this.MailSendResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
