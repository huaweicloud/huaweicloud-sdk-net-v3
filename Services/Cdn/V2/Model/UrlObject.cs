using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UrlObject 
    {

        /// <summary>
        /// url的id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// url的地址。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// url的状态 processing 处理中，succeed 完成，failed 失败，waiting 等待，refreshing 刷新中，preheating 预热中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// url创建时间，相对于UTC 1970-01-01到当前时间相隔的毫秒数。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务的类型， 其值可以为REFRESH：刷新任务、PREHEATING：预热任务、REFRESH_AFTER_PREHEATING：预热后刷新
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskType { get; set; }

        /// <summary>
        /// 失败原因，url状态为failed时返回。   - ORIGIN_ERROR：源站错误。   - INNER_ERROR：内部错误。   - UNKNOWN_ERROR：未知错误。
        /// </summary>
        [JsonProperty("fail_classify", NullValueHandling = NullValueHandling.Ignore)]
        public string FailClassify { get; set; }

        /// <summary>
        /// 刷新预热失败描述。
        /// </summary>
        [JsonProperty("fail_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string FailDesc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UrlObject {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  failClassify: ").Append(FailClassify).Append("\n");
            sb.Append("  failDesc: ").Append(FailDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UrlObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UrlObject input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskType != input.TaskType || (this.TaskType != null && !this.TaskType.Equals(input.TaskType))) return false;
            if (this.FailClassify != input.FailClassify || (this.FailClassify != null && !this.FailClassify.Equals(input.FailClassify))) return false;
            if (this.FailDesc != input.FailDesc || (this.FailDesc != null && !this.FailDesc.Equals(input.FailDesc))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskType != null) hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.FailClassify != null) hashCode = hashCode * 59 + this.FailClassify.GetHashCode();
                if (this.FailDesc != null) hashCode = hashCode * 59 + this.FailDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
