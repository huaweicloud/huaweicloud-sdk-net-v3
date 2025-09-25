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
    public class HotfixDeployMode 
    {
        /// <summary>
        /// **参数解释**： 可升级该补丁的实例部署形态。 **取值范围**： - distributed：包括独立部署，基础版混合部署。 - centralization_standard：包括主备版。
        /// </summary>
        /// <value>**参数解释**： 可升级该补丁的实例部署形态。 **取值范围**： - distributed：包括独立部署，基础版混合部署。 - centralization_standard：包括主备版。</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum CENTRALIZATION_STANDARD for value: centralization_standard
            /// </summary>
            public static readonly ModeEnum CENTRALIZATION_STANDARD = new ModeEnum("centralization_standard");

            /// <summary>
            /// Enum DISTRIBUTED for value: distributed
            /// </summary>
            public static readonly ModeEnum DISTRIBUTED = new ModeEnum("distributed");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "centralization_standard", CENTRALIZATION_STANDARD },
                { "distributed", DISTRIBUTED },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 补丁默认升级策略。 **取值范围**： - true：无需选择，默认升级该版本。 - false：用户可选，选择后升级该版本。
        /// </summary>
        [JsonProperty("default_upgrade", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultUpgrade { get; set; }

        /// <summary>
        /// **参数解释**： 热补丁升级策略的修改时间，UNIX时间戳格式，单位是毫秒。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// **参数解释**： 可升级该补丁的实例部署形态。 **取值范围**： - distributed：包括独立部署，基础版混合部署。 - centralization_standard：包括主备版。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HotfixDeployMode {\n");
            sb.Append("  defaultUpgrade: ").Append(DefaultUpgrade).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HotfixDeployMode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HotfixDeployMode input)
        {
            if (input == null) return false;
            if (this.DefaultUpgrade != input.DefaultUpgrade || (this.DefaultUpgrade != null && !this.DefaultUpgrade.Equals(input.DefaultUpgrade))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Mode != input.Mode) return false;

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
                if (this.DefaultUpgrade != null) hashCode = hashCode * 59 + this.DefaultUpgrade.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
