using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListRocketMqMigrationTaskResponse : SdkResponse
    {

        /// <summary>
        /// 元数据迁移任务总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 元数据迁移任务列表。
        /// </summary>
        [JsonProperty("task", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetadataTask> Task { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRocketMqMigrationTaskResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  task: ").Append(Task).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRocketMqMigrationTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRocketMqMigrationTaskResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Task != input.Task || (this.Task != null && input.Task != null && !this.Task.SequenceEqual(input.Task))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Task != null) hashCode = hashCode * 59 + this.Task.GetHashCode();
                return hashCode;
            }
        }
    }
}
