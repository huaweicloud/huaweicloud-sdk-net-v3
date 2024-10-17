using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// PostgreSQL查询可恢复库的数据库库信息
    /// </summary>
    public class HistoryDatabaseInfo 
    {

        /// <summary>
        /// 数据库名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 表的个数
        /// </summary>
        [JsonProperty("total_tables", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalTables { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryDatabaseInfo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  totalTables: ").Append(TotalTables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HistoryDatabaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HistoryDatabaseInfo input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.TotalTables != input.TotalTables || (this.TotalTables != null && !this.TotalTables.Equals(input.TotalTables))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TotalTables != null) hashCode = hashCode * 59 + this.TotalTables.GetHashCode();
                return hashCode;
            }
        }
    }
}
