using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteSecretTagRequest 
    {

        /// <summary>
        /// 凭据ID
        /// </summary>
        [SDKProperty("secret_id", IsPath = true)]
        [JsonProperty("secret_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretId { get; set; }

        /// <summary>
        /// 标签键的值
        /// </summary>
        [SDKProperty("key", IsPath = true)]
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteSecretTagRequest {\n");
            sb.Append("  secretId: ").Append(SecretId).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteSecretTagRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteSecretTagRequest input)
        {
            if (input == null) return false;
            if (this.SecretId != input.SecretId || (this.SecretId != null && !this.SecretId.Equals(input.SecretId))) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;

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
                if (this.SecretId != null) hashCode = hashCode * 59 + this.SecretId.GetHashCode();
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                return hashCode;
            }
        }
    }
}
