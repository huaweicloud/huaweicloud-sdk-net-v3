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
    public class AuditSqlRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public AuditSqlRequestTime Time { get; set; }

        /// <summary>
        /// 风险级别 - HIGH：高 - MEDIUM：中 - LOW：低 - NO_RISK：无
        /// </summary>
        [JsonProperty("risk_levels", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskLevels { get; set; }

        /// <summary>
        /// 客户端IP
        /// </summary>
        [JsonProperty("client_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIp { get; set; }

        /// <summary>
        /// 客户端名称
        /// </summary>
        [JsonProperty("client_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientName { get; set; }

        /// <summary>
        /// 数据库IP
        /// </summary>
        [JsonProperty("db_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DbIp { get; set; }

        /// <summary>
        /// 数据库用户
        /// </summary>
        [JsonProperty("db_user", NullValueHandling = NullValueHandling.Ignore)]
        public string DbUser { get; set; }

        /// <summary>
        /// 查询类型 - LOGIN：LOGIN - CREATE_TABLE：CREATE TABLE - CREATE_TABLESPACE：CREATE TABLESPACE - DROP_TABLE：DROP TABLE - DROP_TABLESPACE：DROP TABLESPACE - DELETE：DELETE - INSERT：INSERT - INSERT_SELECT：INSERT SELECT - SELECT：SELECT - SELECT_FOR_UPDATE：SELECT FOR UPDATE - UPDATE：UPDATE - CREATE_USER：CREATE USER - DROP_USER：DROP USER - GRANT：GRANT - OPERATE：OPERATE - ALL: ALL
        /// </summary>
        [JsonProperty("query_type", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryType { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// sql语句
        /// </summary>
        [JsonProperty("sql_statement", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlStatement { get; set; }

        /// <summary>
        /// 响应结果 - SUCCESS：成功 - FAILED：失败
        /// </summary>
        [JsonProperty("sql_response", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlResponse { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// 条数
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 时间顺序 - DESC：降序 - ASC：升序
        /// </summary>
        [JsonProperty("time_order", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeOrder { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditSqlRequest {\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  riskLevels: ").Append(RiskLevels).Append("\n");
            sb.Append("  clientIp: ").Append(ClientIp).Append("\n");
            sb.Append("  clientName: ").Append(ClientName).Append("\n");
            sb.Append("  dbIp: ").Append(DbIp).Append("\n");
            sb.Append("  dbUser: ").Append(DbUser).Append("\n");
            sb.Append("  queryType: ").Append(QueryType).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  sqlStatement: ").Append(SqlStatement).Append("\n");
            sb.Append("  sqlResponse: ").Append(SqlResponse).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  timeOrder: ").Append(TimeOrder).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuditSqlRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuditSqlRequest input)
        {
            if (input == null) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.RiskLevels != input.RiskLevels || (this.RiskLevels != null && !this.RiskLevels.Equals(input.RiskLevels))) return false;
            if (this.ClientIp != input.ClientIp || (this.ClientIp != null && !this.ClientIp.Equals(input.ClientIp))) return false;
            if (this.ClientName != input.ClientName || (this.ClientName != null && !this.ClientName.Equals(input.ClientName))) return false;
            if (this.DbIp != input.DbIp || (this.DbIp != null && !this.DbIp.Equals(input.DbIp))) return false;
            if (this.DbUser != input.DbUser || (this.DbUser != null && !this.DbUser.Equals(input.DbUser))) return false;
            if (this.QueryType != input.QueryType || (this.QueryType != null && !this.QueryType.Equals(input.QueryType))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.SqlStatement != input.SqlStatement || (this.SqlStatement != null && !this.SqlStatement.Equals(input.SqlStatement))) return false;
            if (this.SqlResponse != input.SqlResponse || (this.SqlResponse != null && !this.SqlResponse.Equals(input.SqlResponse))) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.TimeOrder != input.TimeOrder || (this.TimeOrder != null && !this.TimeOrder.Equals(input.TimeOrder))) return false;

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
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.RiskLevels != null) hashCode = hashCode * 59 + this.RiskLevels.GetHashCode();
                if (this.ClientIp != null) hashCode = hashCode * 59 + this.ClientIp.GetHashCode();
                if (this.ClientName != null) hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                if (this.DbIp != null) hashCode = hashCode * 59 + this.DbIp.GetHashCode();
                if (this.DbUser != null) hashCode = hashCode * 59 + this.DbUser.GetHashCode();
                if (this.QueryType != null) hashCode = hashCode * 59 + this.QueryType.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.SqlStatement != null) hashCode = hashCode * 59 + this.SqlStatement.GetHashCode();
                if (this.SqlResponse != null) hashCode = hashCode * 59 + this.SqlResponse.GetHashCode();
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.TimeOrder != null) hashCode = hashCode * 59 + this.TimeOrder.GetHashCode();
                return hashCode;
            }
        }
    }
}
