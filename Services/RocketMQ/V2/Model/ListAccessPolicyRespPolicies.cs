using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListAccessPolicyRespPolicies 
    {

        /// <summary>
        /// 秘钥。
        /// </summary>
        [JsonProperty("access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKey { get; set; }

        /// <summary>
        /// IP白名单。
        /// </summary>
        [JsonProperty("white_remote_address", NullValueHandling = NullValueHandling.Ignore)]
        public string WhiteRemoteAddress { get; set; }

        /// <summary>
        /// 是否为管理员。
        /// </summary>
        [JsonProperty("admin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Admin { get; set; }

        /// <summary>
        /// 权限。
        /// </summary>
        [JsonProperty("perm", NullValueHandling = NullValueHandling.Ignore)]
        public string Perm { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAccessPolicyRespPolicies {\n");
            sb.Append("  accessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  whiteRemoteAddress: ").Append(WhiteRemoteAddress).Append("\n");
            sb.Append("  admin: ").Append(Admin).Append("\n");
            sb.Append("  perm: ").Append(Perm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAccessPolicyRespPolicies);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAccessPolicyRespPolicies input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessKey == input.AccessKey ||
                    (this.AccessKey != null &&
                    this.AccessKey.Equals(input.AccessKey))
                ) && 
                (
                    this.WhiteRemoteAddress == input.WhiteRemoteAddress ||
                    (this.WhiteRemoteAddress != null &&
                    this.WhiteRemoteAddress.Equals(input.WhiteRemoteAddress))
                ) && 
                (
                    this.Admin == input.Admin ||
                    (this.Admin != null &&
                    this.Admin.Equals(input.Admin))
                ) && 
                (
                    this.Perm == input.Perm ||
                    (this.Perm != null &&
                    this.Perm.Equals(input.Perm))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AccessKey != null)
                    hashCode = hashCode * 59 + this.AccessKey.GetHashCode();
                if (this.WhiteRemoteAddress != null)
                    hashCode = hashCode * 59 + this.WhiteRemoteAddress.GetHashCode();
                if (this.Admin != null)
                    hashCode = hashCode * 59 + this.Admin.GetHashCode();
                if (this.Perm != null)
                    hashCode = hashCode * 59 + this.Perm.GetHashCode();
                return hashCode;
            }
        }
    }
}
