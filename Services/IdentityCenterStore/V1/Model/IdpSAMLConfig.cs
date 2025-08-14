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
    /// 
    /// </summary>
    public class IdpSAMLConfig 
    {

        /// <summary>
        /// 身份提供商发布者标识
        /// </summary>
        [JsonProperty("entity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityId { get; set; }

        /// <summary>
        /// 身份提供商登录链接
        /// </summary>
        [JsonProperty("login_url", NullValueHandling = NullValueHandling.Ignore)]
        public string LoginUrl { get; set; }

        /// <summary>
        /// 是否要求SAML请求签名验证
        /// </summary>
        [JsonProperty("want_request_signed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WantRequestSigned { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdpSAMLConfig {\n");
            sb.Append("  entityId: ").Append(EntityId).Append("\n");
            sb.Append("  loginUrl: ").Append(LoginUrl).Append("\n");
            sb.Append("  wantRequestSigned: ").Append(WantRequestSigned).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdpSAMLConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdpSAMLConfig input)
        {
            if (input == null) return false;
            if (this.EntityId != input.EntityId || (this.EntityId != null && !this.EntityId.Equals(input.EntityId))) return false;
            if (this.LoginUrl != input.LoginUrl || (this.LoginUrl != null && !this.LoginUrl.Equals(input.LoginUrl))) return false;
            if (this.WantRequestSigned != input.WantRequestSigned || (this.WantRequestSigned != null && !this.WantRequestSigned.Equals(input.WantRequestSigned))) return false;

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
                if (this.EntityId != null) hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.LoginUrl != null) hashCode = hashCode * 59 + this.LoginUrl.GetHashCode();
                if (this.WantRequestSigned != null) hashCode = hashCode * 59 + this.WantRequestSigned.GetHashCode();
                return hashCode;
            }
        }
    }
}
