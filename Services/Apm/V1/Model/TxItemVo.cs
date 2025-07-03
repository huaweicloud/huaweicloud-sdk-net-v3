using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// URL跟踪视图。
    /// </summary>
    public class TxItemVo 
    {

        /// <summary>
        /// 组件名称。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 环境名称。
        /// </summary>
        [JsonProperty("env_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvName { get; set; }

        /// <summary>
        /// 事务显示名称。
        /// </summary>
        [JsonProperty("tx_display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TxDisplayName { get; set; }

        /// <summary>
        /// 应用id。
        /// </summary>
        [JsonProperty("business_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BusinessId { get; set; }

        /// <summary>
        /// 环境id。
        /// </summary>
        [JsonProperty("env_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnvId { get; set; }

        /// <summary>
        /// 组件id。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? AppId { get; set; }

        /// <summary>
        /// 事务名称。
        /// </summary>
        [JsonProperty("tx_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TxName { get; set; }

        /// <summary>
        /// 调用次数。
        /// </summary>
        [JsonProperty("invoke_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? InvokeCount { get; set; }

        /// <summary>
        /// 总耗时。
        /// </summary>
        [JsonProperty("total_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalTime { get; set; }

        /// <summary>
        /// 错误次数。
        /// </summary>
        [JsonProperty("error_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ErrorCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TxItemVo {\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  envName: ").Append(EnvName).Append("\n");
            sb.Append("  txDisplayName: ").Append(TxDisplayName).Append("\n");
            sb.Append("  businessId: ").Append(BusinessId).Append("\n");
            sb.Append("  envId: ").Append(EnvId).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  txName: ").Append(TxName).Append("\n");
            sb.Append("  invokeCount: ").Append(InvokeCount).Append("\n");
            sb.Append("  totalTime: ").Append(TotalTime).Append("\n");
            sb.Append("  errorCount: ").Append(ErrorCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TxItemVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TxItemVo input)
        {
            if (input == null) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.EnvName != input.EnvName || (this.EnvName != null && !this.EnvName.Equals(input.EnvName))) return false;
            if (this.TxDisplayName != input.TxDisplayName || (this.TxDisplayName != null && !this.TxDisplayName.Equals(input.TxDisplayName))) return false;
            if (this.BusinessId != input.BusinessId || (this.BusinessId != null && !this.BusinessId.Equals(input.BusinessId))) return false;
            if (this.EnvId != input.EnvId || (this.EnvId != null && !this.EnvId.Equals(input.EnvId))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.TxName != input.TxName || (this.TxName != null && !this.TxName.Equals(input.TxName))) return false;
            if (this.InvokeCount != input.InvokeCount || (this.InvokeCount != null && !this.InvokeCount.Equals(input.InvokeCount))) return false;
            if (this.TotalTime != input.TotalTime || (this.TotalTime != null && !this.TotalTime.Equals(input.TotalTime))) return false;
            if (this.ErrorCount != input.ErrorCount || (this.ErrorCount != null && !this.ErrorCount.Equals(input.ErrorCount))) return false;

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
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.EnvName != null) hashCode = hashCode * 59 + this.EnvName.GetHashCode();
                if (this.TxDisplayName != null) hashCode = hashCode * 59 + this.TxDisplayName.GetHashCode();
                if (this.BusinessId != null) hashCode = hashCode * 59 + this.BusinessId.GetHashCode();
                if (this.EnvId != null) hashCode = hashCode * 59 + this.EnvId.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.TxName != null) hashCode = hashCode * 59 + this.TxName.GetHashCode();
                if (this.InvokeCount != null) hashCode = hashCode * 59 + this.InvokeCount.GetHashCode();
                if (this.TotalTime != null) hashCode = hashCode * 59 + this.TotalTime.GetHashCode();
                if (this.ErrorCount != null) hashCode = hashCode * 59 + this.ErrorCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
