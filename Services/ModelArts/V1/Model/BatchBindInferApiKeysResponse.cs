using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchBindInferApiKeysResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 请求绑定apikey总个数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释：** 绑定apikey成功个数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("success_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// **参数解释：** 绑定成功的apikey列表。
        /// </summary>
        [JsonProperty("success_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApiKeyResponseV2> SuccessItems { get; set; }

        /// <summary>
        /// **参数解释：** 绑定apikey失败个数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("failure_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailureCount { get; set; }

        /// <summary>
        /// **参数解释：** 绑定失败的apikey列表。
        /// </summary>
        [JsonProperty("failure_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApiKeyFailureResponse> FailureItems { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchBindInferApiKeysResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  successCount: ").Append(SuccessCount).Append("\n");
            sb.Append("  successItems: ").Append(SuccessItems).Append("\n");
            sb.Append("  failureCount: ").Append(FailureCount).Append("\n");
            sb.Append("  failureItems: ").Append(FailureItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchBindInferApiKeysResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchBindInferApiKeysResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.SuccessCount != input.SuccessCount || (this.SuccessCount != null && !this.SuccessCount.Equals(input.SuccessCount))) return false;
            if (this.SuccessItems != input.SuccessItems || (this.SuccessItems != null && input.SuccessItems != null && !this.SuccessItems.SequenceEqual(input.SuccessItems))) return false;
            if (this.FailureCount != input.FailureCount || (this.FailureCount != null && !this.FailureCount.Equals(input.FailureCount))) return false;
            if (this.FailureItems != input.FailureItems || (this.FailureItems != null && input.FailureItems != null && !this.FailureItems.SequenceEqual(input.FailureItems))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.SuccessCount != null) hashCode = hashCode * 59 + this.SuccessCount.GetHashCode();
                if (this.SuccessItems != null) hashCode = hashCode * 59 + this.SuccessItems.GetHashCode();
                if (this.FailureCount != null) hashCode = hashCode * 59 + this.FailureCount.GetHashCode();
                if (this.FailureItems != null) hashCode = hashCode * 59 + this.FailureItems.GetHashCode();
                return hashCode;
            }
        }
    }
}
