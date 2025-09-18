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
    public class IDERepoSearchDO 
    {

        /// <summary>
        /// 搜索制品名称
        /// </summary>
        [JsonProperty("artifact_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtifactName { get; set; }

        /// <summary>
        /// 制品类型
        /// </summary>
        [JsonProperty("artifact_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 是否在项目中
        /// </summary>
        [JsonProperty("in_project", NullValueHandling = NullValueHandling.Ignore)]
        public string InProject { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IDERepoSearchDO {\n");
            sb.Append("  artifactName: ").Append(ArtifactName).Append("\n");
            sb.Append("  artifactType: ").Append(ArtifactType).Append("\n");
            sb.Append("  pageNo: ").Append(PageNo).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  inProject: ").Append(InProject).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IDERepoSearchDO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IDERepoSearchDO input)
        {
            if (input == null) return false;
            if (this.ArtifactName != input.ArtifactName || (this.ArtifactName != null && !this.ArtifactName.Equals(input.ArtifactName))) return false;
            if (this.ArtifactType != input.ArtifactType || (this.ArtifactType != null && !this.ArtifactType.Equals(input.ArtifactType))) return false;
            if (this.PageNo != input.PageNo || (this.PageNo != null && !this.PageNo.Equals(input.PageNo))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.InProject != input.InProject || (this.InProject != null && !this.InProject.Equals(input.InProject))) return false;

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
                if (this.ArtifactName != null) hashCode = hashCode * 59 + this.ArtifactName.GetHashCode();
                if (this.ArtifactType != null) hashCode = hashCode * 59 + this.ArtifactType.GetHashCode();
                if (this.PageNo != null) hashCode = hashCode * 59 + this.PageNo.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.InProject != null) hashCode = hashCode * 59 + this.InProject.GetHashCode();
                return hashCode;
            }
        }
    }
}
