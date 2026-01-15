using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 回放异常SQL数据项
    /// </summary>
    public class ReplayErrorSqlTemplateResp 
    {

        /// <summary>
        /// SQL模板
        /// </summary>
        [JsonProperty("sql_template", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlTemplate { get; set; }

        /// <summary>
        /// SQL模板MD5
        /// </summary>
        [JsonProperty("sql_template_md5", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlTemplateMd5 { get; set; }

        /// <summary>
        /// 目标库昵称
        /// </summary>
        [JsonProperty("target_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetName { get; set; }

        /// <summary>
        /// schema名称
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// SQL类型 取值：SELECT, INSERT, DELETE, UPDATE, DDL
        /// </summary>
        [JsonProperty("query_type", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryType { get; set; }

        /// <summary>
        /// 目标库类型 取值：mysql,taurusha,sqlserver,postgresql,ddm,mongodb,awsdocumentdb,hwmongodb,hwpostgresql,oracle,taurus,gaussdb,kafka,mrsKafka,cassandra,dynamo,dws,gaussdbv5,gaussdbv5ha,gaussmongodb,multigaussdbv5,dmq,gaussdbt,gaussdbtha,gaussdb300,elasticsearch,db2,tidb,redis,gaussredis,rediscluster,mariadb,oceanbase,informix,gaussdbv1,gausscassandra,geminidynamo,dds,tauruslite
        /// </summary>
        [JsonProperty("target_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetType { get; set; }

        /// <summary>
        /// 归类的SQL数量
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplayErrorSqlTemplateResp {\n");
            sb.Append("  sqlTemplate: ").Append(SqlTemplate).Append("\n");
            sb.Append("  sqlTemplateMd5: ").Append(SqlTemplateMd5).Append("\n");
            sb.Append("  targetName: ").Append(TargetName).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  queryType: ").Append(QueryType).Append("\n");
            sb.Append("  targetType: ").Append(TargetType).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplayErrorSqlTemplateResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplayErrorSqlTemplateResp input)
        {
            if (input == null) return false;
            if (this.SqlTemplate != input.SqlTemplate || (this.SqlTemplate != null && !this.SqlTemplate.Equals(input.SqlTemplate))) return false;
            if (this.SqlTemplateMd5 != input.SqlTemplateMd5 || (this.SqlTemplateMd5 != null && !this.SqlTemplateMd5.Equals(input.SqlTemplateMd5))) return false;
            if (this.TargetName != input.TargetName || (this.TargetName != null && !this.TargetName.Equals(input.TargetName))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.QueryType != input.QueryType || (this.QueryType != null && !this.QueryType.Equals(input.QueryType))) return false;
            if (this.TargetType != input.TargetType || (this.TargetType != null && !this.TargetType.Equals(input.TargetType))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;

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
                if (this.SqlTemplate != null) hashCode = hashCode * 59 + this.SqlTemplate.GetHashCode();
                if (this.SqlTemplateMd5 != null) hashCode = hashCode * 59 + this.SqlTemplateMd5.GetHashCode();
                if (this.TargetName != null) hashCode = hashCode * 59 + this.TargetName.GetHashCode();
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.QueryType != null) hashCode = hashCode * 59 + this.QueryType.GetHashCode();
                if (this.TargetType != null) hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
