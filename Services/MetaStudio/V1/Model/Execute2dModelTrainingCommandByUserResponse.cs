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
    /// Response Object
    /// </summary>
    public class Execute2dModelTrainingCommandByUserResponse : SdkResponse
    {
        /// <summary>
        /// 命令执行结果。 * EXCUTE_SUCCESS: 命令提交成功 * EXCUTE_FAILED: 命令提交失败
        /// </summary>
        /// <value>命令执行结果。 * EXCUTE_SUCCESS: 命令提交成功 * EXCUTE_FAILED: 命令提交失败</value>
        [JsonConverter(typeof(EnumClassConverter<CommondResultEnum>))]
        public class CommondResultEnum
        {
            /// <summary>
            /// Enum EXCUTE_SUCCESS for value: EXCUTE_SUCCESS
            /// </summary>
            public static readonly CommondResultEnum EXCUTE_SUCCESS = new CommondResultEnum("EXCUTE_SUCCESS");

            /// <summary>
            /// Enum EXCUTE_FAILED for value: EXCUTE_FAILED
            /// </summary>
            public static readonly CommondResultEnum EXCUTE_FAILED = new CommondResultEnum("EXCUTE_FAILED");

            private static readonly Dictionary<string, CommondResultEnum> StaticFields =
            new Dictionary<string, CommondResultEnum>()
            {
                { "EXCUTE_SUCCESS", EXCUTE_SUCCESS },
                { "EXCUTE_FAILED", EXCUTE_FAILED },
            };

            private string _value;

            public CommondResultEnum()
            {

            }

            public CommondResultEnum(string value)
            {
                _value = value;
            }

            public static CommondResultEnum FromValue(string value)
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

                if (this.Equals(obj as CommondResultEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CommondResultEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CommondResultEnum a, CommondResultEnum b)
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

            public static bool operator !=(CommondResultEnum a, CommondResultEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 命令执行结果。 * EXCUTE_SUCCESS: 命令提交成功 * EXCUTE_FAILED: 命令提交失败
        /// </summary>
        [JsonProperty("commond_result", NullValueHandling = NullValueHandling.Ignore)]
        public CommondResultEnum CommondResult { get; set; }
        /// <summary>
        /// 附件上传地址
        /// </summary>
        [JsonProperty("attachment_upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AttachmentUploadUrl { get; set; }

        /// <summary>
        /// 训练视频已上传分片信息
        /// </summary>
        [JsonProperty("multipart_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<MultipartUploadInfo> MultipartData { get; set; }

        /// <summary>
        /// 命令执行失败原因描述
        /// </summary>
        [JsonProperty("excute_failed_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcuteFailedMsg { get; set; }

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
            sb.Append("class Execute2dModelTrainingCommandByUserResponse {\n");
            sb.Append("  commondResult: ").Append(CommondResult).Append("\n");
            sb.Append("  attachmentUploadUrl: ").Append(AttachmentUploadUrl).Append("\n");
            sb.Append("  multipartData: ").Append(MultipartData).Append("\n");
            sb.Append("  excuteFailedMsg: ").Append(ExcuteFailedMsg).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Execute2dModelTrainingCommandByUserResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Execute2dModelTrainingCommandByUserResponse input)
        {
            if (input == null) return false;
            if (this.CommondResult != input.CommondResult) return false;
            if (this.AttachmentUploadUrl != input.AttachmentUploadUrl || (this.AttachmentUploadUrl != null && input.AttachmentUploadUrl != null && !this.AttachmentUploadUrl.SequenceEqual(input.AttachmentUploadUrl))) return false;
            if (this.MultipartData != input.MultipartData || (this.MultipartData != null && input.MultipartData != null && !this.MultipartData.SequenceEqual(input.MultipartData))) return false;
            if (this.ExcuteFailedMsg != input.ExcuteFailedMsg || (this.ExcuteFailedMsg != null && !this.ExcuteFailedMsg.Equals(input.ExcuteFailedMsg))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                hashCode = hashCode * 59 + this.CommondResult.GetHashCode();
                if (this.AttachmentUploadUrl != null) hashCode = hashCode * 59 + this.AttachmentUploadUrl.GetHashCode();
                if (this.MultipartData != null) hashCode = hashCode * 59 + this.MultipartData.GetHashCode();
                if (this.ExcuteFailedMsg != null) hashCode = hashCode * 59 + this.ExcuteFailedMsg.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
