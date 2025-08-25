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
    public class AuthorizeAccessKeysRequestBody 
    {

        /// <summary>
        /// 所需要绑定的应用ID
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 需要被授权的应用访问密钥的ID列表，若需要授予应用所有访问密钥权限，则仅传入一个元素，且该元素值为“all”，如body为“{\&quot;access_key_ids\&quot;: [\&quot;all\&quot;]}”
        /// </summary>
        [JsonProperty("access_key_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccessKeyIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizeAccessKeysRequestBody {\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  accessKeyIds: ").Append(AccessKeyIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthorizeAccessKeysRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthorizeAccessKeysRequestBody input)
        {
            if (input == null) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
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
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AccessKeyIds != null) hashCode = hashCode * 59 + this.AccessKeyIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
