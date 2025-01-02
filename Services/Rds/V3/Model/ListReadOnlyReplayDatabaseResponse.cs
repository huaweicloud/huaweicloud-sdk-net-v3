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
    /// Response Object
    /// </summary>
    public class ListReadOnlyReplayDatabaseResponse : SdkResponse
    {

        /// <summary>
        /// 每次返回的库上限数量
        /// </summary>
        [JsonProperty("database_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? DatabaseLimit { get; set; }

        /// <summary>
        /// 返回的总表数量
        /// </summary>
        [JsonProperty("total_tables", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalTables { get; set; }

        /// <summary>
        /// 每次返回的表上限数量
        /// </summary>
        [JsonProperty("table_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? TableLimit { get; set; }

        /// <summary>
        /// 可恢复到主实例的数据库列表
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public List<DelayRestoreDatabase> Databases { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListReadOnlyReplayDatabaseResponse {\n");
            sb.Append("  databaseLimit: ").Append(DatabaseLimit).Append("\n");
            sb.Append("  totalTables: ").Append(TotalTables).Append("\n");
            sb.Append("  tableLimit: ").Append(TableLimit).Append("\n");
            sb.Append("  databases: ").Append(Databases).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListReadOnlyReplayDatabaseResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListReadOnlyReplayDatabaseResponse input)
        {
            if (input == null) return false;
            if (this.DatabaseLimit != input.DatabaseLimit || (this.DatabaseLimit != null && !this.DatabaseLimit.Equals(input.DatabaseLimit))) return false;
            if (this.TotalTables != input.TotalTables || (this.TotalTables != null && !this.TotalTables.Equals(input.TotalTables))) return false;
            if (this.TableLimit != input.TableLimit || (this.TableLimit != null && !this.TableLimit.Equals(input.TableLimit))) return false;
            if (this.Databases != input.Databases || (this.Databases != null && input.Databases != null && !this.Databases.SequenceEqual(input.Databases))) return false;

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
                if (this.DatabaseLimit != null) hashCode = hashCode * 59 + this.DatabaseLimit.GetHashCode();
                if (this.TotalTables != null) hashCode = hashCode * 59 + this.TotalTables.GetHashCode();
                if (this.TableLimit != null) hashCode = hashCode * 59 + this.TableLimit.GetHashCode();
                if (this.Databases != null) hashCode = hashCode * 59 + this.Databases.GetHashCode();
                return hashCode;
            }
        }
    }
}
