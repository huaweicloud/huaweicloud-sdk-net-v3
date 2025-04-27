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
    public class PublicZoneResp 
    {

        /// <summary>
        /// 域名的ID，UUID形式的一个资源标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 域名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 对域名的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 管理该域名的管理员邮箱，用于生成该域名的SOA记录。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 域名类型。  取值范围： public：公网域名。
        /// </summary>
        [JsonProperty("zone_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneType { get; set; }

        /// <summary>
        /// 该域名下SOA记录中的ttl值。
        /// </summary>
        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ttl { get; set; }

        /// <summary>
        /// 该域名下SOA记录中用于标识域名文件变更的序列值，用于主从节点同步。
        /// </summary>
        [JsonProperty("serial", NullValueHandling = NullValueHandling.Ignore)]
        public int? Serial { get; set; }

        /// <summary>
        /// 资源状态。  取值范围： ACTIVE：正常 PENDING_CREATE：创建中 PENDING_DELETE：删除中 PENDING_UPDATE：更新中 FREEZE：冻结 PENDING_DISABLE：暂停中 DISABLE：暂停 ERROR：失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 该域名下的记录集个数。
        /// </summary>
        [JsonProperty("record_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordNum { get; set; }

        /// <summary>
        /// 托管该域名的pool，由系统分配。
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// 域名所属的项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 创建时间。 格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 更新时间。 格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public PageLink Links { get; set; }

        /// <summary>
        /// 资源标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 主从模式中，从DNS服务器获取DNS信息。
        /// </summary>
        [JsonProperty("masters", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Masters { get; set; }

        /// <summary>
        /// 域名关联的企业项目ID，长度不超过36个字符。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicZoneResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  zoneType: ").Append(ZoneType).Append("\n");
            sb.Append("  ttl: ").Append(Ttl).Append("\n");
            sb.Append("  serial: ").Append(Serial).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  recordNum: ").Append(RecordNum).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  masters: ").Append(Masters).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicZoneResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublicZoneResp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.ZoneType != input.ZoneType || (this.ZoneType != null && !this.ZoneType.Equals(input.ZoneType))) return false;
            if (this.Ttl != input.Ttl || (this.Ttl != null && !this.Ttl.Equals(input.Ttl))) return false;
            if (this.Serial != input.Serial || (this.Serial != null && !this.Serial.Equals(input.Serial))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.RecordNum != input.RecordNum || (this.RecordNum != null && !this.RecordNum.Equals(input.RecordNum))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Links != input.Links || (this.Links != null && !this.Links.Equals(input.Links))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Masters != input.Masters || (this.Masters != null && input.Masters != null && !this.Masters.SequenceEqual(input.Masters))) return false;
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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.ZoneType != null) hashCode = hashCode * 59 + this.ZoneType.GetHashCode();
                if (this.Ttl != null) hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                if (this.Serial != null) hashCode = hashCode * 59 + this.Serial.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RecordNum != null) hashCode = hashCode * 59 + this.RecordNum.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Links != null) hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Masters != null) hashCode = hashCode * 59 + this.Masters.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
