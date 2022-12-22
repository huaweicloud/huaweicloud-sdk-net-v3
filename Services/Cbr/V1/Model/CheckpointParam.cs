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
        /// 是否自动触发,true:自动触发，false：非自动触发。
        /// </summary>
        [JsonProperty("auto_trigger", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoTrigger { get; set; }

        /// <summary>
        /// 备份描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 是否增量备份，true:增量备份，false：非增量备份。
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
            if (input == null)
                return false;

            return 
                (
                    this.AutoTrigger == input.AutoTrigger ||
                    (this.AutoTrigger != null &&
                    this.AutoTrigger.Equals(input.AutoTrigger))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Incremental == input.Incremental ||
                    (this.Incremental != null &&
                    this.Incremental.Equals(input.Incremental))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
                ) && 
                (
                    this.ResourceDetails == input.ResourceDetails ||
                    this.ResourceDetails != null &&
                    input.ResourceDetails != null &&
                    this.ResourceDetails.SequenceEqual(input.ResourceDetails)
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
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
                if (this.AutoTrigger != null)
                    hashCode = hashCode * 59 + this.AutoTrigger.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Incremental != null)
                    hashCode = hashCode * 59 + this.Incremental.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Resources != null)
                    hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.ResourceDetails != null)
                    hashCode = hashCode * 59 + this.ResourceDetails.GetHashCode();
                if (this.PolicyId != null)
                    hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
