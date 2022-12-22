using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 媒资总览
    /// </summary>
    public class AssetSummary 
    {
        /// <summary>
        /// 媒资状态。  取值如下： - CREATING：上传中。 - FAILED：上传失败。 - CREATED：上传成功。 - PUBLISHED：已发布。 - DELETED：已删除。
        /// </summary>
        /// <value>媒资状态。  取值如下： - CREATING：上传中。 - FAILED：上传失败。 - CREATED：上传成功。 - PUBLISHED：已发布。 - DELETED：已删除。</value>
        [JsonConverter(typeof(EnumClassConverter<AssetStatusEnum>))]
        public class AssetStatusEnum
        {
            /// <summary>
            /// Enum CREATING for value: CREATING
            /// </summary>
            public static readonly AssetStatusEnum CREATING = new AssetStatusEnum("CREATING");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly AssetStatusEnum FAILED = new AssetStatusEnum("FAILED");

            /// <summary>
            /// Enum CREATED for value: CREATED
            /// </summary>
            public static readonly AssetStatusEnum CREATED = new AssetStatusEnum("CREATED");

            /// <summary>
            /// Enum PUBLISHED for value: PUBLISHED
            /// </summary>
            public static readonly AssetStatusEnum PUBLISHED = new AssetStatusEnum("PUBLISHED");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly AssetStatusEnum DELETED = new AssetStatusEnum("DELETED");

            private static readonly Dictionary<string, AssetStatusEnum> StaticFields =
            new Dictionary<string, AssetStatusEnum>()
            {
                { "CREATING", CREATING },
                { "FAILED", FAILED },
                { "CREATED", CREATED },
                { "PUBLISHED", PUBLISHED },
                { "DELETED", DELETED },
            };

            private string _value;

            public AssetStatusEnum()
            {

            }

            public AssetStatusEnum(string value)
            {
                _value = value;
            }

            public static AssetStatusEnum FromValue(string value)
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

                if (this.Equals(obj as AssetStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AssetStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AssetStatusEnum a, AssetStatusEnum b)
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

            public static bool operator !=(AssetStatusEnum a, AssetStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 转码状态。  取值如下： - UN_TRANSCODE：未转码。 - WAITING_TRANSCODE：待转码 - TRANSCODING：转码中。 - TRANSCODE_SUCCEED：转码成功。 - TRANSCODE_FAILED：转码失败。
        /// </summary>
        /// <value>转码状态。  取值如下： - UN_TRANSCODE：未转码。 - WAITING_TRANSCODE：待转码 - TRANSCODING：转码中。 - TRANSCODE_SUCCEED：转码成功。 - TRANSCODE_FAILED：转码失败。</value>
        [JsonConverter(typeof(EnumClassConverter<TranscodeStatusEnum>))]
        public class TranscodeStatusEnum
        {
            /// <summary>
            /// Enum UN_TRANSCODE for value: UN_TRANSCODE
            /// </summary>
            public static readonly TranscodeStatusEnum UN_TRANSCODE = new TranscodeStatusEnum("UN_TRANSCODE");

            /// <summary>
            /// Enum WAITING_TRANSCODE for value: WAITING_TRANSCODE
            /// </summary>
            public static readonly TranscodeStatusEnum WAITING_TRANSCODE = new TranscodeStatusEnum("WAITING_TRANSCODE");

            /// <summary>
            /// Enum TRANSCODING for value: TRANSCODING
            /// </summary>
            public static readonly TranscodeStatusEnum TRANSCODING = new TranscodeStatusEnum("TRANSCODING");

            /// <summary>
            /// Enum TRANSCODE_SUCCEED for value: TRANSCODE_SUCCEED
            /// </summary>
            public static readonly TranscodeStatusEnum TRANSCODE_SUCCEED = new TranscodeStatusEnum("TRANSCODE_SUCCEED");

            /// <summary>
            /// Enum TRANSCODE_FAILED for value: TRANSCODE_FAILED
            /// </summary>
            public static readonly TranscodeStatusEnum TRANSCODE_FAILED = new TranscodeStatusEnum("TRANSCODE_FAILED");

            private static readonly Dictionary<string, TranscodeStatusEnum> StaticFields =
            new Dictionary<string, TranscodeStatusEnum>()
            {
                { "UN_TRANSCODE", UN_TRANSCODE },
                { "WAITING_TRANSCODE", WAITING_TRANSCODE },
                { "TRANSCODING", TRANSCODING },
                { "TRANSCODE_SUCCEED", TRANSCODE_SUCCEED },
                { "TRANSCODE_FAILED", TRANSCODE_FAILED },
            };

            private string _value;

            public TranscodeStatusEnum()
            {

            }

            public TranscodeStatusEnum(string value)
            {
                _value = value;
            }

            public static TranscodeStatusEnum FromValue(string value)
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

                if (this.Equals(obj as TranscodeStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TranscodeStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TranscodeStatusEnum a, TranscodeStatusEnum b)
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

            public static bool operator !=(TranscodeStatusEnum a, TranscodeStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 截图状态。  取值如下： - UN_THUMBNAIL：未截图。 - THUMBNAILING：截图中。 - THUMBNAIL_SUCCEED：截图成功。 - THUMBNAIL_FAILED：截图失败。
        /// </summary>
        /// <value>截图状态。  取值如下： - UN_THUMBNAIL：未截图。 - THUMBNAILING：截图中。 - THUMBNAIL_SUCCEED：截图成功。 - THUMBNAIL_FAILED：截图失败。</value>
        [JsonConverter(typeof(EnumClassConverter<ThumbnailStatusEnum>))]
        public class ThumbnailStatusEnum
        {
            /// <summary>
            /// Enum UN_THUMBNAIL for value: UN_THUMBNAIL
            /// </summary>
            public static readonly ThumbnailStatusEnum UN_THUMBNAIL = new ThumbnailStatusEnum("UN_THUMBNAIL");

            /// <summary>
            /// Enum THUMBNAILING for value: THUMBNAILING
            /// </summary>
            public static readonly ThumbnailStatusEnum THUMBNAILING = new ThumbnailStatusEnum("THUMBNAILING");

            /// <summary>
            /// Enum THUMBNAIL_SUCCEED for value: THUMBNAIL_SUCCEED
            /// </summary>
            public static readonly ThumbnailStatusEnum THUMBNAIL_SUCCEED = new ThumbnailStatusEnum("THUMBNAIL_SUCCEED");

            /// <summary>
            /// Enum THUMBNAIL_FAILED for value: THUMBNAIL_FAILED
            /// </summary>
            public static readonly ThumbnailStatusEnum THUMBNAIL_FAILED = new ThumbnailStatusEnum("THUMBNAIL_FAILED");

            private static readonly Dictionary<string, ThumbnailStatusEnum> StaticFields =
            new Dictionary<string, ThumbnailStatusEnum>()
            {
                { "UN_THUMBNAIL", UN_THUMBNAIL },
                { "THUMBNAILING", THUMBNAILING },
                { "THUMBNAIL_SUCCEED", THUMBNAIL_SUCCEED },
                { "THUMBNAIL_FAILED", THUMBNAIL_FAILED },
            };

            private string _value;

            public ThumbnailStatusEnum()
            {

            }

            public ThumbnailStatusEnum(string value)
            {
                _value = value;
            }

            public static ThumbnailStatusEnum FromValue(string value)
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

                if (this.Equals(obj as ThumbnailStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ThumbnailStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ThumbnailStatusEnum a, ThumbnailStatusEnum b)
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

            public static bool operator !=(ThumbnailStatusEnum a, ThumbnailStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 内容审核状态  取值如下： - UN_REVIEW：未审核。 - REVIEWING：审核中。 - REVIEW_SUSPICIOUS：审核可疑，需要人工复审。 - REVIEW_PASSED：审核通过。 - REVIEW_FAILED：审核失败。 - REVIEW_BLOCKED：已屏蔽。
        /// </summary>
        /// <value>内容审核状态  取值如下： - UN_REVIEW：未审核。 - REVIEWING：审核中。 - REVIEW_SUSPICIOUS：审核可疑，需要人工复审。 - REVIEW_PASSED：审核通过。 - REVIEW_FAILED：审核失败。 - REVIEW_BLOCKED：已屏蔽。</value>
        [JsonConverter(typeof(EnumClassConverter<ReviewStatusEnum>))]
        public class ReviewStatusEnum
        {
            /// <summary>
            /// Enum UN_REVIEW for value: UN_REVIEW
            /// </summary>
            public static readonly ReviewStatusEnum UN_REVIEW = new ReviewStatusEnum("UN_REVIEW");

            /// <summary>
            /// Enum REVIEWING for value: REVIEWING
            /// </summary>
            public static readonly ReviewStatusEnum REVIEWING = new ReviewStatusEnum("REVIEWING");

            /// <summary>
            /// Enum REVIEW_SUSPICIOUS for value: REVIEW_SUSPICIOUS
            /// </summary>
            public static readonly ReviewStatusEnum REVIEW_SUSPICIOUS = new ReviewStatusEnum("REVIEW_SUSPICIOUS");

            /// <summary>
            /// Enum REVIEW_PASSED for value: REVIEW_PASSED
            /// </summary>
            public static readonly ReviewStatusEnum REVIEW_PASSED = new ReviewStatusEnum("REVIEW_PASSED");

            /// <summary>
            /// Enum REVIEW_FAILED for value: REVIEW_FAILED
            /// </summary>
            public static readonly ReviewStatusEnum REVIEW_FAILED = new ReviewStatusEnum("REVIEW_FAILED");

            /// <summary>
            /// Enum REVIEW_BLOCKED for value: REVIEW_BLOCKED
            /// </summary>
            public static readonly ReviewStatusEnum REVIEW_BLOCKED = new ReviewStatusEnum("REVIEW_BLOCKED");

            private static readonly Dictionary<string, ReviewStatusEnum> StaticFields =
            new Dictionary<string, ReviewStatusEnum>()
            {
                { "UN_REVIEW", UN_REVIEW },
                { "REVIEWING", REVIEWING },
                { "REVIEW_SUSPICIOUS", REVIEW_SUSPICIOUS },
                { "REVIEW_PASSED", REVIEW_PASSED },
                { "REVIEW_FAILED", REVIEW_FAILED },
                { "REVIEW_BLOCKED", REVIEW_BLOCKED },
            };

            private string _value;

            public ReviewStatusEnum()
            {

            }

            public ReviewStatusEnum(string value)
            {
                _value = value;
            }

            public static ReviewStatusEnum FromValue(string value)
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

                if (this.Equals(obj as ReviewStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ReviewStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ReviewStatusEnum a, ReviewStatusEnum b)
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

            public static bool operator !=(ReviewStatusEnum a, ReviewStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 媒资ID。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 媒资标题。长度不超过128个字节，UTF-8编码。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 媒资描述。长度不超过1024个字节。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 媒资时长。  单位：秒。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// 媒资大小。  单位：字节。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// 原始播放url。
        /// </summary>
        [JsonProperty("original_url", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalUrl { get; set; }

        /// <summary>
        /// 媒资分类名称。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 封面信息。
        /// </summary>
        [JsonProperty("covers", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoverInfo> Covers { get; set; }

        /// <summary>
        /// 媒资创建时间。  格式为yyyymmddhhmmss。必须是与时区无关的UTC时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 媒资状态。  取值如下： - CREATING：上传中。 - FAILED：上传失败。 - CREATED：上传成功。 - PUBLISHED：已发布。 - DELETED：已删除。
        /// </summary>
        [JsonProperty("asset_status", NullValueHandling = NullValueHandling.Ignore)]
        public AssetStatusEnum AssetStatus { get; set; }
        /// <summary>
        /// 转码状态。  取值如下： - UN_TRANSCODE：未转码。 - WAITING_TRANSCODE：待转码 - TRANSCODING：转码中。 - TRANSCODE_SUCCEED：转码成功。 - TRANSCODE_FAILED：转码失败。
        /// </summary>
        [JsonProperty("transcode_status", NullValueHandling = NullValueHandling.Ignore)]
        public TranscodeStatusEnum TranscodeStatus { get; set; }
        /// <summary>
        /// 截图状态。  取值如下： - UN_THUMBNAIL：未截图。 - THUMBNAILING：截图中。 - THUMBNAIL_SUCCEED：截图成功。 - THUMBNAIL_FAILED：截图失败。
        /// </summary>
        [JsonProperty("thumbnail_status", NullValueHandling = NullValueHandling.Ignore)]
        public ThumbnailStatusEnum ThumbnailStatus { get; set; }
        /// <summary>
        /// 内容审核状态  取值如下： - UN_REVIEW：未审核。 - REVIEWING：审核中。 - REVIEW_SUSPICIOUS：审核可疑，需要人工复审。 - REVIEW_PASSED：审核通过。 - REVIEW_FAILED：审核失败。 - REVIEW_BLOCKED：已屏蔽。
        /// </summary>
        [JsonProperty("review_status", NullValueHandling = NullValueHandling.Ignore)]
        public ReviewStatusEnum ReviewStatus { get; set; }
        /// <summary>
        /// 媒资的任务执行描述汇总。  示例： - asset_exec_desc: upload success，媒资任务执行描述信息。 - transcode_exec_desc: transcode success，转码任务执行描述信息。 - thumbnail_exec_desc: thumbnail failed，截图任务执行描述信息。 - review_exec_desc: review pass，审核任务执行描述信息。
        /// </summary>
        [JsonProperty("exec_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecDesc { get; set; }

        /// <summary>
        /// 音视频文件的格式。  取值如下： - 视频文件格式：MP4、TS、MOV、MXF、MPG、FLV、WMV、AVI、M4V、F4V、MPEG - 音频文件格式：MP3、OGG、WAV、WMA、APE、FLAC、AAC、AC3、MMF、AMR、M4A、M4R、WV、MP2
        /// </summary>
        [JsonProperty("media_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MediaType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetSummary {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  originalUrl: ").Append(OriginalUrl).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  covers: ").Append(Covers).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  assetStatus: ").Append(AssetStatus).Append("\n");
            sb.Append("  transcodeStatus: ").Append(TranscodeStatus).Append("\n");
            sb.Append("  thumbnailStatus: ").Append(ThumbnailStatus).Append("\n");
            sb.Append("  reviewStatus: ").Append(ReviewStatus).Append("\n");
            sb.Append("  execDesc: ").Append(ExecDesc).Append("\n");
            sb.Append("  mediaType: ").Append(MediaType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssetSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssetSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.OriginalUrl == input.OriginalUrl ||
                    (this.OriginalUrl != null &&
                    this.OriginalUrl.Equals(input.OriginalUrl))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Covers == input.Covers ||
                    this.Covers != null &&
                    input.Covers != null &&
                    this.Covers.SequenceEqual(input.Covers)
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.AssetStatus == input.AssetStatus ||
                    (this.AssetStatus != null &&
                    this.AssetStatus.Equals(input.AssetStatus))
                ) && 
                (
                    this.TranscodeStatus == input.TranscodeStatus ||
                    (this.TranscodeStatus != null &&
                    this.TranscodeStatus.Equals(input.TranscodeStatus))
                ) && 
                (
                    this.ThumbnailStatus == input.ThumbnailStatus ||
                    (this.ThumbnailStatus != null &&
                    this.ThumbnailStatus.Equals(input.ThumbnailStatus))
                ) && 
                (
                    this.ReviewStatus == input.ReviewStatus ||
                    (this.ReviewStatus != null &&
                    this.ReviewStatus.Equals(input.ReviewStatus))
                ) && 
                (
                    this.ExecDesc == input.ExecDesc ||
                    (this.ExecDesc != null &&
                    this.ExecDesc.Equals(input.ExecDesc))
                ) && 
                (
                    this.MediaType == input.MediaType ||
                    (this.MediaType != null &&
                    this.MediaType.Equals(input.MediaType))
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
                if (this.AssetId != null)
                    hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.OriginalUrl != null)
                    hashCode = hashCode * 59 + this.OriginalUrl.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Covers != null)
                    hashCode = hashCode * 59 + this.Covers.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.AssetStatus != null)
                    hashCode = hashCode * 59 + this.AssetStatus.GetHashCode();
                if (this.TranscodeStatus != null)
                    hashCode = hashCode * 59 + this.TranscodeStatus.GetHashCode();
                if (this.ThumbnailStatus != null)
                    hashCode = hashCode * 59 + this.ThumbnailStatus.GetHashCode();
                if (this.ReviewStatus != null)
                    hashCode = hashCode * 59 + this.ReviewStatus.GetHashCode();
                if (this.ExecDesc != null)
                    hashCode = hashCode * 59 + this.ExecDesc.GetHashCode();
                if (this.MediaType != null)
                    hashCode = hashCode * 59 + this.MediaType.GetHashCode();
                return hashCode;
            }
        }
    }
}
