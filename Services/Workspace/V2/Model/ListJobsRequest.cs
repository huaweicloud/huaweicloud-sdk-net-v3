using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListJobsRequest 
    {

        /// <summary>
        /// 查询的偏移量，默认值0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 单次查询的大小[1-100]，默认值10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 应用ID。
        /// </summary>
        [SDKProperty("app_id", IsQuery = true)]
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 安装实例的用户。
        /// </summary>
        [SDKProperty("target", IsQuery = true)]
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// 任务状态： * &#x60;INIT&#x60; - 初始化中 * &#x60;WAITING&#x60; - 等待安装结束 * &#x60;SUCCESS&#x60; - 成功 * &#x60;FAIL&#x60; - 失败任务状态
        /// </summary>
        [SDKProperty("job_status", IsQuery = true)]
        [JsonProperty("job_status", NullValueHandling = NullValueHandling.Ignore)]
        public string JobStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListJobsRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  target: ").Append(Target).Append("\n");
            sb.Append("  jobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListJobsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListJobsRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.Target != input.Target || (this.Target != null && !this.Target.Equals(input.Target))) return false;
            if (this.JobStatus != input.JobStatus || (this.JobStatus != null && !this.JobStatus.Equals(input.JobStatus))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.Target != null) hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.JobStatus != null) hashCode = hashCode * 59 + this.JobStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
