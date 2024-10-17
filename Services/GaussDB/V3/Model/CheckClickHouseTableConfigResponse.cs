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
    /// Response Object
    /// </summary>
    public class CheckClickHouseTableConfigResponse : SdkResponse
    {

        /// <summary>
        /// 源数据库名。
        /// </summary>
        [JsonProperty("source_database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDatabaseName { get; set; }

        /// <summary>
        /// 表配置检查结果。
        /// </summary>
        [JsonProperty("table_config_check_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChDatabaseTableConfigCheckResult> TableConfigCheckResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckClickHouseTableConfigResponse {\n");
            sb.Append("  sourceDatabaseName: ").Append(SourceDatabaseName).Append("\n");
            sb.Append("  tableConfigCheckResults: ").Append(TableConfigCheckResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckClickHouseTableConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckClickHouseTableConfigResponse input)
        {
            if (input == null) return false;
            if (this.SourceDatabaseName != input.SourceDatabaseName || (this.SourceDatabaseName != null && !this.SourceDatabaseName.Equals(input.SourceDatabaseName))) return false;
            if (this.TableConfigCheckResults != input.TableConfigCheckResults || (this.TableConfigCheckResults != null && input.TableConfigCheckResults != null && !this.TableConfigCheckResults.SequenceEqual(input.TableConfigCheckResults))) return false;

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
                if (this.SourceDatabaseName != null) hashCode = hashCode * 59 + this.SourceDatabaseName.GetHashCode();
                if (this.TableConfigCheckResults != null) hashCode = hashCode * 59 + this.TableConfigCheckResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
