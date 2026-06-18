using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// **参数解释：** 代码导航功模式信息
    /// </summary>
    public class SchemaDto 
    {

        /// <summary>
        /// **参数解释：** 代码导航版本。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释：** 支持的最大文件大小。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("maximum_file_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaximumFileSize { get; set; }

        /// <summary>
        /// **参数解释：** 支持的最大行数。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("maximum_line_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaximumLineLength { get; set; }

        /// <summary>
        /// **参数解释：** 每行支持的最大字符数，超过将截断。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("maximum_truncate_line", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaximumTruncateLine { get; set; }

        /// <summary>
        /// **参数解释：** 索引创建时间。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateAt { get; set; }

        /// <summary>
        /// **参数解释：** 索引更新时间。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateAt { get; set; }

        /// <summary>
        /// **参数解释：** 索引重建时间。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("rebuild_at", NullValueHandling = NullValueHandling.Ignore)]
        public string RebuildAt { get; set; }

        /// <summary>
        /// **参数解释：** 索引最近构建时间。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("last_build_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LastBuildAt { get; set; }

        /// <summary>
        /// **参数解释：** 索引构建次数。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("build_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? BuildTimes { get; set; }

        /// <summary>
        /// **参数解释：** 请求次数。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("query_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryTimes { get; set; }

        /// <summary>
        /// **参数解释：** 索引大纲请求次数。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("outline_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? OutlineTimes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchemaDto {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  maximumFileSize: ").Append(MaximumFileSize).Append("\n");
            sb.Append("  maximumLineLength: ").Append(MaximumLineLength).Append("\n");
            sb.Append("  maximumTruncateLine: ").Append(MaximumTruncateLine).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  rebuildAt: ").Append(RebuildAt).Append("\n");
            sb.Append("  lastBuildAt: ").Append(LastBuildAt).Append("\n");
            sb.Append("  buildTimes: ").Append(BuildTimes).Append("\n");
            sb.Append("  queryTimes: ").Append(QueryTimes).Append("\n");
            sb.Append("  outlineTimes: ").Append(OutlineTimes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SchemaDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SchemaDto input)
        {
            if (input == null) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.MaximumFileSize != input.MaximumFileSize || (this.MaximumFileSize != null && !this.MaximumFileSize.Equals(input.MaximumFileSize))) return false;
            if (this.MaximumLineLength != input.MaximumLineLength || (this.MaximumLineLength != null && !this.MaximumLineLength.Equals(input.MaximumLineLength))) return false;
            if (this.MaximumTruncateLine != input.MaximumTruncateLine || (this.MaximumTruncateLine != null && !this.MaximumTruncateLine.Equals(input.MaximumTruncateLine))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.RebuildAt != input.RebuildAt || (this.RebuildAt != null && !this.RebuildAt.Equals(input.RebuildAt))) return false;
            if (this.LastBuildAt != input.LastBuildAt || (this.LastBuildAt != null && !this.LastBuildAt.Equals(input.LastBuildAt))) return false;
            if (this.BuildTimes != input.BuildTimes || (this.BuildTimes != null && !this.BuildTimes.Equals(input.BuildTimes))) return false;
            if (this.QueryTimes != input.QueryTimes || (this.QueryTimes != null && !this.QueryTimes.Equals(input.QueryTimes))) return false;
            if (this.OutlineTimes != input.OutlineTimes || (this.OutlineTimes != null && !this.OutlineTimes.Equals(input.OutlineTimes))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.MaximumFileSize != null) hashCode = hashCode * 59 + this.MaximumFileSize.GetHashCode();
                if (this.MaximumLineLength != null) hashCode = hashCode * 59 + this.MaximumLineLength.GetHashCode();
                if (this.MaximumTruncateLine != null) hashCode = hashCode * 59 + this.MaximumTruncateLine.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.RebuildAt != null) hashCode = hashCode * 59 + this.RebuildAt.GetHashCode();
                if (this.LastBuildAt != null) hashCode = hashCode * 59 + this.LastBuildAt.GetHashCode();
                if (this.BuildTimes != null) hashCode = hashCode * 59 + this.BuildTimes.GetHashCode();
                if (this.QueryTimes != null) hashCode = hashCode * 59 + this.QueryTimes.GetHashCode();
                if (this.OutlineTimes != null) hashCode = hashCode * 59 + this.OutlineTimes.GetHashCode();
                return hashCode;
            }
        }
    }
}
