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
    public class ShowAverageEvaluationResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 合并请求id。
        /// </summary>
        [JsonProperty("merge_request_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MergeRequestId { get; set; }

        /// <summary>
        /// **参数解释：** 评价平均分。
        /// </summary>
        [JsonProperty("average_evaluation_level", NullValueHandling = NullValueHandling.Ignore)]
        public double? AverageEvaluationLevel { get; set; }

        /// <summary>
        /// **参数解释：** 单人评价详情。
        /// </summary>
        [JsonProperty("evaluations", NullValueHandling = NullValueHandling.Ignore)]
        public List<MergeRequestBaseEvaluationDto> Evaluations { get; set; }

        /// <summary>
        /// **参数解释：** 自定义评价维度详情。
        /// </summary>
        [JsonProperty("custom_evaluations", NullValueHandling = NullValueHandling.Ignore)]
        public List<MergeRequestCustomAverageEvaluationDto> CustomEvaluations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAverageEvaluationResponse {\n");
            sb.Append("  mergeRequestId: ").Append(MergeRequestId).Append("\n");
            sb.Append("  averageEvaluationLevel: ").Append(AverageEvaluationLevel).Append("\n");
            sb.Append("  evaluations: ").Append(Evaluations).Append("\n");
            sb.Append("  customEvaluations: ").Append(CustomEvaluations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAverageEvaluationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAverageEvaluationResponse input)
        {
            if (input == null) return false;
            if (this.MergeRequestId != input.MergeRequestId || (this.MergeRequestId != null && !this.MergeRequestId.Equals(input.MergeRequestId))) return false;
            if (this.AverageEvaluationLevel != input.AverageEvaluationLevel || (this.AverageEvaluationLevel != null && !this.AverageEvaluationLevel.Equals(input.AverageEvaluationLevel))) return false;
            if (this.Evaluations != input.Evaluations || (this.Evaluations != null && input.Evaluations != null && !this.Evaluations.SequenceEqual(input.Evaluations))) return false;
            if (this.CustomEvaluations != input.CustomEvaluations || (this.CustomEvaluations != null && input.CustomEvaluations != null && !this.CustomEvaluations.SequenceEqual(input.CustomEvaluations))) return false;

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
                if (this.MergeRequestId != null) hashCode = hashCode * 59 + this.MergeRequestId.GetHashCode();
                if (this.AverageEvaluationLevel != null) hashCode = hashCode * 59 + this.AverageEvaluationLevel.GetHashCode();
                if (this.Evaluations != null) hashCode = hashCode * 59 + this.Evaluations.GetHashCode();
                if (this.CustomEvaluations != null) hashCode = hashCode * 59 + this.CustomEvaluations.GetHashCode();
                return hashCode;
            }
        }
    }
}
