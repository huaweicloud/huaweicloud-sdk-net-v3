using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// **参数解释：** Webhook执行日志数据，带仓库信息。
    /// </summary>
    public class WebhookLogExtendDto 
    {

        /// <summary>
        /// **参数解释：** Webhook 日志id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** Webhook id。
        /// </summary>
        [JsonProperty("web_hook_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? WebHookId { get; set; }

        /// <summary>
        /// **参数解释：** 触发类型。
        /// </summary>
        [JsonProperty("trigger", NullValueHandling = NullValueHandling.Ignore)]
        public string Trigger { get; set; }

        /// <summary>
        /// **参数解释：** 请求地址。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// **参数解释：** 响应状态，默认是响应码，如果webhook地址未返回或者其他异常情况，则记录为internal error
        /// </summary>
        [JsonProperty("response_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ResponseStatus { get; set; }

        /// <summary>
        /// **参数解释：** 响应耗时，单位是秒
        /// </summary>
        [JsonProperty("execution_duration", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExecutionDuration { get; set; }

        /// <summary>
        /// **参数解释：** Webhook每次发送消息的时候，会在请求体中带上uuid字段，此处为该记录的uuid字段
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("repository", NullValueHandling = NullValueHandling.Ignore)]
        public WebhookRepositoryDto Repository { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookLogExtendDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  webHookId: ").Append(WebHookId).Append("\n");
            sb.Append("  trigger: ").Append(Trigger).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  responseStatus: ").Append(ResponseStatus).Append("\n");
            sb.Append("  executionDuration: ").Append(ExecutionDuration).Append("\n");
            sb.Append("  uuid: ").Append(Uuid).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  repository: ").Append(Repository).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebhookLogExtendDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WebhookLogExtendDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.WebHookId != input.WebHookId || (this.WebHookId != null && !this.WebHookId.Equals(input.WebHookId))) return false;
            if (this.Trigger != input.Trigger || (this.Trigger != null && !this.Trigger.Equals(input.Trigger))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.ResponseStatus != input.ResponseStatus || (this.ResponseStatus != null && !this.ResponseStatus.Equals(input.ResponseStatus))) return false;
            if (this.ExecutionDuration != input.ExecutionDuration || (this.ExecutionDuration != null && !this.ExecutionDuration.Equals(input.ExecutionDuration))) return false;
            if (this.Uuid != input.Uuid || (this.Uuid != null && !this.Uuid.Equals(input.Uuid))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Repository != input.Repository || (this.Repository != null && !this.Repository.Equals(input.Repository))) return false;

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
                if (this.WebHookId != null) hashCode = hashCode * 59 + this.WebHookId.GetHashCode();
                if (this.Trigger != null) hashCode = hashCode * 59 + this.Trigger.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.ResponseStatus != null) hashCode = hashCode * 59 + this.ResponseStatus.GetHashCode();
                if (this.ExecutionDuration != null) hashCode = hashCode * 59 + this.ExecutionDuration.GetHashCode();
                if (this.Uuid != null) hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Repository != null) hashCode = hashCode * 59 + this.Repository.GetHashCode();
                return hashCode;
            }
        }
    }
}
