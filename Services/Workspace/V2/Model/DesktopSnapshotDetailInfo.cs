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
    /// 快照详情。
    /// </summary>
    public class DesktopSnapshotDetailInfo 
    {
        /// <summary>
        /// 快照创建类型。 - AUTO 定时任务自动创建。 - MANUALLY 手动创建。
        /// </summary>
        /// <value>快照创建类型。 - AUTO 定时任务自动创建。 - MANUALLY 手动创建。</value>
        [JsonConverter(typeof(EnumClassConverter<CreateTypeEnum>))]
        public class CreateTypeEnum
        {
            /// <summary>
            /// Enum AUTO for value: AUTO
            /// </summary>
            public static readonly CreateTypeEnum AUTO = new CreateTypeEnum("AUTO");

            /// <summary>
            /// Enum MANUALLY for value: MANUALLY
            /// </summary>
            public static readonly CreateTypeEnum MANUALLY = new CreateTypeEnum("MANUALLY");

            private static readonly Dictionary<string, CreateTypeEnum> StaticFields =
            new Dictionary<string, CreateTypeEnum>()
            {
                { "AUTO", AUTO },
                { "MANUALLY", MANUALLY },
            };

            private string _value;

            public CreateTypeEnum()
            {

            }

            public CreateTypeEnum(string value)
            {
                _value = value;
            }

            public static CreateTypeEnum FromValue(string value)
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

                if (this.Equals(obj as CreateTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CreateTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CreateTypeEnum a, CreateTypeEnum b)
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

            public static bool operator !=(CreateTypeEnum a, CreateTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 桌面快照ID。
        /// </summary>
        [JsonProperty("snapshot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// 桌面快照记录名称。
        /// </summary>
        [JsonProperty("snapshot_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// 桌面快照对应的桌面id。
        /// </summary>
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 桌面快照对应的桌面名称。
        /// </summary>
        [JsonProperty("desktop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopName { get; set; }

        /// <summary>
        /// 桌面快照对应的桌面sid。
        /// </summary>
        [JsonProperty("desktop_sid", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopSid { get; set; }

        /// <summary>
        /// 桌面快照对应的桌面池id。
        /// </summary>
        [JsonProperty("desktop_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopPoolId { get; set; }

        /// <summary>
        /// 快照对应磁盘类型，true表示系统盘，false表示数据盘。
        /// </summary>
        [JsonProperty("is_system_disk", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSystemDisk { get; set; }

        /// <summary>
        /// 快照状态。 - creating：表示创建中。 - restoring：表示恢复中。 - create_success：表示创建成功。 - create_failed：表示创建快照失败。 - restore_success：表示快照恢复成功。 - restore_failed：表示快照恢复失败。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 快照任务进度， 取值范围0-100以及null，null表示该快照无任务，0-100表明该任务进度的百分比。
        /// </summary>
        [JsonProperty("process", NullValueHandling = NullValueHandling.Ignore)]
        public int? Process { get; set; }

        /// <summary>
        /// 快照描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 快照的创建时间，UTC时间，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z。&#39;
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 快照创建类型。 - AUTO 定时任务自动创建。 - MANUALLY 手动创建。
        /// </summary>
        [JsonProperty("create_type", NullValueHandling = NullValueHandling.Ignore)]
        public CreateTypeEnum CreateType { get; set; }
        /// <summary>
        /// 快照的最近恢复时间，UTC时间，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z。&#39;
        /// </summary>
        [JsonProperty("last_restore_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastRestoreTime { get; set; }

        /// <summary>
        /// 快照恢复失败原因。
        /// </summary>
        [JsonProperty("restore_fail_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string RestoreFailReason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopSnapshotDetailInfo {\n");
            sb.Append("  snapshotId: ").Append(SnapshotId).Append("\n");
            sb.Append("  snapshotName: ").Append(SnapshotName).Append("\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  desktopName: ").Append(DesktopName).Append("\n");
            sb.Append("  desktopSid: ").Append(DesktopSid).Append("\n");
            sb.Append("  desktopPoolId: ").Append(DesktopPoolId).Append("\n");
            sb.Append("  isSystemDisk: ").Append(IsSystemDisk).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  process: ").Append(Process).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  createType: ").Append(CreateType).Append("\n");
            sb.Append("  lastRestoreTime: ").Append(LastRestoreTime).Append("\n");
            sb.Append("  restoreFailReason: ").Append(RestoreFailReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DesktopSnapshotDetailInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DesktopSnapshotDetailInfo input)
        {
            if (input == null) return false;
            if (this.SnapshotId != input.SnapshotId || (this.SnapshotId != null && !this.SnapshotId.Equals(input.SnapshotId))) return false;
            if (this.SnapshotName != input.SnapshotName || (this.SnapshotName != null && !this.SnapshotName.Equals(input.SnapshotName))) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.DesktopName != input.DesktopName || (this.DesktopName != null && !this.DesktopName.Equals(input.DesktopName))) return false;
            if (this.DesktopSid != input.DesktopSid || (this.DesktopSid != null && !this.DesktopSid.Equals(input.DesktopSid))) return false;
            if (this.DesktopPoolId != input.DesktopPoolId || (this.DesktopPoolId != null && !this.DesktopPoolId.Equals(input.DesktopPoolId))) return false;
            if (this.IsSystemDisk != input.IsSystemDisk || (this.IsSystemDisk != null && !this.IsSystemDisk.Equals(input.IsSystemDisk))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Process != input.Process || (this.Process != null && !this.Process.Equals(input.Process))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CreateType != input.CreateType) return false;
            if (this.LastRestoreTime != input.LastRestoreTime || (this.LastRestoreTime != null && !this.LastRestoreTime.Equals(input.LastRestoreTime))) return false;
            if (this.RestoreFailReason != input.RestoreFailReason || (this.RestoreFailReason != null && !this.RestoreFailReason.Equals(input.RestoreFailReason))) return false;

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
                if (this.SnapshotId != null) hashCode = hashCode * 59 + this.SnapshotId.GetHashCode();
                if (this.SnapshotName != null) hashCode = hashCode * 59 + this.SnapshotName.GetHashCode();
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.DesktopName != null) hashCode = hashCode * 59 + this.DesktopName.GetHashCode();
                if (this.DesktopSid != null) hashCode = hashCode * 59 + this.DesktopSid.GetHashCode();
                if (this.DesktopPoolId != null) hashCode = hashCode * 59 + this.DesktopPoolId.GetHashCode();
                if (this.IsSystemDisk != null) hashCode = hashCode * 59 + this.IsSystemDisk.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Process != null) hashCode = hashCode * 59 + this.Process.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                hashCode = hashCode * 59 + this.CreateType.GetHashCode();
                if (this.LastRestoreTime != null) hashCode = hashCode * 59 + this.LastRestoreTime.GetHashCode();
                if (this.RestoreFailReason != null) hashCode = hashCode * 59 + this.RestoreFailReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
