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
    /// 批量重启在线迁移任务结构体
    /// </summary>
    public class BatchRestartOnlineMigrationTasksBody 
    {

        /// <summary>
        /// 数据迁移任务列表。
        /// </summary>
        [JsonProperty("migration_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MigrationTasks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchRestartOnlineMigrationTasksBody {\n");
            sb.Append("  migrationTasks: ").Append(MigrationTasks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchRestartOnlineMigrationTasksBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchRestartOnlineMigrationTasksBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MigrationTasks == input.MigrationTasks ||
                    this.MigrationTasks != null &&
                    input.MigrationTasks != null &&
                    this.MigrationTasks.SequenceEqual(input.MigrationTasks)
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
                if (this.MigrationTasks != null)
                    hashCode = hashCode * 59 + this.MigrationTasks.GetHashCode();
                return hashCode;
            }
        }
    }
}
