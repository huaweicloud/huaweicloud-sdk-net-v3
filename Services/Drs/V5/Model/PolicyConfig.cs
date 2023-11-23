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
    /// 策略信息体。设置迁移、同步策略，包括冲突策略、过滤DROP Datase、对象同步范围等。
    /// </summary>
    public class PolicyConfig 
    {
        /// <summary>
        /// 过滤DDL策略。取值： - drop_database  场景区别： - 实时迁移场景：MySQL迁移可填\&quot;\&quot;，表示不过滤DROP DATABASE。 - 实时同步场景：MySQL同步只能填\&quot;drop_database\&quot;。
        /// </summary>
        /// <value>过滤DDL策略。取值： - drop_database  场景区别： - 实时迁移场景：MySQL迁移可填\&quot;\&quot;，表示不过滤DROP DATABASE。 - 实时同步场景：MySQL同步只能填\&quot;drop_database\&quot;。</value>
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
        /// 增量阶段冲突策略。该冲突策略特指增量同步中的冲突处理策略,全量阶段的冲突默认忽略。取值： - ignore：忽略。当同步数据与目标库已有数据冲突时（主键/唯一键重复等），DRS将忽略源库的冲突数据，并保留目标库中的冲突数据，继续进行后续同步。  - stop：报错。当同步数据与目标库已有数据冲突时（主键/唯一键重复等），同步任务将失败并立即中止。可在同步日志中查看详细信息。  - overwrite：覆盖。当同步数据与目标库已有数据冲突时（主键/唯一键重复等），将覆盖原来的冲突数据。  场景区别： - 实时迁移场景：不支持。 - 实时同步场景：支持。
        /// </summary>
        /// <value>增量阶段冲突策略。该冲突策略特指增量同步中的冲突处理策略,全量阶段的冲突默认忽略。取值： - ignore：忽略。当同步数据与目标库已有数据冲突时（主键/唯一键重复等），DRS将忽略源库的冲突数据，并保留目标库中的冲突数据，继续进行后续同步。  - stop：报错。当同步数据与目标库已有数据冲突时（主键/唯一键重复等），同步任务将失败并立即中止。可在同步日志中查看详细信息。  - overwrite：覆盖。当同步数据与目标库已有数据冲突时（主键/唯一键重复等），将覆盖原来的冲突数据。  场景区别： - 实时迁移场景：不支持。 - 实时同步场景：支持。</value>
        [JsonConverter(typeof(EnumClassConverter<ConflictPolicyEnum>))]
        public class ConflictPolicyEnum
        {
            /// <summary>
            /// Enum IGNORE for value: ignore
            /// </summary>
            public static readonly ConflictPolicyEnum IGNORE = new ConflictPolicyEnum("ignore");

            /// <summary>
            /// Enum STOP for value: stop
            /// </summary>
            public static readonly ConflictPolicyEnum STOP = new ConflictPolicyEnum("stop");

            /// <summary>
            /// Enum OVERWRITE for value: overwrite
            /// </summary>
            public static readonly ConflictPolicyEnum OVERWRITE = new ConflictPolicyEnum("overwrite");

            private static readonly Dictionary<string, ConflictPolicyEnum> StaticFields =
            new Dictionary<string, ConflictPolicyEnum>()
            {
                { "ignore", IGNORE },
                { "stop", STOP },
                { "overwrite", OVERWRITE },
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
        /// 数据同步拓扑。数据同步功能支持多种同步拓扑，您可以根据业务需求规划您的同步实例。参考链接。取值： - one2one：一对一。 - one2many：一对多。 - many2one：多对一。
        /// </summary>
        /// <value>数据同步拓扑。数据同步功能支持多种同步拓扑，您可以根据业务需求规划您的同步实例。参考链接。取值： - one2one：一对一。 - one2many：一对多。 - many2one：多对一。</value>
        [JsonConverter(typeof(EnumClassConverter<DataSyncTopologyTypeEnum>))]
        public class DataSyncTopologyTypeEnum
        {
            /// <summary>
            /// Enum ONE2ONE for value: one2one
            /// </summary>
            public static readonly DataSyncTopologyTypeEnum ONE2ONE = new DataSyncTopologyTypeEnum("one2one");

            /// <summary>
            /// Enum ONE2MANY for value: one2many
            /// </summary>
            public static readonly DataSyncTopologyTypeEnum ONE2MANY = new DataSyncTopologyTypeEnum("one2many");

            /// <summary>
            /// Enum MANY2ONE for value: many2one
            /// </summary>
            public static readonly DataSyncTopologyTypeEnum MANY2ONE = new DataSyncTopologyTypeEnum("many2one");

            private static readonly Dictionary<string, DataSyncTopologyTypeEnum> StaticFields =
            new Dictionary<string, DataSyncTopologyTypeEnum>()
            {
                { "one2one", ONE2ONE },
                { "one2many", ONE2MANY },
                { "many2one", MANY2ONE },
            };

            private string _value;

            public DataSyncTopologyTypeEnum()
            {

            }

            public DataSyncTopologyTypeEnum(string value)
            {
                _value = value;
            }

            public static DataSyncTopologyTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DataSyncTopologyTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DataSyncTopologyTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DataSyncTopologyTypeEnum a, DataSyncTopologyTypeEnum b)
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

            public static bool operator !=(DataSyncTopologyTypeEnum a, DataSyncTopologyTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 增量支持的DDL。取值： - \&quot;CREATE_TABLE,ADD_COLUMN,MODIFY_COLUMN,CHANGE_COLUMN,DROP_INDEX,ADD_INDEX,CREATE_INDEX,RENAME_INDEX\&quot;。 - 含义解释： - CREATE_TABLE：创建表。 - ADD_COLUMN：加列。 - MODIFY_COLUMN：改列属性。 - CHANGE_COLUMN：改列属性。 - DROP_INDEX：删除索引。 - ADD_INDEX：加索引。 - CREATE_INDEX：创建索引。 - RENAME_INDEX：重命名索引。 - 使用提示： 1.一对一，一对多场景，如果业务上认为源和目标应该使用保持严格一致，那么高危类DDL也应该勾选并同步。 2.一对一，一对多场景，如果业务上确定某个高危DDL不应该发生，则可以不勾选同步高危类DDL，这样DRS将拦截过滤这个DDL，从而起到保护目标数据的作用，但需要知晓过滤DDL的附带问题是可能导致同步失败，例如过滤删列动作。 3.多对一数据聚合场景，最佳实践是推荐只选择同步加列DDL，其他大部分DDL同步都因目标表修改而导致其他任务失败/数据不一致的情况发生，常见情况有：a、同步truncate导致目标数据全部被清空； b、同步创建索引导致目标表被锁定； c、同步rename导致其他任务找不到目标表而失败；d、同步改列导致其他任务因数据类型不兼容而失败；
        /// </summary>
        /// <value>增量支持的DDL。取值： - \&quot;CREATE_TABLE,ADD_COLUMN,MODIFY_COLUMN,CHANGE_COLUMN,DROP_INDEX,ADD_INDEX,CREATE_INDEX,RENAME_INDEX\&quot;。 - 含义解释： - CREATE_TABLE：创建表。 - ADD_COLUMN：加列。 - MODIFY_COLUMN：改列属性。 - CHANGE_COLUMN：改列属性。 - DROP_INDEX：删除索引。 - ADD_INDEX：加索引。 - CREATE_INDEX：创建索引。 - RENAME_INDEX：重命名索引。 - 使用提示： 1.一对一，一对多场景，如果业务上认为源和目标应该使用保持严格一致，那么高危类DDL也应该勾选并同步。 2.一对一，一对多场景，如果业务上确定某个高危DDL不应该发生，则可以不勾选同步高危类DDL，这样DRS将拦截过滤这个DDL，从而起到保护目标数据的作用，但需要知晓过滤DDL的附带问题是可能导致同步失败，例如过滤删列动作。 3.多对一数据聚合场景，最佳实践是推荐只选择同步加列DDL，其他大部分DDL同步都因目标表修改而导致其他任务失败/数据不一致的情况发生，常见情况有：a、同步truncate导致目标数据全部被清空； b、同步创建索引导致目标表被锁定； c、同步rename导致其他任务找不到目标表而失败；d、同步改列导致其他任务因数据类型不兼容而失败；</value>
        [JsonConverter(typeof(EnumClassConverter<SupportDdlInfoEnum>))]
        public class SupportDdlInfoEnum
        {
            /// <summary>
            /// Enum CREATE_TABLE for value: CREATE_TABLE
            /// </summary>
            public static readonly SupportDdlInfoEnum CREATE_TABLE = new SupportDdlInfoEnum("CREATE_TABLE");

            /// <summary>
            /// Enum ADD_COLUMN for value: ADD_COLUMN
            /// </summary>
            public static readonly SupportDdlInfoEnum ADD_COLUMN = new SupportDdlInfoEnum("ADD_COLUMN");

            /// <summary>
            /// Enum MODIFY_COLUMN for value: MODIFY_COLUMN
            /// </summary>
            public static readonly SupportDdlInfoEnum MODIFY_COLUMN = new SupportDdlInfoEnum("MODIFY_COLUMN");

            /// <summary>
            /// Enum CHANGE_COLUMN for value: CHANGE_COLUMN
            /// </summary>
            public static readonly SupportDdlInfoEnum CHANGE_COLUMN = new SupportDdlInfoEnum("CHANGE_COLUMN");

            /// <summary>
            /// Enum DROP_INDEX for value: DROP_INDEX
            /// </summary>
            public static readonly SupportDdlInfoEnum DROP_INDEX = new SupportDdlInfoEnum("DROP_INDEX");

            /// <summary>
            /// Enum ADD_INDEX for value: ADD_INDEX
            /// </summary>
            public static readonly SupportDdlInfoEnum ADD_INDEX = new SupportDdlInfoEnum("ADD_INDEX");

            /// <summary>
            /// Enum CREATE_INDEX for value: CREATE_INDEX
            /// </summary>
            public static readonly SupportDdlInfoEnum CREATE_INDEX = new SupportDdlInfoEnum("CREATE_INDEX");

            /// <summary>
            /// Enum RENAME_INDEX for value: RENAME_INDEX
            /// </summary>
            public static readonly SupportDdlInfoEnum RENAME_INDEX = new SupportDdlInfoEnum("RENAME_INDEX");

            private static readonly Dictionary<string, SupportDdlInfoEnum> StaticFields =
            new Dictionary<string, SupportDdlInfoEnum>()
            {
                { "CREATE_TABLE", CREATE_TABLE },
                { "ADD_COLUMN", ADD_COLUMN },
                { "MODIFY_COLUMN", MODIFY_COLUMN },
                { "CHANGE_COLUMN", CHANGE_COLUMN },
                { "DROP_INDEX", DROP_INDEX },
                { "ADD_INDEX", ADD_INDEX },
                { "CREATE_INDEX", CREATE_INDEX },
                { "RENAME_INDEX", RENAME_INDEX },
            };

            private string _value;

            public SupportDdlInfoEnum()
            {

            }

            public SupportDdlInfoEnum(string value)
            {
                _value = value;
            }

            public static SupportDdlInfoEnum FromValue(string value)
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

                if (this.Equals(obj as SupportDdlInfoEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SupportDdlInfoEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SupportDdlInfoEnum a, SupportDdlInfoEnum b)
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

            public static bool operator !=(SupportDdlInfoEnum a, SupportDdlInfoEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 过滤DDL策略。取值： - drop_database  场景区别： - 实时迁移场景：MySQL迁移可填\&quot;\&quot;，表示不过滤DROP DATABASE。 - 实时同步场景：MySQL同步只能填\&quot;drop_database\&quot;。
        /// </summary>
        [JsonProperty("filter_ddl_policy", NullValueHandling = NullValueHandling.Ignore)]
        public FilterDdlPolicyEnum FilterDdlPolicy { get; set; }
        /// <summary>
        /// 增量阶段冲突策略。该冲突策略特指增量同步中的冲突处理策略,全量阶段的冲突默认忽略。取值： - ignore：忽略。当同步数据与目标库已有数据冲突时（主键/唯一键重复等），DRS将忽略源库的冲突数据，并保留目标库中的冲突数据，继续进行后续同步。  - stop：报错。当同步数据与目标库已有数据冲突时（主键/唯一键重复等），同步任务将失败并立即中止。可在同步日志中查看详细信息。  - overwrite：覆盖。当同步数据与目标库已有数据冲突时（主键/唯一键重复等），将覆盖原来的冲突数据。  场景区别： - 实时迁移场景：不支持。 - 实时同步场景：支持。
        /// </summary>
        [JsonProperty("conflict_policy", NullValueHandling = NullValueHandling.Ignore)]
        public ConflictPolicyEnum ConflictPolicy { get; set; }
        /// <summary>
        /// 对象同步范围：是否同步普通索引。DRS将默认同步主键/唯一索引，普通索引是指除主键/唯一索引以外的其他类型索引。取值： - true：将会同步全部的索引。 - false：仅同步主键/唯一索引，普通索引不会同步。
        /// </summary>
        [JsonProperty("index_trans", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IndexTrans { get; set; }

        /// <summary>
        /// 对象同步范围：同步增量阶段是否同步DDL。取值： - true：增量阶段同步DDL。 - false：增量阶段不同步DDL。
        /// </summary>
        [JsonProperty("ddl_trans", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DdlTrans { get; set; }

        /// <summary>
        /// 数据同步拓扑。数据同步功能支持多种同步拓扑，您可以根据业务需求规划您的同步实例。参考链接。取值： - one2one：一对一。 - one2many：一对多。 - many2one：多对一。
        /// </summary>
        [JsonProperty("data_sync_topology_type", NullValueHandling = NullValueHandling.Ignore)]
        public DataSyncTopologyTypeEnum DataSyncTopologyType { get; set; }
        /// <summary>
        /// 增量支持的DDL。取值： - \&quot;CREATE_TABLE,ADD_COLUMN,MODIFY_COLUMN,CHANGE_COLUMN,DROP_INDEX,ADD_INDEX,CREATE_INDEX,RENAME_INDEX\&quot;。 - 含义解释： - CREATE_TABLE：创建表。 - ADD_COLUMN：加列。 - MODIFY_COLUMN：改列属性。 - CHANGE_COLUMN：改列属性。 - DROP_INDEX：删除索引。 - ADD_INDEX：加索引。 - CREATE_INDEX：创建索引。 - RENAME_INDEX：重命名索引。 - 使用提示： 1.一对一，一对多场景，如果业务上认为源和目标应该使用保持严格一致，那么高危类DDL也应该勾选并同步。 2.一对一，一对多场景，如果业务上确定某个高危DDL不应该发生，则可以不勾选同步高危类DDL，这样DRS将拦截过滤这个DDL，从而起到保护目标数据的作用，但需要知晓过滤DDL的附带问题是可能导致同步失败，例如过滤删列动作。 3.多对一数据聚合场景，最佳实践是推荐只选择同步加列DDL，其他大部分DDL同步都因目标表修改而导致其他任务失败/数据不一致的情况发生，常见情况有：a、同步truncate导致目标数据全部被清空； b、同步创建索引导致目标表被锁定； c、同步rename导致其他任务找不到目标表而失败；d、同步改列导致其他任务因数据类型不兼容而失败；
        /// </summary>
        [JsonProperty("support_ddl_info", NullValueHandling = NullValueHandling.Ignore)]
        public SupportDdlInfoEnum SupportDdlInfo { get; set; }
        /// <summary>
        /// 同步数据类型。取值：supportAllType（同步所有类型），tableData（同步数据），tableStructure（同步表结构），constraintData（索引同步）。 说明：除supportAllType以外，其他类型可组合填写，例如：\&quot;tableData,tableStructure\&quot; 。
        /// </summary>
        [JsonProperty("sync_type_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string SyncTypePolicy { get; set; }

        /// <summary>
        /// oracle-gausssdb增量读取方式：logminer，xstream
        /// </summary>
        [JsonProperty("increment_read_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string IncrementReadMode { get; set; }

        /// <summary>
        /// DML同步类型。
        /// </summary>
        [JsonProperty("dml_types", NullValueHandling = NullValueHandling.Ignore)]
        public string DmlTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyConfig {\n");
            sb.Append("  filterDdlPolicy: ").Append(FilterDdlPolicy).Append("\n");
            sb.Append("  conflictPolicy: ").Append(ConflictPolicy).Append("\n");
            sb.Append("  indexTrans: ").Append(IndexTrans).Append("\n");
            sb.Append("  ddlTrans: ").Append(DdlTrans).Append("\n");
            sb.Append("  dataSyncTopologyType: ").Append(DataSyncTopologyType).Append("\n");
            sb.Append("  supportDdlInfo: ").Append(SupportDdlInfo).Append("\n");
            sb.Append("  syncTypePolicy: ").Append(SyncTypePolicy).Append("\n");
            sb.Append("  incrementReadMode: ").Append(IncrementReadMode).Append("\n");
            sb.Append("  dmlTypes: ").Append(DmlTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilterDdlPolicy == input.FilterDdlPolicy ||
                    (this.FilterDdlPolicy != null &&
                    this.FilterDdlPolicy.Equals(input.FilterDdlPolicy))
                ) && 
                (
                    this.ConflictPolicy == input.ConflictPolicy ||
                    (this.ConflictPolicy != null &&
                    this.ConflictPolicy.Equals(input.ConflictPolicy))
                ) && 
                (
                    this.IndexTrans == input.IndexTrans ||
                    (this.IndexTrans != null &&
                    this.IndexTrans.Equals(input.IndexTrans))
                ) && 
                (
                    this.DdlTrans == input.DdlTrans ||
                    (this.DdlTrans != null &&
                    this.DdlTrans.Equals(input.DdlTrans))
                ) && 
                (
                    this.DataSyncTopologyType == input.DataSyncTopologyType ||
                    (this.DataSyncTopologyType != null &&
                    this.DataSyncTopologyType.Equals(input.DataSyncTopologyType))
                ) && 
                (
                    this.SupportDdlInfo == input.SupportDdlInfo ||
                    (this.SupportDdlInfo != null &&
                    this.SupportDdlInfo.Equals(input.SupportDdlInfo))
                ) && 
                (
                    this.SyncTypePolicy == input.SyncTypePolicy ||
                    (this.SyncTypePolicy != null &&
                    this.SyncTypePolicy.Equals(input.SyncTypePolicy))
                ) && 
                (
                    this.IncrementReadMode == input.IncrementReadMode ||
                    (this.IncrementReadMode != null &&
                    this.IncrementReadMode.Equals(input.IncrementReadMode))
                ) && 
                (
                    this.DmlTypes == input.DmlTypes ||
                    (this.DmlTypes != null &&
                    this.DmlTypes.Equals(input.DmlTypes))
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
                if (this.FilterDdlPolicy != null)
                    hashCode = hashCode * 59 + this.FilterDdlPolicy.GetHashCode();
                if (this.ConflictPolicy != null)
                    hashCode = hashCode * 59 + this.ConflictPolicy.GetHashCode();
                if (this.IndexTrans != null)
                    hashCode = hashCode * 59 + this.IndexTrans.GetHashCode();
                if (this.DdlTrans != null)
                    hashCode = hashCode * 59 + this.DdlTrans.GetHashCode();
                if (this.DataSyncTopologyType != null)
                    hashCode = hashCode * 59 + this.DataSyncTopologyType.GetHashCode();
                if (this.SupportDdlInfo != null)
                    hashCode = hashCode * 59 + this.SupportDdlInfo.GetHashCode();
                if (this.SyncTypePolicy != null)
                    hashCode = hashCode * 59 + this.SyncTypePolicy.GetHashCode();
                if (this.IncrementReadMode != null)
                    hashCode = hashCode * 59 + this.IncrementReadMode.GetHashCode();
                if (this.DmlTypes != null)
                    hashCode = hashCode * 59 + this.DmlTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
