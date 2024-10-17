using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListResetTracksTaskResponse : SdkResponse
    {

        /// <summary>
        /// 任务列表
        /// </summary>
        [JsonProperty("task_array", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResetTracksTaskInfo> TaskArray { get; set; }

        /// <summary>
        /// 查询结果是否被截取。 - 1代表被截取，即还有结果未被返回，可以通过设置page和size参数继续查询。 - 0代表未被截取，即所有结果已被返回。 
        /// </summary>
        [JsonProperty("is_truncated", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsTruncated { get; set; }

        /// <summary>
        /// 查询结果的数量。 
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResetTracksTaskResponse {\n");
            sb.Append("  taskArray: ").Append(TaskArray).Append("\n");
            sb.Append("  isTruncated: ").Append(IsTruncated).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResetTracksTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResetTracksTaskResponse input)
        {
            if (input == null) return false;
            if (this.TaskArray != input.TaskArray || (this.TaskArray != null && input.TaskArray != null && !this.TaskArray.SequenceEqual(input.TaskArray))) return false;
            if (this.IsTruncated != input.IsTruncated || (this.IsTruncated != null && !this.IsTruncated.Equals(input.IsTruncated))) return false;
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
                if (this.TaskArray != null) hashCode = hashCode * 59 + this.TaskArray.GetHashCode();
                if (this.IsTruncated != null) hashCode = hashCode * 59 + this.IsTruncated.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
