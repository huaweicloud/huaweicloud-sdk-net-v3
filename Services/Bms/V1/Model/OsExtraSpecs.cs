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
    /// os_extra_specs数据结构说明
    /// </summary>
    public class OsExtraSpecs 
    {
        /// <summary>
        /// 识该规格对应的资源类型，取值范围为“ironic”。
        /// </summary>
        /// <value>识该规格对应的资源类型，取值范围为“ironic”。</value>
        [JsonConverter(typeof(EnumClassConverter<ResourceTypeEnum>))]
        public class ResourceTypeEnum
        {
            /// <summary>
            /// Enum IRONIC for value: ironic
            /// </summary>
            public static readonly ResourceTypeEnum IRONIC = new ResourceTypeEnum("ironic");

            private static readonly Dictionary<string, ResourceTypeEnum> StaticFields =
            new Dictionary<string, ResourceTypeEnum>()
            {
                { "ironic", IRONIC },
            };

            private string _value;

            public ResourceTypeEnum()
            {

            }

            public ResourceTypeEnum(string value)
            {
                _value = value;
            }

            public static ResourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ResourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResourceTypeEnum a, ResourceTypeEnum b)
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

            public static bool operator !=(ResourceTypeEnum a, ResourceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 裸金属服务器的CPU架构类型，取值为：x86_64（适用于x86机型）aarch64（适用于ARM机型）
        /// </summary>
        /// <value>裸金属服务器的CPU架构类型，取值为：x86_64（适用于x86机型）aarch64（适用于ARM机型）</value>
        [JsonConverter(typeof(EnumClassConverter<CapabilitiescpuArchEnum>))]
        public class CapabilitiescpuArchEnum
        {
            /// <summary>
            /// Enum X86_64 for value: x86_64
            /// </summary>
            public static readonly CapabilitiescpuArchEnum X86_64 = new CapabilitiescpuArchEnum("x86_64");

            /// <summary>
            /// Enum AARCH64 for value: aarch64
            /// </summary>
            public static readonly CapabilitiescpuArchEnum AARCH64 = new CapabilitiescpuArchEnum("aarch64");

            private static readonly Dictionary<string, CapabilitiescpuArchEnum> StaticFields =
            new Dictionary<string, CapabilitiescpuArchEnum>()
            {
                { "x86_64", X86_64 },
                { "aarch64", AARCH64 },
            };

            private string _value;

            public CapabilitiescpuArchEnum()
            {

            }

            public CapabilitiescpuArchEnum(string value)
            {
                _value = value;
            }

            public static CapabilitiescpuArchEnum FromValue(string value)
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

                if (this.Equals(obj as CapabilitiescpuArchEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CapabilitiescpuArchEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CapabilitiescpuArchEnum a, CapabilitiescpuArchEnum b)
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

            public static bool operator !=(CapabilitiescpuArchEnum a, CapabilitiescpuArchEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 裸金属服务器启动源。LocalDisk：本地盘Volume：云硬盘（快速发放）
        /// </summary>
        /// <value>裸金属服务器启动源。LocalDisk：本地盘Volume：云硬盘（快速发放）</value>
        [JsonConverter(typeof(EnumClassConverter<BaremetalextBootTypeEnum>))]
        public class BaremetalextBootTypeEnum
        {
            /// <summary>
            /// Enum LOCALDISK for value: LocalDisk
            /// </summary>
            public static readonly BaremetalextBootTypeEnum LOCALDISK = new BaremetalextBootTypeEnum("LocalDisk");

            /// <summary>
            /// Enum VOLUME for value: Volume
            /// </summary>
            public static readonly BaremetalextBootTypeEnum VOLUME = new BaremetalextBootTypeEnum("Volume");

            private static readonly Dictionary<string, BaremetalextBootTypeEnum> StaticFields =
            new Dictionary<string, BaremetalextBootTypeEnum>()
            {
                { "LocalDisk", LOCALDISK },
                { "Volume", VOLUME },
            };

            private string _value;

            public BaremetalextBootTypeEnum()
            {

            }

            public BaremetalextBootTypeEnum(string value)
            {
                _value = value;
            }

            public static BaremetalextBootTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BaremetalextBootTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BaremetalextBootTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BaremetalextBootTypeEnum a, BaremetalextBootTypeEnum b)
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

            public static bool operator !=(BaremetalextBootTypeEnum a, BaremetalextBootTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 裸金属服务器规格状态。不配置时等同于normal。normal：正常商用abandon：下线（即不显示）sellout：售罄obt：公测promotion：推荐（等同normal，也是商用）
        /// </summary>
        /// <value>裸金属服务器规格状态。不配置时等同于normal。normal：正常商用abandon：下线（即不显示）sellout：售罄obt：公测promotion：推荐（等同normal，也是商用）</value>
        [JsonConverter(typeof(EnumClassConverter<CondoperationstatusEnum>))]
        public class CondoperationstatusEnum
        {
            /// <summary>
            /// Enum NORMAL for value: normal
            /// </summary>
            public static readonly CondoperationstatusEnum NORMAL = new CondoperationstatusEnum("normal");

            /// <summary>
            /// Enum ABANDON for value: abandon
            /// </summary>
            public static readonly CondoperationstatusEnum ABANDON = new CondoperationstatusEnum("abandon");

            /// <summary>
            /// Enum SELLOUT for value: sellout
            /// </summary>
            public static readonly CondoperationstatusEnum SELLOUT = new CondoperationstatusEnum("sellout");

            /// <summary>
            /// Enum OBT for value: obt
            /// </summary>
            public static readonly CondoperationstatusEnum OBT = new CondoperationstatusEnum("obt");

            /// <summary>
            /// Enum PROMOTION for value: promotion
            /// </summary>
            public static readonly CondoperationstatusEnum PROMOTION = new CondoperationstatusEnum("promotion");

            private static readonly Dictionary<string, CondoperationstatusEnum> StaticFields =
            new Dictionary<string, CondoperationstatusEnum>()
            {
                { "normal", NORMAL },
                { "abandon", ABANDON },
                { "sellout", SELLOUT },
                { "obt", OBT },
                { "promotion", PROMOTION },
            };

            private string _value;

            public CondoperationstatusEnum()
            {

            }

            public CondoperationstatusEnum(string value)
            {
                _value = value;
            }

            public static CondoperationstatusEnum FromValue(string value)
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

                if (this.Equals(obj as CondoperationstatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CondoperationstatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CondoperationstatusEnum a, CondoperationstatusEnum b)
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

            public static bool operator !=(CondoperationstatusEnum a, CondoperationstatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 识该规格对应的资源类型，取值范围为“ironic”。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceTypeEnum ResourceType { get; set; }
        /// <summary>
        /// 裸金属服务器的CPU架构类型，取值为：x86_64（适用于x86机型）aarch64（适用于ARM机型）
        /// </summary>
        [JsonProperty("capabilities:cpu_arch", NullValueHandling = NullValueHandling.Ignore)]
        public CapabilitiescpuArchEnum CapabilitiescpuArch { get; set; }
        /// <summary>
        /// 磁盘物理规格描述信息。
        /// </summary>
        [JsonProperty("baremetal:disk_detail", NullValueHandling = NullValueHandling.Ignore)]
        public string BaremetaldiskDetail { get; set; }

        /// <summary>
        /// 标示ironic类型的规格。
        /// </summary>
        [JsonProperty("capabilities:hypervisor_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CapabilitieshypervisorType { get; set; }

        /// <summary>
        /// 标识当前的规格是否支持挂载EVS卷。truefalse
        /// </summary>
        [JsonProperty("baremetal:__support_evs", NullValueHandling = NullValueHandling.Ignore)]
        public string BaremetalSupportEvs { get; set; }

        /// <summary>
        /// 裸金属服务器启动源。LocalDisk：本地盘Volume：云硬盘（快速发放）
        /// </summary>
        [JsonProperty("baremetal:extBootType", NullValueHandling = NullValueHandling.Ignore)]
        public BaremetalextBootTypeEnum BaremetalextBootType { get; set; }
        /// <summary>
        /// 裸金属服务器的规格类型。格式为规格的缩写，例如规格名称为“physical.o2.medium”，则规格类型为“o2m”。
        /// </summary>
        [JsonProperty("capabilities:board_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CapabilitiesboardType { get; set; }

        /// <summary>
        /// 实际可挂载网络数量。
        /// </summary>
        [JsonProperty("baremetal:net_num", NullValueHandling = NullValueHandling.Ignore)]
        public string BaremetalnetNum { get; set; }

        /// <summary>
        /// 网卡物理规格描述信息。
        /// </summary>
        [JsonProperty("baremetal:netcard_detail", NullValueHandling = NullValueHandling.Ignore)]
        public string BaremetalnetcardDetail { get; set; }

        /// <summary>
        /// CPU物理规格描述信息。
        /// </summary>
        [JsonProperty("baremetal:cpu_detail", NullValueHandling = NullValueHandling.Ignore)]
        public string BaremetalcpuDetail { get; set; }

        /// <summary>
        /// 内存物理规格描述信息
        /// </summary>
        [JsonProperty("baremetal:memory_detail", NullValueHandling = NullValueHandling.Ignore)]
        public string BaremetalmemoryDetail { get; set; }

        /// <summary>
        /// 裸金属服务器规格状态。不配置时等同于normal。normal：正常商用abandon：下线（即不显示）sellout：售罄obt：公测promotion：推荐（等同normal，也是商用）
        /// </summary>
        [JsonProperty("cond:operation:status", NullValueHandling = NullValueHandling.Ignore)]
        public CondoperationstatusEnum Condoperationstatus { get; set; }
        /// <summary>
        /// 在某个AZ的裸金属服务器规格状态。此参数是AZ级配置，某个AZ没有在此参数中配置时默认使用cond:operation:status参数的取值。格式：az(xx)。()内为某个AZ下的裸金属服务器规格状态，()内必须填写状态，不填为无效配置。例如：规格在某个区域的az0正常商用，az1售罄，az2公测，az3正常商用，其他az显示下线，可配置为：“cond:operation:status”设置为“abandon”“cond:operation:az”设置为“az0(normal), az1(sellout), az2(obt), az3(promotion)” 说明：如果规格在某个AZ下的状态与cond:operation:status配置状态不同，必须配置该参数。
        /// </summary>
        [JsonProperty("cond:operation:az", NullValueHandling = NullValueHandling.Ignore)]
        public string Condoperationaz { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OsExtraSpecs {\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  capabilitiescpuArch: ").Append(CapabilitiescpuArch).Append("\n");
            sb.Append("  baremetaldiskDetail: ").Append(BaremetaldiskDetail).Append("\n");
            sb.Append("  capabilitieshypervisorType: ").Append(CapabilitieshypervisorType).Append("\n");
            sb.Append("  baremetalSupportEvs: ").Append(BaremetalSupportEvs).Append("\n");
            sb.Append("  baremetalextBootType: ").Append(BaremetalextBootType).Append("\n");
            sb.Append("  capabilitiesboardType: ").Append(CapabilitiesboardType).Append("\n");
            sb.Append("  baremetalnetNum: ").Append(BaremetalnetNum).Append("\n");
            sb.Append("  baremetalnetcardDetail: ").Append(BaremetalnetcardDetail).Append("\n");
            sb.Append("  baremetalcpuDetail: ").Append(BaremetalcpuDetail).Append("\n");
            sb.Append("  baremetalmemoryDetail: ").Append(BaremetalmemoryDetail).Append("\n");
            sb.Append("  condoperationstatus: ").Append(Condoperationstatus).Append("\n");
            sb.Append("  condoperationaz: ").Append(Condoperationaz).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OsExtraSpecs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OsExtraSpecs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.CapabilitiescpuArch == input.CapabilitiescpuArch ||
                    (this.CapabilitiescpuArch != null &&
                    this.CapabilitiescpuArch.Equals(input.CapabilitiescpuArch))
                ) && 
                (
                    this.BaremetaldiskDetail == input.BaremetaldiskDetail ||
                    (this.BaremetaldiskDetail != null &&
                    this.BaremetaldiskDetail.Equals(input.BaremetaldiskDetail))
                ) && 
                (
                    this.CapabilitieshypervisorType == input.CapabilitieshypervisorType ||
                    (this.CapabilitieshypervisorType != null &&
                    this.CapabilitieshypervisorType.Equals(input.CapabilitieshypervisorType))
                ) && 
                (
                    this.BaremetalSupportEvs == input.BaremetalSupportEvs ||
                    (this.BaremetalSupportEvs != null &&
                    this.BaremetalSupportEvs.Equals(input.BaremetalSupportEvs))
                ) && 
                (
                    this.BaremetalextBootType == input.BaremetalextBootType ||
                    (this.BaremetalextBootType != null &&
                    this.BaremetalextBootType.Equals(input.BaremetalextBootType))
                ) && 
                (
                    this.CapabilitiesboardType == input.CapabilitiesboardType ||
                    (this.CapabilitiesboardType != null &&
                    this.CapabilitiesboardType.Equals(input.CapabilitiesboardType))
                ) && 
                (
                    this.BaremetalnetNum == input.BaremetalnetNum ||
                    (this.BaremetalnetNum != null &&
                    this.BaremetalnetNum.Equals(input.BaremetalnetNum))
                ) && 
                (
                    this.BaremetalnetcardDetail == input.BaremetalnetcardDetail ||
                    (this.BaremetalnetcardDetail != null &&
                    this.BaremetalnetcardDetail.Equals(input.BaremetalnetcardDetail))
                ) && 
                (
                    this.BaremetalcpuDetail == input.BaremetalcpuDetail ||
                    (this.BaremetalcpuDetail != null &&
                    this.BaremetalcpuDetail.Equals(input.BaremetalcpuDetail))
                ) && 
                (
                    this.BaremetalmemoryDetail == input.BaremetalmemoryDetail ||
                    (this.BaremetalmemoryDetail != null &&
                    this.BaremetalmemoryDetail.Equals(input.BaremetalmemoryDetail))
                ) && 
                (
                    this.Condoperationstatus == input.Condoperationstatus ||
                    (this.Condoperationstatus != null &&
                    this.Condoperationstatus.Equals(input.Condoperationstatus))
                ) && 
                (
                    this.Condoperationaz == input.Condoperationaz ||
                    (this.Condoperationaz != null &&
                    this.Condoperationaz.Equals(input.Condoperationaz))
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
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.CapabilitiescpuArch != null)
                    hashCode = hashCode * 59 + this.CapabilitiescpuArch.GetHashCode();
                if (this.BaremetaldiskDetail != null)
                    hashCode = hashCode * 59 + this.BaremetaldiskDetail.GetHashCode();
                if (this.CapabilitieshypervisorType != null)
                    hashCode = hashCode * 59 + this.CapabilitieshypervisorType.GetHashCode();
                if (this.BaremetalSupportEvs != null)
                    hashCode = hashCode * 59 + this.BaremetalSupportEvs.GetHashCode();
                if (this.BaremetalextBootType != null)
                    hashCode = hashCode * 59 + this.BaremetalextBootType.GetHashCode();
                if (this.CapabilitiesboardType != null)
                    hashCode = hashCode * 59 + this.CapabilitiesboardType.GetHashCode();
                if (this.BaremetalnetNum != null)
                    hashCode = hashCode * 59 + this.BaremetalnetNum.GetHashCode();
                if (this.BaremetalnetcardDetail != null)
                    hashCode = hashCode * 59 + this.BaremetalnetcardDetail.GetHashCode();
                if (this.BaremetalcpuDetail != null)
                    hashCode = hashCode * 59 + this.BaremetalcpuDetail.GetHashCode();
                if (this.BaremetalmemoryDetail != null)
                    hashCode = hashCode * 59 + this.BaremetalmemoryDetail.GetHashCode();
                if (this.Condoperationstatus != null)
                    hashCode = hashCode * 59 + this.Condoperationstatus.GetHashCode();
                if (this.Condoperationaz != null)
                    hashCode = hashCode * 59 + this.Condoperationaz.GetHashCode();
                return hashCode;
            }
        }
    }
}
