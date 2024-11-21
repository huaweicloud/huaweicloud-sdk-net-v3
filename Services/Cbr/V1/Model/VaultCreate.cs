using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VaultCreate 
    {

        /// <summary>
        /// 备份策略ID，不设置时为null，不自动备份。
        /// </summary>
        [JsonProperty("backup_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupPolicyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing", NullValueHandling = NullValueHandling.Ignore)]
        public BillingCreate Billing { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 存储库名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 绑定的备份资源，未在创建时绑定资源填[]
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceCreate> Resources { get; set; }

        /// <summary>
        /// 标签列表 tags不允许为空列表。 tags中最多包含10个key。 tags中key不允许重复。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 企业项目ID，默认为‘0’。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 是否支持自动挂载。
        /// </summary>
        [JsonProperty("auto_bind", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoBind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bind_rules", NullValueHandling = NullValueHandling.Ignore)]
        public VaultBindRules BindRules { get; set; }

        /// <summary>
        /// [是否开启存储库自动扩容能力（只支持按需存储库）。](tag:hws,hws_hk) [是否开启存储库自动扩容能力。](tag:dt,ocb,tlf,sbc,fcs_vm,ctc,g42,tm,cmcc,hcso_dt)
        /// </summary>
        [JsonProperty("auto_expand", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoExpand { get; set; }

        /// <summary>
        /// 存储库容量阈值，已用容量占总容量达到此百分比，将根据 smn_notify 参数设置选择是否发送相关通知。 默认值为：80 最大值：100 最小值：1
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? Threshold { get; set; }

        /// <summary>
        /// 存储库smn消息通知开关。 默认值为 true。
        /// </summary>
        [JsonProperty("smn_notify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SmnNotify { get; set; }

        /// <summary>
        /// 备份名称前缀，设置后该存储库自动备份产生的备份副本都将携带该备份名称前缀
        /// </summary>
        [JsonProperty("backup_name_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupNamePrefix { get; set; }

        /// <summary>
        /// 存储库使用是否允许超出容量，只有创建包周期存储库时才允许该值为 true
        /// </summary>
        [JsonProperty("demand_billing", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DemandBilling { get; set; }

        /// <summary>
        /// 用于标识SMB服务，您可以设置为SMB或者空
        /// </summary>
        [JsonProperty("sys_lock_source_service", NullValueHandling = NullValueHandling.Ignore)]
        public string SysLockSourceService { get; set; }

        /// <summary>
        /// 用于标识该存储库是否已锁定
        /// </summary>
        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Locked { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VaultCreate {\n");
            sb.Append("  backupPolicyId: ").Append(BackupPolicyId).Append("\n");
            sb.Append("  billing: ").Append(Billing).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  autoBind: ").Append(AutoBind).Append("\n");
            sb.Append("  bindRules: ").Append(BindRules).Append("\n");
            sb.Append("  autoExpand: ").Append(AutoExpand).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("  smnNotify: ").Append(SmnNotify).Append("\n");
            sb.Append("  backupNamePrefix: ").Append(BackupNamePrefix).Append("\n");
            sb.Append("  demandBilling: ").Append(DemandBilling).Append("\n");
            sb.Append("  sysLockSourceService: ").Append(SysLockSourceService).Append("\n");
            sb.Append("  locked: ").Append(Locked).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VaultCreate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VaultCreate input)
        {
            if (input == null) return false;
            if (this.BackupPolicyId != input.BackupPolicyId || (this.BackupPolicyId != null && !this.BackupPolicyId.Equals(input.BackupPolicyId))) return false;
            if (this.Billing != input.Billing || (this.Billing != null && !this.Billing.Equals(input.Billing))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.AutoBind != input.AutoBind || (this.AutoBind != null && !this.AutoBind.Equals(input.AutoBind))) return false;
            if (this.BindRules != input.BindRules || (this.BindRules != null && !this.BindRules.Equals(input.BindRules))) return false;
            if (this.AutoExpand != input.AutoExpand || (this.AutoExpand != null && !this.AutoExpand.Equals(input.AutoExpand))) return false;
            if (this.Threshold != input.Threshold || (this.Threshold != null && !this.Threshold.Equals(input.Threshold))) return false;
            if (this.SmnNotify != input.SmnNotify || (this.SmnNotify != null && !this.SmnNotify.Equals(input.SmnNotify))) return false;
            if (this.BackupNamePrefix != input.BackupNamePrefix || (this.BackupNamePrefix != null && !this.BackupNamePrefix.Equals(input.BackupNamePrefix))) return false;
            if (this.DemandBilling != input.DemandBilling || (this.DemandBilling != null && !this.DemandBilling.Equals(input.DemandBilling))) return false;
            if (this.SysLockSourceService != input.SysLockSourceService || (this.SysLockSourceService != null && !this.SysLockSourceService.Equals(input.SysLockSourceService))) return false;
            if (this.Locked != input.Locked || (this.Locked != null && !this.Locked.Equals(input.Locked))) return false;

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
                if (this.BackupPolicyId != null) hashCode = hashCode * 59 + this.BackupPolicyId.GetHashCode();
                if (this.Billing != null) hashCode = hashCode * 59 + this.Billing.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.AutoBind != null) hashCode = hashCode * 59 + this.AutoBind.GetHashCode();
                if (this.BindRules != null) hashCode = hashCode * 59 + this.BindRules.GetHashCode();
                if (this.AutoExpand != null) hashCode = hashCode * 59 + this.AutoExpand.GetHashCode();
                if (this.Threshold != null) hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.SmnNotify != null) hashCode = hashCode * 59 + this.SmnNotify.GetHashCode();
                if (this.BackupNamePrefix != null) hashCode = hashCode * 59 + this.BackupNamePrefix.GetHashCode();
                if (this.DemandBilling != null) hashCode = hashCode * 59 + this.DemandBilling.GetHashCode();
                if (this.SysLockSourceService != null) hashCode = hashCode * 59 + this.SysLockSourceService.GetHashCode();
                if (this.Locked != null) hashCode = hashCode * 59 + this.Locked.GetHashCode();
                return hashCode;
            }
        }
    }
}
