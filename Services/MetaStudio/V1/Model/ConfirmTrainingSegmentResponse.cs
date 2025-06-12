using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ConfirmTrainingSegmentResponse : SdkResponse
    {

        /// <summary>
        /// 是否确认成功。
        /// </summary>
        [JsonProperty("confirm_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConfirmResult { get; set; }

        /// <summary>
        /// 讲解不匹配的文本索引。
        /// </summary>
        [JsonProperty("unmatched_index_hit", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> UnmatchedIndexHit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfirmTrainingSegmentResponse {\n");
            sb.Append("  confirmResult: ").Append(ConfirmResult).Append("\n");
            sb.Append("  unmatchedIndexHit: ").Append(UnmatchedIndexHit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfirmTrainingSegmentResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfirmTrainingSegmentResponse input)
        {
            if (input == null) return false;
            if (this.ConfirmResult != input.ConfirmResult || (this.ConfirmResult != null && !this.ConfirmResult.Equals(input.ConfirmResult))) return false;
            if (this.UnmatchedIndexHit != input.UnmatchedIndexHit || (this.UnmatchedIndexHit != null && input.UnmatchedIndexHit != null && !this.UnmatchedIndexHit.SequenceEqual(input.UnmatchedIndexHit))) return false;

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
                if (this.ConfirmResult != null) hashCode = hashCode * 59 + this.ConfirmResult.GetHashCode();
                if (this.UnmatchedIndexHit != null) hashCode = hashCode * 59 + this.UnmatchedIndexHit.GetHashCode();
                return hashCode;
            }
        }
    }
}
