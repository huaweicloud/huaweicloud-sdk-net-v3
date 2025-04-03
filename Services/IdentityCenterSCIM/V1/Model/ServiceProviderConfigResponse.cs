using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterSCIM.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ServiceProviderConfigResponse : SdkResponse
    {

        /// <summary>
        /// 概要
        /// </summary>
        [JsonProperty("schemas", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Schemas { get; set; }

        /// <summary>
        /// 帮助文档链接
        /// </summary>
        [JsonProperty("documentationUri", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentationUri { get; set; }

        /// <summary>
        /// 认证概要列表
        /// </summary>
        [JsonProperty("authenticationSchemes", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuthenticationSchemeItemDto> AuthenticationSchemes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("patch", NullValueHandling = NullValueHandling.Ignore)]
        public PatchDto Patch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bulk", NullValueHandling = NullValueHandling.Ignore)]
        public BulkDto Bulk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public FilterDto Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("changePassword", NullValueHandling = NullValueHandling.Ignore)]
        public ChangePasswordDto ChangePassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortDto Sort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("etag", NullValueHandling = NullValueHandling.Ignore)]
        public EtagDto Etag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceProviderConfigResponse {\n");
            sb.Append("  schemas: ").Append(Schemas).Append("\n");
            sb.Append("  documentationUri: ").Append(DocumentationUri).Append("\n");
            sb.Append("  authenticationSchemes: ").Append(AuthenticationSchemes).Append("\n");
            sb.Append("  patch: ").Append(Patch).Append("\n");
            sb.Append("  bulk: ").Append(Bulk).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  changePassword: ").Append(ChangePassword).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  etag: ").Append(Etag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceProviderConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceProviderConfigResponse input)
        {
            if (input == null) return false;
            if (this.Schemas != input.Schemas || (this.Schemas != null && input.Schemas != null && !this.Schemas.SequenceEqual(input.Schemas))) return false;
            if (this.DocumentationUri != input.DocumentationUri || (this.DocumentationUri != null && !this.DocumentationUri.Equals(input.DocumentationUri))) return false;
            if (this.AuthenticationSchemes != input.AuthenticationSchemes || (this.AuthenticationSchemes != null && input.AuthenticationSchemes != null && !this.AuthenticationSchemes.SequenceEqual(input.AuthenticationSchemes))) return false;
            if (this.Patch != input.Patch || (this.Patch != null && !this.Patch.Equals(input.Patch))) return false;
            if (this.Bulk != input.Bulk || (this.Bulk != null && !this.Bulk.Equals(input.Bulk))) return false;
            if (this.Filter != input.Filter || (this.Filter != null && !this.Filter.Equals(input.Filter))) return false;
            if (this.ChangePassword != input.ChangePassword || (this.ChangePassword != null && !this.ChangePassword.Equals(input.ChangePassword))) return false;
            if (this.Sort != input.Sort || (this.Sort != null && !this.Sort.Equals(input.Sort))) return false;
            if (this.Etag != input.Etag || (this.Etag != null && !this.Etag.Equals(input.Etag))) return false;

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
                if (this.Schemas != null) hashCode = hashCode * 59 + this.Schemas.GetHashCode();
                if (this.DocumentationUri != null) hashCode = hashCode * 59 + this.DocumentationUri.GetHashCode();
                if (this.AuthenticationSchemes != null) hashCode = hashCode * 59 + this.AuthenticationSchemes.GetHashCode();
                if (this.Patch != null) hashCode = hashCode * 59 + this.Patch.GetHashCode();
                if (this.Bulk != null) hashCode = hashCode * 59 + this.Bulk.GetHashCode();
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.ChangePassword != null) hashCode = hashCode * 59 + this.ChangePassword.GetHashCode();
                if (this.Sort != null) hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.Etag != null) hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }
}
