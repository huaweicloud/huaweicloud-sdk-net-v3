using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RetentionLog 
    {

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 组织名
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 镜像仓库名
        /// </summary>
        [JsonProperty("repo", NullValueHandling = NullValueHandling.Ignore)]
        public string Repo { get; set; }

        /// <summary>
        /// 老化规则ID
        /// </summary>
        [JsonProperty("retention_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionId { get; set; }

        /// <summary>
        /// 规则
        /// </summary>
        [JsonProperty("rule_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleType { get; set; }

        /// <summary>
        /// 镜像版本
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetentionLog {\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  repo: ").Append(Repo).Append("\n");
            sb.Append("  retentionId: ").Append(RetentionId).Append("\n");
            sb.Append("  ruleType: ").Append(RuleType).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetentionLog);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetentionLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Repo == input.Repo ||
                    (this.Repo != null &&
                    this.Repo.Equals(input.Repo))
                ) && 
                (
                    this.RetentionId == input.RetentionId ||
                    (this.RetentionId != null &&
                    this.RetentionId.Equals(input.RetentionId))
                ) && 
                (
                    this.RuleType == input.RuleType ||
                    (this.RuleType != null &&
                    this.RuleType.Equals(input.RuleType))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Repo != null)
                    hashCode = hashCode * 59 + this.Repo.GetHashCode();
                if (this.RetentionId != null)
                    hashCode = hashCode * 59 + this.RetentionId.GetHashCode();
                if (this.RuleType != null)
                    hashCode = hashCode * 59 + this.RuleType.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                return hashCode;
            }
        }
    }
}
