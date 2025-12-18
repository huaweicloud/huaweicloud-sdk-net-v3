using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sts.V1.Model
{
    /// <summary>
    /// 临时安全凭证。
    /// </summary>
    public class CredentialsDto 
    {

        /// <summary>
        /// 临时安全凭证的AK。
        /// </summary>
        [JsonProperty("access_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// 临时安全凭证的失效时间。
        /// </summary>
        [JsonProperty("expiration", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Expiration { get; set; }

        /// <summary>
        /// 临时安全凭证的SK。
        /// </summary>
        [JsonProperty("secret_access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretAccessKey { get; set; }

        /// <summary>
        /// 临时安全凭证的security_token。
        /// </summary>
        [JsonProperty("security_token", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CredentialsDto {\n");
            sb.Append("  accessKeyId: ").Append(AccessKeyId).Append("\n");
            sb.Append("  expiration: ").Append(Expiration).Append("\n");
            sb.Append("  secretAccessKey: ").Append(SecretAccessKey).Append("\n");
            sb.Append("  securityToken: ").Append(SecurityToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CredentialsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CredentialsDto input)
        {
            if (input == null) return false;
            if (this.AccessKeyId != input.AccessKeyId || (this.AccessKeyId != null && !this.AccessKeyId.Equals(input.AccessKeyId))) return false;
            if (this.Expiration != input.Expiration || (this.Expiration != null && !this.Expiration.Equals(input.Expiration))) return false;
            if (this.SecretAccessKey != input.SecretAccessKey || (this.SecretAccessKey != null && !this.SecretAccessKey.Equals(input.SecretAccessKey))) return false;
            if (this.SecurityToken != input.SecurityToken || (this.SecurityToken != null && !this.SecurityToken.Equals(input.SecurityToken))) return false;

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
                if (this.SecurityToken != null) hashCode = hashCode * 59 + this.SecurityToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
