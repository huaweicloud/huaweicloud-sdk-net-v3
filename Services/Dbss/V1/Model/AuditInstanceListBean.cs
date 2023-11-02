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
    /// 审计实例列表bean
    /// </summary>
    public class AuditInstanceListBean 
    {

        /// <summary>
        /// 付费模式 Period：包周期 Demand：按需。
        /// </summary>
        [JsonProperty("charge_model", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeModel { get; set; }

        /// <summary>
        /// 备注信息。
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// 配置的数据库总数。
        /// </summary>
        [JsonProperty("config_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConfigNum { get; set; }

        /// <summary>
        /// 连接地址。
        /// </summary>
        [JsonProperty("connect_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectIp { get; set; }

        /// <summary>
        /// ipv6连接地址。
        /// </summary>
        [JsonProperty("connect_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectIpv6 { get; set; }

        /// <summary>
        /// CPU个数
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cpu { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 支持的数据库总数
        /// </summary>
        [JsonProperty("database_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? DatabaseLimit { get; set; }

        /// <summary>
        /// 1.冻结可释放  2.冻结不可释放 3.冻结后不可续费
        /// </summary>
        [JsonProperty("effect", NullValueHandling = NullValueHandling.Ignore)]
        public int? Effect { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("expired", NullValueHandling = NullValueHandling.Ignore)]
        public string Expired { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 剩余天数
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public string KeepDays { get; set; }

        /// <summary>
        /// 实例别名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 如果有返回，则需要升级，如果没有，则为null
        /// </summary>
        [JsonProperty("new_version", NullValueHandling = NullValueHandling.Ignore)]
        public string NewVersion { get; set; }

        /// <summary>
        /// 绑定弹性IP的portID
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// 内存
        /// </summary>
        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ram { get; set; }

        /// <summary>
        /// 实例所在region
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 到期天数
        /// </summary>
        [JsonProperty("remain_days", NullValueHandling = NullValueHandling.Ignore)]
        public string RemainDays { get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 实例的规格
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public string Scene { get; set; }

        /// <summary>
        /// 安全组
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 实例规格
        /// </summary>
        [JsonProperty("specification", NullValueHandling = NullValueHandling.Ignore)]
        public string Specification { get; set; }

        /// <summary>
        /// 实例状态： SHUTOFF(已关闭) ACTIVE(运行中，允许任何操作) DELETING(删除中，不允许任何操作) BUILD(创建中，不允许任何操作) DELETED(已删除，不需要展示) ERROR(故障，只允许删除) HAWAIT(等待备机创建成功，不允许任何操作) FROZEN(已冻结，只允许续费、绑定/解绑) UPGRADING(升级中，不允许升级操作)
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 任务状态： powering-on(正在开启，实例可以绑定、解绑) powering-off(正在关闭，实例可以绑定、解绑) rebooting(正在重启，实例可以绑定、解绑) delete_wait(等待删除，集群与实例不允许任何操作) NO_TASK(不展示)
        /// </summary>
        [JsonProperty("task", NullValueHandling = NullValueHandling.Ignore)]
        public string Task { get; set; }

        /// <summary>
        /// 实例的当前版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 虚拟私有云
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("zone", NullValueHandling = NullValueHandling.Ignore)]
        public string Zone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditInstanceListBean {\n");
            sb.Append("  chargeModel: ").Append(ChargeModel).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  configNum: ").Append(ConfigNum).Append("\n");
            sb.Append("  connectIp: ").Append(ConnectIp).Append("\n");
            sb.Append("  connectIpv6: ").Append(ConnectIpv6).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  databaseLimit: ").Append(DatabaseLimit).Append("\n");
            sb.Append("  effect: ").Append(Effect).Append("\n");
            sb.Append("  expired: ").Append(Expired).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  keepDays: ").Append(KeepDays).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  newVersion: ").Append(NewVersion).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  ram: ").Append(Ram).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  remainDays: ").Append(RemainDays).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  specification: ").Append(Specification).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  task: ").Append(Task).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  zone: ").Append(Zone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuditInstanceListBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuditInstanceListBean input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChargeModel == input.ChargeModel ||
                    (this.ChargeModel != null &&
                    this.ChargeModel.Equals(input.ChargeModel))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.ConfigNum == input.ConfigNum ||
                    (this.ConfigNum != null &&
                    this.ConfigNum.Equals(input.ConfigNum))
                ) && 
                (
                    this.ConnectIp == input.ConnectIp ||
                    (this.ConnectIp != null &&
                    this.ConnectIp.Equals(input.ConnectIp))
                ) && 
                (
                    this.ConnectIpv6 == input.ConnectIpv6 ||
                    (this.ConnectIpv6 != null &&
                    this.ConnectIpv6.Equals(input.ConnectIpv6))
                ) && 
                (
                    this.Cpu == input.Cpu ||
                    (this.Cpu != null &&
                    this.Cpu.Equals(input.Cpu))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.DatabaseLimit == input.DatabaseLimit ||
                    (this.DatabaseLimit != null &&
                    this.DatabaseLimit.Equals(input.DatabaseLimit))
                ) && 
                (
                    this.Effect == input.Effect ||
                    (this.Effect != null &&
                    this.Effect.Equals(input.Effect))
                ) && 
                (
                    this.Expired == input.Expired ||
                    (this.Expired != null &&
                    this.Expired.Equals(input.Expired))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.KeepDays == input.KeepDays ||
                    (this.KeepDays != null &&
                    this.KeepDays.Equals(input.KeepDays))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NewVersion == input.NewVersion ||
                    (this.NewVersion != null &&
                    this.NewVersion.Equals(input.NewVersion))
                ) && 
                (
                    this.PortId == input.PortId ||
                    (this.PortId != null &&
                    this.PortId.Equals(input.PortId))
                ) && 
                (
                    this.Ram == input.Ram ||
                    (this.Ram != null &&
                    this.Ram.Equals(input.Ram))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.RemainDays == input.RemainDays ||
                    (this.RemainDays != null &&
                    this.RemainDays.Equals(input.RemainDays))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.ResourceSpecCode == input.ResourceSpecCode ||
                    (this.ResourceSpecCode != null &&
                    this.ResourceSpecCode.Equals(input.ResourceSpecCode))
                ) && 
                (
                    this.Scene == input.Scene ||
                    (this.Scene != null &&
                    this.Scene.Equals(input.Scene))
                ) && 
                (
                    this.SecurityGroupId == input.SecurityGroupId ||
                    (this.SecurityGroupId != null &&
                    this.SecurityGroupId.Equals(input.SecurityGroupId))
                ) && 
                (
                    this.Specification == input.Specification ||
                    (this.Specification != null &&
                    this.Specification.Equals(input.Specification))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.Task == input.Task ||
                    (this.Task != null &&
                    this.Task.Equals(input.Task))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.Zone == input.Zone ||
                    (this.Zone != null &&
                    this.Zone.Equals(input.Zone))
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
                if (this.ChargeModel != null)
                    hashCode = hashCode * 59 + this.ChargeModel.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.ConfigNum != null)
                    hashCode = hashCode * 59 + this.ConfigNum.GetHashCode();
                if (this.ConnectIp != null)
                    hashCode = hashCode * 59 + this.ConnectIp.GetHashCode();
                if (this.ConnectIpv6 != null)
                    hashCode = hashCode * 59 + this.ConnectIpv6.GetHashCode();
                if (this.Cpu != null)
                    hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.DatabaseLimit != null)
                    hashCode = hashCode * 59 + this.DatabaseLimit.GetHashCode();
                if (this.Effect != null)
                    hashCode = hashCode * 59 + this.Effect.GetHashCode();
                if (this.Expired != null)
                    hashCode = hashCode * 59 + this.Expired.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.KeepDays != null)
                    hashCode = hashCode * 59 + this.KeepDays.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NewVersion != null)
                    hashCode = hashCode * 59 + this.NewVersion.GetHashCode();
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.Ram != null)
                    hashCode = hashCode * 59 + this.Ram.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.RemainDays != null)
                    hashCode = hashCode * 59 + this.RemainDays.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceSpecCode != null)
                    hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.Scene != null)
                    hashCode = hashCode * 59 + this.Scene.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.Specification != null)
                    hashCode = hashCode * 59 + this.Specification.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.Task != null)
                    hashCode = hashCode * 59 + this.Task.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Zone != null)
                    hashCode = hashCode * 59 + this.Zone.GetHashCode();
                return hashCode;
            }
        }
    }
}
