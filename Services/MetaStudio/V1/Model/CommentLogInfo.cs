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
    /// 评论记录。
    /// </summary>
    public class CommentLogInfo 
    {
        /// <summary>
        /// * USER_REJECT：用户驳回 * USER_COMMENT：用户评论 * ADMIN_COMMENT：管理员评论
        /// </summary>
        /// <value>* USER_REJECT：用户驳回 * USER_COMMENT：用户评论 * ADMIN_COMMENT：管理员评论</value>
        [JsonConverter(typeof(EnumClassConverter<CommentTypeEnum>))]
        public class CommentTypeEnum
        {
            /// <summary>
            /// Enum USER_REJECT for value: USER_REJECT
            /// </summary>
            public static readonly CommentTypeEnum USER_REJECT = new CommentTypeEnum("USER_REJECT");

            /// <summary>
            /// Enum USER_COMMENT for value: USER_COMMENT
            /// </summary>
            public static readonly CommentTypeEnum USER_COMMENT = new CommentTypeEnum("USER_COMMENT");

            /// <summary>
            /// Enum ADMIN_COMMENT for value: ADMIN_COMMENT
            /// </summary>
            public static readonly CommentTypeEnum ADMIN_COMMENT = new CommentTypeEnum("ADMIN_COMMENT");

            private static readonly Dictionary<string, CommentTypeEnum> StaticFields =
            new Dictionary<string, CommentTypeEnum>()
            {
                { "USER_REJECT", USER_REJECT },
                { "USER_COMMENT", USER_COMMENT },
                { "ADMIN_COMMENT", ADMIN_COMMENT },
            };

            private string _value;

            public CommentTypeEnum()
            {

            }

            public CommentTypeEnum(string value)
            {
                _value = value;
            }

            public static CommentTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as CommentTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CommentTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CommentTypeEnum a, CommentTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(CommentTypeEnum a, CommentTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 操作时间,格式遵循：RFC 3339。 例 “2020-07-30T10:43:17Z”
        /// </summary>
        [JsonProperty("operate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateTime { get; set; }

        /// <summary>
        /// * USER_REJECT：用户驳回 * USER_COMMENT：用户评论 * ADMIN_COMMENT：管理员评论
        /// </summary>
        [JsonProperty("comment_type", NullValueHandling = NullValueHandling.Ignore)]
        public CommentTypeEnum CommentType { get; set; }
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
        /// 附件下载地址
        /// </summary>
        [JsonProperty("attachment_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AttachmentDownloadUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommentLogInfo {\n");
            sb.Append("  operateTime: ").Append(OperateTime).Append("\n");
            sb.Append("  commentType: ").Append(CommentType).Append("\n");
            sb.Append("  commentTitle: ").Append(CommentTitle).Append("\n");
            sb.Append("  commentMessage: ").Append(CommentMessage).Append("\n");
            sb.Append("  attachmentDownloadUrl: ").Append(AttachmentDownloadUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommentLogInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommentLogInfo input)
        {
            if (input == null) return false;
            if (this.OperateTime != input.OperateTime || (this.OperateTime != null && !this.OperateTime.Equals(input.OperateTime))) return false;
            if (this.CommentType != input.CommentType) return false;
            if (this.CommentTitle != input.CommentTitle || (this.CommentTitle != null && !this.CommentTitle.Equals(input.CommentTitle))) return false;
            if (this.CommentMessage != input.CommentMessage || (this.CommentMessage != null && !this.CommentMessage.Equals(input.CommentMessage))) return false;
            if (this.AttachmentDownloadUrl != input.AttachmentDownloadUrl || (this.AttachmentDownloadUrl != null && input.AttachmentDownloadUrl != null && !this.AttachmentDownloadUrl.SequenceEqual(input.AttachmentDownloadUrl))) return false;

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
                if (this.OperateTime != null) hashCode = hashCode * 59 + this.OperateTime.GetHashCode();
                hashCode = hashCode * 59 + this.CommentType.GetHashCode();
                if (this.CommentTitle != null) hashCode = hashCode * 59 + this.CommentTitle.GetHashCode();
                if (this.CommentMessage != null) hashCode = hashCode * 59 + this.CommentMessage.GetHashCode();
                if (this.AttachmentDownloadUrl != null) hashCode = hashCode * 59 + this.AttachmentDownloadUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
