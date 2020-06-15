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
    /// 
    /// </summary>
    public class PostPaidServerRootVolume 
    {
        /// <summary>
        /// 云服务器系统盘对应的磁盘类型，需要与系统所提供的磁盘类型相匹配。  - SATA：普通IO磁盘类型。 - SAS：高IO磁盘类型。 - SSD：超高IO磁盘类型。 - co-p1：高IO (性能优化Ⅰ型) - uh-l1：超高IO (时延优化)  &gt; 说明： &gt;  &gt; 对于HANA云服务器、HL1型云服务器、HL2型云服务器，需使用co-p1和uh-l1两种磁盘类型。对于其他类型的云服务器，不能使用co-p1和uh-l1两种磁盘类型。
        /// </summary>
        /// <value>云服务器系统盘对应的磁盘类型，需要与系统所提供的磁盘类型相匹配。  - SATA：普通IO磁盘类型。 - SAS：高IO磁盘类型。 - SSD：超高IO磁盘类型。 - co-p1：高IO (性能优化Ⅰ型) - uh-l1：超高IO (时延优化)  &gt; 说明： &gt;  &gt; 对于HANA云服务器、HL1型云服务器、HL2型云服务器，需使用co-p1和uh-l1两种磁盘类型。对于其他类型的云服务器，不能使用co-p1和uh-l1两种磁盘类型。</value>
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
        /// 云服务器系统盘对应的磁盘存储类型。 磁盘存储类型枚举值： DSS：专属存储类型
        /// </summary>
        /// <value>云服务器系统盘对应的磁盘存储类型。 磁盘存储类型枚举值： DSS：专属存储类型</value>
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
        /// 云服务器系统盘对应的磁盘类型，需要与系统所提供的磁盘类型相匹配。  - SATA：普通IO磁盘类型。 - SAS：高IO磁盘类型。 - SSD：超高IO磁盘类型。 - co-p1：高IO (性能优化Ⅰ型) - uh-l1：超高IO (时延优化)  &gt; 说明： &gt;  &gt; 对于HANA云服务器、HL1型云服务器、HL2型云服务器，需使用co-p1和uh-l1两种磁盘类型。对于其他类型的云服务器，不能使用co-p1和uh-l1两种磁盘类型。
        /// </summary>
        [JsonProperty("volumetype", NullValueHandling = NullValueHandling.Ignore)]
        public VolumetypeEnum Volumetype { get; set; }
        /// <summary>
        /// 系统盘大小，容量单位为GB， 输入大小范围为[1,1024]。  约束：  - 系统盘大小取值应不小于镜像支持的系统盘的最小值(镜像的min_disk属性)。 - 若该参数没有指定或者指定为0时，系统盘大小默认取值为镜像中系统盘的最小值(镜像的min_disk属性)。  &gt; 说明： &gt;  &gt; 镜像系统盘的最小值(镜像的min_disk属性)可在控制台中点击镜像详情查看。或通过调用“查询镜像详情（OpenStack原生）”API获取，详细操作请参考《镜像服务API参考》中“查询镜像详情（OpenStack原生）”章节。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 使用SDI规格创建虚拟机时请关注该参数，如果该参数值为true，说明创建的为scsi类型的卷  &gt; 说明： &gt;  &gt; 此参数为boolean类型，若传入非boolean类型字符，程序将按照false方式处理。
        /// </summary>
        [JsonProperty("hw:passthrough", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hwpassthrough { get; set; }

        /// <summary>
        /// 云服务器系统盘对应的磁盘存储类型。 磁盘存储类型枚举值： DSS：专属存储类型
        /// </summary>
        [JsonProperty("cluster_type", NullValueHandling = NullValueHandling.Ignore)]
        public ClusterTypeEnum ClusterType { get; set; }
        /// <summary>
        /// 使用SDI规格创建虚拟机时请关注该参数，如果该参数值为true，说明创建的为scsi类型的卷
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendparam", NullValueHandling = NullValueHandling.Ignore)]
        public PostPaidServerRootVolumeExtendParam Extendparam { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostPaidServerRootVolume {\n");
            sb.Append("  volumetype: ").Append(Volumetype).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  hwpassthrough: ").Append(Hwpassthrough).Append("\n");
            sb.Append("  clusterType: ").Append(ClusterType).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  extendparam: ").Append(Extendparam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostPaidServerRootVolume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostPaidServerRootVolume input)
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
                    this.Hwpassthrough == input.Hwpassthrough ||
                    (this.Hwpassthrough != null &&
                    this.Hwpassthrough.Equals(input.Hwpassthrough))
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
                    this.Extendparam == input.Extendparam ||
                    (this.Extendparam != null &&
                    this.Extendparam.Equals(input.Extendparam))
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
                if (this.Hwpassthrough != null)
                    hashCode = hashCode * 59 + this.Hwpassthrough.GetHashCode();
                if (this.ClusterType != null)
                    hashCode = hashCode * 59 + this.ClusterType.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.Extendparam != null)
                    hashCode = hashCode * 59 + this.Extendparam.GetHashCode();
                return hashCode;
            }
        }
    }
}
