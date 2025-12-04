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
    /// 更新漏洞CVE白名单列表的请求
    /// </summary>
    public class UpdateCVEAllowlistRequest 
    {

        /// <summary>
        /// 白名单ID，查询命名空间信息时，会返回白名单ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 漏洞白名单列表所属的命名空间ID
        /// </summary>
        [JsonProperty("namespace_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? NamespaceId { get; set; }

        /// <summary>
        /// 漏洞白名单的有效期时间，以自 1970 年 1 月 1 日以来的秒数表示；如果没有配置，则永不过期
        /// </summary>
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiresAt { get; set; }

        /// <summary>
        /// 漏洞列表
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<CVEAllowlistItem> Items { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCVEAllowlistRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  namespaceId: ").Append(NamespaceId).Append("\n");
            sb.Append("  expiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCVEAllowlistRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateCVEAllowlistRequest input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.NamespaceId != input.NamespaceId || (this.NamespaceId != null && !this.NamespaceId.Equals(input.NamespaceId))) return false;
            if (this.ExpiresAt != input.ExpiresAt || (this.ExpiresAt != null && !this.ExpiresAt.Equals(input.ExpiresAt))) return false;
            if (this.Items != input.Items || (this.Items != null && input.Items != null && !this.Items.SequenceEqual(input.Items))) return false;

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
                return hashCode;
            }
        }
    }
}
