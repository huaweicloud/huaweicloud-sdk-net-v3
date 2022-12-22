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
    /// 磁盘信息
    /// </summary>
    public class DiskResult 
    {
        /// <summary>
        /// 磁盘类型。
        /// </summary>
        /// <value>磁盘类型。</value>
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

            private static readonly Dictionary<string, VolumeTypeEnum> StaticFields =
            new Dictionary<string, VolumeTypeEnum>()
            {
                { "SATA", SATA },
                { "SAS", SAS },
                { "SSD", SSD },
                { "co-pl", CO_PL },
                { "uh-11", UH_11 },
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

            public static bool operator !=(VolumeTypeEnum a, VolumeTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 系统盘还是数据盘，DATA表示为数据盘，SYS表示为系统盘。
        /// </summary>
        /// <value>系统盘还是数据盘，DATA表示为数据盘，SYS表示为系统盘。</value>
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

            public static bool operator !=(DiskTypeEnum a, DiskTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 磁盘大小，容量单位为GB。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 磁盘类型。
        /// </summary>
        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeTypeEnum VolumeType { get; set; }
        /// <summary>
        /// 系统盘还是数据盘，DATA表示为数据盘，SYS表示为系统盘。
        /// </summary>
        [JsonProperty("disk_type", NullValueHandling = NullValueHandling.Ignore)]
        public DiskTypeEnum DiskType { get; set; }
        /// <summary>
        /// 磁盘所属的专属存储ID。
        /// </summary>
        [JsonProperty("dedicated_storage_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedStorageId { get; set; }

        /// <summary>
        /// 导入数据盘的数据盘镜像ID。
        /// </summary>
        [JsonProperty("data_disk_image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DataDiskImageId { get; set; }

        /// <summary>
        /// 磁盘备份的快照ID。
        /// </summary>
        [JsonProperty("snapshot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public MetaData Metadata { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiskResult {\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("  diskType: ").Append(DiskType).Append("\n");
            sb.Append("  dedicatedStorageId: ").Append(DedicatedStorageId).Append("\n");
            sb.Append("  dataDiskImageId: ").Append(DataDiskImageId).Append("\n");
            sb.Append("  snapshotId: ").Append(SnapshotId).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiskResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiskResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.VolumeType == input.VolumeType ||
                    (this.VolumeType != null &&
                    this.VolumeType.Equals(input.VolumeType))
                ) && 
                (
                    this.DiskType == input.DiskType ||
                    (this.DiskType != null &&
                    this.DiskType.Equals(input.DiskType))
                ) && 
                (
                    this.DedicatedStorageId == input.DedicatedStorageId ||
                    (this.DedicatedStorageId != null &&
                    this.DedicatedStorageId.Equals(input.DedicatedStorageId))
                ) && 
                (
                    this.DataDiskImageId == input.DataDiskImageId ||
                    (this.DataDiskImageId != null &&
                    this.DataDiskImageId.Equals(input.DataDiskImageId))
                ) && 
                (
                    this.SnapshotId == input.SnapshotId ||
                    (this.SnapshotId != null &&
                    this.SnapshotId.Equals(input.SnapshotId))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.VolumeType != null)
                    hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                if (this.DiskType != null)
                    hashCode = hashCode * 59 + this.DiskType.GetHashCode();
                if (this.DedicatedStorageId != null)
                    hashCode = hashCode * 59 + this.DedicatedStorageId.GetHashCode();
                if (this.DataDiskImageId != null)
                    hashCode = hashCode * 59 + this.DataDiskImageId.GetHashCode();
                if (this.SnapshotId != null)
                    hashCode = hashCode * 59 + this.SnapshotId.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
