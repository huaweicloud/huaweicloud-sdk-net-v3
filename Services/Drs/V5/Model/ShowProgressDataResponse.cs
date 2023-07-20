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
    public class ShowProgressDataResponse : SdkResponse
    {

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        /// <summary>
        /// 数据生成时间，UTC时间，例如：2020-09-01T18:50:20.200Z
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 对比结果。
        /// </summary>
        [JsonProperty("flow_compare_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlowCompareData> FlowCompareData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProgressDataResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  flowCompareData: ").Append(FlowCompareData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProgressDataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProgressDataResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.FlowCompareData == input.FlowCompareData ||
                    this.FlowCompareData != null &&
                    input.FlowCompareData != null &&
                    this.FlowCompareData.SequenceEqual(input.FlowCompareData)
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.FlowCompareData != null)
                    hashCode = hashCode * 59 + this.FlowCompareData.GetHashCode();
                return hashCode;
            }
        }
    }
}
