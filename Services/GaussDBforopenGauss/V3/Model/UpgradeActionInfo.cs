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
    /// 升级操作信息。
    /// </summary>
    public class UpgradeActionInfo 
    {
        /// <summary>
        /// 升级操作,upgrade&#x3D;升级,upgradeAutoCommit&#x3D;升级自动提交,commit&#x3D;提交,rollback&#x3D;回滚。
        /// </summary>
        /// <value>升级操作,upgrade&#x3D;升级,upgradeAutoCommit&#x3D;升级自动提交,commit&#x3D;提交,rollback&#x3D;回滚。</value>
        [JsonConverter(typeof(EnumClassConverter<UpgradeActionEnum>))]
        public class UpgradeActionEnum
        {
            /// <summary>
            /// Enum UPGRADE for value: upgrade
            /// </summary>
            public static readonly UpgradeActionEnum UPGRADE = new UpgradeActionEnum("upgrade");

            /// <summary>
            /// Enum UPGRADEAUTOCOMMIT for value: upgradeAutoCommit
            /// </summary>
            public static readonly UpgradeActionEnum UPGRADEAUTOCOMMIT = new UpgradeActionEnum("upgradeAutoCommit");

            /// <summary>
            /// Enum COMMIT for value: commit
            /// </summary>
            public static readonly UpgradeActionEnum COMMIT = new UpgradeActionEnum("commit");

            /// <summary>
            /// Enum ROLLBACK for value: rollback
            /// </summary>
            public static readonly UpgradeActionEnum ROLLBACK = new UpgradeActionEnum("rollback");

            private static readonly Dictionary<string, UpgradeActionEnum> StaticFields =
            new Dictionary<string, UpgradeActionEnum>()
            {
                { "upgrade", UPGRADE },
                { "upgradeAutoCommit", UPGRADEAUTOCOMMIT },
                { "commit", COMMIT },
                { "rollback", ROLLBACK },
            };

            private string _value;

            public UpgradeActionEnum()
            {

            }

            public UpgradeActionEnum(string value)
            {
                _value = value;
            }

            public static UpgradeActionEnum FromValue(string value)
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

                if (this.Equals(obj as UpgradeActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UpgradeActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UpgradeActionEnum a, UpgradeActionEnum b)
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

            public static bool operator !=(UpgradeActionEnum a, UpgradeActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 升级操作,upgrade&#x3D;升级,upgradeAutoCommit&#x3D;升级自动提交,commit&#x3D;提交,rollback&#x3D;回滚。
        /// </summary>
        [JsonProperty("upgrade_action", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeActionEnum UpgradeAction { get; set; }
        /// <summary>
        /// 可用，不可用。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeActionInfo {\n");
            sb.Append("  upgradeAction: ").Append(UpgradeAction).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeActionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeActionInfo input)
        {
            if (input == null) return false;
            if (this.UpgradeAction != input.UpgradeAction) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;

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
                hashCode = hashCode * 59 + this.UpgradeAction.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                return hashCode;
            }
        }
    }
}
