using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 实例信息。
    /// </summary>
    public class QueryInstanceResponse 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 实例状态。 取值： - normal，表示实例正常。 - abnormal，表示实例异常。 - creating，表示实例创建中。 - frozen，表示实例被冻结。 - data_disk_full，表示实例磁盘已满。 - createfail，表示实例创建失败。 - enlargefail，表示实例扩容节点个数失败。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 数据库端口号。文档数据库实例支持的端口号范围为2100～9500。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 实例类型。与请求参数相同。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// 实例所在区域。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datastore", NullValueHandling = NullValueHandling.Ignore)]
        public DatastoreItem Datastore { get; set; }

        /// <summary>
        /// 存储引擎。取值为“wiredTiger”。
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public string Engine { get; set; }

        /// <summary>
        /// 实例创建时间。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 实例操作最新变更的时间。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 默认用户名。取值为“rwuser”。
        /// </summary>
        [JsonProperty("db_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbUserName { get; set; }

        /// <summary>
        /// 是否开启SSL安全连接。 - 取值为“1”，表示开启。 - 取值为“0”，表示不开启。
        /// </summary>
        [JsonProperty("ssl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ssl { get; set; }

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
        [JsonProperty("backup_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public BackupStrategyForItemResponse BackupStrategy { get; set; }

        /// <summary>
        /// 计费方式。 - 取值为“0”，表示按需计费。 - 取值为“1”，表示包年/包月计费。
        /// </summary>
        [JsonProperty("pay_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string PayMode { get; set; }

        /// <summary>
        /// 系统可维护时间窗。
        /// </summary>
        [JsonProperty("maintenance_window", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintenanceWindow { get; set; }

        /// <summary>
        /// 组信息。
        /// </summary>
        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<GroupResponseItem> Groups { get; set; }

        /// <summary>
        /// 磁盘加密的密钥ID。
        /// </summary>
        [JsonProperty("disk_encryption_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskEncryptionId { get; set; }

        /// <summary>
        /// 企业项目ID。取值为“0”，表示为default企业项目。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 时区。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 专属存储池ID。
        /// </summary>
        [JsonProperty("dss_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DssPoolId { get; set; }

        /// <summary>
        /// 实例正在执行的动作。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Actions { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryInstanceResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  datastore: ").Append(Datastore).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  dbUserName: ").Append(DbUserName).Append("\n");
            sb.Append("  ssl: ").Append(Ssl).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  backupStrategy: ").Append(BackupStrategy).Append("\n");
            sb.Append("  payMode: ").Append(PayMode).Append("\n");
            sb.Append("  maintenanceWindow: ").Append(MaintenanceWindow).Append("\n");
            sb.Append("  groups: ").Append(Groups).Append("\n");
            sb.Append("  diskEncryptionId: ").Append(DiskEncryptionId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  dssPoolId: ").Append(DssPoolId).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryInstanceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryInstanceResponse input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.Datastore == input.Datastore ||
                    (this.Datastore != null &&
                    this.Datastore.Equals(input.Datastore))
                ) && 
                (
                    this.Engine == input.Engine ||
                    (this.Engine != null &&
                    this.Engine.Equals(input.Engine))
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
                    this.Ssl == input.Ssl ||
                    (this.Ssl != null &&
                    this.Ssl.Equals(input.Ssl))
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
                    this.BackupStrategy == input.BackupStrategy ||
                    (this.BackupStrategy != null &&
                    this.BackupStrategy.Equals(input.BackupStrategy))
                ) && 
                (
                    this.PayMode == input.PayMode ||
                    (this.PayMode != null &&
                    this.PayMode.Equals(input.PayMode))
                ) && 
                (
                    this.MaintenanceWindow == input.MaintenanceWindow ||
                    (this.MaintenanceWindow != null &&
                    this.MaintenanceWindow.Equals(input.MaintenanceWindow))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.DiskEncryptionId == input.DiskEncryptionId ||
                    (this.DiskEncryptionId != null &&
                    this.DiskEncryptionId.Equals(input.DiskEncryptionId))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.DssPoolId == input.DssPoolId ||
                    (this.DssPoolId != null &&
                    this.DssPoolId.Equals(input.DssPoolId))
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Datastore != null)
                    hashCode = hashCode * 59 + this.Datastore.GetHashCode();
                if (this.Engine != null)
                    hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.DbUserName != null)
                    hashCode = hashCode * 59 + this.DbUserName.GetHashCode();
                if (this.Ssl != null)
                    hashCode = hashCode * 59 + this.Ssl.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.BackupStrategy != null)
                    hashCode = hashCode * 59 + this.BackupStrategy.GetHashCode();
                if (this.PayMode != null)
                    hashCode = hashCode * 59 + this.PayMode.GetHashCode();
                if (this.MaintenanceWindow != null)
                    hashCode = hashCode * 59 + this.MaintenanceWindow.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.DiskEncryptionId != null)
                    hashCode = hashCode * 59 + this.DiskEncryptionId.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.DssPoolId != null)
                    hashCode = hashCode * 59 + this.DssPoolId.GetHashCode();
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                return hashCode;
            }
        }
    }
}
