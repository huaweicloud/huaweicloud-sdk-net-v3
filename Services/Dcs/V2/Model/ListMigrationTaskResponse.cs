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
    public class ListMigrationTaskResponse : SdkResponse
    {

        /// <summary>
        /// 迁移任务数量。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 迁移任务列表。
        /// </summary>
        [JsonProperty("migration_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<MigrationTaskList> MigrationTasks { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMigrationTaskResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  migrationTasks: ").Append(MigrationTasks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMigrationTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMigrationTaskResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.MigrationTasks != null)
                    hashCode = hashCode * 59 + this.MigrationTasks.GetHashCode();
                return hashCode;
            }
        }
    }
}
