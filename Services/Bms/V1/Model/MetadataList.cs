using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// metadata数据结构说明
    /// </summary>
    public class MetadataList 
    {
        /// <summary>
        /// 裸金属服务器的计费类型。1：按包年包月计费（即prePaid：预付费方式）。
        /// </summary>
        /// <value>裸金属服务器的计费类型。1：按包年包月计费（即prePaid：预付费方式）。</value>
        [JsonConverter(typeof(EnumClassConverter<ChargingModeEnum>))]
        public class ChargingModeEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly ChargingModeEnum _1 = new ChargingModeEnum("1");

            private static readonly Dictionary<string, ChargingModeEnum> StaticFields =
            new Dictionary<string, ChargingModeEnum>()
            {
                { "1", _1 },
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

            public static bool operator !=(ChargingModeEnum a, ChargingModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 镜像类型，目前支持：公共镜像（gold）私有镜像（private）共享镜像（shared）
        /// </summary>
        /// <value>镜像类型，目前支持：公共镜像（gold）私有镜像（private）共享镜像（shared）</value>
        [JsonConverter(typeof(EnumClassConverter<MeteringImagetypeEnum>))]
        public class MeteringImagetypeEnum
        {
            /// <summary>
            /// Enum GOLD for value: gold
            /// </summary>
            public static readonly MeteringImagetypeEnum GOLD = new MeteringImagetypeEnum("gold");

            /// <summary>
            /// Enum PRIVATE for value: private
            /// </summary>
            public static readonly MeteringImagetypeEnum PRIVATE = new MeteringImagetypeEnum("private");

            /// <summary>
            /// Enum SHARED for value: shared
            /// </summary>
            public static readonly MeteringImagetypeEnum SHARED = new MeteringImagetypeEnum("shared");

            private static readonly Dictionary<string, MeteringImagetypeEnum> StaticFields =
            new Dictionary<string, MeteringImagetypeEnum>()
            {
                { "gold", GOLD },
                { "private", PRIVATE },
                { "shared", SHARED },
            };

            private string _value;

            public MeteringImagetypeEnum()
            {

            }

            public MeteringImagetypeEnum(string value)
            {
                _value = value;
            }

            public static MeteringImagetypeEnum FromValue(string value)
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

                if (this.Equals(obj as MeteringImagetypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MeteringImagetypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MeteringImagetypeEnum a, MeteringImagetypeEnum b)
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

            public static bool operator !=(MeteringImagetypeEnum a, MeteringImagetypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 操作系统类型，取值为：Linux、Windows
        /// </summary>
        /// <value>操作系统类型，取值为：Linux、Windows</value>
        [JsonConverter(typeof(EnumClassConverter<OsTypeEnum>))]
        public class OsTypeEnum
        {
            /// <summary>
            /// Enum LINUX for value: Linux
            /// </summary>
            public static readonly OsTypeEnum LINUX = new OsTypeEnum("Linux");

            /// <summary>
            /// Enum WINDOWS for value: Windows
            /// </summary>
            public static readonly OsTypeEnum WINDOWS = new OsTypeEnum("Windows");

            private static readonly Dictionary<string, OsTypeEnum> StaticFields =
            new Dictionary<string, OsTypeEnum>()
            {
                { "Linux", LINUX },
                { "Windows", WINDOWS },
            };

            private string _value;

            public OsTypeEnum()
            {

            }

            public OsTypeEnum(string value)
            {
                _value = value;
            }

            public static OsTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OsTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OsTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OsTypeEnum a, OsTypeEnum b)
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

            public static bool operator !=(OsTypeEnum a, OsTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 操作系统位数，一般取值为“32”或者“64”。
        /// </summary>
        /// <value>操作系统位数，一般取值为“32”或者“64”。</value>
        [JsonConverter(typeof(EnumClassConverter<OsBitEnum>))]
        public class OsBitEnum
        {
            /// <summary>
            /// Enum _32 for value: 32
            /// </summary>
            public static readonly OsBitEnum _32 = new OsBitEnum("32");

            /// <summary>
            /// Enum _64 for value: 64
            /// </summary>
            public static readonly OsBitEnum _64 = new OsBitEnum("64");

            private static readonly Dictionary<string, OsBitEnum> StaticFields =
            new Dictionary<string, OsBitEnum>()
            {
                { "32", _32 },
                { "64", _64 },
            };

            private string _value;

            public OsBitEnum()
            {

            }

            public OsBitEnum(string value)
            {
                _value = value;
            }

            public static OsBitEnum FromValue(string value)
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

                if (this.Equals(obj as OsBitEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OsBitEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OsBitEnum a, OsBitEnum b)
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

            public static bool operator !=(OsBitEnum a, OsBitEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 裸金属服务器的计费类型。1：按包年包月计费（即prePaid：预付费方式）。
        /// </summary>
        [JsonProperty("chargingMode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargingModeEnum ChargingMode { get; set; }
        /// <summary>
        /// 按“包年/包月”计费的裸金属服务器对应的订单ID。
        /// </summary>
        [JsonProperty("metering.order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MeteringOrderId { get; set; }

        /// <summary>
        /// 按“包年/包月”计费的裸金属服务器对应的产品ID
        /// </summary>
        [JsonProperty("metering.product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MeteringProductId { get; set; }

        /// <summary>
        /// 裸金属服务器所属的虚拟私有云ID
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? VpcId { get; set; }

        /// <summary>
        /// 裸金属服务器操作系统对应的镜像ID
        /// </summary>
        [JsonProperty("metering.image_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? MeteringImageId { get; set; }

        /// <summary>
        /// 镜像类型，目前支持：公共镜像（gold）私有镜像（private）共享镜像（shared）
        /// </summary>
        [JsonProperty("metering.imagetype", NullValueHandling = NullValueHandling.Ignore)]
        public MeteringImagetypeEnum MeteringImagetype { get; set; }
        /// <summary>
        /// 裸金属服务器的网卡列表。
        /// </summary>
        [JsonProperty("baremetalPortIDList", NullValueHandling = NullValueHandling.Ignore)]
        public string BaremetalPortIDList { get; set; }

        /// <summary>
        /// 裸金属服务器对应的资源规格编码，格式为：{规格ID}.{os_type}，例如physical.o2.medium.linux。
        /// </summary>
        [JsonProperty("metering.resourcespeccode", NullValueHandling = NullValueHandling.Ignore)]
        public string MeteringResourcespeccode { get; set; }

        /// <summary>
        /// 裸金属服务器对应的资源类型，取值为：hws.resource.type.pm
        /// </summary>
        [JsonProperty("metering.resourcetype", NullValueHandling = NullValueHandling.Ignore)]
        public string MeteringResourcetype { get; set; }

        /// <summary>
        /// 裸金属服务器操作系统对应的镜像名称
        /// </summary>
        [JsonProperty("image_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageName { get; set; }

        /// <summary>
        /// 用户ID（登录管理控制台，进入我的凭证，即可看到“用户ID”）
        /// </summary>
        [JsonProperty("op_svc_userid", NullValueHandling = NullValueHandling.Ignore)]
        public string OpSvcUserid { get; set; }

        /// <summary>
        /// 操作系统类型，取值为：Linux、Windows
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public OsTypeEnum OsType { get; set; }
        /// <summary>
        /// 裸金属服务器是否支持EVS卷。
        /// </summary>
        [JsonProperty("__bms_support_evs", NullValueHandling = NullValueHandling.Ignore)]
        public string BmsSupportEvs { get; set; }

        /// <summary>
        /// 操作系统位数，一般取值为“32”或者“64”。
        /// </summary>
        [JsonProperty("os_bit", NullValueHandling = NullValueHandling.Ignore)]
        public OsBitEnum OsBit { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataList {\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  meteringOrderId: ").Append(MeteringOrderId).Append("\n");
            sb.Append("  meteringProductId: ").Append(MeteringProductId).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  meteringImageId: ").Append(MeteringImageId).Append("\n");
            sb.Append("  meteringImagetype: ").Append(MeteringImagetype).Append("\n");
            sb.Append("  baremetalPortIDList: ").Append(BaremetalPortIDList).Append("\n");
            sb.Append("  meteringResourcespeccode: ").Append(MeteringResourcespeccode).Append("\n");
            sb.Append("  meteringResourcetype: ").Append(MeteringResourcetype).Append("\n");
            sb.Append("  imageName: ").Append(ImageName).Append("\n");
            sb.Append("  opSvcUserid: ").Append(OpSvcUserid).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  bmsSupportEvs: ").Append(BmsSupportEvs).Append("\n");
            sb.Append("  osBit: ").Append(OsBit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetadataList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetadataList input)
        {
            if (input == null) return false;
            if (this.ChargingMode != input.ChargingMode) return false;
            if (this.MeteringOrderId != input.MeteringOrderId || (this.MeteringOrderId != null && !this.MeteringOrderId.Equals(input.MeteringOrderId))) return false;
            if (this.MeteringProductId != input.MeteringProductId || (this.MeteringProductId != null && !this.MeteringProductId.Equals(input.MeteringProductId))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.MeteringImageId != input.MeteringImageId || (this.MeteringImageId != null && !this.MeteringImageId.Equals(input.MeteringImageId))) return false;
            if (this.MeteringImagetype != input.MeteringImagetype) return false;
            if (this.BaremetalPortIDList != input.BaremetalPortIDList || (this.BaremetalPortIDList != null && !this.BaremetalPortIDList.Equals(input.BaremetalPortIDList))) return false;
            if (this.MeteringResourcespeccode != input.MeteringResourcespeccode || (this.MeteringResourcespeccode != null && !this.MeteringResourcespeccode.Equals(input.MeteringResourcespeccode))) return false;
            if (this.MeteringResourcetype != input.MeteringResourcetype || (this.MeteringResourcetype != null && !this.MeteringResourcetype.Equals(input.MeteringResourcetype))) return false;
            if (this.ImageName != input.ImageName || (this.ImageName != null && !this.ImageName.Equals(input.ImageName))) return false;
            if (this.OpSvcUserid != input.OpSvcUserid || (this.OpSvcUserid != null && !this.OpSvcUserid.Equals(input.OpSvcUserid))) return false;
            if (this.OsType != input.OsType) return false;
            if (this.BmsSupportEvs != input.BmsSupportEvs || (this.BmsSupportEvs != null && !this.BmsSupportEvs.Equals(input.BmsSupportEvs))) return false;
            if (this.OsBit != input.OsBit) return false;

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
                hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.MeteringOrderId != null) hashCode = hashCode * 59 + this.MeteringOrderId.GetHashCode();
                if (this.MeteringProductId != null) hashCode = hashCode * 59 + this.MeteringProductId.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.MeteringImageId != null) hashCode = hashCode * 59 + this.MeteringImageId.GetHashCode();
                hashCode = hashCode * 59 + this.MeteringImagetype.GetHashCode();
                if (this.BaremetalPortIDList != null) hashCode = hashCode * 59 + this.BaremetalPortIDList.GetHashCode();
                if (this.MeteringResourcespeccode != null) hashCode = hashCode * 59 + this.MeteringResourcespeccode.GetHashCode();
                if (this.MeteringResourcetype != null) hashCode = hashCode * 59 + this.MeteringResourcetype.GetHashCode();
                if (this.ImageName != null) hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.OpSvcUserid != null) hashCode = hashCode * 59 + this.OpSvcUserid.GetHashCode();
                hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.BmsSupportEvs != null) hashCode = hashCode * 59 + this.BmsSupportEvs.GetHashCode();
                hashCode = hashCode * 59 + this.OsBit.GetHashCode();
                return hashCode;
            }
        }
    }
}
