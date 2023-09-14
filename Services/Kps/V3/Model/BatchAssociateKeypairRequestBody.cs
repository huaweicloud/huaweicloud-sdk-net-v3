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
    public class BatchAssociateKeypairRequestBody 
    {

        /// <summary>
        /// 最多可同时选择10个弹性云服务器绑定密钥对。  约束：只支持选择相同的密钥对，弹性云服务器处于“运行中”状态，并未绑定密钥对。
        /// </summary>
        [JsonProperty("batch_keypairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssociateKeypairRequestBody> BatchKeypairs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAssociateKeypairRequestBody {\n");
            sb.Append("  batchKeypairs: ").Append(BatchKeypairs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchAssociateKeypairRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAssociateKeypairRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BatchKeypairs == input.BatchKeypairs ||
                    this.BatchKeypairs != null &&
                    input.BatchKeypairs != null &&
                    this.BatchKeypairs.SequenceEqual(input.BatchKeypairs)
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
                if (this.BatchKeypairs != null)
                    hashCode = hashCode * 59 + this.BatchKeypairs.GetHashCode();
                return hashCode;
            }
        }
    }
}
