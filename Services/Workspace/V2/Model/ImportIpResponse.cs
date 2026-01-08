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
    public class ImportIpResponse : SdkResponse
    {

        /// <summary>
        /// ip成功列表。
        /// </summary>
        [JsonProperty("ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImportIpInfo> IpList { get; set; }

        /// <summary>
        /// ip失败列表。
        /// </summary>
        [JsonProperty("failed_ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImportIpInfo> FailedIpList { get; set; }

        /// <summary>
        /// 错误码。
        /// </summary>
        [JsonProperty("failed_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedCode { get; set; }

        /// <summary>
        /// 错误码。
        /// </summary>
        [JsonProperty("failed_message", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedMessage { get; set; }

        /// <summary>
        /// ip列表数量。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportIpResponse {\n");
            sb.Append("  ipList: ").Append(IpList).Append("\n");
            sb.Append("  failedIpList: ").Append(FailedIpList).Append("\n");
            sb.Append("  failedCode: ").Append(FailedCode).Append("\n");
            sb.Append("  failedMessage: ").Append(FailedMessage).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportIpResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportIpResponse input)
        {
            if (input == null) return false;
            if (this.IpList != input.IpList || (this.IpList != null && input.IpList != null && !this.IpList.SequenceEqual(input.IpList))) return false;
            if (this.FailedIpList != input.FailedIpList || (this.FailedIpList != null && input.FailedIpList != null && !this.FailedIpList.SequenceEqual(input.FailedIpList))) return false;
            if (this.FailedCode != input.FailedCode || (this.FailedCode != null && !this.FailedCode.Equals(input.FailedCode))) return false;
            if (this.FailedMessage != input.FailedMessage || (this.FailedMessage != null && !this.FailedMessage.Equals(input.FailedMessage))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.IpList != null) hashCode = hashCode * 59 + this.IpList.GetHashCode();
                if (this.FailedIpList != null) hashCode = hashCode * 59 + this.FailedIpList.GetHashCode();
                if (this.FailedCode != null) hashCode = hashCode * 59 + this.FailedCode.GetHashCode();
                if (this.FailedMessage != null) hashCode = hashCode * 59 + this.FailedMessage.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
