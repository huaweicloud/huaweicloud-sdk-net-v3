using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateRepoNotificationSubscriptionDto 
    {
        /// <summary>
        /// **参数解释：** 配资源。
        /// </summary>
        /// <value>**参数解释：** 配资源。</value>
        [JsonConverter(typeof(EnumClassConverter<ConfigSourceEnum>))]
        public class ConfigSourceEnum
        {
            /// <summary>
            /// Enum REPO for value: repo
            /// </summary>
            public static readonly ConfigSourceEnum REPO = new ConfigSourceEnum("repo");

            /// <summary>
            /// Enum PRODUCT for value: product
            /// </summary>
            public static readonly ConfigSourceEnum PRODUCT = new ConfigSourceEnum("product");

            private static readonly Dictionary<string, ConfigSourceEnum> StaticFields =
            new Dictionary<string, ConfigSourceEnum>()
            {
                { "repo", REPO },
                { "product", PRODUCT },
            };

            private string _value;

            public ConfigSourceEnum()
            {

            }

            public ConfigSourceEnum(string value)
            {
                _value = value;
            }

            public static ConfigSourceEnum FromValue(string value)
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

                if (this.Equals(obj as ConfigSourceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConfigSourceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConfigSourceEnum a, ConfigSourceEnum b)
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

            public static bool operator !=(ConfigSourceEnum a, ConfigSourceEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 仓库使用量告警阀值（百分比）。
        /// </summary>
        /// <value>**参数解释：** 仓库使用量告警阀值（百分比）。</value>
        [JsonConverter(typeof(EnumClassConverter<WaringRepoUsageRateEnum>))]
        public class WaringRepoUsageRateEnum
        {
            /// <summary>
            /// Enum NUMBER_60 for value: 60
            /// </summary>
            public static readonly WaringRepoUsageRateEnum NUMBER_60 = new WaringRepoUsageRateEnum(60);

            /// <summary>
            /// Enum NUMBER_80 for value: 80
            /// </summary>
            public static readonly WaringRepoUsageRateEnum NUMBER_80 = new WaringRepoUsageRateEnum(80);

            /// <summary>
            /// Enum NUMBER_90 for value: 90
            /// </summary>
            public static readonly WaringRepoUsageRateEnum NUMBER_90 = new WaringRepoUsageRateEnum(90);

            private static readonly Dictionary<int?, WaringRepoUsageRateEnum> StaticFields =
            new Dictionary<int?, WaringRepoUsageRateEnum>()
            {
                { 60, NUMBER_60 },
                { 80, NUMBER_80 },
                { 90, NUMBER_90 },
            };

            private int? _value;

            public WaringRepoUsageRateEnum()
            {

            }

            public WaringRepoUsageRateEnum(int? value)
            {
                _value = value;
            }

            public static WaringRepoUsageRateEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as WaringRepoUsageRateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(WaringRepoUsageRateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(WaringRepoUsageRateEnum a, WaringRepoUsageRateEnum b)
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

            public static bool operator !=(WaringRepoUsageRateEnum a, WaringRepoUsageRateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 开启通知。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// **参数解释：** 配资源。
        /// </summary>
        [JsonProperty("config_source", NullValueHandling = NullValueHandling.Ignore)]
        public ConfigSourceEnum ConfigSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("webhook_config", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateRepoWebHookSubscriptionDto WebhookConfig { get; set; }

        /// <summary>
        /// **参数解释：** 仓库使用量告警阀值（百分比）。
        /// </summary>
        [JsonProperty("waring_repo_usage_rate", NullValueHandling = NullValueHandling.Ignore)]
        public WaringRepoUsageRateEnum WaringRepoUsageRate { get; set; }
        /// <summary>
        /// **参数解释：** 通知事件。
        /// </summary>
        [JsonProperty("subscript_events", NullValueHandling = NullValueHandling.Ignore)]
        public List<RepoSubscriptionEventDto> SubscriptEvents { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRepoNotificationSubscriptionDto {\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  configSource: ").Append(ConfigSource).Append("\n");
            sb.Append("  webhookConfig: ").Append(WebhookConfig).Append("\n");
            sb.Append("  waringRepoUsageRate: ").Append(WaringRepoUsageRate).Append("\n");
            sb.Append("  subscriptEvents: ").Append(SubscriptEvents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRepoNotificationSubscriptionDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRepoNotificationSubscriptionDto input)
        {
            if (input == null) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.ConfigSource != input.ConfigSource) return false;
            if (this.WebhookConfig != input.WebhookConfig || (this.WebhookConfig != null && !this.WebhookConfig.Equals(input.WebhookConfig))) return false;
            if (this.WaringRepoUsageRate != input.WaringRepoUsageRate) return false;
            if (this.SubscriptEvents != input.SubscriptEvents || (this.SubscriptEvents != null && input.SubscriptEvents != null && !this.SubscriptEvents.SequenceEqual(input.SubscriptEvents))) return false;

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
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                hashCode = hashCode * 59 + this.ConfigSource.GetHashCode();
                if (this.WebhookConfig != null) hashCode = hashCode * 59 + this.WebhookConfig.GetHashCode();
                hashCode = hashCode * 59 + this.WaringRepoUsageRate.GetHashCode();
                if (this.SubscriptEvents != null) hashCode = hashCode * 59 + this.SubscriptEvents.GetHashCode();
                return hashCode;
            }
        }
    }
}
