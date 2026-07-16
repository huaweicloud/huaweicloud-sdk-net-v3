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
    /// 单节点执行状态。
    /// </summary>
    public class StepExecutionResp 
    {
        /// <summary>
        /// **参数解释**：节点的类型。 **取值范围**：枚举值如下: - job：训练 - labeling：标注 - release_dataset：数据集发布 - model：模型发布 - service：服务部署 - mrs_job：MRS作业 - dataset_import：数据集导入 - create_dataset：创建数据集
        /// </summary>
        /// <value>**参数解释**：节点的类型。 **取值范围**：枚举值如下: - job：训练 - labeling：标注 - release_dataset：数据集发布 - model：模型发布 - service：服务部署 - mrs_job：MRS作业 - dataset_import：数据集导入 - create_dataset：创建数据集</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum TRANING_JOB for value: traning_job
            /// </summary>
            public static readonly TypeEnum TRANING_JOB = new TypeEnum("traning_job");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "traning_job", TRANING_JOB },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：节点的状态。 **取值范围**：枚举值如下： - init：初始化 - wait_inputs：等待输入 - pending：等待 - creating：创建中 - created：创建成功 - create_failed：创建失败 - running：运行中 - stopping：停止中 - stopped：停止 - timeout：超时 - completed：完成 - failed：失败 - hold：暂停 - skipped：跳过
        /// </summary>
        /// <value>**参数解释**：节点的状态。 **取值范围**：枚举值如下： - init：初始化 - wait_inputs：等待输入 - pending：等待 - creating：创建中 - created：创建成功 - create_failed：创建失败 - running：运行中 - stopping：停止中 - stopped：停止 - timeout：超时 - completed：完成 - failed：失败 - hold：暂停 - skipped：跳过</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum INIT for value: init
            /// </summary>
            public static readonly StatusEnum INIT = new StatusEnum("init");

            /// <summary>
            /// Enum WAIT_INPUTS for value: wait_inputs
            /// </summary>
            public static readonly StatusEnum WAIT_INPUTS = new StatusEnum("wait_inputs");

            /// <summary>
            /// Enum PENDING for value: pending
            /// </summary>
            public static readonly StatusEnum PENDING = new StatusEnum("pending");

            /// <summary>
            /// Enum CREATING for value: creating
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("creating");

            /// <summary>
            /// Enum CREATED for value: created
            /// </summary>
            public static readonly StatusEnum CREATED = new StatusEnum("created");

            /// <summary>
            /// Enum CREATE_FAILED for value: create_failed
            /// </summary>
            public static readonly StatusEnum CREATE_FAILED = new StatusEnum("create_failed");

            /// <summary>
            /// Enum RUNNING for value: running
            /// </summary>
            public static readonly StatusEnum RUNNING = new StatusEnum("running");

            /// <summary>
            /// Enum STOPPING for value: stopping
            /// </summary>
            public static readonly StatusEnum STOPPING = new StatusEnum("stopping");

            /// <summary>
            /// Enum STOPPED for value: stopped
            /// </summary>
            public static readonly StatusEnum STOPPED = new StatusEnum("stopped");

            /// <summary>
            /// Enum TIMEOUT for value: timeout
            /// </summary>
            public static readonly StatusEnum TIMEOUT = new StatusEnum("timeout");

            /// <summary>
            /// Enum COMPLETED for value: completed
            /// </summary>
            public static readonly StatusEnum COMPLETED = new StatusEnum("completed");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("failed");

            /// <summary>
            /// Enum HOLD for value: hold
            /// </summary>
            public static readonly StatusEnum HOLD = new StatusEnum("hold");

            /// <summary>
            /// Enum SKIPPED for value: skipped
            /// </summary>
            public static readonly StatusEnum SKIPPED = new StatusEnum("skipped");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "init", INIT },
                { "wait_inputs", WAIT_INPUTS },
                { "pending", PENDING },
                { "creating", CREATING },
                { "created", CREATED },
                { "create_failed", CREATE_FAILED },
                { "running", RUNNING },
                { "stopping", STOPPING },
                { "stopped", STOPPED },
                { "timeout", TIMEOUT },
                { "completed", COMPLETED },
                { "failed", FAILED },
                { "hold", HOLD },
                { "skipped", SKIPPED },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：节点的名称，在一个DAG中唯一。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("step_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StepName { get; set; }

        /// <summary>
        /// **参数解释**：执行记录的名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("execution_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionName { get; set; }

        /// <summary>
        /// **参数解释**：执行记录与节点的组合名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：唯一标识uuid。创建节点执行时，后台自动生成。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        /// <summary>
        /// **参数解释**：执行记录的UUID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("execution_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionUuid { get; set; }

        /// <summary>
        /// **参数解释**：Execution执行的创建时间。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释**：Execution执行的更新时间。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// **参数解释**：Execution执行的运行时长。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// **参数解释**：节点的类型。 **取值范围**：枚举值如下: - job：训练 - labeling：标注 - release_dataset：数据集发布 - model：模型发布 - service：服务部署 - mrs_job：MRS作业 - dataset_import：数据集导入 - create_dataset：创建数据集
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**：实例ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**：节点的状态。 **取值范围**：枚举值如下： - init：初始化 - wait_inputs：等待输入 - pending：等待 - creating：创建中 - created：创建成功 - create_failed：创建失败 - running：运行中 - stopping：停止中 - stopped：停止 - timeout：超时 - completed：完成 - failed：失败 - hold：暂停 - skipped：跳过
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释**：节点的输入项。
        /// </summary>
        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobInputResp> Inputs { get; set; }

        /// <summary>
        /// **参数解释**：节点的输出项。
        /// </summary>
        [JsonProperty("outputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobOutputResp> Outputs { get; set; }

        /// <summary>
        /// **参数解释**：节点的UUID，唯一性标识。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("step_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string StepUuid { get; set; }

        /// <summary>
        /// **参数解释**：节点的属性。
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// **参数解释**：节点发生的事件。
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_info", NullValueHandling = NullValueHandling.Ignore)]
        public WorkflowErrorInfoResp ErrorInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public WorkflowStepExecutionPolicyResp Policy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("conditions_execution", NullValueHandling = NullValueHandling.Ignore)]
        public WorkflowConditionExecutionResp ConditionsExecution { get; set; }

        /// <summary>
        /// **参数解释**：节点标题。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("step_title", NullValueHandling = NullValueHandling.Ignore)]
        public string StepTitle { get; set; }

        /// <summary>
        /// **参数解释**：条件节点执行条件。
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<StepConditionResp> Conditions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StepExecutionResp {\n");
            sb.Append("  stepName: ").Append(StepName).Append("\n");
            sb.Append("  executionName: ").Append(ExecutionName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  uuid: ").Append(Uuid).Append("\n");
            sb.Append("  executionUuid: ").Append(ExecutionUuid).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  inputs: ").Append(Inputs).Append("\n");
            sb.Append("  outputs: ").Append(Outputs).Append("\n");
            sb.Append("  stepUuid: ").Append(StepUuid).Append("\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("  events: ").Append(Events).Append("\n");
            sb.Append("  errorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  conditionsExecution: ").Append(ConditionsExecution).Append("\n");
            sb.Append("  stepTitle: ").Append(StepTitle).Append("\n");
            sb.Append("  conditions: ").Append(Conditions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StepExecutionResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StepExecutionResp input)
        {
            if (input == null) return false;
            if (this.StepName != input.StepName || (this.StepName != null && !this.StepName.Equals(input.StepName))) return false;
            if (this.ExecutionName != input.ExecutionName || (this.ExecutionName != null && !this.ExecutionName.Equals(input.ExecutionName))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Uuid != input.Uuid || (this.Uuid != null && !this.Uuid.Equals(input.Uuid))) return false;
            if (this.ExecutionUuid != input.ExecutionUuid || (this.ExecutionUuid != null && !this.ExecutionUuid.Equals(input.ExecutionUuid))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.Type != input.Type) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Status != input.Status) return false;
            if (this.Inputs != input.Inputs || (this.Inputs != null && input.Inputs != null && !this.Inputs.SequenceEqual(input.Inputs))) return false;
            if (this.Outputs != input.Outputs || (this.Outputs != null && input.Outputs != null && !this.Outputs.SequenceEqual(input.Outputs))) return false;
            if (this.StepUuid != input.StepUuid || (this.StepUuid != null && !this.StepUuid.Equals(input.StepUuid))) return false;
            if (this.Properties != input.Properties || (this.Properties != null && input.Properties != null && !this.Properties.SequenceEqual(input.Properties))) return false;
            if (this.Events != input.Events || (this.Events != null && input.Events != null && !this.Events.SequenceEqual(input.Events))) return false;
            if (this.ErrorInfo != input.ErrorInfo || (this.ErrorInfo != null && !this.ErrorInfo.Equals(input.ErrorInfo))) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.ConditionsExecution != input.ConditionsExecution || (this.ConditionsExecution != null && !this.ConditionsExecution.Equals(input.ConditionsExecution))) return false;
            if (this.StepTitle != input.StepTitle || (this.StepTitle != null && !this.StepTitle.Equals(input.StepTitle))) return false;
            if (this.Conditions != input.Conditions || (this.Conditions != null && input.Conditions != null && !this.Conditions.SequenceEqual(input.Conditions))) return false;

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
                if (this.StepName != null) hashCode = hashCode * 59 + this.StepName.GetHashCode();
                if (this.ExecutionName != null) hashCode = hashCode * 59 + this.ExecutionName.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Uuid != null) hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.ExecutionUuid != null) hashCode = hashCode * 59 + this.ExecutionUuid.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Inputs != null) hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Outputs != null) hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                if (this.StepUuid != null) hashCode = hashCode * 59 + this.StepUuid.GetHashCode();
                if (this.Properties != null) hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Events != null) hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.ErrorInfo != null) hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.ConditionsExecution != null) hashCode = hashCode * 59 + this.ConditionsExecution.GetHashCode();
                if (this.StepTitle != null) hashCode = hashCode * 59 + this.StepTitle.GetHashCode();
                if (this.Conditions != null) hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                return hashCode;
            }
        }
    }
}
