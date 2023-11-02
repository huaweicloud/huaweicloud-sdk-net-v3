using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 修改自动扫描配置
    /// </summary>
    public class UpdateAutoScanConfigRequestBody 
    {

        /// <summary>
        /// 启用自动扫描
        /// </summary>
        [JsonProperty("enable_auto_scan", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoScan { get; set; }

        /// <summary>
        /// 首次扫描时间，例如：2023-07-07T15:00:05.000
        /// </summary>
        [JsonProperty("first_scan_at", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstScanAt { get; set; }

        /// <summary>
        /// 间隔时间(秒)
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// 超时时间(秒)
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// 扫描密钥计数
        /// </summary>
        [JsonProperty("scan_keys_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScanKeysCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAutoScanConfigRequestBody {\n");
            sb.Append("  enableAutoScan: ").Append(EnableAutoScan).Append("\n");
            sb.Append("  firstScanAt: ").Append(FirstScanAt).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  scanKeysCount: ").Append(ScanKeysCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAutoScanConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAutoScanConfigRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableAutoScan == input.EnableAutoScan ||
                    (this.EnableAutoScan != null &&
                    this.EnableAutoScan.Equals(input.EnableAutoScan))
                ) && 
                (
                    this.FirstScanAt == input.FirstScanAt ||
                    (this.FirstScanAt != null &&
                    this.FirstScanAt.Equals(input.FirstScanAt))
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.ScanKeysCount == input.ScanKeysCount ||
                    (this.ScanKeysCount != null &&
                    this.ScanKeysCount.Equals(input.ScanKeysCount))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.EnableAutoScan != null)
                    hashCode = hashCode * 59 + this.EnableAutoScan.GetHashCode();
                if (this.FirstScanAt != null)
                    hashCode = hashCode * 59 + this.FirstScanAt.GetHashCode();
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.ScanKeysCount != null)
                    hashCode = hashCode * 59 + this.ScanKeysCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
