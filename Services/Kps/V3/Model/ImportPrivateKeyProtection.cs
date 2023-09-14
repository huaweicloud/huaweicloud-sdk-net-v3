using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kps.V3.Model
{
    /// <summary>
    /// SSH密钥对私钥托管与保护。
    /// </summary>
    public class ImportPrivateKeyProtection 
    {

        /// <summary>
        /// 导入SSH密钥对的私钥。
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("encryption", NullValueHandling = NullValueHandling.Ignore)]
        public Encryption Encryption { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportPrivateKeyProtection {\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  encryption: ").Append(Encryption).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportPrivateKeyProtection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportPrivateKeyProtection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
                ) && 
                (
                    this.Encryption == input.Encryption ||
                    (this.Encryption != null &&
                    this.Encryption.Equals(input.Encryption))
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
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.Encryption != null)
                    hashCode = hashCode * 59 + this.Encryption.GetHashCode();
                return hashCode;
            }
        }
    }
}
