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
    public class RuleScopeRequest 
    {

        /// <summary>
        /// 操作类型，多个用英文,分隔
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 数据库ID，多个用英文逗号分隔，全部传[ALL]
        /// </summary>
        [JsonProperty("db_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string DbIds { get; set; }

        /// <summary>
        /// 数据库名称，多个用英文逗号分隔，全部传[全部数据库]
        /// </summary>
        [JsonProperty("db_names", NullValueHandling = NullValueHandling.Ignore)]
        public string DbNames { get; set; }

        /// <summary>
        /// 数据库账号，多个用英文逗号分隔
        /// </summary>
        [JsonProperty("db_users", NullValueHandling = NullValueHandling.Ignore)]
        public string DbUsers { get; set; }

        /// <summary>
        /// 例外IP，多个用英文逗号分隔
        /// </summary>
        [JsonProperty("exception_ips", NullValueHandling = NullValueHandling.Ignore)]
        public string ExceptionIps { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// 源IP，多个用英文逗号分隔
        /// </summary>
        [JsonProperty("source_ips", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIps { get; set; }

        /// <summary>
        /// 源端口，多个用英文逗号分隔
        /// </summary>
        [JsonProperty("source_ports", NullValueHandling = NullValueHandling.Ignore)]
        public string SourcePorts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleScopeRequest {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  dbIds: ").Append(DbIds).Append("\n");
            sb.Append("  dbNames: ").Append(DbNames).Append("\n");
            sb.Append("  dbUsers: ").Append(DbUsers).Append("\n");
            sb.Append("  exceptionIps: ").Append(ExceptionIps).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  sourceIps: ").Append(SourceIps).Append("\n");
            sb.Append("  sourcePorts: ").Append(SourcePorts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleScopeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleScopeRequest input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.DbIds != input.DbIds || (this.DbIds != null && !this.DbIds.Equals(input.DbIds))) return false;
            if (this.DbNames != input.DbNames || (this.DbNames != null && !this.DbNames.Equals(input.DbNames))) return false;
            if (this.DbUsers != input.DbUsers || (this.DbUsers != null && !this.DbUsers.Equals(input.DbUsers))) return false;
            if (this.ExceptionIps != input.ExceptionIps || (this.ExceptionIps != null && !this.ExceptionIps.Equals(input.ExceptionIps))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.SourceIps != input.SourceIps || (this.SourceIps != null && !this.SourceIps.Equals(input.SourceIps))) return false;
            if (this.SourcePorts != input.SourcePorts || (this.SourcePorts != null && !this.SourcePorts.Equals(input.SourcePorts))) return false;

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
                if (this.DbIds != null) hashCode = hashCode * 59 + this.DbIds.GetHashCode();
                if (this.DbNames != null) hashCode = hashCode * 59 + this.DbNames.GetHashCode();
                if (this.DbUsers != null) hashCode = hashCode * 59 + this.DbUsers.GetHashCode();
                if (this.ExceptionIps != null) hashCode = hashCode * 59 + this.ExceptionIps.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.SourceIps != null) hashCode = hashCode * 59 + this.SourceIps.GetHashCode();
                if (this.SourcePorts != null) hashCode = hashCode * 59 + this.SourcePorts.GetHashCode();
                return hashCode;
            }
        }
    }
}
