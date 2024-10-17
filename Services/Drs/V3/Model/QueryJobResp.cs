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
    /// 
    /// </summary>
    public class QueryJobResp 
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
        /// 迁移模式
        /// </summary>
        /// <value>迁移模式</value>
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
        /// 任务方向
        /// </summary>
        /// <value>任务方向</value>
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

            /// <summary>
            /// Enum NON_DBS for value: non-dbs
            /// </summary>
            public static readonly JobDirectionEnum NON_DBS = new JobDirectionEnum("non-dbs");

            private static readonly Dictionary<string, JobDirectionEnum> StaticFields =
            new Dictionary<string, JobDirectionEnum>()
            {
                { "up", UP },
                { "down", DOWN },
                { "non-dbs", NON_DBS },
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
        /// 迁移场景 - migration：实时迁移 - sync：实时同步 - cloudDataGuard：实时灾备
        /// </summary>
        /// <value>迁移场景 - migration：实时迁移 - sync：实时同步 - cloudDataGuard：实时灾备</value>
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
        /// 冲突忽略策略 - stop：冲突失败 - overwrite：冲突覆盖 - ignore：冲突忽略
        /// </summary>
        /// <value>冲突忽略策略 - stop：冲突失败 - overwrite：冲突覆盖 - ignore：冲突忽略</value>
        [JsonConverter(typeof(EnumClassConverter<ConflictPolicyEnum>))]
        public class ConflictPolicyEnum
        {
            /// <summary>
            /// Enum STOP for value: stop
            /// </summary>
            public static readonly ConflictPolicyEnum STOP = new ConflictPolicyEnum("stop");

            /// <summary>
            /// Enum OVERWRITE for value: overwrite
            /// </summary>
            public static readonly ConflictPolicyEnum OVERWRITE = new ConflictPolicyEnum("overwrite");

            /// <summary>
            /// Enum IGNORE for value: ignore
            /// </summary>
            public static readonly ConflictPolicyEnum IGNORE = new ConflictPolicyEnum("ignore");

            private static readonly Dictionary<string, ConflictPolicyEnum> StaticFields =
            new Dictionary<string, ConflictPolicyEnum>()
            {
                { "stop", STOP },
                { "overwrite", OVERWRITE },
                { "ignore", IGNORE },
            };

            private string _value;

            public ConflictPolicyEnum()
            {

            }

            public ConflictPolicyEnum(string value)
            {
                _value = value;
            }

            public static ConflictPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as ConflictPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConflictPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConflictPolicyEnum a, ConflictPolicyEnum b)
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

            public static bool operator !=(ConflictPolicyEnum a, ConflictPolicyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 迁移方案 - Replication-主从复制 - Tungsten-日志解析 - PGBaseBackup-PG备份
        /// </summary>
        /// <value>迁移方案 - Replication-主从复制 - Tungsten-日志解析 - PGBaseBackup-PG备份</value>
        [JsonConverter(typeof(EnumClassConverter<SchemaTypeEnum>))]
        public class SchemaTypeEnum
        {
            /// <summary>
            /// Enum REPLICATION for value: Replication
            /// </summary>
            public static readonly SchemaTypeEnum REPLICATION = new SchemaTypeEnum("Replication");

            /// <summary>
            /// Enum TUNGSTEN for value: Tungsten
            /// </summary>
            public static readonly SchemaTypeEnum TUNGSTEN = new SchemaTypeEnum("Tungsten");

            /// <summary>
            /// Enum PGBASEBACKUP for value: PGBaseBackup
            /// </summary>
            public static readonly SchemaTypeEnum PGBASEBACKUP = new SchemaTypeEnum("PGBaseBackup");

            private static readonly Dictionary<string, SchemaTypeEnum> StaticFields =
            new Dictionary<string, SchemaTypeEnum>()
            {
                { "Replication", REPLICATION },
                { "Tungsten", TUNGSTEN },
                { "PGBaseBackup", PGBASEBACKUP },
            };

            private string _value;

            public SchemaTypeEnum()
            {

            }

            public SchemaTypeEnum(string value)
            {
                _value = value;
            }

            public static SchemaTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SchemaTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SchemaTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SchemaTypeEnum a, SchemaTypeEnum b)
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

            public static bool operator !=(SchemaTypeEnum a, SchemaTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 初始任务方向。 取值： - up：入云，灾备场景时对应本云为备。 - down：出云，灾备场景时对应本云为主。 - non-dbs：自建。
        /// </summary>
        /// <value>初始任务方向。 取值： - up：入云，灾备场景时对应本云为备。 - down：出云，灾备场景时对应本云为主。 - non-dbs：自建。</value>
        [JsonConverter(typeof(EnumClassConverter<OriginalJobDirectionEnum>))]
        public class OriginalJobDirectionEnum
        {
            /// <summary>
            /// Enum UP for value: up
            /// </summary>
            public static readonly OriginalJobDirectionEnum UP = new OriginalJobDirectionEnum("up");

            /// <summary>
            /// Enum DOWN for value: down
            /// </summary>
            public static readonly OriginalJobDirectionEnum DOWN = new OriginalJobDirectionEnum("down");

            /// <summary>
            /// Enum NON_DBS for value: non-dbs
            /// </summary>
            public static readonly OriginalJobDirectionEnum NON_DBS = new OriginalJobDirectionEnum("non-dbs");

            private static readonly Dictionary<string, OriginalJobDirectionEnum> StaticFields =
            new Dictionary<string, OriginalJobDirectionEnum>()
            {
                { "up", UP },
                { "down", DOWN },
                { "non-dbs", NON_DBS },
            };

            private string _value;

            public OriginalJobDirectionEnum()
            {

            }

            public OriginalJobDirectionEnum(string value)
            {
                _value = value;
            }

            public static OriginalJobDirectionEnum FromValue(string value)
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

                if (this.Equals(obj as OriginalJobDirectionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OriginalJobDirectionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OriginalJobDirectionEnum a, OriginalJobDirectionEnum b)
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

            public static bool operator !=(OriginalJobDirectionEnum a, OriginalJobDirectionEnum b)
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
        /// 父任务id。
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

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
        /// 描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 创建时间，时间戳格式。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 迁移模式
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public TaskTypeEnum TaskType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public Endpoint SourceEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dmq_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public Endpoint DmqEndpoint { get; set; }

        /// <summary>
        /// 物理源库信息。
        /// </summary>
        [JsonProperty("source_sharding", NullValueHandling = NullValueHandling.Ignore)]
        public List<Endpoint> SourceSharding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public Endpoint TargetEndpoint { get; set; }

        /// <summary>
        /// 网络类型
        /// </summary>
        [JsonProperty("net_type", NullValueHandling = NullValueHandling.Ignore)]
        public NetTypeEnum NetType { get; set; }
        /// <summary>
        /// 失败原因。
        /// </summary>
        [JsonProperty("failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inst_info", NullValueHandling = NullValueHandling.Ignore)]
        public InstInfo InstInfo { get; set; }

        /// <summary>
        /// 实际启动时间，时间戳格式。
        /// </summary>
        [JsonProperty("actual_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualStartTime { get; set; }

        /// <summary>
        /// 全量完成时间，时间戳格式。
        /// </summary>
        [JsonProperty("full_transfer_complete_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FullTransferCompleteTime { get; set; }

        /// <summary>
        /// 更新时间，时间戳格式
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 任务方向
        /// </summary>
        [JsonProperty("job_direction", NullValueHandling = NullValueHandling.Ignore)]
        public JobDirectionEnum JobDirection { get; set; }
        /// <summary>
        /// 迁移场景 - migration：实时迁移 - sync：实时同步 - cloudDataGuard：实时灾备
        /// </summary>
        [JsonProperty("db_use_type", NullValueHandling = NullValueHandling.Ignore)]
        public DbUseTypeEnum DbUseType { get; set; }
        /// <summary>
        /// 是否需要重启
        /// </summary>
        [JsonProperty("need_restart", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedRestart { get; set; }

        /// <summary>
        /// 指定目标实例是否限制为只读
        /// </summary>
        [JsonProperty("is_target_readonly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTargetReadonly { get; set; }

        /// <summary>
        /// 冲突忽略策略 - stop：冲突失败 - overwrite：冲突覆盖 - ignore：冲突忽略
        /// </summary>
        [JsonProperty("conflict_policy", NullValueHandling = NullValueHandling.Ignore)]
        public ConflictPolicyEnum ConflictPolicy { get; set; }
        /// <summary>
        /// 过滤DDL策略 - drop_database：过滤drop_database - drop_databasefilter_all：过滤所有ddl - \&quot;\&quot;：不过滤
        /// </summary>
        [JsonProperty("filter_ddl_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string FilterDdlPolicy { get; set; }

        /// <summary>
        /// 迁移速度限制。
        /// </summary>
        [JsonProperty("speed_limit", NullValueHandling = NullValueHandling.Ignore)]
        public List<SpeedLimitInfo> SpeedLimit { get; set; }

        /// <summary>
        /// 迁移方案 - Replication-主从复制 - Tungsten-日志解析 - PGBaseBackup-PG备份
        /// </summary>
        [JsonProperty("schema_type", NullValueHandling = NullValueHandling.Ignore)]
        public SchemaTypeEnum SchemaType { get; set; }
        /// <summary>
        /// 节点个数。MongoDB数据库时对应源端分片个数，源库为集群时必填，[1-32]，MySQL双主灾备时会默认设置为2。
        /// </summary>
        [JsonProperty("node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNum { get; set; }

        /// <summary>
        /// 对象选择开关
        /// </summary>
        [JsonProperty("object_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ObjectSwitch { get; set; }

        /// <summary>
        /// 主任务Id。
        /// </summary>
        [JsonProperty("master_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterJobId { get; set; }

        /// <summary>
        /// 全量快照模式。
        /// </summary>
        [JsonProperty("full_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string FullMode { get; set; }

        /// <summary>
        /// 是否迁移结构。
        /// </summary>
        [JsonProperty("struct_trans", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StructTrans { get; set; }

        /// <summary>
        /// 否迁移索引。
        /// </summary>
        [JsonProperty("index_trans", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IndexTrans { get; set; }

        /// <summary>
        /// 是否使用目标库的用户替换掉definer。
        /// </summary>
        [JsonProperty("replace_definer", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReplaceDefiner { get; set; }

        /// <summary>
        /// 是否迁移用户。
        /// </summary>
        [JsonProperty("migrate_user", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MigrateUser { get; set; }

        /// <summary>
        /// 是否库级同步。
        /// </summary>
        [JsonProperty("sync_database", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncDatabase { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_root_db", NullValueHandling = NullValueHandling.Ignore)]
        public DefaultRootDb TargetRootDb { get; set; }

        /// <summary>
        /// node所在AZ
        /// </summary>
        [JsonProperty("az_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AzCode { get; set; }

        /// <summary>
        /// node所在VPC
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// node所在子网
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// node所在安全组
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 是否多主灾备任务,双主灾备时有值为true
        /// </summary>
        [JsonProperty("multi_write", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MultiWrite { get; set; }

        /// <summary>
        /// 是否支持IPV6
        /// </summary>
        [JsonProperty("support_ip_v6", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportIpV6 { get; set; }

        /// <summary>
        /// 继承的任务ID，Oracle_Mrskafka链路时使用。
        /// </summary>
        [JsonProperty("inherit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InheritId { get; set; }

        /// <summary>
        /// 断点的GTID集合
        /// </summary>
        [JsonProperty("gtid", NullValueHandling = NullValueHandling.Ignore)]
        public string Gtid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("alarm_notify", NullValueHandling = NullValueHandling.Ignore)]
        public QuerySmnInfoResp AlarmNotify { get; set; }

        /// <summary>
        /// 增量任务启动位点
        /// </summary>
        [JsonProperty("incre_start_position", NullValueHandling = NullValueHandling.Ignore)]
        public string IncreStartPosition { get; set; }

        /// <summary>
        /// 是否是主备任务。
        /// </summary>
        [JsonProperty("is_multi_az", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMultiAz { get; set; }

        /// <summary>
        /// node所在节点AZ名称。
        /// </summary>
        [JsonProperty("az_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AzName { get; set; }

        /// <summary>
        /// 主备任务主AZ。
        /// </summary>
        [JsonProperty("master_az", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterAz { get; set; }

        /// <summary>
        /// 主备任务备AZ。
        /// </summary>
        [JsonProperty("slave_az", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveAz { get; set; }

        /// <summary>
        /// 任务主备角色。
        /// </summary>
        [JsonProperty("node_role", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("period_order", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodOrderResp PeriodOrder { get; set; }

        /// <summary>
        /// 已同步对象信息。
        /// </summary>
        [JsonProperty("object_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatabaseObjectInfo> ObjectInfos { get; set; }

        /// <summary>
        /// 初始任务方向。 取值： - up：入云，灾备场景时对应本云为备。 - down：出云，灾备场景时对应本云为主。 - non-dbs：自建。
        /// </summary>
        [JsonProperty("original_job_direction", NullValueHandling = NullValueHandling.Ignore)]
        public OriginalJobDirectionEnum OriginalJobDirection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data_transformation", NullValueHandling = NullValueHandling.Ignore)]
        public GetDataTransformationResp DataTransformation { get; set; }

        /// <summary>
        /// DRS任务标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 指定公网Ip的信息。
        /// </summary>
        [JsonProperty("public_ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicIpConfig> PublicIpList { get; set; }

        /// <summary>
        /// 是否成功绑定公网IP。
        /// </summary>
        [JsonProperty("bind_public_ip_state", NullValueHandling = NullValueHandling.Ignore)]
        public string BindPublicIpState { get; set; }

        /// <summary>
        /// 多任务时，存在子任务绑定失败时，返回子任务的信息。
        /// </summary>
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<FailedToBindEipChildInfo> Children { get; set; }

        /// <summary>
        /// 是否开启云数据库RDS for MySQL/MariaDB的binlog快速清理。
        /// </summary>
        [JsonProperty("is_open_fast_clean", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOpenFastClean { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryJobResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  sourceEndpoint: ").Append(SourceEndpoint).Append("\n");
            sb.Append("  dmqEndpoint: ").Append(DmqEndpoint).Append("\n");
            sb.Append("  sourceSharding: ").Append(SourceSharding).Append("\n");
            sb.Append("  targetEndpoint: ").Append(TargetEndpoint).Append("\n");
            sb.Append("  netType: ").Append(NetType).Append("\n");
            sb.Append("  failedReason: ").Append(FailedReason).Append("\n");
            sb.Append("  instInfo: ").Append(InstInfo).Append("\n");
            sb.Append("  actualStartTime: ").Append(ActualStartTime).Append("\n");
            sb.Append("  fullTransferCompleteTime: ").Append(FullTransferCompleteTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  jobDirection: ").Append(JobDirection).Append("\n");
            sb.Append("  dbUseType: ").Append(DbUseType).Append("\n");
            sb.Append("  needRestart: ").Append(NeedRestart).Append("\n");
            sb.Append("  isTargetReadonly: ").Append(IsTargetReadonly).Append("\n");
            sb.Append("  conflictPolicy: ").Append(ConflictPolicy).Append("\n");
            sb.Append("  filterDdlPolicy: ").Append(FilterDdlPolicy).Append("\n");
            sb.Append("  speedLimit: ").Append(SpeedLimit).Append("\n");
            sb.Append("  schemaType: ").Append(SchemaType).Append("\n");
            sb.Append("  nodeNum: ").Append(NodeNum).Append("\n");
            sb.Append("  objectSwitch: ").Append(ObjectSwitch).Append("\n");
            sb.Append("  masterJobId: ").Append(MasterJobId).Append("\n");
            sb.Append("  fullMode: ").Append(FullMode).Append("\n");
            sb.Append("  structTrans: ").Append(StructTrans).Append("\n");
            sb.Append("  indexTrans: ").Append(IndexTrans).Append("\n");
            sb.Append("  replaceDefiner: ").Append(ReplaceDefiner).Append("\n");
            sb.Append("  migrateUser: ").Append(MigrateUser).Append("\n");
            sb.Append("  syncDatabase: ").Append(SyncDatabase).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  targetRootDb: ").Append(TargetRootDb).Append("\n");
            sb.Append("  azCode: ").Append(AzCode).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  multiWrite: ").Append(MultiWrite).Append("\n");
            sb.Append("  supportIpV6: ").Append(SupportIpV6).Append("\n");
            sb.Append("  inheritId: ").Append(InheritId).Append("\n");
            sb.Append("  gtid: ").Append(Gtid).Append("\n");
            sb.Append("  alarmNotify: ").Append(AlarmNotify).Append("\n");
            sb.Append("  increStartPosition: ").Append(IncreStartPosition).Append("\n");
            sb.Append("  isMultiAz: ").Append(IsMultiAz).Append("\n");
            sb.Append("  azName: ").Append(AzName).Append("\n");
            sb.Append("  masterAz: ").Append(MasterAz).Append("\n");
            sb.Append("  slaveAz: ").Append(SlaveAz).Append("\n");
            sb.Append("  nodeRole: ").Append(NodeRole).Append("\n");
            sb.Append("  periodOrder: ").Append(PeriodOrder).Append("\n");
            sb.Append("  objectInfos: ").Append(ObjectInfos).Append("\n");
            sb.Append("  originalJobDirection: ").Append(OriginalJobDirection).Append("\n");
            sb.Append("  dataTransformation: ").Append(DataTransformation).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  publicIpList: ").Append(PublicIpList).Append("\n");
            sb.Append("  bindPublicIpState: ").Append(BindPublicIpState).Append("\n");
            sb.Append("  children: ").Append(Children).Append("\n");
            sb.Append("  isOpenFastClean: ").Append(IsOpenFastClean).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryJobResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryJobResp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.TaskType != input.TaskType) return false;
            if (this.SourceEndpoint != input.SourceEndpoint || (this.SourceEndpoint != null && !this.SourceEndpoint.Equals(input.SourceEndpoint))) return false;
            if (this.DmqEndpoint != input.DmqEndpoint || (this.DmqEndpoint != null && !this.DmqEndpoint.Equals(input.DmqEndpoint))) return false;
            if (this.SourceSharding != input.SourceSharding || (this.SourceSharding != null && input.SourceSharding != null && !this.SourceSharding.SequenceEqual(input.SourceSharding))) return false;
            if (this.TargetEndpoint != input.TargetEndpoint || (this.TargetEndpoint != null && !this.TargetEndpoint.Equals(input.TargetEndpoint))) return false;
            if (this.NetType != input.NetType) return false;
            if (this.FailedReason != input.FailedReason || (this.FailedReason != null && !this.FailedReason.Equals(input.FailedReason))) return false;
            if (this.InstInfo != input.InstInfo || (this.InstInfo != null && !this.InstInfo.Equals(input.InstInfo))) return false;
            if (this.ActualStartTime != input.ActualStartTime || (this.ActualStartTime != null && !this.ActualStartTime.Equals(input.ActualStartTime))) return false;
            if (this.FullTransferCompleteTime != input.FullTransferCompleteTime || (this.FullTransferCompleteTime != null && !this.FullTransferCompleteTime.Equals(input.FullTransferCompleteTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.JobDirection != input.JobDirection) return false;
            if (this.DbUseType != input.DbUseType) return false;
            if (this.NeedRestart != input.NeedRestart || (this.NeedRestart != null && !this.NeedRestart.Equals(input.NeedRestart))) return false;
            if (this.IsTargetReadonly != input.IsTargetReadonly || (this.IsTargetReadonly != null && !this.IsTargetReadonly.Equals(input.IsTargetReadonly))) return false;
            if (this.ConflictPolicy != input.ConflictPolicy) return false;
            if (this.FilterDdlPolicy != input.FilterDdlPolicy || (this.FilterDdlPolicy != null && !this.FilterDdlPolicy.Equals(input.FilterDdlPolicy))) return false;
            if (this.SpeedLimit != input.SpeedLimit || (this.SpeedLimit != null && input.SpeedLimit != null && !this.SpeedLimit.SequenceEqual(input.SpeedLimit))) return false;
            if (this.SchemaType != input.SchemaType) return false;
            if (this.NodeNum != input.NodeNum || (this.NodeNum != null && !this.NodeNum.Equals(input.NodeNum))) return false;
            if (this.ObjectSwitch != input.ObjectSwitch || (this.ObjectSwitch != null && !this.ObjectSwitch.Equals(input.ObjectSwitch))) return false;
            if (this.MasterJobId != input.MasterJobId || (this.MasterJobId != null && !this.MasterJobId.Equals(input.MasterJobId))) return false;
            if (this.FullMode != input.FullMode || (this.FullMode != null && !this.FullMode.Equals(input.FullMode))) return false;
            if (this.StructTrans != input.StructTrans || (this.StructTrans != null && !this.StructTrans.Equals(input.StructTrans))) return false;
            if (this.IndexTrans != input.IndexTrans || (this.IndexTrans != null && !this.IndexTrans.Equals(input.IndexTrans))) return false;
            if (this.ReplaceDefiner != input.ReplaceDefiner || (this.ReplaceDefiner != null && !this.ReplaceDefiner.Equals(input.ReplaceDefiner))) return false;
            if (this.MigrateUser != input.MigrateUser || (this.MigrateUser != null && !this.MigrateUser.Equals(input.MigrateUser))) return false;
            if (this.SyncDatabase != input.SyncDatabase || (this.SyncDatabase != null && !this.SyncDatabase.Equals(input.SyncDatabase))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;
            if (this.TargetRootDb != input.TargetRootDb || (this.TargetRootDb != null && !this.TargetRootDb.Equals(input.TargetRootDb))) return false;
            if (this.AzCode != input.AzCode || (this.AzCode != null && !this.AzCode.Equals(input.AzCode))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.SecurityGroupId != input.SecurityGroupId || (this.SecurityGroupId != null && !this.SecurityGroupId.Equals(input.SecurityGroupId))) return false;
            if (this.MultiWrite != input.MultiWrite || (this.MultiWrite != null && !this.MultiWrite.Equals(input.MultiWrite))) return false;
            if (this.SupportIpV6 != input.SupportIpV6 || (this.SupportIpV6 != null && !this.SupportIpV6.Equals(input.SupportIpV6))) return false;
            if (this.InheritId != input.InheritId || (this.InheritId != null && !this.InheritId.Equals(input.InheritId))) return false;
            if (this.Gtid != input.Gtid || (this.Gtid != null && !this.Gtid.Equals(input.Gtid))) return false;
            if (this.AlarmNotify != input.AlarmNotify || (this.AlarmNotify != null && !this.AlarmNotify.Equals(input.AlarmNotify))) return false;
            if (this.IncreStartPosition != input.IncreStartPosition || (this.IncreStartPosition != null && !this.IncreStartPosition.Equals(input.IncreStartPosition))) return false;
            if (this.IsMultiAz != input.IsMultiAz || (this.IsMultiAz != null && !this.IsMultiAz.Equals(input.IsMultiAz))) return false;
            if (this.AzName != input.AzName || (this.AzName != null && !this.AzName.Equals(input.AzName))) return false;
            if (this.MasterAz != input.MasterAz || (this.MasterAz != null && !this.MasterAz.Equals(input.MasterAz))) return false;
            if (this.SlaveAz != input.SlaveAz || (this.SlaveAz != null && !this.SlaveAz.Equals(input.SlaveAz))) return false;
            if (this.NodeRole != input.NodeRole || (this.NodeRole != null && !this.NodeRole.Equals(input.NodeRole))) return false;
            if (this.PeriodOrder != input.PeriodOrder || (this.PeriodOrder != null && !this.PeriodOrder.Equals(input.PeriodOrder))) return false;
            if (this.ObjectInfos != input.ObjectInfos || (this.ObjectInfos != null && input.ObjectInfos != null && !this.ObjectInfos.SequenceEqual(input.ObjectInfos))) return false;
            if (this.OriginalJobDirection != input.OriginalJobDirection) return false;
            if (this.DataTransformation != input.DataTransformation || (this.DataTransformation != null && !this.DataTransformation.Equals(input.DataTransformation))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.PublicIpList != input.PublicIpList || (this.PublicIpList != null && input.PublicIpList != null && !this.PublicIpList.SequenceEqual(input.PublicIpList))) return false;
            if (this.BindPublicIpState != input.BindPublicIpState || (this.BindPublicIpState != null && !this.BindPublicIpState.Equals(input.BindPublicIpState))) return false;
            if (this.Children != input.Children || (this.Children != null && input.Children != null && !this.Children.SequenceEqual(input.Children))) return false;
            if (this.IsOpenFastClean != input.IsOpenFastClean || (this.IsOpenFastClean != null && !this.IsOpenFastClean.Equals(input.IsOpenFastClean))) return false;

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
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.SourceEndpoint != null) hashCode = hashCode * 59 + this.SourceEndpoint.GetHashCode();
                if (this.DmqEndpoint != null) hashCode = hashCode * 59 + this.DmqEndpoint.GetHashCode();
                if (this.SourceSharding != null) hashCode = hashCode * 59 + this.SourceSharding.GetHashCode();
                if (this.TargetEndpoint != null) hashCode = hashCode * 59 + this.TargetEndpoint.GetHashCode();
                hashCode = hashCode * 59 + this.NetType.GetHashCode();
                if (this.FailedReason != null) hashCode = hashCode * 59 + this.FailedReason.GetHashCode();
                if (this.InstInfo != null) hashCode = hashCode * 59 + this.InstInfo.GetHashCode();
                if (this.ActualStartTime != null) hashCode = hashCode * 59 + this.ActualStartTime.GetHashCode();
                if (this.FullTransferCompleteTime != null) hashCode = hashCode * 59 + this.FullTransferCompleteTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                hashCode = hashCode * 59 + this.JobDirection.GetHashCode();
                hashCode = hashCode * 59 + this.DbUseType.GetHashCode();
                if (this.NeedRestart != null) hashCode = hashCode * 59 + this.NeedRestart.GetHashCode();
                if (this.IsTargetReadonly != null) hashCode = hashCode * 59 + this.IsTargetReadonly.GetHashCode();
                hashCode = hashCode * 59 + this.ConflictPolicy.GetHashCode();
                if (this.FilterDdlPolicy != null) hashCode = hashCode * 59 + this.FilterDdlPolicy.GetHashCode();
                if (this.SpeedLimit != null) hashCode = hashCode * 59 + this.SpeedLimit.GetHashCode();
                hashCode = hashCode * 59 + this.SchemaType.GetHashCode();
                if (this.NodeNum != null) hashCode = hashCode * 59 + this.NodeNum.GetHashCode();
                if (this.ObjectSwitch != null) hashCode = hashCode * 59 + this.ObjectSwitch.GetHashCode();
                if (this.MasterJobId != null) hashCode = hashCode * 59 + this.MasterJobId.GetHashCode();
                if (this.FullMode != null) hashCode = hashCode * 59 + this.FullMode.GetHashCode();
                if (this.StructTrans != null) hashCode = hashCode * 59 + this.StructTrans.GetHashCode();
                if (this.IndexTrans != null) hashCode = hashCode * 59 + this.IndexTrans.GetHashCode();
                if (this.ReplaceDefiner != null) hashCode = hashCode * 59 + this.ReplaceDefiner.GetHashCode();
                if (this.MigrateUser != null) hashCode = hashCode * 59 + this.MigrateUser.GetHashCode();
                if (this.SyncDatabase != null) hashCode = hashCode * 59 + this.SyncDatabase.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.TargetRootDb != null) hashCode = hashCode * 59 + this.TargetRootDb.GetHashCode();
                if (this.AzCode != null) hashCode = hashCode * 59 + this.AzCode.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SecurityGroupId != null) hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.MultiWrite != null) hashCode = hashCode * 59 + this.MultiWrite.GetHashCode();
                if (this.SupportIpV6 != null) hashCode = hashCode * 59 + this.SupportIpV6.GetHashCode();
                if (this.InheritId != null) hashCode = hashCode * 59 + this.InheritId.GetHashCode();
                if (this.Gtid != null) hashCode = hashCode * 59 + this.Gtid.GetHashCode();
                if (this.AlarmNotify != null) hashCode = hashCode * 59 + this.AlarmNotify.GetHashCode();
                if (this.IncreStartPosition != null) hashCode = hashCode * 59 + this.IncreStartPosition.GetHashCode();
                if (this.IsMultiAz != null) hashCode = hashCode * 59 + this.IsMultiAz.GetHashCode();
                if (this.AzName != null) hashCode = hashCode * 59 + this.AzName.GetHashCode();
                if (this.MasterAz != null) hashCode = hashCode * 59 + this.MasterAz.GetHashCode();
                if (this.SlaveAz != null) hashCode = hashCode * 59 + this.SlaveAz.GetHashCode();
                if (this.NodeRole != null) hashCode = hashCode * 59 + this.NodeRole.GetHashCode();
                if (this.PeriodOrder != null) hashCode = hashCode * 59 + this.PeriodOrder.GetHashCode();
                if (this.ObjectInfos != null) hashCode = hashCode * 59 + this.ObjectInfos.GetHashCode();
                hashCode = hashCode * 59 + this.OriginalJobDirection.GetHashCode();
                if (this.DataTransformation != null) hashCode = hashCode * 59 + this.DataTransformation.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.PublicIpList != null) hashCode = hashCode * 59 + this.PublicIpList.GetHashCode();
                if (this.BindPublicIpState != null) hashCode = hashCode * 59 + this.BindPublicIpState.GetHashCode();
                if (this.Children != null) hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.IsOpenFastClean != null) hashCode = hashCode * 59 + this.IsOpenFastClean.GetHashCode();
                return hashCode;
            }
        }
    }
}
