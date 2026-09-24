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
    public class CheckpointParam 
    {

        /// <summary>
        /// 是否自动触发,true：自动触发，false：非自动触发。
        /// </summary>
        [JsonProperty("auto_trigger", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoTrigger { get; set; }

        /// <summary>
        /// 备份描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 是否增量备份，true：增量备份，false：非增量备份。
        /// </summary>
        [JsonProperty("incremental", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incremental { get; set; }

        /// <summary>
        /// 备份名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 待备份的资源id列表:uuid
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Resources { get; set; }

        /// <summary>
        /// 资源详情
        /// </summary>
        [JsonProperty("resource_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<Resource> ResourceDetails { get; set; }

        /// <summary>
        /// 自动备份时的策略id
        /// </summary>
        [JsonProperty("policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyId { get; set; }

        /// <summary>
        /// **参数解释**： 手动备份的保留时长，单位为天。设置该参数后，备份副本将在保留时长到期后自动删除。用于为手动备份设置自动过期时间，避免手动备份堆积导致存储容量浪费。不设置此参数时，备份将永久保留。 **约束限制**： 当auto_trigger为true时不支持传此参数，自动备份的保留时间由关联的备份策略指定。auto_trigger不传或为false时支持指定此参数。 **取值范围**： -  1~36500：指定保留天数，备份将在创建时间 + 该天数后到期并自动删除。 - -1：永久保留，备份不会自动过期。  **默认取值**： -1 &gt; 该特性目前处于公测阶段，部分Region可能无法使用
        /// </summary>
        [JsonProperty("retention_duration_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionDurationDays { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckpointParam {\n");
            sb.Append("  autoTrigger: ").Append(AutoTrigger).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  incremental: ").Append(Incremental).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  resourceDetails: ").Append(ResourceDetails).Append("\n");
            sb.Append("  policyId: ").Append(PolicyId).Append("\n");
            sb.Append("  retentionDurationDays: ").Append(RetentionDurationDays).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckpointParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckpointParam input)
        {
            if (input == null) return false;
            if (this.AutoTrigger != input.AutoTrigger || (this.AutoTrigger != null && !this.AutoTrigger.Equals(input.AutoTrigger))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Incremental != input.Incremental || (this.Incremental != null && !this.Incremental.Equals(input.Incremental))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;
            if (this.ResourceDetails != input.ResourceDetails || (this.ResourceDetails != null && input.ResourceDetails != null && !this.ResourceDetails.SequenceEqual(input.ResourceDetails))) return false;
            if (this.PolicyId != input.PolicyId || (this.PolicyId != null && !this.PolicyId.Equals(input.PolicyId))) return false;
            if (this.RetentionDurationDays != input.RetentionDurationDays || (this.RetentionDurationDays != null && !this.RetentionDurationDays.Equals(input.RetentionDurationDays))) return false;

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
                if (this.AutoTrigger != null) hashCode = hashCode * 59 + this.AutoTrigger.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Incremental != null) hashCode = hashCode * 59 + this.Incremental.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.ResourceDetails != null) hashCode = hashCode * 59 + this.ResourceDetails.GetHashCode();
                if (this.PolicyId != null) hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.RetentionDurationDays != null) hashCode = hashCode * 59 + this.RetentionDurationDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
