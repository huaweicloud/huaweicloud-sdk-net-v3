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
    /// 关联别名请求消息体
    /// </summary>
    public class AssociateAliasRequestBody 
    {

        /// <summary>
        /// 待关联别名
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string Alias { get; set; }

        /// <summary>
        /// 待关联的密钥ID
        /// </summary>
        [JsonProperty("target_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetKeyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateAliasRequestBody {\n");
            sb.Append("  alias: ").Append(Alias).Append("\n");
            sb.Append("  targetKeyId: ").Append(TargetKeyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateAliasRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateAliasRequestBody input)
        {
            if (input == null) return false;
            if (this.Alias != input.Alias || (this.Alias != null && !this.Alias.Equals(input.Alias))) return false;
            if (this.TargetKeyId != input.TargetKeyId || (this.TargetKeyId != null && !this.TargetKeyId.Equals(input.TargetKeyId))) return false;

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
                if (this.Alias != null) hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.TargetKeyId != null) hashCode = hashCode * 59 + this.TargetKeyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
