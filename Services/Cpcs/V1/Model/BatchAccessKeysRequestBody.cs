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
    /// 
    /// </summary>
    public class BatchAccessKeysRequestBody 
    {

        /// <summary>
        /// 所需要绑定的访问密钥ID
        /// </summary>
        [JsonProperty("access_key_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccessKeyIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAccessKeysRequestBody {\n");
            sb.Append("  accessKeyIds: ").Append(AccessKeyIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchAccessKeysRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAccessKeysRequestBody input)
        {
            if (input == null) return false;
            if (this.AccessKeyIds != input.AccessKeyIds || (this.AccessKeyIds != null && input.AccessKeyIds != null && !this.AccessKeyIds.SequenceEqual(input.AccessKeyIds))) return false;

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
                if (this.AccessKeyIds != null) hashCode = hashCode * 59 + this.AccessKeyIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
