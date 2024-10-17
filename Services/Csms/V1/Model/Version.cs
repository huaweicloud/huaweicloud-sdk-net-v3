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
    /// 凭据版本。
    /// </summary>
    public class Version 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("version_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public VersionMetadata VersionMetadata { get; set; }

        /// <summary>
        /// 二进制类型凭据在base64编码后的明文，凭据管理服务将其加密后，存入凭据的初始版本中。  类型：base64编码的二进制数据对象。 
        /// </summary>
        [JsonProperty("secret_binary", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretBinary { get; set; }

        /// <summary>
        /// 文本类型凭据的明文，凭据管理服务将其加密后，存入凭据的初始版本中。
        /// </summary>
        [JsonProperty("secret_string", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretString { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Version {\n");
            sb.Append("  versionMetadata: ").Append(VersionMetadata).Append("\n");
            sb.Append("  secretBinary: ").Append(SecretBinary).Append("\n");
            sb.Append("  secretString: ").Append(SecretString).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Version);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Version input)
        {
            if (input == null) return false;
            if (this.VersionMetadata != input.VersionMetadata || (this.VersionMetadata != null && !this.VersionMetadata.Equals(input.VersionMetadata))) return false;
            if (this.SecretBinary != input.SecretBinary || (this.SecretBinary != null && !this.SecretBinary.Equals(input.SecretBinary))) return false;
            if (this.SecretString != input.SecretString || (this.SecretString != null && !this.SecretString.Equals(input.SecretString))) return false;

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
                if (this.VersionMetadata != null) hashCode = hashCode * 59 + this.VersionMetadata.GetHashCode();
                if (this.SecretBinary != null) hashCode = hashCode * 59 + this.SecretBinary.GetHashCode();
                if (this.SecretString != null) hashCode = hashCode * 59 + this.SecretString.GetHashCode();
                return hashCode;
            }
        }
    }
}
