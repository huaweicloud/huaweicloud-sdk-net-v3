using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDataProgressResponse : SdkResponse
    {

        /// <summary>
        /// 数据加工规则响应体
        /// </summary>
        [JsonProperty("data_process_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataProcessInfo> DataProcessInfo { get; set; }

        /// <summary>
        /// 数据加工规则总数目
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDataProgressResponse {\n");
            sb.Append("  dataProcessInfo: ").Append(DataProcessInfo).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDataProgressResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDataProgressResponse input)
        {
            if (input == null) return false;
            if (this.DataProcessInfo != input.DataProcessInfo || (this.DataProcessInfo != null && input.DataProcessInfo != null && !this.DataProcessInfo.SequenceEqual(input.DataProcessInfo))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;

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
                if (this.DataProcessInfo != null) hashCode = hashCode * 59 + this.DataProcessInfo.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
