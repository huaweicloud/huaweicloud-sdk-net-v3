using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Vag 
    {

        /// <summary>
        /// vAG信息ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 站点ID
        /// </summary>
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteId { get; set; }

        /// <summary>
        /// vAG IP，与管理节点相同的IP
        /// </summary>
        [JsonProperty("vag_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string VagIp { get; set; }

        /// <summary>
        /// vAG内网IP，HDA往这个IP上报心跳
        /// </summary>
        [JsonProperty("private_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// vAG内网IPv6
        /// </summary>
        [JsonProperty("private_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIpv6 { get; set; }

        /// <summary>
        /// vAG端口ID，与管理节点相同的端口的ID
        /// </summary>
        [JsonProperty("vag_port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VagPortId { get; set; }

        /// <summary>
        /// SSH用户的名称，固定为gandalf
        /// </summary>
        [JsonProperty("ssh_user", NullValueHandling = NullValueHandling.Ignore)]
        public string SshUser { get; set; }

        /// <summary>
        /// SSH用户的密码
        /// </summary>
        [JsonProperty("ssh_pwd", NullValueHandling = NullValueHandling.Ignore)]
        public string SshPwd { get; set; }

        /// <summary>
        /// vAG所属ECS的ID
        /// </summary>
        [JsonProperty("vm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VmId { get; set; }

        /// <summary>
        /// vAG所属机器名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// vAG内部通信IP，最终租户VPC的子网IP
        /// </summary>
        [JsonProperty("internal_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string InternalIp { get; set; }

        /// <summary>
        /// vAG内部通信IPV6
        /// </summary>
        [JsonProperty("internal_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public string InternalIpv6 { get; set; }

        /// <summary>
        /// vAG内部通信端口ID，最终租户VPC的子网中端口的ID
        /// </summary>
        [JsonProperty("internal_port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InternalPortId { get; set; }

        /// <summary>
        /// 外部通信IP，可能独立的EIP
        /// </summary>
        [JsonProperty("external_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalIp { get; set; }

        /// <summary>
        /// 外部通信ID，可能独立的EIP ID
        /// </summary>
        [JsonProperty("external_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        /// <summary>
        /// root用户的名称，固定为root
        /// </summary>
        [JsonProperty("root_user", NullValueHandling = NullValueHandling.Ignore)]
        public string RootUser { get; set; }

        /// <summary>
        /// root用户的密码
        /// </summary>
        [JsonProperty("root_pwd", NullValueHandling = NullValueHandling.Ignore)]
        public string RootPwd { get; set; }

        /// <summary>
        /// vag操作状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 可用分区
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 创建时间字符串
        /// </summary>
        [JsonProperty("create_time_str", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeStr { get; set; }

        /// <summary>
        /// vag服务状态 NOT_USE：维护，ON_USE：启用，CANCELLATION：退服
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 在线用户数
        /// </summary>
        [JsonProperty("number_of_online_user", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumberOfOnlineUser { get; set; }

        /// <summary>
        /// vag运行状态
        /// </summary>
        [JsonProperty("running_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RunningStatus { get; set; }

        /// <summary>
        /// 租户侧domainId
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// vag当前版本号
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// vag最新版本号。
        /// </summary>
        [JsonProperty("latest_version", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestVersion { get; set; }

        /// <summary>
        /// wksAccessEdge版本号
        /// </summary>
        [JsonProperty("access_edge_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessEdgeVersion { get; set; }

        /// <summary>
        /// 项目是否被锁定 0是未锁定 1是锁定
        /// </summary>
        [JsonProperty("tenant_lock", NullValueHandling = NullValueHandling.Ignore)]
        public int? TenantLock { get; set; }

        /// <summary>
        /// 资源池id
        /// </summary>
        [JsonProperty("resource_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourcePoolId { get; set; }

        /// <summary>
        /// agent角色，如：vag,vap4down,vap4up,authConnector
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// 资源池类型，public,private
        /// </summary>
        [JsonProperty("resource_pool_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourcePoolType { get; set; }

        /// <summary>
        /// 边缘sk
        /// </summary>
        [JsonProperty("edge_sk", NullValueHandling = NullValueHandling.Ignore)]
        public string EdgeSk { get; set; }

        /// <summary>
        /// 是否有心跳
        /// </summary>
        [JsonProperty("has_heartbeat", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasHeartbeat { get; set; }

        /// <summary>
        /// VAG负载个数
        /// </summary>
        [JsonProperty("user_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vag {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  siteId: ").Append(SiteId).Append("\n");
            sb.Append("  vagIp: ").Append(VagIp).Append("\n");
            sb.Append("  privateIp: ").Append(PrivateIp).Append("\n");
            sb.Append("  privateIpv6: ").Append(PrivateIpv6).Append("\n");
            sb.Append("  vagPortId: ").Append(VagPortId).Append("\n");
            sb.Append("  sshUser: ").Append(SshUser).Append("\n");
            sb.Append("  sshPwd: ").Append(SshPwd).Append("\n");
            sb.Append("  vmId: ").Append(VmId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  internalIp: ").Append(InternalIp).Append("\n");
            sb.Append("  internalIpv6: ").Append(InternalIpv6).Append("\n");
            sb.Append("  internalPortId: ").Append(InternalPortId).Append("\n");
            sb.Append("  externalIp: ").Append(ExternalIp).Append("\n");
            sb.Append("  externalId: ").Append(ExternalId).Append("\n");
            sb.Append("  rootUser: ").Append(RootUser).Append("\n");
            sb.Append("  rootPwd: ").Append(RootPwd).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  createTimeStr: ").Append(CreateTimeStr).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  numberOfOnlineUser: ").Append(NumberOfOnlineUser).Append("\n");
            sb.Append("  runningStatus: ").Append(RunningStatus).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  latestVersion: ").Append(LatestVersion).Append("\n");
            sb.Append("  accessEdgeVersion: ").Append(AccessEdgeVersion).Append("\n");
            sb.Append("  tenantLock: ").Append(TenantLock).Append("\n");
            sb.Append("  resourcePoolId: ").Append(ResourcePoolId).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  resourcePoolType: ").Append(ResourcePoolType).Append("\n");
            sb.Append("  edgeSk: ").Append(EdgeSk).Append("\n");
            sb.Append("  hasHeartbeat: ").Append(HasHeartbeat).Append("\n");
            sb.Append("  userCount: ").Append(UserCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Vag);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Vag input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.SiteId != input.SiteId || (this.SiteId != null && !this.SiteId.Equals(input.SiteId))) return false;
            if (this.VagIp != input.VagIp || (this.VagIp != null && !this.VagIp.Equals(input.VagIp))) return false;
            if (this.PrivateIp != input.PrivateIp || (this.PrivateIp != null && !this.PrivateIp.Equals(input.PrivateIp))) return false;
            if (this.PrivateIpv6 != input.PrivateIpv6 || (this.PrivateIpv6 != null && !this.PrivateIpv6.Equals(input.PrivateIpv6))) return false;
            if (this.VagPortId != input.VagPortId || (this.VagPortId != null && !this.VagPortId.Equals(input.VagPortId))) return false;
            if (this.SshUser != input.SshUser || (this.SshUser != null && !this.SshUser.Equals(input.SshUser))) return false;
            if (this.SshPwd != input.SshPwd || (this.SshPwd != null && !this.SshPwd.Equals(input.SshPwd))) return false;
            if (this.VmId != input.VmId || (this.VmId != null && !this.VmId.Equals(input.VmId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.InternalIp != input.InternalIp || (this.InternalIp != null && !this.InternalIp.Equals(input.InternalIp))) return false;
            if (this.InternalIpv6 != input.InternalIpv6 || (this.InternalIpv6 != null && !this.InternalIpv6.Equals(input.InternalIpv6))) return false;
            if (this.InternalPortId != input.InternalPortId || (this.InternalPortId != null && !this.InternalPortId.Equals(input.InternalPortId))) return false;
            if (this.ExternalIp != input.ExternalIp || (this.ExternalIp != null && !this.ExternalIp.Equals(input.ExternalIp))) return false;
            if (this.ExternalId != input.ExternalId || (this.ExternalId != null && !this.ExternalId.Equals(input.ExternalId))) return false;
            if (this.RootUser != input.RootUser || (this.RootUser != null && !this.RootUser.Equals(input.RootUser))) return false;
            if (this.RootPwd != input.RootPwd || (this.RootPwd != null && !this.RootPwd.Equals(input.RootPwd))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CreateTimeStr != input.CreateTimeStr || (this.CreateTimeStr != null && !this.CreateTimeStr.Equals(input.CreateTimeStr))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.NumberOfOnlineUser != input.NumberOfOnlineUser || (this.NumberOfOnlineUser != null && !this.NumberOfOnlineUser.Equals(input.NumberOfOnlineUser))) return false;
            if (this.RunningStatus != input.RunningStatus || (this.RunningStatus != null && !this.RunningStatus.Equals(input.RunningStatus))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.LatestVersion != input.LatestVersion || (this.LatestVersion != null && !this.LatestVersion.Equals(input.LatestVersion))) return false;
            if (this.AccessEdgeVersion != input.AccessEdgeVersion || (this.AccessEdgeVersion != null && !this.AccessEdgeVersion.Equals(input.AccessEdgeVersion))) return false;
            if (this.TenantLock != input.TenantLock || (this.TenantLock != null && !this.TenantLock.Equals(input.TenantLock))) return false;
            if (this.ResourcePoolId != input.ResourcePoolId || (this.ResourcePoolId != null && !this.ResourcePoolId.Equals(input.ResourcePoolId))) return false;
            if (this.Role != input.Role || (this.Role != null && !this.Role.Equals(input.Role))) return false;
            if (this.ResourcePoolType != input.ResourcePoolType || (this.ResourcePoolType != null && !this.ResourcePoolType.Equals(input.ResourcePoolType))) return false;
            if (this.EdgeSk != input.EdgeSk || (this.EdgeSk != null && !this.EdgeSk.Equals(input.EdgeSk))) return false;
            if (this.HasHeartbeat != input.HasHeartbeat || (this.HasHeartbeat != null && !this.HasHeartbeat.Equals(input.HasHeartbeat))) return false;
            if (this.UserCount != input.UserCount || (this.UserCount != null && !this.UserCount.Equals(input.UserCount))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.SiteId != null) hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                if (this.VagIp != null) hashCode = hashCode * 59 + this.VagIp.GetHashCode();
                if (this.PrivateIp != null) hashCode = hashCode * 59 + this.PrivateIp.GetHashCode();
                if (this.PrivateIpv6 != null) hashCode = hashCode * 59 + this.PrivateIpv6.GetHashCode();
                if (this.VagPortId != null) hashCode = hashCode * 59 + this.VagPortId.GetHashCode();
                if (this.SshUser != null) hashCode = hashCode * 59 + this.SshUser.GetHashCode();
                if (this.SshPwd != null) hashCode = hashCode * 59 + this.SshPwd.GetHashCode();
                if (this.VmId != null) hashCode = hashCode * 59 + this.VmId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.InternalIp != null) hashCode = hashCode * 59 + this.InternalIp.GetHashCode();
                if (this.InternalIpv6 != null) hashCode = hashCode * 59 + this.InternalIpv6.GetHashCode();
                if (this.InternalPortId != null) hashCode = hashCode * 59 + this.InternalPortId.GetHashCode();
                if (this.ExternalIp != null) hashCode = hashCode * 59 + this.ExternalIp.GetHashCode();
                if (this.ExternalId != null) hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.RootUser != null) hashCode = hashCode * 59 + this.RootUser.GetHashCode();
                if (this.RootPwd != null) hashCode = hashCode * 59 + this.RootPwd.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreateTimeStr != null) hashCode = hashCode * 59 + this.CreateTimeStr.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.NumberOfOnlineUser != null) hashCode = hashCode * 59 + this.NumberOfOnlineUser.GetHashCode();
                if (this.RunningStatus != null) hashCode = hashCode * 59 + this.RunningStatus.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.LatestVersion != null) hashCode = hashCode * 59 + this.LatestVersion.GetHashCode();
                if (this.AccessEdgeVersion != null) hashCode = hashCode * 59 + this.AccessEdgeVersion.GetHashCode();
                if (this.TenantLock != null) hashCode = hashCode * 59 + this.TenantLock.GetHashCode();
                if (this.ResourcePoolId != null) hashCode = hashCode * 59 + this.ResourcePoolId.GetHashCode();
                if (this.Role != null) hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.ResourcePoolType != null) hashCode = hashCode * 59 + this.ResourcePoolType.GetHashCode();
                if (this.EdgeSk != null) hashCode = hashCode * 59 + this.EdgeSk.GetHashCode();
                if (this.HasHeartbeat != null) hashCode = hashCode * 59 + this.HasHeartbeat.GetHashCode();
                if (this.UserCount != null) hashCode = hashCode * 59 + this.UserCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
