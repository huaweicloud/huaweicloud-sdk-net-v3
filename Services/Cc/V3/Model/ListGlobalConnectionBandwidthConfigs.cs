using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 租户购买全域互联带宽的动态配置项。
    /// </summary>
    public class ListGlobalConnectionBandwidthConfigs 
    {
        /// <summary>
        /// 计费类型： - bwd: 按带宽计费 - 95: 按传统型95计费 - 95avr (日95计费)
        /// </summary>
        /// <value>计费类型： - bwd: 按带宽计费 - 95: 按传统型95计费 - 95avr (日95计费)</value>
        [JsonConverter(typeof(EnumClassConverter<ChargeModeEnum>))]
        public class ChargeModeEnum
        {
            /// <summary>
            /// Enum BWD for value: bwd
            /// </summary>
            public static readonly ChargeModeEnum BWD = new ChargeModeEnum("bwd");

            /// <summary>
            /// Enum _95 for value: 95
            /// </summary>
            public static readonly ChargeModeEnum _95 = new ChargeModeEnum("95");

            /// <summary>
            /// Enum _95AVR for value: 95avr
            /// </summary>
            public static readonly ChargeModeEnum _95AVR = new ChargeModeEnum("95avr");

            private static readonly Dictionary<string, ChargeModeEnum> StaticFields =
            new Dictionary<string, ChargeModeEnum>()
            {
                { "bwd", BWD },
                { "95", _95 },
                { "95avr", _95AVR },
            };

            private string _value;

            public ChargeModeEnum()
            {

            }

            public ChargeModeEnum(string value)
            {
                _value = value;
            }

            public static ChargeModeEnum FromValue(string value)
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

                if (this.Equals(obj as ChargeModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargeModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChargeModeEnum a, ChargeModeEnum b)
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

            public static bool operator !=(ChargeModeEnum a, ChargeModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 支持服务实例类型： - CC: 云连接 - GEIP: 全域弹性公网IP - GCN: 中心网络 - GSN: 分支网络
        /// </summary>
        /// <value>支持服务实例类型： - CC: 云连接 - GEIP: 全域弹性公网IP - GCN: 中心网络 - GSN: 分支网络</value>
        [JsonConverter(typeof(EnumClassConverter<ServicesEnum>))]
        public class ServicesEnum
        {
            /// <summary>
            /// Enum CC for value: CC
            /// </summary>
            public static readonly ServicesEnum CC = new ServicesEnum("CC");

            /// <summary>
            /// Enum GEIP for value: GEIP
            /// </summary>
            public static readonly ServicesEnum GEIP = new ServicesEnum("GEIP");

            /// <summary>
            /// Enum GCN for value: GCN
            /// </summary>
            public static readonly ServicesEnum GCN = new ServicesEnum("GCN");

            /// <summary>
            /// Enum GSN for value: GSN
            /// </summary>
            public static readonly ServicesEnum GSN = new ServicesEnum("GSN");

            private static readonly Dictionary<string, ServicesEnum> StaticFields =
            new Dictionary<string, ServicesEnum>()
            {
                { "CC", CC },
                { "GEIP", GEIP },
                { "GCN", GCN },
                { "GSN", GSN },
            };

            private string _value;

            public ServicesEnum()
            {

            }

            public ServicesEnum(string value)
            {
                _value = value;
            }

            public static ServicesEnum FromValue(string value)
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

                if (this.Equals(obj as ServicesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ServicesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ServicesEnum a, ServicesEnum b)
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

            public static bool operator !=(ServicesEnum a, ServicesEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 支持的带宽类型： - TrsArea: 跨区带宽 - Area: 大区带宽 - SubArea: 区域带宽 - Region: 城域带宽
        /// </summary>
        /// <value>支持的带宽类型： - TrsArea: 跨区带宽 - Area: 大区带宽 - SubArea: 区域带宽 - Region: 城域带宽</value>
        [JsonConverter(typeof(EnumClassConverter<GcbTypeEnum>))]
        public class GcbTypeEnum
        {
            /// <summary>
            /// Enum REGION for value: Region
            /// </summary>
            public static readonly GcbTypeEnum REGION = new GcbTypeEnum("Region");

            /// <summary>
            /// Enum SUBAREA for value: SubArea
            /// </summary>
            public static readonly GcbTypeEnum SUBAREA = new GcbTypeEnum("SubArea");

            /// <summary>
            /// Enum AREA for value: Area
            /// </summary>
            public static readonly GcbTypeEnum AREA = new GcbTypeEnum("Area");

            /// <summary>
            /// Enum TRSAREA for value: TrsArea
            /// </summary>
            public static readonly GcbTypeEnum TRSAREA = new GcbTypeEnum("TrsArea");

            private static readonly Dictionary<string, GcbTypeEnum> StaticFields =
            new Dictionary<string, GcbTypeEnum>()
            {
                { "Region", REGION },
                { "SubArea", SUBAREA },
                { "Area", AREA },
                { "TrsArea", TRSAREA },
            };

            private string _value;

            public GcbTypeEnum()
            {

            }

            public GcbTypeEnum(string value)
            {
                _value = value;
            }

            public static GcbTypeEnum FromValue(string value)
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

                if (this.Equals(obj as GcbTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(GcbTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(GcbTypeEnum a, GcbTypeEnum b)
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

            public static bool operator !=(GcbTypeEnum a, GcbTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 支持线路分级： - Pt: 铂金 - Au: 金 - Ag: 银
        /// </summary>
        /// <value>支持线路分级： - Pt: 铂金 - Au: 金 - Ag: 银</value>
        [JsonConverter(typeof(EnumClassConverter<SlaLevelEnum>))]
        public class SlaLevelEnum
        {
            /// <summary>
            /// Enum PT for value: Pt
            /// </summary>
            public static readonly SlaLevelEnum PT = new SlaLevelEnum("Pt");

            /// <summary>
            /// Enum AU for value: Au
            /// </summary>
            public static readonly SlaLevelEnum AU = new SlaLevelEnum("Au");

            /// <summary>
            /// Enum AG for value: Ag
            /// </summary>
            public static readonly SlaLevelEnum AG = new SlaLevelEnum("Ag");

            private static readonly Dictionary<string, SlaLevelEnum> StaticFields =
            new Dictionary<string, SlaLevelEnum>()
            {
                { "Pt", PT },
                { "Au", AU },
                { "Ag", AG },
            };

            private string _value;

            public SlaLevelEnum()
            {

            }

            public SlaLevelEnum(string value)
            {
                _value = value;
            }

            public static SlaLevelEnum FromValue(string value)
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

                if (this.Equals(obj as SlaLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SlaLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SlaLevelEnum a, SlaLevelEnum b)
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

            public static bool operator !=(SlaLevelEnum a, SlaLevelEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 计费类型对应全域互联带宽大小范围。
        /// </summary>
        [JsonProperty("size_range", NullValueHandling = NullValueHandling.Ignore)]
        public List<GlobalConnectionBandwidthSizeRange> SizeRange { get; set; }

        /// <summary>
        /// 支持的计费类型列表。
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChargeModeEnum> ChargeMode { get; set; }
        /// <summary>
        /// 支持服务实例类型。
        /// </summary>
        [JsonProperty("services", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServicesEnum> Services { get; set; }
        /// <summary>
        /// 支持的带宽类型。
        /// </summary>
        [JsonProperty("gcb_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<GcbTypeEnum> GcbType { get; set; }
        /// <summary>
        /// 按增强型95计费保底消费百分比。
        /// </summary>
        [JsonProperty("ratio_95peak_plus", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ratio95peakPlus { get; set; }

        /// <summary>
        /// 按传统型95计费保底消费百分比。
        /// </summary>
        [JsonProperty("ratio_95peak_guar", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ratio95peakGuar { get; set; }

        /// <summary>
        /// 是否已经完成跨境审批。
        /// </summary>
        [JsonProperty("crossborder", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Crossborder { get; set; }

        /// <summary>
        /// 配额信息。
        /// </summary>
        [JsonProperty("quotas", NullValueHandling = NullValueHandling.Ignore)]
        public List<GlobalConnectionBandwidthQuotas> Quotas { get; set; }

        /// <summary>
        /// 支持线路分级。
        /// </summary>
        [JsonProperty("sla_level", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaLevelEnum> SlaLevel { get; set; }
        /// <summary>
        /// 共享带宽允许绑定实例数量上限。
        /// </summary>
        [JsonProperty("bind_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? BindLimit { get; set; }

        /// <summary>
        /// 是否启用传统的大区带宽。
        /// </summary>
        [JsonProperty("enable_area_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAreaBandwidth { get; set; }

        /// <summary>
        /// 是否支持95转按需。
        /// </summary>
        [JsonProperty("enable_change_95", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableChange95 { get; set; }

        /// <summary>
        /// 是否支持多SKU产品功能。
        /// </summary>
        [JsonProperty("enable_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSpecCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListGlobalConnectionBandwidthConfigs {\n");
            sb.Append("  sizeRange: ").Append(SizeRange).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  services: ").Append(Services).Append("\n");
            sb.Append("  gcbType: ").Append(GcbType).Append("\n");
            sb.Append("  ratio95peakPlus: ").Append(Ratio95peakPlus).Append("\n");
            sb.Append("  ratio95peakGuar: ").Append(Ratio95peakGuar).Append("\n");
            sb.Append("  crossborder: ").Append(Crossborder).Append("\n");
            sb.Append("  quotas: ").Append(Quotas).Append("\n");
            sb.Append("  slaLevel: ").Append(SlaLevel).Append("\n");
            sb.Append("  bindLimit: ").Append(BindLimit).Append("\n");
            sb.Append("  enableAreaBandwidth: ").Append(EnableAreaBandwidth).Append("\n");
            sb.Append("  enableChange95: ").Append(EnableChange95).Append("\n");
            sb.Append("  enableSpecCode: ").Append(EnableSpecCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGlobalConnectionBandwidthConfigs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGlobalConnectionBandwidthConfigs input)
        {
            if (input == null) return false;
            if (this.SizeRange != input.SizeRange || (this.SizeRange != null && input.SizeRange != null && !this.SizeRange.SequenceEqual(input.SizeRange))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && input.ChargeMode != null && !this.ChargeMode.SequenceEqual(input.ChargeMode))) return false;
            if (this.Services != input.Services || (this.Services != null && input.Services != null && !this.Services.SequenceEqual(input.Services))) return false;
            if (this.GcbType != input.GcbType || (this.GcbType != null && input.GcbType != null && !this.GcbType.SequenceEqual(input.GcbType))) return false;
            if (this.Ratio95peakPlus != input.Ratio95peakPlus || (this.Ratio95peakPlus != null && !this.Ratio95peakPlus.Equals(input.Ratio95peakPlus))) return false;
            if (this.Ratio95peakGuar != input.Ratio95peakGuar || (this.Ratio95peakGuar != null && !this.Ratio95peakGuar.Equals(input.Ratio95peakGuar))) return false;
            if (this.Crossborder != input.Crossborder || (this.Crossborder != null && !this.Crossborder.Equals(input.Crossborder))) return false;
            if (this.Quotas != input.Quotas || (this.Quotas != null && input.Quotas != null && !this.Quotas.SequenceEqual(input.Quotas))) return false;
            if (this.SlaLevel != input.SlaLevel || (this.SlaLevel != null && input.SlaLevel != null && !this.SlaLevel.SequenceEqual(input.SlaLevel))) return false;
            if (this.BindLimit != input.BindLimit || (this.BindLimit != null && !this.BindLimit.Equals(input.BindLimit))) return false;
            if (this.EnableAreaBandwidth != input.EnableAreaBandwidth || (this.EnableAreaBandwidth != null && !this.EnableAreaBandwidth.Equals(input.EnableAreaBandwidth))) return false;
            if (this.EnableChange95 != input.EnableChange95 || (this.EnableChange95 != null && !this.EnableChange95.Equals(input.EnableChange95))) return false;
            if (this.EnableSpecCode != input.EnableSpecCode || (this.EnableSpecCode != null && !this.EnableSpecCode.Equals(input.EnableSpecCode))) return false;

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
                if (this.SizeRange != null) hashCode = hashCode * 59 + this.SizeRange.GetHashCode();
                hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                hashCode = hashCode * 59 + this.Services.GetHashCode();
                hashCode = hashCode * 59 + this.GcbType.GetHashCode();
                if (this.Ratio95peakPlus != null) hashCode = hashCode * 59 + this.Ratio95peakPlus.GetHashCode();
                if (this.Ratio95peakGuar != null) hashCode = hashCode * 59 + this.Ratio95peakGuar.GetHashCode();
                if (this.Crossborder != null) hashCode = hashCode * 59 + this.Crossborder.GetHashCode();
                if (this.Quotas != null) hashCode = hashCode * 59 + this.Quotas.GetHashCode();
                hashCode = hashCode * 59 + this.SlaLevel.GetHashCode();
                if (this.BindLimit != null) hashCode = hashCode * 59 + this.BindLimit.GetHashCode();
                if (this.EnableAreaBandwidth != null) hashCode = hashCode * 59 + this.EnableAreaBandwidth.GetHashCode();
                if (this.EnableChange95 != null) hashCode = hashCode * 59 + this.EnableChange95.GetHashCode();
                if (this.EnableSpecCode != null) hashCode = hashCode * 59 + this.EnableSpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
