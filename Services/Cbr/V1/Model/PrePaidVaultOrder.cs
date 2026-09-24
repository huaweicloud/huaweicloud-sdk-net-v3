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
    /// 包周期存储库订单
    /// </summary>
    public class PrePaidVaultOrder 
    {

        /// <summary>
        /// 存储库名称，最大支持64字符，只能由中文、字母、数字、\&quot;_\&quot;、\&quot;-\&quot;组成。默认取值不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing", NullValueHandling = NullValueHandling.Ignore)]
        public PrePaidBillingCreate Billing { get; set; }

        /// <summary>
        /// 绑定的备份资源，未在创建时绑定资源填[]
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceCreate> Resources { get; set; }

        /// <summary>
        /// 存储库描述，取值范围：最小长度：0，最大长度：255。默认取值不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 备份策略ID，默认值为null，不自动备份。 [获取方法请参见\&quot;[获取备份策略ID](https://support.huaweicloud.com/api-cbr/ListPolicies.html)\&quot;。](tag:hws) [获取方法请参见\&quot;[获取备份策略ID](https://support.huaweicloud.com/intl/zh-cn/api-cbr/ListPolicies.html)\&quot;。](tag:hws_hk)
        /// </summary>
        [JsonProperty("backup_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupPolicyId { get; set; }

        /// <summary>
        /// 标签列表 tags不允许为空列表。 tags中最多包含10个key。 tags中key不允许重复。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 企业项目ID，默认为&#39;0&#39;。 [获取方法请参见\&quot;[获取企业项目ID](https://support.huaweicloud.com/usermanual-em/zh-cn_topic_0126101490.html)\&quot;。](tag:hws) [获取方法请参见\&quot;[获取企业项目ID](https://support.huaweicloud.com/intl/zh-cn/usermanual-em/zh-cn_topic_0126101490.html)\&quot;。](tag:hws_hk)
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 功能说明：是否支持自动挂载。默认为false。 取值范围： - true：支持自动挂载 - false：不支持自动挂载
        /// </summary>
        [JsonProperty("auto_bind", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoBind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bind_rules", NullValueHandling = NullValueHandling.Ignore)]
        public VaultBindRules BindRules { get; set; }

        /// <summary>
        /// 功能说明：存储库容量阈值，存储库已用容量和总容量的百分比超过该值，如果smn_notify为开，将发送相关通知。 取值范围：[1, 100]，默认值为80。
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? Threshold { get; set; }

        /// <summary>
        /// 功能说明：是否发送smn通知开关，默认为true 取值范围： - true：发送smn通知 - false：不发送smn通知
        /// </summary>
        [JsonProperty("smn_notify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SmnNotify { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public VaultCreateParameters Parameters { get; set; }

        /// <summary>
        /// 功能说明：是否开启存储库自动扩容能力（只支持按需存储库），默认为false。 取值范围： - true：支持自动扩容； - false：不支持自动扩容。
        /// </summary>
        [JsonProperty("auto_expand", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoExpand { get; set; }

        /// <summary>
        /// 功能说明：用于标识当前存储库是否已锁定，锁定的存储库不支持解锁。默认值为false。 [关于备份锁定的详细信息，请参考\&quot;[开启备份锁定](https://support.huaweicloud.com/usermanual-cbr/cbr_01_0035.html)\&quot;。](tag:hws) [关于备份锁定的详细信息，请参考\&quot;[开启备份锁定](https://support.huaweicloud.com/intl/zh-cn/usermanual-cbr/cbr_01_0035.html)\&quot;。](tag:hws_hk) 取值范围： - true：锁定存储库 - false：不锁定存储库
        /// </summary>
        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Locked { get; set; }

        /// <summary>
        /// 功能说明：是否为跨账号复制存储库，默认值为false，只有创建跨账号复制存储库时才允许该值为true。 取值范围： - false: 非跨账号复制存储库 - true: 跨账号复制存储库
        /// </summary>
        [JsonProperty("cross_account", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CrossAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data_encryption", NullValueHandling = NullValueHandling.Ignore)]
        public DataEncryption DataEncryption { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrePaidVaultOrder {\n");
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
            sb.Append("  locked: ").Append(Locked).Append("\n");
            sb.Append("  crossAccount: ").Append(CrossAccount).Append("\n");
            sb.Append("  dataEncryption: ").Append(DataEncryption).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrePaidVaultOrder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrePaidVaultOrder input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Billing != input.Billing || (this.Billing != null && !this.Billing.Equals(input.Billing))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.BackupPolicyId != input.BackupPolicyId || (this.BackupPolicyId != null && !this.BackupPolicyId.Equals(input.BackupPolicyId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.AutoBind != input.AutoBind || (this.AutoBind != null && !this.AutoBind.Equals(input.AutoBind))) return false;
            if (this.BindRules != input.BindRules || (this.BindRules != null && !this.BindRules.Equals(input.BindRules))) return false;
            if (this.Threshold != input.Threshold || (this.Threshold != null && !this.Threshold.Equals(input.Threshold))) return false;
            if (this.SmnNotify != input.SmnNotify || (this.SmnNotify != null && !this.SmnNotify.Equals(input.SmnNotify))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && !this.Parameters.Equals(input.Parameters))) return false;
            if (this.AutoExpand != input.AutoExpand || (this.AutoExpand != null && !this.AutoExpand.Equals(input.AutoExpand))) return false;
            if (this.Locked != input.Locked || (this.Locked != null && !this.Locked.Equals(input.Locked))) return false;
            if (this.CrossAccount != input.CrossAccount || (this.CrossAccount != null && !this.CrossAccount.Equals(input.CrossAccount))) return false;
            if (this.DataEncryption != input.DataEncryption || (this.DataEncryption != null && !this.DataEncryption.Equals(input.DataEncryption))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Billing != null) hashCode = hashCode * 59 + this.Billing.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.BackupPolicyId != null) hashCode = hashCode * 59 + this.BackupPolicyId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.AutoBind != null) hashCode = hashCode * 59 + this.AutoBind.GetHashCode();
                if (this.BindRules != null) hashCode = hashCode * 59 + this.BindRules.GetHashCode();
                if (this.Threshold != null) hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.SmnNotify != null) hashCode = hashCode * 59 + this.SmnNotify.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.AutoExpand != null) hashCode = hashCode * 59 + this.AutoExpand.GetHashCode();
                if (this.Locked != null) hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.CrossAccount != null) hashCode = hashCode * 59 + this.CrossAccount.GetHashCode();
                if (this.DataEncryption != null) hashCode = hashCode * 59 + this.DataEncryption.GetHashCode();
                return hashCode;
            }
        }
    }
}
