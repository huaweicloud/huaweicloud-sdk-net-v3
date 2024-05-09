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
    /// 数据库校验信息。
    /// </summary>
    public class DataBaseInfo 
    {

        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// 数据库配置检查结果。
        /// </summary>
        [JsonProperty("db_config_check_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<DbConfigCheckResult> DbConfigCheckResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataBaseInfo {\n");
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
            return this.Equals(input as DataBaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataBaseInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatabaseName == input.DatabaseName ||
                    (this.DatabaseName != null &&
                    this.DatabaseName.Equals(input.DatabaseName))
                ) && 
                (
                    this.DbConfigCheckResults == input.DbConfigCheckResults ||
                    this.DbConfigCheckResults != null &&
                    input.DbConfigCheckResults != null &&
                    this.DbConfigCheckResults.SequenceEqual(input.DbConfigCheckResults)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DatabaseName != null)
                    hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.DbConfigCheckResults != null)
                    hashCode = hashCode * 59 + this.DbConfigCheckResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
