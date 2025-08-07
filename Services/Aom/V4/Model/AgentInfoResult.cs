using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AgentInfoResult 
    {

        /// <summary>
        /// 机器 IP。
        /// </summary>
        [JsonProperty("inner_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string InnerIp { get; set; }

        /// <summary>
        /// 机器导入IP。
        /// </summary>
        [JsonProperty("import_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ImportIp { get; set; }

        /// <summary>
        /// agent id。
        /// </summary>
        [JsonProperty("agent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentId { get; set; }

        /// <summary>
        /// 主机名。
        /// </summary>
        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }

        /// <summary>
        /// 操作系统。
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OsType { get; set; }

        /// <summary>
        /// UniAgent状态。
        /// </summary>
        [JsonProperty("agent_state", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentState { get; set; }

        /// <summary>
        /// 所属project ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// UniAgent版本。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 是否华为云机器。
        /// </summary>
        [JsonProperty("is_hw_cloud_host", NullValueHandling = NullValueHandling.Ignore)]
        public string IsHwCloudHost { get; set; }

        /// <summary>
        /// VPC ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// CMDB ID.
        /// </summary>
        [JsonProperty("cmdb_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CmdbId { get; set; }

        /// <summary>
        /// ECS ID。唯一值.
        /// </summary>
        [JsonProperty("ecs_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsId { get; set; }

        /// <summary>
        /// 机器所属domain ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentInfoResult {\n");
            sb.Append("  innerIp: ").Append(InnerIp).Append("\n");
            sb.Append("  importIp: ").Append(ImportIp).Append("\n");
            sb.Append("  agentId: ").Append(AgentId).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  agentState: ").Append(AgentState).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  isHwCloudHost: ").Append(IsHwCloudHost).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  cmdbId: ").Append(CmdbId).Append("\n");
            sb.Append("  ecsId: ").Append(EcsId).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentInfoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentInfoResult input)
        {
            if (input == null) return false;
            if (this.InnerIp != input.InnerIp || (this.InnerIp != null && !this.InnerIp.Equals(input.InnerIp))) return false;
            if (this.ImportIp != input.ImportIp || (this.ImportIp != null && !this.ImportIp.Equals(input.ImportIp))) return false;
            if (this.AgentId != input.AgentId || (this.AgentId != null && !this.AgentId.Equals(input.AgentId))) return false;
            if (this.HostName != input.HostName || (this.HostName != null && !this.HostName.Equals(input.HostName))) return false;
            if (this.OsType != input.OsType || (this.OsType != null && !this.OsType.Equals(input.OsType))) return false;
            if (this.AgentState != input.AgentState || (this.AgentState != null && !this.AgentState.Equals(input.AgentState))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.IsHwCloudHost != input.IsHwCloudHost || (this.IsHwCloudHost != null && !this.IsHwCloudHost.Equals(input.IsHwCloudHost))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.CmdbId != input.CmdbId || (this.CmdbId != null && !this.CmdbId.Equals(input.CmdbId))) return false;
            if (this.EcsId != input.EcsId || (this.EcsId != null && !this.EcsId.Equals(input.EcsId))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;

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
                if (this.InnerIp != null) hashCode = hashCode * 59 + this.InnerIp.GetHashCode();
                if (this.ImportIp != null) hashCode = hashCode * 59 + this.ImportIp.GetHashCode();
                if (this.AgentId != null) hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.HostName != null) hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.OsType != null) hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.AgentState != null) hashCode = hashCode * 59 + this.AgentState.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.IsHwCloudHost != null) hashCode = hashCode * 59 + this.IsHwCloudHost.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.CmdbId != null) hashCode = hashCode * 59 + this.CmdbId.GetHashCode();
                if (this.EcsId != null) hashCode = hashCode * 59 + this.EcsId.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                return hashCode;
            }
        }
    }
}
