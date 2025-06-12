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
    /// 文件数据。
    /// </summary>
    public class FileExtraMeta 
    {
        /// <summary>
        /// 视频转码状态。 * WAITING：等待 * TRANSCODING：转码中 * FAILED：失败 * SUCCEEDED：成功
        /// </summary>
        /// <value>视频转码状态。 * WAITING：等待 * TRANSCODING：转码中 * FAILED：失败 * SUCCEEDED：成功</value>
        [JsonConverter(typeof(EnumClassConverter<VideoTranscodingStatusEnum>))]
        public class VideoTranscodingStatusEnum
        {
            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            public static readonly VideoTranscodingStatusEnum WAITING = new VideoTranscodingStatusEnum("WAITING");

            /// <summary>
            /// Enum TRANSCODING for value: TRANSCODING
            /// </summary>
            public static readonly VideoTranscodingStatusEnum TRANSCODING = new VideoTranscodingStatusEnum("TRANSCODING");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly VideoTranscodingStatusEnum FAILED = new VideoTranscodingStatusEnum("FAILED");

            /// <summary>
            /// Enum SUCCEEDED for value: SUCCEEDED
            /// </summary>
            public static readonly VideoTranscodingStatusEnum SUCCEEDED = new VideoTranscodingStatusEnum("SUCCEEDED");

            private static readonly Dictionary<string, VideoTranscodingStatusEnum> StaticFields =
            new Dictionary<string, VideoTranscodingStatusEnum>()
            {
                { "WAITING", WAITING },
                { "TRANSCODING", TRANSCODING },
                { "FAILED", FAILED },
                { "SUCCEEDED", SUCCEEDED },
            };

            private string _value;

            public VideoTranscodingStatusEnum()
            {

            }

            public VideoTranscodingStatusEnum(string value)
            {
                _value = value;
            }

            public static VideoTranscodingStatusEnum FromValue(string value)
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

                if (this.Equals(obj as VideoTranscodingStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VideoTranscodingStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VideoTranscodingStatusEnum a, VideoTranscodingStatusEnum b)
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

            public static bool operator !=(VideoTranscodingStatusEnum a, VideoTranscodingStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 视频转码状态。 * WAITING：等待 * TRANSCODING：转码中 * FAILED：失败 * SUCCEEDED：成功
        /// </summary>
        [JsonProperty("video_transcoding_status", NullValueHandling = NullValueHandling.Ignore)]
        public VideoTranscodingStatusEnum VideoTranscodingStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileExtraMeta {\n");
            sb.Append("  videoTranscodingStatus: ").Append(VideoTranscodingStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FileExtraMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FileExtraMeta input)
        {
            if (input == null) return false;
            if (this.VideoTranscodingStatus != input.VideoTranscodingStatus) return false;

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
                hashCode = hashCode * 59 + this.VideoTranscodingStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
