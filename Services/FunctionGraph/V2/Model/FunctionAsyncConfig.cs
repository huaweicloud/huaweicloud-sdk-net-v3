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
    /// 函数异步配置返回结构体。
    /// </summary>
    public class FunctionAsyncConfig 
    {

        /// <summary>
        /// 消息最大存活时长，取值范围[60，86400]。单位：秒。
        /// </summary>
        [JsonProperty("max_async_event_age_in_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxAsyncEventAgeInSeconds { get; set; }

        /// <summary>
        /// 异步调用失败后的最大重试次数，默认值为3。取值范围[0，8]。
        /// </summary>
        [JsonProperty("max_async_retry_attempts", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxAsyncRetryAttempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("destination_config", NullValueHandling = NullValueHandling.Ignore)]
        public FuncAsyncDestinationConfig DestinationConfig { get; set; }

        /// <summary>
        /// 异步调用配置的创建时间。
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 异步调用配置的最后更改时间。
        /// </summary>
        [JsonProperty("last_modified", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModified { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FunctionAsyncConfig {\n");
            sb.Append("  maxAsyncEventAgeInSeconds: ").Append(MaxAsyncEventAgeInSeconds).Append("\n");
            sb.Append("  maxAsyncRetryAttempts: ").Append(MaxAsyncRetryAttempts).Append("\n");
            sb.Append("  destinationConfig: ").Append(DestinationConfig).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  lastModified: ").Append(LastModified).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FunctionAsyncConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FunctionAsyncConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxAsyncEventAgeInSeconds == input.MaxAsyncEventAgeInSeconds ||
                    (this.MaxAsyncEventAgeInSeconds != null &&
                    this.MaxAsyncEventAgeInSeconds.Equals(input.MaxAsyncEventAgeInSeconds))
                ) && 
                (
                    this.MaxAsyncRetryAttempts == input.MaxAsyncRetryAttempts ||
                    (this.MaxAsyncRetryAttempts != null &&
                    this.MaxAsyncRetryAttempts.Equals(input.MaxAsyncRetryAttempts))
                ) && 
                (
                    this.DestinationConfig == input.DestinationConfig ||
                    (this.DestinationConfig != null &&
                    this.DestinationConfig.Equals(input.DestinationConfig))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
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
                if (this.MaxAsyncEventAgeInSeconds != null)
                    hashCode = hashCode * 59 + this.MaxAsyncEventAgeInSeconds.GetHashCode();
                if (this.MaxAsyncRetryAttempts != null)
                    hashCode = hashCode * 59 + this.MaxAsyncRetryAttempts.GetHashCode();
                if (this.DestinationConfig != null)
                    hashCode = hashCode * 59 + this.DestinationConfig.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                return hashCode;
            }
        }
    }
}
