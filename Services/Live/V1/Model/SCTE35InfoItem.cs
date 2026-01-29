using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// SCTE35信号信息的item结构。
    /// </summary>
    public class SCTE35InfoItem 
    {
        /// <summary>
        /// 信号类型，splice_insert/time_signal。
        /// </summary>
        /// <value>信号类型，splice_insert/time_signal。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum SPLICE_INSERT for value: splice_insert
            /// </summary>
            public static readonly TypeEnum SPLICE_INSERT = new TypeEnum("splice_insert");

            /// <summary>
            /// Enum TIME_SIGNAL for value: time_signal
            /// </summary>
            public static readonly TypeEnum TIME_SIGNAL = new TypeEnum("time_signal");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "splice_insert", SPLICE_INSERT },
                { "time_signal", TIME_SIGNAL },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// // Splice Insert填空\&quot;-\&quot;； // Time Signal，支持0x30，0x31，0x32，0x33，0x34，0x35，0x36，0x37 // 0x30: ProviderAdvertisementStart // 0x31: ProviderAdvertisementEnd // 0x32: DistributorAdvertisementStart // 0x33: DistributorAdvertisementEnd // 0x34: ProviderPlacementOpportunityStart // 0x35: ProviderPlacementOpportunityEnd // 0x36: DistributorPlacementOpportunityStart // 0x37: DistributorPlacementOpportunityEnd
        /// </summary>
        /// <value>// Splice Insert填空\&quot;-\&quot;； // Time Signal，支持0x30，0x31，0x32，0x33，0x34，0x35，0x36，0x37 // 0x30: ProviderAdvertisementStart // 0x31: ProviderAdvertisementEnd // 0x32: DistributorAdvertisementStart // 0x33: DistributorAdvertisementEnd // 0x34: ProviderPlacementOpportunityStart // 0x35: ProviderPlacementOpportunityEnd // 0x36: DistributorPlacementOpportunityStart // 0x37: DistributorPlacementOpportunityEnd</value>
        [JsonConverter(typeof(EnumClassConverter<SegmentationTypeEnum>))]
        public class SegmentationTypeEnum
        {
            /// <summary>
            /// Enum Minus for value: -
            /// </summary>
            public static readonly SegmentationTypeEnum Minus = new SegmentationTypeEnum("-");

            /// <summary>
            /// Enum PROVIDERADVERTISEMENTSTART for value: ProviderAdvertisementStart
            /// </summary>
            public static readonly SegmentationTypeEnum PROVIDERADVERTISEMENTSTART = new SegmentationTypeEnum("ProviderAdvertisementStart");

            /// <summary>
            /// Enum PROVIDERADVERTISEMENTEND for value: ProviderAdvertisementEnd
            /// </summary>
            public static readonly SegmentationTypeEnum PROVIDERADVERTISEMENTEND = new SegmentationTypeEnum("ProviderAdvertisementEnd");

            /// <summary>
            /// Enum DISTRIBUTORADVERTISEMENTSTART for value: DistributorAdvertisementStart
            /// </summary>
            public static readonly SegmentationTypeEnum DISTRIBUTORADVERTISEMENTSTART = new SegmentationTypeEnum("DistributorAdvertisementStart");

            /// <summary>
            /// Enum DISTRIBUTORADVERTISEMENTEND for value: DistributorAdvertisementEnd
            /// </summary>
            public static readonly SegmentationTypeEnum DISTRIBUTORADVERTISEMENTEND = new SegmentationTypeEnum("DistributorAdvertisementEnd");

            /// <summary>
            /// Enum PROVIDERPLACEMENTOPPORTUNITYSTART for value: ProviderPlacementOpportunityStart
            /// </summary>
            public static readonly SegmentationTypeEnum PROVIDERPLACEMENTOPPORTUNITYSTART = new SegmentationTypeEnum("ProviderPlacementOpportunityStart");

            /// <summary>
            /// Enum PROVIDERPLACEMENTOPPORTUNITYEND for value: ProviderPlacementOpportunityEnd
            /// </summary>
            public static readonly SegmentationTypeEnum PROVIDERPLACEMENTOPPORTUNITYEND = new SegmentationTypeEnum("ProviderPlacementOpportunityEnd");

            /// <summary>
            /// Enum DISTRIBUTORPLACEMENTOPPORTUNITYSTART for value: DistributorPlacementOpportunityStart
            /// </summary>
            public static readonly SegmentationTypeEnum DISTRIBUTORPLACEMENTOPPORTUNITYSTART = new SegmentationTypeEnum("DistributorPlacementOpportunityStart");

            /// <summary>
            /// Enum DISTRIBUTORPLACEMENTOPPORTUNITYEND for value: DistributorPlacementOpportunityEnd
            /// </summary>
            public static readonly SegmentationTypeEnum DISTRIBUTORPLACEMENTOPPORTUNITYEND = new SegmentationTypeEnum("DistributorPlacementOpportunityEnd");

            private static readonly Dictionary<string, SegmentationTypeEnum> StaticFields =
            new Dictionary<string, SegmentationTypeEnum>()
            {
                { "-", Minus },
                { "ProviderAdvertisementStart", PROVIDERADVERTISEMENTSTART },
                { "ProviderAdvertisementEnd", PROVIDERADVERTISEMENTEND },
                { "DistributorAdvertisementStart", DISTRIBUTORADVERTISEMENTSTART },
                { "DistributorAdvertisementEnd", DISTRIBUTORADVERTISEMENTEND },
                { "ProviderPlacementOpportunityStart", PROVIDERPLACEMENTOPPORTUNITYSTART },
                { "ProviderPlacementOpportunityEnd", PROVIDERPLACEMENTOPPORTUNITYEND },
                { "DistributorPlacementOpportunityStart", DISTRIBUTORPLACEMENTOPPORTUNITYSTART },
                { "DistributorPlacementOpportunityEnd", DISTRIBUTORPLACEMENTOPPORTUNITYEND },
            };

            private string _value;

            public SegmentationTypeEnum()
            {

            }

            public SegmentationTypeEnum(string value)
            {
                _value = value;
            }

            public static SegmentationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SegmentationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SegmentationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SegmentationTypeEnum a, SegmentationTypeEnum b)
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

            public static bool operator !=(SegmentationTypeEnum a, SegmentationTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 该广告信号对应的region类型，是主region，还是备region **取值范围**：  - master: 主region  - slave: 备region 
        /// </summary>
        /// <value>**参数解释**： 该广告信号对应的region类型，是主region，还是备region **取值范围**：  - master: 主region  - slave: 备region </value>
        [JsonConverter(typeof(EnumClassConverter<RegionTypeEnum>))]
        public class RegionTypeEnum
        {
            /// <summary>
            /// Enum MASTER for value: master
            /// </summary>
            public static readonly RegionTypeEnum MASTER = new RegionTypeEnum("master");

            /// <summary>
            /// Enum SLAVE for value: slave
            /// </summary>
            public static readonly RegionTypeEnum SLAVE = new RegionTypeEnum("slave");

            private static readonly Dictionary<string, RegionTypeEnum> StaticFields =
            new Dictionary<string, RegionTypeEnum>()
            {
                { "master", MASTER },
                { "slave", SLAVE },
            };

            private string _value;

            public RegionTypeEnum()
            {

            }

            public RegionTypeEnum(string value)
            {
                _value = value;
            }

            public static RegionTypeEnum FromValue(string value)
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

                if (this.Equals(obj as RegionTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RegionTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RegionTypeEnum a, RegionTypeEnum b)
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

            public static bool operator !=(RegionTypeEnum a, RegionTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 信号类型，splice_insert/time_signal。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 广告信号的Event ID，Time Signal打印数组第一个。
        /// </summary>
        [JsonProperty("event_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? EventId { get; set; }

        /// <summary>
        /// 广告信号的执行时间，unix time，单位：秒。
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartDate { get; set; }

        /// <summary>
        /// 广告信号时长，-1表示没有携带,单位：秒。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// // Splice Insert填空\&quot;-\&quot;； // Time Signal，支持0x30，0x31，0x32，0x33，0x34，0x35，0x36，0x37 // 0x30: ProviderAdvertisementStart // 0x31: ProviderAdvertisementEnd // 0x32: DistributorAdvertisementStart // 0x33: DistributorAdvertisementEnd // 0x34: ProviderPlacementOpportunityStart // 0x35: ProviderPlacementOpportunityEnd // 0x36: DistributorPlacementOpportunityStart // 0x37: DistributorPlacementOpportunityEnd
        /// </summary>
        [JsonProperty("segmentation_type", NullValueHandling = NullValueHandling.Ignore)]
        public SegmentationTypeEnum SegmentationType { get; set; }
        /// <summary>
        /// 广告信号原始数据的base64值。
        /// </summary>
        [JsonProperty("base64_data", NullValueHandling = NullValueHandling.Ignore)]
        public string Base64Data { get; set; }

        /// <summary>
        /// 广告信号全量信息。
        /// </summary>
        [JsonProperty("raw_splice", NullValueHandling = NullValueHandling.Ignore)]
        public string RawSplice { get; set; }

        /// <summary>
        /// **参数解释**： 该广告信号对应的region类型，是主region，还是备region **取值范围**：  - master: 主region  - slave: 备region 
        /// </summary>
        [JsonProperty("region_type", NullValueHandling = NullValueHandling.Ignore)]
        public RegionTypeEnum RegionType { get; set; }
        /// <summary>
        /// **参数解释**： 该广告信号对应的region区域 **取值范围**： 华为云的region 
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCTE35InfoItem {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  eventId: ").Append(EventId).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  segmentationType: ").Append(SegmentationType).Append("\n");
            sb.Append("  base64Data: ").Append(Base64Data).Append("\n");
            sb.Append("  rawSplice: ").Append(RawSplice).Append("\n");
            sb.Append("  regionType: ").Append(RegionType).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SCTE35InfoItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SCTE35InfoItem input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.EventId != input.EventId || (this.EventId != null && !this.EventId.Equals(input.EventId))) return false;
            if (this.StartDate != input.StartDate || (this.StartDate != null && !this.StartDate.Equals(input.StartDate))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.SegmentationType != input.SegmentationType) return false;
            if (this.Base64Data != input.Base64Data || (this.Base64Data != null && !this.Base64Data.Equals(input.Base64Data))) return false;
            if (this.RawSplice != input.RawSplice || (this.RawSplice != null && !this.RawSplice.Equals(input.RawSplice))) return false;
            if (this.RegionType != input.RegionType) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.EventId != null) hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.StartDate != null) hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                hashCode = hashCode * 59 + this.SegmentationType.GetHashCode();
                if (this.Base64Data != null) hashCode = hashCode * 59 + this.Base64Data.GetHashCode();
                if (this.RawSplice != null) hashCode = hashCode * 59 + this.RawSplice.GetHashCode();
                hashCode = hashCode * 59 + this.RegionType.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                return hashCode;
            }
        }
    }
}
