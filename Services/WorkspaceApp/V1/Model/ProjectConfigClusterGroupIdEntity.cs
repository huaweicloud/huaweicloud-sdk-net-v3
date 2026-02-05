using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 项目配置ID信息，包含项目配置ID和集群ID。
    /// </summary>
    public class ProjectConfigClusterGroupIdEntity 
    {

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("cluster_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterGroupId { get; set; }

        /// <summary>
        /// 项目配置ID
        /// </summary>
        [JsonProperty("project_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectConfigId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectConfigClusterGroupIdEntity {\n");
            sb.Append("  clusterGroupId: ").Append(ClusterGroupId).Append("\n");
            sb.Append("  projectConfigId: ").Append(ProjectConfigId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProjectConfigClusterGroupIdEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProjectConfigClusterGroupIdEntity input)
        {
            if (input == null) return false;
            if (this.ClusterGroupId != input.ClusterGroupId || (this.ClusterGroupId != null && !this.ClusterGroupId.Equals(input.ClusterGroupId))) return false;
            if (this.ProjectConfigId != input.ProjectConfigId || (this.ProjectConfigId != null && !this.ProjectConfigId.Equals(input.ProjectConfigId))) return false;

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
                if (this.ClusterGroupId != null) hashCode = hashCode * 59 + this.ClusterGroupId.GetHashCode();
                if (this.ProjectConfigId != null) hashCode = hashCode * 59 + this.ProjectConfigId.GetHashCode();
                return hashCode;
            }
        }
    }
}
