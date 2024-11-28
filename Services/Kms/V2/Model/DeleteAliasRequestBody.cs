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
    /// 删除别名请求消息体
    /// </summary>
    public class DeleteAliasRequestBody 
    {

        /// <summary>
        /// 待删除的别名
        /// </summary>
        [JsonProperty("aliases", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Aliases { get; set; }

        /// <summary>
        /// 别名关联的密钥ID
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAliasRequestBody {\n");
            sb.Append("  aliases: ").Append(Aliases).Append("\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAliasRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAliasRequestBody input)
        {
            if (input == null) return false;
            if (this.Aliases != input.Aliases || (this.Aliases != null && input.Aliases != null && !this.Aliases.SequenceEqual(input.Aliases))) return false;
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
                if (this.Aliases != null) hashCode = hashCode * 59 + this.Aliases.GetHashCode();
                if (this.KeyId != null) hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
