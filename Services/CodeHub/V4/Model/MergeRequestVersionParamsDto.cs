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
    /// 合并请求版本详情。
    /// </summary>
    public class MergeRequestVersionParamsDto 
    {

        /// <summary>
        /// **参数解释：** 版本id(由合并请求id和sha值共同组成)。
        /// </summary>
        [JsonProperty("diff_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiffId { get; set; }

        /// <summary>
        /// **参数解释：** 起始sha值。
        /// </summary>
        [JsonProperty("start_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string StartSha { get; set; }

        /// <summary>
        /// **参数解释：** 提交记录id。
        /// </summary>
        [JsonProperty("commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeRequestVersionParamsDto {\n");
            sb.Append("  diffId: ").Append(DiffId).Append("\n");
            sb.Append("  startSha: ").Append(StartSha).Append("\n");
            sb.Append("  commitId: ").Append(CommitId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeRequestVersionParamsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeRequestVersionParamsDto input)
        {
            if (input == null) return false;
            if (this.DiffId != input.DiffId || (this.DiffId != null && !this.DiffId.Equals(input.DiffId))) return false;
            if (this.StartSha != input.StartSha || (this.StartSha != null && !this.StartSha.Equals(input.StartSha))) return false;
            if (this.CommitId != input.CommitId || (this.CommitId != null && !this.CommitId.Equals(input.CommitId))) return false;

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
                if (this.DiffId != null) hashCode = hashCode * 59 + this.DiffId.GetHashCode();
                if (this.StartSha != null) hashCode = hashCode * 59 + this.StartSha.GetHashCode();
                if (this.CommitId != null) hashCode = hashCode * 59 + this.CommitId.GetHashCode();
                return hashCode;
            }
        }
    }
}
