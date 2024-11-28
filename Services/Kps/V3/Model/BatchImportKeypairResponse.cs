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
    /// Response Object
    /// </summary>
    public class BatchImportKeypairResponse : SdkResponse
    {

        /// <summary>
        /// 导入失败的SSH密钥对信息及导入失败的原因
        /// </summary>
        [JsonProperty("failed_keypairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<FailedKeypair> FailedKeypairs { get; set; }

        /// <summary>
        /// 成功导入的SSH密钥对信息
        /// </summary>
        [JsonProperty("succeeded_keypairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateKeypairResponseBody> SucceededKeypairs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchImportKeypairResponse {\n");
            sb.Append("  failedKeypairs: ").Append(FailedKeypairs).Append("\n");
            sb.Append("  succeededKeypairs: ").Append(SucceededKeypairs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchImportKeypairResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchImportKeypairResponse input)
        {
            if (input == null) return false;
            if (this.FailedKeypairs != input.FailedKeypairs || (this.FailedKeypairs != null && input.FailedKeypairs != null && !this.FailedKeypairs.SequenceEqual(input.FailedKeypairs))) return false;
            if (this.SucceededKeypairs != input.SucceededKeypairs || (this.SucceededKeypairs != null && input.SucceededKeypairs != null && !this.SucceededKeypairs.SequenceEqual(input.SucceededKeypairs))) return false;

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
                if (this.FailedKeypairs != null) hashCode = hashCode * 59 + this.FailedKeypairs.GetHashCode();
                if (this.SucceededKeypairs != null) hashCode = hashCode * 59 + this.SucceededKeypairs.GetHashCode();
                return hashCode;
            }
        }
    }
}
