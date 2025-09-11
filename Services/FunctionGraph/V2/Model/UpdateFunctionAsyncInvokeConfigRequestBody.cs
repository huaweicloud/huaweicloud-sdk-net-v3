using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 函数异步配置请求体。
    /// </summary>
    public class UpdateFunctionAsyncInvokeConfigRequestBody 
    {

        /// <summary>
        /// 消息最大存活时长，取值范围[1，86400]，单位：秒，默认值为3600。
        /// </summary>
        [JsonProperty("max_async_event_age_in_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxAsyncEventAgeInSeconds { get; set; }

        /// <summary>
        /// 异步调用失败后的最大重试次数，默认值为1。取值范围[0，3]。
        /// </summary>
        [JsonProperty("max_async_retry_attempts", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxAsyncRetryAttempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("destination_config", NullValueHandling = NullValueHandling.Ignore)]
        public FuncAsyncDestinationConfig DestinationConfig { get; set; }

        /// <summary>
        /// 开启异步调用状态持久化
        /// </summary>
        [JsonProperty("enable_async_status_log", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAsyncStatusLog { get; set; }

        /// <summary>
        /// 自定义日志查询组id。
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 自定义日志查询流id。
        /// </summary>
        [JsonProperty("log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }

        /// <summary>
        /// 自定义日志查询组名称。
        /// </summary>
        [JsonProperty("log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// 自定义日志查询流名称。
        /// </summary>
        [JsonProperty("log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFunctionAsyncInvokeConfigRequestBody {\n");
            sb.Append("  maxAsyncEventAgeInSeconds: ").Append(MaxAsyncEventAgeInSeconds).Append("\n");
            sb.Append("  maxAsyncRetryAttempts: ").Append(MaxAsyncRetryAttempts).Append("\n");
            sb.Append("  destinationConfig: ").Append(DestinationConfig).Append("\n");
            sb.Append("  enableAsyncStatusLog: ").Append(EnableAsyncStatusLog).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("  logGroupName: ").Append(LogGroupName).Append("\n");
            sb.Append("  logStreamName: ").Append(LogStreamName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateFunctionAsyncInvokeConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateFunctionAsyncInvokeConfigRequestBody input)
        {
            if (input == null) return false;
            if (this.MaxAsyncEventAgeInSeconds != input.MaxAsyncEventAgeInSeconds || (this.MaxAsyncEventAgeInSeconds != null && !this.MaxAsyncEventAgeInSeconds.Equals(input.MaxAsyncEventAgeInSeconds))) return false;
            if (this.MaxAsyncRetryAttempts != input.MaxAsyncRetryAttempts || (this.MaxAsyncRetryAttempts != null && !this.MaxAsyncRetryAttempts.Equals(input.MaxAsyncRetryAttempts))) return false;
            if (this.DestinationConfig != input.DestinationConfig || (this.DestinationConfig != null && !this.DestinationConfig.Equals(input.DestinationConfig))) return false;
            if (this.EnableAsyncStatusLog != input.EnableAsyncStatusLog || (this.EnableAsyncStatusLog != null && !this.EnableAsyncStatusLog.Equals(input.EnableAsyncStatusLog))) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && !this.LogGroupId.Equals(input.LogGroupId))) return false;
            if (this.LogStreamId != input.LogStreamId || (this.LogStreamId != null && !this.LogStreamId.Equals(input.LogStreamId))) return false;
            if (this.LogGroupName != input.LogGroupName || (this.LogGroupName != null && !this.LogGroupName.Equals(input.LogGroupName))) return false;
            if (this.LogStreamName != input.LogStreamName || (this.LogStreamName != null && !this.LogStreamName.Equals(input.LogStreamName))) return false;

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
                if (this.MaxAsyncEventAgeInSeconds != null) hashCode = hashCode * 59 + this.MaxAsyncEventAgeInSeconds.GetHashCode();
                if (this.MaxAsyncRetryAttempts != null) hashCode = hashCode * 59 + this.MaxAsyncRetryAttempts.GetHashCode();
                if (this.DestinationConfig != null) hashCode = hashCode * 59 + this.DestinationConfig.GetHashCode();
                if (this.EnableAsyncStatusLog != null) hashCode = hashCode * 59 + this.EnableAsyncStatusLog.GetHashCode();
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogStreamId != null) hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                if (this.LogGroupName != null) hashCode = hashCode * 59 + this.LogGroupName.GetHashCode();
                if (this.LogStreamName != null) hashCode = hashCode * 59 + this.LogStreamName.GetHashCode();
                return hashCode;
            }
        }
    }
}
