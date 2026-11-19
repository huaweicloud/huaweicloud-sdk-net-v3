using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 删除/退订实例请求体。
    /// </summary>
    public class DeleteGaussMySqlInstanceRequestBody 
    {
        /// <summary>
        /// **参数解释**：  释放实例时的备份保留策略。  **约束限制**：  不涉及。  **取值范围**：  - retain_all：永久保留全部备份，包含回收站备份、自动全量备份、自动差量备份、手动备份，不包含增量备份。实例删除后，永久保留的备份会产生费用。 - retain_last：保留回收站备份和手动备份。超过回收站策略的保留天数后，系统将删除回收站备份，仅保留手动备份。手动备份会产生费用，其余保留的备份不收费。 - delete_all：删除全部备份。  **默认取值**：  retain_last。
        /// </summary>
        /// <value>**参数解释**：  释放实例时的备份保留策略。  **约束限制**：  不涉及。  **取值范围**：  - retain_all：永久保留全部备份，包含回收站备份、自动全量备份、自动差量备份、手动备份，不包含增量备份。实例删除后，永久保留的备份会产生费用。 - retain_last：保留回收站备份和手动备份。超过回收站策略的保留天数后，系统将删除回收站备份，仅保留手动备份。手动备份会产生费用，其余保留的备份不收费。 - delete_all：删除全部备份。  **默认取值**：  retain_last。</value>
        [JsonConverter(typeof(EnumClassConverter<BackupRetentionStrategyEnum>))]
        public class BackupRetentionStrategyEnum
        {
            /// <summary>
            /// Enum RETAIN_ALL for value: retain_all
            /// </summary>
            public static readonly BackupRetentionStrategyEnum RETAIN_ALL = new BackupRetentionStrategyEnum("retain_all");

            /// <summary>
            /// Enum RETAIN_LAST for value: retain_last
            /// </summary>
            public static readonly BackupRetentionStrategyEnum RETAIN_LAST = new BackupRetentionStrategyEnum("retain_last");

            /// <summary>
            /// Enum DELETE_ALL for value: delete_all
            /// </summary>
            public static readonly BackupRetentionStrategyEnum DELETE_ALL = new BackupRetentionStrategyEnum("delete_all");

            private static readonly Dictionary<string, BackupRetentionStrategyEnum> StaticFields =
            new Dictionary<string, BackupRetentionStrategyEnum>()
            {
                { "retain_all", RETAIN_ALL },
                { "retain_last", RETAIN_LAST },
                { "delete_all", DELETE_ALL },
            };

            private string _value;

            public BackupRetentionStrategyEnum()
            {

            }

            public BackupRetentionStrategyEnum(string value)
            {
                _value = value;
            }

            public static BackupRetentionStrategyEnum FromValue(string value)
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

                if (this.Equals(obj as BackupRetentionStrategyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BackupRetentionStrategyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BackupRetentionStrategyEnum a, BackupRetentionStrategyEnum b)
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

            public static bool operator !=(BackupRetentionStrategyEnum a, BackupRetentionStrategyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：  释放实例时的备份保留策略。  **约束限制**：  不涉及。  **取值范围**：  - retain_all：永久保留全部备份，包含回收站备份、自动全量备份、自动差量备份、手动备份，不包含增量备份。实例删除后，永久保留的备份会产生费用。 - retain_last：保留回收站备份和手动备份。超过回收站策略的保留天数后，系统将删除回收站备份，仅保留手动备份。手动备份会产生费用，其余保留的备份不收费。 - delete_all：删除全部备份。  **默认取值**：  retain_last。
        /// </summary>
        [JsonProperty("backup_retention_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public BackupRetentionStrategyEnum BackupRetentionStrategy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteGaussMySqlInstanceRequestBody {\n");
            sb.Append("  backupRetentionStrategy: ").Append(BackupRetentionStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteGaussMySqlInstanceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteGaussMySqlInstanceRequestBody input)
        {
            if (input == null) return false;
            if (this.BackupRetentionStrategy != input.BackupRetentionStrategy) return false;

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
                hashCode = hashCode * 59 + this.BackupRetentionStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
