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
    public class RuleScopeInfo 
    {

        /// <summary>
        /// 审计范围规则ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 审计范围名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 审计范围动作
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 审计范围规则状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 审计范围例外IP
        /// </summary>
        [JsonProperty("exception_ips", NullValueHandling = NullValueHandling.Ignore)]
        public string ExceptionIps { get; set; }

        /// <summary>
        /// 审计范围规则源IP
        /// </summary>
        [JsonProperty("source_ips", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIps { get; set; }

        /// <summary>
        /// 审计范围源端口
        /// </summary>
        [JsonProperty("source_ports", NullValueHandling = NullValueHandling.Ignore)]
        public string SourcePorts { get; set; }

        /// <summary>
        /// 数据库ID
        /// </summary>
        [JsonProperty("db_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string DbIds { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("db_names", NullValueHandling = NullValueHandling.Ignore)]
        public string DbNames { get; set; }

        /// <summary>
        /// 数据库用户
        /// </summary>
        [JsonProperty("db_users", NullValueHandling = NullValueHandling.Ignore)]
        public string DbUsers { get; set; }

        /// <summary>
        /// 是否全审计
        /// </summary>
        [JsonProperty("all_audit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllAudit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleScopeInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  exceptionIps: ").Append(ExceptionIps).Append("\n");
            sb.Append("  sourceIps: ").Append(SourceIps).Append("\n");
            sb.Append("  sourcePorts: ").Append(SourcePorts).Append("\n");
            sb.Append("  dbIds: ").Append(DbIds).Append("\n");
            sb.Append("  dbNames: ").Append(DbNames).Append("\n");
            sb.Append("  dbUsers: ").Append(DbUsers).Append("\n");
            sb.Append("  allAudit: ").Append(AllAudit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleScopeInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleScopeInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ExceptionIps != input.ExceptionIps || (this.ExceptionIps != null && !this.ExceptionIps.Equals(input.ExceptionIps))) return false;
            if (this.SourceIps != input.SourceIps || (this.SourceIps != null && !this.SourceIps.Equals(input.SourceIps))) return false;
            if (this.SourcePorts != input.SourcePorts || (this.SourcePorts != null && !this.SourcePorts.Equals(input.SourcePorts))) return false;
            if (this.DbIds != input.DbIds || (this.DbIds != null && !this.DbIds.Equals(input.DbIds))) return false;
            if (this.DbNames != input.DbNames || (this.DbNames != null && !this.DbNames.Equals(input.DbNames))) return false;
            if (this.DbUsers != input.DbUsers || (this.DbUsers != null && !this.DbUsers.Equals(input.DbUsers))) return false;
            if (this.AllAudit != input.AllAudit || (this.AllAudit != null && !this.AllAudit.Equals(input.AllAudit))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ExceptionIps != null) hashCode = hashCode * 59 + this.ExceptionIps.GetHashCode();
                if (this.SourceIps != null) hashCode = hashCode * 59 + this.SourceIps.GetHashCode();
                if (this.SourcePorts != null) hashCode = hashCode * 59 + this.SourcePorts.GetHashCode();
                if (this.DbIds != null) hashCode = hashCode * 59 + this.DbIds.GetHashCode();
                if (this.DbNames != null) hashCode = hashCode * 59 + this.DbNames.GetHashCode();
                if (this.DbUsers != null) hashCode = hashCode * 59 + this.DbUsers.GetHashCode();
                if (this.AllAudit != null) hashCode = hashCode * 59 + this.AllAudit.GetHashCode();
                return hashCode;
            }
        }
    }
}
