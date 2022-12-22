using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowSinkTaskDetailRequest 
    {
        /// <summary>
        /// 是否包含topic信息。默认是false。
        /// </summary>
        /// <value>是否包含topic信息。默认是false。</value>
        [JsonConverter(typeof(EnumClassConverter<TopicInfoEnum>))]
        public class TopicInfoEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly TopicInfoEnum TRUE = new TopicInfoEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly TopicInfoEnum FALSE = new TopicInfoEnum("false");

            private static readonly Dictionary<string, TopicInfoEnum> StaticFields =
            new Dictionary<string, TopicInfoEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public TopicInfoEnum()
            {

            }

            public TopicInfoEnum(string value)
            {
                _value = value;
            }

            public static TopicInfoEnum FromValue(string value)
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

                if (this.Equals(obj as TopicInfoEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TopicInfoEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TopicInfoEnum a, TopicInfoEnum b)
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

            public static bool operator !=(TopicInfoEnum a, TopicInfoEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例转储ID。 请参考[实例生命周期][查询实例]接口返回的数据。
        /// </summary>
        [SDKProperty("connector_id", IsPath = true)]
        [JsonProperty("connector_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// 转储任务ID。
        /// </summary>
        [SDKProperty("task_id", IsPath = true)]
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 是否包含topic信息。默认是false。
        /// </summary>
        [SDKProperty("topic-info", IsQuery = true)]
        [JsonProperty("topic-info", NullValueHandling = NullValueHandling.Ignore)]
        public TopicInfoEnum TopicInfo { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSinkTaskDetailRequest {\n");
            sb.Append("  connectorId: ").Append(ConnectorId).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  topicInfo: ").Append(TopicInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSinkTaskDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSinkTaskDetailRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConnectorId == input.ConnectorId ||
                    (this.ConnectorId != null &&
                    this.ConnectorId.Equals(input.ConnectorId))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.TopicInfo == input.TopicInfo ||
                    (this.TopicInfo != null &&
                    this.TopicInfo.Equals(input.TopicInfo))
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
                if (this.ConnectorId != null)
                    hashCode = hashCode * 59 + this.ConnectorId.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TopicInfo != null)
                    hashCode = hashCode * 59 + this.TopicInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
