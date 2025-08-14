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
    /// 用户session详情
    /// </summary>
    public class UserSessionDto 
    {

        /// <summary>
        /// 会话创建时间
        /// </summary>
        [JsonProperty("creation_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreationTime { get; set; }

        /// <summary>
        /// 用户IP地址
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [JsonProperty("session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionId { get; set; }

        /// <summary>
        /// 会话失效时间
        /// </summary>
        [JsonProperty("session_not_valid_after", NullValueHandling = NullValueHandling.Ignore)]
        public long? SessionNotValidAfter { get; set; }

        /// <summary>
        /// 用户客户端信息
        /// </summary>
        [JsonProperty("user_agent", NullValueHandling = NullValueHandling.Ignore)]
        public string UserAgent { get; set; }

        /// <summary>
        /// 用户唯一标识ID
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSessionDto {\n");
            sb.Append("  creationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  sessionId: ").Append(SessionId).Append("\n");
            sb.Append("  sessionNotValidAfter: ").Append(SessionNotValidAfter).Append("\n");
            sb.Append("  userAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserSessionDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserSessionDto input)
        {
            if (input == null) return false;
            if (this.CreationTime != input.CreationTime || (this.CreationTime != null && !this.CreationTime.Equals(input.CreationTime))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;
            if (this.SessionId != input.SessionId || (this.SessionId != null && !this.SessionId.Equals(input.SessionId))) return false;
            if (this.SessionNotValidAfter != input.SessionNotValidAfter || (this.SessionNotValidAfter != null && !this.SessionNotValidAfter.Equals(input.SessionNotValidAfter))) return false;
            if (this.UserAgent != input.UserAgent || (this.UserAgent != null && !this.UserAgent.Equals(input.UserAgent))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;

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
                if (this.CreationTime != null) hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.SessionId != null) hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.SessionNotValidAfter != null) hashCode = hashCode * 59 + this.SessionNotValidAfter.GetHashCode();
                if (this.UserAgent != null) hashCode = hashCode * 59 + this.UserAgent.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                return hashCode;
            }
        }
    }
}
