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
    /// 设置同步策略请求体
    /// </summary>
    public class SyncPolicyReq 
    {
        /// <summary>
        /// **参数解释**：  数据迁移过程中的冲突忽略策略，指定当目标库已存在相同数据时的处理方式。  **约束限制**：  不涉及。  **取值范围**：  - stop：冲突失败，遇到冲突时停止任务 - overwrite：冲突覆盖，用源库数据覆盖目标库已有数据 - ignore：冲突忽略，跳过冲突数据继续迁移  **默认取值**：  不涉及
        /// </summary>
        /// <value>**参数解释**：  数据迁移过程中的冲突忽略策略，指定当目标库已存在相同数据时的处理方式。  **约束限制**：  不涉及。  **取值范围**：  - stop：冲突失败，遇到冲突时停止任务 - overwrite：冲突覆盖，用源库数据覆盖目标库已有数据 - ignore：冲突忽略，跳过冲突数据继续迁移  **默认取值**：  不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<ConflictPolicyEnum>))]
        public class ConflictPolicyEnum
        {
            /// <summary>
            /// Enum IGNORE for value: ignore
            /// </summary>
            public static readonly ConflictPolicyEnum IGNORE = new ConflictPolicyEnum("ignore");

            /// <summary>
            /// Enum OVERWRITE for value: overwrite
            /// </summary>
            public static readonly ConflictPolicyEnum OVERWRITE = new ConflictPolicyEnum("overwrite");

            /// <summary>
            /// Enum STOP for value: stop
            /// </summary>
            public static readonly ConflictPolicyEnum STOP = new ConflictPolicyEnum("stop");

            private static readonly Dictionary<string, ConflictPolicyEnum> StaticFields =
            new Dictionary<string, ConflictPolicyEnum>()
            {
                { "ignore", IGNORE },
                { "overwrite", OVERWRITE },
                { "stop", STOP },
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

            public static bool operator !=(ConflictPolicyEnum a, ConflictPolicyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：  过滤DDL策略，指定增量同步过程中需要过滤的DDL操作类型。  **约束限制**：  不涉及。  **取值范围**：  - drop_database：过滤DROP DATABASE操作  **默认取值**：  不涉及
        /// </summary>
        /// <value>**参数解释**：  过滤DDL策略，指定增量同步过程中需要过滤的DDL操作类型。  **约束限制**：  不涉及。  **取值范围**：  - drop_database：过滤DROP DATABASE操作  **默认取值**：  不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<FilterDdlPolicyEnum>))]
        public class FilterDdlPolicyEnum
        {
            /// <summary>
            /// Enum DROP_DATABASE for value: drop_database
            /// </summary>
            public static readonly FilterDdlPolicyEnum DROP_DATABASE = new FilterDdlPolicyEnum("drop_database");

            private static readonly Dictionary<string, FilterDdlPolicyEnum> StaticFields =
            new Dictionary<string, FilterDdlPolicyEnum>()
            {
                { "drop_database", DROP_DATABASE },
            };

            private string _value;

            public FilterDdlPolicyEnum()
            {

            }

            public FilterDdlPolicyEnum(string value)
            {
                _value = value;
            }

            public static FilterDdlPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as FilterDdlPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FilterDdlPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FilterDdlPolicyEnum a, FilterDdlPolicyEnum b)
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

            public static bool operator !=(FilterDdlPolicyEnum a, FilterDdlPolicyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：  同步Topic策略，指定Kafka目标库的Topic生成方式。  **约束限制**：  - 目标库为Kafka时必填。 - 不同引擎类型支持的取值范围不同，详见取值范围说明。  **取值范围**：  - 0：集中投递到一个Topic - 1：按库名-schema-表名自动生成Topic名字（GaussDB集中式版到Kafka、PostgreSQL到Kafka按库名-schema-表名；MySQL到Kafka、TaurusDB到Kafka自动生成Topic；Oracle到Kafka按schema-表名） - 2：按库名自动生成Topic名字 - 3：按库名-schema自动生成Topic名字（Oracle到Kafka按schema自动生成Topic）  **默认取值**：  不涉及
        /// </summary>
        /// <value>**参数解释**：  同步Topic策略，指定Kafka目标库的Topic生成方式。  **约束限制**：  - 目标库为Kafka时必填。 - 不同引擎类型支持的取值范围不同，详见取值范围说明。  **取值范围**：  - 0：集中投递到一个Topic - 1：按库名-schema-表名自动生成Topic名字（GaussDB集中式版到Kafka、PostgreSQL到Kafka按库名-schema-表名；MySQL到Kafka、TaurusDB到Kafka自动生成Topic；Oracle到Kafka按schema-表名） - 2：按库名自动生成Topic名字 - 3：按库名-schema自动生成Topic名字（Oracle到Kafka按schema自动生成Topic）  **默认取值**：  不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<TopicPolicyEnum>))]
        public class TopicPolicyEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly TopicPolicyEnum _0 = new TopicPolicyEnum("0");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly TopicPolicyEnum _1 = new TopicPolicyEnum("1");

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            public static readonly TopicPolicyEnum _2 = new TopicPolicyEnum("2");

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            public static readonly TopicPolicyEnum _3 = new TopicPolicyEnum("3");

            private static readonly Dictionary<string, TopicPolicyEnum> StaticFields =
            new Dictionary<string, TopicPolicyEnum>()
            {
                { "0", _0 },
                { "1", _1 },
                { "2", _2 },
                { "3", _3 },
            };

            private string _value;

            public TopicPolicyEnum()
            {

            }

            public TopicPolicyEnum(string value)
            {
                _value = value;
            }

            public static TopicPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as TopicPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TopicPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TopicPolicyEnum a, TopicPolicyEnum b)
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

            public static bool operator !=(TopicPolicyEnum a, TopicPolicyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：  同步到Kafka Partition的策略，指定数据投递到Kafka分区的方式。  **约束限制**：  - 目标库为Kafka时必填。 - partition_policy的可选取值受topic_policy约束：当topic_policy取0时可取0、1、2、3、4、5；当topic_policy取1时可取0、1、2、5；当topic_policy取2时可取0、1、2、3；当topic_policy取3时可取0、1；当topic_policy取4时可取0、1、3。  **取值范围**：  - 0：按库名.schema.表名的hash值投递到不同Partition - 1：全部投递到Partition 0 - 2：按主键的hash值投递到不同Partition - 3：按库名.schema的hash值投递到不同Partition  **默认取值**：  不涉及
        /// </summary>
        /// <value>**参数解释**：  同步到Kafka Partition的策略，指定数据投递到Kafka分区的方式。  **约束限制**：  - 目标库为Kafka时必填。 - partition_policy的可选取值受topic_policy约束：当topic_policy取0时可取0、1、2、3、4、5；当topic_policy取1时可取0、1、2、5；当topic_policy取2时可取0、1、2、3；当topic_policy取3时可取0、1；当topic_policy取4时可取0、1、3。  **取值范围**：  - 0：按库名.schema.表名的hash值投递到不同Partition - 1：全部投递到Partition 0 - 2：按主键的hash值投递到不同Partition - 3：按库名.schema的hash值投递到不同Partition  **默认取值**：  不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<PartitionPolicyEnum>))]
        public class PartitionPolicyEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly PartitionPolicyEnum _0 = new PartitionPolicyEnum("0");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly PartitionPolicyEnum _1 = new PartitionPolicyEnum("1");

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            public static readonly PartitionPolicyEnum _2 = new PartitionPolicyEnum("2");

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            public static readonly PartitionPolicyEnum _3 = new PartitionPolicyEnum("3");

            private static readonly Dictionary<string, PartitionPolicyEnum> StaticFields =
            new Dictionary<string, PartitionPolicyEnum>()
            {
                { "0", _0 },
                { "1", _1 },
                { "2", _2 },
                { "3", _3 },
            };

            private string _value;

            public PartitionPolicyEnum()
            {

            }

            public PartitionPolicyEnum(string value)
            {
                _value = value;
            }

            public static PartitionPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as PartitionPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PartitionPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PartitionPolicyEnum a, PartitionPolicyEnum b)
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

            public static bool operator !=(PartitionPolicyEnum a, PartitionPolicyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：  投送到Kafka的数据格式，指定同步到Kafka的数据序列化方式。  **约束限制**：  - MySQL到Kafka、TaurusDB到Kafka同步支持json和json_c。 - 其他引擎支持json和avro。  **取值范围**：  - json：JSON格式 - avro：Avro格式  **默认取值**：  json
        /// </summary>
        /// <value>**参数解释**：  投送到Kafka的数据格式，指定同步到Kafka的数据序列化方式。  **约束限制**：  - MySQL到Kafka、TaurusDB到Kafka同步支持json和json_c。 - 其他引擎支持json和avro。  **取值范围**：  - json：JSON格式 - avro：Avro格式  **默认取值**：  json</value>
        [JsonConverter(typeof(EnumClassConverter<KafkaDataFormatEnum>))]
        public class KafkaDataFormatEnum
        {
            /// <summary>
            /// Enum JSON for value: json
            /// </summary>
            public static readonly KafkaDataFormatEnum JSON = new KafkaDataFormatEnum("json");

            /// <summary>
            /// Enum AVRO for value: avro
            /// </summary>
            public static readonly KafkaDataFormatEnum AVRO = new KafkaDataFormatEnum("avro");

            private static readonly Dictionary<string, KafkaDataFormatEnum> StaticFields =
            new Dictionary<string, KafkaDataFormatEnum>()
            {
                { "json", JSON },
                { "avro", AVRO },
            };

            private string _value;

            public KafkaDataFormatEnum()
            {

            }

            public KafkaDataFormatEnum(string value)
            {
                _value = value;
            }

            public static KafkaDataFormatEnum FromValue(string value)
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

                if (this.Equals(obj as KafkaDataFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KafkaDataFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KafkaDataFormatEnum a, KafkaDataFormatEnum b)
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

            public static bool operator !=(KafkaDataFormatEnum a, KafkaDataFormatEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：  同步任务ID，用于唯一标识一个数据复制任务，在批量设置同步策略时指定需要设置策略的任务。  **约束限制**：  不涉及。  **取值范围**：  UUID格式字符串。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// **参数解释**：  数据迁移过程中的冲突忽略策略，指定当目标库已存在相同数据时的处理方式。  **约束限制**：  不涉及。  **取值范围**：  - stop：冲突失败，遇到冲突时停止任务 - overwrite：冲突覆盖，用源库数据覆盖目标库已有数据 - ignore：冲突忽略，跳过冲突数据继续迁移  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("conflict_policy", NullValueHandling = NullValueHandling.Ignore)]
        public ConflictPolicyEnum ConflictPolicy { get; set; }
        /// <summary>
        /// **参数解释**：  过滤DDL策略，指定增量同步过程中需要过滤的DDL操作类型。  **约束限制**：  不涉及。  **取值范围**：  - drop_database：过滤DROP DATABASE操作  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("filter_ddl_policy", NullValueHandling = NullValueHandling.Ignore)]
        public FilterDdlPolicyEnum FilterDdlPolicy { get; set; }
        /// <summary>
        /// **参数解释**：  同步增量时是否同步DDL，指定增量同步阶段是否将源库的DDL操作同步到目标库。  **约束限制**：  不涉及。  **取值范围**：  - true：同步增量时同步DDL - false：同步增量时不同步DDL  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("ddl_trans", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DdlTrans { get; set; }

        /// <summary>
        /// **参数解释**：  同步增量时是否同步索引，指定增量同步阶段是否将源库的索引变更同步到目标库。  **约束限制**：  不涉及。  **取值范围**：  - true：同步增量时同步索引 - false：同步增量时不同步索引  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("index_trans", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IndexTrans { get; set; }

        /// <summary>
        /// **参数解释**：  同步Topic策略，指定Kafka目标库的Topic生成方式。  **约束限制**：  - 目标库为Kafka时必填。 - 不同引擎类型支持的取值范围不同，详见取值范围说明。  **取值范围**：  - 0：集中投递到一个Topic - 1：按库名-schema-表名自动生成Topic名字（GaussDB集中式版到Kafka、PostgreSQL到Kafka按库名-schema-表名；MySQL到Kafka、TaurusDB到Kafka自动生成Topic；Oracle到Kafka按schema-表名） - 2：按库名自动生成Topic名字 - 3：按库名-schema自动生成Topic名字（Oracle到Kafka按schema自动生成Topic）  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("topic_policy", NullValueHandling = NullValueHandling.Ignore)]
        public TopicPolicyEnum TopicPolicy { get; set; }
        /// <summary>
        /// **参数解释**：  Kafka Topic名称，指定同步数据投递的目标Topic。  **约束限制**：  - topic_policy为0时必填。 - 确保Topic已存在。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// **参数解释**：  同步到Kafka Partition的策略，指定数据投递到Kafka分区的方式。  **约束限制**：  - 目标库为Kafka时必填。 - partition_policy的可选取值受topic_policy约束：当topic_policy取0时可取0、1、2、3、4、5；当topic_policy取1时可取0、1、2、5；当topic_policy取2时可取0、1、2、3；当topic_policy取3时可取0、1；当topic_policy取4时可取0、1、3。  **取值范围**：  - 0：按库名.schema.表名的hash值投递到不同Partition - 1：全部投递到Partition 0 - 2：按主键的hash值投递到不同Partition - 3：按库名.schema的hash值投递到不同Partition  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("partition_policy", NullValueHandling = NullValueHandling.Ignore)]
        public PartitionPolicyEnum PartitionPolicy { get; set; }
        /// <summary>
        /// **参数解释**：  投送到Kafka的数据格式，指定同步到Kafka的数据序列化方式。  **约束限制**：  - MySQL到Kafka、TaurusDB到Kafka同步支持json和json_c。 - 其他引擎支持json和avro。  **取值范围**：  - json：JSON格式 - avro：Avro格式  **默认取值**：  json
        /// </summary>
        [JsonProperty("kafka_data_format", NullValueHandling = NullValueHandling.Ignore)]
        public KafkaDataFormatEnum KafkaDataFormat { get; set; }
        /// <summary>
        /// **参数解释**：  Topic名字格式，指定自动生成Topic名称时使用的命名模板。  **约束限制**：  - topic_policy为1、2、3时需要填写。 - PostgreSQL到Kafka、GaussDB集中式版到Kafka：topic_policy取1时支持database和schema变量，不填默认为$-$；取2时支持database变量，不填默认为$；取3时支持database、schema和tablename变量，不填默认为$-$-$。 - Oracle到Kafka：topic_policy取1时支持schema和tablename变量，不填默认为$-$；取3时支持schema变量，不填默认为$。 - MySQL到Kafka、TaurusDB到Kafka：topic_policy取1时支持database和tablename变量，不填默认为$-$。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("topic_name_format", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicNameFormat { get; set; }

        /// <summary>
        /// **参数解释**：  Partition个数，指定Kafka Topic的分区数量。  **约束限制**：  - topic_policy为1、2、3时需要填写。  **取值范围**：  1-2147483647  **默认取值**：  1
        /// </summary>
        [JsonProperty("partitions_num", NullValueHandling = NullValueHandling.Ignore)]
        public string PartitionsNum { get; set; }

        /// <summary>
        /// **参数解释**：  副本个数，指定Kafka Topic的副本数量。  **约束限制**：  - topic_policy为1、2、3时需要填写。  **取值范围**：  1-32767  **默认取值**：  1
        /// </summary>
        [JsonProperty("replication_factor", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicationFactor { get; set; }

        /// <summary>
        /// **参数解释**：  PostgreSQL同步全量阶段是否填充物化视图，指定全量同步时是否将源库物化视图的数据填充到目标库。  **约束限制**：  不涉及。  **取值范围**：  - true：填充物化视图 - false：不填充物化视图  **默认取值**：  false
        /// </summary>
        [JsonProperty("is_fill_materialized_view", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFillMaterializedView { get; set; }

        /// <summary>
        /// **参数解释**：  PostgreSQL同步全量阶段是否使用快照模式导出，指定全量同步时是否采用快照方式导出源库数据。  **约束限制**：  不涉及。  **取值范围**：  - true：使用快照模式导出 - false：不使用快照模式导出  **默认取值**：  false
        /// </summary>
        [JsonProperty("export_snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExportSnapshot { get; set; }

        /// <summary>
        /// **参数解释**：  复制槽名称，指定PostgreSQL逻辑复制的复制槽标识。  **约束限制**：  - gaussdbv5ha-to-kafka主备任务必填。 - PostgreSQL为源的单增量同步任务选填。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("slot_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SlotName { get; set; }

        /// <summary>
        /// **参数解释**：  源库日志位点，指定增量同步的起始位点。  **约束限制**：  - MySQL为源时，通过show master status命令获取源库位点，格式为：文件名.文件编号:事件位点。文件名只能为1-60个字符且不能包含特殊字符，文件编号只能为3-20个数字，binlog事件位置只能为1-20个数字，且总长度不能超过100个字符。 - MongoDB为源时，位点需设置在oplog范围以内，格式为：timestamp:incre，timestamp和incre均为范围在1~2147483647之间的整数。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("file_and_position", NullValueHandling = NullValueHandling.Ignore)]
        public string FileAndPosition { get; set; }

        /// <summary>
        /// **参数解释**：  MySQL GTID集合，指定增量同步的GTID起始位点。  **约束限制**：  - MySQL为源的任务需要填写，通过show master status命令获取源库位点，根据提示填写Executed_Gtid_Set。 - 如果源库为MySQL 5.5版本，则不支持使用同步任务。 - 不能包含特殊字符和中文，且不能超过2048个字符。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("gtid_set", NullValueHandling = NullValueHandling.Ignore)]
        public string GtidSet { get; set; }

        /// <summary>
        /// **参数解释**：  存储DDL的Kafka Topic名称，指定DDL操作数据投递的目标Topic。  **约束限制**：  - Kafka为目标且ddl_trans为true时必填。 - 取值必须为目标库已存在的Topic名称，确保Topic已存在。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("ddl_topic", NullValueHandling = NullValueHandling.Ignore)]
        public string DdlTopic { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SyncPolicyReq {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  conflictPolicy: ").Append(ConflictPolicy).Append("\n");
            sb.Append("  filterDdlPolicy: ").Append(FilterDdlPolicy).Append("\n");
            sb.Append("  ddlTrans: ").Append(DdlTrans).Append("\n");
            sb.Append("  indexTrans: ").Append(IndexTrans).Append("\n");
            sb.Append("  topicPolicy: ").Append(TopicPolicy).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  partitionPolicy: ").Append(PartitionPolicy).Append("\n");
            sb.Append("  kafkaDataFormat: ").Append(KafkaDataFormat).Append("\n");
            sb.Append("  topicNameFormat: ").Append(TopicNameFormat).Append("\n");
            sb.Append("  partitionsNum: ").Append(PartitionsNum).Append("\n");
            sb.Append("  replicationFactor: ").Append(ReplicationFactor).Append("\n");
            sb.Append("  isFillMaterializedView: ").Append(IsFillMaterializedView).Append("\n");
            sb.Append("  exportSnapshot: ").Append(ExportSnapshot).Append("\n");
            sb.Append("  slotName: ").Append(SlotName).Append("\n");
            sb.Append("  fileAndPosition: ").Append(FileAndPosition).Append("\n");
            sb.Append("  gtidSet: ").Append(GtidSet).Append("\n");
            sb.Append("  ddlTopic: ").Append(DdlTopic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SyncPolicyReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SyncPolicyReq input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.ConflictPolicy != input.ConflictPolicy) return false;
            if (this.FilterDdlPolicy != input.FilterDdlPolicy) return false;
            if (this.DdlTrans != input.DdlTrans || (this.DdlTrans != null && !this.DdlTrans.Equals(input.DdlTrans))) return false;
            if (this.IndexTrans != input.IndexTrans || (this.IndexTrans != null && !this.IndexTrans.Equals(input.IndexTrans))) return false;
            if (this.TopicPolicy != input.TopicPolicy) return false;
            if (this.Topic != input.Topic || (this.Topic != null && !this.Topic.Equals(input.Topic))) return false;
            if (this.PartitionPolicy != input.PartitionPolicy) return false;
            if (this.KafkaDataFormat != input.KafkaDataFormat) return false;
            if (this.TopicNameFormat != input.TopicNameFormat || (this.TopicNameFormat != null && !this.TopicNameFormat.Equals(input.TopicNameFormat))) return false;
            if (this.PartitionsNum != input.PartitionsNum || (this.PartitionsNum != null && !this.PartitionsNum.Equals(input.PartitionsNum))) return false;
            if (this.ReplicationFactor != input.ReplicationFactor || (this.ReplicationFactor != null && !this.ReplicationFactor.Equals(input.ReplicationFactor))) return false;
            if (this.IsFillMaterializedView != input.IsFillMaterializedView || (this.IsFillMaterializedView != null && !this.IsFillMaterializedView.Equals(input.IsFillMaterializedView))) return false;
            if (this.ExportSnapshot != input.ExportSnapshot || (this.ExportSnapshot != null && !this.ExportSnapshot.Equals(input.ExportSnapshot))) return false;
            if (this.SlotName != input.SlotName || (this.SlotName != null && !this.SlotName.Equals(input.SlotName))) return false;
            if (this.FileAndPosition != input.FileAndPosition || (this.FileAndPosition != null && !this.FileAndPosition.Equals(input.FileAndPosition))) return false;
            if (this.GtidSet != input.GtidSet || (this.GtidSet != null && !this.GtidSet.Equals(input.GtidSet))) return false;
            if (this.DdlTopic != input.DdlTopic || (this.DdlTopic != null && !this.DdlTopic.Equals(input.DdlTopic))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                hashCode = hashCode * 59 + this.ConflictPolicy.GetHashCode();
                hashCode = hashCode * 59 + this.FilterDdlPolicy.GetHashCode();
                if (this.DdlTrans != null) hashCode = hashCode * 59 + this.DdlTrans.GetHashCode();
                if (this.IndexTrans != null) hashCode = hashCode * 59 + this.IndexTrans.GetHashCode();
                hashCode = hashCode * 59 + this.TopicPolicy.GetHashCode();
                if (this.Topic != null) hashCode = hashCode * 59 + this.Topic.GetHashCode();
                hashCode = hashCode * 59 + this.PartitionPolicy.GetHashCode();
                hashCode = hashCode * 59 + this.KafkaDataFormat.GetHashCode();
                if (this.TopicNameFormat != null) hashCode = hashCode * 59 + this.TopicNameFormat.GetHashCode();
                if (this.PartitionsNum != null) hashCode = hashCode * 59 + this.PartitionsNum.GetHashCode();
                if (this.ReplicationFactor != null) hashCode = hashCode * 59 + this.ReplicationFactor.GetHashCode();
                if (this.IsFillMaterializedView != null) hashCode = hashCode * 59 + this.IsFillMaterializedView.GetHashCode();
                if (this.ExportSnapshot != null) hashCode = hashCode * 59 + this.ExportSnapshot.GetHashCode();
                if (this.SlotName != null) hashCode = hashCode * 59 + this.SlotName.GetHashCode();
                if (this.FileAndPosition != null) hashCode = hashCode * 59 + this.FileAndPosition.GetHashCode();
                if (this.GtidSet != null) hashCode = hashCode * 59 + this.GtidSet.GetHashCode();
                if (this.DdlTopic != null) hashCode = hashCode * 59 + this.DdlTopic.GetHashCode();
                return hashCode;
            }
        }
    }
}
