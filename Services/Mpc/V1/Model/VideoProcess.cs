using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoProcess 
    {
        /// <summary>
        /// hls的音视频流存储方式。  - composite：存储在同一个文件中。 - separate：存储在不同的文件中 
        /// </summary>
        /// <value>hls的音视频流存储方式。  - composite：存储在同一个文件中。 - separate：存储在不同的文件中 </value>
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
        /// 长短边自适应控制字段： - SHORT：表示短边自适应 - LONG：表示长边自适应 - NONE：表示不自适应 
        /// </summary>
        /// <value>长短边自适应控制字段： - SHORT：表示短边自适应 - LONG：表示长边自适应 - NONE：表示不自适应 </value>
        [JsonConverter(typeof(EnumClassConverter<AdaptationEnum>))]
        public class AdaptationEnum
        {
            /// <summary>
            /// Enum SHORT for value: SHORT
            /// </summary>
            public static readonly AdaptationEnum SHORT = new AdaptationEnum("SHORT");

            /// <summary>
            /// Enum LONG for value: LONG
            /// </summary>
            public static readonly AdaptationEnum LONG = new AdaptationEnum("LONG");

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            public static readonly AdaptationEnum NONE = new AdaptationEnum("NONE");

            private static readonly Dictionary<string, AdaptationEnum> StaticFields =
            new Dictionary<string, AdaptationEnum>()
            {
                { "SHORT", SHORT },
                { "LONG", LONG },
                { "NONE", NONE },
            };

            private string _value;

            public AdaptationEnum()
            {

            }

            public AdaptationEnum(string value)
            {
                _value = value;
            }

            public static AdaptationEnum FromValue(string value)
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

                if (this.Equals(obj as AdaptationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AdaptationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AdaptationEnum a, AdaptationEnum b)
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

            public static bool operator !=(AdaptationEnum a, AdaptationEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 需要单独设置时长的HLS起始分片数量。与hls_init_interval配合使用，设置前面hls_init_count个HLS分片时长。 为0表示不单独配置时长。 
        /// </summary>
        [JsonProperty("hls_init_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? HlsInitCount { get; set; }

        /// <summary>
        /// 表示前面hls_init_count个HLS分片的时长,hls_init_count不为0时，该字段才起作用。 
        /// </summary>
        [JsonProperty("hls_init_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? HlsInitInterval { get; set; }

        /// <summary>
        /// hls的音视频流存储方式。  - composite：存储在同一个文件中。 - separate：存储在不同的文件中 
        /// </summary>
        [JsonProperty("hls_storage_type", NullValueHandling = NullValueHandling.Ignore)]
        public HlsStorageTypeEnum HlsStorageType { get; set; }
        /// <summary>
        /// 视频顺时针旋转角度。  - 0：表示不旋转 - 1：表示顺时针旋转90度 - 2：表示顺时针旋转180度 - 3：表示顺时针旋转270度 
        /// </summary>
        [JsonProperty("rotate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rotate { get; set; }

        /// <summary>
        /// 长短边自适应控制字段： - SHORT：表示短边自适应 - LONG：表示长边自适应 - NONE：表示不自适应 
        /// </summary>
        [JsonProperty("adaptation", NullValueHandling = NullValueHandling.Ignore)]
        public AdaptationEnum Adaptation { get; set; }
        /// <summary>
        /// 是否开启上采样，如支持从480P的片源转为720P，可取值为:  - 0：表示上采样关闭， - 1：表示上采样开启. 
        /// </summary>
        [JsonProperty("upsample", NullValueHandling = NullValueHandling.Ignore)]
        public int? Upsample { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoProcess {\n");
            sb.Append("  hlsInitCount: ").Append(HlsInitCount).Append("\n");
            sb.Append("  hlsInitInterval: ").Append(HlsInitInterval).Append("\n");
            sb.Append("  hlsStorageType: ").Append(HlsStorageType).Append("\n");
            sb.Append("  rotate: ").Append(Rotate).Append("\n");
            sb.Append("  adaptation: ").Append(Adaptation).Append("\n");
            sb.Append("  upsample: ").Append(Upsample).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoProcess);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoProcess input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HlsInitCount == input.HlsInitCount ||
                    (this.HlsInitCount != null &&
                    this.HlsInitCount.Equals(input.HlsInitCount))
                ) && 
                (
                    this.HlsInitInterval == input.HlsInitInterval ||
                    (this.HlsInitInterval != null &&
                    this.HlsInitInterval.Equals(input.HlsInitInterval))
                ) && 
                (
                    this.HlsStorageType == input.HlsStorageType ||
                    (this.HlsStorageType != null &&
                    this.HlsStorageType.Equals(input.HlsStorageType))
                ) && 
                (
                    this.Rotate == input.Rotate ||
                    (this.Rotate != null &&
                    this.Rotate.Equals(input.Rotate))
                ) && 
                (
                    this.Adaptation == input.Adaptation ||
                    (this.Adaptation != null &&
                    this.Adaptation.Equals(input.Adaptation))
                ) && 
                (
                    this.Upsample == input.Upsample ||
                    (this.Upsample != null &&
                    this.Upsample.Equals(input.Upsample))
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
                if (this.HlsInitCount != null)
                    hashCode = hashCode * 59 + this.HlsInitCount.GetHashCode();
                if (this.HlsInitInterval != null)
                    hashCode = hashCode * 59 + this.HlsInitInterval.GetHashCode();
                if (this.HlsStorageType != null)
                    hashCode = hashCode * 59 + this.HlsStorageType.GetHashCode();
                if (this.Rotate != null)
                    hashCode = hashCode * 59 + this.Rotate.GetHashCode();
                if (this.Adaptation != null)
                    hashCode = hashCode * 59 + this.Adaptation.GetHashCode();
                if (this.Upsample != null)
                    hashCode = hashCode * 59 + this.Upsample.GetHashCode();
                return hashCode;
            }
        }
    }
}
