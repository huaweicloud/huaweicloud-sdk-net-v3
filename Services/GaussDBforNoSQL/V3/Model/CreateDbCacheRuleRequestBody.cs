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
    /// 
    /// </summary>
    public class CreateDbCacheRuleRequestBody 
    {

        /// <summary>
        /// 内存加速映射ID。
        /// </summary>
        [JsonProperty("dbcache_mapping_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DbcacheMappingId { get; set; }

        /// <summary>
        /// 内存加速规则名称。不超过256字符，需要确保在当前映射下唯一。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 源端数据库。
        /// </summary>
        [JsonProperty("source_db_schema", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDbSchema { get; set; }

        /// <summary>
        /// 源端数据表。
        /// </summary>
        [JsonProperty("source_db_table", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDbTable { get; set; }

        /// <summary>
        /// 目标数据存储类型。 取值为： hash。
        /// </summary>
        [JsonProperty("storage_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageType { get; set; }

        /// <summary>
        /// 目标数据库。取值范围： [0-999]。
        /// </summary>
        [JsonProperty("target_database", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDatabase { get; set; }

        /// <summary>
        /// 映射的key使用的column列表。
        /// </summary>
        [JsonProperty("key_columns", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> KeyColumns { get; set; }

        /// <summary>
        /// 映射的value使用的column列表。
        /// </summary>
        [JsonProperty("value_columns", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ValueColumns { get; set; }

        /// <summary>
        /// key的生存时间。单位:ms。不传该值，默认取2592000000，表示30天。
        /// </summary>
        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public string Ttl { get; set; }

        /// <summary>
        /// 映射的key分隔符。只允许一个字符。
        /// </summary>
        [JsonProperty("key_separator", NullValueHandling = NullValueHandling.Ignore)]
        public string KeySeparator { get; set; }

        /// <summary>
        /// 映射的value分隔符。只允许一个字符。
        /// </summary>
        [JsonProperty("value_separator", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueSeparator { get; set; }

        /// <summary>
        /// 键前缀。最长限制1024字符。需确保key_prefix和target_database在当前映射下唯一。
        /// </summary>
        [JsonProperty("key_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyPrefix { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDbCacheRuleRequestBody {\n");
            sb.Append("  dbcacheMappingId: ").Append(DbcacheMappingId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sourceDbSchema: ").Append(SourceDbSchema).Append("\n");
            sb.Append("  sourceDbTable: ").Append(SourceDbTable).Append("\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  targetDatabase: ").Append(TargetDatabase).Append("\n");
            sb.Append("  keyColumns: ").Append(KeyColumns).Append("\n");
            sb.Append("  valueColumns: ").Append(ValueColumns).Append("\n");
            sb.Append("  ttl: ").Append(Ttl).Append("\n");
            sb.Append("  keySeparator: ").Append(KeySeparator).Append("\n");
            sb.Append("  valueSeparator: ").Append(ValueSeparator).Append("\n");
            sb.Append("  keyPrefix: ").Append(KeyPrefix).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDbCacheRuleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDbCacheRuleRequestBody input)
        {
            if (input == null) return false;
            if (this.DbcacheMappingId != input.DbcacheMappingId || (this.DbcacheMappingId != null && !this.DbcacheMappingId.Equals(input.DbcacheMappingId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SourceDbSchema != input.SourceDbSchema || (this.SourceDbSchema != null && !this.SourceDbSchema.Equals(input.SourceDbSchema))) return false;
            if (this.SourceDbTable != input.SourceDbTable || (this.SourceDbTable != null && !this.SourceDbTable.Equals(input.SourceDbTable))) return false;
            if (this.StorageType != input.StorageType || (this.StorageType != null && !this.StorageType.Equals(input.StorageType))) return false;
            if (this.TargetDatabase != input.TargetDatabase || (this.TargetDatabase != null && !this.TargetDatabase.Equals(input.TargetDatabase))) return false;
            if (this.KeyColumns != input.KeyColumns || (this.KeyColumns != null && input.KeyColumns != null && !this.KeyColumns.SequenceEqual(input.KeyColumns))) return false;
            if (this.ValueColumns != input.ValueColumns || (this.ValueColumns != null && input.ValueColumns != null && !this.ValueColumns.SequenceEqual(input.ValueColumns))) return false;
            if (this.Ttl != input.Ttl || (this.Ttl != null && !this.Ttl.Equals(input.Ttl))) return false;
            if (this.KeySeparator != input.KeySeparator || (this.KeySeparator != null && !this.KeySeparator.Equals(input.KeySeparator))) return false;
            if (this.ValueSeparator != input.ValueSeparator || (this.ValueSeparator != null && !this.ValueSeparator.Equals(input.ValueSeparator))) return false;
            if (this.KeyPrefix != input.KeyPrefix || (this.KeyPrefix != null && !this.KeyPrefix.Equals(input.KeyPrefix))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SourceDbSchema != null) hashCode = hashCode * 59 + this.SourceDbSchema.GetHashCode();
                if (this.SourceDbTable != null) hashCode = hashCode * 59 + this.SourceDbTable.GetHashCode();
                if (this.StorageType != null) hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                if (this.TargetDatabase != null) hashCode = hashCode * 59 + this.TargetDatabase.GetHashCode();
                if (this.KeyColumns != null) hashCode = hashCode * 59 + this.KeyColumns.GetHashCode();
                if (this.ValueColumns != null) hashCode = hashCode * 59 + this.ValueColumns.GetHashCode();
                if (this.Ttl != null) hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                if (this.KeySeparator != null) hashCode = hashCode * 59 + this.KeySeparator.GetHashCode();
                if (this.ValueSeparator != null) hashCode = hashCode * 59 + this.ValueSeparator.GetHashCode();
                if (this.KeyPrefix != null) hashCode = hashCode * 59 + this.KeyPrefix.GetHashCode();
                return hashCode;
            }
        }
    }
}
