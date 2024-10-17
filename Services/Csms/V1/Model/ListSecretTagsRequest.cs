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
    public class ListSecretTagsRequest 
    {

        /// <summary>
        /// 凭据ID
        /// </summary>
        [SDKProperty("secret_id", IsPath = true)]
        [JsonProperty("secret_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSecretTagsRequest {\n");
            sb.Append("  secretId: ").Append(SecretId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSecretTagsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSecretTagsRequest input)
        {
            if (input == null) return false;
            if (this.SecretId != input.SecretId || (this.SecretId != null && !this.SecretId.Equals(input.SecretId))) return false;

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
                return hashCode;
            }
        }
    }
}
