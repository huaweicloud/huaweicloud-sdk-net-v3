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
    /// Response Object
    /// </summary>
    public class ListMergeRequestVersionsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** diff主键ID。    
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** head commit节点。
        /// </summary>
        [JsonProperty("head_commit_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string HeadCommitSha { get; set; }

        /// <summary>
        /// **参数解释：** base commit节点。
        /// </summary>
        [JsonProperty("base_commit_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseCommitSha { get; set; }

        /// <summary>
        /// **参数解释：** tart commit节点。
        /// </summary>
        [JsonProperty("start_commit_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string StartCommitSha { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。 
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** MR主键ID。
        /// </summary>
        [JsonProperty("merge_request_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MergeRequestId { get; set; }

        /// <summary>
        /// **参数解释：** 状态。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释：** diff大小。
        /// </summary>
        [JsonProperty("real_size", NullValueHandling = NullValueHandling.Ignore)]
        public string RealSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMergeRequestVersionsResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  headCommitSha: ").Append(HeadCommitSha).Append("\n");
            sb.Append("  baseCommitSha: ").Append(BaseCommitSha).Append("\n");
            sb.Append("  startCommitSha: ").Append(StartCommitSha).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  mergeRequestId: ").Append(MergeRequestId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  realSize: ").Append(RealSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMergeRequestVersionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMergeRequestVersionsResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.HeadCommitSha != input.HeadCommitSha || (this.HeadCommitSha != null && !this.HeadCommitSha.Equals(input.HeadCommitSha))) return false;
            if (this.BaseCommitSha != input.BaseCommitSha || (this.BaseCommitSha != null && !this.BaseCommitSha.Equals(input.BaseCommitSha))) return false;
            if (this.StartCommitSha != input.StartCommitSha || (this.StartCommitSha != null && !this.StartCommitSha.Equals(input.StartCommitSha))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.MergeRequestId != input.MergeRequestId || (this.MergeRequestId != null && !this.MergeRequestId.Equals(input.MergeRequestId))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.RealSize != input.RealSize || (this.RealSize != null && !this.RealSize.Equals(input.RealSize))) return false;

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
                if (this.HeadCommitSha != null) hashCode = hashCode * 59 + this.HeadCommitSha.GetHashCode();
                if (this.BaseCommitSha != null) hashCode = hashCode * 59 + this.BaseCommitSha.GetHashCode();
                if (this.StartCommitSha != null) hashCode = hashCode * 59 + this.StartCommitSha.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.MergeRequestId != null) hashCode = hashCode * 59 + this.MergeRequestId.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.RealSize != null) hashCode = hashCode * 59 + this.RealSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
