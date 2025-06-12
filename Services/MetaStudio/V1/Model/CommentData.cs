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
    /// 用户提交的评论信息。
    /// </summary>
    public class CommentData 
    {

        /// <summary>
        /// 标题。
        /// </summary>
        [JsonProperty("comment_title", NullValueHandling = NullValueHandling.Ignore)]
        public string CommentTitle { get; set; }

        /// <summary>
        /// 消息。
        /// </summary>
        [JsonProperty("comment_message", NullValueHandling = NullValueHandling.Ignore)]
        public string CommentMessage { get; set; }

        /// <summary>
        /// 附件名字
        /// </summary>
        [JsonProperty("attachment_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AttachmentName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommentData {\n");
            sb.Append("  commentTitle: ").Append(CommentTitle).Append("\n");
            sb.Append("  commentMessage: ").Append(CommentMessage).Append("\n");
            sb.Append("  attachmentName: ").Append(AttachmentName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommentData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommentData input)
        {
            if (input == null) return false;
            if (this.CommentTitle != input.CommentTitle || (this.CommentTitle != null && !this.CommentTitle.Equals(input.CommentTitle))) return false;
            if (this.CommentMessage != input.CommentMessage || (this.CommentMessage != null && !this.CommentMessage.Equals(input.CommentMessage))) return false;
            if (this.AttachmentName != input.AttachmentName || (this.AttachmentName != null && input.AttachmentName != null && !this.AttachmentName.SequenceEqual(input.AttachmentName))) return false;

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
                if (this.CommentTitle != null) hashCode = hashCode * 59 + this.CommentTitle.GetHashCode();
                if (this.CommentMessage != null) hashCode = hashCode * 59 + this.CommentMessage.GetHashCode();
                if (this.AttachmentName != null) hashCode = hashCode * 59 + this.AttachmentName.GetHashCode();
                return hashCode;
            }
        }
    }
}
