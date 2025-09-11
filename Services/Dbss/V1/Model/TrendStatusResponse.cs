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
    public class TrendStatusResponse 
    {

        /// <summary>
        /// 数据库ID
        /// </summary>
        [JsonProperty("db_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DbId { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 生成时间
        /// </summary>
        [JsonProperty("generate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string GenerateTime { get; set; }

        /// <summary>
        /// 统计类型  - RISK: 风险  - SESSION：SESSION  - SQL: SQL  - COUNT: 数量  - INJECTION：注入 - OPERATION: 操作
        /// </summary>
        [JsonProperty("statistics_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StatisticsType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrendStatusResponse {\n");
            sb.Append("  dbId: ").Append(DbId).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  generateTime: ").Append(GenerateTime).Append("\n");
            sb.Append("  statisticsType: ").Append(StatisticsType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrendStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrendStatusResponse input)
        {
            if (input == null) return false;
            if (this.DbId != input.DbId || (this.DbId != null && !this.DbId.Equals(input.DbId))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.GenerateTime != input.GenerateTime || (this.GenerateTime != null && !this.GenerateTime.Equals(input.GenerateTime))) return false;
            if (this.StatisticsType != input.StatisticsType || (this.StatisticsType != null && !this.StatisticsType.Equals(input.StatisticsType))) return false;

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
                if (this.DbId != null) hashCode = hashCode * 59 + this.DbId.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.GenerateTime != null) hashCode = hashCode * 59 + this.GenerateTime.GetHashCode();
                if (this.StatisticsType != null) hashCode = hashCode * 59 + this.StatisticsType.GetHashCode();
                return hashCode;
            }
        }
    }
}
