using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// **参数解释**: 开启全量SQL请求体。 **取值范围**: 不涉及。
    /// </summary>
    public class FullSqlStartRequestBody 
    {
        /// <summary>
        /// **参数解释**: 存储类型。 **约束限制**: 公有云场景，只支持LTS云日志服务存储。 **取值范围**: - LTS：LTS云日志服务。  **默认取值**: 不涉及。
        /// </summary>
        /// <value>**参数解释**: 存储类型。 **约束限制**: 公有云场景，只支持LTS云日志服务存储。 **取值范围**: - LTS：LTS云日志服务。  **默认取值**: 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<StorageModeEnum>))]
        public class StorageModeEnum
        {
            /// <summary>
            /// Enum LTS for value: LTS
            /// </summary>
            public static readonly StorageModeEnum LTS = new StorageModeEnum("LTS");

            private static readonly Dictionary<string, StorageModeEnum> StaticFields =
            new Dictionary<string, StorageModeEnum>()
            {
                { "LTS", LTS },
            };

            private string _value;

            public StorageModeEnum()
            {

            }

            public StorageModeEnum(string value)
            {
                _value = value;
            }

            public static StorageModeEnum FromValue(string value)
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

                if (this.Equals(obj as StorageModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StorageModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StorageModeEnum a, StorageModeEnum b)
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

            public static bool operator !=(StorageModeEnum a, StorageModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 全量SQL采集数据最大保留天数。 **约束限制**: 不涉及。 **取值范围**: [1, 30] **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("save_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? SaveDays { get; set; }

        /// <summary>
        /// **参数解释**: 存储类型。 **约束限制**: 公有云场景，只支持LTS云日志服务存储。 **取值范围**: - LTS：LTS云日志服务。  **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("storage_mode", NullValueHandling = NullValueHandling.Ignore)]
        public StorageModeEnum StorageMode { get; set; }
        /// <summary>
        /// **参数解释**: 是否过滤系统用户。 **约束限制**: 不涉及。 **取值范围**: - true：过滤系统用户。 - false：不过滤系统用户。  **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("is_exclude_sys_user", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsExcludeSysUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lts_config", NullValueHandling = NullValueHandling.Ignore)]
        public LtsInfoOption LtsConfig { get; set; }

        /// <summary>
        /// **参数解释**: SQL采集类型列表。默认取值[]，表示采集所有SQL语句。 **约束限制**: 不涉及。
        /// </summary>
        [JsonProperty("sql_type_range", NullValueHandling = NullValueHandling.Ignore)]
        public List<SqlTypeConfigOption> SqlTypeRange { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullSqlStartRequestBody {\n");
            sb.Append("  saveDays: ").Append(SaveDays).Append("\n");
            sb.Append("  storageMode: ").Append(StorageMode).Append("\n");
            sb.Append("  isExcludeSysUser: ").Append(IsExcludeSysUser).Append("\n");
            sb.Append("  ltsConfig: ").Append(LtsConfig).Append("\n");
            sb.Append("  sqlTypeRange: ").Append(SqlTypeRange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FullSqlStartRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FullSqlStartRequestBody input)
        {
            if (input == null) return false;
            if (this.SaveDays != input.SaveDays || (this.SaveDays != null && !this.SaveDays.Equals(input.SaveDays))) return false;
            if (this.StorageMode != input.StorageMode) return false;
            if (this.IsExcludeSysUser != input.IsExcludeSysUser || (this.IsExcludeSysUser != null && !this.IsExcludeSysUser.Equals(input.IsExcludeSysUser))) return false;
            if (this.LtsConfig != input.LtsConfig || (this.LtsConfig != null && !this.LtsConfig.Equals(input.LtsConfig))) return false;
            if (this.SqlTypeRange != input.SqlTypeRange || (this.SqlTypeRange != null && input.SqlTypeRange != null && !this.SqlTypeRange.SequenceEqual(input.SqlTypeRange))) return false;

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
                if (this.SaveDays != null) hashCode = hashCode * 59 + this.SaveDays.GetHashCode();
                hashCode = hashCode * 59 + this.StorageMode.GetHashCode();
                if (this.IsExcludeSysUser != null) hashCode = hashCode * 59 + this.IsExcludeSysUser.GetHashCode();
                if (this.LtsConfig != null) hashCode = hashCode * 59 + this.LtsConfig.GetHashCode();
                if (this.SqlTypeRange != null) hashCode = hashCode * 59 + this.SqlTypeRange.GetHashCode();
                return hashCode;
            }
        }
    }
}
