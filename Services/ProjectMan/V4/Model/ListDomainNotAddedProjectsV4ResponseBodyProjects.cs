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
    /// 
    /// </summary>
    public class ListDomainNotAddedProjectsV4ResponseBodyProjects 
    {

        /// <summary>
        /// 项目数字id
        /// </summary>
        [JsonProperty("project_num_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProjectNumId { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 项目描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 项目创建时间
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// 项目更新时间
        /// </summary>
        [JsonProperty("updated_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdatedTime { get; set; }

        /// <summary>
        /// 项目类型
        /// </summary>
        [JsonProperty("project_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public ListDomainNotAddedProjectsV4ResponseBodyCreator Creator { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDomainNotAddedProjectsV4ResponseBodyProjects {\n");
            sb.Append("  projectNumId: ").Append(ProjectNumId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  updatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  projectType: ").Append(ProjectType).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDomainNotAddedProjectsV4ResponseBodyProjects);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDomainNotAddedProjectsV4ResponseBodyProjects input)
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
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.UpdatedTime == input.UpdatedTime ||
                    (this.UpdatedTime != null &&
                    this.UpdatedTime.Equals(input.UpdatedTime))
                ) && 
                (
                    this.ProjectType == input.ProjectType ||
                    (this.ProjectType != null &&
                    this.ProjectType.Equals(input.ProjectType))
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
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.UpdatedTime != null)
                    hashCode = hashCode * 59 + this.UpdatedTime.GetHashCode();
                if (this.ProjectType != null)
                    hashCode = hashCode * 59 + this.ProjectType.GetHashCode();
                if (this.Creator != null)
                    hashCode = hashCode * 59 + this.Creator.GetHashCode();
                return hashCode;
            }
        }
    }
}
