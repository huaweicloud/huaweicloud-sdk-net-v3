using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MysqlTdeInfo 
    {

        /// <summary>
        /// 是否打开透明加密功能。
        /// </summary>
        [JsonProperty("enable_tde", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableTde { get; set; }

        /// <summary>
        /// 透明加密算法，支持AES256、SM4加密算法。
        /// </summary>
        [JsonProperty("encryption_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptionType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlTdeInfo {\n");
            sb.Append("  enableTde: ").Append(EnableTde).Append("\n");
            sb.Append("  encryptionType: ").Append(EncryptionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlTdeInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlTdeInfo input)
        {
            if (input == null) return false;
            if (this.EnableTde != input.EnableTde || (this.EnableTde != null && !this.EnableTde.Equals(input.EnableTde))) return false;
            if (this.EncryptionType != input.EncryptionType || (this.EncryptionType != null && !this.EncryptionType.Equals(input.EncryptionType))) return false;

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
                if (this.EnableTde != null) hashCode = hashCode * 59 + this.EnableTde.GetHashCode();
                if (this.EncryptionType != null) hashCode = hashCode * 59 + this.EncryptionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
