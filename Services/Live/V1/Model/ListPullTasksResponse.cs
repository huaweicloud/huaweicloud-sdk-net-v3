using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListPullTasksResponse : SdkResponse
    {

        /// <summary>
        /// 直播拉流任务列表
        /// </summary>
        [JsonProperty("task_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<LivePullTaskInfo> TaskInfos { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 任务条目数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPullTasksResponse {\n");
            sb.Append("  taskInfos: ").Append(TaskInfos).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPullTasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPullTasksResponse input)
        {
            if (input == null) return false;
            if (this.TaskInfos != input.TaskInfos || (this.TaskInfos != null && input.TaskInfos != null && !this.TaskInfos.SequenceEqual(input.TaskInfos))) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;
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
                if (this.TaskInfos != null) hashCode = hashCode * 59 + this.TaskInfos.GetHashCode();
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
