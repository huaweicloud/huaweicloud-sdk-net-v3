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
    /// **参数解释**：镜像预热任务的执行状态。 **约束限制**：仅在请求体/插件中存在镜像预热配置（image_warm_up）时返回。 **取值范围**：不涉及。 **默认取值**：不涉及。
    /// </summary>
    public class NodeconfigStatusConfigsStatusImageWarmUp 
    {
        /// <summary>
        /// **参数解释**：镜像预热任务的整体状态。 **约束限制**：不涉及。 **取值范围**：可选值如下： - Success：全部成功，所有镜像在所有节点上均预热成功。 - Failed：全部失败，所有镜像在所有节点上均预热失败。 - Pulling：预热中，镜像正在被拉取。 - PartialCompletion：部分完成，部分镜像成功、部分失败或部分节点成功。 - Unknown：未知状态，解析节点上报数据异常。 **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：镜像预热任务的整体状态。 **约束限制**：不涉及。 **取值范围**：可选值如下： - Success：全部成功，所有镜像在所有节点上均预热成功。 - Failed：全部失败，所有镜像在所有节点上均预热失败。 - Pulling：预热中，镜像正在被拉取。 - PartialCompletion：部分完成，部分镜像成功、部分失败或部分节点成功。 - Unknown：未知状态，解析节点上报数据异常。 **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: Success
            /// </summary>
            public static readonly StateEnum SUCCESS = new StateEnum("Success");

            /// <summary>
            /// Enum FAILED for value: Failed
            /// </summary>
            public static readonly StateEnum FAILED = new StateEnum("Failed");

            /// <summary>
            /// Enum PULLING for value: Pulling
            /// </summary>
            public static readonly StateEnum PULLING = new StateEnum("Pulling");

            /// <summary>
            /// Enum PARTIALCOMPLETION for value: PartialCompletion
            /// </summary>
            public static readonly StateEnum PARTIALCOMPLETION = new StateEnum("PartialCompletion");

            /// <summary>
            /// Enum UNKNOWN for value: Unknown
            /// </summary>
            public static readonly StateEnum UNKNOWN = new StateEnum("Unknown");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "Success", SUCCESS },
                { "Failed", FAILED },
                { "Pulling", PULLING },
                { "PartialCompletion", PARTIALCOMPLETION },
                { "Unknown", UNKNOWN },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：镜像预热任务的整体状态。 **约束限制**：不涉及。 **取值范围**：可选值如下： - Success：全部成功，所有镜像在所有节点上均预热成功。 - Failed：全部失败，所有镜像在所有节点上均预热失败。 - Pulling：预热中，镜像正在被拉取。 - PartialCompletion：部分完成，部分镜像成功、部分失败或部分节点成功。 - Unknown：未知状态，解析节点上报数据异常。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// **参数解释**：镜像预热任务的详细结果信息（JSON格式字符串），包含以下字段： - successfulImages：预热成功的镜像列表 - failedImages：预热失败的镜像列表 - partialSuccess：部分节点成功的镜像列表 - pendingImages：尚未完成预热的镜像列表 - additionalInfos：失败原因等附加信息（如镜像不存在、拉取超时、拉取失败、镜像仓库中manifest不存在） - successfulImagesConfig：成功镜像的配置详情（id、name、creationTimestamp、type、image） - failedImagesConfig：失败镜像的配置详情 - partialSuccessConfig：部分成功镜像的配置详情 - pendingImagesConfig：待预热镜像的配置详情 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeconfigStatusConfigsStatusImageWarmUp {\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeconfigStatusConfigsStatusImageWarmUp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeconfigStatusConfigsStatusImageWarmUp input)
        {
            if (input == null) return false;
            if (this.State != input.State) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
