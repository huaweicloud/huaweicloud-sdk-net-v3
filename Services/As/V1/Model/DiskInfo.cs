using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 磁盘组信息，系统盘必选，数据盘可选。
    /// </summary>
    public class DiskInfo 
    {
        /// <summary>
        /// 云服务器系统盘对应的磁盘类型，需要与系统所提供的磁盘类型相匹配。SATA：普通IO磁盘类型。SAS：高IO磁盘类型。SSD：超高IO磁盘类型。GPSSD：通用型SSD磁盘类型。co-p1：高IO (性能优化Ⅰ型)uh-l1：超高IO (时延优化)GPSSD2: 通用型SSD V2云硬盘ESSD2: 极速型SSD V2云硬盘当指定的云硬盘类型在avaliability_zone内不存在时，则创建云硬盘失败。说明：对于HANA云服务器、HL1型云服务器、HL2型云服务器，需使用co-p1和uh-l1两种磁盘类型。对于其他类型的云服务器，不能使用co-p1和uh-l1两种磁盘类型。了解不同磁盘类型的详细信息，请参见[磁盘类型及性能介绍](https://support.huaweicloud.com/productdesc-evs/zh-cn_topic_0044524691.html)。
        /// </summary>
        /// <value>云服务器系统盘对应的磁盘类型，需要与系统所提供的磁盘类型相匹配。SATA：普通IO磁盘类型。SAS：高IO磁盘类型。SSD：超高IO磁盘类型。GPSSD：通用型SSD磁盘类型。co-p1：高IO (性能优化Ⅰ型)uh-l1：超高IO (时延优化)GPSSD2: 通用型SSD V2云硬盘ESSD2: 极速型SSD V2云硬盘当指定的云硬盘类型在avaliability_zone内不存在时，则创建云硬盘失败。说明：对于HANA云服务器、HL1型云服务器、HL2型云服务器，需使用co-p1和uh-l1两种磁盘类型。对于其他类型的云服务器，不能使用co-p1和uh-l1两种磁盘类型。了解不同磁盘类型的详细信息，请参见[磁盘类型及性能介绍](https://support.huaweicloud.com/productdesc-evs/zh-cn_topic_0044524691.html)。</value>
        [JsonConverter(typeof(EnumClassConverter<VolumeTypeEnum>))]
        public class VolumeTypeEnum
        {
            /// <summary>
            /// Enum SATA for value: SATA
            /// </summary>
            public static readonly VolumeTypeEnum SATA = new VolumeTypeEnum("SATA");

            /// <summary>
            /// Enum SAS for value: SAS
            /// </summary>
            public static readonly VolumeTypeEnum SAS = new VolumeTypeEnum("SAS");

            /// <summary>
            /// Enum SSD for value: SSD
            /// </summary>
            public static readonly VolumeTypeEnum SSD = new VolumeTypeEnum("SSD");

            /// <summary>
            /// Enum CO_PL for value: co-pl
            /// </summary>
            public static readonly VolumeTypeEnum CO_PL = new VolumeTypeEnum("co-pl");

            /// <summary>
            /// Enum UH_11 for value: uh-11
            /// </summary>
            public static readonly VolumeTypeEnum UH_11 = new VolumeTypeEnum("uh-11");

            /// <summary>
            /// Enum GPSSD for value: GPSSD
            /// </summary>
            public static readonly VolumeTypeEnum GPSSD = new VolumeTypeEnum("GPSSD");

            /// <summary>
            /// Enum GPSSD2 for value: GPSSD2
            /// </summary>
            public static readonly VolumeTypeEnum GPSSD2 = new VolumeTypeEnum("GPSSD2");

            /// <summary>
            /// Enum ESSD2 for value: ESSD2
            /// </summary>
            public static readonly VolumeTypeEnum ESSD2 = new VolumeTypeEnum("ESSD2");

            private static readonly Dictionary<string, VolumeTypeEnum> StaticFields =
            new Dictionary<string, VolumeTypeEnum>()
            {
                { "SATA", SATA },
                { "SAS", SAS },
                { "SSD", SSD },
                { "co-pl", CO_PL },
                { "uh-11", UH_11 },
                { "GPSSD", GPSSD },
                { "GPSSD2", GPSSD2 },
                { "ESSD2", ESSD2 },
            };

            private string _value;

            public VolumeTypeEnum()
            {

            }

            public VolumeTypeEnum(string value)
            {
                _value = value;
            }

            public static VolumeTypeEnum FromValue(string value)
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

                if (this.Equals(obj as VolumeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VolumeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VolumeTypeEnum a, VolumeTypeEnum b)
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

            public static bool operator !=(VolumeTypeEnum a, VolumeTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 系统盘还是数据盘，DATA表示为数据盘，SYS表示为系统盘。 说明： 系统盘不支持加密。
        /// </summary>
        /// <value>系统盘还是数据盘，DATA表示为数据盘，SYS表示为系统盘。 说明： 系统盘不支持加密。</value>
        [JsonConverter(typeof(EnumClassConverter<DiskTypeEnum>))]
        public class DiskTypeEnum
        {
            /// <summary>
            /// Enum SYS for value: SYS
            /// </summary>
            public static readonly DiskTypeEnum SYS = new DiskTypeEnum("SYS");

            /// <summary>
            /// Enum DATA for value: DATA
            /// </summary>
            public static readonly DiskTypeEnum DATA = new DiskTypeEnum("DATA");

            private static readonly Dictionary<string, DiskTypeEnum> StaticFields =
            new Dictionary<string, DiskTypeEnum>()
            {
                { "SYS", SYS },
                { "DATA", DATA },
            };

            private string _value;

            public DiskTypeEnum()
            {

            }

            public DiskTypeEnum(string value)
            {
                _value = value;
            }

            public static DiskTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DiskTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DiskTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DiskTypeEnum a, DiskTypeEnum b)
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

            public static bool operator !=(DiskTypeEnum a, DiskTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 磁盘大小，容量单位为GB。系统盘输入大小范围为1~1024，且不小于镜像中系统盘的最小(min_disk属性)值。数据盘输入大小范围为10~32768。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 云服务器系统盘对应的磁盘类型，需要与系统所提供的磁盘类型相匹配。SATA：普通IO磁盘类型。SAS：高IO磁盘类型。SSD：超高IO磁盘类型。GPSSD：通用型SSD磁盘类型。co-p1：高IO (性能优化Ⅰ型)uh-l1：超高IO (时延优化)GPSSD2: 通用型SSD V2云硬盘ESSD2: 极速型SSD V2云硬盘当指定的云硬盘类型在avaliability_zone内不存在时，则创建云硬盘失败。说明：对于HANA云服务器、HL1型云服务器、HL2型云服务器，需使用co-p1和uh-l1两种磁盘类型。对于其他类型的云服务器，不能使用co-p1和uh-l1两种磁盘类型。了解不同磁盘类型的详细信息，请参见[磁盘类型及性能介绍](https://support.huaweicloud.com/productdesc-evs/zh-cn_topic_0044524691.html)。
        /// </summary>
        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeTypeEnum VolumeType { get; set; }
        /// <summary>
        /// 系统盘还是数据盘，DATA表示为数据盘，SYS表示为系统盘。 说明： 系统盘不支持加密。
        /// </summary>
        [JsonProperty("disk_type", NullValueHandling = NullValueHandling.Ignore)]
        public DiskTypeEnum DiskType { get; set; }
        /// <summary>
        /// 云服务器的磁盘可指定创建在用户的专属存储中，需要指定专属存储ID。说明：同一个伸缩配置中的磁盘需统一指定或统一不指定专属存储，不支持混用；当指定专属存储时，所有专属存储需要属于同一个可用分区，且每个磁盘选择的专属存储支持的磁盘类型都需要和参数volume_type保持一致。
        /// </summary>
        [JsonProperty("dedicated_storage_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedStorageId { get; set; }

        /// <summary>
        /// 云服务器的数据盘可指定从数据盘镜像导出，需要指定数据盘镜像ID。
        /// </summary>
        [JsonProperty("data_disk_image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DataDiskImageId { get; set; }

        /// <summary>
        /// 当选择使用整机镜像时，云服务器的系统盘及数据盘将通过整机备份恢复，需要指定磁盘备份的快照ID。说明：磁盘备份的快照ID可通过镜像的整机备份ID在CSBS查询备份详情获得；一个伸缩配置中的每一个disk需要通过snapshot_id和整机备份中的磁盘备份一一对应。
        /// </summary>
        [JsonProperty("snapshot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public MetaData Metadata { get; set; }

        /// <summary>
        /// 为云硬盘配置iops。当“volume_type”设置为GPSSD2、ESSD2类型的云硬盘时，该参数必填，其他类型无需设置。
        /// </summary>
        [JsonProperty("iops", NullValueHandling = NullValueHandling.Ignore)]
        public int? Iops { get; set; }

        /// <summary>
        /// 为云硬盘配置吞吐量，单位是MiB/s。当“volume_type”设置为GPSSD2类型的云硬盘时必填，其他类型不能设置。
        /// </summary>
        [JsonProperty("throughput", NullValueHandling = NullValueHandling.Ignore)]
        public int? Throughput { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiskInfo {\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("  diskType: ").Append(DiskType).Append("\n");
            sb.Append("  dedicatedStorageId: ").Append(DedicatedStorageId).Append("\n");
            sb.Append("  dataDiskImageId: ").Append(DataDiskImageId).Append("\n");
            sb.Append("  snapshotId: ").Append(SnapshotId).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  iops: ").Append(Iops).Append("\n");
            sb.Append("  throughput: ").Append(Throughput).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiskInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiskInfo input)
        {
            if (input == null) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.VolumeType != input.VolumeType) return false;
            if (this.DiskType != input.DiskType) return false;
            if (this.DedicatedStorageId != input.DedicatedStorageId || (this.DedicatedStorageId != null && !this.DedicatedStorageId.Equals(input.DedicatedStorageId))) return false;
            if (this.DataDiskImageId != input.DataDiskImageId || (this.DataDiskImageId != null && !this.DataDiskImageId.Equals(input.DataDiskImageId))) return false;
            if (this.SnapshotId != input.SnapshotId || (this.SnapshotId != null && !this.SnapshotId.Equals(input.SnapshotId))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;
            if (this.Iops != input.Iops || (this.Iops != null && !this.Iops.Equals(input.Iops))) return false;
            if (this.Throughput != input.Throughput || (this.Throughput != null && !this.Throughput.Equals(input.Throughput))) return false;

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
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                hashCode = hashCode * 59 + this.DiskType.GetHashCode();
                if (this.DedicatedStorageId != null) hashCode = hashCode * 59 + this.DedicatedStorageId.GetHashCode();
                if (this.DataDiskImageId != null) hashCode = hashCode * 59 + this.DataDiskImageId.GetHashCode();
                if (this.SnapshotId != null) hashCode = hashCode * 59 + this.SnapshotId.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Iops != null) hashCode = hashCode * 59 + this.Iops.GetHashCode();
                if (this.Throughput != null) hashCode = hashCode * 59 + this.Throughput.GetHashCode();
                return hashCode;
            }
        }
    }
}
