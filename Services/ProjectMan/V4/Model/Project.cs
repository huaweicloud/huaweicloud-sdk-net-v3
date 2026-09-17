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
    public class Project 
    {

        /// <summary>
        /// devcloud项目的数字id
        /// </summary>
        [JsonProperty("project_num_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProjectNumId { get; set; }

        /// <summary>
        /// devcloud项目的32位id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

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
        /// 项目代号
        /// </summary>
        [JsonProperty("project_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 区域region
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 是否归档
        /// </summary>
        [JsonProperty("is_archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsArchived { get; set; }

        /// <summary>
        /// 项目类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public User Creator { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Project {\n");
            sb.Append("  projectNumId: ").Append(ProjectNumId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  updatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  projectCode: ").Append(ProjectCode).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  isArchived: ").Append(IsArchived).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Project);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Project input)
        {
            if (input == null) return false;
            if (this.ProjectNumId != input.ProjectNumId || (this.ProjectNumId != null && !this.ProjectNumId.Equals(input.ProjectNumId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.UpdatedTime != input.UpdatedTime || (this.UpdatedTime != null && !this.UpdatedTime.Equals(input.UpdatedTime))) return false;
            if (this.ProjectCode != input.ProjectCode || (this.ProjectCode != null && !this.ProjectCode.Equals(input.ProjectCode))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.IsArchived != input.IsArchived || (this.IsArchived != null && !this.IsArchived.Equals(input.IsArchived))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;

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
                if (this.ProjectNumId != null) hashCode = hashCode * 59 + this.ProjectNumId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.UpdatedTime != null) hashCode = hashCode * 59 + this.UpdatedTime.GetHashCode();
                if (this.ProjectCode != null) hashCode = hashCode * 59 + this.ProjectCode.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.IsArchived != null) hashCode = hashCode * 59 + this.IsArchived.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                return hashCode;
            }
        }
    }
}
