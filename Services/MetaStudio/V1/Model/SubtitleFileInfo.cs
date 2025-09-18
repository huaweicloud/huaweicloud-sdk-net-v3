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
    /// 
    /// </summary>
    public class SubtitleFileInfo 
    {
        /// <summary>
        /// 字幕文件生成状态。 * GENERATING：字幕文件生成中。 * GENERATE_SUCCEED：字幕文件生成成功。 * GENERATE_FAILED：字幕文件生成失败。
        /// </summary>
        /// <value>字幕文件生成状态。 * GENERATING：字幕文件生成中。 * GENERATE_SUCCEED：字幕文件生成成功。 * GENERATE_FAILED：字幕文件生成失败。</value>
        [JsonConverter(typeof(EnumClassConverter<SubtitleFileStateEnum>))]
        public class SubtitleFileStateEnum
        {
            /// <summary>
            /// Enum GENERATE_SUCCEED for value: GENERATE_SUCCEED
            /// </summary>
            public static readonly SubtitleFileStateEnum GENERATE_SUCCEED = new SubtitleFileStateEnum("GENERATE_SUCCEED");

            /// <summary>
            /// Enum GENERATE_FAILED for value: GENERATE_FAILED
            /// </summary>
            public static readonly SubtitleFileStateEnum GENERATE_FAILED = new SubtitleFileStateEnum("GENERATE_FAILED");

            /// <summary>
            /// Enum GENERATING for value: GENERATING
            /// </summary>
            public static readonly SubtitleFileStateEnum GENERATING = new SubtitleFileStateEnum("GENERATING");

            private static readonly Dictionary<string, SubtitleFileStateEnum> StaticFields =
            new Dictionary<string, SubtitleFileStateEnum>()
            {
                { "GENERATE_SUCCEED", GENERATE_SUCCEED },
                { "GENERATE_FAILED", GENERATE_FAILED },
                { "GENERATING", GENERATING },
            };

            private string _value;

            public SubtitleFileStateEnum()
            {

            }

            public SubtitleFileStateEnum(string value)
            {
                _value = value;
            }

            public static SubtitleFileStateEnum FromValue(string value)
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

                if (this.Equals(obj as SubtitleFileStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SubtitleFileStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SubtitleFileStateEnum a, SubtitleFileStateEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(SubtitleFileStateEnum a, SubtitleFileStateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 字幕文件下载链接。
        /// </summary>
        [JsonProperty("subtitle_file_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtitleFileDownloadUrl { get; set; }

        /// <summary>
        /// 字幕文件上传链接。
        /// </summary>
        [JsonProperty("subtitle_file_upload_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtitleFileUploadUrl { get; set; }

        /// <summary>
        /// 字幕文件生成状态。 * GENERATING：字幕文件生成中。 * GENERATE_SUCCEED：字幕文件生成成功。 * GENERATE_FAILED：字幕文件生成失败。
        /// </summary>
        [JsonProperty("subtitle_file_state", NullValueHandling = NullValueHandling.Ignore)]
        public SubtitleFileStateEnum SubtitleFileState { get; set; }
        /// <summary>
        /// 字幕文件生成任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubtitleFileInfo {\n");
            sb.Append("  subtitleFileDownloadUrl: ").Append(SubtitleFileDownloadUrl).Append("\n");
            sb.Append("  subtitleFileUploadUrl: ").Append(SubtitleFileUploadUrl).Append("\n");
            sb.Append("  subtitleFileState: ").Append(SubtitleFileState).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubtitleFileInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubtitleFileInfo input)
        {
            if (input == null) return false;
            if (this.SubtitleFileDownloadUrl != input.SubtitleFileDownloadUrl || (this.SubtitleFileDownloadUrl != null && !this.SubtitleFileDownloadUrl.Equals(input.SubtitleFileDownloadUrl))) return false;
            if (this.SubtitleFileUploadUrl != input.SubtitleFileUploadUrl || (this.SubtitleFileUploadUrl != null && !this.SubtitleFileUploadUrl.Equals(input.SubtitleFileUploadUrl))) return false;
            if (this.SubtitleFileState != input.SubtitleFileState) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;

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
                if (this.SubtitleFileDownloadUrl != null) hashCode = hashCode * 59 + this.SubtitleFileDownloadUrl.GetHashCode();
                if (this.SubtitleFileUploadUrl != null) hashCode = hashCode * 59 + this.SubtitleFileUploadUrl.GetHashCode();
                hashCode = hashCode * 59 + this.SubtitleFileState.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
