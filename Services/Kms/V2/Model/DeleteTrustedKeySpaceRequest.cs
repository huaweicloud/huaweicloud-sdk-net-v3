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
    public class DeleteTrustedKeySpaceRequest 
    {

        /// <summary>
        /// **参数解释：** 密钥空间ID。 **约束限制：** 不涉及 **取值范围：** UUID格式，字符长度36-36。 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("keyspace_id", IsPath = true)]
        [JsonProperty("keyspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyspaceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTrustedKeySpaceRequest {\n");
            sb.Append("  keyspaceId: ").Append(KeyspaceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTrustedKeySpaceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTrustedKeySpaceRequest input)
        {
            if (input == null) return false;
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
                if (this.KeyspaceId != null) hashCode = hashCode * 59 + this.KeyspaceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
