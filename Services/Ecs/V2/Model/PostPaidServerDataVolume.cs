using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 云服务器对应数据盘相关配置。
    /// </summary>
    public class PostPaidServerDataVolume 
    {
        /// <summary>
        /// 云服务器数据盘对应的磁盘类型，需要与系统所提供的磁盘类型相匹配。  磁盘类型枚举值：  - SATA：普通IO磁盘类型。 - SAS：高IO磁盘类型。 - SSD：超高IO磁盘类型。 - co-p1：高IO (性能优化Ⅰ型) - uh-l1：超高IO (时延优化)磁盘类型。  &gt; 说明： &gt;  &gt; 对于HANA云服务器、HL1型云服务器、HL2型云服务器，需使用co-p1和uh-l1两种磁盘类型。对于其他类型的云服务器，不能使用co-p1和uh-l1两种磁盘类型。
        /// </summary>
        /// <value>云服务器数据盘对应的磁盘类型，需要与系统所提供的磁盘类型相匹配。  磁盘类型枚举值：  - SATA：普通IO磁盘类型。 - SAS：高IO磁盘类型。 - SSD：超高IO磁盘类型。 - co-p1：高IO (性能优化Ⅰ型) - uh-l1：超高IO (时延优化)磁盘类型。  &gt; 说明： &gt;  &gt; 对于HANA云服务器、HL1型云服务器、HL2型云服务器，需使用co-p1和uh-l1两种磁盘类型。对于其他类型的云服务器，不能使用co-p1和uh-l1两种磁盘类型。</value>
        [JsonConverter(typeof(EnumClassConverter<VolumetypeEnum>))]
        public class VolumetypeEnum
        {
            /// <summary>
            /// Enum SATA for value: SATA
            /// </summary>
            public static readonly VolumetypeEnum SATA = new VolumetypeEnum("SATA");

            /// <summary>
            /// Enum SAS for value: SAS
            /// </summary>
            public static readonly VolumetypeEnum SAS = new VolumetypeEnum("SAS");

            /// <summary>
            /// Enum SSD for value: SSD
            /// </summary>
            public static readonly VolumetypeEnum SSD = new VolumetypeEnum("SSD");

            /// <summary>
            /// Enum GPSSD for value: GPSSD
            /// </summary>
            public static readonly VolumetypeEnum GPSSD = new VolumetypeEnum("GPSSD");

            /// <summary>
            /// Enum CO_P1 for value: co-p1
            /// </summary>
            public static readonly VolumetypeEnum CO_P1 = new VolumetypeEnum("co-p1");

            /// <summary>
            /// Enum UH_L1 for value: uh-l1
            /// </summary>
            public static readonly VolumetypeEnum UH_L1 = new VolumetypeEnum("uh-l1");

            public static readonly Dictionary<string, VolumetypeEnum> StaticFields =
            new Dictionary<string, VolumetypeEnum>()
            {
                {"SATA", SATA},
                {"SAS", SAS},
                {"SSD", SSD},
                {"GPSSD", GPSSD},
                {"co-p1", CO_P1},
                {"uh-l1", UH_L1},
            };

            private string Value;

            public VolumetypeEnum(string Value)
            {
                this.Value = Value;
            }

            public static VolumetypeEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as VolumetypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VolumetypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(VolumetypeEnum a, VolumetypeEnum b)
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

            public static bool operator !=(VolumetypeEnum a, VolumetypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 云服务器数据盘对应的磁盘存储类型。 磁盘存储类型枚举值： DSS：专属存储类型
        /// </summary>
        /// <value>云服务器数据盘对应的磁盘存储类型。 磁盘存储类型枚举值： DSS：专属存储类型</value>
        [JsonConverter(typeof(EnumClassConverter<ClusterTypeEnum>))]
        public class ClusterTypeEnum
        {
            /// <summary>
            /// Enum DSS for value: DSS
            /// </summary>
            public static readonly ClusterTypeEnum DSS = new ClusterTypeEnum("DSS");

            public static readonly Dictionary<string, ClusterTypeEnum> StaticFields =
            new Dictionary<string, ClusterTypeEnum>()
            {
                {"DSS", DSS},
            };

            private string Value;

            public ClusterTypeEnum(string Value)
            {
                this.Value = Value;
            }

            public static ClusterTypeEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as ClusterTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ClusterTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ClusterTypeEnum a, ClusterTypeEnum b)
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

            public static bool operator !=(ClusterTypeEnum a, ClusterTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 云服务器数据盘对应的磁盘类型，需要与系统所提供的磁盘类型相匹配。  磁盘类型枚举值：  - SATA：普通IO磁盘类型。 - SAS：高IO磁盘类型。 - SSD：超高IO磁盘类型。 - co-p1：高IO (性能优化Ⅰ型) - uh-l1：超高IO (时延优化)磁盘类型。  &gt; 说明： &gt;  &gt; 对于HANA云服务器、HL1型云服务器、HL2型云服务器，需使用co-p1和uh-l1两种磁盘类型。对于其他类型的云服务器，不能使用co-p1和uh-l1两种磁盘类型。
        /// </summary>
        [JsonProperty("volumetype", NullValueHandling = NullValueHandling.Ignore)]
        public VolumetypeEnum Volumetype { get; set; }
        /// <summary>
        /// 数据盘大小，容量单位为GB，输入大小范围为[10,32768]。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 是否为共享磁盘。true为共享盘，false为普通云硬盘。  &gt; 说明： &gt;  &gt; 该字段已废弃，请使用multiattach。
        /// </summary>
        [JsonProperty("shareable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shareable { get; set; }

        /// <summary>
        /// 创建共享磁盘的信息。  - true：创建的磁盘为共享盘。 - false：创建的磁盘为普通云硬盘。  &gt; 说明： &gt;  &gt; shareable当前为废弃字段，如果确实需要同时使用shareable字段和multiattach字段，此时，请确保两个字段的参数值相同。当不指定该字段时，系统默认创建普通云硬盘。
        /// </summary>
        [JsonProperty("multiattach", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multiattach { get; set; }

        /// <summary>
        /// 数据卷是否使用SCSI锁。  - true表示云硬盘的设备类型为SCSI类型，即允许ECS操作系统直接访问底层存储介质。支持SCSI锁命令。 - false表示云硬盘的设备类型为VBD (虚拟块存储设备 , Virtual Block Device)类型，即为默认类型，VBD只能支持简单的SCSI读写命令。 - 该字段不存在时，云硬盘默认为VBD类型。  &gt; 说明： &gt;  &gt; 此参数为boolean类型，若传入非boolean类型字符，程序将按照【false】方式处理。
        /// </summary>
        [JsonProperty("hw:passthrough", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hwpassthrough { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendparam", NullValueHandling = NullValueHandling.Ignore)]
        public PostPaidServerDataVolumeExtendParam Extendparam { get; set; }

        /// <summary>
        /// 云服务器数据盘对应的磁盘存储类型。 磁盘存储类型枚举值： DSS：专属存储类型
        /// </summary>
        [JsonProperty("cluster_type", NullValueHandling = NullValueHandling.Ignore)]
        public ClusterTypeEnum ClusterType { get; set; }
        /// <summary>
        /// 云服务器数据盘对应的存储池的ID。
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public PostPaidServerDataVolumeMetadata Metadata { get; set; }

        /// <summary>
        /// 数据镜像的ID，UUID格式。  如果使用数据盘镜像创建数据盘，则data_image_id为必选参数，且不支持使用metadata。
        /// </summary>
        [JsonProperty("data_image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DataImageId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostPaidServerDataVolume {\n");
            sb.Append("  volumetype: ").Append(Volumetype).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  shareable: ").Append(Shareable).Append("\n");
            sb.Append("  multiattach: ").Append(Multiattach).Append("\n");
            sb.Append("  hwpassthrough: ").Append(Hwpassthrough).Append("\n");
            sb.Append("  extendparam: ").Append(Extendparam).Append("\n");
            sb.Append("  clusterType: ").Append(ClusterType).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  dataImageId: ").Append(DataImageId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostPaidServerDataVolume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostPaidServerDataVolume input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Volumetype == input.Volumetype ||
                    (this.Volumetype != null &&
                    this.Volumetype.Equals(input.Volumetype))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Shareable == input.Shareable ||
                    (this.Shareable != null &&
                    this.Shareable.Equals(input.Shareable))
                ) && 
                (
                    this.Multiattach == input.Multiattach ||
                    (this.Multiattach != null &&
                    this.Multiattach.Equals(input.Multiattach))
                ) && 
                (
                    this.Hwpassthrough == input.Hwpassthrough ||
                    (this.Hwpassthrough != null &&
                    this.Hwpassthrough.Equals(input.Hwpassthrough))
                ) && 
                (
                    this.Extendparam == input.Extendparam ||
                    (this.Extendparam != null &&
                    this.Extendparam.Equals(input.Extendparam))
                ) && 
                (
                    this.ClusterType == input.ClusterType ||
                    (this.ClusterType != null &&
                    this.ClusterType.Equals(input.ClusterType))
                ) && 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.DataImageId == input.DataImageId ||
                    (this.DataImageId != null &&
                    this.DataImageId.Equals(input.DataImageId))
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
                if (this.Volumetype != null)
                    hashCode = hashCode * 59 + this.Volumetype.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Shareable != null)
                    hashCode = hashCode * 59 + this.Shareable.GetHashCode();
                if (this.Multiattach != null)
                    hashCode = hashCode * 59 + this.Multiattach.GetHashCode();
                if (this.Hwpassthrough != null)
                    hashCode = hashCode * 59 + this.Hwpassthrough.GetHashCode();
                if (this.Extendparam != null)
                    hashCode = hashCode * 59 + this.Extendparam.GetHashCode();
                if (this.ClusterType != null)
                    hashCode = hashCode * 59 + this.ClusterType.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.DataImageId != null)
                    hashCode = hashCode * 59 + this.DataImageId.GetHashCode();
                return hashCode;
            }
        }
    }
}
