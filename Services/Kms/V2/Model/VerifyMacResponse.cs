using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class VerifyMacResponse : SdkResponse
    {

        /// <summary>
        /// 密钥ID
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// MAC算法
        /// </summary>
        [JsonProperty("mac_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string MacAlgorithm { get; set; }

        /// <summary>
        /// 消息验证码校验结果
        /// </summary>
        [JsonProperty("mac_valid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MacValid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyMacResponse {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  macAlgorithm: ").Append(MacAlgorithm).Append("\n");
            sb.Append("  macValid: ").Append(MacValid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VerifyMacResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VerifyMacResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))
                ) && 
                (
                    this.MacAlgorithm == input.MacAlgorithm ||
                    (this.MacAlgorithm != null &&
                    this.MacAlgorithm.Equals(input.MacAlgorithm))
                ) && 
                (
                    this.MacValid == input.MacValid ||
                    (this.MacValid != null &&
                    this.MacValid.Equals(input.MacValid))
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
                if (this.KeyId != null)
                    hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                if (this.MacAlgorithm != null)
                    hashCode = hashCode * 59 + this.MacAlgorithm.GetHashCode();
                if (this.MacValid != null)
                    hashCode = hashCode * 59 + this.MacValid.GetHashCode();
                return hashCode;
            }
        }
    }
}
