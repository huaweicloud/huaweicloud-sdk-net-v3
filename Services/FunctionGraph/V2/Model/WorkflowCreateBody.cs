using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 创建函数流的body体
    /// </summary>
    public class WorkflowCreateBody 
    {
        /// <summary>
        /// 函数流模式，当前支持两种模式 NORMAL: 标准模式，普通模式面向普通的业务场景，支持长时间任务，支持执行历史持久化和查询，只支持异步调用 EXPRESS: 快速模式，快速模式面向业务执行时长较短，需要极致性能的场景，只支持流程执行时长低于5分钟的场景，不支持执行历史持久化，支持同步和异步调用 默认为标准模式
        /// </summary>
        /// <value>函数流模式，当前支持两种模式 NORMAL: 标准模式，普通模式面向普通的业务场景，支持长时间任务，支持执行历史持久化和查询，只支持异步调用 EXPRESS: 快速模式，快速模式面向业务执行时长较短，需要极致性能的场景，只支持流程执行时长低于5分钟的场景，不支持执行历史持久化，支持同步和异步调用 默认为标准模式</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            public static readonly ModeEnum NORMAL = new ModeEnum("NORMAL");

            /// <summary>
            /// Enum EXPRESS for value: EXPRESS
            /// </summary>
            public static readonly ModeEnum EXPRESS = new ModeEnum("EXPRESS");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "NORMAL", NORMAL },
                { "EXPRESS", EXPRESS },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 函数流名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 函数流描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 流程开始节点ID
        /// </summary>
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public string Start { get; set; }

        /// <summary>
        /// 触发器列表
        /// </summary>
        [JsonProperty("triggers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Trigger> Triggers { get; set; }

        /// <summary>
        /// 函数列表
        /// </summary>
        [JsonProperty("functions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Function> Functions { get; set; }

        /// <summary>
        /// 函数流节点清单，定义参考SleepState和OperationState
        /// </summary>
        [JsonProperty("states", NullValueHandling = NullValueHandling.Ignore)]
        public List<OperationState> States { get; set; }

        /// <summary>
        /// 函数流中的常量
        /// </summary>
        [JsonProperty("constants", NullValueHandling = NullValueHandling.Ignore)]
        public Object Constants { get; set; }

        /// <summary>
        /// 重试策略清单
        /// </summary>
        [JsonProperty("retries", NullValueHandling = NullValueHandling.Ignore)]
        public List<Retry> Retries { get; set; }

        /// <summary>
        /// 函数流模式，当前支持两种模式 NORMAL: 标准模式，普通模式面向普通的业务场景，支持长时间任务，支持执行历史持久化和查询，只支持异步调用 EXPRESS: 快速模式，快速模式面向业务执行时长较短，需要极致性能的场景，只支持流程执行时长低于5分钟的场景，不支持执行历史持久化，支持同步和异步调用 默认为标准模式
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("express_config", NullValueHandling = NullValueHandling.Ignore)]
        public ExpressConfig ExpressConfig { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 是否返回流数据
        /// </summary>
        [JsonProperty("enable_stream_response", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableStreamResponse { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowCreateBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  start: ").Append(Start).Append("\n");
            sb.Append("  triggers: ").Append(Triggers).Append("\n");
            sb.Append("  functions: ").Append(Functions).Append("\n");
            sb.Append("  states: ").Append(States).Append("\n");
            sb.Append("  constants: ").Append(Constants).Append("\n");
            sb.Append("  retries: ").Append(Retries).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  expressConfig: ").Append(ExpressConfig).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enableStreamResponse: ").Append(EnableStreamResponse).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowCreateBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowCreateBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Start != input.Start || (this.Start != null && !this.Start.Equals(input.Start))) return false;
            if (this.Triggers != input.Triggers || (this.Triggers != null && input.Triggers != null && !this.Triggers.SequenceEqual(input.Triggers))) return false;
            if (this.Functions != input.Functions || (this.Functions != null && input.Functions != null && !this.Functions.SequenceEqual(input.Functions))) return false;
            if (this.States != input.States || (this.States != null && input.States != null && !this.States.SequenceEqual(input.States))) return false;
            if (this.Constants != input.Constants || (this.Constants != null && !this.Constants.Equals(input.Constants))) return false;
            if (this.Retries != input.Retries || (this.Retries != null && input.Retries != null && !this.Retries.SequenceEqual(input.Retries))) return false;
            if (this.Mode != input.Mode) return false;
            if (this.ExpressConfig != input.ExpressConfig || (this.ExpressConfig != null && !this.ExpressConfig.Equals(input.ExpressConfig))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.EnableStreamResponse != input.EnableStreamResponse || (this.EnableStreamResponse != null && !this.EnableStreamResponse.Equals(input.EnableStreamResponse))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Start != null) hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Triggers != null) hashCode = hashCode * 59 + this.Triggers.GetHashCode();
                if (this.Functions != null) hashCode = hashCode * 59 + this.Functions.GetHashCode();
                if (this.States != null) hashCode = hashCode * 59 + this.States.GetHashCode();
                if (this.Constants != null) hashCode = hashCode * 59 + this.Constants.GetHashCode();
                if (this.Retries != null) hashCode = hashCode * 59 + this.Retries.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.ExpressConfig != null) hashCode = hashCode * 59 + this.ExpressConfig.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.EnableStreamResponse != null) hashCode = hashCode * 59 + this.EnableStreamResponse.GetHashCode();
                return hashCode;
            }
        }
    }
}
