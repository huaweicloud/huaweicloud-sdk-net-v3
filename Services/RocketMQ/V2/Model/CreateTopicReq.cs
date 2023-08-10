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
    public class CreateTopicReq 
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
        /// 消息类型。
        /// </summary>
        /// <value>消息类型。</value>
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
        /// 主题名称，只能由英文字母、数字、百分号、竖线、中划线、下划线组成，长度3~64个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 关联的代理。
        /// </summary>
        [JsonProperty("brokers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Brokers { get; set; }

        /// <summary>
        /// 队列数，范围1~50。
        /// </summary>
        [JsonProperty("queue_num", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? QueueNum { get; set; }

        /// <summary>
        /// 权限。
        /// </summary>
        [JsonProperty("permission", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionEnum Permission { get; set; }
        /// <summary>
        /// 消息类型。
        /// </summary>
        [JsonProperty("message_type", NullValueHandling = NullValueHandling.Ignore)]
        public MessageTypeEnum MessageType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTopicReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  brokers: ").Append(Brokers).Append("\n");
            sb.Append("  queueNum: ").Append(QueueNum).Append("\n");
            sb.Append("  permission: ").Append(Permission).Append("\n");
            sb.Append("  messageType: ").Append(MessageType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTopicReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTopicReq input)
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
                    this.Brokers == input.Brokers ||
                    this.Brokers != null &&
                    input.Brokers != null &&
                    this.Brokers.SequenceEqual(input.Brokers)
                ) && 
                (
                    this.QueueNum == input.QueueNum ||
                    (this.QueueNum != null &&
                    this.QueueNum.Equals(input.QueueNum))
                ) && 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
                ) && 
                (
                    this.MessageType == input.MessageType ||
                    (this.MessageType != null &&
                    this.MessageType.Equals(input.MessageType))
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
                if (this.Brokers != null)
                    hashCode = hashCode * 59 + this.Brokers.GetHashCode();
                if (this.QueueNum != null)
                    hashCode = hashCode * 59 + this.QueueNum.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.MessageType != null)
                    hashCode = hashCode * 59 + this.MessageType.GetHashCode();
                return hashCode;
            }
        }
    }
}
