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
    /// 资源使用信息
    /// </summary>
    public class ResourceUsageInfo 
    {
        /// <summary>
        /// 业务类型。 * VOICE_CLONE：声音制作 * SYNTHETICS_SOUND：声音合成 * ASSET_MANAGER：资产管理 * MODELING_2D：形象制作 * LIVE_2D：分身数字人视频直播 * VIDEO_2D：分身数字人视频制作 * CHAT_2D：分身数字人智能交互 * BUSINESS_CARD_2D：分身数字人名片 * PICTURE_2D：照片数字人视频 * MODELING_3D：3D照片建模 * VDS_3D：3D视觉驱动 * TTSA_3D：3D语音驱动 * FLEXUS_2D：FLEXUS版本资源
        /// </summary>
        /// <value>业务类型。 * VOICE_CLONE：声音制作 * SYNTHETICS_SOUND：声音合成 * ASSET_MANAGER：资产管理 * MODELING_2D：形象制作 * LIVE_2D：分身数字人视频直播 * VIDEO_2D：分身数字人视频制作 * CHAT_2D：分身数字人智能交互 * BUSINESS_CARD_2D：分身数字人名片 * PICTURE_2D：照片数字人视频 * MODELING_3D：3D照片建模 * VDS_3D：3D视觉驱动 * TTSA_3D：3D语音驱动 * FLEXUS_2D：FLEXUS版本资源</value>
        [JsonConverter(typeof(EnumClassConverter<BusinessTypeEnum>))]
        public class BusinessTypeEnum
        {
            /// <summary>
            /// Enum VOICE_CLONE for value: VOICE_CLONE
            /// </summary>
            public static readonly BusinessTypeEnum VOICE_CLONE = new BusinessTypeEnum("VOICE_CLONE");

            /// <summary>
            /// Enum SYNTHETICS_SOUND for value: SYNTHETICS_SOUND
            /// </summary>
            public static readonly BusinessTypeEnum SYNTHETICS_SOUND = new BusinessTypeEnum("SYNTHETICS_SOUND");

            /// <summary>
            /// Enum ASSET_MANAGER for value: ASSET_MANAGER
            /// </summary>
            public static readonly BusinessTypeEnum ASSET_MANAGER = new BusinessTypeEnum("ASSET_MANAGER");

            /// <summary>
            /// Enum MODELING_2D for value: MODELING_2D
            /// </summary>
            public static readonly BusinessTypeEnum MODELING_2D = new BusinessTypeEnum("MODELING_2D");

            /// <summary>
            /// Enum LIVE_2D for value: LIVE_2D
            /// </summary>
            public static readonly BusinessTypeEnum LIVE_2D = new BusinessTypeEnum("LIVE_2D");

            /// <summary>
            /// Enum VIDEO_2D for value: VIDEO_2D
            /// </summary>
            public static readonly BusinessTypeEnum VIDEO_2D = new BusinessTypeEnum("VIDEO_2D");

            /// <summary>
            /// Enum CHAT_2D for value: CHAT_2D
            /// </summary>
            public static readonly BusinessTypeEnum CHAT_2D = new BusinessTypeEnum("CHAT_2D");

            /// <summary>
            /// Enum BUSINESS_CARD_2D for value: BUSINESS_CARD_2D
            /// </summary>
            public static readonly BusinessTypeEnum BUSINESS_CARD_2D = new BusinessTypeEnum("BUSINESS_CARD_2D");

            /// <summary>
            /// Enum PICTURE_2D for value: PICTURE_2D
            /// </summary>
            public static readonly BusinessTypeEnum PICTURE_2D = new BusinessTypeEnum("PICTURE_2D");

            /// <summary>
            /// Enum MODELING_3D for value: MODELING_3D
            /// </summary>
            public static readonly BusinessTypeEnum MODELING_3D = new BusinessTypeEnum("MODELING_3D");

            /// <summary>
            /// Enum VDS_3D for value: VDS_3D
            /// </summary>
            public static readonly BusinessTypeEnum VDS_3D = new BusinessTypeEnum("VDS_3D");

            /// <summary>
            /// Enum TTSA_3D for value: TTSA_3D
            /// </summary>
            public static readonly BusinessTypeEnum TTSA_3D = new BusinessTypeEnum("TTSA_3D");

            /// <summary>
            /// Enum FLEXUS_2D for value: FLEXUS_2D
            /// </summary>
            public static readonly BusinessTypeEnum FLEXUS_2D = new BusinessTypeEnum("FLEXUS_2D");

            private static readonly Dictionary<string, BusinessTypeEnum> StaticFields =
            new Dictionary<string, BusinessTypeEnum>()
            {
                { "VOICE_CLONE", VOICE_CLONE },
                { "SYNTHETICS_SOUND", SYNTHETICS_SOUND },
                { "ASSET_MANAGER", ASSET_MANAGER },
                { "MODELING_2D", MODELING_2D },
                { "LIVE_2D", LIVE_2D },
                { "VIDEO_2D", VIDEO_2D },
                { "CHAT_2D", CHAT_2D },
                { "BUSINESS_CARD_2D", BUSINESS_CARD_2D },
                { "PICTURE_2D", PICTURE_2D },
                { "MODELING_3D", MODELING_3D },
                { "VDS_3D", VDS_3D },
                { "TTSA_3D", TTSA_3D },
                { "FLEXUS_2D", FLEXUS_2D },
            };

            private string _value;

            public BusinessTypeEnum()
            {

            }

            public BusinessTypeEnum(string value)
            {
                _value = value;
            }

            public static BusinessTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BusinessTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BusinessTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BusinessTypeEnum a, BusinessTypeEnum b)
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

            public static bool operator !=(BusinessTypeEnum a, BusinessTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 计费类型。 * PERIODIC: 包周期 * ONE_TIME：一次性 * ON_DEMAND：按需
        /// </summary>
        /// <value>计费类型。 * PERIODIC: 包周期 * ONE_TIME：一次性 * ON_DEMAND：按需</value>
        [JsonConverter(typeof(EnumClassConverter<ChargingModeEnum>))]
        public class ChargingModeEnum
        {
            /// <summary>
            /// Enum PERIODIC for value: PERIODIC
            /// </summary>
            public static readonly ChargingModeEnum PERIODIC = new ChargingModeEnum("PERIODIC");

            /// <summary>
            /// Enum ONE_TIME for value: ONE_TIME
            /// </summary>
            public static readonly ChargingModeEnum ONE_TIME = new ChargingModeEnum("ONE_TIME");

            /// <summary>
            /// Enum ON_DEMAND for value: ON_DEMAND
            /// </summary>
            public static readonly ChargingModeEnum ON_DEMAND = new ChargingModeEnum("ON_DEMAND");

            private static readonly Dictionary<string, ChargingModeEnum> StaticFields =
            new Dictionary<string, ChargingModeEnum>()
            {
                { "PERIODIC", PERIODIC },
                { "ONE_TIME", ONE_TIME },
                { "ON_DEMAND", ON_DEMAND },
            };

            private string _value;

            public ChargingModeEnum()
            {

            }

            public ChargingModeEnum(string value)
            {
                _value = value;
            }

            public static ChargingModeEnum FromValue(string value)
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

                if (this.Equals(obj as ChargingModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargingModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChargingModeEnum a, ChargingModeEnum b)
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

            public static bool operator !=(ChargingModeEnum a, ChargingModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 单位。 * NUM：个数(形象/声音) * MIN：分钟（视频制作） * HOUR：小时 （直播） * CHANNEL：路（直播/交互） * GB：GB(资产管理) * MILLION_WORDS：百万字 * TEN_THOUSAND_WORDS：万字 * TIME：次
        /// </summary>
        /// <value>单位。 * NUM：个数(形象/声音) * MIN：分钟（视频制作） * HOUR：小时 （直播） * CHANNEL：路（直播/交互） * GB：GB(资产管理) * MILLION_WORDS：百万字 * TEN_THOUSAND_WORDS：万字 * TIME：次</value>
        [JsonConverter(typeof(EnumClassConverter<UnitEnum>))]
        public class UnitEnum
        {
            /// <summary>
            /// Enum NUM for value: NUM
            /// </summary>
            public static readonly UnitEnum NUM = new UnitEnum("NUM");

            /// <summary>
            /// Enum MIN for value: MIN
            /// </summary>
            public static readonly UnitEnum MIN = new UnitEnum("MIN");

            /// <summary>
            /// Enum HOUR for value: HOUR
            /// </summary>
            public static readonly UnitEnum HOUR = new UnitEnum("HOUR");

            /// <summary>
            /// Enum CHANNEL for value: CHANNEL
            /// </summary>
            public static readonly UnitEnum CHANNEL = new UnitEnum("CHANNEL");

            /// <summary>
            /// Enum GB for value: GB
            /// </summary>
            public static readonly UnitEnum GB = new UnitEnum("GB");

            /// <summary>
            /// Enum MILLION_WORDS for value: MILLION_WORDS
            /// </summary>
            public static readonly UnitEnum MILLION_WORDS = new UnitEnum("MILLION_WORDS");

            /// <summary>
            /// Enum TEN_THOUSAND_WORDS for value: TEN_THOUSAND_WORDS
            /// </summary>
            public static readonly UnitEnum TEN_THOUSAND_WORDS = new UnitEnum("TEN_THOUSAND_WORDS");

            /// <summary>
            /// Enum TIME for value: TIME
            /// </summary>
            public static readonly UnitEnum TIME = new UnitEnum("TIME");

            private static readonly Dictionary<string, UnitEnum> StaticFields =
            new Dictionary<string, UnitEnum>()
            {
                { "NUM", NUM },
                { "MIN", MIN },
                { "HOUR", HOUR },
                { "CHANNEL", CHANNEL },
                { "GB", GB },
                { "MILLION_WORDS", MILLION_WORDS },
                { "TEN_THOUSAND_WORDS", TEN_THOUSAND_WORDS },
                { "TIME", TIME },
            };

            private string _value;

            public UnitEnum()
            {

            }

            public UnitEnum(string value)
            {
                _value = value;
            }

            public static UnitEnum FromValue(string value)
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

                if (this.Equals(obj as UnitEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UnitEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UnitEnum a, UnitEnum b)
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

            public static bool operator !=(UnitEnum a, UnitEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资源类型。详见[资源类型](metastudio_02_0042.xml)。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 业务类型。 * VOICE_CLONE：声音制作 * SYNTHETICS_SOUND：声音合成 * ASSET_MANAGER：资产管理 * MODELING_2D：形象制作 * LIVE_2D：分身数字人视频直播 * VIDEO_2D：分身数字人视频制作 * CHAT_2D：分身数字人智能交互 * BUSINESS_CARD_2D：分身数字人名片 * PICTURE_2D：照片数字人视频 * MODELING_3D：3D照片建模 * VDS_3D：3D视觉驱动 * TTSA_3D：3D语音驱动 * FLEXUS_2D：FLEXUS版本资源
        /// </summary>
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public BusinessTypeEnum BusinessType { get; set; }
        /// <summary>
        /// 子资源类型。当前只有flexus套餐包存在该字段 * voice_clone_flexus: 语音克隆Flexus版 * modeling_count_2d_model_flexus: 分身数字人形象制作Flexus版 * video_time_flexus_2d_model: 分身数字人Flexus版本视频制作
        /// </summary>
        [JsonProperty("sub_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubResourceType { get; set; }

        /// <summary>
        /// 是否子资源。子资源描述的是子资源的数量和单位
        /// </summary>
        [JsonProperty("is_sub_resource", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSubResource { get; set; }

        /// <summary>
        /// 计费类型。 * PERIODIC: 包周期 * ONE_TIME：一次性 * ON_DEMAND：按需
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargingModeEnum ChargingMode { get; set; }
        /// <summary>
        /// 资源来源。 * PURCHASED: 购买 * SP_ALLOCATED：SP分配 * ADMIN_ALLOCATED：系统管理员分配
        /// </summary>
        [JsonProperty("resource_source", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSource { get; set; }

        /// <summary>
        /// 总量
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public float? Amount { get; set; }

        /// <summary>
        /// 使用量
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public float? Usage { get; set; }

        /// <summary>
        /// 单位。 * NUM：个数(形象/声音) * MIN：分钟（视频制作） * HOUR：小时 （直播） * CHANNEL：路（直播/交互） * GB：GB(资产管理) * MILLION_WORDS：百万字 * TEN_THOUSAND_WORDS：万字 * TIME：次
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public UnitEnum Unit { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceUsageInfo {\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  subResourceType: ").Append(SubResourceType).Append("\n");
            sb.Append("  isSubResource: ").Append(IsSubResource).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  resourceSource: ").Append(ResourceSource).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  usage: ").Append(Usage).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceUsageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceUsageInfo input)
        {
            if (input == null) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.BusinessType != input.BusinessType) return false;
            if (this.SubResourceType != input.SubResourceType || (this.SubResourceType != null && !this.SubResourceType.Equals(input.SubResourceType))) return false;
            if (this.IsSubResource != input.IsSubResource || (this.IsSubResource != null && !this.IsSubResource.Equals(input.IsSubResource))) return false;
            if (this.ChargingMode != input.ChargingMode) return false;
            if (this.ResourceSource != input.ResourceSource || (this.ResourceSource != null && !this.ResourceSource.Equals(input.ResourceSource))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.Usage != input.Usage || (this.Usage != null && !this.Usage.Equals(input.Usage))) return false;
            if (this.Unit != input.Unit) return false;

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
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.SubResourceType != null) hashCode = hashCode * 59 + this.SubResourceType.GetHashCode();
                if (this.IsSubResource != null) hashCode = hashCode * 59 + this.IsSubResource.GetHashCode();
                hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.ResourceSource != null) hashCode = hashCode * 59 + this.ResourceSource.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Usage != null) hashCode = hashCode * 59 + this.Usage.GetHashCode();
                hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }
    }
}
