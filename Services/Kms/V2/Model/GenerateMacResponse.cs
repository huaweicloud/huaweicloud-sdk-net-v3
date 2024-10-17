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
    public class GenerateMacResponse : SdkResponse
    {

        /// <summary>
        /// 密钥ID
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// Mac算法
        /// </summary>
        [JsonProperty("mac_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string MacAlgorithm { get; set; }

        /// <summary>
        /// 生成的消息验证码
        /// </summary>
        [JsonProperty("mac", NullValueHandling = NullValueHandling.Ignore)]
        public string Mac { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenerateMacResponse {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  macAlgorithm: ").Append(MacAlgorithm).Append("\n");
            sb.Append("  mac: ").Append(Mac).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GenerateMacResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GenerateMacResponse input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.MacAlgorithm != input.MacAlgorithm || (this.MacAlgorithm != null && !this.MacAlgorithm.Equals(input.MacAlgorithm))) return false;
            if (this.Mac != input.Mac || (this.Mac != null && !this.Mac.Equals(input.Mac))) return false;

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
                if (this.KeyId != null) hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                if (this.MacAlgorithm != null) hashCode = hashCode * 59 + this.MacAlgorithm.GetHashCode();
                if (this.Mac != null) hashCode = hashCode * 59 + this.Mac.GetHashCode();
                return hashCode;
            }
        }
    }
}
