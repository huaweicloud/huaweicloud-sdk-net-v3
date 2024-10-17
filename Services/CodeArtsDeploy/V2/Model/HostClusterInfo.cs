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
    /// 主机集群信息
    /// </summary>
    public class HostClusterInfo 
    {

        /// <summary>
        /// 主机集群id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 集群内主机数量，一个主机集群内最多可添加200台主机
        /// </summary>
        [JsonProperty("host_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? HostCount { get; set; }

        /// <summary>
        /// 主机集群名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 操作系统：windows|linux
        /// </summary>
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// slave集群id，默认为null时使用默认slave集群，用户自定义slave时为slave集群id
        /// </summary>
        [JsonProperty("slave_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserInfo CreatedBy { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("permission", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionClusterDetail Permission { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// 环境数量
        /// </summary>
        [JsonProperty("env_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnvCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HostClusterInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  hostCount: ").Append(HostCount).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  slaveClusterId: ").Append(SlaveClusterId).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  permission: ").Append(Permission).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  envCount: ").Append(EnvCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HostClusterInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HostClusterInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.HostCount != input.HostCount || (this.HostCount != null && !this.HostCount.Equals(input.HostCount))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Os != input.Os || (this.Os != null && !this.Os.Equals(input.Os))) return false;
            if (this.SlaveClusterId != input.SlaveClusterId || (this.SlaveClusterId != null && !this.SlaveClusterId.Equals(input.SlaveClusterId))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Permission != input.Permission || (this.Permission != null && !this.Permission.Equals(input.Permission))) return false;
            if (this.NickName != input.NickName || (this.NickName != null && !this.NickName.Equals(input.NickName))) return false;
            if (this.EnvCount != input.EnvCount || (this.EnvCount != null && !this.EnvCount.Equals(input.EnvCount))) return false;

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
                if (this.HostCount != null) hashCode = hashCode * 59 + this.HostCount.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Os != null) hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.SlaveClusterId != null) hashCode = hashCode * 59 + this.SlaveClusterId.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Permission != null) hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.EnvCount != null) hashCode = hashCode * 59 + this.EnvCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
