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
    /// Request Object
    /// </summary>
    public class ShowAccessKeyRequest 
    {

        /// <summary>
        /// 访问密钥ID
        /// </summary>
        [SDKProperty("access_key_id", IsPath = true)]
        [JsonProperty("access_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [SDKProperty("app_id", IsPath = true)]
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAccessKeyRequest {\n");
            sb.Append("  accessKeyId: ").Append(AccessKeyId).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAccessKeyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAccessKeyRequest input)
        {
            if (input == null) return false;
            if (this.AccessKeyId != input.AccessKeyId || (this.AccessKeyId != null && !this.AccessKeyId.Equals(input.AccessKeyId))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;

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
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                return hashCode;
            }
        }
    }
}
