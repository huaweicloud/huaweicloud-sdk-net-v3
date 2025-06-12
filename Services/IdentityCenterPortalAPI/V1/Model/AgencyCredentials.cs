using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterPortalAPI.V1.Model
{
    /// <summary>
    /// 分配给用户的指定委托或信任委托的凭证
    /// </summary>
    public class AgencyCredentials 
    {

        /// <summary>
        /// 用于临时安全凭证的标识符
        /// </summary>
        [JsonProperty("access_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// 临时安全凭证到期的日期
        /// </summary>
        [JsonProperty("expiration", NullValueHandling = NullValueHandling.Ignore)]
        public long? Expiration { get; set; }

        /// <summary>
        /// 用于对请求进行签名的密钥
        /// </summary>
        [JsonProperty("secret_access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretAccessKey { get; set; }

        /// <summary>
        /// 用于临时凭证的令牌
        /// </summary>
        [JsonProperty("session_token", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgencyCredentials {\n");
            sb.Append("  accessKeyId: ").Append(AccessKeyId).Append("\n");
            sb.Append("  expiration: ").Append(Expiration).Append("\n");
            sb.Append("  secretAccessKey: ").Append(SecretAccessKey).Append("\n");
            sb.Append("  sessionToken: ").Append(SessionToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgencyCredentials);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgencyCredentials input)
        {
            if (input == null) return false;
            if (this.AccessKeyId != input.AccessKeyId || (this.AccessKeyId != null && !this.AccessKeyId.Equals(input.AccessKeyId))) return false;
            if (this.Expiration != input.Expiration || (this.Expiration != null && !this.Expiration.Equals(input.Expiration))) return false;
            if (this.SecretAccessKey != input.SecretAccessKey || (this.SecretAccessKey != null && !this.SecretAccessKey.Equals(input.SecretAccessKey))) return false;
            if (this.SessionToken != input.SessionToken || (this.SessionToken != null && !this.SessionToken.Equals(input.SessionToken))) return false;

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
                if (this.AccessKeyId != null) hashCode = hashCode * 59 + this.AccessKeyId.GetHashCode();
                if (this.Expiration != null) hashCode = hashCode * 59 + this.Expiration.GetHashCode();
                if (this.SecretAccessKey != null) hashCode = hashCode * 59 + this.SecretAccessKey.GetHashCode();
                if (this.SessionToken != null) hashCode = hashCode * 59 + this.SessionToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
