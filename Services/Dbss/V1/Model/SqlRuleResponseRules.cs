using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SqlRuleResponseRules 
    {

        /// <summary>
        /// SQL规则ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// SQL规则名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 规则的状态： - ON：启用 - OFF：禁用
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 风险级别 - HIGH：高 - MEDIUM：中 - LOW：低
        /// </summary>
        [JsonProperty("risk_level", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 风险类型 - SYSTEM：系统  - CUSTOMIZE：自定义
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 优先级。数字越小优先级越高。
        /// </summary>
        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// SQL命令特征
        /// </summary>
        [JsonProperty("feature", NullValueHandling = NullValueHandling.Ignore)]
        public string Feature { get; set; }

        /// <summary>
        /// 正则表达式
        /// </summary>
        [JsonProperty("regex", NullValueHandling = NullValueHandling.Ignore)]
        public string Regex { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlRuleResponseRules {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  riskLevel: ").Append(RiskLevel).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  rank: ").Append(Rank).Append("\n");
            sb.Append("  feature: ").Append(Feature).Append("\n");
            sb.Append("  regex: ").Append(Regex).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SqlRuleResponseRules);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SqlRuleResponseRules input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.RiskLevel != input.RiskLevel || (this.RiskLevel != null && !this.RiskLevel.Equals(input.RiskLevel))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Rank != input.Rank || (this.Rank != null && !this.Rank.Equals(input.Rank))) return false;
            if (this.Feature != input.Feature || (this.Feature != null && !this.Feature.Equals(input.Feature))) return false;
            if (this.Regex != input.Regex || (this.Regex != null && !this.Regex.Equals(input.Regex))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RiskLevel != null) hashCode = hashCode * 59 + this.RiskLevel.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Rank != null) hashCode = hashCode * 59 + this.Rank.GetHashCode();
                if (this.Feature != null) hashCode = hashCode * 59 + this.Feature.GetHashCode();
                if (this.Regex != null) hashCode = hashCode * 59 + this.Regex.GetHashCode();
                return hashCode;
            }
        }
    }
}
