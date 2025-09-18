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
    /// Response Object
    /// </summary>
    public class ShowTakeOverAssetDetailsResponse : SdkResponse
    {
        /// <summary>
        /// 媒资状态。 - \&quot;CREATING\&quot;：上传中 - \&quot;FAILED\&quot;：上传失败 - \&quot;CREATED\&quot;：上传成功 - \&quot;PUBLISHED\&quot;：已发布 - \&quot;DELETED\&quot;：已删除
        /// </summary>
        /// <value>媒资状态。 - \&quot;CREATING\&quot;：上传中 - \&quot;FAILED\&quot;：上传失败 - \&quot;CREATED\&quot;：上传成功 - \&quot;PUBLISHED\&quot;：已发布 - \&quot;DELETED\&quot;：已删除</value>
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

            public static bool operator !=(AssetStatusEnum a, AssetStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 转码状态。 - \&quot;UN_TRANSCODE\&quot;：未转码 - \&quot;WAITING_TRANSCODE\&quot;：等待转码，排队中 - \&quot;TRANSCODING\&quot;：转码中 - \&quot;TRANSCODE_SUCCEED\&quot;：转码成功 - \&quot;TRANSCODE_FAILED\&quot;：转码失败
        /// </summary>
        /// <value>转码状态。 - \&quot;UN_TRANSCODE\&quot;：未转码 - \&quot;WAITING_TRANSCODE\&quot;：等待转码，排队中 - \&quot;TRANSCODING\&quot;：转码中 - \&quot;TRANSCODE_SUCCEED\&quot;：转码成功 - \&quot;TRANSCODE_FAILED\&quot;：转码失败</value>
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

            public static bool operator !=(TranscodeStatusEnum a, TranscodeStatusEnum b)
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
        /// 媒资状态。 - \&quot;CREATING\&quot;：上传中 - \&quot;FAILED\&quot;：上传失败 - \&quot;CREATED\&quot;：上传成功 - \&quot;PUBLISHED\&quot;：已发布 - \&quot;DELETED\&quot;：已删除
        /// </summary>
        [JsonProperty("asset_status", NullValueHandling = NullValueHandling.Ignore)]
        public AssetStatusEnum AssetStatus { get; set; }
        /// <summary>
        /// 转码状态。 - \&quot;UN_TRANSCODE\&quot;：未转码 - \&quot;WAITING_TRANSCODE\&quot;：等待转码，排队中 - \&quot;TRANSCODING\&quot;：转码中 - \&quot;TRANSCODE_SUCCEED\&quot;：转码成功 - \&quot;TRANSCODE_FAILED\&quot;：转码失败
        /// </summary>
        [JsonProperty("transcode_status", NullValueHandling = NullValueHandling.Ignore)]
        public TranscodeStatusEnum TranscodeStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("base_info", NullValueHandling = NullValueHandling.Ignore)]
        public BaseInfo BaseInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transcode_info", NullValueHandling = NullValueHandling.Ignore)]
        public TranscodeInfo TranscodeInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTakeOverAssetDetailsResponse {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  assetStatus: ").Append(AssetStatus).Append("\n");
            sb.Append("  transcodeStatus: ").Append(TranscodeStatus).Append("\n");
            sb.Append("  baseInfo: ").Append(BaseInfo).Append("\n");
            sb.Append("  transcodeInfo: ").Append(TranscodeInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTakeOverAssetDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTakeOverAssetDetailsResponse input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.AssetStatus != input.AssetStatus) return false;
            if (this.TranscodeStatus != input.TranscodeStatus) return false;
            if (this.BaseInfo != input.BaseInfo || (this.BaseInfo != null && !this.BaseInfo.Equals(input.BaseInfo))) return false;
            if (this.TranscodeInfo != input.TranscodeInfo || (this.TranscodeInfo != null && !this.TranscodeInfo.Equals(input.TranscodeInfo))) return false;

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
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                hashCode = hashCode * 59 + this.AssetStatus.GetHashCode();
                hashCode = hashCode * 59 + this.TranscodeStatus.GetHashCode();
                if (this.BaseInfo != null) hashCode = hashCode * 59 + this.BaseInfo.GetHashCode();
                if (this.TranscodeInfo != null) hashCode = hashCode * 59 + this.TranscodeInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
