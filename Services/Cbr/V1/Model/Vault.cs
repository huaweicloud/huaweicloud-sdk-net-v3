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
    public class Vault 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing", NullValueHandling = NullValueHandling.Ignore)]
        public Billing Billing { get; set; }

        /// <summary>
        /// 存储库自定义描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 存储库ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 存储库名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 存储库资源类型id
        /// </summary>
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        /// <summary>
        /// 存储库资源
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceResp> Resources { get; set; }

        /// <summary>
        /// 存储库标签
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 企业项目id，默认为‘0’。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 是否自动绑定，默认为false，不支持。
        /// </summary>
        [JsonProperty("auto_bind", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoBind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bind_rules", NullValueHandling = NullValueHandling.Ignore)]
        public VaultBindRules BindRules { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 创建时间,例如:\&quot;2020-02-05T10:38:34.209782\&quot;
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 是否开启存储库自动扩容能力（只支持按需存储库）。
        /// </summary>
        [JsonProperty("auto_expand", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoExpand { get; set; }

        /// <summary>
        /// 存储库smn消息通知开关
        /// </summary>
        [JsonProperty("smn_notify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SmnNotify { get; set; }

        /// <summary>
        /// 存储库容量阈值，已用容量占总容量达到此百分比即发送相关通知
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? Threshold { get; set; }

        /// <summary>
        /// 用于标识SMB服务
        /// </summary>
        [JsonProperty("sys_lock_source_service", NullValueHandling = NullValueHandling.Ignore)]
        public string SysLockSourceService { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vault {\n");
            sb.Append("  billing: ").Append(Billing).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  autoBind: ").Append(AutoBind).Append("\n");
            sb.Append("  bindRules: ").Append(BindRules).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  autoExpand: ").Append(AutoExpand).Append("\n");
            sb.Append("  smnNotify: ").Append(SmnNotify).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("  sysLockSourceService: ").Append(SysLockSourceService).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Vault);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Vault input)
        {
            if (input == null) return false;
            if (this.Billing != input.Billing || (this.Billing != null && !this.Billing.Equals(input.Billing))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProviderId != input.ProviderId || (this.ProviderId != null && !this.ProviderId.Equals(input.ProviderId))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.AutoBind != input.AutoBind || (this.AutoBind != null && !this.AutoBind.Equals(input.AutoBind))) return false;
            if (this.BindRules != input.BindRules || (this.BindRules != null && !this.BindRules.Equals(input.BindRules))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.AutoExpand != input.AutoExpand || (this.AutoExpand != null && !this.AutoExpand.Equals(input.AutoExpand))) return false;
            if (this.SmnNotify != input.SmnNotify || (this.SmnNotify != null && !this.SmnNotify.Equals(input.SmnNotify))) return false;
            if (this.Threshold != input.Threshold || (this.Threshold != null && !this.Threshold.Equals(input.Threshold))) return false;
            if (this.SysLockSourceService != input.SysLockSourceService || (this.SysLockSourceService != null && !this.SysLockSourceService.Equals(input.SysLockSourceService))) return false;

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
                if (this.Billing != null) hashCode = hashCode * 59 + this.Billing.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProviderId != null) hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.AutoBind != null) hashCode = hashCode * 59 + this.AutoBind.GetHashCode();
                if (this.BindRules != null) hashCode = hashCode * 59 + this.BindRules.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.AutoExpand != null) hashCode = hashCode * 59 + this.AutoExpand.GetHashCode();
                if (this.SmnNotify != null) hashCode = hashCode * 59 + this.SmnNotify.GetHashCode();
                if (this.Threshold != null) hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.SysLockSourceService != null) hashCode = hashCode * 59 + this.SysLockSourceService.GetHashCode();
                return hashCode;
            }
        }
    }
}
