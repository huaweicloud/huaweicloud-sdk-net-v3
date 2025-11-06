using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MergeResult 
    {

        /// <summary>
        /// 已关闭合并请求数
        /// </summary>
        [JsonProperty("closed", NullValueHandling = NullValueHandling.Ignore)]
        public double? Closed { get; set; }

        /// <summary>
        /// 合并请求详情
        /// </summary>
        [JsonProperty("merge_requests", NullValueHandling = NullValueHandling.Ignore)]
        public List<MergeRequestsItem> MergeRequests { get; set; }

        /// <summary>
        /// 已合并合并请求数数
        /// </summary>
        [JsonProperty("merged", NullValueHandling = NullValueHandling.Ignore)]
        public double? Merged { get; set; }

        /// <summary>
        /// 开启中合并请求数
        /// </summary>
        [JsonProperty("opened", NullValueHandling = NullValueHandling.Ignore)]
        public double? Opened { get; set; }

        /// <summary>
        /// 合并请求总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public double? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeResult {\n");
            sb.Append("  closed: ").Append(Closed).Append("\n");
            sb.Append("  mergeRequests: ").Append(MergeRequests).Append("\n");
            sb.Append("  merged: ").Append(Merged).Append("\n");
            sb.Append("  opened: ").Append(Opened).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeResult input)
        {
            if (input == null) return false;
            if (this.Closed != input.Closed || (this.Closed != null && !this.Closed.Equals(input.Closed))) return false;
            if (this.MergeRequests != input.MergeRequests || (this.MergeRequests != null && input.MergeRequests != null && !this.MergeRequests.SequenceEqual(input.MergeRequests))) return false;
            if (this.Merged != input.Merged || (this.Merged != null && !this.Merged.Equals(input.Merged))) return false;
            if (this.Opened != input.Opened || (this.Opened != null && !this.Opened.Equals(input.Opened))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.Closed != null) hashCode = hashCode * 59 + this.Closed.GetHashCode();
                if (this.MergeRequests != null) hashCode = hashCode * 59 + this.MergeRequests.GetHashCode();
                if (this.Merged != null) hashCode = hashCode * 59 + this.Merged.GetHashCode();
                if (this.Opened != null) hashCode = hashCode * 59 + this.Opened.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
