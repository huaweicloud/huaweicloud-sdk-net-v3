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
    /// Response Object
    /// </summary>
    public class ShowAuditRuleRiskNewResponse : SdkResponse
    {

        /// <summary>
        /// 风险规则ID
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// 风险名称
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// 风险规则状态 - OFF - ON
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 操作集合, 中间逗号分隔。 LOGIN,CREATE_TABLE,CREATE_TABLESPACE,DROP_TABLE, DROP_TABLESPACE,DELETE,INSERT,INSERT_SELECT,SELECT,SELECT_FOR_UPDATE, UPDATE,CREATE_USER,DROP_USER,GRANT,OPERATE ALL
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// Schema列表
        /// </summary>
        [JsonProperty("schemas", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleRiskInfoBeanSchemas> Schemas { get; set; }

        /// <summary>
        /// 风险规则优先级。数字越小优先级越高。
        /// </summary>
        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// 是否忽略大小写
        /// </summary>
        [JsonProperty("ignore_case", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreCase { get; set; }

        /// <summary>
        /// 风险级别 - LOW - MEDIUM - HIGH - NO_RISK
        /// </summary>
        [JsonProperty("risk_level", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 数据库id，中间逗号分隔（单个id 小于256位）
        /// </summary>
        [JsonProperty("db_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string DbIds { get; set; }

        /// <summary>
        /// 执行时长对执行时长阈值的关系 - GREATER - EQUAL - LESS - GREATER_EQUAL - LESS_EQUAL - NO_MATCH
        /// </summary>
        [JsonProperty("execution_symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionSymbol { get; set; }

        /// <summary>
        /// 设定的执行时长阈值
        /// </summary>
        [JsonProperty("execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecutionTime { get; set; }

        /// <summary>
        /// 影响行数对行数阈值的关系：  - GREATER - EQUAL - LESS - GREATER_EQUAL - LESS_EQUAL - NO_MATCH
        /// </summary>
        [JsonProperty("affect_symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string AffectSymbol { get; set; }

        /// <summary>
        /// 设定的影响行数阈值
        /// </summary>
        [JsonProperty("affect_rows", NullValueHandling = NullValueHandling.Ignore)]
        public int? AffectRows { get; set; }

        /// <summary>
        /// 客户端IP段: IP-IP格式，或IP/XX 格式。 各个IP段使用逗号连接
        /// </summary>
        [JsonProperty("client_ips", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAuditRuleRiskNewResponse {\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  schemas: ").Append(Schemas).Append("\n");
            sb.Append("  rank: ").Append(Rank).Append("\n");
            sb.Append("  ignoreCase: ").Append(IgnoreCase).Append("\n");
            sb.Append("  riskLevel: ").Append(RiskLevel).Append("\n");
            sb.Append("  dbIds: ").Append(DbIds).Append("\n");
            sb.Append("  executionSymbol: ").Append(ExecutionSymbol).Append("\n");
            sb.Append("  executionTime: ").Append(ExecutionTime).Append("\n");
            sb.Append("  affectSymbol: ").Append(AffectSymbol).Append("\n");
            sb.Append("  affectRows: ").Append(AffectRows).Append("\n");
            sb.Append("  clientIps: ").Append(ClientIps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAuditRuleRiskNewResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAuditRuleRiskNewResponse input)
        {
            if (input == null) return false;
            if (this.RuleId != input.RuleId || (this.RuleId != null && !this.RuleId.Equals(input.RuleId))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Schemas != input.Schemas || (this.Schemas != null && input.Schemas != null && !this.Schemas.SequenceEqual(input.Schemas))) return false;
            if (this.Rank != input.Rank || (this.Rank != null && !this.Rank.Equals(input.Rank))) return false;
            if (this.IgnoreCase != input.IgnoreCase || (this.IgnoreCase != null && !this.IgnoreCase.Equals(input.IgnoreCase))) return false;
            if (this.RiskLevel != input.RiskLevel || (this.RiskLevel != null && !this.RiskLevel.Equals(input.RiskLevel))) return false;
            if (this.DbIds != input.DbIds || (this.DbIds != null && !this.DbIds.Equals(input.DbIds))) return false;
            if (this.ExecutionSymbol != input.ExecutionSymbol || (this.ExecutionSymbol != null && !this.ExecutionSymbol.Equals(input.ExecutionSymbol))) return false;
            if (this.ExecutionTime != input.ExecutionTime || (this.ExecutionTime != null && !this.ExecutionTime.Equals(input.ExecutionTime))) return false;
            if (this.AffectSymbol != input.AffectSymbol || (this.AffectSymbol != null && !this.AffectSymbol.Equals(input.AffectSymbol))) return false;
            if (this.AffectRows != input.AffectRows || (this.AffectRows != null && !this.AffectRows.Equals(input.AffectRows))) return false;
            if (this.ClientIps != input.ClientIps || (this.ClientIps != null && !this.ClientIps.Equals(input.ClientIps))) return false;

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
                if (this.RuleId != null) hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Schemas != null) hashCode = hashCode * 59 + this.Schemas.GetHashCode();
                if (this.Rank != null) hashCode = hashCode * 59 + this.Rank.GetHashCode();
                if (this.IgnoreCase != null) hashCode = hashCode * 59 + this.IgnoreCase.GetHashCode();
                if (this.RiskLevel != null) hashCode = hashCode * 59 + this.RiskLevel.GetHashCode();
                if (this.DbIds != null) hashCode = hashCode * 59 + this.DbIds.GetHashCode();
                if (this.ExecutionSymbol != null) hashCode = hashCode * 59 + this.ExecutionSymbol.GetHashCode();
                if (this.ExecutionTime != null) hashCode = hashCode * 59 + this.ExecutionTime.GetHashCode();
                if (this.AffectSymbol != null) hashCode = hashCode * 59 + this.AffectSymbol.GetHashCode();
                if (this.AffectRows != null) hashCode = hashCode * 59 + this.AffectRows.GetHashCode();
                if (this.ClientIps != null) hashCode = hashCode * 59 + this.ClientIps.GetHashCode();
                return hashCode;
            }
        }
    }
}
