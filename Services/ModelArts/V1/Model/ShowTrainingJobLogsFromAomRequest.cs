using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowTrainingJobLogsFromAomRequest 
    {
        /// <summary>
        /// **参数解释**：日志排序方式。 **约束限制**：不涉及。 **取值范围**：枚举值如下： - asc：升序（从旧到新） - desc：降序（从新到旧） **默认取值**：desc。
        /// </summary>
        /// <value>**参数解释**：日志排序方式。 **约束限制**：不涉及。 **取值范围**：枚举值如下： - asc：升序（从旧到新） - desc：降序（从新到旧） **默认取值**：desc。</value>
        [JsonConverter(typeof(EnumClassConverter<OrderEnum>))]
        public class OrderEnum
        {
            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly OrderEnum ASC = new OrderEnum("asc");

            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly OrderEnum DESC = new OrderEnum("desc");

            private static readonly Dictionary<string, OrderEnum> StaticFields =
            new Dictionary<string, OrderEnum>()
            {
                { "asc", ASC },
                { "desc", DESC },
            };

            private string _value;

            public OrderEnum()
            {

            }

            public OrderEnum(string value)
            {
                _value = value;
            }

            public static OrderEnum FromValue(string value)
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

                if (this.Equals(obj as OrderEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OrderEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OrderEnum a, OrderEnum b)
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

            public static bool operator !=(OrderEnum a, OrderEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 训练作业ID。获取方法请参见[查询训练作业列表](ListTrainingJobs.xml)。
        /// </summary>
        [SDKProperty("training_job_id", IsPath = true)]
        [JsonProperty("training_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainingJobId { get; set; }

        /// <summary>
        /// 训练作业的任务名称。可从训练作业详情中的status.tasks字段中获取。
        /// </summary>
        [SDKProperty("task_id", IsPath = true)]
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// **参数解释**：日志查询的基线行号，用于分页查询。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及（从最新日志开始查询）。
        /// </summary>
        [SDKProperty("base_line", IsQuery = true)]
        [JsonProperty("base_line", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseLine { get; set; }

        /// <summary>
        /// **参数解释**：返回的日志行数。 **约束限制**：不涉及。 **取值范围**：1 ~ 500。 **默认取值**：50。
        /// </summary>
        [SDKProperty("lines", IsQuery = true)]
        [JsonProperty("lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lines { get; set; }

        /// <summary>
        /// **参数解释**：日志排序方式。 **约束限制**：不涉及。 **取值范围**：枚举值如下： - asc：升序（从旧到新） - desc：降序（从新到旧） **默认取值**：desc。
        /// </summary>
        [SDKProperty("order", IsQuery = true)]
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public OrderEnum Order { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTrainingJobLogsFromAomRequest {\n");
            sb.Append("  trainingJobId: ").Append(TrainingJobId).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  baseLine: ").Append(BaseLine).Append("\n");
            sb.Append("  lines: ").Append(Lines).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTrainingJobLogsFromAomRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTrainingJobLogsFromAomRequest input)
        {
            if (input == null) return false;
            if (this.TrainingJobId != input.TrainingJobId || (this.TrainingJobId != null && !this.TrainingJobId.Equals(input.TrainingJobId))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.BaseLine != input.BaseLine || (this.BaseLine != null && !this.BaseLine.Equals(input.BaseLine))) return false;
            if (this.Lines != input.Lines || (this.Lines != null && !this.Lines.Equals(input.Lines))) return false;
            if (this.Order != input.Order) return false;

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
                if (this.TrainingJobId != null) hashCode = hashCode * 59 + this.TrainingJobId.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.BaseLine != null) hashCode = hashCode * 59 + this.BaseLine.GetHashCode();
                if (this.Lines != null) hashCode = hashCode * 59 + this.Lines.GetHashCode();
                hashCode = hashCode * 59 + this.Order.GetHashCode();
                return hashCode;
            }
        }
    }
}
