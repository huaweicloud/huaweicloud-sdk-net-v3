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
    public class TransferKeyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 转移后密钥的ID **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// **参数解释：** 密钥所属的目标密钥空间ID **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("keyspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyspaceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferKeyResponse {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  keyspaceId: ").Append(KeyspaceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferKeyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransferKeyResponse input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.KeyspaceId != input.KeyspaceId || (this.KeyspaceId != null && !this.KeyspaceId.Equals(input.KeyspaceId))) return false;

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
                if (this.KeyspaceId != null) hashCode = hashCode * 59 + this.KeyspaceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
