using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowResourceDetailAccessKeyResponseBodyAkList 
    {

        /// <summary>
        /// 成功率
        /// </summary>
        [JsonProperty("success_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? SuccessRate { get; set; }

        /// <summary>
        /// 失败率
        /// </summary>
        [JsonProperty("fail_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? FailRate { get; set; }

        /// <summary>
        /// 成功次数
        /// </summary>
        [JsonProperty("success_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? SuccessCount { get; set; }

        /// <summary>
        /// 总次数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 平均值
        /// </summary>
        [JsonProperty("average_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? AverageValue { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalValue { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 访问密钥ID
        /// </summary>
        [JsonProperty("access_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// 访问密钥名称
        /// </summary>
        [JsonProperty("access_key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKeyName { get; set; }

        /// <summary>
        /// 访问密钥状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 最后访问时间，UNIX时间戳，单位毫秒
        /// </summary>
        [JsonProperty("last_access_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastAccessTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowResourceDetailAccessKeyResponseBodyAkList {\n");
            sb.Append("  successRate: ").Append(SuccessRate).Append("\n");
            sb.Append("  failRate: ").Append(FailRate).Append("\n");
            sb.Append("  successCount: ").Append(SuccessCount).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  averageValue: ").Append(AverageValue).Append("\n");
            sb.Append("  totalValue: ").Append(TotalValue).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  accessKeyId: ").Append(AccessKeyId).Append("\n");
            sb.Append("  accessKeyName: ").Append(AccessKeyName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  lastAccessTime: ").Append(LastAccessTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowResourceDetailAccessKeyResponseBodyAkList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowResourceDetailAccessKeyResponseBodyAkList input)
        {
            if (input == null) return false;
            if (this.SuccessRate != input.SuccessRate || (this.SuccessRate != null && !this.SuccessRate.Equals(input.SuccessRate))) return false;
            if (this.FailRate != input.FailRate || (this.FailRate != null && !this.FailRate.Equals(input.FailRate))) return false;
            if (this.SuccessCount != input.SuccessCount || (this.SuccessCount != null && !this.SuccessCount.Equals(input.SuccessCount))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.AverageValue != input.AverageValue || (this.AverageValue != null && !this.AverageValue.Equals(input.AverageValue))) return false;
            if (this.TotalValue != input.TotalValue || (this.TotalValue != null && !this.TotalValue.Equals(input.TotalValue))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.AccessKeyId != input.AccessKeyId || (this.AccessKeyId != null && !this.AccessKeyId.Equals(input.AccessKeyId))) return false;
            if (this.AccessKeyName != input.AccessKeyName || (this.AccessKeyName != null && !this.AccessKeyName.Equals(input.AccessKeyName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.LastAccessTime != input.LastAccessTime || (this.LastAccessTime != null && !this.LastAccessTime.Equals(input.LastAccessTime))) return false;

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
                if (this.SuccessRate != null) hashCode = hashCode * 59 + this.SuccessRate.GetHashCode();
                if (this.FailRate != null) hashCode = hashCode * 59 + this.FailRate.GetHashCode();
                if (this.SuccessCount != null) hashCode = hashCode * 59 + this.SuccessCount.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.AverageValue != null) hashCode = hashCode * 59 + this.AverageValue.GetHashCode();
                if (this.TotalValue != null) hashCode = hashCode * 59 + this.TotalValue.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.AccessKeyId != null) hashCode = hashCode * 59 + this.AccessKeyId.GetHashCode();
                if (this.AccessKeyName != null) hashCode = hashCode * 59 + this.AccessKeyName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.LastAccessTime != null) hashCode = hashCode * 59 + this.LastAccessTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
