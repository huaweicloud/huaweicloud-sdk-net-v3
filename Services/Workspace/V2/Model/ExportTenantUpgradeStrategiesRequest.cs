using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ExportTenantUpgradeStrategiesRequest 
    {
        /// <summary>
        /// 语言。   - zh_CN：中文 - en_US：英文
        /// </summary>
        /// <value>语言。   - zh_CN：中文 - en_US：英文</value>
        [JsonConverter(typeof(EnumClassConverter<LanguageEnum>))]
        public class LanguageEnum
        {
            /// <summary>
            /// Enum ZH_CN for value: zh_CN
            /// </summary>
            public static readonly LanguageEnum ZH_CN = new LanguageEnum("zh_CN");

            /// <summary>
            /// Enum EN_US for value: en_US
            /// </summary>
            public static readonly LanguageEnum EN_US = new LanguageEnum("en_US");

            private static readonly Dictionary<string, LanguageEnum> StaticFields =
            new Dictionary<string, LanguageEnum>()
            {
                { "zh_CN", ZH_CN },
                { "en_US", EN_US },
            };

            private string _value;

            public LanguageEnum()
            {

            }

            public LanguageEnum(string value)
            {
                _value = value;
            }

            public static LanguageEnum FromValue(string value)
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

                if (this.Equals(obj as LanguageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LanguageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LanguageEnum a, LanguageEnum b)
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

            public static bool operator !=(LanguageEnum a, LanguageEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 策略名称（支持模糊查询）
        /// </summary>
        [SDKProperty("strategy_name", IsQuery = true)]
        [JsonProperty("strategy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StrategyName { get; set; }

        /// <summary>
        /// 策略类型：0-服务端 1-客户端
        /// </summary>
        [SDKProperty("strategy_type", IsQuery = true)]
        [JsonProperty("strategy_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? StrategyType { get; set; }

        /// <summary>
        /// 是否强制升级：0-否 1-是
        /// </summary>
        [SDKProperty("is_force_upgrade", IsQuery = true)]
        [JsonProperty("is_force_upgrade", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsForceUpgrade { get; set; }

        /// <summary>
        /// 启用状态：0-禁用 1-启用
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 协议策略优先级
        /// </summary>
        [SDKProperty("strategy_priority", IsQuery = true)]
        [JsonProperty("strategy_priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? StrategyPriority { get; set; }

        /// <summary>
        /// 语言。   - zh_CN：中文 - en_US：英文
        /// </summary>
        [SDKProperty("language", IsQuery = true)]
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportTenantUpgradeStrategiesRequest {\n");
            sb.Append("  strategyName: ").Append(StrategyName).Append("\n");
            sb.Append("  strategyType: ").Append(StrategyType).Append("\n");
            sb.Append("  isForceUpgrade: ").Append(IsForceUpgrade).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  strategyPriority: ").Append(StrategyPriority).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExportTenantUpgradeStrategiesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExportTenantUpgradeStrategiesRequest input)
        {
            if (input == null) return false;
            if (this.StrategyName != input.StrategyName || (this.StrategyName != null && !this.StrategyName.Equals(input.StrategyName))) return false;
            if (this.StrategyType != input.StrategyType || (this.StrategyType != null && !this.StrategyType.Equals(input.StrategyType))) return false;
            if (this.IsForceUpgrade != input.IsForceUpgrade || (this.IsForceUpgrade != null && !this.IsForceUpgrade.Equals(input.IsForceUpgrade))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.StrategyPriority != input.StrategyPriority || (this.StrategyPriority != null && !this.StrategyPriority.Equals(input.StrategyPriority))) return false;
            if (this.Language != input.Language) return false;

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
                if (this.StrategyName != null) hashCode = hashCode * 59 + this.StrategyName.GetHashCode();
                if (this.StrategyType != null) hashCode = hashCode * 59 + this.StrategyType.GetHashCode();
                if (this.IsForceUpgrade != null) hashCode = hashCode * 59 + this.IsForceUpgrade.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StrategyPriority != null) hashCode = hashCode * 59 + this.StrategyPriority.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                return hashCode;
            }
        }
    }
}
