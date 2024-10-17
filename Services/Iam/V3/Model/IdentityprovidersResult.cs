using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IdentityprovidersResult 
    {

        /// <summary>
        /// 身份提供商类型。当前支持virtual_user_sso和iam_user_sso两种。当返回为空字符串或者null时，默认为缺省类型virtual_user_sso类型。
        /// </summary>
        [JsonProperty("sso_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SsoType { get; set; }

        /// <summary>
        /// 身份提供商ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 身份提供商描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 身份提供商是否启用，true为启用，false为停用，默认为false。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 身份提供商的联邦用户ID列表。
        /// </summary>
        [JsonProperty("remote_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RemoteIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public IdentityprovidersLinks Links { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityprovidersResult {\n");
            sb.Append("  ssoType: ").Append(SsoType).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  remoteIds: ").Append(RemoteIds).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdentityprovidersResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdentityprovidersResult input)
        {
            if (input == null) return false;
            if (this.SsoType != input.SsoType || (this.SsoType != null && !this.SsoType.Equals(input.SsoType))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.RemoteIds != input.RemoteIds || (this.RemoteIds != null && input.RemoteIds != null && !this.RemoteIds.SequenceEqual(input.RemoteIds))) return false;
            if (this.Links != input.Links || (this.Links != null && !this.Links.Equals(input.Links))) return false;

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
                if (this.SsoType != null) hashCode = hashCode * 59 + this.SsoType.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.RemoteIds != null) hashCode = hashCode * 59 + this.RemoteIds.GetHashCode();
                if (this.Links != null) hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }
}
