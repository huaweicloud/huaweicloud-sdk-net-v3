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
    /// Request Object
    /// </summary>
    public class ListAssetListRequest 
    {
        /// <summary>
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATING for value: CREATING
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("CREATING");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("FAILED");

            /// <summary>
            /// Enum CREATED for value: CREATED
            /// </summary>
            public static readonly StatusEnum CREATED = new StatusEnum("CREATED");

            /// <summary>
            /// Enum PUBLISHED for value: PUBLISHED
            /// </summary>
            public static readonly StatusEnum PUBLISHED = new StatusEnum("PUBLISHED");

            /// <summary>
            /// Enum WAITING_TRANSCODE for value: WAITING_TRANSCODE
            /// </summary>
            public static readonly StatusEnum WAITING_TRANSCODE = new StatusEnum("WAITING_TRANSCODE");

            /// <summary>
            /// Enum TRANSCODING for value: TRANSCODING
            /// </summary>
            public static readonly StatusEnum TRANSCODING = new StatusEnum("TRANSCODING");

            /// <summary>
            /// Enum TRANSCODE_SUCCEED for value: TRANSCODE_SUCCEED
            /// </summary>
            public static readonly StatusEnum TRANSCODE_SUCCEED = new StatusEnum("TRANSCODE_SUCCEED");

            /// <summary>
            /// Enum TRANSCODE_FAILED for value: TRANSCODE_FAILED
            /// </summary>
            public static readonly StatusEnum TRANSCODE_FAILED = new StatusEnum("TRANSCODE_FAILED");

            /// <summary>
            /// Enum THUMBNAILING for value: THUMBNAILING
            /// </summary>
            public static readonly StatusEnum THUMBNAILING = new StatusEnum("THUMBNAILING");

            /// <summary>
            /// Enum THUMBNAIL_SUCCEED for value: THUMBNAIL_SUCCEED
            /// </summary>
            public static readonly StatusEnum THUMBNAIL_SUCCEED = new StatusEnum("THUMBNAIL_SUCCEED");

            /// <summary>
            /// Enum THUMBNAIL_FAILED for value: THUMBNAIL_FAILED
            /// </summary>
            public static readonly StatusEnum THUMBNAIL_FAILED = new StatusEnum("THUMBNAIL_FAILED");

            /// <summary>
            /// Enum UN_REVIEW for value: UN_REVIEW
            /// </summary>
            public static readonly StatusEnum UN_REVIEW = new StatusEnum("UN_REVIEW");

            /// <summary>
            /// Enum REVIEWING for value: REVIEWING
            /// </summary>
            public static readonly StatusEnum REVIEWING = new StatusEnum("REVIEWING");

            /// <summary>
            /// Enum REVIEW_SUSPICIOUS for value: REVIEW_SUSPICIOUS
            /// </summary>
            public static readonly StatusEnum REVIEW_SUSPICIOUS = new StatusEnum("REVIEW_SUSPICIOUS");

            /// <summary>
            /// Enum REVIEW_PASSED for value: REVIEW_PASSED
            /// </summary>
            public static readonly StatusEnum REVIEW_PASSED = new StatusEnum("REVIEW_PASSED");

            /// <summary>
            /// Enum REVIEW_FAILED for value: REVIEW_FAILED
            /// </summary>
            public static readonly StatusEnum REVIEW_FAILED = new StatusEnum("REVIEW_FAILED");

            /// <summary>
            /// Enum REVIEW_BLOCKED for value: REVIEW_BLOCKED
            /// </summary>
            public static readonly StatusEnum REVIEW_BLOCKED = new StatusEnum("REVIEW_BLOCKED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CREATING", CREATING },
                { "FAILED", FAILED },
                { "CREATED", CREATED },
                { "PUBLISHED", PUBLISHED },
                { "WAITING_TRANSCODE", WAITING_TRANSCODE },
                { "TRANSCODING", TRANSCODING },
                { "TRANSCODE_SUCCEED", TRANSCODE_SUCCEED },
                { "TRANSCODE_FAILED", TRANSCODE_FAILED },
                { "THUMBNAILING", THUMBNAILING },
                { "THUMBNAIL_SUCCEED", THUMBNAIL_SUCCEED },
                { "THUMBNAIL_FAILED", THUMBNAIL_FAILED },
                { "UN_REVIEW", UN_REVIEW },
                { "REVIEWING", REVIEWING },
                { "REVIEW_SUSPICIOUS", REVIEW_SUSPICIOUS },
                { "REVIEW_PASSED", REVIEW_PASSED },
                { "REVIEW_FAILED", REVIEW_FAILED },
                { "REVIEW_BLOCKED", REVIEW_BLOCKED },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 查询顺序，按createTime顺序还是倒序
        /// </summary>
        /// <value>查询顺序，按createTime顺序还是倒序</value>
        [JsonConverter(typeof(EnumClassConverter<OrderEnum>))]
        public class OrderEnum
        {
            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly OrderEnum ASC = new OrderEnum("asc");

            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly OrderEnum DESC = new OrderEnum("desc");

            private static readonly Dictionary<string, OrderEnum> StaticFields =
            new Dictionary<string, OrderEnum>()
            {
                { "asc", ASC },
                { "desc", DESC },
            };

            private string _value;

            public OrderEnum()
            {

            }

            public OrderEnum(string value)
            {
                _value = value;
            }

            public static OrderEnum FromValue(string value)
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

                if (this.Equals(obj as OrderEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OrderEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OrderEnum a, OrderEnum b)
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

            public static bool operator !=(OrderEnum a, OrderEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。 
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 媒资ID，最多同时查询10个。
        /// </summary>
        [SDKProperty("asset_id", IsQuery = true)]
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetId { get; set; }

        /// <summary>
        /// 媒资状态，同时查询多个状态的媒资。  取值如下： - CREATING：上传中 - FAILED：上传失败 - CREATED：上传成功 - PUBLISHED：已发布 - TRANSCODING：转码中 - TRANSCODE_SUCCEED：转码成功 - TRANSCODE_FAILED：转码失败 - THUMBNAILING：截图中 - THUMBNAIL_SUCCEED：截图成功 - THUMBNAIL_FAILED：截图失败 - UN_REVIEW：未审核 - REVIEWING：审核中 - REVIEW_SUSPICIOUS ：审核不过，待人工复审 - REVIEW_PASSED：审核通过 - REVIEW_FAILED：审核任务失败 - REVIEW_BLOCKED：已屏蔽
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatusEnum> Status { get; set; }
        /// <summary>
        /// 起始时间。  格式为yyyymmddhhm mss。必须是与时区无关的UTC时间。
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间。  格式为yyyymmddhhm mss。必须是与时区无关的UTC时间。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 分类ID。
        /// </summary>
        [SDKProperty("category_id", IsQuery = true)]
        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryId { get; set; }

        /// <summary>
        /// 媒资标签。 单个标签不超过16个字节， 最多不超过16 个标签。 多个用英文逗号分隔，UTF8编码。
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 在媒资标题、 描述、分类名称中模糊查询的字符串。
        /// </summary>
        [SDKProperty("query_string", IsQuery = true)]
        [JsonProperty("query_string", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryString { get; set; }

        /// <summary>
        /// 音视频文件的格式，支持多格式查询，最多不超过20个。  取值如下： - 视频文件格式：MP4、TS、MOV、MXF、MPG、FLV、WMV、AVI、M4V、F4V、MPEG - 音频文件格式：MP3、OGG、WAV、WMA、APE、FLAC、AAC、AC3、MMF、AMR、M4A、M4R、WV、MP2
        /// </summary>
        [SDKProperty("media_type", IsQuery = true)]
        [JsonProperty("media_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MediaType { get; set; }

        /// <summary>
        /// 分页编号。  默认值：0。
        /// </summary>
        [SDKProperty("page", IsQuery = true)]
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// 每页记录数。  取值范围：[1,100]。  默认值：10。
        /// </summary>
        [SDKProperty("size", IsQuery = true)]
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 查询顺序，按createTime顺序还是倒序
        /// </summary>
        [SDKProperty("order", IsQuery = true)]
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public OrderEnum Order { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAssetListRequest {\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  categoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  queryString: ").Append(QueryString).Append("\n");
            sb.Append("  mediaType: ").Append(MediaType).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAssetListRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAssetListRequest input)
        {
            if (input == null) return false;
            if (this.XSdkDate != input.XSdkDate || (this.XSdkDate != null && !this.XSdkDate.Equals(input.XSdkDate))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && input.AssetId != null && !this.AssetId.SequenceEqual(input.AssetId))) return false;
            if (this.Status != input.Status || (this.Status != null && input.Status != null && !this.Status.SequenceEqual(input.Status))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.CategoryId != input.CategoryId || (this.CategoryId != null && !this.CategoryId.Equals(input.CategoryId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && !this.Tags.Equals(input.Tags))) return false;
            if (this.QueryString != input.QueryString || (this.QueryString != null && !this.QueryString.Equals(input.QueryString))) return false;
            if (this.MediaType != input.MediaType || (this.MediaType != null && input.MediaType != null && !this.MediaType.SequenceEqual(input.MediaType))) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Order != input.Order) return false;

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
                if (this.XSdkDate != null) hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.CategoryId != null) hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.QueryString != null) hashCode = hashCode * 59 + this.QueryString.GetHashCode();
                if (this.MediaType != null) hashCode = hashCode * 59 + this.MediaType.GetHashCode();
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                hashCode = hashCode * 59 + this.Order.GetHashCode();
                return hashCode;
            }
        }
    }
}
