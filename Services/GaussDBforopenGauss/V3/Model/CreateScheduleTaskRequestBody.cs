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
    /// 
    /// </summary>
    public class CreateScheduleTaskRequestBody 
    {
        /// <summary>
        /// 实例升级类型。
        /// </summary>
        /// <value>实例升级类型。</value>
        [JsonConverter(typeof(EnumClassConverter<UpgradeTypeEnum>))]
        public class UpgradeTypeEnum
        {
            /// <summary>
            /// Enum HOTFIX for value: hotfix
            /// </summary>
            public static readonly UpgradeTypeEnum HOTFIX = new UpgradeTypeEnum("hotfix");

            private static readonly Dictionary<string, UpgradeTypeEnum> StaticFields =
            new Dictionary<string, UpgradeTypeEnum>()
            {
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

            public static bool operator !=(UpgradeTypeEnum a, UpgradeTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 实例升级操作。
        /// </summary>
        /// <value>实例升级操作。</value>
        [JsonConverter(typeof(EnumClassConverter<UpgradeActionEnum>))]
        public class UpgradeActionEnum
        {
            /// <summary>
            /// Enum UPGRADEAUTOCOMMIT for value: upgradeAutoCommit
            /// </summary>
            public static readonly UpgradeActionEnum UPGRADEAUTOCOMMIT = new UpgradeActionEnum("upgradeAutoCommit");

            private static readonly Dictionary<string, UpgradeActionEnum> StaticFields =
            new Dictionary<string, UpgradeActionEnum>()
            {
                { "upgradeAutoCommit", UPGRADEAUTOCOMMIT },
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
        /// 实例ID列表。
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// 任务开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 实例升级类型。
        /// </summary>
        [JsonProperty("upgrade_type", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeTypeEnum UpgradeType { get; set; }
        /// <summary>
        /// 实例升级操作。
        /// </summary>
        [JsonProperty("upgrade_action", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeActionEnum UpgradeAction { get; set; }
        /// <summary>
        /// 实例升级目标版本。
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateScheduleTaskRequestBody {\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
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
            return this.Equals(input as CreateScheduleTaskRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateScheduleTaskRequestBody input)
        {
            if (input == null) return false;
            if (this.InstanceIds != input.InstanceIds || (this.InstanceIds != null && input.InstanceIds != null && !this.InstanceIds.SequenceEqual(input.InstanceIds))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.UpgradeType != input.UpgradeType) return false;
            if (this.UpgradeAction != input.UpgradeAction) return false;
            if (this.TargetVersion != input.TargetVersion || (this.TargetVersion != null && !this.TargetVersion.Equals(input.TargetVersion))) return false;

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
                if (this.InstanceIds != null) hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                hashCode = hashCode * 59 + this.UpgradeType.GetHashCode();
                hashCode = hashCode * 59 + this.UpgradeAction.GetHashCode();
                if (this.TargetVersion != null) hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
