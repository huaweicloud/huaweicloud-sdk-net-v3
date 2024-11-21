using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BackupExtendInfo 
    {
        /// <summary>
        /// 备份支持恢复的方式，当前取值包含na,snapshot和backup。如果该字段取值为snapshot，代表备份此时已经支持创建整机镜像；如果该字段取值为backup，备份支持通过云服务器上硬盘的备份进行恢复；如果该字段取值为na，备份不支持恢复。
        /// </summary>
        /// <value>备份支持恢复的方式，当前取值包含na,snapshot和backup。如果该字段取值为snapshot，代表备份此时已经支持创建整机镜像；如果该字段取值为backup，备份支持通过云服务器上硬盘的备份进行恢复；如果该字段取值为na，备份不支持恢复。</value>
        [JsonConverter(typeof(EnumClassConverter<SupportedRestoreModeEnum>))]
        public class SupportedRestoreModeEnum
        {
            /// <summary>
            /// Enum NA for value: na
            /// </summary>
            public static readonly SupportedRestoreModeEnum NA = new SupportedRestoreModeEnum("na");

            /// <summary>
            /// Enum BACKUP for value: backup
            /// </summary>
            public static readonly SupportedRestoreModeEnum BACKUP = new SupportedRestoreModeEnum("backup");

            /// <summary>
            /// Enum SNAPSHOT for value: snapshot
            /// </summary>
            public static readonly SupportedRestoreModeEnum SNAPSHOT = new SupportedRestoreModeEnum("snapshot");

            private static readonly Dictionary<string, SupportedRestoreModeEnum> StaticFields =
            new Dictionary<string, SupportedRestoreModeEnum>()
            {
                { "na", NA },
                { "backup", BACKUP },
                { "snapshot", SNAPSHOT },
            };

            private string _value;

            public SupportedRestoreModeEnum()
            {

            }

            public SupportedRestoreModeEnum(string value)
            {
                _value = value;
            }

            public static SupportedRestoreModeEnum FromValue(string value)
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

                if (this.Equals(obj as SupportedRestoreModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SupportedRestoreModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SupportedRestoreModeEnum a, SupportedRestoreModeEnum b)
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

            public static bool operator !=(SupportedRestoreModeEnum a, SupportedRestoreModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否是自动生成的备份副本
        /// </summary>
        [JsonProperty("auto_trigger", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoTrigger { get; set; }

        /// <summary>
        /// 是否系统盘备份
        /// </summary>
        [JsonProperty("bootable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Bootable { get; set; }

        /// <summary>
        /// 卷备份副本的快照id
        /// </summary>
        [JsonProperty("snapshot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// 是否支持lazyloading快速恢复
        /// </summary>
        [JsonProperty("support_lld", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportLld { get; set; }

        /// <summary>
        /// 备份支持恢复的方式，当前取值包含na,snapshot和backup。如果该字段取值为snapshot，代表备份此时已经支持创建整机镜像；如果该字段取值为backup，备份支持通过云服务器上硬盘的备份进行恢复；如果该字段取值为na，备份不支持恢复。
        /// </summary>
        [JsonProperty("supported_restore_mode", NullValueHandling = NullValueHandling.Ignore)]
        public SupportedRestoreModeEnum SupportedRestoreMode { get; set; }
        /// <summary>
        /// 备份注册镜像ID列表
        /// </summary>
        [JsonProperty("os_images_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageData> OsImagesData { get; set; }

        /// <summary>
        /// 整机备份是否包含系统盘
        /// </summary>
        [JsonProperty("contain_system_disk", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContainSystemDisk { get; set; }

        /// <summary>
        /// 是否加密
        /// </summary>
        [JsonProperty("encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// 是否是系统盘
        /// </summary>
        [JsonProperty("system_disk", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SystemDisk { get; set; }

        /// <summary>
        /// 备份类型是否为多AZ
        /// </summary>
        [JsonProperty("is_multi_az", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMultiAz { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupExtendInfo {\n");
            sb.Append("  autoTrigger: ").Append(AutoTrigger).Append("\n");
            sb.Append("  bootable: ").Append(Bootable).Append("\n");
            sb.Append("  snapshotId: ").Append(SnapshotId).Append("\n");
            sb.Append("  supportLld: ").Append(SupportLld).Append("\n");
            sb.Append("  supportedRestoreMode: ").Append(SupportedRestoreMode).Append("\n");
            sb.Append("  osImagesData: ").Append(OsImagesData).Append("\n");
            sb.Append("  containSystemDisk: ").Append(ContainSystemDisk).Append("\n");
            sb.Append("  encrypted: ").Append(Encrypted).Append("\n");
            sb.Append("  systemDisk: ").Append(SystemDisk).Append("\n");
            sb.Append("  isMultiAz: ").Append(IsMultiAz).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupExtendInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupExtendInfo input)
        {
            if (input == null) return false;
            if (this.AutoTrigger != input.AutoTrigger || (this.AutoTrigger != null && !this.AutoTrigger.Equals(input.AutoTrigger))) return false;
            if (this.Bootable != input.Bootable || (this.Bootable != null && !this.Bootable.Equals(input.Bootable))) return false;
            if (this.SnapshotId != input.SnapshotId || (this.SnapshotId != null && !this.SnapshotId.Equals(input.SnapshotId))) return false;
            if (this.SupportLld != input.SupportLld || (this.SupportLld != null && !this.SupportLld.Equals(input.SupportLld))) return false;
            if (this.SupportedRestoreMode != input.SupportedRestoreMode) return false;
            if (this.OsImagesData != input.OsImagesData || (this.OsImagesData != null && input.OsImagesData != null && !this.OsImagesData.SequenceEqual(input.OsImagesData))) return false;
            if (this.ContainSystemDisk != input.ContainSystemDisk || (this.ContainSystemDisk != null && !this.ContainSystemDisk.Equals(input.ContainSystemDisk))) return false;
            if (this.Encrypted != input.Encrypted || (this.Encrypted != null && !this.Encrypted.Equals(input.Encrypted))) return false;
            if (this.SystemDisk != input.SystemDisk || (this.SystemDisk != null && !this.SystemDisk.Equals(input.SystemDisk))) return false;
            if (this.IsMultiAz != input.IsMultiAz || (this.IsMultiAz != null && !this.IsMultiAz.Equals(input.IsMultiAz))) return false;

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
                if (this.AutoTrigger != null) hashCode = hashCode * 59 + this.AutoTrigger.GetHashCode();
                if (this.Bootable != null) hashCode = hashCode * 59 + this.Bootable.GetHashCode();
                if (this.SnapshotId != null) hashCode = hashCode * 59 + this.SnapshotId.GetHashCode();
                if (this.SupportLld != null) hashCode = hashCode * 59 + this.SupportLld.GetHashCode();
                hashCode = hashCode * 59 + this.SupportedRestoreMode.GetHashCode();
                if (this.OsImagesData != null) hashCode = hashCode * 59 + this.OsImagesData.GetHashCode();
                if (this.ContainSystemDisk != null) hashCode = hashCode * 59 + this.ContainSystemDisk.GetHashCode();
                if (this.Encrypted != null) hashCode = hashCode * 59 + this.Encrypted.GetHashCode();
                if (this.SystemDisk != null) hashCode = hashCode * 59 + this.SystemDisk.GetHashCode();
                if (this.IsMultiAz != null) hashCode = hashCode * 59 + this.IsMultiAz.GetHashCode();
                return hashCode;
            }
        }
    }
}
