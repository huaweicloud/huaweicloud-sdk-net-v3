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
    /// 存储库订单
    /// </summary>
    public class VaultOrder 
    {

        /// <summary>
        /// 存储库名称  最小长度：1  最大长度：64
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing", NullValueHandling = NullValueHandling.Ignore)]
        public BillingCreate Billing { get; set; }

        /// <summary>
        /// 绑定的备份资源，未在创建时绑定资源填[]
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceCreate> Resources { get; set; }

        /// <summary>
        /// 描述  最小长度：0  最大长度：255
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 备份策略ID，不设置时为null，不自动备份。
        /// </summary>
        [JsonProperty("backup_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupPolicyId { get; set; }

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
        /// 存储库阈值，百分比。  最小值：1  最大值：100
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? Threshold { get; set; }

        /// <summary>
        /// 当容量到达阈值，是否启用通知
        /// </summary>
        [JsonProperty("smn_notify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SmnNotify { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public VaultCreateParameters Parameters { get; set; }

        /// <summary>
        /// 是否开启存储库自动扩容能力（只支持按需存储库）。
        /// </summary>
        [JsonProperty("auto_expand", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoExpand { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VaultOrder {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  billing: ").Append(Billing).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  backupPolicyId: ").Append(BackupPolicyId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  autoBind: ").Append(AutoBind).Append("\n");
            sb.Append("  bindRules: ").Append(BindRules).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("  smnNotify: ").Append(SmnNotify).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  autoExpand: ").Append(AutoExpand).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VaultOrder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VaultOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Billing == input.Billing ||
                    (this.Billing != null &&
                    this.Billing.Equals(input.Billing))
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.BackupPolicyId == input.BackupPolicyId ||
                    (this.BackupPolicyId != null &&
                    this.BackupPolicyId.Equals(input.BackupPolicyId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.AutoBind == input.AutoBind ||
                    (this.AutoBind != null &&
                    this.AutoBind.Equals(input.AutoBind))
                ) && 
                (
                    this.BindRules == input.BindRules ||
                    (this.BindRules != null &&
                    this.BindRules.Equals(input.BindRules))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
                ) && 
                (
                    this.SmnNotify == input.SmnNotify ||
                    (this.SmnNotify != null &&
                    this.SmnNotify.Equals(input.SmnNotify))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    (this.Parameters != null &&
                    this.Parameters.Equals(input.Parameters))
                ) && 
                (
                    this.AutoExpand == input.AutoExpand ||
                    (this.AutoExpand != null &&
                    this.AutoExpand.Equals(input.AutoExpand))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Billing != null)
                    hashCode = hashCode * 59 + this.Billing.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.BackupPolicyId != null)
                    hashCode = hashCode * 59 + this.BackupPolicyId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.AutoBind != null)
                    hashCode = hashCode * 59 + this.AutoBind.GetHashCode();
                if (this.BindRules != null)
                    hashCode = hashCode * 59 + this.BindRules.GetHashCode();
                if (this.Threshold != null)
                    hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.SmnNotify != null)
                    hashCode = hashCode * 59 + this.SmnNotify.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.AutoExpand != null)
                    hashCode = hashCode * 59 + this.AutoExpand.GetHashCode();
                return hashCode;
            }
        }
    }
}
