using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VolumeFlavorItemDetail 
    {
        /// <summary>
        /// **参数解释**: IO类型。 **取值范围**: - ULTRAHIGH：超高IO。 - ESSD：极速型SSD。
        /// </summary>
        /// <value>**参数解释**: IO类型。 **取值范围**: - ULTRAHIGH：超高IO。 - ESSD：极速型SSD。</value>
        [JsonConverter(typeof(EnumClassConverter<IoTypeEnum>))]
        public class IoTypeEnum
        {
            /// <summary>
            /// Enum ULTRAHIGH for value: ULTRAHIGH
            /// </summary>
            public static readonly IoTypeEnum ULTRAHIGH = new IoTypeEnum("ULTRAHIGH");

            /// <summary>
            /// Enum ESSD for value: ESSD
            /// </summary>
            public static readonly IoTypeEnum ESSD = new IoTypeEnum("ESSD");

            private static readonly Dictionary<string, IoTypeEnum> StaticFields =
            new Dictionary<string, IoTypeEnum>()
            {
                { "ULTRAHIGH", ULTRAHIGH },
                { "ESSD", ESSD },
            };

            private string _value;

            public IoTypeEnum()
            {

            }

            public IoTypeEnum(string value)
            {
                _value = value;
            }

            public static IoTypeEnum FromValue(string value)
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

                if (this.Equals(obj as IoTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IoTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IoTypeEnum a, IoTypeEnum b)
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

            public static bool operator !=(IoTypeEnum a, IoTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**: 存储介质类型。 **取值范围**: - SAS：高IO云硬盘。 - SSD：超高IO云硬盘。 - ESSD：极速型SSD云硬盘。
        /// </summary>
        /// <value>**参数解释**: 存储介质类型。 **取值范围**: - SAS：高IO云硬盘。 - SSD：超高IO云硬盘。 - ESSD：极速型SSD云硬盘。</value>
        [JsonConverter(typeof(EnumClassConverter<MediaTypeEnum>))]
        public class MediaTypeEnum
        {
            /// <summary>
            /// Enum SAS for value: SAS
            /// </summary>
            public static readonly MediaTypeEnum SAS = new MediaTypeEnum("SAS");

            /// <summary>
            /// Enum SSD for value: SSD
            /// </summary>
            public static readonly MediaTypeEnum SSD = new MediaTypeEnum("SSD");

            /// <summary>
            /// Enum ESSD for value: ESSD
            /// </summary>
            public static readonly MediaTypeEnum ESSD = new MediaTypeEnum("ESSD");

            private static readonly Dictionary<string, MediaTypeEnum> StaticFields =
            new Dictionary<string, MediaTypeEnum>()
            {
                { "SAS", SAS },
                { "SSD", SSD },
                { "ESSD", ESSD },
            };

            private string _value;

            public MediaTypeEnum()
            {

            }

            public MediaTypeEnum(string value)
            {
                _value = value;
            }

            public static MediaTypeEnum FromValue(string value)
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

                if (this.Equals(obj as MediaTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MediaTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MediaTypeEnum a, MediaTypeEnum b)
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

            public static bool operator !=(MediaTypeEnum a, MediaTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: IO类型。 **取值范围**: - ULTRAHIGH：超高IO。 - ESSD：极速型SSD。
        /// </summary>
        [JsonProperty("io_type", NullValueHandling = NullValueHandling.Ignore)]
        public IoTypeEnum IoType { get; set; }
        /// <summary>
        /// **参数解释**: 存储介质类型。 **取值范围**: - SAS：高IO云硬盘。 - SSD：超高IO云硬盘。 - ESSD：极速型SSD云硬盘。
        /// </summary>
        [JsonProperty("media_type", NullValueHandling = NullValueHandling.Ignore)]
        public MediaTypeEnum MediaType { get; set; }
        /// <summary>
        /// **参数解释**: 存储规格在各个可用区的状态。 **取值范围**: - normal：正常。 - sellout：已售罄。 - unknown：状态未知。 - unsupported：不支持。 - abandon：已废弃。
        /// </summary>
        [JsonProperty("az_status", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AzStatus { get; set; }

        /// <summary>
        /// **参数解释**: 该存储规格支持的计算规格组类型列表。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("support_compute_group_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportComputeGroupType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeFlavorItemDetail {\n");
            sb.Append("  ioType: ").Append(IoType).Append("\n");
            sb.Append("  mediaType: ").Append(MediaType).Append("\n");
            sb.Append("  azStatus: ").Append(AzStatus).Append("\n");
            sb.Append("  supportComputeGroupType: ").Append(SupportComputeGroupType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VolumeFlavorItemDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VolumeFlavorItemDetail input)
        {
            if (input == null) return false;
            if (this.IoType != input.IoType) return false;
            if (this.MediaType != input.MediaType) return false;
            if (this.AzStatus != input.AzStatus || (this.AzStatus != null && input.AzStatus != null && !this.AzStatus.SequenceEqual(input.AzStatus))) return false;
            if (this.SupportComputeGroupType != input.SupportComputeGroupType || (this.SupportComputeGroupType != null && input.SupportComputeGroupType != null && !this.SupportComputeGroupType.SequenceEqual(input.SupportComputeGroupType))) return false;

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
                hashCode = hashCode * 59 + this.IoType.GetHashCode();
                hashCode = hashCode * 59 + this.MediaType.GetHashCode();
                if (this.AzStatus != null) hashCode = hashCode * 59 + this.AzStatus.GetHashCode();
                if (this.SupportComputeGroupType != null) hashCode = hashCode * 59 + this.SupportComputeGroupType.GetHashCode();
                return hashCode;
            }
        }
    }
}
