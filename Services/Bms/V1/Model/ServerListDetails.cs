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
    /// server字段数据结构说明
    /// </summary>
    public class ServerListDetails 
    {
        /// <summary>
        /// 裸金属服务器当前状态信息。  取值范围：  ACTIVE：运行中/正在关机/删除中 BUILD：创建中 ERROR：故障 HARD_REBOOT：强制重启中 REBOOT：重启中 DELETED：实例已被正常删除 SHUTOFF：关机/正在开机/删除中/重建中/重装操作系统中/重装操作系统失败/冻结
        /// </summary>
        /// <value>裸金属服务器当前状态信息。  取值范围：  ACTIVE：运行中/正在关机/删除中 BUILD：创建中 ERROR：故障 HARD_REBOOT：强制重启中 REBOOT：重启中 DELETED：实例已被正常删除 SHUTOFF：关机/正在开机/删除中/重建中/重装操作系统中/重装操作系统失败/冻结</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum BUILD for value: BUILD
            /// </summary>
            public static readonly StatusEnum BUILD = new StatusEnum("BUILD");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("ERROR");

            /// <summary>
            /// Enum HARD_REBOOT for value: HARD_REBOOT
            /// </summary>
            public static readonly StatusEnum HARD_REBOOT = new StatusEnum("HARD_REBOOT");

            /// <summary>
            /// Enum REBOOT for value: REBOOT
            /// </summary>
            public static readonly StatusEnum REBOOT = new StatusEnum("REBOOT");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("DELETED");

            /// <summary>
            /// Enum SHUTOFF for value: SHUTOFF
            /// </summary>
            public static readonly StatusEnum SHUTOFF = new StatusEnum("SHUTOFF");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "BUILD", BUILD },
                { "ERROR", ERROR },
                { "HARD_REBOOT", HARD_REBOOT },
                { "REBOOT", REBOOT },
                { "DELETED", DELETED },
                { "SHUTOFF", SHUTOFF },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 扩展属性，裸金属服务器当前的任务状态。例如：rebooting：重启中reboot_started：普通重启reboot_started_hard：强制重启powering-off：关机中powering-on：开机中rebuilding：重建中scheduling：调度中deleting：删除中
        /// </summary>
        /// <value>扩展属性，裸金属服务器当前的任务状态。例如：rebooting：重启中reboot_started：普通重启reboot_started_hard：强制重启powering-off：关机中powering-on：开机中rebuilding：重建中scheduling：调度中deleting：删除中</value>
        [JsonConverter(typeof(EnumClassConverter<TaskStateEnum>))]
        public class TaskStateEnum
        {
            /// <summary>
            /// Enum REBOOTING for value: rebooting
            /// </summary>
            public static readonly TaskStateEnum REBOOTING = new TaskStateEnum("rebooting");

            /// <summary>
            /// Enum REBOOT_STARTED for value: reboot_started
            /// </summary>
            public static readonly TaskStateEnum REBOOT_STARTED = new TaskStateEnum("reboot_started");

            /// <summary>
            /// Enum REBOOT_STARTED_HARD for value: reboot_started_hard
            /// </summary>
            public static readonly TaskStateEnum REBOOT_STARTED_HARD = new TaskStateEnum("reboot_started_hard");

            /// <summary>
            /// Enum POWERING_OFF for value: powering-off
            /// </summary>
            public static readonly TaskStateEnum POWERING_OFF = new TaskStateEnum("powering-off");

            /// <summary>
            /// Enum POWERING_ON for value: powering-on
            /// </summary>
            public static readonly TaskStateEnum POWERING_ON = new TaskStateEnum("powering-on");

            /// <summary>
            /// Enum REBUILDING for value: rebuilding
            /// </summary>
            public static readonly TaskStateEnum REBUILDING = new TaskStateEnum("rebuilding");

            /// <summary>
            /// Enum SCHEDULING for value: scheduling
            /// </summary>
            public static readonly TaskStateEnum SCHEDULING = new TaskStateEnum("scheduling");

            /// <summary>
            /// Enum DELETING for value: deleting
            /// </summary>
            public static readonly TaskStateEnum DELETING = new TaskStateEnum("deleting");

            private static readonly Dictionary<string, TaskStateEnum> StaticFields =
            new Dictionary<string, TaskStateEnum>()
            {
                { "rebooting", REBOOTING },
                { "reboot_started", REBOOT_STARTED },
                { "reboot_started_hard", REBOOT_STARTED_HARD },
                { "powering-off", POWERING_OFF },
                { "powering-on", POWERING_ON },
                { "rebuilding", REBUILDING },
                { "scheduling", SCHEDULING },
                { "deleting", DELETING },
            };

            private string _value;

            public TaskStateEnum()
            {

            }

            public TaskStateEnum(string value)
            {
                _value = value;
            }

            public static TaskStateEnum FromValue(string value)
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

                if (this.Equals(obj as TaskStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TaskStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TaskStateEnum a, TaskStateEnum b)
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

            public static bool operator !=(TaskStateEnum a, TaskStateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 扩展属性，裸金属服务器的稳定状态。例如：active：运行中shutoff：关机reboot：重启
        /// </summary>
        /// <value>扩展属性，裸金属服务器的稳定状态。例如：active：运行中shutoff：关机reboot：重启</value>
        [JsonConverter(typeof(EnumClassConverter<VmStateEnum>))]
        public class VmStateEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: active
            /// </summary>
            public static readonly VmStateEnum ACTIVE = new VmStateEnum("active");

            /// <summary>
            /// Enum SHUTOFF for value: shutoff
            /// </summary>
            public static readonly VmStateEnum SHUTOFF = new VmStateEnum("shutoff");

            /// <summary>
            /// Enum REBOOT for value: reboot
            /// </summary>
            public static readonly VmStateEnum REBOOT = new VmStateEnum("reboot");

            private static readonly Dictionary<string, VmStateEnum> StaticFields =
            new Dictionary<string, VmStateEnum>()
            {
                { "active", ACTIVE },
                { "shutoff", SHUTOFF },
                { "reboot", REBOOT },
            };

            private string _value;

            public VmStateEnum()
            {

            }

            public VmStateEnum(string value)
            {
                _value = value;
            }

            public static VmStateEnum FromValue(string value)
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

                if (this.Equals(obj as VmStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VmStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VmStateEnum a, VmStateEnum b)
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

            public static bool operator !=(VmStateEnum a, VmStateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 裸金属服务器ID，格式为UUID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// 创建裸金属服务器的用户ID，格式为UUID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 裸金属服务器名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 裸金属服务器创建时间。时间戳格式为ISO 8601：YYYY-MM-DDTHH:MM:SSZ，例如：2019-05-22T03:30:52Z
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 裸金属服务器更新时间。时间戳格式为ISO 8601：YYYY-MM-DDTHH:MM:SSZ，例如：2019-05-22T04:30:52Z
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 裸金属服务器所属租户ID，格式为UUID。该参数和project_id表示相同的概念。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public FlavorDetailInfos Flavor { get; set; }

        /// <summary>
        /// 裸金属服务器当前状态信息。  取值范围：  ACTIVE：运行中/正在关机/删除中 BUILD：创建中 ERROR：故障 HARD_REBOOT：强制重启中 REBOOT：重启中 DELETED：实例已被正常删除 SHUTOFF：关机/正在开机/删除中/重建中/重装操作系统中/重装操作系统失败/冻结
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 扩展属性，裸金属服务器当前的任务状态。例如：rebooting：重启中reboot_started：普通重启reboot_started_hard：强制重启powering-off：关机中powering-on：开机中rebuilding：重建中scheduling：调度中deleting：删除中
        /// </summary>
        [JsonProperty("task_state", NullValueHandling = NullValueHandling.Ignore)]
        public TaskStateEnum TaskState { get; set; }
        /// <summary>
        /// 扩展属性，裸金属服务器的稳定状态。例如：active：运行中shutoff：关机reboot：重启
        /// </summary>
        [JsonProperty("vm_state", NullValueHandling = NullValueHandling.Ignore)]
        public VmStateEnum VmState { get; set; }
        /// <summary>
        /// 扩展属性，裸金属服务器所在可用分区名称。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fault", NullValueHandling = NullValueHandling.Ignore)]
        public Fault Fault { get; set; }

        /// <summary>
        /// 裸机是否在回收站中
        /// </summary>
        [JsonProperty("in_recycle_in", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InRecycleIn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerListDetails {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  taskState: ").Append(TaskState).Append("\n");
            sb.Append("  vmState: ").Append(VmState).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  fault: ").Append(Fault).Append("\n");
            sb.Append("  inRecycleIn: ").Append(InRecycleIn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerListDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerListDetails input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.Status != input.Status) return false;
            if (this.TaskState != input.TaskState) return false;
            if (this.VmState != input.VmState) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.Fault != input.Fault || (this.Fault != null && !this.Fault.Equals(input.Fault))) return false;
            if (this.InRecycleIn != input.InRecycleIn || (this.InRecycleIn != null && !this.InRecycleIn.Equals(input.InRecycleIn))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.TaskState.GetHashCode();
                hashCode = hashCode * 59 + this.VmState.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.Fault != null) hashCode = hashCode * 59 + this.Fault.GetHashCode();
                if (this.InRecycleIn != null) hashCode = hashCode * 59 + this.InRecycleIn.GetHashCode();
                return hashCode;
            }
        }
    }
}
