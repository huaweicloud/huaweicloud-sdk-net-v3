using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 在线迁移任务列表信息体
    /// </summary>
    public class JobInfo 
    {
        /// <summary>
        /// 任务状态。 - CREATING：创建中 - CREATE_FAILED：创建失败 - CONFIGURATION：配置中 - STARTJOBING：启动中 - WAITING_FOR_START：等待启动中 - START_JOB_FAILED：启动失败 - PAUSING：已暂停 - FULL_TRANSFER_STARTED：全量开始，灾备场景下为初始化 - FULL_TRANSFER_FAILED：全量失败，灾备场景下为初始化失败 - FULL_TRANSFER_COMPLETE：全量完成，灾备场景下为初始化完成 - INCRE_TRANSFER_STARTED：增量开始，灾备场景下为灾备中 - INCRE_TRANSFER_FAILED：增量失败，灾备场景下为灾备异常 - RELEASE_RESOURCE_STARTED：结束任务中 - RELEASE_RESOURCE_FAILED：结束任务失败 - RELEASE_RESOURCE_COMPLETE：已结束 - REBUILD_NODE_STARTED：故障恢复中 - REBUILD_NODE_FAILED：故障恢复失败 - CHANGE_JOB_STARTED：任务变更中 - CHANGE_JOB_FAILED：任务变更失败 - DELETED：已删除 - CHILD_TRANSFER_STARTING：再编辑子任务启动中 - CHILD_TRANSFER_STARTED：再编辑子任务迁移中 - CHILD_TRANSFER_COMPLETE：再编辑子任务迁移完成 - CHILD_TRANSFER_FAILED：再编辑子任务迁移失败 - RELEASE_CHILD_TRANSFER_STARTED：再编辑子任务结束中 - RELEASE_CHILD_TRANSFER_COMPLETE：再编辑子任务已结束 - NODE_UPGRADE_START：升级开始 - NODE_UPGRADE_COMPLETE：升级完成 - NODE_UPGRADE_FAILED：升级失败
        /// </summary>
        /// <value>任务状态。 - CREATING：创建中 - CREATE_FAILED：创建失败 - CONFIGURATION：配置中 - STARTJOBING：启动中 - WAITING_FOR_START：等待启动中 - START_JOB_FAILED：启动失败 - PAUSING：已暂停 - FULL_TRANSFER_STARTED：全量开始，灾备场景下为初始化 - FULL_TRANSFER_FAILED：全量失败，灾备场景下为初始化失败 - FULL_TRANSFER_COMPLETE：全量完成，灾备场景下为初始化完成 - INCRE_TRANSFER_STARTED：增量开始，灾备场景下为灾备中 - INCRE_TRANSFER_FAILED：增量失败，灾备场景下为灾备异常 - RELEASE_RESOURCE_STARTED：结束任务中 - RELEASE_RESOURCE_FAILED：结束任务失败 - RELEASE_RESOURCE_COMPLETE：已结束 - REBUILD_NODE_STARTED：故障恢复中 - REBUILD_NODE_FAILED：故障恢复失败 - CHANGE_JOB_STARTED：任务变更中 - CHANGE_JOB_FAILED：任务变更失败 - DELETED：已删除 - CHILD_TRANSFER_STARTING：再编辑子任务启动中 - CHILD_TRANSFER_STARTED：再编辑子任务迁移中 - CHILD_TRANSFER_COMPLETE：再编辑子任务迁移完成 - CHILD_TRANSFER_FAILED：再编辑子任务迁移失败 - RELEASE_CHILD_TRANSFER_STARTED：再编辑子任务结束中 - RELEASE_CHILD_TRANSFER_COMPLETE：再编辑子任务已结束 - NODE_UPGRADE_START：升级开始 - NODE_UPGRADE_COMPLETE：升级完成 - NODE_UPGRADE_FAILED：升级失败</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATING for value: CREATING
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("CREATING");

            /// <summary>
            /// Enum CREATE_FAILED for value: CREATE_FAILED
            /// </summary>
            public static readonly StatusEnum CREATE_FAILED = new StatusEnum("CREATE_FAILED");

            /// <summary>
            /// Enum CONFIGURATION for value: CONFIGURATION
            /// </summary>
            public static readonly StatusEnum CONFIGURATION = new StatusEnum("CONFIGURATION");

            /// <summary>
            /// Enum STARTJOBING for value: STARTJOBING
            /// </summary>
            public static readonly StatusEnum STARTJOBING = new StatusEnum("STARTJOBING");

            /// <summary>
            /// Enum WAITING_FOR_START for value: WAITING_FOR_START
            /// </summary>
            public static readonly StatusEnum WAITING_FOR_START = new StatusEnum("WAITING_FOR_START");

            /// <summary>
            /// Enum START_JOB_FAILED for value: START_JOB_FAILED
            /// </summary>
            public static readonly StatusEnum START_JOB_FAILED = new StatusEnum("START_JOB_FAILED");

            /// <summary>
            /// Enum PAUSING for value: PAUSING
            /// </summary>
            public static readonly StatusEnum PAUSING = new StatusEnum("PAUSING");

            /// <summary>
            /// Enum FULL_TRANSFER_STARTED for value: FULL_TRANSFER_STARTED
            /// </summary>
            public static readonly StatusEnum FULL_TRANSFER_STARTED = new StatusEnum("FULL_TRANSFER_STARTED");

            /// <summary>
            /// Enum FULL_TRANSFER_FAILED for value: FULL_TRANSFER_FAILED
            /// </summary>
            public static readonly StatusEnum FULL_TRANSFER_FAILED = new StatusEnum("FULL_TRANSFER_FAILED");

            /// <summary>
            /// Enum FULL_TRANSFER_COMPLETE for value: FULL_TRANSFER_COMPLETE
            /// </summary>
            public static readonly StatusEnum FULL_TRANSFER_COMPLETE = new StatusEnum("FULL_TRANSFER_COMPLETE");

            /// <summary>
            /// Enum INCRE_TRANSFER_STARTED for value: INCRE_TRANSFER_STARTED
            /// </summary>
            public static readonly StatusEnum INCRE_TRANSFER_STARTED = new StatusEnum("INCRE_TRANSFER_STARTED");

            /// <summary>
            /// Enum INCRE_TRANSFER_FAILED for value: INCRE_TRANSFER_FAILED
            /// </summary>
            public static readonly StatusEnum INCRE_TRANSFER_FAILED = new StatusEnum("INCRE_TRANSFER_FAILED");

            /// <summary>
            /// Enum RELEASE_RESOURCE_STARTED for value: RELEASE_RESOURCE_STARTED
            /// </summary>
            public static readonly StatusEnum RELEASE_RESOURCE_STARTED = new StatusEnum("RELEASE_RESOURCE_STARTED");

            /// <summary>
            /// Enum RELEASE_RESOURCE_FAILED for value: RELEASE_RESOURCE_FAILED
            /// </summary>
            public static readonly StatusEnum RELEASE_RESOURCE_FAILED = new StatusEnum("RELEASE_RESOURCE_FAILED");

            /// <summary>
            /// Enum RELEASE_RESOURCE_COMPLETE for value: RELEASE_RESOURCE_COMPLETE
            /// </summary>
            public static readonly StatusEnum RELEASE_RESOURCE_COMPLETE = new StatusEnum("RELEASE_RESOURCE_COMPLETE");

            /// <summary>
            /// Enum REBUILD_NODE_STARTED for value: REBUILD_NODE_STARTED
            /// </summary>
            public static readonly StatusEnum REBUILD_NODE_STARTED = new StatusEnum("REBUILD_NODE_STARTED");

            /// <summary>
            /// Enum REBUILD_NODE_FAILED for value: REBUILD_NODE_FAILED
            /// </summary>
            public static readonly StatusEnum REBUILD_NODE_FAILED = new StatusEnum("REBUILD_NODE_FAILED");

            /// <summary>
            /// Enum CHANGE_JOB_STARTED for value: CHANGE_JOB_STARTED
            /// </summary>
            public static readonly StatusEnum CHANGE_JOB_STARTED = new StatusEnum("CHANGE_JOB_STARTED");

            /// <summary>
            /// Enum CHANGE_JOB_FAILED for value: CHANGE_JOB_FAILED
            /// </summary>
            public static readonly StatusEnum CHANGE_JOB_FAILED = new StatusEnum("CHANGE_JOB_FAILED");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("DELETED");

            /// <summary>
            /// Enum CHILD_TRANSFER_STARTING for value: CHILD_TRANSFER_STARTING
            /// </summary>
            public static readonly StatusEnum CHILD_TRANSFER_STARTING = new StatusEnum("CHILD_TRANSFER_STARTING");

            /// <summary>
            /// Enum CHILD_TRANSFER_STARTED for value: CHILD_TRANSFER_STARTED
            /// </summary>
            public static readonly StatusEnum CHILD_TRANSFER_STARTED = new StatusEnum("CHILD_TRANSFER_STARTED");

            /// <summary>
            /// Enum CHILD_TRANSFER_COMPLETE for value: CHILD_TRANSFER_COMPLETE
            /// </summary>
            public static readonly StatusEnum CHILD_TRANSFER_COMPLETE = new StatusEnum("CHILD_TRANSFER_COMPLETE");

            /// <summary>
            /// Enum CHILD_TRANSFER_FAILED for value: CHILD_TRANSFER_FAILED
            /// </summary>
            public static readonly StatusEnum CHILD_TRANSFER_FAILED = new StatusEnum("CHILD_TRANSFER_FAILED");

            /// <summary>
            /// Enum RELEASE_CHILD_TRANSFER_STARTED for value: RELEASE_CHILD_TRANSFER_STARTED
            /// </summary>
            public static readonly StatusEnum RELEASE_CHILD_TRANSFER_STARTED = new StatusEnum("RELEASE_CHILD_TRANSFER_STARTED");

            /// <summary>
            /// Enum RELEASE_CHILD_TRANSFER_COMPLETE for value: RELEASE_CHILD_TRANSFER_COMPLETE
            /// </summary>
            public static readonly StatusEnum RELEASE_CHILD_TRANSFER_COMPLETE = new StatusEnum("RELEASE_CHILD_TRANSFER_COMPLETE");

            /// <summary>
            /// Enum NODE_UPGRADE_START for value: NODE_UPGRADE_START
            /// </summary>
            public static readonly StatusEnum NODE_UPGRADE_START = new StatusEnum("NODE_UPGRADE_START");

            /// <summary>
            /// Enum NODE_UPGRADE_COMPLETE for value: NODE_UPGRADE_COMPLETE
            /// </summary>
            public static readonly StatusEnum NODE_UPGRADE_COMPLETE = new StatusEnum("NODE_UPGRADE_COMPLETE");

            /// <summary>
            /// Enum NODE_UPGRADE_FAILED for value: NODE_UPGRADE_FAILED
            /// </summary>
            public static readonly StatusEnum NODE_UPGRADE_FAILED = new StatusEnum("NODE_UPGRADE_FAILED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CREATING", CREATING },
                { "CREATE_FAILED", CREATE_FAILED },
                { "CONFIGURATION", CONFIGURATION },
                { "STARTJOBING", STARTJOBING },
                { "WAITING_FOR_START", WAITING_FOR_START },
                { "START_JOB_FAILED", START_JOB_FAILED },
                { "PAUSING", PAUSING },
                { "FULL_TRANSFER_STARTED", FULL_TRANSFER_STARTED },
                { "FULL_TRANSFER_FAILED", FULL_TRANSFER_FAILED },
                { "FULL_TRANSFER_COMPLETE", FULL_TRANSFER_COMPLETE },
                { "INCRE_TRANSFER_STARTED", INCRE_TRANSFER_STARTED },
                { "INCRE_TRANSFER_FAILED", INCRE_TRANSFER_FAILED },
                { "RELEASE_RESOURCE_STARTED", RELEASE_RESOURCE_STARTED },
                { "RELEASE_RESOURCE_FAILED", RELEASE_RESOURCE_FAILED },
                { "RELEASE_RESOURCE_COMPLETE", RELEASE_RESOURCE_COMPLETE },
                { "REBUILD_NODE_STARTED", REBUILD_NODE_STARTED },
                { "REBUILD_NODE_FAILED", REBUILD_NODE_FAILED },
                { "CHANGE_JOB_STARTED", CHANGE_JOB_STARTED },
                { "CHANGE_JOB_FAILED", CHANGE_JOB_FAILED },
                { "DELETED", DELETED },
                { "CHILD_TRANSFER_STARTING", CHILD_TRANSFER_STARTING },
                { "CHILD_TRANSFER_STARTED", CHILD_TRANSFER_STARTED },
                { "CHILD_TRANSFER_COMPLETE", CHILD_TRANSFER_COMPLETE },
                { "CHILD_TRANSFER_FAILED", CHILD_TRANSFER_FAILED },
                { "RELEASE_CHILD_TRANSFER_STARTED", RELEASE_CHILD_TRANSFER_STARTED },
                { "RELEASE_CHILD_TRANSFER_COMPLETE", RELEASE_CHILD_TRANSFER_COMPLETE },
                { "NODE_UPGRADE_START", NODE_UPGRADE_START },
                { "NODE_UPGRADE_COMPLETE", NODE_UPGRADE_COMPLETE },
                { "NODE_UPGRADE_FAILED", NODE_UPGRADE_FAILED },
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
        /// 引擎类型
        /// </summary>
        /// <value>引擎类型</value>
        [JsonConverter(typeof(EnumClassConverter<EngineTypeEnum>))]
        public class EngineTypeEnum
        {
            /// <summary>
            /// Enum CLOUDDATAGUARD_CASSANDRA for value: cloudDataGuard-cassandra
            /// </summary>
            public static readonly EngineTypeEnum CLOUDDATAGUARD_CASSANDRA = new EngineTypeEnum("cloudDataGuard-cassandra");

            /// <summary>
            /// Enum CLOUDDATAGUARD_DDM for value: cloudDataGuard-ddm
            /// </summary>
            public static readonly EngineTypeEnum CLOUDDATAGUARD_DDM = new EngineTypeEnum("cloudDataGuard-ddm");

            /// <summary>
            /// Enum CLOUDDATAGUARD_TAURUS_TO_MYSQL for value: cloudDataGuard-taurus-to-mysql
            /// </summary>
            public static readonly EngineTypeEnum CLOUDDATAGUARD_TAURUS_TO_MYSQL = new EngineTypeEnum("cloudDataGuard-taurus-to-mysql");

            /// <summary>
            /// Enum CLOUDDATAGUARD_MYSQL for value: cloudDataGuard-mysql
            /// </summary>
            public static readonly EngineTypeEnum CLOUDDATAGUARD_MYSQL = new EngineTypeEnum("cloudDataGuard-mysql");

            /// <summary>
            /// Enum CLOUDDATAGUARD_MYSQL_TO_TAURUS for value: cloudDataGuard-mysql-to-taurus
            /// </summary>
            public static readonly EngineTypeEnum CLOUDDATAGUARD_MYSQL_TO_TAURUS = new EngineTypeEnum("cloudDataGuard-mysql-to-taurus");

            private static readonly Dictionary<string, EngineTypeEnum> StaticFields =
            new Dictionary<string, EngineTypeEnum>()
            {
                { "cloudDataGuard-cassandra", CLOUDDATAGUARD_CASSANDRA },
                { "cloudDataGuard-ddm", CLOUDDATAGUARD_DDM },
                { "cloudDataGuard-taurus-to-mysql", CLOUDDATAGUARD_TAURUS_TO_MYSQL },
                { "cloudDataGuard-mysql", CLOUDDATAGUARD_MYSQL },
                { "cloudDataGuard-mysql-to-taurus", CLOUDDATAGUARD_MYSQL_TO_TAURUS },
            };

            private string _value;

            public EngineTypeEnum()
            {

            }

            public EngineTypeEnum(string value)
            {
                _value = value;
            }

            public static EngineTypeEnum FromValue(string value)
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

                if (this.Equals(obj as EngineTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EngineTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EngineTypeEnum a, EngineTypeEnum b)
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

            public static bool operator !=(EngineTypeEnum a, EngineTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 网络类型
        /// </summary>
        /// <value>网络类型</value>
        [JsonConverter(typeof(EnumClassConverter<NetTypeEnum>))]
        public class NetTypeEnum
        {
            /// <summary>
            /// Enum VPN for value: vpn
            /// </summary>
            public static readonly NetTypeEnum VPN = new NetTypeEnum("vpn");

            /// <summary>
            /// Enum VPC for value: vpc
            /// </summary>
            public static readonly NetTypeEnum VPC = new NetTypeEnum("vpc");

            /// <summary>
            /// Enum EIP for value: eip
            /// </summary>
            public static readonly NetTypeEnum EIP = new NetTypeEnum("eip");

            private static readonly Dictionary<string, NetTypeEnum> StaticFields =
            new Dictionary<string, NetTypeEnum>()
            {
                { "vpn", VPN },
                { "vpc", VPC },
                { "eip", EIP },
            };

            private string _value;

            public NetTypeEnum()
            {

            }

            public NetTypeEnum(string value)
            {
                _value = value;
            }

            public static NetTypeEnum FromValue(string value)
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

                if (this.Equals(obj as NetTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NetTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NetTypeEnum a, NetTypeEnum b)
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

            public static bool operator !=(NetTypeEnum a, NetTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 迁移方向
        /// </summary>
        /// <value>迁移方向</value>
        [JsonConverter(typeof(EnumClassConverter<JobDirectionEnum>))]
        public class JobDirectionEnum
        {
            /// <summary>
            /// Enum UP for value: up
            /// </summary>
            public static readonly JobDirectionEnum UP = new JobDirectionEnum("up");

            /// <summary>
            /// Enum DOWN for value: down
            /// </summary>
            public static readonly JobDirectionEnum DOWN = new JobDirectionEnum("down");

            private static readonly Dictionary<string, JobDirectionEnum> StaticFields =
            new Dictionary<string, JobDirectionEnum>()
            {
                { "up", UP },
                { "down", DOWN },
            };

            private string _value;

            public JobDirectionEnum()
            {

            }

            public JobDirectionEnum(string value)
            {
                _value = value;
            }

            public static JobDirectionEnum FromValue(string value)
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

                if (this.Equals(obj as JobDirectionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(JobDirectionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(JobDirectionEnum a, JobDirectionEnum b)
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

            public static bool operator !=(JobDirectionEnum a, JobDirectionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 迁移场景。 - migration:实时迁移 - sync:实时同步 - cloudDataGuard:实时灾备
        /// </summary>
        /// <value>迁移场景。 - migration:实时迁移 - sync:实时同步 - cloudDataGuard:实时灾备</value>
        [JsonConverter(typeof(EnumClassConverter<DbUseTypeEnum>))]
        public class DbUseTypeEnum
        {
            /// <summary>
            /// Enum MIGRATION for value: migration
            /// </summary>
            public static readonly DbUseTypeEnum MIGRATION = new DbUseTypeEnum("migration");

            /// <summary>
            /// Enum SYNC for value: sync
            /// </summary>
            public static readonly DbUseTypeEnum SYNC = new DbUseTypeEnum("sync");

            /// <summary>
            /// Enum CLOUDDATAGUARD for value: cloudDataGuard
            /// </summary>
            public static readonly DbUseTypeEnum CLOUDDATAGUARD = new DbUseTypeEnum("cloudDataGuard");

            private static readonly Dictionary<string, DbUseTypeEnum> StaticFields =
            new Dictionary<string, DbUseTypeEnum>()
            {
                { "migration", MIGRATION },
                { "sync", SYNC },
                { "cloudDataGuard", CLOUDDATAGUARD },
            };

            private string _value;

            public DbUseTypeEnum()
            {

            }

            public DbUseTypeEnum(string value)
            {
                _value = value;
            }

            public static DbUseTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DbUseTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DbUseTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DbUseTypeEnum a, DbUseTypeEnum b)
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

            public static bool operator !=(DbUseTypeEnum a, DbUseTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 迁移模式。 - FULL_TRANS 全量 - FULL_INCR_TRANS 全量+增量 - INCR_TRANS 增量
        /// </summary>
        /// <value>迁移模式。 - FULL_TRANS 全量 - FULL_INCR_TRANS 全量+增量 - INCR_TRANS 增量</value>
        [JsonConverter(typeof(EnumClassConverter<TaskTypeEnum>))]
        public class TaskTypeEnum
        {
            /// <summary>
            /// Enum FULL_TRANS for value: FULL_TRANS
            /// </summary>
            public static readonly TaskTypeEnum FULL_TRANS = new TaskTypeEnum("FULL_TRANS");

            /// <summary>
            /// Enum FULL_INCR_TRANS for value: FULL_INCR_TRANS
            /// </summary>
            public static readonly TaskTypeEnum FULL_INCR_TRANS = new TaskTypeEnum("FULL_INCR_TRANS");

            /// <summary>
            /// Enum INCR_TRANS for value: INCR_TRANS
            /// </summary>
            public static readonly TaskTypeEnum INCR_TRANS = new TaskTypeEnum("INCR_TRANS");

            private static readonly Dictionary<string, TaskTypeEnum> StaticFields =
            new Dictionary<string, TaskTypeEnum>()
            {
                { "FULL_TRANS", FULL_TRANS },
                { "FULL_INCR_TRANS", FULL_INCR_TRANS },
                { "INCR_TRANS", INCR_TRANS },
            };

            private string _value;

            public TaskTypeEnum()
            {

            }

            public TaskTypeEnum(string value)
            {
                _value = value;
            }

            public static TaskTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TaskTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TaskTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TaskTypeEnum a, TaskTypeEnum b)
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

            public static bool operator !=(TaskTypeEnum a, TaskTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 任务状态。 - CREATING：创建中 - CREATE_FAILED：创建失败 - CONFIGURATION：配置中 - STARTJOBING：启动中 - WAITING_FOR_START：等待启动中 - START_JOB_FAILED：启动失败 - PAUSING：已暂停 - FULL_TRANSFER_STARTED：全量开始，灾备场景下为初始化 - FULL_TRANSFER_FAILED：全量失败，灾备场景下为初始化失败 - FULL_TRANSFER_COMPLETE：全量完成，灾备场景下为初始化完成 - INCRE_TRANSFER_STARTED：增量开始，灾备场景下为灾备中 - INCRE_TRANSFER_FAILED：增量失败，灾备场景下为灾备异常 - RELEASE_RESOURCE_STARTED：结束任务中 - RELEASE_RESOURCE_FAILED：结束任务失败 - RELEASE_RESOURCE_COMPLETE：已结束 - REBUILD_NODE_STARTED：故障恢复中 - REBUILD_NODE_FAILED：故障恢复失败 - CHANGE_JOB_STARTED：任务变更中 - CHANGE_JOB_FAILED：任务变更失败 - DELETED：已删除 - CHILD_TRANSFER_STARTING：再编辑子任务启动中 - CHILD_TRANSFER_STARTED：再编辑子任务迁移中 - CHILD_TRANSFER_COMPLETE：再编辑子任务迁移完成 - CHILD_TRANSFER_FAILED：再编辑子任务迁移失败 - RELEASE_CHILD_TRANSFER_STARTED：再编辑子任务结束中 - RELEASE_CHILD_TRANSFER_COMPLETE：再编辑子任务已结束 - NODE_UPGRADE_START：升级开始 - NODE_UPGRADE_COMPLETE：升级完成 - NODE_UPGRADE_FAILED：升级失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 任务描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 引擎类型
        /// </summary>
        [JsonProperty("engine_type", NullValueHandling = NullValueHandling.Ignore)]
        public EngineTypeEnum EngineType { get; set; }
        /// <summary>
        /// 网络类型
        /// </summary>
        [JsonProperty("net_type", NullValueHandling = NullValueHandling.Ignore)]
        public NetTypeEnum NetType { get; set; }
        /// <summary>
        /// 计费字段
        /// </summary>
        [JsonProperty("billing_tag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BillingTag { get; set; }

        /// <summary>
        /// 迁移方向
        /// </summary>
        [JsonProperty("job_direction", NullValueHandling = NullValueHandling.Ignore)]
        public JobDirectionEnum JobDirection { get; set; }
        /// <summary>
        /// 迁移场景。 - migration:实时迁移 - sync:实时同步 - cloudDataGuard:实时灾备
        /// </summary>
        [JsonProperty("db_use_type", NullValueHandling = NullValueHandling.Ignore)]
        public DbUseTypeEnum DbUseType { get; set; }
        /// <summary>
        /// 迁移模式。 - FULL_TRANS 全量 - FULL_INCR_TRANS 全量+增量 - INCR_TRANS 增量
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public TaskTypeEnum TaskType { get; set; }
        /// <summary>
        /// 子任务信息体
        /// </summary>
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChildrenJobInfo> Children { get; set; }

        /// <summary>
        /// 是否新框架
        /// </summary>
        [JsonProperty("node_newFramework", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NodeNewFramework { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_action", NullValueHandling = NullValueHandling.Ignore)]
        public JobActionResp JobAction { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  engineType: ").Append(EngineType).Append("\n");
            sb.Append("  netType: ").Append(NetType).Append("\n");
            sb.Append("  billingTag: ").Append(BillingTag).Append("\n");
            sb.Append("  jobDirection: ").Append(JobDirection).Append("\n");
            sb.Append("  dbUseType: ").Append(DbUseType).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  children: ").Append(Children).Append("\n");
            sb.Append("  nodeNewFramework: ").Append(NodeNewFramework).Append("\n");
            sb.Append("  jobAction: ").Append(JobAction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.EngineType != input.EngineType) return false;
            if (this.NetType != input.NetType) return false;
            if (this.BillingTag != input.BillingTag || (this.BillingTag != null && !this.BillingTag.Equals(input.BillingTag))) return false;
            if (this.JobDirection != input.JobDirection) return false;
            if (this.DbUseType != input.DbUseType) return false;
            if (this.TaskType != input.TaskType) return false;
            if (this.Children != input.Children || (this.Children != null && input.Children != null && !this.Children.SequenceEqual(input.Children))) return false;
            if (this.NodeNewFramework != input.NodeNewFramework || (this.NodeNewFramework != null && !this.NodeNewFramework.Equals(input.NodeNewFramework))) return false;
            if (this.JobAction != input.JobAction || (this.JobAction != null && !this.JobAction.Equals(input.JobAction))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                hashCode = hashCode * 59 + this.EngineType.GetHashCode();
                hashCode = hashCode * 59 + this.NetType.GetHashCode();
                if (this.BillingTag != null) hashCode = hashCode * 59 + this.BillingTag.GetHashCode();
                hashCode = hashCode * 59 + this.JobDirection.GetHashCode();
                hashCode = hashCode * 59 + this.DbUseType.GetHashCode();
                hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.Children != null) hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.NodeNewFramework != null) hashCode = hashCode * 59 + this.NodeNewFramework.GetHashCode();
                if (this.JobAction != null) hashCode = hashCode * 59 + this.JobAction.GetHashCode();
                return hashCode;
            }
        }
    }
}
