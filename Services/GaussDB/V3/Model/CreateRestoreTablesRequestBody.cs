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
    /// 
    /// </summary>
    public class CreateRestoreTablesRequestBody 
    {

        /// <summary>
        /// 备份时间点，时间戳格式。
        /// </summary>
        [JsonProperty("restore_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// 是否是最新库表。默认为false。 - true：是最新库表。 - false：是恢复时间点库表。
        /// </summary>
        [JsonProperty("last_table_info", NullValueHandling = NullValueHandling.Ignore)]
        public string LastTableInfo { get; set; }

        /// <summary>
        /// 数据库信息。
        /// </summary>
        [JsonProperty("restore_tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateRestoreDatabaseTableInfo> RestoreTables { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRestoreTablesRequestBody {\n");
            sb.Append("  restoreTime: ").Append(RestoreTime).Append("\n");
            sb.Append("  lastTableInfo: ").Append(LastTableInfo).Append("\n");
            sb.Append("  restoreTables: ").Append(RestoreTables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRestoreTablesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRestoreTablesRequestBody input)
        {
            if (input == null) return false;
            if (this.RestoreTime != input.RestoreTime || (this.RestoreTime != null && !this.RestoreTime.Equals(input.RestoreTime))) return false;
            if (this.LastTableInfo != input.LastTableInfo || (this.LastTableInfo != null && !this.LastTableInfo.Equals(input.LastTableInfo))) return false;
            if (this.RestoreTables != input.RestoreTables || (this.RestoreTables != null && input.RestoreTables != null && !this.RestoreTables.SequenceEqual(input.RestoreTables))) return false;

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
                if (this.RestoreTime != null) hashCode = hashCode * 59 + this.RestoreTime.GetHashCode();
                if (this.LastTableInfo != null) hashCode = hashCode * 59 + this.LastTableInfo.GetHashCode();
                if (this.RestoreTables != null) hashCode = hashCode * 59 + this.RestoreTables.GetHashCode();
                return hashCode;
            }
        }
    }
}
