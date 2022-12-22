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
    /// Request Object
    /// </summary>
    public class ListAsyncInvocationsRequest 
    {

        /// <summary>
        /// 函数URN
        /// </summary>
        [SDKProperty("function_urn", IsPath = true)]
        [JsonProperty("function_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionUrn { get; set; }

        /// <summary>
        /// 需要查询的异步请求ID。如果不指定，默认查询所有异步调用记录
        /// </summary>
        [SDKProperty("request_id", IsQuery = true)]
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 本次查询起始位置，默认值0
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 本次查询最大返回的数据条数，最大值500，默认值100
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// 本次查询指定的异步调用状态，支持5种状态，如果不指定，则查询所有状态的调用记录 WAIT: 等待 RUNNING: 执行中 SUCCESS: 执行成功 FAIL: 执行失败 DISCARD: 请求丢弃
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 搜索起始时间（格式为YYYY-MM-DD&#39;T&#39;HH:mm:ss,UTC时间）。如果不指定默认为当前时间前1小时
        /// </summary>
        [SDKProperty("query_begin_time", IsQuery = true)]
        [JsonProperty("query_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? QueryBeginTime { get; set; }

        /// <summary>
        /// 搜索结束时间（格式为YYYY-MM-DD&#39;T&#39;HH:mm:ss,UTC时间）。如果不指定默认为当前时间
        /// </summary>
        [SDKProperty("query_end_time", IsQuery = true)]
        [JsonProperty("query_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? QueryEndTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAsyncInvocationsRequest {\n");
            sb.Append("  functionUrn: ").Append(FunctionUrn).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  queryBeginTime: ").Append(QueryBeginTime).Append("\n");
            sb.Append("  queryEndTime: ").Append(QueryEndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAsyncInvocationsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAsyncInvocationsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FunctionUrn == input.FunctionUrn ||
                    (this.FunctionUrn != null &&
                    this.FunctionUrn.Equals(input.FunctionUrn))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.QueryBeginTime == input.QueryBeginTime ||
                    (this.QueryBeginTime != null &&
                    this.QueryBeginTime.Equals(input.QueryBeginTime))
                ) && 
                (
                    this.QueryEndTime == input.QueryEndTime ||
                    (this.QueryEndTime != null &&
                    this.QueryEndTime.Equals(input.QueryEndTime))
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
                if (this.FunctionUrn != null)
                    hashCode = hashCode * 59 + this.FunctionUrn.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.QueryBeginTime != null)
                    hashCode = hashCode * 59 + this.QueryBeginTime.GetHashCode();
                if (this.QueryEndTime != null)
                    hashCode = hashCode * 59 + this.QueryEndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
