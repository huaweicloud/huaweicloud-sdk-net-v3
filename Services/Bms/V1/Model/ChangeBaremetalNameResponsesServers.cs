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
    public class ChangeBaremetalNameResponsesServers 
    {
        /// <summary>
        /// 裸金属服务器当前状态。ACTIVE：运行中/正在关机/删除中BUILD：创建中ERROR：故障HARD_REBOOT：强制重启中REBOOT：重启中 SHUTOFF：关机/正在开机/删除中/重建中/重装操作系统中/重装操作系统失败/冻结
        /// </summary>
        /// <value>裸金属服务器当前状态。ACTIVE：运行中/正在关机/删除中BUILD：创建中ERROR：故障HARD_REBOOT：强制重启中REBOOT：重启中 SHUTOFF：关机/正在开机/删除中/重建中/重装操作系统中/重装操作系统失败/冻结</value>
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
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("DELETED");

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
            /// Enum REBUILD for value: REBUILD
            /// </summary>
            public static readonly StatusEnum REBUILD = new StatusEnum("REBUILD");

            /// <summary>
            /// Enum SHUTOFF for value: SHUTOFF
            /// </summary>
            public static readonly StatusEnum SHUTOFF = new StatusEnum("SHUTOFF");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "BUILD", BUILD },
                { "DELETED", DELETED },
                { "ERROR", ERROR },
                { "HARD_REBOOT", HARD_REBOOT },
                { "REBOOT", REBOOT },
                { "REBUILD", REBUILD },
                { "SHUTOFF", SHUTOFF },
            };

            private string Value;

            public StatusEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 扩展属性，磁盘配置方式，取值为如下两种：MANUAL：API使用镜像中的分区方案和文件系统创建裸金属服务器。如果目标flavor磁盘较大，则API不会对剩余磁盘空间进行分区。AUTO：API使用与目标flavor磁盘大小相同的单个分区创建裸金属服务器，API会自动调整文件系统以适应整个分区。
        /// </summary>
        /// <value>扩展属性，磁盘配置方式，取值为如下两种：MANUAL：API使用镜像中的分区方案和文件系统创建裸金属服务器。如果目标flavor磁盘较大，则API不会对剩余磁盘空间进行分区。AUTO：API使用与目标flavor磁盘大小相同的单个分区创建裸金属服务器，API会自动调整文件系统以适应整个分区。</value>
        [JsonConverter(typeof(EnumClassConverter<OSDCFdiskConfigEnum>))]
        public class OSDCFdiskConfigEnum
        {
            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            public static readonly OSDCFdiskConfigEnum MANUAL = new OSDCFdiskConfigEnum("MANUAL");

            /// <summary>
            /// Enum AUTO for value: AUTO
            /// </summary>
            public static readonly OSDCFdiskConfigEnum AUTO = new OSDCFdiskConfigEnum("AUTO");

            private static readonly Dictionary<string, OSDCFdiskConfigEnum> StaticFields =
            new Dictionary<string, OSDCFdiskConfigEnum>()
            {
                { "MANUAL", MANUAL },
                { "AUTO", AUTO },
            };

            private string Value;

            public OSDCFdiskConfigEnum(string value)
            {
                Value = value;
            }

            public static OSDCFdiskConfigEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
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

                if (this.Equals(obj as OSDCFdiskConfigEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OSDCFdiskConfigEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OSDCFdiskConfigEnum a, OSDCFdiskConfigEnum b)
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

            public static bool operator !=(OSDCFdiskConfigEnum a, OSDCFdiskConfigEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 扩展属性，裸金属服务器电源状态。例如：0表示“NO STATE”1表示“RUNNING”4表示“SHUTDOWN”
        /// </summary>
        /// <value>扩展属性，裸金属服务器电源状态。例如：0表示“NO STATE”1表示“RUNNING”4表示“SHUTDOWN”</value>
        [JsonConverter(typeof(EnumClassConverter<OSEXTSTSpowerStateEnum>))]
        public class OSEXTSTSpowerStateEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly OSEXTSTSpowerStateEnum NUMBER_0 = new OSEXTSTSpowerStateEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly OSEXTSTSpowerStateEnum NUMBER_1 = new OSEXTSTSpowerStateEnum(1);

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            public static readonly OSEXTSTSpowerStateEnum NUMBER_4 = new OSEXTSTSpowerStateEnum(4);

            private static readonly Dictionary<int?, OSEXTSTSpowerStateEnum> StaticFields =
            new Dictionary<int?, OSEXTSTSpowerStateEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 4, NUMBER_4 },
            };

            private int? Value;

            public OSEXTSTSpowerStateEnum(int? value)
            {
                Value = value;
            }

            public static OSEXTSTSpowerStateEnum FromValue(int? value)
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

            public int? GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
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

                if (this.Equals(obj as OSEXTSTSpowerStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OSEXTSTSpowerStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OSEXTSTSpowerStateEnum a, OSEXTSTSpowerStateEnum b)
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

            public static bool operator !=(OSEXTSTSpowerStateEnum a, OSEXTSTSpowerStateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 扩展属性，裸金属服务器任务状态。例如：rebooting表示重启中reboot_started表示普通重启reboot_started_hard表示强制重启powering-off表示关机中powering-on表示开机中rebuilding表示重建中scheduling表示调度中deleting表示删除中
        /// </summary>
        /// <value>扩展属性，裸金属服务器任务状态。例如：rebooting表示重启中reboot_started表示普通重启reboot_started_hard表示强制重启powering-off表示关机中powering-on表示开机中rebuilding表示重建中scheduling表示调度中deleting表示删除中</value>
        [JsonConverter(typeof(EnumClassConverter<OSEXTSTStaskStateEnum>))]
        public class OSEXTSTStaskStateEnum
        {
            /// <summary>
            /// Enum REBOOTING for value: rebooting
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum REBOOTING = new OSEXTSTStaskStateEnum("rebooting");

            /// <summary>
            /// Enum REBOOT_STARTED for value: reboot_started
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum REBOOT_STARTED = new OSEXTSTStaskStateEnum("reboot_started");

            /// <summary>
            /// Enum REBOOT_STARTED_HARD for value: reboot_started_hard
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum REBOOT_STARTED_HARD = new OSEXTSTStaskStateEnum("reboot_started_hard");

            /// <summary>
            /// Enum POWERING_OFF for value: powering-off
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum POWERING_OFF = new OSEXTSTStaskStateEnum("powering-off");

            /// <summary>
            /// Enum POWERING_ON for value: powering-on
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum POWERING_ON = new OSEXTSTStaskStateEnum("powering-on");

            /// <summary>
            /// Enum REBUILDING for value: rebuilding
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum REBUILDING = new OSEXTSTStaskStateEnum("rebuilding");

            /// <summary>
            /// Enum SCHEDULING for value: scheduling
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum SCHEDULING = new OSEXTSTStaskStateEnum("scheduling");

            /// <summary>
            /// Enum DELETING for value: deleting
            /// </summary>
            public static readonly OSEXTSTStaskStateEnum DELETING = new OSEXTSTStaskStateEnum("deleting");

            private static readonly Dictionary<string, OSEXTSTStaskStateEnum> StaticFields =
            new Dictionary<string, OSEXTSTStaskStateEnum>()
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

            private string Value;

            public OSEXTSTStaskStateEnum(string value)
            {
                Value = value;
            }

            public static OSEXTSTStaskStateEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
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

                if (this.Equals(obj as OSEXTSTStaskStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OSEXTSTStaskStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OSEXTSTStaskStateEnum a, OSEXTSTStaskStateEnum b)
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

            public static bool operator !=(OSEXTSTStaskStateEnum a, OSEXTSTStaskStateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 扩展属性，裸金属服务器状态。例如：RUNNING表示运行中SHUTOFF表示关机SUSPENDED表示暂停REBOOT表示重启
        /// </summary>
        /// <value>扩展属性，裸金属服务器状态。例如：RUNNING表示运行中SHUTOFF表示关机SUSPENDED表示暂停REBOOT表示重启</value>
        [JsonConverter(typeof(EnumClassConverter<OSEXTSTSvmStateEnum>))]
        public class OSEXTSTSvmStateEnum
        {
            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            public static readonly OSEXTSTSvmStateEnum RUNNING = new OSEXTSTSvmStateEnum("RUNNING");

            /// <summary>
            /// Enum SHUTOFF for value: SHUTOFF
            /// </summary>
            public static readonly OSEXTSTSvmStateEnum SHUTOFF = new OSEXTSTSvmStateEnum("SHUTOFF");

            /// <summary>
            /// Enum SUSPENDED for value: SUSPENDED
            /// </summary>
            public static readonly OSEXTSTSvmStateEnum SUSPENDED = new OSEXTSTSvmStateEnum("SUSPENDED");

            /// <summary>
            /// Enum REBOOT for value: REBOOT
            /// </summary>
            public static readonly OSEXTSTSvmStateEnum REBOOT = new OSEXTSTSvmStateEnum("REBOOT");

            private static readonly Dictionary<string, OSEXTSTSvmStateEnum> StaticFields =
            new Dictionary<string, OSEXTSTSvmStateEnum>()
            {
                { "RUNNING", RUNNING },
                { "SHUTOFF", SHUTOFF },
                { "SUSPENDED", SUSPENDED },
                { "REBOOT", REBOOT },
            };

            private string Value;

            public OSEXTSTSvmStateEnum(string value)
            {
                Value = value;
            }

            public static OSEXTSTSvmStateEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
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

                if (this.Equals(obj as OSEXTSTSvmStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OSEXTSTSvmStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OSEXTSTSvmStateEnum a, OSEXTSTSvmStateEnum b)
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

            public static bool operator !=(OSEXTSTSvmStateEnum a, OSEXTSTSvmStateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 裸金属服务器宿主机状态。UP：服务正常UNKNOWN：状态未知DOWN：服务异常MAINTENANCE：维护状态空字符串：裸金属服务器无主机信息
        /// </summary>
        /// <value>裸金属服务器宿主机状态。UP：服务正常UNKNOWN：状态未知DOWN：服务异常MAINTENANCE：维护状态空字符串：裸金属服务器无主机信息</value>
        [JsonConverter(typeof(EnumClassConverter<HostStatusEnum>))]
        public class HostStatusEnum
        {
            /// <summary>
            /// Enum UP for value: UP
            /// </summary>
            public static readonly HostStatusEnum UP = new HostStatusEnum("UP");

            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            public static readonly HostStatusEnum UNKNOWN = new HostStatusEnum("UNKNOWN");

            /// <summary>
            /// Enum DOWN for value: DOWN
            /// </summary>
            public static readonly HostStatusEnum DOWN = new HostStatusEnum("DOWN");

            /// <summary>
            /// Enum MAINTENANCE for value: MAINTENANCE
            /// </summary>
            public static readonly HostStatusEnum MAINTENANCE = new HostStatusEnum("MAINTENANCE");

            private static readonly Dictionary<string, HostStatusEnum> StaticFields =
            new Dictionary<string, HostStatusEnum>()
            {
                { "UP", UP },
                { "UNKNOWN", UNKNOWN },
                { "DOWN", DOWN },
                { "MAINTENANCE", MAINTENANCE },
            };

            private string Value;

            public HostStatusEnum(string value)
            {
                Value = value;
            }

            public static HostStatusEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
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

                if (this.Equals(obj as HostStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HostStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(HostStatusEnum a, HostStatusEnum b)
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

            public static bool operator !=(HostStatusEnum a, HostStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 裸金属服务器名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 裸金属服务器唯一标识ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// 裸金属服务器当前状态。ACTIVE：运行中/正在关机/删除中BUILD：创建中ERROR：故障HARD_REBOOT：强制重启中REBOOT：重启中 SHUTOFF：关机/正在开机/删除中/重建中/重装操作系统中/重装操作系统失败/冻结
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 裸金属服务器创建时间。时间戳格式为ISO 8601：YYYY-MM-DDTHH:MM:SSZ，例如：2019-05-22T03:30:52Z
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// 裸金属服务器上一次更新时间。时间戳格式为ISO 8601：YYYY-MM-DDTHH:MM:SSZ，例如：2019-05-22T04:30:52Z
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public FlavorInfo Flavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public Image Image { get; set; }

        /// <summary>
        /// 裸金属服务器所属租户ID，格式为UUID。该参数和project_id表示相同的概念。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TenantId { get; set; }

        /// <summary>
        /// SSH密钥名称
        /// </summary>
        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyName { get; set; }

        /// <summary>
        /// 裸金属服务器所属用户ID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public MetadataInfos Metadata { get; set; }

        /// <summary>
        /// 裸金属服务器的主机ID
        /// </summary>
        [JsonProperty("hostId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? HostId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
        public Addresses Addresses { get; set; }

        /// <summary>
        /// 裸金属服务器所属安全组列表。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityGroups> SecurityGroups { get; set; }

        /// <summary>
        /// 裸金属服务器相关信息快捷链接
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Links> Links { get; set; }

        /// <summary>
        /// 扩展属性，磁盘配置方式，取值为如下两种：MANUAL：API使用镜像中的分区方案和文件系统创建裸金属服务器。如果目标flavor磁盘较大，则API不会对剩余磁盘空间进行分区。AUTO：API使用与目标flavor磁盘大小相同的单个分区创建裸金属服务器，API会自动调整文件系统以适应整个分区。
        /// </summary>
        [JsonProperty("OS-DCF:diskConfig", NullValueHandling = NullValueHandling.Ignore)]
        public OSDCFdiskConfigEnum OSDCFdiskConfig { get; set; }
        /// <summary>
        /// 扩展属性，可用分区编码。
        /// </summary>
        [JsonProperty("OS-EXT-AZ:availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTAZavailabilityZone { get; set; }

        /// <summary>
        /// 扩展属性，裸金属服务器宿主名称
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:host", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRhost { get; set; }

        /// <summary>
        /// 扩展属性，hypervisor主机名称，由Nova virt驱动提供
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:hypervisor_hostname", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRhypervisorHostname { get; set; }

        /// <summary>
        /// 扩展属性，裸金属服务器实例ID
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRinstanceName { get; set; }

        /// <summary>
        /// 扩展属性，裸金属服务器电源状态。例如：0表示“NO STATE”1表示“RUNNING”4表示“SHUTDOWN”
        /// </summary>
        [JsonProperty("OS-EXT-STS:power_state", NullValueHandling = NullValueHandling.Ignore)]
        public OSEXTSTSpowerStateEnum OSEXTSTSpowerState { get; set; }
        /// <summary>
        /// 扩展属性，裸金属服务器任务状态。例如：rebooting表示重启中reboot_started表示普通重启reboot_started_hard表示强制重启powering-off表示关机中powering-on表示开机中rebuilding表示重建中scheduling表示调度中deleting表示删除中
        /// </summary>
        [JsonProperty("OS-EXT-STS:task_state", NullValueHandling = NullValueHandling.Ignore)]
        public OSEXTSTStaskStateEnum OSEXTSTStaskState { get; set; }
        /// <summary>
        /// 扩展属性，裸金属服务器状态。例如：RUNNING表示运行中SHUTOFF表示关机SUSPENDED表示暂停REBOOT表示重启
        /// </summary>
        [JsonProperty("OS-EXT-STS:vm_state", NullValueHandling = NullValueHandling.Ignore)]
        public OSEXTSTSvmStateEnum OSEXTSTSvmState { get; set; }
        /// <summary>
        /// 扩展属性，裸金属服务器启动时间。时间戳格式为ISO 8601，例如：2019-05-25T03:40:25.000000
        /// </summary>
        [JsonProperty("OS-SRV-USG:launched_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? OSSRVUSGlaunchedAt { get; set; }

        /// <summary>
        /// 扩展属性，裸金属服务器关闭时间。时间戳格式为ISO 8601，例如：2019-06-25T03:40:25.000000
        /// </summary>
        [JsonProperty("OS-SRV-USG:terminated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? OSSRVUSGterminatedAt { get; set; }

        /// <summary>
        /// 裸金属服务器挂载的云硬盘信息。详情请参见表 os-extended-volumes:volumes_attached字段数据结构说明。
        /// </summary>
        [JsonProperty("os-extended-volumes:volumes_attached", NullValueHandling = NullValueHandling.Ignore)]
        public List<OsExtendedVolumes> OsExtendedVolumesvolumesAttached { get; set; }

        /// <summary>
        /// 预留属性
        /// </summary>
        [JsonProperty("accessIPv4", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessIPv4 { get; set; }

        /// <summary>
        /// 预留属性
        /// </summary>
        [JsonProperty("accessIPv6", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessIPv6 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fault", NullValueHandling = NullValueHandling.Ignore)]
        public Fault Fault { get; set; }

        /// <summary>
        /// config drive信息
        /// </summary>
        [JsonProperty("config_drive", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigDrive { get; set; }

        /// <summary>
        /// 预留属性
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public int? Progress { get; set; }

        /// <summary>
        /// 裸金属服务器的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 裸金属服务器宿主机状态。UP：服务正常UNKNOWN：状态未知DOWN：服务异常MAINTENANCE：维护状态空字符串：裸金属服务器无主机信息
        /// </summary>
        [JsonProperty("host_status", NullValueHandling = NullValueHandling.Ignore)]
        public HostStatusEnum HostStatus { get; set; }
        /// <summary>
        /// 裸金属服务器的主机名
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:hostname", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRhostname { get; set; }

        /// <summary>
        /// 批量创建场景，裸金属服务器的预留ID。当批量创建裸金属服务器时，这些服务器将拥有相同的reservation_id。您可以使用6.3.3-查询裸金属服务器详情列表API并指定reservation_id来过滤查询同一批创建的所有裸金属服务器。
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:reservation_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OSEXTSRVATTRreservationId { get; set; }

        /// <summary>
        /// 批量创建场景，裸金属服务器的启动顺序
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:launch_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? OSEXTSRVATTRlaunchIndex { get; set; }

        /// <summary>
        /// 若使用AMI格式的镜像，则表示kernel image的UUID；否则，留空
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:kernel_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OSEXTSRVATTRkernelId { get; set; }

        /// <summary>
        /// 若使用AMI格式镜像，则表示ramdisk image的UUID；否则，留空。
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:ramdisk_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OSEXTSRVATTRramdiskId { get; set; }

        /// <summary>
        /// 裸金属服务器系统盘的设备名称，例如“/dev/sdb”。
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:root_device_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRrootDeviceName { get; set; }

        /// <summary>
        /// 创建裸金属服务器时指定的user_data。取值为base64编码后的结果或空字符串。
        /// </summary>
        [JsonProperty("OS-EXT-SRV-ATTR:user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTSRVATTRuserData { get; set; }

        /// <summary>
        /// 裸金属服务器实例是否为锁定状态。true：锁定false：未锁定
        /// </summary>
        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Locked { get; set; }

        /// <summary>
        /// 裸金属服务器标签
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 裸金属服务器的系统标签
        /// </summary>
        [JsonProperty("sys_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<SystemTags> SysTags { get; set; }

        /// <summary>
        /// enterprise_project_id。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os:scheduler_hints", NullValueHandling = NullValueHandling.Ignore)]
        public ServerOsSchedulerHints OsschedulerHints { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeBaremetalNameResponsesServers {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  keyName: ").Append(KeyName).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  hostId: ").Append(HostId).Append("\n");
            sb.Append("  addresses: ").Append(Addresses).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  oSDCFdiskConfig: ").Append(OSDCFdiskConfig).Append("\n");
            sb.Append("  oSEXTAZavailabilityZone: ").Append(OSEXTAZavailabilityZone).Append("\n");
            sb.Append("  oSEXTSRVATTRhost: ").Append(OSEXTSRVATTRhost).Append("\n");
            sb.Append("  oSEXTSRVATTRhypervisorHostname: ").Append(OSEXTSRVATTRhypervisorHostname).Append("\n");
            sb.Append("  oSEXTSRVATTRinstanceName: ").Append(OSEXTSRVATTRinstanceName).Append("\n");
            sb.Append("  oSEXTSTSpowerState: ").Append(OSEXTSTSpowerState).Append("\n");
            sb.Append("  oSEXTSTStaskState: ").Append(OSEXTSTStaskState).Append("\n");
            sb.Append("  oSEXTSTSvmState: ").Append(OSEXTSTSvmState).Append("\n");
            sb.Append("  oSSRVUSGlaunchedAt: ").Append(OSSRVUSGlaunchedAt).Append("\n");
            sb.Append("  oSSRVUSGterminatedAt: ").Append(OSSRVUSGterminatedAt).Append("\n");
            sb.Append("  osExtendedVolumesvolumesAttached: ").Append(OsExtendedVolumesvolumesAttached).Append("\n");
            sb.Append("  accessIPv4: ").Append(AccessIPv4).Append("\n");
            sb.Append("  accessIPv6: ").Append(AccessIPv6).Append("\n");
            sb.Append("  fault: ").Append(Fault).Append("\n");
            sb.Append("  configDrive: ").Append(ConfigDrive).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  hostStatus: ").Append(HostStatus).Append("\n");
            sb.Append("  oSEXTSRVATTRhostname: ").Append(OSEXTSRVATTRhostname).Append("\n");
            sb.Append("  oSEXTSRVATTRreservationId: ").Append(OSEXTSRVATTRreservationId).Append("\n");
            sb.Append("  oSEXTSRVATTRlaunchIndex: ").Append(OSEXTSRVATTRlaunchIndex).Append("\n");
            sb.Append("  oSEXTSRVATTRkernelId: ").Append(OSEXTSRVATTRkernelId).Append("\n");
            sb.Append("  oSEXTSRVATTRramdiskId: ").Append(OSEXTSRVATTRramdiskId).Append("\n");
            sb.Append("  oSEXTSRVATTRrootDeviceName: ").Append(OSEXTSRVATTRrootDeviceName).Append("\n");
            sb.Append("  oSEXTSRVATTRuserData: ").Append(OSEXTSRVATTRuserData).Append("\n");
            sb.Append("  locked: ").Append(Locked).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  sysTags: ").Append(SysTags).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  osschedulerHints: ").Append(OsschedulerHints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeBaremetalNameResponsesServers);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeBaremetalNameResponsesServers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.Flavor == input.Flavor ||
                    (this.Flavor != null &&
                    this.Flavor.Equals(input.Flavor))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.HostId == input.HostId ||
                    (this.HostId != null &&
                    this.HostId.Equals(input.HostId))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    (this.Addresses != null &&
                    this.Addresses.Equals(input.Addresses))
                ) && 
                (
                    this.SecurityGroups == input.SecurityGroups ||
                    this.SecurityGroups != null &&
                    input.SecurityGroups != null &&
                    this.SecurityGroups.SequenceEqual(input.SecurityGroups)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.OSDCFdiskConfig == input.OSDCFdiskConfig ||
                    (this.OSDCFdiskConfig != null &&
                    this.OSDCFdiskConfig.Equals(input.OSDCFdiskConfig))
                ) && 
                (
                    this.OSEXTAZavailabilityZone == input.OSEXTAZavailabilityZone ||
                    (this.OSEXTAZavailabilityZone != null &&
                    this.OSEXTAZavailabilityZone.Equals(input.OSEXTAZavailabilityZone))
                ) && 
                (
                    this.OSEXTSRVATTRhost == input.OSEXTSRVATTRhost ||
                    (this.OSEXTSRVATTRhost != null &&
                    this.OSEXTSRVATTRhost.Equals(input.OSEXTSRVATTRhost))
                ) && 
                (
                    this.OSEXTSRVATTRhypervisorHostname == input.OSEXTSRVATTRhypervisorHostname ||
                    (this.OSEXTSRVATTRhypervisorHostname != null &&
                    this.OSEXTSRVATTRhypervisorHostname.Equals(input.OSEXTSRVATTRhypervisorHostname))
                ) && 
                (
                    this.OSEXTSRVATTRinstanceName == input.OSEXTSRVATTRinstanceName ||
                    (this.OSEXTSRVATTRinstanceName != null &&
                    this.OSEXTSRVATTRinstanceName.Equals(input.OSEXTSRVATTRinstanceName))
                ) && 
                (
                    this.OSEXTSTSpowerState == input.OSEXTSTSpowerState ||
                    (this.OSEXTSTSpowerState != null &&
                    this.OSEXTSTSpowerState.Equals(input.OSEXTSTSpowerState))
                ) && 
                (
                    this.OSEXTSTStaskState == input.OSEXTSTStaskState ||
                    (this.OSEXTSTStaskState != null &&
                    this.OSEXTSTStaskState.Equals(input.OSEXTSTStaskState))
                ) && 
                (
                    this.OSEXTSTSvmState == input.OSEXTSTSvmState ||
                    (this.OSEXTSTSvmState != null &&
                    this.OSEXTSTSvmState.Equals(input.OSEXTSTSvmState))
                ) && 
                (
                    this.OSSRVUSGlaunchedAt == input.OSSRVUSGlaunchedAt ||
                    (this.OSSRVUSGlaunchedAt != null &&
                    this.OSSRVUSGlaunchedAt.Equals(input.OSSRVUSGlaunchedAt))
                ) && 
                (
                    this.OSSRVUSGterminatedAt == input.OSSRVUSGterminatedAt ||
                    (this.OSSRVUSGterminatedAt != null &&
                    this.OSSRVUSGterminatedAt.Equals(input.OSSRVUSGterminatedAt))
                ) && 
                (
                    this.OsExtendedVolumesvolumesAttached == input.OsExtendedVolumesvolumesAttached ||
                    this.OsExtendedVolumesvolumesAttached != null &&
                    input.OsExtendedVolumesvolumesAttached != null &&
                    this.OsExtendedVolumesvolumesAttached.SequenceEqual(input.OsExtendedVolumesvolumesAttached)
                ) && 
                (
                    this.AccessIPv4 == input.AccessIPv4 ||
                    (this.AccessIPv4 != null &&
                    this.AccessIPv4.Equals(input.AccessIPv4))
                ) && 
                (
                    this.AccessIPv6 == input.AccessIPv6 ||
                    (this.AccessIPv6 != null &&
                    this.AccessIPv6.Equals(input.AccessIPv6))
                ) && 
                (
                    this.Fault == input.Fault ||
                    (this.Fault != null &&
                    this.Fault.Equals(input.Fault))
                ) && 
                (
                    this.ConfigDrive == input.ConfigDrive ||
                    (this.ConfigDrive != null &&
                    this.ConfigDrive.Equals(input.ConfigDrive))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.HostStatus == input.HostStatus ||
                    (this.HostStatus != null &&
                    this.HostStatus.Equals(input.HostStatus))
                ) && 
                (
                    this.OSEXTSRVATTRhostname == input.OSEXTSRVATTRhostname ||
                    (this.OSEXTSRVATTRhostname != null &&
                    this.OSEXTSRVATTRhostname.Equals(input.OSEXTSRVATTRhostname))
                ) && 
                (
                    this.OSEXTSRVATTRreservationId == input.OSEXTSRVATTRreservationId ||
                    (this.OSEXTSRVATTRreservationId != null &&
                    this.OSEXTSRVATTRreservationId.Equals(input.OSEXTSRVATTRreservationId))
                ) && 
                (
                    this.OSEXTSRVATTRlaunchIndex == input.OSEXTSRVATTRlaunchIndex ||
                    (this.OSEXTSRVATTRlaunchIndex != null &&
                    this.OSEXTSRVATTRlaunchIndex.Equals(input.OSEXTSRVATTRlaunchIndex))
                ) && 
                (
                    this.OSEXTSRVATTRkernelId == input.OSEXTSRVATTRkernelId ||
                    (this.OSEXTSRVATTRkernelId != null &&
                    this.OSEXTSRVATTRkernelId.Equals(input.OSEXTSRVATTRkernelId))
                ) && 
                (
                    this.OSEXTSRVATTRramdiskId == input.OSEXTSRVATTRramdiskId ||
                    (this.OSEXTSRVATTRramdiskId != null &&
                    this.OSEXTSRVATTRramdiskId.Equals(input.OSEXTSRVATTRramdiskId))
                ) && 
                (
                    this.OSEXTSRVATTRrootDeviceName == input.OSEXTSRVATTRrootDeviceName ||
                    (this.OSEXTSRVATTRrootDeviceName != null &&
                    this.OSEXTSRVATTRrootDeviceName.Equals(input.OSEXTSRVATTRrootDeviceName))
                ) && 
                (
                    this.OSEXTSRVATTRuserData == input.OSEXTSRVATTRuserData ||
                    (this.OSEXTSRVATTRuserData != null &&
                    this.OSEXTSRVATTRuserData.Equals(input.OSEXTSRVATTRuserData))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.SysTags == input.SysTags ||
                    this.SysTags != null &&
                    input.SysTags != null &&
                    this.SysTags.SequenceEqual(input.SysTags)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.OsschedulerHints == input.OsschedulerHints ||
                    (this.OsschedulerHints != null &&
                    this.OsschedulerHints.Equals(input.OsschedulerHints))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Flavor != null)
                    hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.KeyName != null)
                    hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.HostId != null)
                    hashCode = hashCode * 59 + this.HostId.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.SecurityGroups != null)
                    hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.OSDCFdiskConfig != null)
                    hashCode = hashCode * 59 + this.OSDCFdiskConfig.GetHashCode();
                if (this.OSEXTAZavailabilityZone != null)
                    hashCode = hashCode * 59 + this.OSEXTAZavailabilityZone.GetHashCode();
                if (this.OSEXTSRVATTRhost != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRhost.GetHashCode();
                if (this.OSEXTSRVATTRhypervisorHostname != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRhypervisorHostname.GetHashCode();
                if (this.OSEXTSRVATTRinstanceName != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRinstanceName.GetHashCode();
                if (this.OSEXTSTSpowerState != null)
                    hashCode = hashCode * 59 + this.OSEXTSTSpowerState.GetHashCode();
                if (this.OSEXTSTStaskState != null)
                    hashCode = hashCode * 59 + this.OSEXTSTStaskState.GetHashCode();
                if (this.OSEXTSTSvmState != null)
                    hashCode = hashCode * 59 + this.OSEXTSTSvmState.GetHashCode();
                if (this.OSSRVUSGlaunchedAt != null)
                    hashCode = hashCode * 59 + this.OSSRVUSGlaunchedAt.GetHashCode();
                if (this.OSSRVUSGterminatedAt != null)
                    hashCode = hashCode * 59 + this.OSSRVUSGterminatedAt.GetHashCode();
                if (this.OsExtendedVolumesvolumesAttached != null)
                    hashCode = hashCode * 59 + this.OsExtendedVolumesvolumesAttached.GetHashCode();
                if (this.AccessIPv4 != null)
                    hashCode = hashCode * 59 + this.AccessIPv4.GetHashCode();
                if (this.AccessIPv6 != null)
                    hashCode = hashCode * 59 + this.AccessIPv6.GetHashCode();
                if (this.Fault != null)
                    hashCode = hashCode * 59 + this.Fault.GetHashCode();
                if (this.ConfigDrive != null)
                    hashCode = hashCode * 59 + this.ConfigDrive.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.HostStatus != null)
                    hashCode = hashCode * 59 + this.HostStatus.GetHashCode();
                if (this.OSEXTSRVATTRhostname != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRhostname.GetHashCode();
                if (this.OSEXTSRVATTRreservationId != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRreservationId.GetHashCode();
                if (this.OSEXTSRVATTRlaunchIndex != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRlaunchIndex.GetHashCode();
                if (this.OSEXTSRVATTRkernelId != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRkernelId.GetHashCode();
                if (this.OSEXTSRVATTRramdiskId != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRramdiskId.GetHashCode();
                if (this.OSEXTSRVATTRrootDeviceName != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRrootDeviceName.GetHashCode();
                if (this.OSEXTSRVATTRuserData != null)
                    hashCode = hashCode * 59 + this.OSEXTSRVATTRuserData.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.SysTags != null)
                    hashCode = hashCode * 59 + this.SysTags.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.OsschedulerHints != null)
                    hashCode = hashCode * 59 + this.OsschedulerHints.GetHashCode();
                return hashCode;
            }
        }
    }
}
