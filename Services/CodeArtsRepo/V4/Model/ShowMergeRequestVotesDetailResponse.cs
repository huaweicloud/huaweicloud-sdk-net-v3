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
    public class ShowMergeRequestVotesDetailResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 多人合计总分数。
        /// </summary>
        [JsonProperty("scores", NullValueHandling = NullValueHandling.Ignore)]
        public int? Scores { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求id。
        /// </summary>
        [JsonProperty("merge_request_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MergeRequestId { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求作者名。
        /// </summary>
        [JsonProperty("merge_request_creator", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeRequestCreator { get; set; }

        /// <summary>
        /// **参数解释：** 个人打分详情。
        /// </summary>
        [JsonProperty("votes", NullValueHandling = NullValueHandling.Ignore)]
        public List<MergeRequestVotesDto> Votes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMergeRequestVotesDetailResponse {\n");
            sb.Append("  scores: ").Append(Scores).Append("\n");
            sb.Append("  mergeRequestId: ").Append(MergeRequestId).Append("\n");
            sb.Append("  mergeRequestCreator: ").Append(MergeRequestCreator).Append("\n");
            sb.Append("  votes: ").Append(Votes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMergeRequestVotesDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMergeRequestVotesDetailResponse input)
        {
            if (input == null) return false;
            if (this.Scores != input.Scores || (this.Scores != null && !this.Scores.Equals(input.Scores))) return false;
            if (this.MergeRequestId != input.MergeRequestId || (this.MergeRequestId != null && !this.MergeRequestId.Equals(input.MergeRequestId))) return false;
            if (this.MergeRequestCreator != input.MergeRequestCreator || (this.MergeRequestCreator != null && !this.MergeRequestCreator.Equals(input.MergeRequestCreator))) return false;
            if (this.Votes != input.Votes || (this.Votes != null && input.Votes != null && !this.Votes.SequenceEqual(input.Votes))) return false;

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
                if (this.Scores != null) hashCode = hashCode * 59 + this.Scores.GetHashCode();
                if (this.MergeRequestId != null) hashCode = hashCode * 59 + this.MergeRequestId.GetHashCode();
                if (this.MergeRequestCreator != null) hashCode = hashCode * 59 + this.MergeRequestCreator.GetHashCode();
                if (this.Votes != null) hashCode = hashCode * 59 + this.Votes.GetHashCode();
                return hashCode;
            }
        }
    }
}
