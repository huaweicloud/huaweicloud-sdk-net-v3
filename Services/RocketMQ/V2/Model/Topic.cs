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
    public class Topic 
    {
        /// <summary>
        /// 权限。
        /// </summary>
        /// <value>权限。</value>
        [JsonConverter(typeof(EnumClassConverter<PermissionEnum>))]
        public class PermissionEnum
        {
            /// <summary>
            /// Enum SUB for value: sub
            /// </summary>
            public static readonly PermissionEnum SUB = new PermissionEnum("sub");

            /// <summary>
            /// Enum PUB for value: pub
            /// </summary>
            public static readonly PermissionEnum PUB = new PermissionEnum("pub");

            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly PermissionEnum ALL = new PermissionEnum("all");

            private static readonly Dictionary<string, PermissionEnum> StaticFields =
            new Dictionary<string, PermissionEnum>()
            {
                { "sub", SUB },
                { "pub", PUB },
                { "all", ALL },
            };

            private string _value;

            public PermissionEnum()
            {

            }

            public PermissionEnum(string value)
            {
                _value = value;
            }

            public static PermissionEnum FromValue(string value)
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

                if (this.Equals(obj as PermissionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PermissionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PermissionEnum a, PermissionEnum b)
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

            public static bool operator !=(PermissionEnum a, PermissionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 消息类型（RocketMQ实例5.x版本才包含此参数）。
        /// </summary>
        /// <value>消息类型（RocketMQ实例5.x版本才包含此参数）。</value>
        [JsonConverter(typeof(EnumClassConverter<MessageTypeEnum>))]
        public class MessageTypeEnum
        {
            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            public static readonly MessageTypeEnum NORMAL = new MessageTypeEnum("NORMAL");

            /// <summary>
            /// Enum FIFO for value: FIFO
            /// </summary>
            public static readonly MessageTypeEnum FIFO = new MessageTypeEnum("FIFO");

            /// <summary>
            /// Enum DELAY for value: DELAY
            /// </summary>
            public static readonly MessageTypeEnum DELAY = new MessageTypeEnum("DELAY");

            /// <summary>
            /// Enum TRANSACTION for value: TRANSACTION
            /// </summary>
            public static readonly MessageTypeEnum TRANSACTION = new MessageTypeEnum("TRANSACTION");

            private static readonly Dictionary<string, MessageTypeEnum> StaticFields =
            new Dictionary<string, MessageTypeEnum>()
            {
                { "NORMAL", NORMAL },
                { "FIFO", FIFO },
                { "DELAY", DELAY },
                { "TRANSACTION", TRANSACTION },
            };

            private string _value;

            public MessageTypeEnum()
            {

            }

            public MessageTypeEnum(string value)
            {
                _value = value;
            }

            public static MessageTypeEnum FromValue(string value)
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

                if (this.Equals(obj as MessageTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MessageTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MessageTypeEnum a, MessageTypeEnum b)
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

            public static bool operator !=(MessageTypeEnum a, MessageTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Topic名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 总读队列个数。
        /// </summary>
        [JsonProperty("total_read_queue_num", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TotalReadQueueNum { get; set; }

        /// <summary>
        /// 总写队列个数。
        /// </summary>
        [JsonProperty("total_write_queue_num", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TotalWriteQueueNum { get; set; }

        /// <summary>
        /// 权限。
        /// </summary>
        [JsonProperty("permission", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionEnum Permission { get; set; }
        /// <summary>
        /// 关联的代理。
        /// </summary>
        [JsonProperty("brokers", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopicBrokers> Brokers { get; set; }

        /// <summary>
        /// 消息类型（RocketMQ实例5.x版本才包含此参数）。
        /// </summary>
        [JsonProperty("message_type", NullValueHandling = NullValueHandling.Ignore)]
        public MessageTypeEnum MessageType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Topic {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  totalReadQueueNum: ").Append(TotalReadQueueNum).Append("\n");
            sb.Append("  totalWriteQueueNum: ").Append(TotalWriteQueueNum).Append("\n");
            sb.Append("  permission: ").Append(Permission).Append("\n");
            sb.Append("  brokers: ").Append(Brokers).Append("\n");
            sb.Append("  messageType: ").Append(MessageType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Topic);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Topic input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.TotalReadQueueNum != input.TotalReadQueueNum || (this.TotalReadQueueNum != null && !this.TotalReadQueueNum.Equals(input.TotalReadQueueNum))) return false;
            if (this.TotalWriteQueueNum != input.TotalWriteQueueNum || (this.TotalWriteQueueNum != null && !this.TotalWriteQueueNum.Equals(input.TotalWriteQueueNum))) return false;
            if (this.Permission != input.Permission) return false;
            if (this.Brokers != input.Brokers || (this.Brokers != null && input.Brokers != null && !this.Brokers.SequenceEqual(input.Brokers))) return false;
            if (this.MessageType != input.MessageType) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TotalReadQueueNum != null) hashCode = hashCode * 59 + this.TotalReadQueueNum.GetHashCode();
                if (this.TotalWriteQueueNum != null) hashCode = hashCode * 59 + this.TotalWriteQueueNum.GetHashCode();
                hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.Brokers != null) hashCode = hashCode * 59 + this.Brokers.GetHashCode();
                hashCode = hashCode * 59 + this.MessageType.GetHashCode();
                return hashCode;
            }
        }
    }
}
