using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowHistoryTaskDetailsResponse : SdkResponse
    {

        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 任务类型，refresh：刷新任务；preheating：预热任务。
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskType { get; set; }

        /// <summary>
        /// 任务执行结果,task_done:成功，task_inprocess:处理中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 本次提交的url列表。
        /// </summary>
        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<UrlObject> Urls { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 处理中的url个数。
        /// </summary>
        [JsonProperty("processing", NullValueHandling = NullValueHandling.Ignore)]
        public int? Processing { get; set; }

        /// <summary>
        /// 成功处理的url个数。
        /// </summary>
        [JsonProperty("succeed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Succeed { get; set; }

        /// <summary>
        /// 处理失败的url个数。
        /// </summary>
        [JsonProperty("failed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Failed { get; set; }

        /// <summary>
        /// 历史任务的url个数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 文件类型，file：文件；directory：目录，默认是文件file,
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowHistoryTaskDetailsResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  urls: ").Append(Urls).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  processing: ").Append(Processing).Append("\n");
            sb.Append("  succeed: ").Append(Succeed).Append("\n");
            sb.Append("  failed: ").Append(Failed).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowHistoryTaskDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowHistoryTaskDetailsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TaskType == input.TaskType ||
                    (this.TaskType != null &&
                    this.TaskType.Equals(input.TaskType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Urls == input.Urls ||
                    this.Urls != null &&
                    input.Urls != null &&
                    this.Urls.SequenceEqual(input.Urls)
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.Processing == input.Processing ||
                    (this.Processing != null &&
                    this.Processing.Equals(input.Processing))
                ) && 
                (
                    this.Succeed == input.Succeed ||
                    (this.Succeed != null &&
                    this.Succeed.Equals(input.Succeed))
                ) && 
                (
                    this.Failed == input.Failed ||
                    (this.Failed != null &&
                    this.Failed.Equals(input.Failed))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
                ) && 
                (
                    this.XRequestId == input.XRequestId ||
                    (this.XRequestId != null &&
                    this.XRequestId.Equals(input.XRequestId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TaskType != null)
                    hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Urls != null)
                    hashCode = hashCode * 59 + this.Urls.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Processing != null)
                    hashCode = hashCode * 59 + this.Processing.GetHashCode();
                if (this.Succeed != null)
                    hashCode = hashCode * 59 + this.Succeed.GetHashCode();
                if (this.Failed != null)
                    hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.FileType != null)
                    hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.XRequestId != null)
                    hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
