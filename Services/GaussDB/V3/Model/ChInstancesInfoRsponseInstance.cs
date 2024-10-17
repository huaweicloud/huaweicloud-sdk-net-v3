using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 实例信息。
    /// </summary>
    public class ChInstancesInfoRsponseInstance 
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
        /// 租户在某一Region下的project ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 公网访问IP。
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 是否可公网访问。
        /// </summary>
        [JsonProperty("can_enable_public_access", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanEnablePublicAccess { get; set; }

        /// <summary>
        /// 备份节点ID。
        /// </summary>
        [JsonProperty("current_backup_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentBackupNodeId { get; set; }

        /// <summary>
        /// 部署模式。 取值范围： - Single：单机 - Ha：主备
        /// </summary>
        [JsonProperty("cluster_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// 实例状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 是否冻结。 取值范围： - 0：不冻结 - 1：冻结
        /// </summary>
        [JsonProperty("is_frozen", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsFrozen { get; set; }

        /// <summary>
        /// 冻结时间。
        /// </summary>
        [JsonProperty("frozen_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FrozenTime { get; set; }

        /// <summary>
        /// 默认用户。
        /// </summary>
        [JsonProperty("db_user", NullValueHandling = NullValueHandling.Ignore)]
        public string DbUser { get; set; }

        /// <summary>
        /// 备份周期。
        /// </summary>
        [JsonProperty("bak_period", NullValueHandling = NullValueHandling.Ignore)]
        public string BakPeriod { get; set; }

        /// <summary>
        /// 备份保存天数。
        /// </summary>
        [JsonProperty("bak_keep_day", NullValueHandling = NullValueHandling.Ignore)]
        public int? BakKeepDay { get; set; }

        /// <summary>
        /// 备份预计开始时间。
        /// </summary>
        [JsonProperty("bak_expected_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BakExpectedStartTime { get; set; }

        /// <summary>
        /// 数据库版本ID。
        /// </summary>
        [JsonProperty("datastore_version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreVersionId { get; set; }

        /// <summary>
        /// 数据库版本。
        /// </summary>
        [JsonProperty("datastore_version", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreVersion { get; set; }

        /// <summary>
        /// 数据库引擎。
        /// </summary>
        [JsonProperty("datastore_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreType { get; set; }

        /// <summary>
        /// 实例创建时间。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateAt { get; set; }

        /// <summary>
        /// 实例更新时间。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateAt { get; set; }

        /// <summary>
        /// 实例删除时间。
        /// </summary>
        [JsonProperty("delete_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? DeleteAt { get; set; }

        /// <summary>
        /// 数据库端口号。取值范围0~65535。
        /// </summary>
        [JsonProperty("db_port", NullValueHandling = NullValueHandling.Ignore)]
        public string DbPort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("param_group", NullValueHandling = NullValueHandling.Ignore)]
        public ChInstancesInfoRsponseInstanceParamGroup ParamGroup { get; set; }

        /// <summary>
        /// 实例动作。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChQueryActionInfo> Actions { get; set; }

        /// <summary>
        /// 实例创建失败错误码。
        /// </summary>
        [JsonProperty("create_fail_error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateFailErrorCode { get; set; }

        /// <summary>
        /// 实例分组。
        /// </summary>
        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChInstancesInfoRsponseInstanceGroups> Groups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ops_window", NullValueHandling = NullValueHandling.Ignore)]
        public ChInstancesInfoRsponseInstanceOpsWindow OpsWindow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tags_info", NullValueHandling = NullValueHandling.Ignore)]
        public CreateChInstanceInfoTagsInfo TagsInfo { get; set; }

        /// <summary>
        /// 时区。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 备份使用空间。
        /// </summary>
        [JsonProperty("backup_used_space", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupUsedSpace { get; set; }

        /// <summary>
        /// 可用区模式。 取值范围： - single：单可用区 - double：多可用区-
        /// </summary>
        [JsonProperty("az_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AzMode { get; set; }

        /// <summary>
        /// 主可用区。
        /// </summary>
        [JsonProperty("master_az_code", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterAzCode { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("port_info", NullValueHandling = NullValueHandling.Ignore)]
        public ChInstancesInfoRsponseInstancePortInfo PortInfo { get; set; }

        /// <summary>
        /// 磁盘规格码。
        /// </summary>
        [JsonProperty("volume_code", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeCode { get; set; }

        /// <summary>
        /// 是否支持副本。
        /// </summary>
        [JsonProperty("support_data_replication", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportDataReplication { get; set; }

        /// <summary>
        /// 是否有数据库新版本。
        /// </summary>
        [JsonProperty("new_version_available", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewVersionAvailable { get; set; }

        /// <summary>
        /// SSL开关。
        /// </summary>
        [JsonProperty("ssl_option", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslOption { get; set; }

        /// <summary>
        /// 专属资源池ID。
        /// </summary>
        [JsonProperty("dedicated_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedResourceId { get; set; }

        /// <summary>
        /// 支付模式。 取值范围： - 0：按需计费 - 1：包周期-
        /// </summary>
        [JsonProperty("pay_model", NullValueHandling = NullValueHandling.Ignore)]
        public string PayModel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChInstancesInfoRsponseInstance {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  canEnablePublicAccess: ").Append(CanEnablePublicAccess).Append("\n");
            sb.Append("  currentBackupNodeId: ").Append(CurrentBackupNodeId).Append("\n");
            sb.Append("  clusterMode: ").Append(ClusterMode).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  isFrozen: ").Append(IsFrozen).Append("\n");
            sb.Append("  frozenTime: ").Append(FrozenTime).Append("\n");
            sb.Append("  dbUser: ").Append(DbUser).Append("\n");
            sb.Append("  bakPeriod: ").Append(BakPeriod).Append("\n");
            sb.Append("  bakKeepDay: ").Append(BakKeepDay).Append("\n");
            sb.Append("  bakExpectedStartTime: ").Append(BakExpectedStartTime).Append("\n");
            sb.Append("  datastoreVersionId: ").Append(DatastoreVersionId).Append("\n");
            sb.Append("  datastoreVersion: ").Append(DatastoreVersion).Append("\n");
            sb.Append("  datastoreType: ").Append(DatastoreType).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  deleteAt: ").Append(DeleteAt).Append("\n");
            sb.Append("  dbPort: ").Append(DbPort).Append("\n");
            sb.Append("  paramGroup: ").Append(ParamGroup).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("  createFailErrorCode: ").Append(CreateFailErrorCode).Append("\n");
            sb.Append("  groups: ").Append(Groups).Append("\n");
            sb.Append("  opsWindow: ").Append(OpsWindow).Append("\n");
            sb.Append("  tagsInfo: ").Append(TagsInfo).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  backupUsedSpace: ").Append(BackupUsedSpace).Append("\n");
            sb.Append("  azMode: ").Append(AzMode).Append("\n");
            sb.Append("  masterAzCode: ").Append(MasterAzCode).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  portInfo: ").Append(PortInfo).Append("\n");
            sb.Append("  volumeCode: ").Append(VolumeCode).Append("\n");
            sb.Append("  supportDataReplication: ").Append(SupportDataReplication).Append("\n");
            sb.Append("  newVersionAvailable: ").Append(NewVersionAvailable).Append("\n");
            sb.Append("  sslOption: ").Append(SslOption).Append("\n");
            sb.Append("  dedicatedResourceId: ").Append(DedicatedResourceId).Append("\n");
            sb.Append("  payModel: ").Append(PayModel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChInstancesInfoRsponseInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChInstancesInfoRsponseInstance input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.CanEnablePublicAccess != input.CanEnablePublicAccess || (this.CanEnablePublicAccess != null && !this.CanEnablePublicAccess.Equals(input.CanEnablePublicAccess))) return false;
            if (this.CurrentBackupNodeId != input.CurrentBackupNodeId || (this.CurrentBackupNodeId != null && !this.CurrentBackupNodeId.Equals(input.CurrentBackupNodeId))) return false;
            if (this.ClusterMode != input.ClusterMode || (this.ClusterMode != null && !this.ClusterMode.Equals(input.ClusterMode))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.IsFrozen != input.IsFrozen || (this.IsFrozen != null && !this.IsFrozen.Equals(input.IsFrozen))) return false;
            if (this.FrozenTime != input.FrozenTime || (this.FrozenTime != null && !this.FrozenTime.Equals(input.FrozenTime))) return false;
            if (this.DbUser != input.DbUser || (this.DbUser != null && !this.DbUser.Equals(input.DbUser))) return false;
            if (this.BakPeriod != input.BakPeriod || (this.BakPeriod != null && !this.BakPeriod.Equals(input.BakPeriod))) return false;
            if (this.BakKeepDay != input.BakKeepDay || (this.BakKeepDay != null && !this.BakKeepDay.Equals(input.BakKeepDay))) return false;
            if (this.BakExpectedStartTime != input.BakExpectedStartTime || (this.BakExpectedStartTime != null && !this.BakExpectedStartTime.Equals(input.BakExpectedStartTime))) return false;
            if (this.DatastoreVersionId != input.DatastoreVersionId || (this.DatastoreVersionId != null && !this.DatastoreVersionId.Equals(input.DatastoreVersionId))) return false;
            if (this.DatastoreVersion != input.DatastoreVersion || (this.DatastoreVersion != null && !this.DatastoreVersion.Equals(input.DatastoreVersion))) return false;
            if (this.DatastoreType != input.DatastoreType || (this.DatastoreType != null && !this.DatastoreType.Equals(input.DatastoreType))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.DeleteAt != input.DeleteAt || (this.DeleteAt != null && !this.DeleteAt.Equals(input.DeleteAt))) return false;
            if (this.DbPort != input.DbPort || (this.DbPort != null && !this.DbPort.Equals(input.DbPort))) return false;
            if (this.ParamGroup != input.ParamGroup || (this.ParamGroup != null && !this.ParamGroup.Equals(input.ParamGroup))) return false;
            if (this.Actions != input.Actions || (this.Actions != null && input.Actions != null && !this.Actions.SequenceEqual(input.Actions))) return false;
            if (this.CreateFailErrorCode != input.CreateFailErrorCode || (this.CreateFailErrorCode != null && !this.CreateFailErrorCode.Equals(input.CreateFailErrorCode))) return false;
            if (this.Groups != input.Groups || (this.Groups != null && input.Groups != null && !this.Groups.SequenceEqual(input.Groups))) return false;
            if (this.OpsWindow != input.OpsWindow || (this.OpsWindow != null && !this.OpsWindow.Equals(input.OpsWindow))) return false;
            if (this.TagsInfo != input.TagsInfo || (this.TagsInfo != null && !this.TagsInfo.Equals(input.TagsInfo))) return false;
            if (this.TimeZone != input.TimeZone || (this.TimeZone != null && !this.TimeZone.Equals(input.TimeZone))) return false;
            if (this.BackupUsedSpace != input.BackupUsedSpace || (this.BackupUsedSpace != null && !this.BackupUsedSpace.Equals(input.BackupUsedSpace))) return false;
            if (this.AzMode != input.AzMode || (this.AzMode != null && !this.AzMode.Equals(input.AzMode))) return false;
            if (this.MasterAzCode != input.MasterAzCode || (this.MasterAzCode != null && !this.MasterAzCode.Equals(input.MasterAzCode))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.PortInfo != input.PortInfo || (this.PortInfo != null && !this.PortInfo.Equals(input.PortInfo))) return false;
            if (this.VolumeCode != input.VolumeCode || (this.VolumeCode != null && !this.VolumeCode.Equals(input.VolumeCode))) return false;
            if (this.SupportDataReplication != input.SupportDataReplication || (this.SupportDataReplication != null && !this.SupportDataReplication.Equals(input.SupportDataReplication))) return false;
            if (this.NewVersionAvailable != input.NewVersionAvailable || (this.NewVersionAvailable != null && !this.NewVersionAvailable.Equals(input.NewVersionAvailable))) return false;
            if (this.SslOption != input.SslOption || (this.SslOption != null && !this.SslOption.Equals(input.SslOption))) return false;
            if (this.DedicatedResourceId != input.DedicatedResourceId || (this.DedicatedResourceId != null && !this.DedicatedResourceId.Equals(input.DedicatedResourceId))) return false;
            if (this.PayModel != input.PayModel || (this.PayModel != null && !this.PayModel.Equals(input.PayModel))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.CanEnablePublicAccess != null) hashCode = hashCode * 59 + this.CanEnablePublicAccess.GetHashCode();
                if (this.CurrentBackupNodeId != null) hashCode = hashCode * 59 + this.CurrentBackupNodeId.GetHashCode();
                if (this.ClusterMode != null) hashCode = hashCode * 59 + this.ClusterMode.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IsFrozen != null) hashCode = hashCode * 59 + this.IsFrozen.GetHashCode();
                if (this.FrozenTime != null) hashCode = hashCode * 59 + this.FrozenTime.GetHashCode();
                if (this.DbUser != null) hashCode = hashCode * 59 + this.DbUser.GetHashCode();
                if (this.BakPeriod != null) hashCode = hashCode * 59 + this.BakPeriod.GetHashCode();
                if (this.BakKeepDay != null) hashCode = hashCode * 59 + this.BakKeepDay.GetHashCode();
                if (this.BakExpectedStartTime != null) hashCode = hashCode * 59 + this.BakExpectedStartTime.GetHashCode();
                if (this.DatastoreVersionId != null) hashCode = hashCode * 59 + this.DatastoreVersionId.GetHashCode();
                if (this.DatastoreVersion != null) hashCode = hashCode * 59 + this.DatastoreVersion.GetHashCode();
                if (this.DatastoreType != null) hashCode = hashCode * 59 + this.DatastoreType.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.DeleteAt != null) hashCode = hashCode * 59 + this.DeleteAt.GetHashCode();
                if (this.DbPort != null) hashCode = hashCode * 59 + this.DbPort.GetHashCode();
                if (this.ParamGroup != null) hashCode = hashCode * 59 + this.ParamGroup.GetHashCode();
                if (this.Actions != null) hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.CreateFailErrorCode != null) hashCode = hashCode * 59 + this.CreateFailErrorCode.GetHashCode();
                if (this.Groups != null) hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.OpsWindow != null) hashCode = hashCode * 59 + this.OpsWindow.GetHashCode();
                if (this.TagsInfo != null) hashCode = hashCode * 59 + this.TagsInfo.GetHashCode();
                if (this.TimeZone != null) hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.BackupUsedSpace != null) hashCode = hashCode * 59 + this.BackupUsedSpace.GetHashCode();
                if (this.AzMode != null) hashCode = hashCode * 59 + this.AzMode.GetHashCode();
                if (this.MasterAzCode != null) hashCode = hashCode * 59 + this.MasterAzCode.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.PortInfo != null) hashCode = hashCode * 59 + this.PortInfo.GetHashCode();
                if (this.VolumeCode != null) hashCode = hashCode * 59 + this.VolumeCode.GetHashCode();
                if (this.SupportDataReplication != null) hashCode = hashCode * 59 + this.SupportDataReplication.GetHashCode();
                if (this.NewVersionAvailable != null) hashCode = hashCode * 59 + this.NewVersionAvailable.GetHashCode();
                if (this.SslOption != null) hashCode = hashCode * 59 + this.SslOption.GetHashCode();
                if (this.DedicatedResourceId != null) hashCode = hashCode * 59 + this.DedicatedResourceId.GetHashCode();
                if (this.PayModel != null) hashCode = hashCode * 59 + this.PayModel.GetHashCode();
                return hashCode;
            }
        }
    }
}
