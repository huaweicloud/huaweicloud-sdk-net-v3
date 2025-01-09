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
    public class EstimateDesktopPoolResizeResponse : SdkResponse
    {

        /// <summary>
        /// 是否为升配
        /// </summary>
        [JsonProperty("is_upgrade", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUpgrade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("batch_inquiry_rsp_when_upgrade", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodBatchUpChangeResourceRsp BatchInquiryRspWhenUpgrade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("batch_inquiry_rsp_when_downgrade", NullValueHandling = NullValueHandling.Ignore)]
        public BatchInquiryChangeRsp BatchInquiryRspWhenDowngrade { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EstimateDesktopPoolResizeResponse {\n");
            sb.Append("  isUpgrade: ").Append(IsUpgrade).Append("\n");
            sb.Append("  batchInquiryRspWhenUpgrade: ").Append(BatchInquiryRspWhenUpgrade).Append("\n");
            sb.Append("  batchInquiryRspWhenDowngrade: ").Append(BatchInquiryRspWhenDowngrade).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EstimateDesktopPoolResizeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EstimateDesktopPoolResizeResponse input)
        {
            if (input == null) return false;
            if (this.IsUpgrade != input.IsUpgrade || (this.IsUpgrade != null && !this.IsUpgrade.Equals(input.IsUpgrade))) return false;
            if (this.BatchInquiryRspWhenUpgrade != input.BatchInquiryRspWhenUpgrade || (this.BatchInquiryRspWhenUpgrade != null && !this.BatchInquiryRspWhenUpgrade.Equals(input.BatchInquiryRspWhenUpgrade))) return false;
            if (this.BatchInquiryRspWhenDowngrade != input.BatchInquiryRspWhenDowngrade || (this.BatchInquiryRspWhenDowngrade != null && !this.BatchInquiryRspWhenDowngrade.Equals(input.BatchInquiryRspWhenDowngrade))) return false;

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
                if (this.IsUpgrade != null) hashCode = hashCode * 59 + this.IsUpgrade.GetHashCode();
                if (this.BatchInquiryRspWhenUpgrade != null) hashCode = hashCode * 59 + this.BatchInquiryRspWhenUpgrade.GetHashCode();
                if (this.BatchInquiryRspWhenDowngrade != null) hashCode = hashCode * 59 + this.BatchInquiryRspWhenDowngrade.GetHashCode();
                return hashCode;
            }
        }
    }
}
