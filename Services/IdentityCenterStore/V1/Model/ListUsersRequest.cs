using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListUsersRequest 
    {

        /// <summary>
        /// 如果正在使用临时安全凭据，则此header是必需的，该值是临时安全凭据的安全令牌（会话令牌）。
        /// </summary>
        [SDKProperty("X-Security-Token", IsHeader = true)]
        [JsonProperty("X-Security-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XSecurityToken { get; set; }

        /// <summary>
        /// 分页标记
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 每个请求返回的最大结果数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 身份源的全局唯一标识符（ID）
        /// </summary>
        [SDKProperty("identity_store_id", IsPath = true)]
        [JsonProperty("identity_store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [SDKProperty("user_name", IsQuery = true)]
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUsersRequest {\n");
            sb.Append("  xSecurityToken: ").Append(XSecurityToken).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  identityStoreId: ").Append(IdentityStoreId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUsersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUsersRequest input)
        {
            if (input == null) return false;
            if (this.XSecurityToken != input.XSecurityToken || (this.XSecurityToken != null && !this.XSecurityToken.Equals(input.XSecurityToken))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.IdentityStoreId != input.IdentityStoreId || (this.IdentityStoreId != null && !this.IdentityStoreId.Equals(input.IdentityStoreId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;

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
                if (this.XSecurityToken != null) hashCode = hashCode * 59 + this.XSecurityToken.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.IdentityStoreId != null) hashCode = hashCode * 59 + this.IdentityStoreId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                return hashCode;
            }
        }
    }
}
