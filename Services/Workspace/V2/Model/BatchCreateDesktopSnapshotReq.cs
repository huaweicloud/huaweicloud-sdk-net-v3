using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 批量创建快照请求体。
    /// </summary>
    public class BatchCreateDesktopSnapshotReq 
    {
        /// <summary>
        /// 快照类型。 - SYSTEM_DISK 系统盘。 - DATA_DISKS 数据盘。 - ALL 系统盘和数据盘。
        /// </summary>
        /// <value>快照类型。 - SYSTEM_DISK 系统盘。 - DATA_DISKS 数据盘。 - ALL 系统盘和数据盘。</value>
        [JsonConverter(typeof(EnumClassConverter<DiskTypeEnum>))]
        public class DiskTypeEnum
        {
            /// <summary>
            /// Enum SYSTEM_DISK for value: SYSTEM_DISK
            /// </summary>
            public static readonly DiskTypeEnum SYSTEM_DISK = new DiskTypeEnum("SYSTEM_DISK");

            /// <summary>
            /// Enum DATA_DISKS for value: DATA_DISKS
            /// </summary>
            public static readonly DiskTypeEnum DATA_DISKS = new DiskTypeEnum("DATA_DISKS");

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly DiskTypeEnum ALL = new DiskTypeEnum("ALL");

            private static readonly Dictionary<string, DiskTypeEnum> StaticFields =
            new Dictionary<string, DiskTypeEnum>()
            {
                { "SYSTEM_DISK", SYSTEM_DISK },
                { "DATA_DISKS", DATA_DISKS },
                { "ALL", ALL },
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
        /// 桌面id数组，最多支持100。
        /// </summary>
        [JsonProperty("desktop_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// 快照类型。 - SYSTEM_DISK 系统盘。 - DATA_DISKS 数据盘。 - ALL 系统盘和数据盘。
        /// </summary>
        [JsonProperty("disk_type", NullValueHandling = NullValueHandling.Ignore)]
        public DiskTypeEnum DiskType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("system_disk_snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public DiskSnapshotInfo SystemDiskSnapshot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data_disk_snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public DiskSnapshotInfo DataDiskSnapshot { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateDesktopSnapshotReq {\n");
            sb.Append("  desktopIds: ").Append(DesktopIds).Append("\n");
            sb.Append("  diskType: ").Append(DiskType).Append("\n");
            sb.Append("  systemDiskSnapshot: ").Append(SystemDiskSnapshot).Append("\n");
            sb.Append("  dataDiskSnapshot: ").Append(DataDiskSnapshot).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateDesktopSnapshotReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateDesktopSnapshotReq input)
        {
            if (input == null) return false;
            if (this.DesktopIds != input.DesktopIds || (this.DesktopIds != null && input.DesktopIds != null && !this.DesktopIds.SequenceEqual(input.DesktopIds))) return false;
            if (this.DiskType != input.DiskType) return false;
            if (this.SystemDiskSnapshot != input.SystemDiskSnapshot || (this.SystemDiskSnapshot != null && !this.SystemDiskSnapshot.Equals(input.SystemDiskSnapshot))) return false;
            if (this.DataDiskSnapshot != input.DataDiskSnapshot || (this.DataDiskSnapshot != null && !this.DataDiskSnapshot.Equals(input.DataDiskSnapshot))) return false;

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
                if (this.DesktopIds != null) hashCode = hashCode * 59 + this.DesktopIds.GetHashCode();
                hashCode = hashCode * 59 + this.DiskType.GetHashCode();
                if (this.SystemDiskSnapshot != null) hashCode = hashCode * 59 + this.SystemDiskSnapshot.GetHashCode();
                if (this.DataDiskSnapshot != null) hashCode = hashCode * 59 + this.DataDiskSnapshot.GetHashCode();
                return hashCode;
            }
        }
    }
}
