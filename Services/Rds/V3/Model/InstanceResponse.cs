using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 实例信息。
    /// </summary>
    public class InstanceResponse 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例状态。 - 值为“BUILD”，表示实例正在创建。 - 值为“ACTIVE”，表示实例正常。 - 值为“FAILED”，表示实例异常。 - 值为“FROZEN”，表示实例冻结。 - 值为“MODIFYING”，表示实例正在扩容。 - 值为“REBOOTING”，表示实例正在重启。 - 值为“RESTORING”，表示实例正在恢复。 - 值为“MODIFYING INSTANCE TYPE”，表示实例正在转主备。 - 值为“SWITCHOVER”，表示实例正在主备切换。 - 值为“MIGRATING”，表示实例正在迁移。 - 值为“BACKING UP”，表示实例正在进行备份。 - 值为“MODIFYING DATABASE PORT”，表示实例正在修改数据库端口。 - 值为“STORAGE FULL”，表示实例磁盘空间满。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 实例是否开启SSL，取值为\&quot;true\&quot;表示实例开启了SSL，取值为\&quot;false\&quot;表示实例未开启SSL。
        /// </summary>
        [JsonProperty("enable_ssl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// 实例内网IP地址列表。弹性云服务器创建成功后该值存在，其他情况下为空字符串。
        /// </summary>
        [JsonProperty("private_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PrivateIps { get; set; }

        /// <summary>
        /// 内网域名列表
        /// </summary>
        [JsonProperty("private_dns_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PrivateDnsNames { get; set; }

        /// <summary>
        /// 公网域名列表
        /// </summary>
        [JsonProperty("public_dns_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublicDnsNames { get; set; }

        /// <summary>
        /// 实例外网IP地址列表。
        /// </summary>
        [JsonProperty("public_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublicIps { get; set; }

        /// <summary>
        /// 实例类型，取值为“Single”，“Ha”或“Replica”，分别对应于单机实例、主备实例、只读实例。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 创建时间，格式为“yyyy-mm-ddThh:mm:ssZ”。  其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。  说明：创建时返回值为空，数据库实例创建成功后该值不为空。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 更新时间，格式与“created”字段对应格式完全相同。  说明：创建时返回值为空，数据库实例创建成功后该值不为空。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 默认用户名。
        /// </summary>
        [JsonProperty("db_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbUserName { get; set; }

        /// <summary>
        /// 数据库切换策略。取值为“reliability”或“availability”，分别对应于可靠性优先和可用性优先。
        /// </summary>
        [JsonProperty("switch_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchStrategy { get; set; }

        /// <summary>
        /// 客户设置实例只读API的状态信息。仅支持RDS for MySQL引擎。 - true，表示该实例为客户设置的只读状态 - false， 表示该实例未被客户设置只读
        /// </summary>
        [JsonProperty("read_only_by_user", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReadOnlyByUser { get; set; }

        /// <summary>
        /// 可维护时间窗，为UTC时间。
        /// </summary>
        [JsonProperty("maintenance_window", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintenanceWindow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodeResponse> Nodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("related_instance", NullValueHandling = NullValueHandling.Ignore)]
        public List<RelatedInstance> RelatedInstance { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datastore", NullValueHandling = NullValueHandling.Ignore)]
        public Datastore Datastore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ha", NullValueHandling = NullValueHandling.Ignore)]
        public HaResponse Ha { get; set; }

        /// <summary>
        /// 数据库端口信息。  - MySQL数据库端口设置范围为1024～65535（其中12017和33071被RDS系统占用不可设置）。 - PostgreSQL数据库端口修改范围为2100～9500。 - Microsoft SQL Server实例的端口设置范围为1433和2100~9500（其中5355和5985不可设置。对于2017 EE版，5050、5353和5986不可设置）。  当不传该参数时，默认端口如下：  - MySQL默认3306。 - PostgreSQL默认5432。 - Microsoft SQL Server默认1433。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public BackupStrategyForResponse BackupStrategy { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 用于磁盘加密的密钥ID。
        /// </summary>
        [JsonProperty("disk_encryption_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskEncryptionId { get; set; }

        /// <summary>
        /// 规格码。
        /// </summary>
        [JsonProperty("flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// CPU大小。例如，1表示1U。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpu { get; set; }

        /// <summary>
        /// 内存大小（单位：GB）。
        /// </summary>
        [JsonProperty("mem", NullValueHandling = NullValueHandling.Ignore)]
        public string Mem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public Volume Volume { get; set; }

        /// <summary>
        /// 区域ID。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 虚拟私有云ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 安全组ID。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("charge_info", NullValueHandling = NullValueHandling.Ignore)]
        public ChargeInfoResponse ChargeInfo { get; set; }

        /// <summary>
        /// 时区。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagResponse> Tags { get; set; }

        /// <summary>
        /// 备份空间使用量，单位GB。  该字段仅用于查询指定SQL Server实例信息时返回。
        /// </summary>
        [JsonProperty("backup_used_space", NullValueHandling = NullValueHandling.Ignore)]
        public double? BackupUsedSpace { get; set; }

        /// <summary>
        /// 磁盘空间使用量，单位GB。  该字段仅用于查询指定SQL Server实例信息时返回。
        /// </summary>
        [JsonProperty("storage_used_space", NullValueHandling = NullValueHandling.Ignore)]
        public double? StorageUsedSpace { get; set; }

        /// <summary>
        /// 订单ID，仅包周期场景返回。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 是否已被DDM实例关联。
        /// </summary>
        [JsonProperty("associated_with_ddm", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AssociatedWithDdm { get; set; }

        /// <summary>
        /// 实例的备注信息。
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string Alias { get; set; }

        /// <summary>
        /// 实例磁盘的最大IOPS值。  当前该字段仅对于SQL Server引擎实例返回。
        /// </summary>
        [JsonProperty("max_iops", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxIops { get; set; }

        /// <summary>
        /// 实例的到期时间，格式为“yyyy-mm-ddThh:mm:ssZ”。  仅包周期场景返回。
        /// </summary>
        [JsonProperty("expiration_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("serverless_info", NullValueHandling = NullValueHandling.Ignore)]
        public ServerlessInfoResponse ServerlessInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  enableSsl: ").Append(EnableSsl).Append("\n");
            sb.Append("  privateIps: ").Append(PrivateIps).Append("\n");
            sb.Append("  privateDnsNames: ").Append(PrivateDnsNames).Append("\n");
            sb.Append("  publicDnsNames: ").Append(PublicDnsNames).Append("\n");
            sb.Append("  publicIps: ").Append(PublicIps).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  dbUserName: ").Append(DbUserName).Append("\n");
            sb.Append("  switchStrategy: ").Append(SwitchStrategy).Append("\n");
            sb.Append("  readOnlyByUser: ").Append(ReadOnlyByUser).Append("\n");
            sb.Append("  maintenanceWindow: ").Append(MaintenanceWindow).Append("\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("  relatedInstance: ").Append(RelatedInstance).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  datastore: ").Append(Datastore).Append("\n");
            sb.Append("  ha: ").Append(Ha).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  backupStrategy: ").Append(BackupStrategy).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  diskEncryptionId: ").Append(DiskEncryptionId).Append("\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  mem: ").Append(Mem).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  chargeInfo: ").Append(ChargeInfo).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  backupUsedSpace: ").Append(BackupUsedSpace).Append("\n");
            sb.Append("  storageUsedSpace: ").Append(StorageUsedSpace).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  associatedWithDdm: ").Append(AssociatedWithDdm).Append("\n");
            sb.Append("  alias: ").Append(Alias).Append("\n");
            sb.Append("  maxIops: ").Append(MaxIops).Append("\n");
            sb.Append("  expirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  serverlessInfo: ").Append(ServerlessInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.EnableSsl == input.EnableSsl ||
                    (this.EnableSsl != null &&
                    this.EnableSsl.Equals(input.EnableSsl))
                ) && 
                (
                    this.PrivateIps == input.PrivateIps ||
                    this.PrivateIps != null &&
                    input.PrivateIps != null &&
                    this.PrivateIps.SequenceEqual(input.PrivateIps)
                ) && 
                (
                    this.PrivateDnsNames == input.PrivateDnsNames ||
                    this.PrivateDnsNames != null &&
                    input.PrivateDnsNames != null &&
                    this.PrivateDnsNames.SequenceEqual(input.PrivateDnsNames)
                ) && 
                (
                    this.PublicDnsNames == input.PublicDnsNames ||
                    this.PublicDnsNames != null &&
                    input.PublicDnsNames != null &&
                    this.PublicDnsNames.SequenceEqual(input.PublicDnsNames)
                ) && 
                (
                    this.PublicIps == input.PublicIps ||
                    this.PublicIps != null &&
                    input.PublicIps != null &&
                    this.PublicIps.SequenceEqual(input.PublicIps)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.DbUserName == input.DbUserName ||
                    (this.DbUserName != null &&
                    this.DbUserName.Equals(input.DbUserName))
                ) && 
                (
                    this.SwitchStrategy == input.SwitchStrategy ||
                    (this.SwitchStrategy != null &&
                    this.SwitchStrategy.Equals(input.SwitchStrategy))
                ) && 
                (
                    this.ReadOnlyByUser == input.ReadOnlyByUser ||
                    (this.ReadOnlyByUser != null &&
                    this.ReadOnlyByUser.Equals(input.ReadOnlyByUser))
                ) && 
                (
                    this.MaintenanceWindow == input.MaintenanceWindow ||
                    (this.MaintenanceWindow != null &&
                    this.MaintenanceWindow.Equals(input.MaintenanceWindow))
                ) && 
                (
                    this.Nodes == input.Nodes ||
                    this.Nodes != null &&
                    input.Nodes != null &&
                    this.Nodes.SequenceEqual(input.Nodes)
                ) && 
                (
                    this.RelatedInstance == input.RelatedInstance ||
                    this.RelatedInstance != null &&
                    input.RelatedInstance != null &&
                    this.RelatedInstance.SequenceEqual(input.RelatedInstance)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Datastore == input.Datastore ||
                    (this.Datastore != null &&
                    this.Datastore.Equals(input.Datastore))
                ) && 
                (
                    this.Ha == input.Ha ||
                    (this.Ha != null &&
                    this.Ha.Equals(input.Ha))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.BackupStrategy == input.BackupStrategy ||
                    (this.BackupStrategy != null &&
                    this.BackupStrategy.Equals(input.BackupStrategy))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.DiskEncryptionId == input.DiskEncryptionId ||
                    (this.DiskEncryptionId != null &&
                    this.DiskEncryptionId.Equals(input.DiskEncryptionId))
                ) && 
                (
                    this.FlavorRef == input.FlavorRef ||
                    (this.FlavorRef != null &&
                    this.FlavorRef.Equals(input.FlavorRef))
                ) && 
                (
                    this.Cpu == input.Cpu ||
                    (this.Cpu != null &&
                    this.Cpu.Equals(input.Cpu))
                ) && 
                (
                    this.Mem == input.Mem ||
                    (this.Mem != null &&
                    this.Mem.Equals(input.Mem))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.SecurityGroupId == input.SecurityGroupId ||
                    (this.SecurityGroupId != null &&
                    this.SecurityGroupId.Equals(input.SecurityGroupId))
                ) && 
                (
                    this.ChargeInfo == input.ChargeInfo ||
                    (this.ChargeInfo != null &&
                    this.ChargeInfo.Equals(input.ChargeInfo))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.BackupUsedSpace == input.BackupUsedSpace ||
                    (this.BackupUsedSpace != null &&
                    this.BackupUsedSpace.Equals(input.BackupUsedSpace))
                ) && 
                (
                    this.StorageUsedSpace == input.StorageUsedSpace ||
                    (this.StorageUsedSpace != null &&
                    this.StorageUsedSpace.Equals(input.StorageUsedSpace))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.AssociatedWithDdm == input.AssociatedWithDdm ||
                    (this.AssociatedWithDdm != null &&
                    this.AssociatedWithDdm.Equals(input.AssociatedWithDdm))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.MaxIops == input.MaxIops ||
                    (this.MaxIops != null &&
                    this.MaxIops.Equals(input.MaxIops))
                ) && 
                (
                    this.ExpirationTime == input.ExpirationTime ||
                    (this.ExpirationTime != null &&
                    this.ExpirationTime.Equals(input.ExpirationTime))
                ) && 
                (
                    this.ServerlessInfo == input.ServerlessInfo ||
                    (this.ServerlessInfo != null &&
                    this.ServerlessInfo.Equals(input.ServerlessInfo))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.EnableSsl != null)
                    hashCode = hashCode * 59 + this.EnableSsl.GetHashCode();
                if (this.PrivateIps != null)
                    hashCode = hashCode * 59 + this.PrivateIps.GetHashCode();
                if (this.PrivateDnsNames != null)
                    hashCode = hashCode * 59 + this.PrivateDnsNames.GetHashCode();
                if (this.PublicDnsNames != null)
                    hashCode = hashCode * 59 + this.PublicDnsNames.GetHashCode();
                if (this.PublicIps != null)
                    hashCode = hashCode * 59 + this.PublicIps.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.DbUserName != null)
                    hashCode = hashCode * 59 + this.DbUserName.GetHashCode();
                if (this.SwitchStrategy != null)
                    hashCode = hashCode * 59 + this.SwitchStrategy.GetHashCode();
                if (this.ReadOnlyByUser != null)
                    hashCode = hashCode * 59 + this.ReadOnlyByUser.GetHashCode();
                if (this.MaintenanceWindow != null)
                    hashCode = hashCode * 59 + this.MaintenanceWindow.GetHashCode();
                if (this.Nodes != null)
                    hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.RelatedInstance != null)
                    hashCode = hashCode * 59 + this.RelatedInstance.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Datastore != null)
                    hashCode = hashCode * 59 + this.Datastore.GetHashCode();
                if (this.Ha != null)
                    hashCode = hashCode * 59 + this.Ha.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.BackupStrategy != null)
                    hashCode = hashCode * 59 + this.BackupStrategy.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.DiskEncryptionId != null)
                    hashCode = hashCode * 59 + this.DiskEncryptionId.GetHashCode();
                if (this.FlavorRef != null)
                    hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.Cpu != null)
                    hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Mem != null)
                    hashCode = hashCode * 59 + this.Mem.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.ChargeInfo != null)
                    hashCode = hashCode * 59 + this.ChargeInfo.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.BackupUsedSpace != null)
                    hashCode = hashCode * 59 + this.BackupUsedSpace.GetHashCode();
                if (this.StorageUsedSpace != null)
                    hashCode = hashCode * 59 + this.StorageUsedSpace.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.AssociatedWithDdm != null)
                    hashCode = hashCode * 59 + this.AssociatedWithDdm.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.MaxIops != null)
                    hashCode = hashCode * 59 + this.MaxIops.GetHashCode();
                if (this.ExpirationTime != null)
                    hashCode = hashCode * 59 + this.ExpirationTime.GetHashCode();
                if (this.ServerlessInfo != null)
                    hashCode = hashCode * 59 + this.ServerlessInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
