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
    public class CreateAppAccessKeyResponse : SdkResponse
    {

        /// <summary>
        /// 访问密钥的id
        /// </summary>
        [JsonProperty("access_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKeyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAppAccessKeyResponse {\n");
            sb.Append("  accessKeyId: ").Append(AccessKeyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAppAccessKeyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAppAccessKeyResponse input)
        {
            if (input == null) return false;
            if (this.AccessKeyId != input.AccessKeyId || (this.AccessKeyId != null && !this.AccessKeyId.Equals(input.AccessKeyId))) return false;

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
                if (this.AccessKeyId != null) hashCode = hashCode * 59 + this.AccessKeyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
