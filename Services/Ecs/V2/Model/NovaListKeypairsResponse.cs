using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class NovaListKeypairsResponse : SdkResponse
    {

        /// <summary>
        /// 密钥信息列表。
        /// </summary>
        [JsonProperty("keypairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<NovaListKeypairsResult> Keypairs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaListKeypairsResponse {\n");
            sb.Append("  keypairs: ").Append(Keypairs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaListKeypairsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaListKeypairsResponse input)
        {
            if (input == null) return false;
            if (this.Keypairs != input.Keypairs || (this.Keypairs != null && input.Keypairs != null && !this.Keypairs.SequenceEqual(input.Keypairs))) return false;

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
                if (this.Keypairs != null) hashCode = hashCode * 59 + this.Keypairs.GetHashCode();
                return hashCode;
            }
        }
    }
}
