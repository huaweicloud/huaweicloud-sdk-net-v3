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
    /// Request Object
    /// </summary>
    public class ShowKeyUsageFlowRequest 
    {

        /// <summary>
        /// **参数解释：** 密钥空间ID **约束限制：** 满足正则表达式^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$ **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("keyspace_id", IsQuery = true)]
        [JsonProperty("keyspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyspaceId { get; set; }

        /// <summary>
        /// **参数解释：** 密钥ID **约束限制：** 满足正则表达式^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$ **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("key_id", IsQuery = true)]
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKeyUsageFlowRequest {\n");
            sb.Append("  keyspaceId: ").Append(KeyspaceId).Append("\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKeyUsageFlowRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKeyUsageFlowRequest input)
        {
            if (input == null) return false;
            if (this.KeyspaceId != input.KeyspaceId || (this.KeyspaceId != null && !this.KeyspaceId.Equals(input.KeyspaceId))) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;

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
                if (this.KeyspaceId != null) hashCode = hashCode * 59 + this.KeyspaceId.GetHashCode();
                if (this.KeyId != null) hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
