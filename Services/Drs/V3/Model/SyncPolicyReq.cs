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
        /// 冲突策略。 - ignore：忽略 - overwrite：覆盖 - stop：报错
        /// </summary>
        /// <value>冲突策略。 - ignore：忽略 - overwrite：覆盖 - stop：报错</value>
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
        /// 过滤DDL策略。
        /// </summary>
        /// <value>过滤DDL策略。</value>
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

            public static bool operator !=(FilterDdlPolicyEnum a, FilterDdlPolicyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 同步Topic策略，目标库为kafka时必填，取值： - 0：集中投递到一个Topic - 1：按库名-schema-表名自动生成Topic名字 - 2：按库名自动生成Topic名字 - 3：按库名-schema自动生成Topic名字
        /// </summary>
        /// <value>同步Topic策略，目标库为kafka时必填，取值： - 0：集中投递到一个Topic - 1：按库名-schema-表名自动生成Topic名字 - 2：按库名自动生成Topic名字 - 3：按库名-schema自动生成Topic名字</value>
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

            public static bool operator !=(TopicPolicyEnum a, TopicPolicyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 同步到kafka partition策略，取值： - 0：按库名.schema.表名的hash值投递到不同Partition - 1：全部投递到Partition 0 - 2：按主键的hash值投递到不同Partition - 3：按库名.schema的hash值投递到不同Partition **当topic_policy取0时，可以取0,1,2,3；当topic_policy取1时，可以取1,2；当topic_policy取2时，可以取0,1,3；当topic_policy取3时，可以取0,1；**
        /// </summary>
        /// <value>同步到kafka partition策略，取值： - 0：按库名.schema.表名的hash值投递到不同Partition - 1：全部投递到Partition 0 - 2：按主键的hash值投递到不同Partition - 3：按库名.schema的hash值投递到不同Partition **当topic_policy取0时，可以取0,1,2,3；当topic_policy取1时，可以取1,2；当topic_policy取2时，可以取0,1,3；当topic_policy取3时，可以取0,1；**</value>
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

            public static bool operator !=(PartitionPolicyEnum a, PartitionPolicyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 投送到kafka的数据格式，不填默认为json：
        /// </summary>
        /// <value>投送到kafka的数据格式，不填默认为json：</value>
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

            public static bool operator !=(KafkaDataFormatEnum a, KafkaDataFormatEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 冲突策略。 - ignore：忽略 - overwrite：覆盖 - stop：报错
        /// </summary>
        [JsonProperty("conflict_policy", NullValueHandling = NullValueHandling.Ignore)]
        public ConflictPolicyEnum ConflictPolicy { get; set; }
        /// <summary>
        /// 过滤DDL策略。
        /// </summary>
        [JsonProperty("filter_ddl_policy", NullValueHandling = NullValueHandling.Ignore)]
        public FilterDdlPolicyEnum FilterDdlPolicy { get; set; }
        /// <summary>
        /// 同步增量是否同步DDL。
        /// </summary>
        [JsonProperty("ddl_trans", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DdlTrans { get; set; }

        /// <summary>
        /// 同步增量是否同步索引。
        /// </summary>
        [JsonProperty("index_trans", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IndexTrans { get; set; }

        /// <summary>
        /// 同步Topic策略，目标库为kafka时必填，取值： - 0：集中投递到一个Topic - 1：按库名-schema-表名自动生成Topic名字 - 2：按库名自动生成Topic名字 - 3：按库名-schema自动生成Topic名字
        /// </summary>
        [JsonProperty("topic_policy", NullValueHandling = NullValueHandling.Ignore)]
        public TopicPolicyEnum TopicPolicy { get; set; }
        /// <summary>
        /// Topic名称，topic_policy为0时必填，确保topic已存在。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 同步到kafka partition策略，取值： - 0：按库名.schema.表名的hash值投递到不同Partition - 1：全部投递到Partition 0 - 2：按主键的hash值投递到不同Partition - 3：按库名.schema的hash值投递到不同Partition **当topic_policy取0时，可以取0,1,2,3；当topic_policy取1时，可以取1,2；当topic_policy取2时，可以取0,1,3；当topic_policy取3时，可以取0,1；**
        /// </summary>
        [JsonProperty("partition_policy", NullValueHandling = NullValueHandling.Ignore)]
        public PartitionPolicyEnum PartitionPolicy { get; set; }
        /// <summary>
        /// 投送到kafka的数据格式，不填默认为json：
        /// </summary>
        [JsonProperty("kafka_data_format", NullValueHandling = NullValueHandling.Ignore)]
        public KafkaDataFormatEnum KafkaDataFormat { get; set; }
        /// <summary>
        /// Topic名字格式，topic_policy为1,2,3,时需要 - 当topic_policy取1时，Topic名字格式支持database、schema两个变量，其他字符当做常量。分别用$database$代替数据库名，$schema$代替模式名，不填默认为$database$-$schema$ - 当topic_policy取2时，Topic名字格式支持database一个变量，其他字符都当做常量，不填默认为$database$ - 当topic_policy取3时，Topic名字格式支持database、schema和tablename三个变量，其他字符当做常量。分别用$database$代替数据库名，$schema$代替模式名，$tablename$代替表名，不填默认为$database$-$schema$-$tablename$
        /// </summary>
        [JsonProperty("topic_name_format", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicNameFormat { get; set; }

        /// <summary>
        /// Partition个数，取值1-2147483647之间，topic_policy为1,2,3,时需要，不填默认为1
        /// </summary>
        [JsonProperty("partitions_num", NullValueHandling = NullValueHandling.Ignore)]
        public string PartitionsNum { get; set; }

        /// <summary>
        /// 副本个数，取值1-32767之间，topic_policy为1,2,3,时需要，不填默认为1
        /// </summary>
        [JsonProperty("replication_factor", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicationFactor { get; set; }

        /// <summary>
        /// PostgreSQL同步全量阶段是否填充物化视图，不填默认为false
        /// </summary>
        [JsonProperty("is_fill_materialized_view", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFillMaterializedView { get; set; }

        /// <summary>
        /// PostgreSQL同步全量阶段是否使用快照模式导出，不填默认为false
        /// </summary>
        [JsonProperty("export_snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExportSnapshot { get; set; }

        /// <summary>
        /// 复制槽名称，gaussdbv5ha-to-kafka主备任务必填
        /// </summary>
        [JsonProperty("slot_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SlotName { get; set; }

        /// <summary>
        /// - MySQL为源通过show master status命令获取源库位点，根据提示分别填写File:Position。例如：mysql-bin.000277:805 文件名只能为1-60个字符且不能包含&lt; &gt; &amp; : \&quot; \\&#39; / \\\\\\\\ 特殊字符，文件编号只能为3-20个数字，binlog事件位置只能为1-20个数字，且总长度不能超过100个字符。格式为：文件名.文件编号:事件位点 - MongoDB为源的任务，任务的源库日志从位点开始获取（含当前启动位点），位点需设置在oplog范围以内。非集群通过db.getReplicationInfo()直接获得oplog范围，集群通过db.watch([], {startAtOperationTime: Timestamp(xx, xx)})命令，将启动位点填在xx处，校验位点是否在oplog范围以内。格式为：timestamp:incre。timestamp和incre均为范围在1~2,147,483,647之间的整数。
        /// </summary>
        [JsonProperty("file_and_position", NullValueHandling = NullValueHandling.Ignore)]
        public string FileAndPosition { get; set; }

        /// <summary>
        /// - MySQL为源的任务需要，通过show master status命令获取源库位点，根据提示填写Executed_Gtid_Set（如果源库为MySQL 5.5版本，则不支持使用同步任务）。  - 不能包含&lt; &gt; &amp; \&quot; \\&#39; / \\\\\\\\ 特殊字符和中文。且不能超过2048个字符
        /// </summary>
        [JsonProperty("gtid_set", NullValueHandling = NullValueHandling.Ignore)]
        public string GtidSet { get; set; }



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
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.ConflictPolicy == input.ConflictPolicy ||
                    (this.ConflictPolicy != null &&
                    this.ConflictPolicy.Equals(input.ConflictPolicy))
                ) && 
                (
                    this.FilterDdlPolicy == input.FilterDdlPolicy ||
                    (this.FilterDdlPolicy != null &&
                    this.FilterDdlPolicy.Equals(input.FilterDdlPolicy))
                ) && 
                (
                    this.DdlTrans == input.DdlTrans ||
                    (this.DdlTrans != null &&
                    this.DdlTrans.Equals(input.DdlTrans))
                ) && 
                (
                    this.IndexTrans == input.IndexTrans ||
                    (this.IndexTrans != null &&
                    this.IndexTrans.Equals(input.IndexTrans))
                ) && 
                (
                    this.TopicPolicy == input.TopicPolicy ||
                    (this.TopicPolicy != null &&
                    this.TopicPolicy.Equals(input.TopicPolicy))
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.PartitionPolicy == input.PartitionPolicy ||
                    (this.PartitionPolicy != null &&
                    this.PartitionPolicy.Equals(input.PartitionPolicy))
                ) && 
                (
                    this.KafkaDataFormat == input.KafkaDataFormat ||
                    (this.KafkaDataFormat != null &&
                    this.KafkaDataFormat.Equals(input.KafkaDataFormat))
                ) && 
                (
                    this.TopicNameFormat == input.TopicNameFormat ||
                    (this.TopicNameFormat != null &&
                    this.TopicNameFormat.Equals(input.TopicNameFormat))
                ) && 
                (
                    this.PartitionsNum == input.PartitionsNum ||
                    (this.PartitionsNum != null &&
                    this.PartitionsNum.Equals(input.PartitionsNum))
                ) && 
                (
                    this.ReplicationFactor == input.ReplicationFactor ||
                    (this.ReplicationFactor != null &&
                    this.ReplicationFactor.Equals(input.ReplicationFactor))
                ) && 
                (
                    this.IsFillMaterializedView == input.IsFillMaterializedView ||
                    (this.IsFillMaterializedView != null &&
                    this.IsFillMaterializedView.Equals(input.IsFillMaterializedView))
                ) && 
                (
                    this.ExportSnapshot == input.ExportSnapshot ||
                    (this.ExportSnapshot != null &&
                    this.ExportSnapshot.Equals(input.ExportSnapshot))
                ) && 
                (
                    this.SlotName == input.SlotName ||
                    (this.SlotName != null &&
                    this.SlotName.Equals(input.SlotName))
                ) && 
                (
                    this.FileAndPosition == input.FileAndPosition ||
                    (this.FileAndPosition != null &&
                    this.FileAndPosition.Equals(input.FileAndPosition))
                ) && 
                (
                    this.GtidSet == input.GtidSet ||
                    (this.GtidSet != null &&
                    this.GtidSet.Equals(input.GtidSet))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ConflictPolicy != null)
                    hashCode = hashCode * 59 + this.ConflictPolicy.GetHashCode();
                if (this.FilterDdlPolicy != null)
                    hashCode = hashCode * 59 + this.FilterDdlPolicy.GetHashCode();
                if (this.DdlTrans != null)
                    hashCode = hashCode * 59 + this.DdlTrans.GetHashCode();
                if (this.IndexTrans != null)
                    hashCode = hashCode * 59 + this.IndexTrans.GetHashCode();
                if (this.TopicPolicy != null)
                    hashCode = hashCode * 59 + this.TopicPolicy.GetHashCode();
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.PartitionPolicy != null)
                    hashCode = hashCode * 59 + this.PartitionPolicy.GetHashCode();
                if (this.KafkaDataFormat != null)
                    hashCode = hashCode * 59 + this.KafkaDataFormat.GetHashCode();
                if (this.TopicNameFormat != null)
                    hashCode = hashCode * 59 + this.TopicNameFormat.GetHashCode();
                if (this.PartitionsNum != null)
                    hashCode = hashCode * 59 + this.PartitionsNum.GetHashCode();
                if (this.ReplicationFactor != null)
                    hashCode = hashCode * 59 + this.ReplicationFactor.GetHashCode();
                if (this.IsFillMaterializedView != null)
                    hashCode = hashCode * 59 + this.IsFillMaterializedView.GetHashCode();
                if (this.ExportSnapshot != null)
                    hashCode = hashCode * 59 + this.ExportSnapshot.GetHashCode();
                if (this.SlotName != null)
                    hashCode = hashCode * 59 + this.SlotName.GetHashCode();
                if (this.FileAndPosition != null)
                    hashCode = hashCode * 59 + this.FileAndPosition.GetHashCode();
                if (this.GtidSet != null)
                    hashCode = hashCode * 59 + this.GtidSet.GetHashCode();
                return hashCode;
            }
        }
    }
}
