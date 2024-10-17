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
    /// Response Object
    /// </summary>
    public class ListFunctionAsyncInvokeConfigResponse : SdkResponse
    {

        /// <summary>
        /// 函数异步配置列表。
        /// </summary>
        [JsonProperty("async_invoke_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListFunctionAsyncInvokeConfigResult> AsyncInvokeConfigs { get; set; }

        /// <summary>
        /// 列表总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFunctionAsyncInvokeConfigResponse {\n");
            sb.Append("  asyncInvokeConfigs: ").Append(AsyncInvokeConfigs).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFunctionAsyncInvokeConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFunctionAsyncInvokeConfigResponse input)
        {
            if (input == null) return false;
            if (this.AsyncInvokeConfigs != input.AsyncInvokeConfigs || (this.AsyncInvokeConfigs != null && input.AsyncInvokeConfigs != null && !this.AsyncInvokeConfigs.SequenceEqual(input.AsyncInvokeConfigs))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.AsyncInvokeConfigs != null) hashCode = hashCode * 59 + this.AsyncInvokeConfigs.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
