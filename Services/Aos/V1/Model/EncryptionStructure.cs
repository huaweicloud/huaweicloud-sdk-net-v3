using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 如果用户传递的var_value是已经加密过的，可以通过声名此项以要求资源编排服务在使用前进行解密，目前暂时只支持KMS加解密
    /// </summary>
    public class EncryptionStructure 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("kms", NullValueHandling = NullValueHandling.Ignore)]
        public KmsStructure Kms { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncryptionStructure {\n");
            sb.Append("  kms: ").Append(Kms).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EncryptionStructure);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EncryptionStructure input)
        {
            if (input == null) return false;
            if (this.Kms != input.Kms || (this.Kms != null && !this.Kms.Equals(input.Kms))) return false;

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
                if (this.Kms != null) hashCode = hashCode * 59 + this.Kms.GetHashCode();
                return hashCode;
            }
        }
    }
}
