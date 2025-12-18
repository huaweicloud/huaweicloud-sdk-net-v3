using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 访问密钥的最后使用时间。
    /// </summary>
    public class AccessKeyLastUsed 
    {

        /// <summary>
        /// 访问密钥的最后使用时间。若不存在则表示从未使用过。
        /// </summary>
        [JsonProperty("last_used_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastUsedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessKeyLastUsed {\n");
            sb.Append("  lastUsedAt: ").Append(LastUsedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessKeyLastUsed);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessKeyLastUsed input)
        {
            if (input == null) return false;
            if (this.LastUsedAt != input.LastUsedAt || (this.LastUsedAt != null && !this.LastUsedAt.Equals(input.LastUsedAt))) return false;

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
                if (this.LastUsedAt != null) hashCode = hashCode * 59 + this.LastUsedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
