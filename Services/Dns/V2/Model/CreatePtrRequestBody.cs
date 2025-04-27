using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreatePtrRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("publicip", NullValueHandling = NullValueHandling.Ignore)]
        public PublicIpReq Publicip { get; set; }

        /// <summary>
        /// 反向解析记录对应的域名列表，最大个数不超过10个。
        /// </summary>
        [JsonProperty("ptrdnames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ptrdnames { get; set; }

        /// <summary>
        /// 对反向解析记录的描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 反向解析记录在本地DNS服务器的缓存时间，缓存时间越长更新生效越慢，以秒为单位。取值范围：1～2147483647
        /// </summary>
        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ttl { get; set; }

        /// <summary>
        /// 资源标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 反向解析关联的企业项目ID，长度不超过36个字符。默认值为0。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePtrRequestBody {\n");
            sb.Append("  publicip: ").Append(Publicip).Append("\n");
            sb.Append("  ptrdnames: ").Append(Ptrdnames).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  ttl: ").Append(Ttl).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePtrRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePtrRequestBody input)
        {
            if (input == null) return false;
            if (this.Publicip != input.Publicip || (this.Publicip != null && !this.Publicip.Equals(input.Publicip))) return false;
            if (this.Ptrdnames != input.Ptrdnames || (this.Ptrdnames != null && input.Ptrdnames != null && !this.Ptrdnames.SequenceEqual(input.Ptrdnames))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Ttl != input.Ttl || (this.Ttl != null && !this.Ttl.Equals(input.Ttl))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                if (this.Publicip != null) hashCode = hashCode * 59 + this.Publicip.GetHashCode();
                if (this.Ptrdnames != null) hashCode = hashCode * 59 + this.Ptrdnames.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Ttl != null) hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
