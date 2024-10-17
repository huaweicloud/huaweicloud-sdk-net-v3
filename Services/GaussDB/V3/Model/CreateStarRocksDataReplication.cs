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
    /// StarRocks创建数据同步请求。
    /// </summary>
    public class CreateStarRocksDataReplication 
    {

        /// <summary>
        /// GaussDB(for MySQL)实例ID。
        /// </summary>
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// GaussDB(for MySQL)只读节点ID。如为空，则取GaussDB(for MySQL)主节点ID
        /// </summary>
        [JsonProperty("source_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceNodeId { get; set; }

        /// <summary>
        /// 源数据库。
        /// </summary>
        [JsonProperty("source_database", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDatabase { get; set; }

        /// <summary>
        /// 目标数据库。 字符长度限制3~128位，仅支持英文大小写字母、数字以及下划线_。
        /// </summary>
        [JsonProperty("target_database", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDatabase { get; set; }

        /// <summary>
        /// 同步任务名。 字符长度限制3~128位，仅支持英文大小写字母、数字以及下划线_。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateStarRocksDataReplication {\n");
            sb.Append("  sourceInstanceId: ").Append(SourceInstanceId).Append("\n");
            sb.Append("  sourceNodeId: ").Append(SourceNodeId).Append("\n");
            sb.Append("  sourceDatabase: ").Append(SourceDatabase).Append("\n");
            sb.Append("  targetDatabase: ").Append(TargetDatabase).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateStarRocksDataReplication);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateStarRocksDataReplication input)
        {
            if (input == null) return false;
            if (this.SourceInstanceId != input.SourceInstanceId || (this.SourceInstanceId != null && !this.SourceInstanceId.Equals(input.SourceInstanceId))) return false;
            if (this.SourceNodeId != input.SourceNodeId || (this.SourceNodeId != null && !this.SourceNodeId.Equals(input.SourceNodeId))) return false;
            if (this.SourceDatabase != input.SourceDatabase || (this.SourceDatabase != null && !this.SourceDatabase.Equals(input.SourceDatabase))) return false;
            if (this.TargetDatabase != input.TargetDatabase || (this.TargetDatabase != null && !this.TargetDatabase.Equals(input.TargetDatabase))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;

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
                if (this.SourceInstanceId != null) hashCode = hashCode * 59 + this.SourceInstanceId.GetHashCode();
                if (this.SourceNodeId != null) hashCode = hashCode * 59 + this.SourceNodeId.GetHashCode();
                if (this.SourceDatabase != null) hashCode = hashCode * 59 + this.SourceDatabase.GetHashCode();
                if (this.TargetDatabase != null) hashCode = hashCode * 59 + this.TargetDatabase.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                return hashCode;
            }
        }
    }
}
