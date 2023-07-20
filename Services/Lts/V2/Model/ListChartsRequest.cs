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
    /// Request Object
    /// </summary>
    public class ListChartsRequest 
    {

        /// <summary>
        /// 日志组ID
        /// </summary>
        [SDKProperty("log_group_id", IsPath = true)]
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 日志流ID
        /// </summary>
        [SDKProperty("log_stream_id", IsPath = true)]
        [JsonProperty("log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }

        /// <summary>
        /// 查询游标，初始传入0，后续从上一次的返回值中获取
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页数据量，最大值为100
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListChartsRequest {\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListChartsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListChartsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogGroupId == input.LogGroupId ||
                    (this.LogGroupId != null &&
                    this.LogGroupId.Equals(input.LogGroupId))
                ) && 
                (
                    this.LogStreamId == input.LogStreamId ||
                    (this.LogStreamId != null &&
                    this.LogStreamId.Equals(input.LogStreamId))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.LogGroupId != null)
                    hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogStreamId != null)
                    hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
