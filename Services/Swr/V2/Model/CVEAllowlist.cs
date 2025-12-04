using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 漏洞CVE白名单列表
    /// </summary>
    public class CVEAllowlist 
    {

        /// <summary>
        /// 白名单ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 漏洞白名单列表所属的命名空间ID
        /// </summary>
        [JsonProperty("namespace_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? NamespaceId { get; set; }

        /// <summary>
        /// 漏洞白名单的有效期时间，如果没有配置，则永不过期
        /// </summary>
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiresAt { get; set; }

        /// <summary>
        /// 漏洞列表
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<CVEAllowlistItem> Items { get; set; }

        /// <summary>
        /// 漏洞白名单的创建时间
        /// </summary>
        [JsonProperty("creation_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationTime { get; set; }

        /// <summary>
        /// 漏洞白名单的更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CVEAllowlist {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  namespaceId: ").Append(NamespaceId).Append("\n");
            sb.Append("  expiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("  creationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CVEAllowlist);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CVEAllowlist input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.NamespaceId != input.NamespaceId || (this.NamespaceId != null && !this.NamespaceId.Equals(input.NamespaceId))) return false;
            if (this.ExpiresAt != input.ExpiresAt || (this.ExpiresAt != null && !this.ExpiresAt.Equals(input.ExpiresAt))) return false;
            if (this.Items != input.Items || (this.Items != null && input.Items != null && !this.Items.SequenceEqual(input.Items))) return false;
            if (this.CreationTime != input.CreationTime || (this.CreationTime != null && !this.CreationTime.Equals(input.CreationTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.NamespaceId != null) hashCode = hashCode * 59 + this.NamespaceId.GetHashCode();
                if (this.ExpiresAt != null) hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.Items != null) hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.CreationTime != null) hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
