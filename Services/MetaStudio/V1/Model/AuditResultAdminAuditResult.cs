using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 管理员审核结果。
    /// </summary>
    public class AuditResultAdminAuditResult 
    {

        /// <summary>
        /// 审核信息。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 附件名称。
        /// </summary>
        [JsonProperty("attachment_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachmentName { get; set; }

        /// <summary>
        /// 附件下载地址。
        /// </summary>
        [JsonProperty("attachment_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachmentUrl { get; set; }

        /// <summary>
        /// 操作时间。
        /// </summary>
        [JsonProperty("audit_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AuditTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditResultAdminAuditResult {\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  attachmentName: ").Append(AttachmentName).Append("\n");
            sb.Append("  attachmentUrl: ").Append(AttachmentUrl).Append("\n");
            sb.Append("  auditTime: ").Append(AuditTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuditResultAdminAuditResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuditResultAdminAuditResult input)
        {
            if (input == null) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.AttachmentName != input.AttachmentName || (this.AttachmentName != null && !this.AttachmentName.Equals(input.AttachmentName))) return false;
            if (this.AttachmentUrl != input.AttachmentUrl || (this.AttachmentUrl != null && !this.AttachmentUrl.Equals(input.AttachmentUrl))) return false;
            if (this.AuditTime != input.AuditTime || (this.AuditTime != null && !this.AuditTime.Equals(input.AuditTime))) return false;

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
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.AttachmentName != null) hashCode = hashCode * 59 + this.AttachmentName.GetHashCode();
                if (this.AttachmentUrl != null) hashCode = hashCode * 59 + this.AttachmentUrl.GetHashCode();
                if (this.AuditTime != null) hashCode = hashCode * 59 + this.AuditTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
