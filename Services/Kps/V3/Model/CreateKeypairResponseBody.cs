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
    /// SSH密钥对的详情
    /// </summary>
    public class CreateKeypairResponseBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("keypair", NullValueHandling = NullValueHandling.Ignore)]
        public CreateKeypairResp Keypair { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateKeypairResponseBody {\n");
            sb.Append("  keypair: ").Append(Keypair).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateKeypairResponseBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateKeypairResponseBody input)
        {
            if (input == null) return false;
            if (this.Keypair != input.Keypair || (this.Keypair != null && !this.Keypair.Equals(input.Keypair))) return false;

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
                if (this.Keypair != null) hashCode = hashCode * 59 + this.Keypair.GetHashCode();
                return hashCode;
            }
        }
    }
}