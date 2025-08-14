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
    public class UpdateExternalIdPConfigurationForDirectoryReqBody 
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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateExternalIdPConfigurationForDirectoryReqBody {\n");
            sb.Append("  entityId: ").Append(EntityId).Append("\n");
            sb.Append("  loginUrl: ").Append(LoginUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateExternalIdPConfigurationForDirectoryReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateExternalIdPConfigurationForDirectoryReqBody input)
        {
            if (input == null) return false;
            if (this.EntityId != input.EntityId || (this.EntityId != null && !this.EntityId.Equals(input.EntityId))) return false;
            if (this.LoginUrl != input.LoginUrl || (this.LoginUrl != null && !this.LoginUrl.Equals(input.LoginUrl))) return false;

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
                return hashCode;
            }
        }
    }
}
