using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSpecIssueStayTimesResponse : SdkResponse
    {

        /// <summary>
        /// 计算失败的工作项id,一般指未关闭的工作项
        /// </summary>
        [JsonProperty("fails", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fails { get; set; }

        /// <summary>
        /// 工作项时间数据（创建时间-关闭时间）
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListSpecIssueStayTimesResponseBodyData> Data { get; set; }

        /// <summary>
        /// 停留时间求和（单位：秒）
        /// </summary>
        [JsonProperty("total_stay_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalStayTime { get; set; }

        /// <summary>
        /// 停留时间求和的工作项个数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSpecIssueStayTimesResponse {\n");
            sb.Append("  fails: ").Append(Fails).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  totalStayTime: ").Append(TotalStayTime).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSpecIssueStayTimesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSpecIssueStayTimesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fails == input.Fails ||
                    this.Fails != null &&
                    input.Fails != null &&
                    this.Fails.SequenceEqual(input.Fails)
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.TotalStayTime == input.TotalStayTime ||
                    (this.TotalStayTime != null &&
                    this.TotalStayTime.Equals(input.TotalStayTime))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Fails != null)
                    hashCode = hashCode * 59 + this.Fails.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.TotalStayTime != null)
                    hashCode = hashCode * 59 + this.TotalStayTime.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
