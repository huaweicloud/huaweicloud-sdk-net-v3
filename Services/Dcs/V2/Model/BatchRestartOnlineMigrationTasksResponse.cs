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
    public class BatchRestartOnlineMigrationTasksResponse : SdkResponse
    {

        /// <summary>
        /// 数据迁移任务列表。
        /// </summary>
        [JsonProperty("migration_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchRestartMigrationTaskResult> MigrationTasks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchRestartOnlineMigrationTasksResponse {\n");
            sb.Append("  migrationTasks: ").Append(MigrationTasks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchRestartOnlineMigrationTasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchRestartOnlineMigrationTasksResponse input)
        {
            if (input == null) return false;
            if (this.MigrationTasks != input.MigrationTasks || (this.MigrationTasks != null && input.MigrationTasks != null && !this.MigrationTasks.SequenceEqual(input.MigrationTasks))) return false;

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
                if (this.MigrationTasks != null) hashCode = hashCode * 59 + this.MigrationTasks.GetHashCode();
                return hashCode;
            }
        }
    }
}
