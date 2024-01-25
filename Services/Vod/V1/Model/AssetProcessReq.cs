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
    /// 
    /// </summary>
    public class AssetProcessReq 
    {
        /// <summary>
        /// hls的音视频流存储方式。  取值如下： - composite：存储在同一文件中。 - separate：存储在不同文件中。
        /// </summary>
        /// <value>hls的音视频流存储方式。  取值如下： - composite：存储在同一文件中。 - separate：存储在不同文件中。</value>
        [JsonConverter(typeof(EnumClassConverter<HlsStorageTypeEnum>))]
        public class HlsStorageTypeEnum
        {
            /// <summary>
            /// Enum COMPOSITE for value: composite
            /// </summary>
            public static readonly HlsStorageTypeEnum COMPOSITE = new HlsStorageTypeEnum("composite");

            /// <summary>
            /// Enum SEPARATE for value: separate
            /// </summary>
            public static readonly HlsStorageTypeEnum SEPARATE = new HlsStorageTypeEnum("separate");

            private static readonly Dictionary<string, HlsStorageTypeEnum> StaticFields =
            new Dictionary<string, HlsStorageTypeEnum>()
            {
                { "composite", COMPOSITE },
                { "separate", SEPARATE },
            };

            private string _value;

            public HlsStorageTypeEnum()
            {

            }

            public HlsStorageTypeEnum(string value)
            {
                _value = value;
            }

            public static HlsStorageTypeEnum FromValue(string value)
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

                if (this.Equals(obj as HlsStorageTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HlsStorageTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HlsStorageTypeEnum a, HlsStorageTypeEnum b)
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

            public static bool operator !=(HlsStorageTypeEnum a, HlsStorageTypeEnum b)
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
        /// hls的音视频流存储方式。  取值如下： - composite：存储在同一文件中。 - separate：存储在不同文件中。
        /// </summary>
        [JsonProperty("hls_storage_type", NullValueHandling = NullValueHandling.Ignore)]
        public HlsStorageTypeEnum HlsStorageType { get; set; }
        /// <summary>
        /// 转码模板组名称。   若不为空，则使用指定的转码模板对上传的音视频进行转码，您可以在视频点播控制台配置转码模板，具体请参见[转码设置](https://support.huaweicloud.com/usermanual-vod/vod_01_0072.html)。
        /// </summary>
        [JsonProperty("template_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateGroupName { get; set; }

        /// <summary>
        /// 是否自动加密。  取值如下： - 0：表示不加密。 - 1：表示需要加密。  默认值：0。  加密与转码必须要一起进行，当需要加密时，转码参数不能为空，且转码输出格式必须要为HLS。
        /// </summary>
        [JsonProperty("auto_encrypt", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoEncrypt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Thumbnail Thumbnail { get; set; }

        /// <summary>
        /// 字幕文件ID。  &gt; 仅在[创建媒资](https://support.huaweicloud.com/api-vod/vod_04_0196.html)时，请求参数设置了“**subtitles**”时，该参数设置才生效。
        /// </summary>
        [JsonProperty("subtitle_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> SubtitleId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetProcessReq {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  hlsStorageType: ").Append(HlsStorageType).Append("\n");
            sb.Append("  templateGroupName: ").Append(TemplateGroupName).Append("\n");
            sb.Append("  autoEncrypt: ").Append(AutoEncrypt).Append("\n");
            sb.Append("  thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  subtitleId: ").Append(SubtitleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssetProcessReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssetProcessReq input)
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
                    this.HlsStorageType == input.HlsStorageType ||
                    (this.HlsStorageType != null &&
                    this.HlsStorageType.Equals(input.HlsStorageType))
                ) && 
                (
                    this.TemplateGroupName == input.TemplateGroupName ||
                    (this.TemplateGroupName != null &&
                    this.TemplateGroupName.Equals(input.TemplateGroupName))
                ) && 
                (
                    this.AutoEncrypt == input.AutoEncrypt ||
                    (this.AutoEncrypt != null &&
                    this.AutoEncrypt.Equals(input.AutoEncrypt))
                ) && 
                (
                    this.Thumbnail == input.Thumbnail ||
                    (this.Thumbnail != null &&
                    this.Thumbnail.Equals(input.Thumbnail))
                ) && 
                (
                    this.SubtitleId == input.SubtitleId ||
                    this.SubtitleId != null &&
                    input.SubtitleId != null &&
                    this.SubtitleId.SequenceEqual(input.SubtitleId)
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
                if (this.HlsStorageType != null)
                    hashCode = hashCode * 59 + this.HlsStorageType.GetHashCode();
                if (this.TemplateGroupName != null)
                    hashCode = hashCode * 59 + this.TemplateGroupName.GetHashCode();
                if (this.AutoEncrypt != null)
                    hashCode = hashCode * 59 + this.AutoEncrypt.GetHashCode();
                if (this.Thumbnail != null)
                    hashCode = hashCode * 59 + this.Thumbnail.GetHashCode();
                if (this.SubtitleId != null)
                    hashCode = hashCode * 59 + this.SubtitleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
