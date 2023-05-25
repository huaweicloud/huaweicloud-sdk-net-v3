using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListTakeOverTaskRequest 
    {

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。 
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 任务状态。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 任务ID。
        /// </summary>
        [SDKProperty("task_id", IsQuery = true)]
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 分页编号，默认为0。
        /// </summary>
        [SDKProperty("page", IsQuery = true)]
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// 每页记录数。  默认10，范围[1,100]，指定task_id时该参数无效。
        /// </summary>
        [SDKProperty("size", IsQuery = true)]
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTakeOverTaskRequest {\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTakeOverTaskRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTakeOverTaskRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XSdkDate == input.XSdkDate ||
                    (this.XSdkDate != null &&
                    this.XSdkDate.Equals(input.XSdkDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.XSdkDate != null)
                    hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                return hashCode;
            }
        }
    }
}
