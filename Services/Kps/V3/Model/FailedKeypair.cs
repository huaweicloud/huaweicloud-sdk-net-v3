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
    /// 
    /// </summary>
    public class FailedKeypair 
    {

        /// <summary>
        /// SSH密钥对名称
        /// </summary>
        [JsonProperty("keypair_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeypairName { get; set; }

        /// <summary>
        /// 导入失败的原因
        /// </summary>
        [JsonProperty("failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedReason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FailedKeypair {\n");
            sb.Append("  keypairName: ").Append(KeypairName).Append("\n");
            sb.Append("  failedReason: ").Append(FailedReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FailedKeypair);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FailedKeypair input)
        {
            if (input == null) return false;
            if (this.KeypairName != input.KeypairName || (this.KeypairName != null && !this.KeypairName.Equals(input.KeypairName))) return false;
            if (this.FailedReason != input.FailedReason || (this.FailedReason != null && !this.FailedReason.Equals(input.FailedReason))) return false;

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
                if (this.KeypairName != null) hashCode = hashCode * 59 + this.KeypairName.GetHashCode();
                if (this.FailedReason != null) hashCode = hashCode * 59 + this.FailedReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
