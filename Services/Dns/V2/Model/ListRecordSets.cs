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
    public class ListRecordSets 
    {

        /// <summary>
        /// Record Set的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Record Set的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Record Set的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 托管该记录的zone_id。
        /// </summary>
        [JsonProperty("zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneId { get; set; }

        /// <summary>
        /// 托管该记录的zone_name。
        /// </summary>
        [JsonProperty("zone_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneName { get; set; }

        /// <summary>
        /// 记录类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 解析记录在本地DNS服务器的缓存时间，缓存时间越长更新生效越慢，以秒为单位。
        /// </summary>
        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ttl { get; set; }

        /// <summary>
        /// 域名解析后的值。
        /// </summary>
        [JsonProperty("records", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Records { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateAt { get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateAt { get; set; }

        /// <summary>
        /// 资源状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 标识是否由系统默认生成，系统默认生成的Record Set不能删除。
        /// </summary>
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default { get; set; }

        /// <summary>
        /// 该Record Set所属的项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public PageLink Links { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRecordSets {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  zoneId: ").Append(ZoneId).Append("\n");
            sb.Append("  zoneName: ").Append(ZoneName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  ttl: ").Append(Ttl).Append("\n");
            sb.Append("  records: ").Append(Records).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRecordSets);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRecordSets input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ZoneId == input.ZoneId ||
                    (this.ZoneId != null &&
                    this.ZoneId.Equals(input.ZoneId))
                ) && 
                (
                    this.ZoneName == input.ZoneName ||
                    (this.ZoneName != null &&
                    this.ZoneName.Equals(input.ZoneName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))
                ) && 
                (
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
                ) && 
                (
                    this.CreateAt == input.CreateAt ||
                    (this.CreateAt != null &&
                    this.CreateAt.Equals(input.CreateAt))
                ) && 
                (
                    this.UpdateAt == input.UpdateAt ||
                    (this.UpdateAt != null &&
                    this.UpdateAt.Equals(input.UpdateAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ZoneId != null)
                    hashCode = hashCode * 59 + this.ZoneId.GetHashCode();
                if (this.ZoneName != null)
                    hashCode = hashCode * 59 + this.ZoneName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Ttl != null)
                    hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                if (this.Records != null)
                    hashCode = hashCode * 59 + this.Records.GetHashCode();
                if (this.CreateAt != null)
                    hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UpdateAt != null)
                    hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }
}
