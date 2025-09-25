using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 检视意见位置详情。
    /// </summary>
    public class PositionDto 
    {

        /// <summary>
        /// **参数解释：** 基础sha值。
        /// </summary>
        [JsonProperty("base_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseSha { get; set; }

        /// <summary>
        /// **参数解释：** 起始sha值。
        /// </summary>
        [JsonProperty("start_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string StartSha { get; set; }

        /// <summary>
        /// **参数解释：** 最新sha值。
        /// </summary>
        [JsonProperty("head_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string HeadSha { get; set; }

        /// <summary>
        /// **参数解释：** 文件旧路径。
        /// </summary>
        [JsonProperty("old_path", NullValueHandling = NullValueHandling.Ignore)]
        public string OldPath { get; set; }

        /// <summary>
        /// **参数解释：** 文件新路径。
        /// </summary>
        [JsonProperty("new_path", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPath { get; set; }

        /// <summary>
        /// **参数解释：** 文件类型。
        /// </summary>
        [JsonProperty("position_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PositionType { get; set; }

        /// <summary>
        /// **参数解释：** 旧文件行号。
        /// </summary>
        [JsonProperty("old_line", NullValueHandling = NullValueHandling.Ignore)]
        public int? OldLine { get; set; }

        /// <summary>
        /// **参数解释：** 新文件行号。
        /// </summary>
        [JsonProperty("new_line", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewLine { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PositionDto {\n");
            sb.Append("  baseSha: ").Append(BaseSha).Append("\n");
            sb.Append("  startSha: ").Append(StartSha).Append("\n");
            sb.Append("  headSha: ").Append(HeadSha).Append("\n");
            sb.Append("  oldPath: ").Append(OldPath).Append("\n");
            sb.Append("  newPath: ").Append(NewPath).Append("\n");
            sb.Append("  positionType: ").Append(PositionType).Append("\n");
            sb.Append("  oldLine: ").Append(OldLine).Append("\n");
            sb.Append("  newLine: ").Append(NewLine).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PositionDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PositionDto input)
        {
            if (input == null) return false;
            if (this.BaseSha != input.BaseSha || (this.BaseSha != null && !this.BaseSha.Equals(input.BaseSha))) return false;
            if (this.StartSha != input.StartSha || (this.StartSha != null && !this.StartSha.Equals(input.StartSha))) return false;
            if (this.HeadSha != input.HeadSha || (this.HeadSha != null && !this.HeadSha.Equals(input.HeadSha))) return false;
            if (this.OldPath != input.OldPath || (this.OldPath != null && !this.OldPath.Equals(input.OldPath))) return false;
            if (this.NewPath != input.NewPath || (this.NewPath != null && !this.NewPath.Equals(input.NewPath))) return false;
            if (this.PositionType != input.PositionType || (this.PositionType != null && !this.PositionType.Equals(input.PositionType))) return false;
            if (this.OldLine != input.OldLine || (this.OldLine != null && !this.OldLine.Equals(input.OldLine))) return false;
            if (this.NewLine != input.NewLine || (this.NewLine != null && !this.NewLine.Equals(input.NewLine))) return false;

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
                if (this.BaseSha != null) hashCode = hashCode * 59 + this.BaseSha.GetHashCode();
                if (this.StartSha != null) hashCode = hashCode * 59 + this.StartSha.GetHashCode();
                if (this.HeadSha != null) hashCode = hashCode * 59 + this.HeadSha.GetHashCode();
                if (this.OldPath != null) hashCode = hashCode * 59 + this.OldPath.GetHashCode();
                if (this.NewPath != null) hashCode = hashCode * 59 + this.NewPath.GetHashCode();
                if (this.PositionType != null) hashCode = hashCode * 59 + this.PositionType.GetHashCode();
                if (this.OldLine != null) hashCode = hashCode * 59 + this.OldLine.GetHashCode();
                if (this.NewLine != null) hashCode = hashCode * 59 + this.NewLine.GetHashCode();
                return hashCode;
            }
        }
    }
}
