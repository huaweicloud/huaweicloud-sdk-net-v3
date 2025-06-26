using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AuthorizeObsResponse : SdkResponse
    {

        /// <summary>
        /// 访问的服务终端节点。
        /// </summary>
        [JsonProperty("server_end_point", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerEndPoint { get; set; }

        /// <summary>
        /// 存放的桶名称。
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// 存放目录。
        /// </summary>
        [JsonProperty("directory", NullValueHandling = NullValueHandling.Ignore)]
        public string Directory { get; set; }

        /// <summary>
        /// 获取的AK。。
        /// </summary>
        [JsonProperty("ak", NullValueHandling = NullValueHandling.Ignore)]
        public string Ak { get; set; }

        /// <summary>
        /// 获取的SK。
        /// </summary>
        [JsonProperty("sk", NullValueHandling = NullValueHandling.Ignore)]
        public string Sk { get; set; }

        /// <summary>
        /// AK/SK和securitytoken的过期时间。。
        /// </summary>
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public Policy Policy { get; set; }

        /// <summary>
        /// 安全校验token，将所获的AK、SK等信息进行加密后的字符串。
        /// </summary>
        [JsonProperty("security_token", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizeObsResponse {\n");
            sb.Append("  serverEndPoint: ").Append(ServerEndPoint).Append("\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  directory: ").Append(Directory).Append("\n");
            sb.Append("  ak: ").Append(Ak).Append("\n");
            sb.Append("  sk: ").Append(Sk).Append("\n");
            sb.Append("  expiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  securityToken: ").Append(SecurityToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthorizeObsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthorizeObsResponse input)
        {
            if (input == null) return false;
            if (this.ServerEndPoint != input.ServerEndPoint || (this.ServerEndPoint != null && !this.ServerEndPoint.Equals(input.ServerEndPoint))) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;
            if (this.Directory != input.Directory || (this.Directory != null && !this.Directory.Equals(input.Directory))) return false;
            if (this.Ak != input.Ak || (this.Ak != null && !this.Ak.Equals(input.Ak))) return false;
            if (this.Sk != input.Sk || (this.Sk != null && !this.Sk.Equals(input.Sk))) return false;
            if (this.ExpiresAt != input.ExpiresAt || (this.ExpiresAt != null && !this.ExpiresAt.Equals(input.ExpiresAt))) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.SecurityToken != input.SecurityToken || (this.SecurityToken != null && !this.SecurityToken.Equals(input.SecurityToken))) return false;

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
                if (this.ServerEndPoint != null) hashCode = hashCode * 59 + this.ServerEndPoint.GetHashCode();
                if (this.BucketName != null) hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.Directory != null) hashCode = hashCode * 59 + this.Directory.GetHashCode();
                if (this.Ak != null) hashCode = hashCode * 59 + this.Ak.GetHashCode();
                if (this.Sk != null) hashCode = hashCode * 59 + this.Sk.GetHashCode();
                if (this.ExpiresAt != null) hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.SecurityToken != null) hashCode = hashCode * 59 + this.SecurityToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
