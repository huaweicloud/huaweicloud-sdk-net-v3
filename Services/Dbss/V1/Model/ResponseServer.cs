using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResponseServer 
    {

        /// <summary>
        /// 连接IP
        /// </summary>
        [JsonProperty("connect_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectIp { get; set; }

        /// <summary>
        /// CPU数
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpu { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 实例冻结状态  - 1：冻结可释放 （默认）  - 2：冻结不可释放  - 3：冻结后不可续费
        /// </summary>
        [JsonProperty("effect", NullValueHandling = NullValueHandling.Ignore)]
        public int? Effect { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 双机实例HA中用来标注实例为主机还是备机, - 0：主机  - 1：备机
        /// </summary>
        [JsonProperty("is_active", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsActive { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 内存大小
        /// </summary>
        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public string Ram { get; set; }

        /// <summary>
        /// 所属REGION
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 实例所属规格编码
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// 冻结场景  - POLICE：公安冻结  - ILLEGAL：违规冻结  - VERIFY：未实名认证冻结  - PARTNER：合作伙伴冻结 - ARREAR：普通冻结（普通）
        /// </summary>
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public string Scene { get; set; }

        /// <summary>
        /// 安全组ID
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 资源规格类型编码
        /// </summary>
        [JsonProperty("specification", NullValueHandling = NullValueHandling.Ignore)]
        public string Specification { get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 实例处理中状态
        /// </summary>
        [JsonProperty("task_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 升级状态  - SUCCESS：成功  - FAILED：失败  - UPGRADING：升级中
        /// </summary>
        [JsonProperty("update_status", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateStatus { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 所属区域
        /// </summary>
        [JsonProperty("zone", NullValueHandling = NullValueHandling.Ignore)]
        public string Zone { get; set; }

        /// <summary>
        /// 服务器ID
        /// </summary>
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseServer {\n");
            sb.Append("  connectIp: ").Append(ConnectIp).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  effect: ").Append(Effect).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  isActive: ").Append(IsActive).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  ram: ").Append(Ram).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  specification: ").Append(Specification).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  taskStatus: ").Append(TaskStatus).Append("\n");
            sb.Append("  updateStatus: ").Append(UpdateStatus).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  zone: ").Append(Zone).Append("\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResponseServer);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResponseServer input)
        {
            if (input == null) return false;
            if (this.ConnectIp != input.ConnectIp || (this.ConnectIp != null && !this.ConnectIp.Equals(input.ConnectIp))) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Effect != input.Effect || (this.Effect != null && !this.Effect.Equals(input.Effect))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.IsActive != input.IsActive || (this.IsActive != null && !this.IsActive.Equals(input.IsActive))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Ram != input.Ram || (this.Ram != null && !this.Ram.Equals(input.Ram))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.ResourceSpecCode != input.ResourceSpecCode || (this.ResourceSpecCode != null && !this.ResourceSpecCode.Equals(input.ResourceSpecCode))) return false;
            if (this.Scene != input.Scene || (this.Scene != null && !this.Scene.Equals(input.Scene))) return false;
            if (this.SecurityGroupId != input.SecurityGroupId || (this.SecurityGroupId != null && !this.SecurityGroupId.Equals(input.SecurityGroupId))) return false;
            if (this.Specification != input.Specification || (this.Specification != null && !this.Specification.Equals(input.Specification))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.TaskStatus != input.TaskStatus || (this.TaskStatus != null && !this.TaskStatus.Equals(input.TaskStatus))) return false;
            if (this.UpdateStatus != input.UpdateStatus || (this.UpdateStatus != null && !this.UpdateStatus.Equals(input.UpdateStatus))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.Zone != input.Zone || (this.Zone != null && !this.Zone.Equals(input.Zone))) return false;
            if (this.ServerId != input.ServerId || (this.ServerId != null && !this.ServerId.Equals(input.ServerId))) return false;

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
                if (this.ConnectIp != null) hashCode = hashCode * 59 + this.ConnectIp.GetHashCode();
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Effect != null) hashCode = hashCode * 59 + this.Effect.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.IsActive != null) hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Ram != null) hashCode = hashCode * 59 + this.Ram.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.ResourceSpecCode != null) hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.Scene != null) hashCode = hashCode * 59 + this.Scene.GetHashCode();
                if (this.SecurityGroupId != null) hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.Specification != null) hashCode = hashCode * 59 + this.Specification.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.TaskStatus != null) hashCode = hashCode * 59 + this.TaskStatus.GetHashCode();
                if (this.UpdateStatus != null) hashCode = hashCode * 59 + this.UpdateStatus.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Zone != null) hashCode = hashCode * 59 + this.Zone.GetHashCode();
                if (this.ServerId != null) hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
