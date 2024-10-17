using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 库配置校验成功返回值。
    /// </summary>
    public class ChDatabaseConfigResponse 
    {

        /// <summary>
        /// 源数据库名称。
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// 源数据库配置检查结果。
        /// </summary>
        [JsonProperty("db_config_check_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChDatabaseConfigCheckResult> DbConfigCheckResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChDatabaseConfigResponse {\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  dbConfigCheckResults: ").Append(DbConfigCheckResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChDatabaseConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChDatabaseConfigResponse input)
        {
            if (input == null) return false;
            if (this.DatabaseName != input.DatabaseName || (this.DatabaseName != null && !this.DatabaseName.Equals(input.DatabaseName))) return false;
            if (this.DbConfigCheckResults != input.DbConfigCheckResults || (this.DbConfigCheckResults != null && input.DbConfigCheckResults != null && !this.DbConfigCheckResults.SequenceEqual(input.DbConfigCheckResults))) return false;

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
                if (this.DatabaseName != null) hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.DbConfigCheckResults != null) hashCode = hashCode * 59 + this.DbConfigCheckResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
