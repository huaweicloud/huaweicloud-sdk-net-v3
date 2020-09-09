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
    /// Response Object
    /// </summary>
    public class ShowQueueResponse : SdkResponse
    {
        /// <summary>
        /// 队列类型。
        /// </summary>
        /// <value>队列类型。</value>
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

            public static readonly Dictionary<string, QueueModeEnum> StaticFields =
            new Dictionary<string, QueueModeEnum>()
            {
                {"NORMAL", NORMAL},
                {"FIFO", FIFO},
                {"KAFKA_HA", KAFKA_HA},
                {"KAFKA_HT", KAFKA_HT},
            };

            private string Value;

            public QueueModeEnum(string Value)
            {
                this.Value = Value;
            }

            public static QueueModeEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 该队列是否开启死信消息。仅当include_deadletter为true时，才有该响应参数。 - enable：表示开启。 - disable：表示不开启。
        /// </summary>
        /// <value>该队列是否开启死信消息。仅当include_deadletter为true时，才有该响应参数。 - enable：表示开启。 - disable：表示不开启。</value>
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

            public static readonly Dictionary<string, RedrivePolicyEnum> StaticFields =
            new Dictionary<string, RedrivePolicyEnum>()
            {
                {"enable", ENABLE},
                {"disable", DISABLE},
            };

            private string Value;

            public RedrivePolicyEnum(string Value)
            {
                this.Value = Value;
            }

            public static RedrivePolicyEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 队列ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 队列的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 创建队列的时间。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 队列的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 队列类型。
        /// </summary>
        [JsonProperty("queue_mode", NullValueHandling = NullValueHandling.Ignore)]
        public QueueModeEnum QueueMode { get; set; }
        /// <summary>
        /// 消息在队列中允许保留的时长（单位分钟）。
        /// </summary>
        [JsonProperty("reservation", NullValueHandling = NullValueHandling.Ignore)]
        public int? Reservation { get; set; }

        /// <summary>
        /// 队列中允许的最大消息大小（单位Byte）。
        /// </summary>
        [JsonProperty("max_msg_size_byte", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxMsgSizeByte { get; set; }

        /// <summary>
        /// 队列的消息总数。
        /// </summary>
        [JsonProperty("produced_messages", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProducedMessages { get; set; }

        /// <summary>
        /// 该队列是否开启死信消息。仅当include_deadletter为true时，才有该响应参数。 - enable：表示开启。 - disable：表示不开启。
        /// </summary>
        [JsonProperty("redrive_policy", NullValueHandling = NullValueHandling.Ignore)]
        public RedrivePolicyEnum RedrivePolicy { get; set; }
        /// <summary>
        /// 最大确认消费失败的次数，当达到最大确认失败次数后，DMS会将该条消息转存到死信队列中。 仅当include_deadletter为true时，才有该响应参数。
        /// </summary>
        [JsonProperty("max_consume_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxConsumeCount { get; set; }

        /// <summary>
        /// 该队列下的消费组数量。
        /// </summary>
        [JsonProperty("group_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupCount { get; set; }

        /// <summary>
        /// 仅Kafka队列才有该参数。
        /// </summary>
        [JsonProperty("kafka_topic", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaTopic { get; set; }

        /// <summary>
        /// 创建队列的时间。
        /// </summary>
        [JsonProperty("eff_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EffDate { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowQueueResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  queueMode: ").Append(QueueMode).Append("\n");
            sb.Append("  reservation: ").Append(Reservation).Append("\n");
            sb.Append("  maxMsgSizeByte: ").Append(MaxMsgSizeByte).Append("\n");
            sb.Append("  producedMessages: ").Append(ProducedMessages).Append("\n");
            sb.Append("  redrivePolicy: ").Append(RedrivePolicy).Append("\n");
            sb.Append("  maxConsumeCount: ").Append(MaxConsumeCount).Append("\n");
            sb.Append("  groupCount: ").Append(GroupCount).Append("\n");
            sb.Append("  kafkaTopic: ").Append(KafkaTopic).Append("\n");
            sb.Append("  effDate: ").Append(EffDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowQueueResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowQueueResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.QueueMode == input.QueueMode ||
                    (this.QueueMode != null &&
                    this.QueueMode.Equals(input.QueueMode))
                ) && 
                (
                    this.Reservation == input.Reservation ||
                    (this.Reservation != null &&
                    this.Reservation.Equals(input.Reservation))
                ) && 
                (
                    this.MaxMsgSizeByte == input.MaxMsgSizeByte ||
                    (this.MaxMsgSizeByte != null &&
                    this.MaxMsgSizeByte.Equals(input.MaxMsgSizeByte))
                ) && 
                (
                    this.ProducedMessages == input.ProducedMessages ||
                    (this.ProducedMessages != null &&
                    this.ProducedMessages.Equals(input.ProducedMessages))
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
                    this.GroupCount == input.GroupCount ||
                    (this.GroupCount != null &&
                    this.GroupCount.Equals(input.GroupCount))
                ) && 
                (
                    this.KafkaTopic == input.KafkaTopic ||
                    (this.KafkaTopic != null &&
                    this.KafkaTopic.Equals(input.KafkaTopic))
                ) && 
                (
                    this.EffDate == input.EffDate ||
                    (this.EffDate != null &&
                    this.EffDate.Equals(input.EffDate))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.QueueMode != null)
                    hashCode = hashCode * 59 + this.QueueMode.GetHashCode();
                if (this.Reservation != null)
                    hashCode = hashCode * 59 + this.Reservation.GetHashCode();
                if (this.MaxMsgSizeByte != null)
                    hashCode = hashCode * 59 + this.MaxMsgSizeByte.GetHashCode();
                if (this.ProducedMessages != null)
                    hashCode = hashCode * 59 + this.ProducedMessages.GetHashCode();
                if (this.RedrivePolicy != null)
                    hashCode = hashCode * 59 + this.RedrivePolicy.GetHashCode();
                if (this.MaxConsumeCount != null)
                    hashCode = hashCode * 59 + this.MaxConsumeCount.GetHashCode();
                if (this.GroupCount != null)
                    hashCode = hashCode * 59 + this.GroupCount.GetHashCode();
                if (this.KafkaTopic != null)
                    hashCode = hashCode * 59 + this.KafkaTopic.GetHashCode();
                if (this.EffDate != null)
                    hashCode = hashCode * 59 + this.EffDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
