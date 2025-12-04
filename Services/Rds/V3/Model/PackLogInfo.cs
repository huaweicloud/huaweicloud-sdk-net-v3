using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// binlog合并下载文件信息
    /// </summary>
    public class PackLogInfo 
    {

        /// <summary>
        /// **参数解释**：  文件唯一ID标识。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：  实例id。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  文件大小。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public double? Size { get; set; }

        /// <summary>
        /// **参数解释**：  文件大小单位。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("size_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string SizeUnit { get; set; }

        /// <summary>
        /// **参数解释**：  状态。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：  合并时间段起始时间戳。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("query_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? QueryStartTime { get; set; }

        /// <summary>
        /// **参数解释**：  合并时间段结束时间戳。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("query_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? QueryEndTime { get; set; }

        /// <summary>
        /// **参数解释**：  文件名。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackLogInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  sizeUnit: ").Append(SizeUnit).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  queryStartTime: ").Append(QueryStartTime).Append("\n");
            sb.Append("  queryEndTime: ").Append(QueryEndTime).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PackLogInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PackLogInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.SizeUnit != input.SizeUnit || (this.SizeUnit != null && !this.SizeUnit.Equals(input.SizeUnit))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.QueryStartTime != input.QueryStartTime || (this.QueryStartTime != null && !this.QueryStartTime.Equals(input.QueryStartTime))) return false;
            if (this.QueryEndTime != input.QueryEndTime || (this.QueryEndTime != null && !this.QueryEndTime.Equals(input.QueryEndTime))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.SizeUnit != null) hashCode = hashCode * 59 + this.SizeUnit.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.QueryStartTime != null) hashCode = hashCode * 59 + this.QueryStartTime.GetHashCode();
                if (this.QueryEndTime != null) hashCode = hashCode * 59 + this.QueryEndTime.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                return hashCode;
            }
        }
    }
}
