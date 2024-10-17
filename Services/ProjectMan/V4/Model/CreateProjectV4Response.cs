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
    /// Response Object
    /// </summary>
    public class CreateProjectV4Response : SdkResponse
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
        /// 项目类型
        /// </summary>
        [JsonProperty("project_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectType { get; set; }

        /// <summary>
        /// 创建者的数字id
        /// </summary>
        [JsonProperty("user_num_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserNumId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateProjectV4Response {\n");
            sb.Append("  projectNumId: ").Append(ProjectNumId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  projectType: ").Append(ProjectType).Append("\n");
            sb.Append("  userNumId: ").Append(UserNumId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateProjectV4Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateProjectV4Response input)
        {
            if (input == null) return false;
            if (this.ProjectNumId != input.ProjectNumId || (this.ProjectNumId != null && !this.ProjectNumId.Equals(input.ProjectNumId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ProjectType != input.ProjectType || (this.ProjectType != null && !this.ProjectType.Equals(input.ProjectType))) return false;
            if (this.UserNumId != input.UserNumId || (this.UserNumId != null && !this.UserNumId.Equals(input.UserNumId))) return false;

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
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ProjectType != null) hashCode = hashCode * 59 + this.ProjectType.GetHashCode();
                if (this.UserNumId != null) hashCode = hashCode * 59 + this.UserNumId.GetHashCode();
                return hashCode;
            }
        }
    }
}
