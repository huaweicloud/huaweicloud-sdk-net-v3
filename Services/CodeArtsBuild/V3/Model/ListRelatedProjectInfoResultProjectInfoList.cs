using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListRelatedProjectInfoResultProjectInfoList 
    {

        /// <summary>
        /// 唯一标识
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// 项目名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("author_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 项目创建者租户ID
        /// </summary>
        [JsonProperty("author_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorDomainId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRelatedProjectInfoResultProjectInfoList {\n");
            sb.Append("  identifier: ").Append(Identifier).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  authorId: ").Append(AuthorId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  authorDomainId: ").Append(AuthorDomainId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRelatedProjectInfoResultProjectInfoList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRelatedProjectInfoResultProjectInfoList input)
        {
            if (input == null) return false;
            if (this.Identifier != input.Identifier || (this.Identifier != null && !this.Identifier.Equals(input.Identifier))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AuthorId != input.AuthorId || (this.AuthorId != null && !this.AuthorId.Equals(input.AuthorId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.AuthorDomainId != input.AuthorDomainId || (this.AuthorDomainId != null && !this.AuthorDomainId.Equals(input.AuthorDomainId))) return false;

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
                if (this.Identifier != null) hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AuthorId != null) hashCode = hashCode * 59 + this.AuthorId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AuthorDomainId != null) hashCode = hashCode * 59 + this.AuthorDomainId.GetHashCode();
                return hashCode;
            }
        }
    }
}
