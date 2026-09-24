using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DataEncryption 
    {

        /// <summary>
        /// 存储库的密钥ID。如果为非加密存储库，默认值为None
        /// </summary>
        [JsonProperty("cmkid", NullValueHandling = NullValueHandling.Ignore)]
        public string Cmkid { get; set; }

        /// <summary>
        /// 存储库的加密算法类型。如果为非加密存储库，默认值为None
        /// </summary>
        [JsonProperty("encrypted_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptedAlgorithm { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataEncryption {\n");
            sb.Append("  cmkid: ").Append(Cmkid).Append("\n");
            sb.Append("  encryptedAlgorithm: ").Append(EncryptedAlgorithm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataEncryption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataEncryption input)
        {
            if (input == null) return false;
            if (this.Cmkid != input.Cmkid || (this.Cmkid != null && !this.Cmkid.Equals(input.Cmkid))) return false;
            if (this.EncryptedAlgorithm != input.EncryptedAlgorithm || (this.EncryptedAlgorithm != null && !this.EncryptedAlgorithm.Equals(input.EncryptedAlgorithm))) return false;

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
                if (this.Cmkid != null) hashCode = hashCode * 59 + this.Cmkid.GetHashCode();
                if (this.EncryptedAlgorithm != null) hashCode = hashCode * 59 + this.EncryptedAlgorithm.GetHashCode();
                return hashCode;
            }
        }
    }
}
