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
    public class ListConsumerGroupsResponse : SdkResponse
    {
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

            private static readonly Dictionary<string, RedrivePolicyEnum> StaticFields =
            new Dictionary<string, RedrivePolicyEnum>()
            {
                { "enable", ENABLE },
                { "disable", DISABLE },
            };

            private string Value;

            public RedrivePolicyEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
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
        [JsonProperty("queue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueueId { get; set; }

        /// <summary>
        /// 队列的名称。
        /// </summary>
        [JsonProperty("queue_name", NullValueHandling = NullValueHandling.Ignore)]
        public string QueueName { get; set; }

        /// <summary>
        /// 消费组列表。
        /// </summary>
        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListQueueGroupsRespGroups> Groups { get; set; }

        /// <summary>
        /// 该队列是否开启死信消息。仅当include_deadletter为true时，才有该响应参数。 - enable：表示开启。 - disable：表示不开启。
        /// </summary>
        [JsonProperty("redrive_policy", NullValueHandling = NullValueHandling.Ignore)]
        public RedrivePolicyEnum RedrivePolicy { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConsumerGroupsResponse {\n");
            sb.Append("  queueId: ").Append(QueueId).Append("\n");
            sb.Append("  queueName: ").Append(QueueName).Append("\n");
            sb.Append("  groups: ").Append(Groups).Append("\n");
            sb.Append("  redrivePolicy: ").Append(RedrivePolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConsumerGroupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListConsumerGroupsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QueueId == input.QueueId ||
                    (this.QueueId != null &&
                    this.QueueId.Equals(input.QueueId))
                ) && 
                (
                    this.QueueName == input.QueueName ||
                    (this.QueueName != null &&
                    this.QueueName.Equals(input.QueueName))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.RedrivePolicy == input.RedrivePolicy ||
                    (this.RedrivePolicy != null &&
                    this.RedrivePolicy.Equals(input.RedrivePolicy))
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
                if (this.QueueId != null)
                    hashCode = hashCode * 59 + this.QueueId.GetHashCode();
                if (this.QueueName != null)
                    hashCode = hashCode * 59 + this.QueueName.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.RedrivePolicy != null)
                    hashCode = hashCode * 59 + this.RedrivePolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
