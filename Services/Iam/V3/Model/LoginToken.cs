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
    public class LoginToken 
    {

        /// <summary>
        /// 账号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// logintoken的过期时间，默认10min。
        /// </summary>
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// 认证方法。当认证用户为华为云用户时，该字段内容为“token”，当认证用户为自定义代理用户时，该字段内容为“federation_proxy”。
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public string Method { get; set; }

        /// <summary>
        /// 用户ID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 会话ID。
        /// </summary>
        [JsonProperty("session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionId { get; set; }

        /// <summary>
        /// 自定义代理用户ID。
        /// </summary>
        [JsonProperty("session_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionUserId { get; set; }

        /// <summary>
        /// 自定义代理用户名。 &gt; - [通过委托获取临时访问密钥和securitytoken](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;IAM&amp;api&#x3D;CreateTemporaryAccessKeyByAgency)且请求体中填写session_user.name参数时，会返回该字段。该字段的值即为session_user.name所填写的值。
        /// </summary>
        [JsonProperty("session_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assumed_by", NullValueHandling = NullValueHandling.Ignore)]
        public LoginTokenAssumedBy AssumedBy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginToken {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  expiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  method: ").Append(Method).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  sessionId: ").Append(SessionId).Append("\n");
            sb.Append("  sessionUserId: ").Append(SessionUserId).Append("\n");
            sb.Append("  sessionName: ").Append(SessionName).Append("\n");
            sb.Append("  assumedBy: ").Append(AssumedBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoginToken);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LoginToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.SessionUserId == input.SessionUserId ||
                    (this.SessionUserId != null &&
                    this.SessionUserId.Equals(input.SessionUserId))
                ) && 
                (
                    this.SessionName == input.SessionName ||
                    (this.SessionName != null &&
                    this.SessionName.Equals(input.SessionName))
                ) && 
                (
                    this.AssumedBy == input.AssumedBy ||
                    (this.AssumedBy != null &&
                    this.AssumedBy.Equals(input.AssumedBy))
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
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.SessionUserId != null)
                    hashCode = hashCode * 59 + this.SessionUserId.GetHashCode();
                if (this.SessionName != null)
                    hashCode = hashCode * 59 + this.SessionName.GetHashCode();
                if (this.AssumedBy != null)
                    hashCode = hashCode * 59 + this.AssumedBy.GetHashCode();
                return hashCode;
            }
        }
    }
}
