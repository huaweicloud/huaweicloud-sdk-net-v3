using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// 创建凭据版本请求体。
    /// </summary>
    public class CreateSecretVersionRequestBody 
    {

        /// <summary>
        /// 新创建凭据的凭据值，将其加密后，存入初始版本中。  类型：base64编码的二进制数据对象。  约束：secret_binary和secret_string必须且只能设置一个，最大32K。 
        /// </summary>
        [JsonProperty("secret_binary", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretBinary { get; set; }

        /// <summary>
        /// 新创建凭据的凭据值，将其加密后，存入初始版本中。  约束：secret_binary和 secret_string必须且只能设置一个，最大32K。 
        /// </summary>
        [JsonProperty("secret_string", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretString { get; set; }

        /// <summary>
        /// 凭据版本在存入时需要被同时标记的版本状态。如果您不指定此参数，凭据管家默认为新版本标记SYSCURRENT  约束：数组大小：最小1，最大12。stage长度：最小1字节，最大64字节。 
        /// </summary>
        [JsonProperty("version_stages", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VersionStages { get; set; }

        /// <summary>
        /// 凭据版本过期时间，时间戳，即从1970年1月1日至该时间的总秒数。默认为空，凭据订阅“版本过期”事件类型时，有效期判断所依据的值。 
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSecretVersionRequestBody {\n");
            sb.Append("  secretBinary: ").Append(SecretBinary).Append("\n");
            sb.Append("  secretString: ").Append(SecretString).Append("\n");
            sb.Append("  versionStages: ").Append(VersionStages).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSecretVersionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSecretVersionRequestBody input)
        {
            if (input == null) return false;
            if (this.SecretBinary != input.SecretBinary || (this.SecretBinary != null && !this.SecretBinary.Equals(input.SecretBinary))) return false;
            if (this.SecretString != input.SecretString || (this.SecretString != null && !this.SecretString.Equals(input.SecretString))) return false;
            if (this.VersionStages != input.VersionStages || (this.VersionStages != null && input.VersionStages != null && !this.VersionStages.SequenceEqual(input.VersionStages))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;

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
                if (this.SecretBinary != null) hashCode = hashCode * 59 + this.SecretBinary.GetHashCode();
                if (this.SecretString != null) hashCode = hashCode * 59 + this.SecretString.GetHashCode();
                if (this.VersionStages != null) hashCode = hashCode * 59 + this.VersionStages.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
