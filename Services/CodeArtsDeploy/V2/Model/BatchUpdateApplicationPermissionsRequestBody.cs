using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchUpdateApplicationPermissionsRequestBody 
    {

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 应用列表
        /// </summary>
        [JsonProperty("application_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// 角色权限
        /// </summary>
        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<AppPermission> Roles { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateApplicationPermissionsRequestBody {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  applicationIds: ").Append(ApplicationIds).Append("\n");
            sb.Append("  roles: ").Append(Roles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateApplicationPermissionsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateApplicationPermissionsRequestBody input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ApplicationIds != input.ApplicationIds || (this.ApplicationIds != null && input.ApplicationIds != null && !this.ApplicationIds.SequenceEqual(input.ApplicationIds))) return false;
            if (this.Roles != input.Roles || (this.Roles != null && input.Roles != null && !this.Roles.SequenceEqual(input.Roles))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ApplicationIds != null) hashCode = hashCode * 59 + this.ApplicationIds.GetHashCode();
                if (this.Roles != null) hashCode = hashCode * 59 + this.Roles.GetHashCode();
                return hashCode;
            }
        }
    }
}
