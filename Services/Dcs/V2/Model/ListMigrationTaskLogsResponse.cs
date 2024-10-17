using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListMigrationTaskLogsResponse : SdkResponse
    {

        /// <summary>
        /// 日志条数
        /// </summary>
        [JsonProperty("log_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? LogNum { get; set; }

        /// <summary>
        /// 日志列表
        /// </summary>
        [JsonProperty("migration_logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<MigrationLog> MigrationLogs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMigrationTaskLogsResponse {\n");
            sb.Append("  logNum: ").Append(LogNum).Append("\n");
            sb.Append("  migrationLogs: ").Append(MigrationLogs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMigrationTaskLogsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMigrationTaskLogsResponse input)
        {
            if (input == null) return false;
            if (this.LogNum != input.LogNum || (this.LogNum != null && !this.LogNum.Equals(input.LogNum))) return false;
            if (this.MigrationLogs != input.MigrationLogs || (this.MigrationLogs != null && input.MigrationLogs != null && !this.MigrationLogs.SequenceEqual(input.MigrationLogs))) return false;

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
                if (this.LogNum != null) hashCode = hashCode * 59 + this.LogNum.GetHashCode();
                if (this.MigrationLogs != null) hashCode = hashCode * 59 + this.MigrationLogs.GetHashCode();
                return hashCode;
            }
        }
    }
}
