using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AuthorizeAccessKeysResponse : SdkResponse
    {

        /// <summary>
        /// 访问密钥ID列表
        /// </summary>
        [JsonProperty("access_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccessKeys { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizeAccessKeysResponse {\n");
            sb.Append("  accessKeys: ").Append(AccessKeys).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthorizeAccessKeysResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthorizeAccessKeysResponse input)
        {
            if (input == null) return false;
            if (this.AccessKeys != input.AccessKeys || (this.AccessKeys != null && input.AccessKeys != null && !this.AccessKeys.SequenceEqual(input.AccessKeys))) return false;

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
                if (this.AccessKeys != null) hashCode = hashCode * 59 + this.AccessKeys.GetHashCode();
                return hashCode;
            }
        }
    }
}
