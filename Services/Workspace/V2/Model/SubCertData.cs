using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 证书元数据。
    /// </summary>
    public class SubCertData 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("distinguished_name", NullValueHandling = NullValueHandling.Ignore)]
        public DistinguishedName DistinguishedName { get; set; }

        /// <summary>
        /// 密钥对生成算法 RSA-2048 RSA-3072。
        /// </summary>
        [JsonProperty("key_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyAlgorithm { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubCertData {\n");
            sb.Append("  distinguishedName: ").Append(DistinguishedName).Append("\n");
            sb.Append("  keyAlgorithm: ").Append(KeyAlgorithm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubCertData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubCertData input)
        {
            if (input == null) return false;
            if (this.DistinguishedName != input.DistinguishedName || (this.DistinguishedName != null && !this.DistinguishedName.Equals(input.DistinguishedName))) return false;
            if (this.KeyAlgorithm != input.KeyAlgorithm || (this.KeyAlgorithm != null && !this.KeyAlgorithm.Equals(input.KeyAlgorithm))) return false;

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
                if (this.DistinguishedName != null) hashCode = hashCode * 59 + this.DistinguishedName.GetHashCode();
                if (this.KeyAlgorithm != null) hashCode = hashCode * 59 + this.KeyAlgorithm.GetHashCode();
                return hashCode;
            }
        }
    }
}
