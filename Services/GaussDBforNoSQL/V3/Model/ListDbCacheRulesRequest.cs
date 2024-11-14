using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListDbCacheRulesRequest 
    {

        /// <summary>
        /// 内存加速映射ID。
        /// </summary>
        [SDKProperty("dbcache_mapping_id", IsQuery = true)]
        [JsonProperty("dbcache_mapping_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DbcacheMappingId { get; set; }

        /// <summary>
        /// 内存加速规则ID。
        /// </summary>
        [SDKProperty("rule_id", IsQuery = true)]
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// 内存加速规则名称。名称以“*”起始，表示按照“*”后面的值模糊匹配，否则，按照实际填写的名称精确匹配查询。
        /// </summary>
        [SDKProperty("rule_name", IsQuery = true)]
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// 源端数据库名。名称以“*”起始，表示按照“*”后面的值模糊匹配，否则，按照实际填写的名称精确匹配查询。
        /// </summary>
        [SDKProperty("source_db_schema", IsQuery = true)]
        [JsonProperty("source_db_schema", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDbSchema { get; set; }

        /// <summary>
        /// 源端数据表名。名称以“*”起始，表示按照“*”后面的值模糊匹配，否则，按照实际填写的名称精确匹配查询。
        /// </summary>
        [SDKProperty("source_db_table", IsQuery = true)]
        [JsonProperty("source_db_table", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDbTable { get; set; }

        /// <summary>
        /// 索引位置，偏移量。 从第一条数据偏移offset条数据后开始查询，默认为0（偏移0条数据，表示从第一条数据开始查询）。 取值必须为数字，不能为负数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// 查询个数上限值。取值范围：1~100。不传该参数时，默认查询前100条信息。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDbCacheRulesRequest {\n");
            sb.Append("  dbcacheMappingId: ").Append(DbcacheMappingId).Append("\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  sourceDbSchema: ").Append(SourceDbSchema).Append("\n");
            sb.Append("  sourceDbTable: ").Append(SourceDbTable).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDbCacheRulesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDbCacheRulesRequest input)
        {
            if (input == null) return false;
            if (this.DbcacheMappingId != input.DbcacheMappingId || (this.DbcacheMappingId != null && !this.DbcacheMappingId.Equals(input.DbcacheMappingId))) return false;
            if (this.RuleId != input.RuleId || (this.RuleId != null && !this.RuleId.Equals(input.RuleId))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.SourceDbSchema != input.SourceDbSchema || (this.SourceDbSchema != null && !this.SourceDbSchema.Equals(input.SourceDbSchema))) return false;
            if (this.SourceDbTable != input.SourceDbTable || (this.SourceDbTable != null && !this.SourceDbTable.Equals(input.SourceDbTable))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.DbcacheMappingId != null) hashCode = hashCode * 59 + this.DbcacheMappingId.GetHashCode();
                if (this.RuleId != null) hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.SourceDbSchema != null) hashCode = hashCode * 59 + this.SourceDbSchema.GetHashCode();
                if (this.SourceDbTable != null) hashCode = hashCode * 59 + this.SourceDbTable.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
