using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 检查webhook地址
    /// </summary>
    public class CheckWebhookUrlRequestBody 
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 通知的类型,分为消息，邮件，钉钉，飞书和微信
        /// </summary>
        [JsonProperty("notice_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NoticeType { get; set; }

        /// <summary>
        /// Webhook地址
        /// </summary>
        [JsonProperty("webhook_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebhookUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckWebhookUrlRequestBody {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  noticeType: ").Append(NoticeType).Append("\n");
            sb.Append("  webhookUrl: ").Append(WebhookUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckWebhookUrlRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckWebhookUrlRequestBody input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.NoticeType != input.NoticeType || (this.NoticeType != null && !this.NoticeType.Equals(input.NoticeType))) return false;
            if (this.WebhookUrl != input.WebhookUrl || (this.WebhookUrl != null && !this.WebhookUrl.Equals(input.WebhookUrl))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.NoticeType != null) hashCode = hashCode * 59 + this.NoticeType.GetHashCode();
                if (this.WebhookUrl != null) hashCode = hashCode * 59 + this.WebhookUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
