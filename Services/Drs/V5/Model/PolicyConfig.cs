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
        /// **参数解释**：  过滤DDL策略，指定增量同步阶段需要过滤的DDL操作类型。  **约束限制**：  - 实时迁移场景：MySQL迁移可填空，表示不过滤DROP DATABASE。 - 实时同步场景：MySQL同步只能填drop_database。  **取值范围**：  - drop_database：过滤DROP DATABASE操作  **默认取值**：  不涉及
        /// </summary>
        /// <value>**参数解释**：  过滤DDL策略，指定增量同步阶段需要过滤的DDL操作类型。  **约束限制**：  - 实时迁移场景：MySQL迁移可填空，表示不过滤DROP DATABASE。 - 实时同步场景：MySQL同步只能填drop_database。  **取值范围**：  - drop_database：过滤DROP DATABASE操作  **默认取值**：  不涉及</value>
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
        /// **参数解释**：  增量阶段冲突策略，指定当目标库已存在相同数据时的处理方式。该冲突策略特指增量同步中的冲突处理策略，全量阶段的冲突默认忽略。  **约束限制**：  - 实时迁移场景：不支持。 - 实时同步场景：支持。  **取值范围**：  - ignore：忽略，保留目标库中的冲突数据，继续进行后续同步 - stop：报错，同步任务将失败并立即中止 - overwrite：覆盖，用源库数据覆盖目标库已有数据  **默认取值**：  不涉及
        /// </summary>
        /// <value>**参数解释**：  增量阶段冲突策略，指定当目标库已存在相同数据时的处理方式。该冲突策略特指增量同步中的冲突处理策略，全量阶段的冲突默认忽略。  **约束限制**：  - 实时迁移场景：不支持。 - 实时同步场景：支持。  **取值范围**：  - ignore：忽略，保留目标库中的冲突数据，继续进行后续同步 - stop：报错，同步任务将失败并立即中止 - overwrite：覆盖，用源库数据覆盖目标库已有数据  **默认取值**：  不涉及</value>
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

            public static bool operator !=(DataSyncTopologyTypeEnum a, DataSyncTopologyTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：  增量支持的DDL，指定增量同步阶段允许同步的DDL操作类型。  **约束限制**：  不涉及。  **取值范围**：  - CREATE_TABLE：创建表 - ADD_COLUMN：加列 - MODIFY_COLUMN：改列属性 - CHANGE_COLUMN：改列属性 - DROP_INDEX：删除索引 - ADD_INDEX：加索引 - CREATE_INDEX：创建索引 - RENAME_INDEX：重命名索引  **默认取值**：  不涉及
        /// </summary>
        /// <value>**参数解释**：  增量支持的DDL，指定增量同步阶段允许同步的DDL操作类型。  **约束限制**：  不涉及。  **取值范围**：  - CREATE_TABLE：创建表 - ADD_COLUMN：加列 - MODIFY_COLUMN：改列属性 - CHANGE_COLUMN：改列属性 - DROP_INDEX：删除索引 - ADD_INDEX：加索引 - CREATE_INDEX：创建索引 - RENAME_INDEX：重命名索引  **默认取值**：  不涉及</value>
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

            public static bool operator !=(SupportDdlInfoEnum a, SupportDdlInfoEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：  过滤DDL策略，指定增量同步阶段需要过滤的DDL操作类型。  **约束限制**：  - 实时迁移场景：MySQL迁移可填空，表示不过滤DROP DATABASE。 - 实时同步场景：MySQL同步只能填drop_database。  **取值范围**：  - drop_database：过滤DROP DATABASE操作  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("filter_ddl_policy", NullValueHandling = NullValueHandling.Ignore)]
        public FilterDdlPolicyEnum FilterDdlPolicy { get; set; }
        /// <summary>
        /// **参数解释**：  增量阶段冲突策略，指定当目标库已存在相同数据时的处理方式。该冲突策略特指增量同步中的冲突处理策略，全量阶段的冲突默认忽略。  **约束限制**：  - 实时迁移场景：不支持。 - 实时同步场景：支持。  **取值范围**：  - ignore：忽略，保留目标库中的冲突数据，继续进行后续同步 - stop：报错，同步任务将失败并立即中止 - overwrite：覆盖，用源库数据覆盖目标库已有数据  **默认取值**：  不涉及
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
        /// **参数解释**：  增量支持的DDL，指定增量同步阶段允许同步的DDL操作类型。  **约束限制**：  不涉及。  **取值范围**：  - CREATE_TABLE：创建表 - ADD_COLUMN：加列 - MODIFY_COLUMN：改列属性 - CHANGE_COLUMN：改列属性 - DROP_INDEX：删除索引 - ADD_INDEX：加索引 - CREATE_INDEX：创建索引 - RENAME_INDEX：重命名索引  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("support_ddl_info", NullValueHandling = NullValueHandling.Ignore)]
        public SupportDdlInfoEnum SupportDdlInfo { get; set; }
        /// <summary>
        /// **参数解释**：  同步数据类型，指定增量同步阶段需要同步的数据类型范围。  **约束限制**：  不涉及。  **取值范围**：  - supportAllType：同步所有类型 - tableData：同步数据 - tableStructure：同步表结构 - constraintData：索引同步  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("sync_type_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string SyncTypePolicy { get; set; }

        /// <summary>
        /// **参数解释**：  Oracle-GaussDB增量读取方式，指定Oracle同步到GaussDB时增量数据的读取模式。  **约束限制**：  不涉及。  **取值范围**：  - logminer：Logminer方式 - xstream：Xstream方式  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("increment_read_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string IncrementReadMode { get; set; }

        /// <summary>
        /// **参数解释**：  DML同步类型，指定增量同步阶段需要同步的数据操作类型，包括插入、更新和删除操作。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("dml_types", NullValueHandling = NullValueHandling.Ignore)]
        public string DmlTypes { get; set; }

        /// <summary>
        /// **参数解释**：  索引与表结构是否同时建立，指定在同步过程中创建表时是否同时创建索引。  **约束限制**：  不涉及。  **取值范围**：  - true：索引与表结构同时建立 - false：索引与表结构不同时建立  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("is_create_table_with_index", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCreateTableWithIndex { get; set; }



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
            sb.Append("  isCreateTableWithIndex: ").Append(IsCreateTableWithIndex).Append("\n");
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
            if (input == null) return false;
            if (this.FilterDdlPolicy != input.FilterDdlPolicy) return false;
            if (this.ConflictPolicy != input.ConflictPolicy) return false;
            if (this.IndexTrans != input.IndexTrans || (this.IndexTrans != null && !this.IndexTrans.Equals(input.IndexTrans))) return false;
            if (this.DdlTrans != input.DdlTrans || (this.DdlTrans != null && !this.DdlTrans.Equals(input.DdlTrans))) return false;
            if (this.DataSyncTopologyType != input.DataSyncTopologyType) return false;
            if (this.SupportDdlInfo != input.SupportDdlInfo) return false;
            if (this.SyncTypePolicy != input.SyncTypePolicy || (this.SyncTypePolicy != null && !this.SyncTypePolicy.Equals(input.SyncTypePolicy))) return false;
            if (this.IncrementReadMode != input.IncrementReadMode || (this.IncrementReadMode != null && !this.IncrementReadMode.Equals(input.IncrementReadMode))) return false;
            if (this.DmlTypes != input.DmlTypes || (this.DmlTypes != null && !this.DmlTypes.Equals(input.DmlTypes))) return false;
            if (this.IsCreateTableWithIndex != input.IsCreateTableWithIndex || (this.IsCreateTableWithIndex != null && !this.IsCreateTableWithIndex.Equals(input.IsCreateTableWithIndex))) return false;

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
                hashCode = hashCode * 59 + this.FilterDdlPolicy.GetHashCode();
                hashCode = hashCode * 59 + this.ConflictPolicy.GetHashCode();
                if (this.IndexTrans != null) hashCode = hashCode * 59 + this.IndexTrans.GetHashCode();
                if (this.DdlTrans != null) hashCode = hashCode * 59 + this.DdlTrans.GetHashCode();
                hashCode = hashCode * 59 + this.DataSyncTopologyType.GetHashCode();
                hashCode = hashCode * 59 + this.SupportDdlInfo.GetHashCode();
                if (this.SyncTypePolicy != null) hashCode = hashCode * 59 + this.SyncTypePolicy.GetHashCode();
                if (this.IncrementReadMode != null) hashCode = hashCode * 59 + this.IncrementReadMode.GetHashCode();
                if (this.DmlTypes != null) hashCode = hashCode * 59 + this.DmlTypes.GetHashCode();
                if (this.IsCreateTableWithIndex != null) hashCode = hashCode * 59 + this.IsCreateTableWithIndex.GetHashCode();
                return hashCode;
            }
        }
    }
}
