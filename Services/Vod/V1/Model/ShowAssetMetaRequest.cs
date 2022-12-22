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
    public class ShowAssetMetaRequest 
    {
        /// <summary>
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum UNCREATED for value: UNCREATED
            /// </summary>
            public static readonly StatusEnum UNCREATED = new StatusEnum("UNCREATED");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("DELETED");

            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            public static readonly StatusEnum CANCELLED = new StatusEnum("CANCELLED");

            /// <summary>
            /// Enum SERVER_ERROR for value: SERVER_ERROR
            /// </summary>
            public static readonly StatusEnum SERVER_ERROR = new StatusEnum("SERVER_ERROR");

            /// <summary>
            /// Enum UPLOAD_FAILED for value: UPLOAD_FAILED
            /// </summary>
            public static readonly StatusEnum UPLOAD_FAILED = new StatusEnum("UPLOAD_FAILED");

            /// <summary>
            /// Enum CREATING for value: CREATING
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("CREATING");

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
            /// Enum TRANSCODE_FAILED for value: TRANSCODE_FAILED
            /// </summary>
            public static readonly StatusEnum TRANSCODE_FAILED = new StatusEnum("TRANSCODE_FAILED");

            /// <summary>
            /// Enum TRANSCODE_SUCCEED for value: TRANSCODE_SUCCEED
            /// </summary>
            public static readonly StatusEnum TRANSCODE_SUCCEED = new StatusEnum("TRANSCODE_SUCCEED");

            /// <summary>
            /// Enum CREATED for value: CREATED
            /// </summary>
            public static readonly StatusEnum CREATED = new StatusEnum("CREATED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "UNCREATED", UNCREATED },
                { "DELETED", DELETED },
                { "CANCELLED", CANCELLED },
                { "SERVER_ERROR", SERVER_ERROR },
                { "UPLOAD_FAILED", UPLOAD_FAILED },
                { "CREATING", CREATING },
                { "PUBLISHED", PUBLISHED },
                { "WAITING_TRANSCODE", WAITING_TRANSCODE },
                { "TRANSCODING", TRANSCODING },
                { "TRANSCODE_FAILED", TRANSCODE_FAILED },
                { "TRANSCODE_SUCCEED", TRANSCODE_SUCCEED },
                { "CREATED", CREATED },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines transcodeStatus
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<TranscodeStatusEnum>))]
        public class TranscodeStatusEnum
        {
            /// <summary>
            /// Enum TRANSCODING for value: TRANSCODING
            /// </summary>
            public static readonly TranscodeStatusEnum TRANSCODING = new TranscodeStatusEnum("TRANSCODING");

            /// <summary>
            /// Enum TRANSCODE_FAILED for value: TRANSCODE_FAILED
            /// </summary>
            public static readonly TranscodeStatusEnum TRANSCODE_FAILED = new TranscodeStatusEnum("TRANSCODE_FAILED");

            /// <summary>
            /// Enum TRANSCODE_SUCCEED for value: TRANSCODE_SUCCEED
            /// </summary>
            public static readonly TranscodeStatusEnum TRANSCODE_SUCCEED = new TranscodeStatusEnum("TRANSCODE_SUCCEED");

            /// <summary>
            /// Enum UN_TRANSCODE for value: UN_TRANSCODE
            /// </summary>
            public static readonly TranscodeStatusEnum UN_TRANSCODE = new TranscodeStatusEnum("UN_TRANSCODE");

            /// <summary>
            /// Enum WAITING_TRANSCODE for value: WAITING_TRANSCODE
            /// </summary>
            public static readonly TranscodeStatusEnum WAITING_TRANSCODE = new TranscodeStatusEnum("WAITING_TRANSCODE");

            private static readonly Dictionary<string, TranscodeStatusEnum> StaticFields =
            new Dictionary<string, TranscodeStatusEnum>()
            {
                { "TRANSCODING", TRANSCODING },
                { "TRANSCODE_FAILED", TRANSCODE_FAILED },
                { "TRANSCODE_SUCCEED", TRANSCODE_SUCCEED },
                { "UN_TRANSCODE", UN_TRANSCODE },
                { "WAITING_TRANSCODE", WAITING_TRANSCODE },
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
        /// Defines assetStatus
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<AssetStatusEnum>))]
        public class AssetStatusEnum
        {
            /// <summary>
            /// Enum PUBLISHED for value: PUBLISHED
            /// </summary>
            public static readonly AssetStatusEnum PUBLISHED = new AssetStatusEnum("PUBLISHED");

            /// <summary>
            /// Enum CREATED for value: CREATED
            /// </summary>
            public static readonly AssetStatusEnum CREATED = new AssetStatusEnum("CREATED");

            private static readonly Dictionary<string, AssetStatusEnum> StaticFields =
            new Dictionary<string, AssetStatusEnum>()
            {
                { "PUBLISHED", PUBLISHED },
                { "CREATED", CREATED },
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
        /// 使用AK/SK方式认证时必选，携带的鉴权信息。 
        /// </summary>
        [SDKProperty("Authorization", IsHeader = true)]
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。 
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 媒资id，最多同时查询10个媒资。
        /// </summary>
        [SDKProperty("asset_id", IsQuery = true)]
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetId { get; set; }

        /// <summary>
        /// 媒资状态。  取值如下： - UNCREATED：未创建（媒资ID不存在 ） - DELETED：已删除 - CANCELLED：上传取消 - SERVER_ERROR：上传失败（点播服务端故障） - UPLOAD_FAILED：上传失败（向OBS上传失败） - CREATING：创建中 - PUBLISHED：已发布 - TRANSCODING：待发布（转码中） - TRANSCODE_FAILED：待发布（转码失败） - TRANSCODE_SUCCEED：待发布（转码成功） - CREATED：待发布（未转码）
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatusEnum> Status { get; set; }
        /// <summary>
        /// 转码状态  取值如下： - TRANSCODING：转码中 - TRANSCODE_FAILED：转码失败 - TRANSCODE_SUCCEED：转码成功 - UN_TRANSCODE：未转码 - WAITING_TRANSCODE：等待转码
        /// </summary>
        [SDKProperty("transcodeStatus", IsQuery = true)]
        [JsonProperty("transcodeStatus", NullValueHandling = NullValueHandling.Ignore)]
        public List<TranscodeStatusEnum> TranscodeStatus { get; set; }
        /// <summary>
        /// 媒资状态。  取值如下： - PUBLISHED：已发布 - CREATED：未发布
        /// </summary>
        [SDKProperty("assetStatus", IsQuery = true)]
        [JsonProperty("assetStatus", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssetStatusEnum> AssetStatus { get; set; }
        /// <summary>
        /// 起始时间，查询指定“**asset_id**”时，该参数无效。  格式为yyyymmddhhmmss。必须是与时区无关的UTC时间。
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间，查询指定“**asset_id**”时，该参数无效。  格式为yyyymmddhhmmss。必须是与时区无关的UTC时间。
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
        /// 媒资标签。  单个标签不超过16个字节，最多不超过16个标签。  多个用逗号分隔，UTF8编码。
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 在媒资标题、描述中模糊查询的字符串。
        /// </summary>
        [SDKProperty("query_string", IsQuery = true)]
        [JsonProperty("query_string", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryString { get; set; }

        /// <summary>
        /// 分页编号，查询指定“asset_id”时，该参数无效。  默认值：0。
        /// </summary>
        [SDKProperty("page", IsQuery = true)]
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// 每页记录数，查询指定“**asset_id**”时，该参数无效。  取值范围：[1,100]。  默认值：10。
        /// </summary>
        [SDKProperty("size", IsQuery = true)]
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAssetMetaRequest {\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  transcodeStatus: ").Append(TranscodeStatus).Append("\n");
            sb.Append("  assetStatus: ").Append(AssetStatus).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  categoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  queryString: ").Append(QueryString).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAssetMetaRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAssetMetaRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Authorization == input.Authorization ||
                    (this.Authorization != null &&
                    this.Authorization.Equals(input.Authorization))
                ) && 
                (
                    this.XSdkDate == input.XSdkDate ||
                    (this.XSdkDate != null &&
                    this.XSdkDate.Equals(input.XSdkDate))
                ) && 
                (
                    this.AssetId == input.AssetId ||
                    this.AssetId != null &&
                    input.AssetId != null &&
                    this.AssetId.SequenceEqual(input.AssetId)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status != null &&
                    input.Status != null &&
                    this.Status.SequenceEqual(input.Status)
                ) && 
                (
                    this.TranscodeStatus == input.TranscodeStatus ||
                    this.TranscodeStatus != null &&
                    input.TranscodeStatus != null &&
                    this.TranscodeStatus.SequenceEqual(input.TranscodeStatus)
                ) && 
                (
                    this.AssetStatus == input.AssetStatus ||
                    this.AssetStatus != null &&
                    input.AssetStatus != null &&
                    this.AssetStatus.SequenceEqual(input.AssetStatus)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.QueryString == input.QueryString ||
                    (this.QueryString != null &&
                    this.QueryString.Equals(input.QueryString))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.Authorization != null)
                    hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.XSdkDate != null)
                    hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.AssetId != null)
                    hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TranscodeStatus != null)
                    hashCode = hashCode * 59 + this.TranscodeStatus.GetHashCode();
                if (this.AssetStatus != null)
                    hashCode = hashCode * 59 + this.AssetStatus.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.QueryString != null)
                    hashCode = hashCode * 59 + this.QueryString.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                return hashCode;
            }
        }
    }
}
