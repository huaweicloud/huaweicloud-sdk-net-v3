using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateTransferRequestBody 
    {

        /// <summary>
        /// 日志转储ID
        /// </summary>
        [JsonProperty("log_transfer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogTransferId { get; set; }

        /// <summary>
        /// 日志组ID
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_transfer_info", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateTransferRequestBodyLogTransferInfo LogTransferInfo { get; set; }

        /// <summary>
        /// 日志流信息
        /// </summary>
        [JsonProperty("log_streams", NullValueHandling = NullValueHandling.Ignore)]
        public List<LogStreams> LogStreams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTransferRequestBody {\n");
            sb.Append("  logTransferId: ").Append(LogTransferId).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logTransferInfo: ").Append(LogTransferInfo).Append("\n");
            sb.Append("  logStreams: ").Append(LogStreams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTransferRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTransferRequestBody input)
        {
            if (input == null) return false;
            if (this.LogTransferId != input.LogTransferId || (this.LogTransferId != null && !this.LogTransferId.Equals(input.LogTransferId))) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && !this.LogGroupId.Equals(input.LogGroupId))) return false;
            if (this.LogTransferInfo != input.LogTransferInfo || (this.LogTransferInfo != null && !this.LogTransferInfo.Equals(input.LogTransferInfo))) return false;
            if (this.LogStreams != input.LogStreams || (this.LogStreams != null && input.LogStreams != null && !this.LogStreams.SequenceEqual(input.LogStreams))) return false;

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
                if (this.LogTransferId != null) hashCode = hashCode * 59 + this.LogTransferId.GetHashCode();
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogTransferInfo != null) hashCode = hashCode * 59 + this.LogTransferInfo.GetHashCode();
                if (this.LogStreams != null) hashCode = hashCode * 59 + this.LogStreams.GetHashCode();
                return hashCode;
            }
        }
    }
}
