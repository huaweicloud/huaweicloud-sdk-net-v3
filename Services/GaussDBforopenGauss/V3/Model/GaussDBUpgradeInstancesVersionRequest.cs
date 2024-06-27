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
    /// GaussDB批量实例版本升级接口传参参数。
    /// </summary>
    public class GaussDBUpgradeInstancesVersionRequest 
    {
        /// <summary>
        /// 实例升级类型，包括就地升级，灰度升级、热补丁升级三种
        /// </summary>
        /// <value>实例升级类型，包括就地升级，灰度升级、热补丁升级三种</value>
        [JsonConverter(typeof(EnumClassConverter<UpgradeTypeEnum>))]
        public class UpgradeTypeEnum
        {
            /// <summary>
            /// Enum INPLACE for value: inplace
            /// </summary>
            public static readonly UpgradeTypeEnum INPLACE = new UpgradeTypeEnum("inplace");

            /// <summary>
            /// Enum GREY for value: grey
            /// </summary>
            public static readonly UpgradeTypeEnum GREY = new UpgradeTypeEnum("grey");

            /// <summary>
            /// Enum HOTFIX for value: hotfix
            /// </summary>
            public static readonly UpgradeTypeEnum HOTFIX = new UpgradeTypeEnum("hotfix");

            private static readonly Dictionary<string, UpgradeTypeEnum> StaticFields =
            new Dictionary<string, UpgradeTypeEnum>()
            {
                { "inplace", INPLACE },
                { "grey", GREY },
                { "hotfix", HOTFIX },
            };

            private string _value;

            public UpgradeTypeEnum()
            {

            }

            public UpgradeTypeEnum(string value)
            {
                _value = value;
            }

            public static UpgradeTypeEnum FromValue(string value)
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

                if (this.Equals(obj as UpgradeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UpgradeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UpgradeTypeEnum a, UpgradeTypeEnum b)
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

            public static bool operator !=(UpgradeTypeEnum a, UpgradeTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 实例升级操作，就地升级无需传值。灰度升级包括升级自动提交，升级待观察，提交升级，升级回退四种。
        /// </summary>
        /// <value>实例升级操作，就地升级无需传值。灰度升级包括升级自动提交，升级待观察，提交升级，升级回退四种。</value>
        [JsonConverter(typeof(EnumClassConverter<UpgradeActionEnum>))]
        public class UpgradeActionEnum
        {
            /// <summary>
            /// Enum UPGRADEAUTOCOMMIT for value: upgradeAutoCommit
            /// </summary>
            public static readonly UpgradeActionEnum UPGRADEAUTOCOMMIT = new UpgradeActionEnum("upgradeAutoCommit");

            /// <summary>
            /// Enum UPGRADE for value: upgrade
            /// </summary>
            public static readonly UpgradeActionEnum UPGRADE = new UpgradeActionEnum("upgrade");

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
                { "upgradeAutoCommit", UPGRADEAUTOCOMMIT },
                { "upgrade", UPGRADE },
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

            public static bool operator !=(UpgradeActionEnum a, UpgradeActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 批量实例ID
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// 实例升级类型，包括就地升级，灰度升级、热补丁升级三种
        /// </summary>
        [JsonProperty("upgrade_type", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeTypeEnum UpgradeType { get; set; }
        /// <summary>
        /// 实例升级操作，就地升级无需传值。灰度升级包括升级自动提交，升级待观察，提交升级，升级回退四种。
        /// </summary>
        [JsonProperty("upgrade_action", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeActionEnum UpgradeAction { get; set; }
        /// <summary>
        /// 批量实例升级目标版本，非必填。如果未传值灰度升级和就地升级默认升级到当前实例的优选版本，热补丁升级无需传该值，默认升级实例所有可升级热补丁。
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GaussDBUpgradeInstancesVersionRequest {\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("  upgradeType: ").Append(UpgradeType).Append("\n");
            sb.Append("  upgradeAction: ").Append(UpgradeAction).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GaussDBUpgradeInstancesVersionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GaussDBUpgradeInstancesVersionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceIds == input.InstanceIds ||
                    this.InstanceIds != null &&
                    input.InstanceIds != null &&
                    this.InstanceIds.SequenceEqual(input.InstanceIds)
                ) && 
                (
                    this.UpgradeType == input.UpgradeType ||
                    (this.UpgradeType != null &&
                    this.UpgradeType.Equals(input.UpgradeType))
                ) && 
                (
                    this.UpgradeAction == input.UpgradeAction ||
                    (this.UpgradeAction != null &&
                    this.UpgradeAction.Equals(input.UpgradeAction))
                ) && 
                (
                    this.TargetVersion == input.TargetVersion ||
                    (this.TargetVersion != null &&
                    this.TargetVersion.Equals(input.TargetVersion))
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
                if (this.InstanceIds != null)
                    hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                if (this.UpgradeType != null)
                    hashCode = hashCode * 59 + this.UpgradeType.GetHashCode();
                if (this.UpgradeAction != null)
                    hashCode = hashCode * 59 + this.UpgradeAction.GetHashCode();
                if (this.TargetVersion != null)
                    hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
