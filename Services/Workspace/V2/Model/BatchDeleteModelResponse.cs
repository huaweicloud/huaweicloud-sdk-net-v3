using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchDeleteModelResponse : SdkResponse
    {

        /// <summary>
        /// 删除数量。
        /// </summary>
        [JsonProperty("deleted_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeletedCount { get; set; }

        /// <summary>
        /// 失败数量。
        /// </summary>
        [JsonProperty("failed_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedCount { get; set; }

        /// <summary>
        /// 失败详情列表。
        /// </summary>
        [JsonProperty("failed_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<ModelBatchDeleteRespFailedDetails> FailedDetails { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteModelResponse {\n");
            sb.Append("  deletedCount: ").Append(DeletedCount).Append("\n");
            sb.Append("  failedCount: ").Append(FailedCount).Append("\n");
            sb.Append("  failedDetails: ").Append(FailedDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteModelResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteModelResponse input)
        {
            if (input == null) return false;
            if (this.DeletedCount != input.DeletedCount || (this.DeletedCount != null && !this.DeletedCount.Equals(input.DeletedCount))) return false;
            if (this.FailedCount != input.FailedCount || (this.FailedCount != null && !this.FailedCount.Equals(input.FailedCount))) return false;
            if (this.FailedDetails != input.FailedDetails || (this.FailedDetails != null && input.FailedDetails != null && !this.FailedDetails.SequenceEqual(input.FailedDetails))) return false;

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
                if (this.DeletedCount != null) hashCode = hashCode * 59 + this.DeletedCount.GetHashCode();
                if (this.FailedCount != null) hashCode = hashCode * 59 + this.FailedCount.GetHashCode();
                if (this.FailedDetails != null) hashCode = hashCode * 59 + this.FailedDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
