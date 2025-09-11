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
    /// SQL语句对象
    /// </summary>
    public class SqlDetailBean 
    {

        /// <summary>
        /// 审计结果
        /// </summary>
        [JsonProperty("audit_result", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditResult { get; set; }

        /// <summary>
        /// 客户端端口
        /// </summary>
        [JsonProperty("client_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientPort { get; set; }

        /// <summary>
        /// 客户端IP
        /// </summary>
        [JsonProperty("client_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIp { get; set; }

        /// <summary>
        /// 客户端MAC地址
        /// </summary>
        [JsonProperty("client_mac", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientMac { get; set; }

        /// <summary>
        /// 客户端名称
        /// </summary>
        [JsonProperty("client_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientName { get; set; }

        /// <summary>
        /// 客户端系统主机名称
        /// </summary>
        [JsonProperty("client_os_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientOsName { get; set; }

        /// <summary>
        /// 客户端操作系统用户名
        /// </summary>
        [JsonProperty("client_os_user", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientOsUser { get; set; }

        /// <summary>
        /// 客户端端口字符
        /// </summary>
        [JsonProperty("client_port_str", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientPortStr { get; set; }

        /// <summary>
        /// 客户端连接工具
        /// </summary>
        [JsonProperty("client_tool", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientTool { get; set; }

        /// <summary>
        /// 数据库端口
        /// </summary>
        [JsonProperty("db_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DbPort { get; set; }

        /// <summary>
        /// 数据库实例
        /// </summary>
        [JsonProperty("db_instance", NullValueHandling = NullValueHandling.Ignore)]
        public string DbInstance { get; set; }

        /// <summary>
        /// 数据库IP
        /// </summary>
        [JsonProperty("db_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DbIp { get; set; }

        /// <summary>
        /// 数据库MAC地址
        /// </summary>
        [JsonProperty("db_mac", NullValueHandling = NullValueHandling.Ignore)]
        public string DbMac { get; set; }

        /// <summary>
        /// 数据库端口字符
        /// </summary>
        [JsonProperty("db_port_str", NullValueHandling = NullValueHandling.Ignore)]
        public string DbPortStr { get; set; }

        /// <summary>
        /// 数据库服务名称
        /// </summary>
        [JsonProperty("db_service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbServiceName { get; set; }

        /// <summary>
        /// 数据库连接ID
        /// </summary>
        [JsonProperty("db_session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DbSessionId { get; set; }

        /// <summary>
        /// 数据库类型
        /// </summary>
        [JsonProperty("db_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DbType { get; set; }

        /// <summary>
        /// 数据库用户
        /// </summary>
        [JsonProperty("db_user", NullValueHandling = NullValueHandling.Ignore)]
        public string DbUser { get; set; }

        /// <summary>
        /// 请求结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 执行时长
        /// </summary>
        [JsonProperty("execute_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExecuteTime { get; set; }

        /// <summary>
        /// 操作对象类型信息
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// 记录ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 风险等级   - LOW：低  - MEDIUM：中  - HIGH：高  - NO_RISK：无
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        /// 影响行数
        /// </summary>
        [JsonProperty("lines", NullValueHandling = NullValueHandling.Ignore)]
        public string Lines { get; set; }

        /// <summary>
        /// 登入登出结果
        /// </summary>
        [JsonProperty("log_result", NullValueHandling = NullValueHandling.Ignore)]
        public string LogResult { get; set; }

        /// <summary>
        /// 操作对象
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public string Object { get; set; }

        /// <summary>
        /// 操作对象类型
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectType { get; set; }

        /// <summary>
        /// 查询ID
        /// </summary>
        [JsonProperty("query_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryId { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [JsonProperty("query_type", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryType { get; set; }

        /// <summary>
        /// 数据长度
        /// </summary>
        [JsonProperty("response_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResponseLength { get; set; }

        /// <summary>
        /// 响应状态
        /// </summary>
        [JsonProperty("response_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ResponseStatus { get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// 规则类型
        /// </summary>
        [JsonProperty("rule_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleType { get; set; }

        /// <summary>
        /// 数据库SCHEMA
        /// </summary>
        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public string Schema { get; set; }

        /// <summary>
        /// 审计范围ID
        /// </summary>
        [JsonProperty("scope_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScopeId { get; set; }

        /// <summary>
        /// 审计范围名称
        /// </summary>
        [JsonProperty("scope_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScopeName { get; set; }

        /// <summary>
        /// SQL返回结果
        /// </summary>
        [JsonProperty("sql_response", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlResponse { get; set; }

        /// <summary>
        /// SQL处理结果
        /// </summary>
        [JsonProperty("sql_result", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlResult { get; set; }

        /// <summary>
        /// SQL语句内容
        /// </summary>
        [JsonProperty("sql_statement", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlStatement { get; set; }

        /// <summary>
        /// 请求开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// TCP连接ID
        /// </summary>
        [JsonProperty("tcp_session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TcpSessionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlDetailBean {\n");
            sb.Append("  auditResult: ").Append(AuditResult).Append("\n");
            sb.Append("  clientPort: ").Append(ClientPort).Append("\n");
            sb.Append("  clientIp: ").Append(ClientIp).Append("\n");
            sb.Append("  clientMac: ").Append(ClientMac).Append("\n");
            sb.Append("  clientName: ").Append(ClientName).Append("\n");
            sb.Append("  clientOsName: ").Append(ClientOsName).Append("\n");
            sb.Append("  clientOsUser: ").Append(ClientOsUser).Append("\n");
            sb.Append("  clientPortStr: ").Append(ClientPortStr).Append("\n");
            sb.Append("  clientTool: ").Append(ClientTool).Append("\n");
            sb.Append("  dbPort: ").Append(DbPort).Append("\n");
            sb.Append("  dbInstance: ").Append(DbInstance).Append("\n");
            sb.Append("  dbIp: ").Append(DbIp).Append("\n");
            sb.Append("  dbMac: ").Append(DbMac).Append("\n");
            sb.Append("  dbPortStr: ").Append(DbPortStr).Append("\n");
            sb.Append("  dbServiceName: ").Append(DbServiceName).Append("\n");
            sb.Append("  dbSessionId: ").Append(DbSessionId).Append("\n");
            sb.Append("  dbType: ").Append(DbType).Append("\n");
            sb.Append("  dbUser: ").Append(DbUser).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  executeTime: ").Append(ExecuteTime).Append("\n");
            sb.Append("  field: ").Append(Field).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  lines: ").Append(Lines).Append("\n");
            sb.Append("  logResult: ").Append(LogResult).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  queryId: ").Append(QueryId).Append("\n");
            sb.Append("  queryType: ").Append(QueryType).Append("\n");
            sb.Append("  responseLength: ").Append(ResponseLength).Append("\n");
            sb.Append("  responseStatus: ").Append(ResponseStatus).Append("\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  ruleType: ").Append(RuleType).Append("\n");
            sb.Append("  schema: ").Append(Schema).Append("\n");
            sb.Append("  scopeId: ").Append(ScopeId).Append("\n");
            sb.Append("  scopeName: ").Append(ScopeName).Append("\n");
            sb.Append("  sqlResponse: ").Append(SqlResponse).Append("\n");
            sb.Append("  sqlResult: ").Append(SqlResult).Append("\n");
            sb.Append("  sqlStatement: ").Append(SqlStatement).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  tcpSessionId: ").Append(TcpSessionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SqlDetailBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SqlDetailBean input)
        {
            if (input == null) return false;
            if (this.AuditResult != input.AuditResult || (this.AuditResult != null && !this.AuditResult.Equals(input.AuditResult))) return false;
            if (this.ClientPort != input.ClientPort || (this.ClientPort != null && !this.ClientPort.Equals(input.ClientPort))) return false;
            if (this.ClientIp != input.ClientIp || (this.ClientIp != null && !this.ClientIp.Equals(input.ClientIp))) return false;
            if (this.ClientMac != input.ClientMac || (this.ClientMac != null && !this.ClientMac.Equals(input.ClientMac))) return false;
            if (this.ClientName != input.ClientName || (this.ClientName != null && !this.ClientName.Equals(input.ClientName))) return false;
            if (this.ClientOsName != input.ClientOsName || (this.ClientOsName != null && !this.ClientOsName.Equals(input.ClientOsName))) return false;
            if (this.ClientOsUser != input.ClientOsUser || (this.ClientOsUser != null && !this.ClientOsUser.Equals(input.ClientOsUser))) return false;
            if (this.ClientPortStr != input.ClientPortStr || (this.ClientPortStr != null && !this.ClientPortStr.Equals(input.ClientPortStr))) return false;
            if (this.ClientTool != input.ClientTool || (this.ClientTool != null && !this.ClientTool.Equals(input.ClientTool))) return false;
            if (this.DbPort != input.DbPort || (this.DbPort != null && !this.DbPort.Equals(input.DbPort))) return false;
            if (this.DbInstance != input.DbInstance || (this.DbInstance != null && !this.DbInstance.Equals(input.DbInstance))) return false;
            if (this.DbIp != input.DbIp || (this.DbIp != null && !this.DbIp.Equals(input.DbIp))) return false;
            if (this.DbMac != input.DbMac || (this.DbMac != null && !this.DbMac.Equals(input.DbMac))) return false;
            if (this.DbPortStr != input.DbPortStr || (this.DbPortStr != null && !this.DbPortStr.Equals(input.DbPortStr))) return false;
            if (this.DbServiceName != input.DbServiceName || (this.DbServiceName != null && !this.DbServiceName.Equals(input.DbServiceName))) return false;
            if (this.DbSessionId != input.DbSessionId || (this.DbSessionId != null && !this.DbSessionId.Equals(input.DbSessionId))) return false;
            if (this.DbType != input.DbType || (this.DbType != null && !this.DbType.Equals(input.DbType))) return false;
            if (this.DbUser != input.DbUser || (this.DbUser != null && !this.DbUser.Equals(input.DbUser))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ExecuteTime != input.ExecuteTime || (this.ExecuteTime != null && !this.ExecuteTime.Equals(input.ExecuteTime))) return false;
            if (this.Field != input.Field || (this.Field != null && !this.Field.Equals(input.Field))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.Lines != input.Lines || (this.Lines != null && !this.Lines.Equals(input.Lines))) return false;
            if (this.LogResult != input.LogResult || (this.LogResult != null && !this.LogResult.Equals(input.LogResult))) return false;
            if (this.Object != input.Object || (this.Object != null && !this.Object.Equals(input.Object))) return false;
            if (this.ObjectType != input.ObjectType || (this.ObjectType != null && !this.ObjectType.Equals(input.ObjectType))) return false;
            if (this.QueryId != input.QueryId || (this.QueryId != null && !this.QueryId.Equals(input.QueryId))) return false;
            if (this.QueryType != input.QueryType || (this.QueryType != null && !this.QueryType.Equals(input.QueryType))) return false;
            if (this.ResponseLength != input.ResponseLength || (this.ResponseLength != null && !this.ResponseLength.Equals(input.ResponseLength))) return false;
            if (this.ResponseStatus != input.ResponseStatus || (this.ResponseStatus != null && !this.ResponseStatus.Equals(input.ResponseStatus))) return false;
            if (this.RuleId != input.RuleId || (this.RuleId != null && !this.RuleId.Equals(input.RuleId))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.RuleType != input.RuleType || (this.RuleType != null && !this.RuleType.Equals(input.RuleType))) return false;
            if (this.Schema != input.Schema || (this.Schema != null && !this.Schema.Equals(input.Schema))) return false;
            if (this.ScopeId != input.ScopeId || (this.ScopeId != null && !this.ScopeId.Equals(input.ScopeId))) return false;
            if (this.ScopeName != input.ScopeName || (this.ScopeName != null && !this.ScopeName.Equals(input.ScopeName))) return false;
            if (this.SqlResponse != input.SqlResponse || (this.SqlResponse != null && !this.SqlResponse.Equals(input.SqlResponse))) return false;
            if (this.SqlResult != input.SqlResult || (this.SqlResult != null && !this.SqlResult.Equals(input.SqlResult))) return false;
            if (this.SqlStatement != input.SqlStatement || (this.SqlStatement != null && !this.SqlStatement.Equals(input.SqlStatement))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.TcpSessionId != input.TcpSessionId || (this.TcpSessionId != null && !this.TcpSessionId.Equals(input.TcpSessionId))) return false;

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
                if (this.AuditResult != null) hashCode = hashCode * 59 + this.AuditResult.GetHashCode();
                if (this.ClientPort != null) hashCode = hashCode * 59 + this.ClientPort.GetHashCode();
                if (this.ClientIp != null) hashCode = hashCode * 59 + this.ClientIp.GetHashCode();
                if (this.ClientMac != null) hashCode = hashCode * 59 + this.ClientMac.GetHashCode();
                if (this.ClientName != null) hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                if (this.ClientOsName != null) hashCode = hashCode * 59 + this.ClientOsName.GetHashCode();
                if (this.ClientOsUser != null) hashCode = hashCode * 59 + this.ClientOsUser.GetHashCode();
                if (this.ClientPortStr != null) hashCode = hashCode * 59 + this.ClientPortStr.GetHashCode();
                if (this.ClientTool != null) hashCode = hashCode * 59 + this.ClientTool.GetHashCode();
                if (this.DbPort != null) hashCode = hashCode * 59 + this.DbPort.GetHashCode();
                if (this.DbInstance != null) hashCode = hashCode * 59 + this.DbInstance.GetHashCode();
                if (this.DbIp != null) hashCode = hashCode * 59 + this.DbIp.GetHashCode();
                if (this.DbMac != null) hashCode = hashCode * 59 + this.DbMac.GetHashCode();
                if (this.DbPortStr != null) hashCode = hashCode * 59 + this.DbPortStr.GetHashCode();
                if (this.DbServiceName != null) hashCode = hashCode * 59 + this.DbServiceName.GetHashCode();
                if (this.DbSessionId != null) hashCode = hashCode * 59 + this.DbSessionId.GetHashCode();
                if (this.DbType != null) hashCode = hashCode * 59 + this.DbType.GetHashCode();
                if (this.DbUser != null) hashCode = hashCode * 59 + this.DbUser.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ExecuteTime != null) hashCode = hashCode * 59 + this.ExecuteTime.GetHashCode();
                if (this.Field != null) hashCode = hashCode * 59 + this.Field.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Lines != null) hashCode = hashCode * 59 + this.Lines.GetHashCode();
                if (this.LogResult != null) hashCode = hashCode * 59 + this.LogResult.GetHashCode();
                if (this.Object != null) hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.ObjectType != null) hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.QueryId != null) hashCode = hashCode * 59 + this.QueryId.GetHashCode();
                if (this.QueryType != null) hashCode = hashCode * 59 + this.QueryType.GetHashCode();
                if (this.ResponseLength != null) hashCode = hashCode * 59 + this.ResponseLength.GetHashCode();
                if (this.ResponseStatus != null) hashCode = hashCode * 59 + this.ResponseStatus.GetHashCode();
                if (this.RuleId != null) hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.RuleType != null) hashCode = hashCode * 59 + this.RuleType.GetHashCode();
                if (this.Schema != null) hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.ScopeId != null) hashCode = hashCode * 59 + this.ScopeId.GetHashCode();
                if (this.ScopeName != null) hashCode = hashCode * 59 + this.ScopeName.GetHashCode();
                if (this.SqlResponse != null) hashCode = hashCode * 59 + this.SqlResponse.GetHashCode();
                if (this.SqlResult != null) hashCode = hashCode * 59 + this.SqlResult.GetHashCode();
                if (this.SqlStatement != null) hashCode = hashCode * 59 + this.SqlStatement.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.TcpSessionId != null) hashCode = hashCode * 59 + this.TcpSessionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
