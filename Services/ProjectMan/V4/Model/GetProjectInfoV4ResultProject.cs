using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 项目信息
    /// </summary>
    public class GetProjectInfoV4ResultProject 
    {

        /// <summary>
        /// 项目numId
        /// </summary>
        [JsonProperty("project_num_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProjectNumId { get; set; }

        /// <summary>
        /// 项目uuid
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 项目创建时间
        /// </summary>
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedOn { get; set; }

        /// <summary>
        /// 项目更新时间
        /// </summary>
        [JsonProperty("updated_on", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdatedOn { get; set; }

        /// <summary>
        /// 项目类型
        /// </summary>
        [JsonProperty("project_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectType { get; set; }

        /// <summary>
        /// 是否归档
        /// </summary>
        [JsonProperty("archive", NullValueHandling = NullValueHandling.Ignore)]
        public int? Archive { get; set; }

        /// <summary>
        /// 企业项目id
        /// </summary>
        [JsonProperty("enterprise_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 项目代号
        /// </summary>
        [JsonProperty("project_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public GetProjectInfoV4ResultProjectCreator Creator { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetProjectInfoV4ResultProject {\n");
            sb.Append("  projectNumId: ").Append(ProjectNumId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  createdOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  updatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  projectType: ").Append(ProjectType).Append("\n");
            sb.Append("  archive: ").Append(Archive).Append("\n");
            sb.Append("  enterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  projectCode: ").Append(ProjectCode).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetProjectInfoV4ResultProject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetProjectInfoV4ResultProject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectNumId == input.ProjectNumId ||
                    (this.ProjectNumId != null &&
                    this.ProjectNumId.Equals(input.ProjectNumId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.UpdatedOn == input.UpdatedOn ||
                    (this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(input.UpdatedOn))
                ) && 
                (
                    this.ProjectType == input.ProjectType ||
                    (this.ProjectType != null &&
                    this.ProjectType.Equals(input.ProjectType))
                ) && 
                (
                    this.Archive == input.Archive ||
                    (this.Archive != null &&
                    this.Archive.Equals(input.Archive))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.ProjectCode == input.ProjectCode ||
                    (this.ProjectCode != null &&
                    this.ProjectCode.Equals(input.ProjectCode))
                ) && 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
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
                if (this.ProjectNumId != null)
                    hashCode = hashCode * 59 + this.ProjectNumId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.UpdatedOn != null)
                    hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.ProjectType != null)
                    hashCode = hashCode * 59 + this.ProjectType.GetHashCode();
                if (this.Archive != null)
                    hashCode = hashCode * 59 + this.Archive.GetHashCode();
                if (this.EnterpriseId != null)
                    hashCode = hashCode * 59 + this.EnterpriseId.GetHashCode();
                if (this.ProjectCode != null)
                    hashCode = hashCode * 59 + this.ProjectCode.GetHashCode();
                if (this.Creator != null)
                    hashCode = hashCode * 59 + this.Creator.GetHashCode();
                return hashCode;
            }
        }
    }
}
