using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListStackOutputsResponse : SdkResponse
    {

        /// <summary>
        /// 资源栈输出列表
        /// </summary>
        [JsonProperty("outputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<StackOutput> Outputs { get; set; }

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
            sb.Append("class ListStackOutputsResponse {\n");
            sb.Append("  outputs: ").Append(Outputs).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStackOutputsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStackOutputsResponse input)
        {
            if (input == null) return false;
            if (this.Outputs != input.Outputs || (this.Outputs != null && input.Outputs != null && !this.Outputs.SequenceEqual(input.Outputs))) return false;
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
                if (this.Outputs != null) hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
