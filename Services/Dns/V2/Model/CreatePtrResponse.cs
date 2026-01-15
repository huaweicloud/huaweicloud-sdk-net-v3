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
    /// Response Object
    /// </summary>
    public class CreatePtrResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("publicip", NullValueHandling = NullValueHandling.Ignore)]
        public PublicIpRes Publicip { get; set; }

        /// <summary>
        /// 反向解析记录对应的域名列表,最大个数不超过10个。
        /// </summary>
        [JsonProperty("ptrdnames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ptrdnames { get; set; }

        /// <summary>
        /// 反向解析记录的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 对反向解析记录的描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 反向解析记录在本地DNS服务器的缓存时间，缓存时间越长更新生效越慢，以秒为单位。
        /// </summary>
        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ttl { get; set; }

        /// <summary>
        /// **参数解释：** 资源状态。 **取值范围：** - ACTIVE：正常 - PENDING_CREATE：创建中 - PENDING_UPDATE：更新中 - PENDING_DELETE：删除中 - PENDING_FREEZE：冻结中 - FREEZE：冻结 - ILLEGAL：违规冻结 - POLICE：公安冻结 - ERROR：失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public PageLink Links { get; set; }

        /// <summary>
        /// 反向解析关联的企业项目ID，长度不超过36个字符。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePtrResponse {\n");
            sb.Append("  publicip: ").Append(Publicip).Append("\n");
            sb.Append("  ptrdnames: ").Append(Ptrdnames).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  ttl: ").Append(Ttl).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePtrResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePtrResponse input)
        {
            if (input == null) return false;
            if (this.Publicip != input.Publicip || (this.Publicip != null && !this.Publicip.Equals(input.Publicip))) return false;
            if (this.Ptrdnames != input.Ptrdnames || (this.Ptrdnames != null && input.Ptrdnames != null && !this.Ptrdnames.SequenceEqual(input.Ptrdnames))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Ttl != input.Ttl || (this.Ttl != null && !this.Ttl.Equals(input.Ttl))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Links != input.Links || (this.Links != null && !this.Links.Equals(input.Links))) return false;
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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Ttl != null) hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Links != null) hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
