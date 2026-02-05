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
    /// 切换文件夹归属集群请求体
    /// </summary>
    public class ChangeClusterReq 
    {

        /// <summary>
        /// 目标集群ID
        /// </summary>
        [JsonProperty("target_cluster_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetClusterGroupId { get; set; }

        /// <summary>
        /// 目标项目配置ID
        /// </summary>
        [JsonProperty("target_project_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetProjectConfigId { get; set; }

        /// <summary>
        /// 文件系统id,数量区间 [1, 50]。
        /// </summary>
        [JsonProperty("cloud_storage_assignment_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CloudStorageAssignmentIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeClusterReq {\n");
            sb.Append("  targetClusterGroupId: ").Append(TargetClusterGroupId).Append("\n");
            sb.Append("  targetProjectConfigId: ").Append(TargetProjectConfigId).Append("\n");
            sb.Append("  cloudStorageAssignmentIds: ").Append(CloudStorageAssignmentIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeClusterReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeClusterReq input)
        {
            if (input == null) return false;
            if (this.TargetClusterGroupId != input.TargetClusterGroupId || (this.TargetClusterGroupId != null && !this.TargetClusterGroupId.Equals(input.TargetClusterGroupId))) return false;
            if (this.TargetProjectConfigId != input.TargetProjectConfigId || (this.TargetProjectConfigId != null && !this.TargetProjectConfigId.Equals(input.TargetProjectConfigId))) return false;
            if (this.CloudStorageAssignmentIds != input.CloudStorageAssignmentIds || (this.CloudStorageAssignmentIds != null && input.CloudStorageAssignmentIds != null && !this.CloudStorageAssignmentIds.SequenceEqual(input.CloudStorageAssignmentIds))) return false;

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
                if (this.TargetClusterGroupId != null) hashCode = hashCode * 59 + this.TargetClusterGroupId.GetHashCode();
                if (this.TargetProjectConfigId != null) hashCode = hashCode * 59 + this.TargetProjectConfigId.GetHashCode();
                if (this.CloudStorageAssignmentIds != null) hashCode = hashCode * 59 + this.CloudStorageAssignmentIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
