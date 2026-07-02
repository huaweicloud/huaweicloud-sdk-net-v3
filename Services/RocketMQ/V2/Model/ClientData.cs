using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientData 
    {
        /// <summary>
        /// **参数解释**： 消费类型。 **约束限制**： 不涉及。 **取值范围**： - CONSUME_POP：POP消费模式 - CONSUME_PASSIVELY：推消费模式 - CONSUME_ACTIVELY：拉消费模式 **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 消费类型。 **约束限制**： 不涉及。 **取值范围**： - CONSUME_POP：POP消费模式 - CONSUME_PASSIVELY：推消费模式 - CONSUME_ACTIVELY：拉消费模式 **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<ConsumeTypeEnum>))]
        public class ConsumeTypeEnum
        {
            /// <summary>
            /// Enum CONSUME_POP for value: CONSUME_POP
            /// </summary>
            public static readonly ConsumeTypeEnum CONSUME_POP = new ConsumeTypeEnum("CONSUME_POP");

            /// <summary>
            /// Enum CONSUME_PASSIVELY for value: CONSUME_PASSIVELY
            /// </summary>
            public static readonly ConsumeTypeEnum CONSUME_PASSIVELY = new ConsumeTypeEnum("CONSUME_PASSIVELY");

            /// <summary>
            /// Enum CONSUME_ACTIVELY for value: CONSUME_ACTIVELY
            /// </summary>
            public static readonly ConsumeTypeEnum CONSUME_ACTIVELY = new ConsumeTypeEnum("CONSUME_ACTIVELY");

            private static readonly Dictionary<string, ConsumeTypeEnum> StaticFields =
            new Dictionary<string, ConsumeTypeEnum>()
            {
                { "CONSUME_POP", CONSUME_POP },
                { "CONSUME_PASSIVELY", CONSUME_PASSIVELY },
                { "CONSUME_ACTIVELY", CONSUME_ACTIVELY },
            };

            private string _value;

            public ConsumeTypeEnum()
            {

            }

            public ConsumeTypeEnum(string value)
            {
                _value = value;
            }

            public static ConsumeTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ConsumeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConsumeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConsumeTypeEnum a, ConsumeTypeEnum b)
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

            public static bool operator !=(ConsumeTypeEnum a, ConsumeTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 客户端语言。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// **参数解释**： 客户端版本。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**： 客户端ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// **参数解释**： 客户端地址。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("client_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientAddr { get; set; }

        /// <summary>
        /// **参数解释**： 消费类型。 **约束限制**： 不涉及。 **取值范围**： - CONSUME_POP：POP消费模式 - CONSUME_PASSIVELY：推消费模式 - CONSUME_ACTIVELY：拉消费模式 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("consume_type", NullValueHandling = NullValueHandling.Ignore)]
        public ConsumeTypeEnum ConsumeType { get; set; }
        /// <summary>
        /// **参数解释**： 订阅关系列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Subscription> Subscriptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientData {\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  clientId: ").Append(ClientId).Append("\n");
            sb.Append("  clientAddr: ").Append(ClientAddr).Append("\n");
            sb.Append("  consumeType: ").Append(ConsumeType).Append("\n");
            sb.Append("  subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClientData input)
        {
            if (input == null) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.ClientId != input.ClientId || (this.ClientId != null && !this.ClientId.Equals(input.ClientId))) return false;
            if (this.ClientAddr != input.ClientAddr || (this.ClientAddr != null && !this.ClientAddr.Equals(input.ClientAddr))) return false;
            if (this.ConsumeType != input.ConsumeType) return false;
            if (this.Subscriptions != input.Subscriptions || (this.Subscriptions != null && input.Subscriptions != null && !this.Subscriptions.SequenceEqual(input.Subscriptions))) return false;

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
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ClientId != null) hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientAddr != null) hashCode = hashCode * 59 + this.ClientAddr.GetHashCode();
                hashCode = hashCode * 59 + this.ConsumeType.GetHashCode();
                if (this.Subscriptions != null) hashCode = hashCode * 59 + this.Subscriptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
