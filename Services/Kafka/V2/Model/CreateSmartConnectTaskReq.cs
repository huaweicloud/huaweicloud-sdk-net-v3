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
    /// 
    /// </summary>
    public class CreateSmartConnectTaskReq 
    {
        /// <summary>
        /// **参数解释**： SmartConnect任务的源端类型。 **约束限制**： 不涉及。 **取值范围**： - KAFKA_REPLICATOR_SOURCE：Kafka数据复制。 - NONE：不配置。 **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： SmartConnect任务的源端类型。 **约束限制**： 不涉及。 **取值范围**： - KAFKA_REPLICATOR_SOURCE：Kafka数据复制。 - NONE：不配置。 **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<SourceTypeEnum>))]
        public class SourceTypeEnum
        {
            /// <summary>
            /// Enum KAFKA_REPLICATOR_SOURCE for value: KAFKA_REPLICATOR_SOURCE
            /// </summary>
            public static readonly SourceTypeEnum KAFKA_REPLICATOR_SOURCE = new SourceTypeEnum("KAFKA_REPLICATOR_SOURCE");

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            public static readonly SourceTypeEnum NONE = new SourceTypeEnum("NONE");

            private static readonly Dictionary<string, SourceTypeEnum> StaticFields =
            new Dictionary<string, SourceTypeEnum>()
            {
                { "KAFKA_REPLICATOR_SOURCE", KAFKA_REPLICATOR_SOURCE },
                { "NONE", NONE },
            };

            private string _value;

            public SourceTypeEnum()
            {

            }

            public SourceTypeEnum(string value)
            {
                _value = value;
            }

            public static SourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SourceTypeEnum a, SourceTypeEnum b)
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

            public static bool operator !=(SourceTypeEnum a, SourceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： SmartConnect任务的目标端类型。 **约束限制**： 不涉及。 **取值范围**： - OBS_SINK：转储。 - NONE：不配置。 **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： SmartConnect任务的目标端类型。 **约束限制**： 不涉及。 **取值范围**： - OBS_SINK：转储。 - NONE：不配置。 **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<SinkTypeEnum>))]
        public class SinkTypeEnum
        {
            /// <summary>
            /// Enum OBS_SINK for value: OBS_SINK
            /// </summary>
            public static readonly SinkTypeEnum OBS_SINK = new SinkTypeEnum("OBS_SINK");

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            public static readonly SinkTypeEnum NONE = new SinkTypeEnum("NONE");

            private static readonly Dictionary<string, SinkTypeEnum> StaticFields =
            new Dictionary<string, SinkTypeEnum>()
            {
                { "OBS_SINK", OBS_SINK },
                { "NONE", NONE },
            };

            private string _value;

            public SinkTypeEnum()
            {

            }

            public SinkTypeEnum(string value)
            {
                _value = value;
            }

            public static SinkTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SinkTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SinkTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SinkTypeEnum a, SinkTypeEnum b)
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

            public static bool operator !=(SinkTypeEnum a, SinkTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// SmartConnect任务名称。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 是否稍后再启动任务。如需要创建任务后立即启动，请填false；如希望稍后在任务列表中手动开启任务，请填true。
        /// </summary>
        [JsonProperty("start_later", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StartLater { get; set; }

        /// <summary>
        /// SmartConnect任务配置的Topic。
        /// </summary>
        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public string Topics { get; set; }

        /// <summary>
        /// SmartConnect任务配置的Topic正则表达式。
        /// </summary>
        [JsonProperty("topics_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicsRegex { get; set; }

        /// <summary>
        /// **参数解释**： SmartConnect任务的源端类型。 **约束限制**： 不涉及。 **取值范围**： - KAFKA_REPLICATOR_SOURCE：Kafka数据复制。 - NONE：不配置。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public SourceTypeEnum SourceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source_task", NullValueHandling = NullValueHandling.Ignore)]
        public SmartConnectTaskReqSourceConfig SourceTask { get; set; }

        /// <summary>
        /// **参数解释**： SmartConnect任务的目标端类型。 **约束限制**： 不涉及。 **取值范围**： - OBS_SINK：转储。 - NONE：不配置。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("sink_type", NullValueHandling = NullValueHandling.Ignore)]
        public SinkTypeEnum SinkType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sink_task", NullValueHandling = NullValueHandling.Ignore)]
        public SmartConnectTaskReqSinkConfig SinkTask { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSmartConnectTaskReq {\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  startLater: ").Append(StartLater).Append("\n");
            sb.Append("  topics: ").Append(Topics).Append("\n");
            sb.Append("  topicsRegex: ").Append(TopicsRegex).Append("\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  sourceTask: ").Append(SourceTask).Append("\n");
            sb.Append("  sinkType: ").Append(SinkType).Append("\n");
            sb.Append("  sinkTask: ").Append(SinkTask).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSmartConnectTaskReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSmartConnectTaskReq input)
        {
            if (input == null) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.StartLater != input.StartLater || (this.StartLater != null && !this.StartLater.Equals(input.StartLater))) return false;
            if (this.Topics != input.Topics || (this.Topics != null && !this.Topics.Equals(input.Topics))) return false;
            if (this.TopicsRegex != input.TopicsRegex || (this.TopicsRegex != null && !this.TopicsRegex.Equals(input.TopicsRegex))) return false;
            if (this.SourceType != input.SourceType) return false;
            if (this.SourceTask != input.SourceTask || (this.SourceTask != null && !this.SourceTask.Equals(input.SourceTask))) return false;
            if (this.SinkType != input.SinkType) return false;
            if (this.SinkTask != input.SinkTask || (this.SinkTask != null && !this.SinkTask.Equals(input.SinkTask))) return false;

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
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.StartLater != null) hashCode = hashCode * 59 + this.StartLater.GetHashCode();
                if (this.Topics != null) hashCode = hashCode * 59 + this.Topics.GetHashCode();
                if (this.TopicsRegex != null) hashCode = hashCode * 59 + this.TopicsRegex.GetHashCode();
                hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.SourceTask != null) hashCode = hashCode * 59 + this.SourceTask.GetHashCode();
                hashCode = hashCode * 59 + this.SinkType.GetHashCode();
                if (this.SinkTask != null) hashCode = hashCode * 59 + this.SinkTask.GetHashCode();
                return hashCode;
            }
        }
    }
}
