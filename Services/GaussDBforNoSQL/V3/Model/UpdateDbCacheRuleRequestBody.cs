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
    /// 修改内存加速规则请求体。
    /// </summary>
    public class UpdateDbCacheRuleRequestBody 
    {

        /// <summary>
        /// 内存加速规则ID。
        /// </summary>
        [JsonProperty("dbcache_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DbcacheRuleId { get; set; }

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
        /// 映射的value分隔符。只允许一个字符。
        /// </summary>
        [JsonProperty("value_separator", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueSeparator { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDbCacheRuleRequestBody {\n");
            sb.Append("  dbcacheRuleId: ").Append(DbcacheRuleId).Append("\n");
            sb.Append("  valueColumns: ").Append(ValueColumns).Append("\n");
            sb.Append("  ttl: ").Append(Ttl).Append("\n");
            sb.Append("  valueSeparator: ").Append(ValueSeparator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDbCacheRuleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDbCacheRuleRequestBody input)
        {
            if (input == null) return false;
            if (this.DbcacheRuleId != input.DbcacheRuleId || (this.DbcacheRuleId != null && !this.DbcacheRuleId.Equals(input.DbcacheRuleId))) return false;
            if (this.ValueColumns != input.ValueColumns || (this.ValueColumns != null && input.ValueColumns != null && !this.ValueColumns.SequenceEqual(input.ValueColumns))) return false;
            if (this.Ttl != input.Ttl || (this.Ttl != null && !this.Ttl.Equals(input.Ttl))) return false;
            if (this.ValueSeparator != input.ValueSeparator || (this.ValueSeparator != null && !this.ValueSeparator.Equals(input.ValueSeparator))) return false;

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
                if (this.DbcacheRuleId != null) hashCode = hashCode * 59 + this.DbcacheRuleId.GetHashCode();
                if (this.ValueColumns != null) hashCode = hashCode * 59 + this.ValueColumns.GetHashCode();
                if (this.Ttl != null) hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                if (this.ValueSeparator != null) hashCode = hashCode * 59 + this.ValueSeparator.GetHashCode();
                return hashCode;
            }
        }
    }
}
