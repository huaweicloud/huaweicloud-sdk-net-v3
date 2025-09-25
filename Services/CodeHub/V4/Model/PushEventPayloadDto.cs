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
    /// **参数解释：** 推送动态负载。
    /// </summary>
    public class PushEventPayloadDto 
    {

        /// <summary>
        /// **参数解释：** 提交数量。
        /// </summary>
        [JsonProperty("commit_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CommitCount { get; set; }

        /// <summary>
        /// **参数解释：** 操作类型。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// **参数解释：** ref类型。
        /// </summary>
        [JsonProperty("ref_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RefType { get; set; }

        /// <summary>
        /// **参数解释：** 源Commit。
        /// </summary>
        [JsonProperty("commit_from", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitFrom { get; set; }

        /// <summary>
        /// **参数解释：** 目标Commit。
        /// </summary>
        [JsonProperty("commit_to", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitTo { get; set; }

        /// <summary>
        /// **参数解释：** 分支。
        /// </summary>
        [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
        public string Ref { get; set; }

        /// <summary>
        /// **参数解释：** 提交标题。
        /// </summary>
        [JsonProperty("commit_title", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitTitle { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushEventPayloadDto {\n");
            sb.Append("  commitCount: ").Append(CommitCount).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  refType: ").Append(RefType).Append("\n");
            sb.Append("  commitFrom: ").Append(CommitFrom).Append("\n");
            sb.Append("  commitTo: ").Append(CommitTo).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  commitTitle: ").Append(CommitTitle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PushEventPayloadDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PushEventPayloadDto input)
        {
            if (input == null) return false;
            if (this.CommitCount != input.CommitCount || (this.CommitCount != null && !this.CommitCount.Equals(input.CommitCount))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.RefType != input.RefType || (this.RefType != null && !this.RefType.Equals(input.RefType))) return false;
            if (this.CommitFrom != input.CommitFrom || (this.CommitFrom != null && !this.CommitFrom.Equals(input.CommitFrom))) return false;
            if (this.CommitTo != input.CommitTo || (this.CommitTo != null && !this.CommitTo.Equals(input.CommitTo))) return false;
            if (this.Ref != input.Ref || (this.Ref != null && !this.Ref.Equals(input.Ref))) return false;
            if (this.CommitTitle != input.CommitTitle || (this.CommitTitle != null && !this.CommitTitle.Equals(input.CommitTitle))) return false;

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
                if (this.CommitCount != null) hashCode = hashCode * 59 + this.CommitCount.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.RefType != null) hashCode = hashCode * 59 + this.RefType.GetHashCode();
                if (this.CommitFrom != null) hashCode = hashCode * 59 + this.CommitFrom.GetHashCode();
                if (this.CommitTo != null) hashCode = hashCode * 59 + this.CommitTo.GetHashCode();
                if (this.Ref != null) hashCode = hashCode * 59 + this.Ref.GetHashCode();
                if (this.CommitTitle != null) hashCode = hashCode * 59 + this.CommitTitle.GetHashCode();
                return hashCode;
            }
        }
    }
}
