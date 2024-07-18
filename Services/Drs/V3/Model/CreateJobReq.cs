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
    /// 创建任务请求体
    /// </summary>
    public class CreateJobReq 
    {
        /// <summary>
        /// 迁移场景，migration-实时迁移,sync-实时同步,cloudDataGuard-实时灾备
        /// </summary>
        /// <value>迁移场景，migration-实时迁移,sync-实时同步,cloudDataGuard-实时灾备</value>
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
        /// 引擎类型 - mysql：MySQL到MySQL迁移，MySQL到MySQL同步 - mongodb：MongoDB到DDS迁移 - cloudDataGuard-mysql：MySQL到MySQL灾备 - gaussdbv5：GaussDB同步 - mysql-to-kafka：MySQL到Kafka同步 - taurus-to-kafka：GaussDB(for MySQL)到Kafka同步 - gaussdbv5ha-to-kafka：GaussDB主备版到Kafka同步 - postgresql：PostgreSQL到PostgreSQL同步
        /// </summary>
        /// <value>引擎类型 - mysql：MySQL到MySQL迁移，MySQL到MySQL同步 - mongodb：MongoDB到DDS迁移 - cloudDataGuard-mysql：MySQL到MySQL灾备 - gaussdbv5：GaussDB同步 - mysql-to-kafka：MySQL到Kafka同步 - taurus-to-kafka：GaussDB(for MySQL)到Kafka同步 - gaussdbv5ha-to-kafka：GaussDB主备版到Kafka同步 - postgresql：PostgreSQL到PostgreSQL同步</value>
        [JsonConverter(typeof(EnumClassConverter<EngineTypeEnum>))]
        public class EngineTypeEnum
        {
            /// <summary>
            /// Enum MYSQL for value: mysql
            /// </summary>
            public static readonly EngineTypeEnum MYSQL = new EngineTypeEnum("mysql");

            /// <summary>
            /// Enum MONGODB for value: mongodb
            /// </summary>
            public static readonly EngineTypeEnum MONGODB = new EngineTypeEnum("mongodb");

            /// <summary>
            /// Enum CLOUDDATAGUARD_MYSQL for value: cloudDataGuard-mysql
            /// </summary>
            public static readonly EngineTypeEnum CLOUDDATAGUARD_MYSQL = new EngineTypeEnum("cloudDataGuard-mysql");

            /// <summary>
            /// Enum GAUSSDBV5 for value: gaussdbv5
            /// </summary>
            public static readonly EngineTypeEnum GAUSSDBV5 = new EngineTypeEnum("gaussdbv5");

            /// <summary>
            /// Enum POSTGRESQL for value: postgresql
            /// </summary>
            public static readonly EngineTypeEnum POSTGRESQL = new EngineTypeEnum("postgresql");

            /// <summary>
            /// Enum MYSQL_TO_KAFKA for value: mysql-to-kafka
            /// </summary>
            public static readonly EngineTypeEnum MYSQL_TO_KAFKA = new EngineTypeEnum("mysql-to-kafka");

            /// <summary>
            /// Enum TAURUS_TO_KAFKA for value: taurus-to-kafka
            /// </summary>
            public static readonly EngineTypeEnum TAURUS_TO_KAFKA = new EngineTypeEnum("taurus-to-kafka");

            /// <summary>
            /// Enum GAUSSDBV5HA_TO_KAFKA for value: gaussdbv5ha-to-kafka
            /// </summary>
            public static readonly EngineTypeEnum GAUSSDBV5HA_TO_KAFKA = new EngineTypeEnum("gaussdbv5ha-to-kafka");

            private static readonly Dictionary<string, EngineTypeEnum> StaticFields =
            new Dictionary<string, EngineTypeEnum>()
            {
                { "mysql", MYSQL },
                { "mongodb", MONGODB },
                { "cloudDataGuard-mysql", CLOUDDATAGUARD_MYSQL },
                { "gaussdbv5", GAUSSDBV5 },
                { "postgresql", POSTGRESQL },
                { "mysql-to-kafka", MYSQL_TO_KAFKA },
                { "taurus-to-kafka", TAURUS_TO_KAFKA },
                { "gaussdbv5ha-to-kafka", GAUSSDBV5HA_TO_KAFKA },
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
        /// 迁移方向，up ：入云 ，灾备场景时对应本云为备，down：出云，灾备场景时对应本云为主，non-dbs：自建
        /// </summary>
        /// <value>迁移方向，up ：入云 ，灾备场景时对应本云为备，down：出云，灾备场景时对应本云为主，non-dbs：自建</value>
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
        /// 规格类型。取值： - micro：极小规格。 - small：小规格。 - medium：中规格。 - high：大规格。 - xlarge：超大规格。 - 2xlarge：极大规格。 具体某种场景支持的取值可以通过[查询可用的Node规格接口](https://support.huaweicloud.com/api-drs/drs_03_0239.html)获取。
        /// </summary>
        /// <value>规格类型。取值： - micro：极小规格。 - small：小规格。 - medium：中规格。 - high：大规格。 - xlarge：超大规格。 - 2xlarge：极大规格。 具体某种场景支持的取值可以通过[查询可用的Node规格接口](https://support.huaweicloud.com/api-drs/drs_03_0239.html)获取。</value>
        [JsonConverter(typeof(EnumClassConverter<NodeTypeEnum>))]
        public class NodeTypeEnum
        {
            /// <summary>
            /// Enum MICRO for value: micro
            /// </summary>
            public static readonly NodeTypeEnum MICRO = new NodeTypeEnum("micro");

            /// <summary>
            /// Enum SMALL for value: small
            /// </summary>
            public static readonly NodeTypeEnum SMALL = new NodeTypeEnum("small");

            /// <summary>
            /// Enum MEDIUM for value: medium
            /// </summary>
            public static readonly NodeTypeEnum MEDIUM = new NodeTypeEnum("medium");

            /// <summary>
            /// Enum HIGH for value: high
            /// </summary>
            public static readonly NodeTypeEnum HIGH = new NodeTypeEnum("high");

            /// <summary>
            /// Enum XLARGE for value: xlarge
            /// </summary>
            public static readonly NodeTypeEnum XLARGE = new NodeTypeEnum("xlarge");

            /// <summary>
            /// Enum _2XLARGE for value: 2xlarge
            /// </summary>
            public static readonly NodeTypeEnum _2XLARGE = new NodeTypeEnum("2xlarge");

            private static readonly Dictionary<string, NodeTypeEnum> StaticFields =
            new Dictionary<string, NodeTypeEnum>()
            {
                { "micro", MICRO },
                { "small", SMALL },
                { "medium", MEDIUM },
                { "high", HIGH },
                { "xlarge", XLARGE },
                { "2xlarge", _2XLARGE },
            };

            private string _value;

            public NodeTypeEnum()
            {

            }

            public NodeTypeEnum(string value)
            {
                _value = value;
            }

            public static NodeTypeEnum FromValue(string value)
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

                if (this.Equals(obj as NodeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NodeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NodeTypeEnum a, NodeTypeEnum b)
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

            public static bool operator !=(NodeTypeEnum a, NodeTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 迁移模式，FULL_TRANS 全量,FULL_INCR_TRANS 全量+增量,INCR_TRANS 增量，灾备场景单主灾备仅支持全量加增量（FULL_INCR_TRANS）
        /// </summary>
        /// <value>迁移模式，FULL_TRANS 全量,FULL_INCR_TRANS 全量+增量,INCR_TRANS 增量，灾备场景单主灾备仅支持全量加增量（FULL_INCR_TRANS）</value>
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
        /// 计费模式，不填默认为按需计费。 取值范围： - period：包年包月。 - on_demand：按需计费。
        /// </summary>
        /// <value>计费模式，不填默认为按需计费。 取值范围： - period：包年包月。 - on_demand：按需计费。</value>
        [JsonConverter(typeof(EnumClassConverter<ChargingModeEnum>))]
        public class ChargingModeEnum
        {
            /// <summary>
            /// Enum PERIOD for value: period
            /// </summary>
            public static readonly ChargingModeEnum PERIOD = new ChargingModeEnum("period");

            /// <summary>
            /// Enum ON_DEMAND for value: on_demand
            /// </summary>
            public static readonly ChargingModeEnum ON_DEMAND = new ChargingModeEnum("on_demand");

            private static readonly Dictionary<string, ChargingModeEnum> StaticFields =
            new Dictionary<string, ChargingModeEnum>()
            {
                { "period", PERIOD },
                { "on_demand", ON_DEMAND },
            };

            private string _value;

            public ChargingModeEnum()
            {

            }

            public ChargingModeEnum(string value)
            {
                _value = value;
            }

            public static ChargingModeEnum FromValue(string value)
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

                if (this.Equals(obj as ChargingModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargingModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChargingModeEnum a, ChargingModeEnum b)
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

            public static bool operator !=(ChargingModeEnum a, ChargingModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否绑定eip，网络类型为eip时必填且为true
        /// </summary>
        [JsonProperty("bind_eip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BindEip { get; set; }

        /// <summary>
        /// 迁移场景，migration-实时迁移,sync-实时同步,cloudDataGuard-实时灾备
        /// </summary>
        [JsonProperty("db_use_type", NullValueHandling = NullValueHandling.Ignore)]
        public DbUseTypeEnum DbUseType { get; set; }
        /// <summary>
        /// 任务名称，约束：任务名称在4位到50位之间，不区分大小写，可以包含字母、数字、中划线或下划线，不能包括其他特殊字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 任务描述。  **约束**：任务描述不能超过256位，且不能包含!&lt;&gt;&amp;&#39;\&quot;\\特殊字符。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 引擎类型 - mysql：MySQL到MySQL迁移，MySQL到MySQL同步 - mongodb：MongoDB到DDS迁移 - cloudDataGuard-mysql：MySQL到MySQL灾备 - gaussdbv5：GaussDB同步 - mysql-to-kafka：MySQL到Kafka同步 - taurus-to-kafka：GaussDB(for MySQL)到Kafka同步 - gaussdbv5ha-to-kafka：GaussDB主备版到Kafka同步 - postgresql：PostgreSQL到PostgreSQL同步
        /// </summary>
        [JsonProperty("engine_type", NullValueHandling = NullValueHandling.Ignore)]
        public EngineTypeEnum EngineType { get; set; }
        /// <summary>
        /// 指定目标实例是否限制为只读，MySQL迁移和灾备，且job_direction为up时设置有效。（灾备场景下，单主灾备且本云为备为必填且为true，不填默认设置为true）。
        /// </summary>
        [JsonProperty("is_target_readonly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTargetReadonly { get; set; }

        /// <summary>
        /// 迁移方向，up ：入云 ，灾备场景时对应本云为备，down：出云，灾备场景时对应本云为主，non-dbs：自建
        /// </summary>
        [JsonProperty("job_direction", NullValueHandling = NullValueHandling.Ignore)]
        public JobDirectionEnum JobDirection { get; set; }
        /// <summary>
        /// - db_use_type 是cloudDataGuard时，必填，灾备类型是双主灾备时 muti_write取值true, 否则为false。 - db_use_type 是其他类型时，muti_write是非必选参数
        /// </summary>
        [JsonProperty("multi_write", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MultiWrite { get; set; }

        /// <summary>
        /// 网络类型
        /// </summary>
        [JsonProperty("net_type", NullValueHandling = NullValueHandling.Ignore)]
        public NetTypeEnum NetType { get; set; }
        /// <summary>
        /// 节点个数。MongoDB数据库时对应源端分片个数，源库为集群时必填，[1-32]，MySQL双主灾备时会默认设置为2。
        /// </summary>
        [JsonProperty("node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNum { get; set; }

        /// <summary>
        /// 规格类型。取值： - micro：极小规格。 - small：小规格。 - medium：中规格。 - high：大规格。 - xlarge：超大规格。 - 2xlarge：极大规格。 具体某种场景支持的取值可以通过[查询可用的Node规格接口](https://support.huaweicloud.com/api-drs/drs_03_0239.html)获取。
        /// </summary>
        [JsonProperty("node_type", NullValueHandling = NullValueHandling.Ignore)]
        public NodeTypeEnum NodeType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public Endpoint SourceEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public Endpoint TargetEndpoint { get; set; }

        /// <summary>
        /// 标签信息。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> Tags { get; set; }

        /// <summary>
        /// 迁移模式，FULL_TRANS 全量,FULL_INCR_TRANS 全量+增量,INCR_TRANS 增量，灾备场景单主灾备仅支持全量加增量（FULL_INCR_TRANS）
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public TaskTypeEnum TaskType { get; set; }
        /// <summary>
        /// DRS实例所在子网ID，对应目标库相同VPC下已创建的子网（subnet）的网络ID，UUID格式。
        /// </summary>
        [JsonProperty("customize_sutnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomizeSutnetId { get; set; }

        /// <summary>
        /// 产品id。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 企业项目，不填默认为default，key值必须为_sys_enterprise_project_id，value为企业项目ID，只能填一个企业项目。
        /// </summary>
        [JsonProperty("sys_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> SysTags { get; set; }

        /// <summary>
        /// 任务处于异常状态一段时间后，将会自动结束，单位为天。(范围14-100)，不传默认为14天。
        /// </summary>
        [JsonProperty("expired_days", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiredDays { get; set; }

        /// <summary>
        /// 主备任务主任务所在可用区code，可以通过查询规格未售罄的可用区接口获取 - master_az和slave_az同时填写时生效 - 目前支持mysql，gaussdbv5ha-to-kafka
        /// </summary>
        [JsonProperty("master_az", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterAz { get; set; }

        /// <summary>
        /// 主备任务备任务所在可用区code，可以通过查询规格未售罄的可用区接口获取 - master_az和slave_az同时填写时生效 - 目前支持mysql，gaussdbv5ha-to-kafka
        /// </summary>
        [JsonProperty("slave_az", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveAz { get; set; }

        /// <summary>
        /// 计费模式，不填默认为按需计费。 取值范围： - period：包年包月。 - on_demand：按需计费。
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargingModeEnum ChargingMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("period_order", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodOrderInfo PeriodOrder { get; set; }

        /// <summary>
        /// 指定公网IP的信息。
        /// </summary>
        [JsonProperty("public_ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicIpConfig> PublicIpList { get; set; }

        /// <summary>
        /// 是否开启云数据库RDS for MySQL/MariaDB的binlog快速清理。不传默认为false，不开启快速清理。
        /// </summary>
        [JsonProperty("is_open_fast_clean", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOpenFastClean { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateJobReq {\n");
            sb.Append("  bindEip: ").Append(BindEip).Append("\n");
            sb.Append("  dbUseType: ").Append(DbUseType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  engineType: ").Append(EngineType).Append("\n");
            sb.Append("  isTargetReadonly: ").Append(IsTargetReadonly).Append("\n");
            sb.Append("  jobDirection: ").Append(JobDirection).Append("\n");
            sb.Append("  multiWrite: ").Append(MultiWrite).Append("\n");
            sb.Append("  netType: ").Append(NetType).Append("\n");
            sb.Append("  nodeNum: ").Append(NodeNum).Append("\n");
            sb.Append("  nodeType: ").Append(NodeType).Append("\n");
            sb.Append("  sourceEndpoint: ").Append(SourceEndpoint).Append("\n");
            sb.Append("  targetEndpoint: ").Append(TargetEndpoint).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  customizeSutnetId: ").Append(CustomizeSutnetId).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  sysTags: ").Append(SysTags).Append("\n");
            sb.Append("  expiredDays: ").Append(ExpiredDays).Append("\n");
            sb.Append("  masterAz: ").Append(MasterAz).Append("\n");
            sb.Append("  slaveAz: ").Append(SlaveAz).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  periodOrder: ").Append(PeriodOrder).Append("\n");
            sb.Append("  publicIpList: ").Append(PublicIpList).Append("\n");
            sb.Append("  isOpenFastClean: ").Append(IsOpenFastClean).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateJobReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BindEip == input.BindEip ||
                    (this.BindEip != null &&
                    this.BindEip.Equals(input.BindEip))
                ) && 
                (
                    this.DbUseType == input.DbUseType ||
                    (this.DbUseType != null &&
                    this.DbUseType.Equals(input.DbUseType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EngineType == input.EngineType ||
                    (this.EngineType != null &&
                    this.EngineType.Equals(input.EngineType))
                ) && 
                (
                    this.IsTargetReadonly == input.IsTargetReadonly ||
                    (this.IsTargetReadonly != null &&
                    this.IsTargetReadonly.Equals(input.IsTargetReadonly))
                ) && 
                (
                    this.JobDirection == input.JobDirection ||
                    (this.JobDirection != null &&
                    this.JobDirection.Equals(input.JobDirection))
                ) && 
                (
                    this.MultiWrite == input.MultiWrite ||
                    (this.MultiWrite != null &&
                    this.MultiWrite.Equals(input.MultiWrite))
                ) && 
                (
                    this.NetType == input.NetType ||
                    (this.NetType != null &&
                    this.NetType.Equals(input.NetType))
                ) && 
                (
                    this.NodeNum == input.NodeNum ||
                    (this.NodeNum != null &&
                    this.NodeNum.Equals(input.NodeNum))
                ) && 
                (
                    this.NodeType == input.NodeType ||
                    (this.NodeType != null &&
                    this.NodeType.Equals(input.NodeType))
                ) && 
                (
                    this.SourceEndpoint == input.SourceEndpoint ||
                    (this.SourceEndpoint != null &&
                    this.SourceEndpoint.Equals(input.SourceEndpoint))
                ) && 
                (
                    this.TargetEndpoint == input.TargetEndpoint ||
                    (this.TargetEndpoint != null &&
                    this.TargetEndpoint.Equals(input.TargetEndpoint))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.TaskType == input.TaskType ||
                    (this.TaskType != null &&
                    this.TaskType.Equals(input.TaskType))
                ) && 
                (
                    this.CustomizeSutnetId == input.CustomizeSutnetId ||
                    (this.CustomizeSutnetId != null &&
                    this.CustomizeSutnetId.Equals(input.CustomizeSutnetId))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.SysTags == input.SysTags ||
                    this.SysTags != null &&
                    input.SysTags != null &&
                    this.SysTags.SequenceEqual(input.SysTags)
                ) && 
                (
                    this.ExpiredDays == input.ExpiredDays ||
                    (this.ExpiredDays != null &&
                    this.ExpiredDays.Equals(input.ExpiredDays))
                ) && 
                (
                    this.MasterAz == input.MasterAz ||
                    (this.MasterAz != null &&
                    this.MasterAz.Equals(input.MasterAz))
                ) && 
                (
                    this.SlaveAz == input.SlaveAz ||
                    (this.SlaveAz != null &&
                    this.SlaveAz.Equals(input.SlaveAz))
                ) && 
                (
                    this.ChargingMode == input.ChargingMode ||
                    (this.ChargingMode != null &&
                    this.ChargingMode.Equals(input.ChargingMode))
                ) && 
                (
                    this.PeriodOrder == input.PeriodOrder ||
                    (this.PeriodOrder != null &&
                    this.PeriodOrder.Equals(input.PeriodOrder))
                ) && 
                (
                    this.PublicIpList == input.PublicIpList ||
                    this.PublicIpList != null &&
                    input.PublicIpList != null &&
                    this.PublicIpList.SequenceEqual(input.PublicIpList)
                ) && 
                (
                    this.IsOpenFastClean == input.IsOpenFastClean ||
                    (this.IsOpenFastClean != null &&
                    this.IsOpenFastClean.Equals(input.IsOpenFastClean))
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
                if (this.BindEip != null)
                    hashCode = hashCode * 59 + this.BindEip.GetHashCode();
                if (this.DbUseType != null)
                    hashCode = hashCode * 59 + this.DbUseType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EngineType != null)
                    hashCode = hashCode * 59 + this.EngineType.GetHashCode();
                if (this.IsTargetReadonly != null)
                    hashCode = hashCode * 59 + this.IsTargetReadonly.GetHashCode();
                if (this.JobDirection != null)
                    hashCode = hashCode * 59 + this.JobDirection.GetHashCode();
                if (this.MultiWrite != null)
                    hashCode = hashCode * 59 + this.MultiWrite.GetHashCode();
                if (this.NetType != null)
                    hashCode = hashCode * 59 + this.NetType.GetHashCode();
                if (this.NodeNum != null)
                    hashCode = hashCode * 59 + this.NodeNum.GetHashCode();
                if (this.NodeType != null)
                    hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                if (this.SourceEndpoint != null)
                    hashCode = hashCode * 59 + this.SourceEndpoint.GetHashCode();
                if (this.TargetEndpoint != null)
                    hashCode = hashCode * 59 + this.TargetEndpoint.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TaskType != null)
                    hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.CustomizeSutnetId != null)
                    hashCode = hashCode * 59 + this.CustomizeSutnetId.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.SysTags != null)
                    hashCode = hashCode * 59 + this.SysTags.GetHashCode();
                if (this.ExpiredDays != null)
                    hashCode = hashCode * 59 + this.ExpiredDays.GetHashCode();
                if (this.MasterAz != null)
                    hashCode = hashCode * 59 + this.MasterAz.GetHashCode();
                if (this.SlaveAz != null)
                    hashCode = hashCode * 59 + this.SlaveAz.GetHashCode();
                if (this.ChargingMode != null)
                    hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.PeriodOrder != null)
                    hashCode = hashCode * 59 + this.PeriodOrder.GetHashCode();
                if (this.PublicIpList != null)
                    hashCode = hashCode * 59 + this.PublicIpList.GetHashCode();
                if (this.IsOpenFastClean != null)
                    hashCode = hashCode * 59 + this.IsOpenFastClean.GetHashCode();
                return hashCode;
            }
        }
    }
}
