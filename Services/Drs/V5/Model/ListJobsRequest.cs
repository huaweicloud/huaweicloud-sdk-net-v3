using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListJobsRequest 
    {
        /// <summary>
        /// 请求语言类型。
        /// </summary>
        /// <value>请求语言类型。</value>
        [JsonConverter(typeof(EnumClassConverter<XLanguageEnum>))]
        public class XLanguageEnum
        {
            /// <summary>
            /// Enum EN_US for value: en-us
            /// </summary>
            public static readonly XLanguageEnum EN_US = new XLanguageEnum("en-us");

            /// <summary>
            /// Enum ZH_CN for value: zh-cn
            /// </summary>
            public static readonly XLanguageEnum ZH_CN = new XLanguageEnum("zh-cn");

            private static readonly Dictionary<string, XLanguageEnum> StaticFields =
            new Dictionary<string, XLanguageEnum>()
            {
                { "en-us", EN_US },
                { "zh-cn", ZH_CN },
            };

            private string _value;

            public XLanguageEnum()
            {

            }

            public XLanguageEnum(string value)
            {
                _value = value;
            }

            public static XLanguageEnum FromValue(string value)
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

                if (this.Equals(obj as XLanguageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(XLanguageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(XLanguageEnum a, XLanguageEnum b)
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

            public static bool operator !=(XLanguageEnum a, XLanguageEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 任务场景。取值： - migration：实时迁移。 - sync：实时同步。 - cloudDataGuard：实时灾备。
        /// </summary>
        /// <value>任务场景。取值： - migration：实时迁移。 - sync：实时同步。 - cloudDataGuard：实时灾备。</value>
        [JsonConverter(typeof(EnumClassConverter<JobTypeEnum>))]
        public class JobTypeEnum
        {
            /// <summary>
            /// Enum MIGRATION for value: migration
            /// </summary>
            public static readonly JobTypeEnum MIGRATION = new JobTypeEnum("migration");

            /// <summary>
            /// Enum SYNC for value: sync
            /// </summary>
            public static readonly JobTypeEnum SYNC = new JobTypeEnum("sync");

            /// <summary>
            /// Enum CLOUDDATAGUARD for value: cloudDataGuard
            /// </summary>
            public static readonly JobTypeEnum CLOUDDATAGUARD = new JobTypeEnum("cloudDataGuard");

            private static readonly Dictionary<string, JobTypeEnum> StaticFields =
            new Dictionary<string, JobTypeEnum>()
            {
                { "migration", MIGRATION },
                { "sync", SYNC },
                { "cloudDataGuard", CLOUDDATAGUARD },
            };

            private string _value;

            public JobTypeEnum()
            {

            }

            public JobTypeEnum(string value)
            {
                _value = value;
            }

            public static JobTypeEnum FromValue(string value)
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

                if (this.Equals(obj as JobTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(JobTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(JobTypeEnum a, JobTypeEnum b)
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

            public static bool operator !=(JobTypeEnum a, JobTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 任务状态。取值： - CREATING：创建中。 - CREATE_FAILED：创建失败。 - CONFIGURATION：配置中。 - STARTJOBING：启动中。 - WAITING_FOR_START：等待启动中。 - START_JOB_FAILED：任务启动失败。 - FULL_TRANSFER_STARTED：全量迁移中，灾备场景为初始化。 - FULL_TRANSFER_FAILED：全量迁移失败，灾备场景为初始化失败。 - FULL_TRANSFER_COMPLETE：全量迁移完成，灾备场景为初始化完成。 - INCRE_TRANSFER_STARTED：增量迁移中，灾备场景为灾备中。 - INCRE_TRANSFER_FAILED：增量迁移失败，灾备场景为灾备异常。 - RELEASE_RESOURCE_STARTED：结束任务中。 - RELEASE_RESOURCE_FAILED：结束任务失败。 - RELEASE_RESOURCE_COMPLETE：已结束。 - CHANGE_JOB_STARTED：任务变更中。 - CHANGE_JOB_FAILED：任务变更失败。 - CHILD_TRANSFER_STARTING：子任务启动中。 - CHILD_TRANSFER_STARTED：子任务迁移中。 - CHILD_TRANSFER_COMPLETE：子任务迁移完成。 - CHILD_TRANSFER_FAILED：子任务迁移失败。 - RELEASE_CHILD_TRANSFER_STARTED：子任务结束中。 - RELEASE_CHILD_TRANSFER_COMPLETE：子任务已结束。 其中，异常状态可单独查询，也可以通过以下方式查询全部异常任务： CREATE_FAILED,START_JOB_FAILED,FULL_TRANSFER_FAILED,INCRE_TRANSFER_FAILED,RELEASE_RESOURCE_FAILED,CHANGE_JOB_FAILED,CHILD_TRANSFER_FAILED
        /// </summary>
        /// <value>任务状态。取值： - CREATING：创建中。 - CREATE_FAILED：创建失败。 - CONFIGURATION：配置中。 - STARTJOBING：启动中。 - WAITING_FOR_START：等待启动中。 - START_JOB_FAILED：任务启动失败。 - FULL_TRANSFER_STARTED：全量迁移中，灾备场景为初始化。 - FULL_TRANSFER_FAILED：全量迁移失败，灾备场景为初始化失败。 - FULL_TRANSFER_COMPLETE：全量迁移完成，灾备场景为初始化完成。 - INCRE_TRANSFER_STARTED：增量迁移中，灾备场景为灾备中。 - INCRE_TRANSFER_FAILED：增量迁移失败，灾备场景为灾备异常。 - RELEASE_RESOURCE_STARTED：结束任务中。 - RELEASE_RESOURCE_FAILED：结束任务失败。 - RELEASE_RESOURCE_COMPLETE：已结束。 - CHANGE_JOB_STARTED：任务变更中。 - CHANGE_JOB_FAILED：任务变更失败。 - CHILD_TRANSFER_STARTING：子任务启动中。 - CHILD_TRANSFER_STARTED：子任务迁移中。 - CHILD_TRANSFER_COMPLETE：子任务迁移完成。 - CHILD_TRANSFER_FAILED：子任务迁移失败。 - RELEASE_CHILD_TRANSFER_STARTED：子任务结束中。 - RELEASE_CHILD_TRANSFER_COMPLETE：子任务已结束。 其中，异常状态可单独查询，也可以通过以下方式查询全部异常任务： CREATE_FAILED,START_JOB_FAILED,FULL_TRANSFER_FAILED,INCRE_TRANSFER_FAILED,RELEASE_RESOURCE_FAILED,CHANGE_JOB_FAILED,CHILD_TRANSFER_FAILED</value>
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
            /// Enum CHANGE_JOB_STARTED for value: CHANGE_JOB_STARTED
            /// </summary>
            public static readonly StatusEnum CHANGE_JOB_STARTED = new StatusEnum("CHANGE_JOB_STARTED");

            /// <summary>
            /// Enum CHANGE_JOB_FAILED for value: CHANGE_JOB_FAILED
            /// </summary>
            public static readonly StatusEnum CHANGE_JOB_FAILED = new StatusEnum("CHANGE_JOB_FAILED");

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

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CREATING", CREATING },
                { "CREATE_FAILED", CREATE_FAILED },
                { "CONFIGURATION", CONFIGURATION },
                { "STARTJOBING", STARTJOBING },
                { "WAITING_FOR_START", WAITING_FOR_START },
                { "START_JOB_FAILED", START_JOB_FAILED },
                { "FULL_TRANSFER_STARTED", FULL_TRANSFER_STARTED },
                { "FULL_TRANSFER_FAILED", FULL_TRANSFER_FAILED },
                { "FULL_TRANSFER_COMPLETE", FULL_TRANSFER_COMPLETE },
                { "INCRE_TRANSFER_STARTED", INCRE_TRANSFER_STARTED },
                { "INCRE_TRANSFER_FAILED", INCRE_TRANSFER_FAILED },
                { "RELEASE_RESOURCE_STARTED", RELEASE_RESOURCE_STARTED },
                { "RELEASE_RESOURCE_FAILED", RELEASE_RESOURCE_FAILED },
                { "RELEASE_RESOURCE_COMPLETE", RELEASE_RESOURCE_COMPLETE },
                { "CHANGE_JOB_STARTED", CHANGE_JOB_STARTED },
                { "CHANGE_JOB_FAILED", CHANGE_JOB_FAILED },
                { "CHILD_TRANSFER_STARTING", CHILD_TRANSFER_STARTING },
                { "CHILD_TRANSFER_STARTED", CHILD_TRANSFER_STARTED },
                { "CHILD_TRANSFER_COMPLETE", CHILD_TRANSFER_COMPLETE },
                { "CHILD_TRANSFER_FAILED", CHILD_TRANSFER_FAILED },
                { "RELEASE_CHILD_TRANSFER_STARTED", RELEASE_CHILD_TRANSFER_STARTED },
                { "RELEASE_CHILD_TRANSFER_COMPLETE", RELEASE_CHILD_TRANSFER_COMPLETE },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 引擎类型。取值： - oracle-to-gaussdbv5：Oracle同步到GaussDB分布式版，实时同步场景使用。 - redis-to-gaussredis：Redis同步到GeminiDB Redis，实时迁移场景使用。 - rediscluster-to-gaussredis：Redis集群同步到GeminiDB Redis，实时迁移场景使用。
        /// </summary>
        /// <value>引擎类型。取值： - oracle-to-gaussdbv5：Oracle同步到GaussDB分布式版，实时同步场景使用。 - redis-to-gaussredis：Redis同步到GeminiDB Redis，实时迁移场景使用。 - rediscluster-to-gaussredis：Redis集群同步到GeminiDB Redis，实时迁移场景使用。</value>
        [JsonConverter(typeof(EnumClassConverter<EngineTypeEnum>))]
        public class EngineTypeEnum
        {
            /// <summary>
            /// Enum ORACLE_TO_GAUSSDBV5 for value: oracle-to-gaussdbv5
            /// </summary>
            public static readonly EngineTypeEnum ORACLE_TO_GAUSSDBV5 = new EngineTypeEnum("oracle-to-gaussdbv5");

            /// <summary>
            /// Enum REDIS_TO_GAUSSREDIS for value: redis-to-gaussredis
            /// </summary>
            public static readonly EngineTypeEnum REDIS_TO_GAUSSREDIS = new EngineTypeEnum("redis-to-gaussredis");

            /// <summary>
            /// Enum REDISCLUSTER_TO_GAUSSREDIS for value: rediscluster-to-gaussredis
            /// </summary>
            public static readonly EngineTypeEnum REDISCLUSTER_TO_GAUSSREDIS = new EngineTypeEnum("rediscluster-to-gaussredis");

            private static readonly Dictionary<string, EngineTypeEnum> StaticFields =
            new Dictionary<string, EngineTypeEnum>()
            {
                { "oracle-to-gaussdbv5", ORACLE_TO_GAUSSDBV5 },
                { "redis-to-gaussredis", REDIS_TO_GAUSSREDIS },
                { "rediscluster-to-gaussredis", REDISCLUSTER_TO_GAUSSREDIS },
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

            public static bool operator !=(EngineTypeEnum a, EngineTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 网络类型。取值： - eip：公网网络。 - vpc：VPC网络。 - vpn：VPN、专线网络。
        /// </summary>
        /// <value>网络类型。取值： - eip：公网网络。 - vpc：VPC网络。 - vpn：VPN、专线网络。</value>
        [JsonConverter(typeof(EnumClassConverter<NetTypeEnum>))]
        public class NetTypeEnum
        {
            /// <summary>
            /// Enum EIP for value: eip
            /// </summary>
            public static readonly NetTypeEnum EIP = new NetTypeEnum("eip");

            /// <summary>
            /// Enum VPC for value: vpc
            /// </summary>
            public static readonly NetTypeEnum VPC = new NetTypeEnum("vpc");

            /// <summary>
            /// Enum VPN for value: vpn
            /// </summary>
            public static readonly NetTypeEnum VPN = new NetTypeEnum("vpn");

            private static readonly Dictionary<string, NetTypeEnum> StaticFields =
            new Dictionary<string, NetTypeEnum>()
            {
                { "eip", EIP },
                { "vpc", VPC },
                { "vpn", VPN },
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

            public static bool operator !=(NetTypeEnum a, NetTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 请求语言类型。
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public XLanguageEnum XLanguage { get; set; }
        /// <summary>
        /// 任务场景。取值： - migration：实时迁移。 - sync：实时同步。 - cloudDataGuard：实时灾备。
        /// </summary>
        [SDKProperty("job_type", IsQuery = true)]
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public JobTypeEnum JobType { get; set; }
        /// <summary>
        /// 任务ID或名称。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 任务状态。取值： - CREATING：创建中。 - CREATE_FAILED：创建失败。 - CONFIGURATION：配置中。 - STARTJOBING：启动中。 - WAITING_FOR_START：等待启动中。 - START_JOB_FAILED：任务启动失败。 - FULL_TRANSFER_STARTED：全量迁移中，灾备场景为初始化。 - FULL_TRANSFER_FAILED：全量迁移失败，灾备场景为初始化失败。 - FULL_TRANSFER_COMPLETE：全量迁移完成，灾备场景为初始化完成。 - INCRE_TRANSFER_STARTED：增量迁移中，灾备场景为灾备中。 - INCRE_TRANSFER_FAILED：增量迁移失败，灾备场景为灾备异常。 - RELEASE_RESOURCE_STARTED：结束任务中。 - RELEASE_RESOURCE_FAILED：结束任务失败。 - RELEASE_RESOURCE_COMPLETE：已结束。 - CHANGE_JOB_STARTED：任务变更中。 - CHANGE_JOB_FAILED：任务变更失败。 - CHILD_TRANSFER_STARTING：子任务启动中。 - CHILD_TRANSFER_STARTED：子任务迁移中。 - CHILD_TRANSFER_COMPLETE：子任务迁移完成。 - CHILD_TRANSFER_FAILED：子任务迁移失败。 - RELEASE_CHILD_TRANSFER_STARTED：子任务结束中。 - RELEASE_CHILD_TRANSFER_COMPLETE：子任务已结束。 其中，异常状态可单独查询，也可以通过以下方式查询全部异常任务： CREATE_FAILED,START_JOB_FAILED,FULL_TRANSFER_FAILED,INCRE_TRANSFER_FAILED,RELEASE_RESOURCE_FAILED,CHANGE_JOB_FAILED,CHILD_TRANSFER_FAILED
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 引擎类型。取值： - oracle-to-gaussdbv5：Oracle同步到GaussDB分布式版，实时同步场景使用。 - redis-to-gaussredis：Redis同步到GeminiDB Redis，实时迁移场景使用。 - rediscluster-to-gaussredis：Redis集群同步到GeminiDB Redis，实时迁移场景使用。
        /// </summary>
        [SDKProperty("engine_type", IsQuery = true)]
        [JsonProperty("engine_type", NullValueHandling = NullValueHandling.Ignore)]
        public EngineTypeEnum EngineType { get; set; }
        /// <summary>
        /// 网络类型。取值： - eip：公网网络。 - vpc：VPC网络。 - vpn：VPN、专线网络。
        /// </summary>
        [SDKProperty("net_type", IsQuery = true)]
        [JsonProperty("net_type", NullValueHandling = NullValueHandling.Ignore)]
        public NetTypeEnum NetType { get; set; }
        /// <summary>
        /// 企业项目ID。 缺省值：\&quot;\&quot;，表示查询所有企业项目任务。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 偏移量，表示查询该偏移量后面的记录。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询返回记录的数量限制。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 返回结果按该关键字排序，默认为“create_time”。
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SortKey { get; set; }

        /// <summary>
        /// 降序或升序（分别对应desc和asc，默认为“desc”）。
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string SortDir { get; set; }

        /// <summary>
        /// 数据库实例ID列表，最多支持10个
        /// </summary>
        [SDKProperty("instance_ids", IsQuery = true)]
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// 数据库实例IP
        /// </summary>
        [SDKProperty("instance_ip", IsQuery = true)]
        [JsonProperty("instance_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListJobsRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  engineType: ").Append(EngineType).Append("\n");
            sb.Append("  netType: ").Append(NetType).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("  instanceIp: ").Append(InstanceIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListJobsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListJobsRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage) return false;
            if (this.JobType != input.JobType) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status) return false;
            if (this.EngineType != input.EngineType) return false;
            if (this.NetType != input.NetType) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && !this.SortKey.Equals(input.SortKey))) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && !this.SortDir.Equals(input.SortDir))) return false;
            if (this.InstanceIds != input.InstanceIds || (this.InstanceIds != null && input.InstanceIds != null && !this.InstanceIds.SequenceEqual(input.InstanceIds))) return false;
            if (this.InstanceIp != input.InstanceIp || (this.InstanceIp != null && !this.InstanceIp.Equals(input.InstanceIp))) return false;

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
                hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.EngineType.GetHashCode();
                hashCode = hashCode * 59 + this.NetType.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SortKey != null) hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.SortDir != null) hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.InstanceIds != null) hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                if (this.InstanceIp != null) hashCode = hashCode * 59 + this.InstanceIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
