using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.SMSApi.V1.Model
{
    /// <summary>
    /// 批量发送短信的请求body数据结构
    /// </summary>
    public class BatchSendDiffSmsRequestBody 
    {

        /// <summary>
        /// 短信发送方的号码
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public string From { get; set; }

        /// <summary>
        /// SP的回调地址，用于单条接收短信状态报告
        /// </summary>
        [JsonProperty("statusCallback", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusCallback { get; set; }

        /// <summary>
        /// 短信内容
        /// </summary>
        [JsonProperty("smsContent", NullValueHandling = NullValueHandling.Ignore)]
        public List<SmsContent> SmsContent { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonProperty("extend", NullValueHandling = NullValueHandling.Ignore)]
        public string Extend { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchSendDiffSmsRequestBody {\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  statusCallback: ").Append(StatusCallback).Append("\n");
            sb.Append("  smsContent: ").Append(SmsContent).Append("\n");
            sb.Append("  extend: ").Append(Extend).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchSendDiffSmsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchSendDiffSmsRequestBody input)
        {
            if (input == null) return false;
            if (this.From != input.From || (this.From != null && !this.From.Equals(input.From))) return false;
            if (this.StatusCallback != input.StatusCallback || (this.StatusCallback != null && !this.StatusCallback.Equals(input.StatusCallback))) return false;
            if (this.SmsContent != input.SmsContent || (this.SmsContent != null && input.SmsContent != null && !this.SmsContent.SequenceEqual(input.SmsContent))) return false;
            if (this.Extend != input.Extend || (this.Extend != null && !this.Extend.Equals(input.Extend))) return false;

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
                if (this.From != null) hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.StatusCallback != null) hashCode = hashCode * 59 + this.StatusCallback.GetHashCode();
                if (this.SmsContent != null) hashCode = hashCode * 59 + this.SmsContent.GetHashCode();
                if (this.Extend != null) hashCode = hashCode * 59 + this.Extend.GetHashCode();
                return hashCode;
            }
        }
    }
}
