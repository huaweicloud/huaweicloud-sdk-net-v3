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
    /// Request Object
    /// </summary>
    public class ListHarvestTaskRequest 
    {

        /// <summary>
        /// 服务鉴权Token，服务开启鉴权，必须携带Access-Control-Allow-Internal访问服务。
        /// </summary>
        [SDKProperty("Access-Control-Allow-Internal", IsHeader = true)]
        [JsonProperty("Access-Control-Allow-Internal", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessControlAllowInternal { get; set; }

        /// <summary>
        /// 服务鉴权Token，服务开启鉴权，必须携带Access-Control-Allow-External访问服务。
        /// </summary>
        [SDKProperty("Access-Control-Allow-External", IsHeader = true)]
        [JsonProperty("Access-Control-Allow-External", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessControlAllowExternal { get; set; }

        /// <summary>
        /// 推流域名
        /// </summary>
        [SDKProperty("domain", IsQuery = true)]
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 组名或应用名
        /// </summary>
        [SDKProperty("app_name", IsQuery = true)]
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 频道ID
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [SDKProperty("job_id", IsQuery = true)]
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 开始时间，Unix时间戳：单位是秒
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartTime { get; set; }

        /// <summary>
        /// 结束，Unix时间戳：单位是秒
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? EndTime { get; set; }

        /// <summary>
        /// 事件名称
        /// </summary>
        [SDKProperty("event_name", IsQuery = true)]
        [JsonProperty("event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        /// <summary>
        /// 每页记录数，取值范围[1,100]，默认值10
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 偏移量。表示从此偏移量开始查询，offset大于等于0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHarvestTaskRequest {\n");
            sb.Append("  accessControlAllowInternal: ").Append(AccessControlAllowInternal).Append("\n");
            sb.Append("  accessControlAllowExternal: ").Append(AccessControlAllowExternal).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  eventName: ").Append(EventName).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHarvestTaskRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHarvestTaskRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessControlAllowInternal == input.AccessControlAllowInternal ||
                    (this.AccessControlAllowInternal != null &&
                    this.AccessControlAllowInternal.Equals(input.AccessControlAllowInternal))
                ) && 
                (
                    this.AccessControlAllowExternal == input.AccessControlAllowExternal ||
                    (this.AccessControlAllowExternal != null &&
                    this.AccessControlAllowExternal.Equals(input.AccessControlAllowExternal))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
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
                if (this.AccessControlAllowInternal != null)
                    hashCode = hashCode * 59 + this.AccessControlAllowInternal.GetHashCode();
                if (this.AccessControlAllowExternal != null)
                    hashCode = hashCode * 59 + this.AccessControlAllowExternal.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
