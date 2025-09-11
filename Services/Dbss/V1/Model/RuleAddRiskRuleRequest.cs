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
    public class RuleAddRiskRuleRequest 
    {

        /// <summary>
        /// 操作类型，多个用英文&#39;,&#39;分隔
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 影响行数
        /// </summary>
        [JsonProperty("affect_rows", NullValueHandling = NullValueHandling.Ignore)]
        public int? AffectRows { get; set; }

        /// <summary>
        /// 影响行数操作符 - GREATER: 大于 - EQUAL: 等于 - LESS: 小于 - GREATER_EQUAL: 大于等于 - LESS_EQUAL: 小于等于 - NO_MATCH: 不等于
        /// </summary>
        [JsonProperty("affect_symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string AffectSymbol { get; set; }

        /// <summary>
        /// 客户端IP，多个用英文&#39;,&#39;分隔
        /// </summary>
        [JsonProperty("client_ips", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIps { get; set; }

        /// <summary>
        /// 数据库ID，多个用英文&#39;,&#39;分隔
        /// </summary>
        [JsonProperty("db_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string DbIds { get; set; }

        /// <summary>
        /// 例外IP，IP内不做匹配，多个用英文&#39;,&#39;分隔
        /// </summary>
        [JsonProperty("exception_ips", NullValueHandling = NullValueHandling.Ignore)]
        public string ExceptionIps { get; set; }

        /// <summary>
        /// 执行时长操作符 - GREATER: 大于 - EQUAL: 等于 - LESS: 小于 - GREATER_EQUAL: 大于等于 - LESS_EQUAL: 小于等于 - NO_MATCH: 不等于
        /// </summary>
        [JsonProperty("execution_symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionSymbol { get; set; }

        /// <summary>
        /// 执行时长
        /// </summary>
        [JsonProperty("execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExecutionTime { get; set; }

        /// <summary>
        /// 是否忽略大小写
        /// </summary>
        [JsonProperty("ignore_case", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreCase { get; set; }

        /// <summary>
        /// 风险等级   - LOW：低  - MEDIUM：中  - HIGH：高  - NO_RISK：无
        /// </summary>
        [JsonProperty("risk_level", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// 操作对象
        /// </summary>
        [JsonProperty("schemas", NullValueHandling = NullValueHandling.Ignore)]
        public List<SchemaBean> Schemas { get; set; }

        /// <summary>
        /// 状态  - OFF：已关闭  - ON：已开启
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleAddRiskRuleRequest {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  affectRows: ").Append(AffectRows).Append("\n");
            sb.Append("  affectSymbol: ").Append(AffectSymbol).Append("\n");
            sb.Append("  clientIps: ").Append(ClientIps).Append("\n");
            sb.Append("  dbIds: ").Append(DbIds).Append("\n");
            sb.Append("  exceptionIps: ").Append(ExceptionIps).Append("\n");
            sb.Append("  executionSymbol: ").Append(ExecutionSymbol).Append("\n");
            sb.Append("  executionTime: ").Append(ExecutionTime).Append("\n");
            sb.Append("  ignoreCase: ").Append(IgnoreCase).Append("\n");
            sb.Append("  riskLevel: ").Append(RiskLevel).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  schemas: ").Append(Schemas).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleAddRiskRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleAddRiskRuleRequest input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.AffectRows != input.AffectRows || (this.AffectRows != null && !this.AffectRows.Equals(input.AffectRows))) return false;
            if (this.AffectSymbol != input.AffectSymbol || (this.AffectSymbol != null && !this.AffectSymbol.Equals(input.AffectSymbol))) return false;
            if (this.ClientIps != input.ClientIps || (this.ClientIps != null && !this.ClientIps.Equals(input.ClientIps))) return false;
            if (this.DbIds != input.DbIds || (this.DbIds != null && !this.DbIds.Equals(input.DbIds))) return false;
            if (this.ExceptionIps != input.ExceptionIps || (this.ExceptionIps != null && !this.ExceptionIps.Equals(input.ExceptionIps))) return false;
            if (this.ExecutionSymbol != input.ExecutionSymbol || (this.ExecutionSymbol != null && !this.ExecutionSymbol.Equals(input.ExecutionSymbol))) return false;
            if (this.ExecutionTime != input.ExecutionTime || (this.ExecutionTime != null && !this.ExecutionTime.Equals(input.ExecutionTime))) return false;
            if (this.IgnoreCase != input.IgnoreCase || (this.IgnoreCase != null && !this.IgnoreCase.Equals(input.IgnoreCase))) return false;
            if (this.RiskLevel != input.RiskLevel || (this.RiskLevel != null && !this.RiskLevel.Equals(input.RiskLevel))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.Schemas != input.Schemas || (this.Schemas != null && input.Schemas != null && !this.Schemas.SequenceEqual(input.Schemas))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.AffectRows != null) hashCode = hashCode * 59 + this.AffectRows.GetHashCode();
                if (this.AffectSymbol != null) hashCode = hashCode * 59 + this.AffectSymbol.GetHashCode();
                if (this.ClientIps != null) hashCode = hashCode * 59 + this.ClientIps.GetHashCode();
                if (this.DbIds != null) hashCode = hashCode * 59 + this.DbIds.GetHashCode();
                if (this.ExceptionIps != null) hashCode = hashCode * 59 + this.ExceptionIps.GetHashCode();
                if (this.ExecutionSymbol != null) hashCode = hashCode * 59 + this.ExecutionSymbol.GetHashCode();
                if (this.ExecutionTime != null) hashCode = hashCode * 59 + this.ExecutionTime.GetHashCode();
                if (this.IgnoreCase != null) hashCode = hashCode * 59 + this.IgnoreCase.GetHashCode();
                if (this.RiskLevel != null) hashCode = hashCode * 59 + this.RiskLevel.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.Schemas != null) hashCode = hashCode * 59 + this.Schemas.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
