using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InstanceDetail 
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
        /// 实例别名。
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string Alias { get; set; }

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 集群模式。
        /// </summary>
        [JsonProperty("cluster_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// 状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// bpdomain_id
        /// </summary>
        [JsonProperty("bpdomain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BpdomainId { get; set; }

        /// <summary>
        /// 账户ID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 数据库版本。
        /// </summary>
        [JsonProperty("datastore_version", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreVersion { get; set; }

        /// <summary>
        /// 数据库类型。
        /// </summary>
        [JsonProperty("datastore_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreType { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateAt { get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateAt { get; set; }

        /// <summary>
        /// 删除时间。
        /// </summary>
        [JsonProperty("delete_at", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteAt { get; set; }

        /// <summary>
        /// 是否有版本可升级。
        /// </summary>
        [JsonProperty("new_version_available", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewVersionAvailable { get; set; }

        /// <summary>
        /// 是否有版本可回滚。
        /// </summary>
        [JsonProperty("rollback_version_available", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RollbackVersionAvailable { get; set; }

        /// <summary>
        /// 是否有版本可降级。
        /// </summary>
        [JsonProperty("degrade_version_available", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DegradeVersionAvailable { get; set; }

        /// <summary>
        /// 公共ip。
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 端口。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// 创建失败原因编码。
        /// </summary>
        [JsonProperty("create_fail_error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateFailErrorCode { get; set; }

        /// <summary>
        /// 时区。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 付费模式。
        /// </summary>
        [JsonProperty("pay_model", NullValueHandling = NullValueHandling.Ignore)]
        public string PayModel { get; set; }

        /// <summary>
        /// 订单ID。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 周期。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

        /// <summary>
        /// 是否冻结。
        /// </summary>
        [JsonProperty("is_frozen", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFrozen { get; set; }

        /// <summary>
        /// 冻结时间。
        /// </summary>
        [JsonProperty("frozen_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FrozenTime { get; set; }

        /// <summary>
        /// 锁状态。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ActionInfo> Actions { get; set; }

        /// <summary>
        /// 是否只有默认组。
        /// </summary>
        [JsonProperty("only_default_group", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyDefaultGroup { get; set; }

        /// <summary>
        /// 组信息。
        /// </summary>
        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<DdmGroupInfo> Groups { get; set; }

        /// <summary>
        /// 其他信息。
        /// </summary>
        [JsonProperty("extend_map", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ExtendMap { get; set; }

        /// <summary>
        /// 标签信息。
        /// </summary>
        [JsonProperty("tags_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagsInfo> TagsInfo { get; set; }

        /// <summary>
        /// 管理员账号。
        /// </summary>
        [JsonProperty("admin_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminUserName { get; set; }

        /// <summary>
        /// 绑定eip信息。
        /// </summary>
        [JsonProperty("eip_binding_info", NullValueHandling = NullValueHandling.Ignore)]
        public Object EipBindingInfo { get; set; }

        /// <summary>
        /// 是否支持ssl。
        /// </summary>
        [JsonProperty("enable_ssl", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnableSsl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceDetail {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  alias: ").Append(Alias).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  clusterMode: ").Append(ClusterMode).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  bpdomainId: ").Append(BpdomainId).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  datastoreVersion: ").Append(DatastoreVersion).Append("\n");
            sb.Append("  datastoreType: ").Append(DatastoreType).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  deleteAt: ").Append(DeleteAt).Append("\n");
            sb.Append("  newVersionAvailable: ").Append(NewVersionAvailable).Append("\n");
            sb.Append("  rollbackVersionAvailable: ").Append(RollbackVersionAvailable).Append("\n");
            sb.Append("  degradeVersionAvailable: ").Append(DegradeVersionAvailable).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  createFailErrorCode: ").Append(CreateFailErrorCode).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  payModel: ").Append(PayModel).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  isFrozen: ").Append(IsFrozen).Append("\n");
            sb.Append("  frozenTime: ").Append(FrozenTime).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("  onlyDefaultGroup: ").Append(OnlyDefaultGroup).Append("\n");
            sb.Append("  groups: ").Append(Groups).Append("\n");
            sb.Append("  extendMap: ").Append(ExtendMap).Append("\n");
            sb.Append("  tagsInfo: ").Append(TagsInfo).Append("\n");
            sb.Append("  adminUserName: ").Append(AdminUserName).Append("\n");
            sb.Append("  eipBindingInfo: ").Append(EipBindingInfo).Append("\n");
            sb.Append("  enableSsl: ").Append(EnableSsl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceDetail input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Alias != input.Alias || (this.Alias != null && !this.Alias.Equals(input.Alias))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ClusterMode != input.ClusterMode || (this.ClusterMode != null && !this.ClusterMode.Equals(input.ClusterMode))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.BpdomainId != input.BpdomainId || (this.BpdomainId != null && !this.BpdomainId.Equals(input.BpdomainId))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.DatastoreVersion != input.DatastoreVersion || (this.DatastoreVersion != null && !this.DatastoreVersion.Equals(input.DatastoreVersion))) return false;
            if (this.DatastoreType != input.DatastoreType || (this.DatastoreType != null && !this.DatastoreType.Equals(input.DatastoreType))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.DeleteAt != input.DeleteAt || (this.DeleteAt != null && !this.DeleteAt.Equals(input.DeleteAt))) return false;
            if (this.NewVersionAvailable != input.NewVersionAvailable || (this.NewVersionAvailable != null && !this.NewVersionAvailable.Equals(input.NewVersionAvailable))) return false;
            if (this.RollbackVersionAvailable != input.RollbackVersionAvailable || (this.RollbackVersionAvailable != null && !this.RollbackVersionAvailable.Equals(input.RollbackVersionAvailable))) return false;
            if (this.DegradeVersionAvailable != input.DegradeVersionAvailable || (this.DegradeVersionAvailable != null && !this.DegradeVersionAvailable.Equals(input.DegradeVersionAvailable))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.CreateFailErrorCode != input.CreateFailErrorCode || (this.CreateFailErrorCode != null && !this.CreateFailErrorCode.Equals(input.CreateFailErrorCode))) return false;
            if (this.TimeZone != input.TimeZone || (this.TimeZone != null && !this.TimeZone.Equals(input.TimeZone))) return false;
            if (this.PayModel != input.PayModel || (this.PayModel != null && !this.PayModel.Equals(input.PayModel))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.IsFrozen != input.IsFrozen || (this.IsFrozen != null && !this.IsFrozen.Equals(input.IsFrozen))) return false;
            if (this.FrozenTime != input.FrozenTime || (this.FrozenTime != null && !this.FrozenTime.Equals(input.FrozenTime))) return false;
            if (this.Actions != input.Actions || (this.Actions != null && input.Actions != null && !this.Actions.SequenceEqual(input.Actions))) return false;
            if (this.OnlyDefaultGroup != input.OnlyDefaultGroup || (this.OnlyDefaultGroup != null && !this.OnlyDefaultGroup.Equals(input.OnlyDefaultGroup))) return false;
            if (this.Groups != input.Groups || (this.Groups != null && input.Groups != null && !this.Groups.SequenceEqual(input.Groups))) return false;
            if (this.ExtendMap != input.ExtendMap || (this.ExtendMap != null && input.ExtendMap != null && !this.ExtendMap.SequenceEqual(input.ExtendMap))) return false;
            if (this.TagsInfo != input.TagsInfo || (this.TagsInfo != null && input.TagsInfo != null && !this.TagsInfo.SequenceEqual(input.TagsInfo))) return false;
            if (this.AdminUserName != input.AdminUserName || (this.AdminUserName != null && !this.AdminUserName.Equals(input.AdminUserName))) return false;
            if (this.EipBindingInfo != input.EipBindingInfo || (this.EipBindingInfo != null && !this.EipBindingInfo.Equals(input.EipBindingInfo))) return false;
            if (this.EnableSsl != input.EnableSsl || (this.EnableSsl != null && !this.EnableSsl.Equals(input.EnableSsl))) return false;

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
                if (this.Alias != null) hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ClusterMode != null) hashCode = hashCode * 59 + this.ClusterMode.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.BpdomainId != null) hashCode = hashCode * 59 + this.BpdomainId.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.DatastoreVersion != null) hashCode = hashCode * 59 + this.DatastoreVersion.GetHashCode();
                if (this.DatastoreType != null) hashCode = hashCode * 59 + this.DatastoreType.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.DeleteAt != null) hashCode = hashCode * 59 + this.DeleteAt.GetHashCode();
                if (this.NewVersionAvailable != null) hashCode = hashCode * 59 + this.NewVersionAvailable.GetHashCode();
                if (this.RollbackVersionAvailable != null) hashCode = hashCode * 59 + this.RollbackVersionAvailable.GetHashCode();
                if (this.DegradeVersionAvailable != null) hashCode = hashCode * 59 + this.DegradeVersionAvailable.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.CreateFailErrorCode != null) hashCode = hashCode * 59 + this.CreateFailErrorCode.GetHashCode();
                if (this.TimeZone != null) hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.PayModel != null) hashCode = hashCode * 59 + this.PayModel.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.IsFrozen != null) hashCode = hashCode * 59 + this.IsFrozen.GetHashCode();
                if (this.FrozenTime != null) hashCode = hashCode * 59 + this.FrozenTime.GetHashCode();
                if (this.Actions != null) hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.OnlyDefaultGroup != null) hashCode = hashCode * 59 + this.OnlyDefaultGroup.GetHashCode();
                if (this.Groups != null) hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.ExtendMap != null) hashCode = hashCode * 59 + this.ExtendMap.GetHashCode();
                if (this.TagsInfo != null) hashCode = hashCode * 59 + this.TagsInfo.GetHashCode();
                if (this.AdminUserName != null) hashCode = hashCode * 59 + this.AdminUserName.GetHashCode();
                if (this.EipBindingInfo != null) hashCode = hashCode * 59 + this.EipBindingInfo.GetHashCode();
                if (this.EnableSsl != null) hashCode = hashCode * 59 + this.EnableSsl.GetHashCode();
                return hashCode;
            }
        }
    }
}
