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
    /// 备份迁移参数。
    /// </summary>
    public class BackupRestoreOptionInfo 
    {
        /// <summary>
        /// 恢复模式：  “full”表示全量迁移。  “incre”表示增量迁移 。
        /// </summary>
        /// <value>恢复模式：  “full”表示全量迁移。  “incre”表示增量迁移 。</value>
        [JsonConverter(typeof(EnumClassConverter<RecoveryModeEnum>))]
        public class RecoveryModeEnum
        {
            /// <summary>
            /// Enum FULL for value: full
            /// </summary>
            public static readonly RecoveryModeEnum FULL = new RecoveryModeEnum("full");

            /// <summary>
            /// Enum INCRE for value: incre
            /// </summary>
            public static readonly RecoveryModeEnum INCRE = new RecoveryModeEnum("incre");

            private static readonly Dictionary<string, RecoveryModeEnum> StaticFields =
            new Dictionary<string, RecoveryModeEnum>()
            {
                { "full", FULL },
                { "incre", INCRE },
            };

            private string _value;

            public RecoveryModeEnum()
            {

            }

            public RecoveryModeEnum(string value)
            {
                _value = value;
            }

            public static RecoveryModeEnum FromValue(string value)
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

                if (this.Equals(obj as RecoveryModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecoveryModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RecoveryModeEnum a, RecoveryModeEnum b)
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

            public static bool operator !=(RecoveryModeEnum a, RecoveryModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否覆盖目标数据库，不填默认为false。  值为“true”表示覆盖。  值为“false”表示不覆盖。
        /// </summary>
        [JsonProperty("is_cover", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCover { get; set; }

        /// <summary>
        /// 是否默认恢复，默认恢复所有数据库。  “true”是代表默认恢复还原备份文件中的全部数据库。  “false”代表需要在db_names这个字段中指定需要恢复的数据库名。
        /// </summary>
        [JsonProperty("is_default_restore", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefaultRestore { get; set; }

        /// <summary>
        /// 一次典型的增量恢复过程，会涉及多次恢复增量备份。每个增量备份恢复均会使目标数据库保持还原中状态，此时数据库不可读写，直至最后一个增量备份恢复完成后，数据库才能变成可用状态。此后数据库将无法继续进行增量恢复，所以确定为最后一个备份的场景有：  一次性全量迁移，后续将不再进行增量恢复时，设置该字段值为“true”。  增量恢复流程中，确定为最后割接阶段的最后一个增量备份时，设置该字段值为“false”。
        /// </summary>
        [JsonProperty("is_last_backup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLastBackup { get; set; }

        /// <summary>
        /// 是否执行预校验。 true：执行。 false：不执行。
        /// </summary>
        [JsonProperty("is_precheck", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPrecheck { get; set; }

        /// <summary>
        /// 恢复模式：  “full”表示全量迁移。  “incre”表示增量迁移 。
        /// </summary>
        [JsonProperty("recovery_mode", NullValueHandling = NullValueHandling.Ignore)]
        public RecoveryModeEnum RecoveryMode { get; set; }
        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("db_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DbNames { get; set; }

        /// <summary>
        /// 该字段为一个map，目前使用格式key是\&quot;\&quot;，value是新数据库名字。 该功能将忽略备份文件中原有的数据库名，通过DRS将其恢复为指定的新数据库名。 使用条件： - 备份文件中只有一个数据库。 - 备份文件是全量备份类型（待恢复备份类型选择：全量备份），且是一次性恢复（最后一个备份选择：是）。
        /// </summary>
        [JsonProperty("reset_db_name_map", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ResetDbNameMap { get; set; }

        /// <summary>
        /// 该参数控制使用OBS桶中备份文件恢复时，当任务结束时是否删除下载到RDS for SQL server磁盘中的OBS备份文件，默认删除。 - true 删除 - false 不删除
        /// </summary>
        [JsonProperty("is_delete_backup_file", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDeleteBackupFile { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupRestoreOptionInfo {\n");
            sb.Append("  isCover: ").Append(IsCover).Append("\n");
            sb.Append("  isDefaultRestore: ").Append(IsDefaultRestore).Append("\n");
            sb.Append("  isLastBackup: ").Append(IsLastBackup).Append("\n");
            sb.Append("  isPrecheck: ").Append(IsPrecheck).Append("\n");
            sb.Append("  recoveryMode: ").Append(RecoveryMode).Append("\n");
            sb.Append("  dbNames: ").Append(DbNames).Append("\n");
            sb.Append("  resetDbNameMap: ").Append(ResetDbNameMap).Append("\n");
            sb.Append("  isDeleteBackupFile: ").Append(IsDeleteBackupFile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupRestoreOptionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupRestoreOptionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsCover == input.IsCover ||
                    (this.IsCover != null &&
                    this.IsCover.Equals(input.IsCover))
                ) && 
                (
                    this.IsDefaultRestore == input.IsDefaultRestore ||
                    (this.IsDefaultRestore != null &&
                    this.IsDefaultRestore.Equals(input.IsDefaultRestore))
                ) && 
                (
                    this.IsLastBackup == input.IsLastBackup ||
                    (this.IsLastBackup != null &&
                    this.IsLastBackup.Equals(input.IsLastBackup))
                ) && 
                (
                    this.IsPrecheck == input.IsPrecheck ||
                    (this.IsPrecheck != null &&
                    this.IsPrecheck.Equals(input.IsPrecheck))
                ) && 
                (
                    this.RecoveryMode == input.RecoveryMode ||
                    (this.RecoveryMode != null &&
                    this.RecoveryMode.Equals(input.RecoveryMode))
                ) && 
                (
                    this.DbNames == input.DbNames ||
                    this.DbNames != null &&
                    input.DbNames != null &&
                    this.DbNames.SequenceEqual(input.DbNames)
                ) && 
                (
                    this.ResetDbNameMap == input.ResetDbNameMap ||
                    this.ResetDbNameMap != null &&
                    input.ResetDbNameMap != null &&
                    this.ResetDbNameMap.SequenceEqual(input.ResetDbNameMap)
                ) && 
                (
                    this.IsDeleteBackupFile == input.IsDeleteBackupFile ||
                    (this.IsDeleteBackupFile != null &&
                    this.IsDeleteBackupFile.Equals(input.IsDeleteBackupFile))
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
                if (this.IsCover != null)
                    hashCode = hashCode * 59 + this.IsCover.GetHashCode();
                if (this.IsDefaultRestore != null)
                    hashCode = hashCode * 59 + this.IsDefaultRestore.GetHashCode();
                if (this.IsLastBackup != null)
                    hashCode = hashCode * 59 + this.IsLastBackup.GetHashCode();
                if (this.IsPrecheck != null)
                    hashCode = hashCode * 59 + this.IsPrecheck.GetHashCode();
                if (this.RecoveryMode != null)
                    hashCode = hashCode * 59 + this.RecoveryMode.GetHashCode();
                if (this.DbNames != null)
                    hashCode = hashCode * 59 + this.DbNames.GetHashCode();
                if (this.ResetDbNameMap != null)
                    hashCode = hashCode * 59 + this.ResetDbNameMap.GetHashCode();
                if (this.IsDeleteBackupFile != null)
                    hashCode = hashCode * 59 + this.IsDeleteBackupFile.GetHashCode();
                return hashCode;
            }
        }
    }
}
