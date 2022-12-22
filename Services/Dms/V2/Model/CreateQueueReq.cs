using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dms.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateQueueReq 
    {
        /// <summary>
        /// 队列类型。  取值范围： - NORMAL：普通队列，更高的并发性能，不保证先入先出（FIFO）的严格顺序。 - FIFO：有序队列，保证消息先入先出（FIFO）的严格顺序。 - KAFKA_HA：高可靠模式的kafka队列。消息多副本同步落盘，保证消息的可靠性。 - KAFKA_HT：高吞吐模式的kafka队列。消息副本异步落盘，具有较高的性能。  默认值：NORMAL
        /// </summary>
        /// <value>队列类型。  取值范围： - NORMAL：普通队列，更高的并发性能，不保证先入先出（FIFO）的严格顺序。 - FIFO：有序队列，保证消息先入先出（FIFO）的严格顺序。 - KAFKA_HA：高可靠模式的kafka队列。消息多副本同步落盘，保证消息的可靠性。 - KAFKA_HT：高吞吐模式的kafka队列。消息副本异步落盘，具有较高的性能。  默认值：NORMAL</value>
        [JsonConverter(typeof(EnumClassConverter<QueueModeEnum>))]
        public class QueueModeEnum
        {
            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            public static readonly QueueModeEnum NORMAL = new QueueModeEnum("NORMAL");

            /// <summary>
            /// Enum FIFO for value: FIFO
            /// </summary>
            public static readonly QueueModeEnum FIFO = new QueueModeEnum("FIFO");

            /// <summary>
            /// Enum KAFKA_HA for value: KAFKA_HA
            /// </summary>
            public static readonly QueueModeEnum KAFKA_HA = new QueueModeEnum("KAFKA_HA");

            /// <summary>
            /// Enum KAFKA_HT for value: KAFKA_HT
            /// </summary>
            public static readonly QueueModeEnum KAFKA_HT = new QueueModeEnum("KAFKA_HT");

            private static readonly Dictionary<string, QueueModeEnum> StaticFields =
            new Dictionary<string, QueueModeEnum>()
            {
                { "NORMAL", NORMAL },
                { "FIFO", FIFO },
                { "KAFKA_HA", KAFKA_HA },
                { "KAFKA_HT", KAFKA_HT },
            };

            private string _value;

            public QueueModeEnum()
            {

            }

            public QueueModeEnum(string value)
            {
                _value = value;
            }

            public static QueueModeEnum FromValue(string value)
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

                if (this.Equals(obj as QueueModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(QueueModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(QueueModeEnum a, QueueModeEnum b)
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

            public static bool operator !=(QueueModeEnum a, QueueModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 仅当queue_mode为“NORMAL”或者“FIFO”时，该参数有效。  是否开启死信消息，死信消息是指无法被正常消费的消息。  当达到最大消费次数仍然失败后，DMS会将该条消息转存到死信队列中，有效期为72小时，用户可以根据需要对死信消息进行重新消费。  消费死信消息时，只能消费该消费组产生的死信消息。  有序队列的死信消息依然按照先入先出（FIFO）的顺序存储在死信队列中。  取值范围： - enable：开启 - disable：不开启  默认值：disable
        /// </summary>
        /// <value>仅当queue_mode为“NORMAL”或者“FIFO”时，该参数有效。  是否开启死信消息，死信消息是指无法被正常消费的消息。  当达到最大消费次数仍然失败后，DMS会将该条消息转存到死信队列中，有效期为72小时，用户可以根据需要对死信消息进行重新消费。  消费死信消息时，只能消费该消费组产生的死信消息。  有序队列的死信消息依然按照先入先出（FIFO）的顺序存储在死信队列中。  取值范围： - enable：开启 - disable：不开启  默认值：disable</value>
        [JsonConverter(typeof(EnumClassConverter<RedrivePolicyEnum>))]
        public class RedrivePolicyEnum
        {
            /// <summary>
            /// Enum ENABLE for value: enable
            /// </summary>
            public static readonly RedrivePolicyEnum ENABLE = new RedrivePolicyEnum("enable");

            /// <summary>
            /// Enum DISABLE for value: disable
            /// </summary>
            public static readonly RedrivePolicyEnum DISABLE = new RedrivePolicyEnum("disable");

            private static readonly Dictionary<string, RedrivePolicyEnum> StaticFields =
            new Dictionary<string, RedrivePolicyEnum>()
            {
                { "enable", ENABLE },
                { "disable", DISABLE },
            };

            private string _value;

            public RedrivePolicyEnum()
            {

            }

            public RedrivePolicyEnum(string value)
            {
                _value = value;
            }

            public static RedrivePolicyEnum FromValue(string value)
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

                if (this.Equals(obj as RedrivePolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RedrivePolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RedrivePolicyEnum a, RedrivePolicyEnum b)
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

            public static bool operator !=(RedrivePolicyEnum a, RedrivePolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 队列的名称，必须唯一。  长度不超过64位的字符串，包含a~z，A~Z，0~9、中划线（-）和下划线（_）。  创建队列后无法修改名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 队列类型。  取值范围： - NORMAL：普通队列，更高的并发性能，不保证先入先出（FIFO）的严格顺序。 - FIFO：有序队列，保证消息先入先出（FIFO）的严格顺序。 - KAFKA_HA：高可靠模式的kafka队列。消息多副本同步落盘，保证消息的可靠性。 - KAFKA_HT：高吞吐模式的kafka队列。消息副本异步落盘，具有较高的性能。  默认值：NORMAL
        /// </summary>
        [JsonProperty("queue_mode", NullValueHandling = NullValueHandling.Ignore)]
        public QueueModeEnum QueueMode { get; set; }
        /// <summary>
        /// 队列的描述信息。  长度不超过160位的字符串，不能包含尖括号&lt;&gt;。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 仅当queue_mode为“NORMAL”或者“FIFO”时，该参数有效。  是否开启死信消息，死信消息是指无法被正常消费的消息。  当达到最大消费次数仍然失败后，DMS会将该条消息转存到死信队列中，有效期为72小时，用户可以根据需要对死信消息进行重新消费。  消费死信消息时，只能消费该消费组产生的死信消息。  有序队列的死信消息依然按照先入先出（FIFO）的顺序存储在死信队列中。  取值范围： - enable：开启 - disable：不开启  默认值：disable
        /// </summary>
        [JsonProperty("redrive_policy", NullValueHandling = NullValueHandling.Ignore)]
        public RedrivePolicyEnum RedrivePolicy { get; set; }
        /// <summary>
        /// 仅当redrive_policy为enable时，该参数必选。  最大确认消费失败的次数，当达到最大确认失败次数后，DMS会将该条消息转存到死信队列中。  取值范围：1~100
        /// </summary>
        [JsonProperty("max_consume_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxConsumeCount { get; set; }

        /// <summary>
        /// 指定kafka队列的消息保存时间，单位为小时。  仅当queue_mode为KAFKA_HA或者KAFKA_HT才有效。  取值范围: 1-72（小时）
        /// </summary>
        [JsonProperty("retention_hours", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionHours { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateQueueReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  queueMode: ").Append(QueueMode).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  redrivePolicy: ").Append(RedrivePolicy).Append("\n");
            sb.Append("  maxConsumeCount: ").Append(MaxConsumeCount).Append("\n");
            sb.Append("  retentionHours: ").Append(RetentionHours).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateQueueReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateQueueReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.QueueMode == input.QueueMode ||
                    (this.QueueMode != null &&
                    this.QueueMode.Equals(input.QueueMode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.RedrivePolicy == input.RedrivePolicy ||
                    (this.RedrivePolicy != null &&
                    this.RedrivePolicy.Equals(input.RedrivePolicy))
                ) && 
                (
                    this.MaxConsumeCount == input.MaxConsumeCount ||
                    (this.MaxConsumeCount != null &&
                    this.MaxConsumeCount.Equals(input.MaxConsumeCount))
                ) && 
                (
                    this.RetentionHours == input.RetentionHours ||
                    (this.RetentionHours != null &&
                    this.RetentionHours.Equals(input.RetentionHours))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.QueueMode != null)
                    hashCode = hashCode * 59 + this.QueueMode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RedrivePolicy != null)
                    hashCode = hashCode * 59 + this.RedrivePolicy.GetHashCode();
                if (this.MaxConsumeCount != null)
                    hashCode = hashCode * 59 + this.MaxConsumeCount.GetHashCode();
                if (this.RetentionHours != null)
                    hashCode = hashCode * 59 + this.RetentionHours.GetHashCode();
                return hashCode;
            }
        }
    }
}
