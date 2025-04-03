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
    /// 
    /// </summary>
    public class AuthenticationSchemeItemDto 
    {

        /// <summary>
        /// 认证类型，指定鉴权的方式
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 认证概要名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 认证概要的描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 规范链接
        /// </summary>
        [JsonProperty("specUri", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecUri { get; set; }

        /// <summary>
        /// 帮助文档链接
        /// </summary>
        [JsonProperty("documentationUri", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentationUri { get; set; }

        /// <summary>
        /// 是否为主要的认证方式
        /// </summary>
        [JsonProperty("primary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Primary { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationSchemeItemDto {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  specUri: ").Append(SpecUri).Append("\n");
            sb.Append("  documentationUri: ").Append(DocumentationUri).Append("\n");
            sb.Append("  primary: ").Append(Primary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthenticationSchemeItemDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthenticationSchemeItemDto input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.SpecUri != input.SpecUri || (this.SpecUri != null && !this.SpecUri.Equals(input.SpecUri))) return false;
            if (this.DocumentationUri != input.DocumentationUri || (this.DocumentationUri != null && !this.DocumentationUri.Equals(input.DocumentationUri))) return false;
            if (this.Primary != input.Primary || (this.Primary != null && !this.Primary.Equals(input.Primary))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SpecUri != null) hashCode = hashCode * 59 + this.SpecUri.GetHashCode();
                if (this.DocumentationUri != null) hashCode = hashCode * 59 + this.DocumentationUri.GetHashCode();
                if (this.Primary != null) hashCode = hashCode * 59 + this.Primary.GetHashCode();
                return hashCode;
            }
        }
    }
}
