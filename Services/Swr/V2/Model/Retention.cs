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
    /// 镜像老化规则
    /// </summary>
    public class Retention 
    {

        /// <summary>
        /// 回收规则匹配策略，or
        /// </summary>
        [JsonProperty("algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string Algorithm { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 镜像老化规则
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<Rule> Rules { get; set; }

        /// <summary>
        /// 保留字段
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Retention {\n");
            sb.Append("  algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Retention);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Retention input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Algorithm == input.Algorithm ||
                    (this.Algorithm != null &&
                    this.Algorithm.Equals(input.Algorithm))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    input.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
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
                if (this.Algorithm != null)
                    hashCode = hashCode * 59 + this.Algorithm.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                return hashCode;
            }
        }
    }
}
