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
    /// Response Object
    /// </summary>
    public class ShowDeploymentGroupDetailResponse : SdkResponse
    {

        /// <summary>
        /// 主机集群id
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("updated_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedTime { get; set; }

        /// <summary>
        /// 集群内主机数量，一个主机集群内最多可添加200台主机
        /// </summary>
        [JsonProperty("host_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? HostCount { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 主机集群名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 局点信息
        /// </summary>
        [JsonProperty("region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionName { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 操作系统：windows|linux
        /// </summary>
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// 自动连通性验证 0不执行 1每日 2每周
        /// </summary>
        [JsonProperty("auto_connection_test_switch", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoConnectionTestSwitch { get; set; }

        /// <summary>
        /// slave集群id，默认为null时使用默认slave集群，用户自定义slave时为slave集群id
        /// </summary>
        [JsonProperty("slave_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveClusterId { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserInfo CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("updated_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserInfo UpdatedBy { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("permission", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionGroupDetail Permission { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDeploymentGroupDetailResponse {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  updatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  hostCount: ").Append(HostCount).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  regionName: ").Append(RegionName).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  autoConnectionTestSwitch: ").Append(AutoConnectionTestSwitch).Append("\n");
            sb.Append("  slaveClusterId: ").Append(SlaveClusterId).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  updatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  permission: ").Append(Permission).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDeploymentGroupDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDeploymentGroupDetailResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
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
                    this.HostCount == input.HostCount ||
                    (this.HostCount != null &&
                    this.HostCount.Equals(input.HostCount))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RegionName == input.RegionName ||
                    (this.RegionName != null &&
                    this.RegionName.Equals(input.RegionName))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.AutoConnectionTestSwitch == input.AutoConnectionTestSwitch ||
                    (this.AutoConnectionTestSwitch != null &&
                    this.AutoConnectionTestSwitch.Equals(input.AutoConnectionTestSwitch))
                ) && 
                (
                    this.SlaveClusterId == input.SlaveClusterId ||
                    (this.SlaveClusterId != null &&
                    this.SlaveClusterId.Equals(input.SlaveClusterId))
                ) && 
                (
                    this.NickName == input.NickName ||
                    (this.NickName != null &&
                    this.NickName.Equals(input.NickName))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.UpdatedTime != null)
                    hashCode = hashCode * 59 + this.UpdatedTime.GetHashCode();
                if (this.HostCount != null)
                    hashCode = hashCode * 59 + this.HostCount.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RegionName != null)
                    hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.AutoConnectionTestSwitch != null)
                    hashCode = hashCode * 59 + this.AutoConnectionTestSwitch.GetHashCode();
                if (this.SlaveClusterId != null)
                    hashCode = hashCode * 59 + this.SlaveClusterId.GetHashCode();
                if (this.NickName != null)
                    hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.UpdatedBy != null)
                    hashCode = hashCode * 59 + this.UpdatedBy.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                return hashCode;
            }
        }
    }
}
