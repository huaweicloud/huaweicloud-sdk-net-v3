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
    public class ListKeypairsResponse : SdkResponse
    {

        /// <summary>
        /// SSH密钥对信息详情
        /// </summary>
        [JsonProperty("keypairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Keypairs> Keypairs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListKeypairsResponse {\n");
            sb.Append("  keypairs: ").Append(Keypairs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListKeypairsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListKeypairsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Keypairs == input.Keypairs ||
                    this.Keypairs != null &&
                    input.Keypairs != null &&
                    this.Keypairs.SequenceEqual(input.Keypairs)
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
                if (this.Keypairs != null)
                    hashCode = hashCode * 59 + this.Keypairs.GetHashCode();
                return hashCode;
            }
        }
    }
}
