using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PrivilegeProjectInfoV5 
    {

        /// <summary>
        /// **参数解释**：  项目的序号。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 项目的名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 项目的状态（该参数无返回值，请忽略）。 **取值范围**： 该参数无返回值，请忽略。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 项目ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 项目的创建时间。 **取值范围**： 格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// **参数解释**： 仓库数量。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("repository_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryNum { get; set; }

        /// <summary>
        /// **参数解释**： 项目总数（该参数无返回值，请忽略）。 **取值范围**： 该参数无返回值，请忽略。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**： 仓库ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryId { get; set; }

        /// <summary>
        /// **参数解释**： 项目所属的区域。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// **参数解释**： 租户ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释**： 项目的序号列表（该参数无返回值，请忽略）。 **取值范围**： 该参数无返回值，请忽略。
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// **参数解释**： 项目总数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("total_records", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// **参数解释**： 请求参数中的仓库ID是否关联到本项目。 **取值范围**： - true：关联到本项目。 - false：未关联到本项目。
        /// </summary>
        [JsonProperty("associated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Associated { get; set; }

        /// <summary>
        /// **参数解释**： 项目的信息。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("project_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<PrivilegeProjectInfoV5> ProjectInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivilegeProjectInfoV5 {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  repositoryNum: ").Append(RepositoryNum).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  ids: ").Append(Ids).Append("\n");
            sb.Append("  totalRecords: ").Append(TotalRecords).Append("\n");
            sb.Append("  associated: ").Append(Associated).Append("\n");
            sb.Append("  projectInfo: ").Append(ProjectInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivilegeProjectInfoV5);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivilegeProjectInfoV5 input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.RepositoryNum != input.RepositoryNum || (this.RepositoryNum != null && !this.RepositoryNum.Equals(input.RepositoryNum))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Ids != input.Ids || (this.Ids != null && input.Ids != null && !this.Ids.SequenceEqual(input.Ids))) return false;
            if (this.TotalRecords != input.TotalRecords || (this.TotalRecords != null && !this.TotalRecords.Equals(input.TotalRecords))) return false;
            if (this.Associated != input.Associated || (this.Associated != null && !this.Associated.Equals(input.Associated))) return false;
            if (this.ProjectInfo != input.ProjectInfo || (this.ProjectInfo != null && input.ProjectInfo != null && !this.ProjectInfo.SequenceEqual(input.ProjectInfo))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.RepositoryNum != null) hashCode = hashCode * 59 + this.RepositoryNum.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Ids != null) hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.TotalRecords != null) hashCode = hashCode * 59 + this.TotalRecords.GetHashCode();
                if (this.Associated != null) hashCode = hashCode * 59 + this.Associated.GetHashCode();
                if (this.ProjectInfo != null) hashCode = hashCode * 59 + this.ProjectInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
