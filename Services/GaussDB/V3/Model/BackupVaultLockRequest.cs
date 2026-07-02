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
    /// **参数解释**：  打开或延期备份合规锁配置的请求体。  **约束限制**：  不涉及。
    /// </summary>
    public class BackupVaultLockRequest 
    {
        /// <summary>
        /// **参数解释**：  操作类型。  **约束限制**：  当前只支持开启和延期。不区分大小写。  **取值范围**： - enable：开启。 - extend：延期。  **默认取值**：  enable。
        /// </summary>
        /// <value>**参数解释**：  操作类型。  **约束限制**：  当前只支持开启和延期。不区分大小写。  **取值范围**： - enable：开启。 - extend：延期。  **默认取值**：  enable。</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum ENABLE for value: enable
            /// </summary>
            public static readonly ActionEnum ENABLE = new ActionEnum("enable");

            /// <summary>
            /// Enum EXTEND for value: extend
            /// </summary>
            public static readonly ActionEnum EXTEND = new ActionEnum("extend");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "enable", ENABLE },
                { "extend", EXTEND },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_vaultlock_info", NullValueHandling = NullValueHandling.Ignore)]
        public BackupVaultLockInfoRequest BackupVaultlockInfo { get; set; }

        /// <summary>
        /// **参数解释**：  操作类型。  **约束限制**：  当前只支持开启和延期。不区分大小写。  **取值范围**： - enable：开启。 - extend：延期。  **默认取值**：  enable。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupVaultLockRequest {\n");
            sb.Append("  backupVaultlockInfo: ").Append(BackupVaultlockInfo).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupVaultLockRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupVaultLockRequest input)
        {
            if (input == null) return false;
            if (this.BackupVaultlockInfo != input.BackupVaultlockInfo || (this.BackupVaultlockInfo != null && !this.BackupVaultlockInfo.Equals(input.BackupVaultlockInfo))) return false;
            if (this.Action != input.Action) return false;

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
                if (this.BackupVaultlockInfo != null) hashCode = hashCode * 59 + this.BackupVaultlockInfo.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                return hashCode;
            }
        }
    }
}
