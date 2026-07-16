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
    /// 
    /// </summary>
    public class BatchUpdatePoolNodesRequestBody 
    {
        /// <summary>
        /// **参数解释**：节点更新的类型。 **约束限制**：不涉及。 **取值范围**：可选值如下： - openHaRedundant：开启节点的高可用冗余标签 - closeHaRedundant：关闭节点的高可用冗余标签 - createTags：批量添加节点资源标签 - deleteTags：批量删除节点资源标签 **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：节点更新的类型。 **约束限制**：不涉及。 **取值范围**：可选值如下： - openHaRedundant：开启节点的高可用冗余标签 - closeHaRedundant：关闭节点的高可用冗余标签 - createTags：批量添加节点资源标签 - deleteTags：批量删除节点资源标签 **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly ActionEnum TRUE = new ActionEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly ActionEnum FALSE = new ActionEnum("false");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：需要更新的节点名称列表。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("nodeNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// **参数解释**：节点更新的类型。 **约束限制**：不涉及。 **取值范围**：可选值如下： - openHaRedundant：开启节点的高可用冗余标签 - closeHaRedundant：关闭节点的高可用冗余标签 - createTags：批量添加节点资源标签 - deleteTags：批量删除节点资源标签 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// **参数解释**：高可用冗余标签效果。 **约束限制**：不涉及。 **取值范围**：可选值如下： - NoSchedule：禁止调度 - NoExecute：禁止执行。 **默认取值**：NoSchedule。
        /// </summary>
        [JsonProperty("haRedundantEffect", NullValueHandling = NullValueHandling.Ignore)]
        public string HaRedundantEffect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("driver", NullValueHandling = NullValueHandling.Ignore)]
        public NodeDriver Driver { get; set; }

        /// <summary>
        /// **参数解释**：需要批量操作的资源标签列表。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodeTag> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdatePoolNodesRequestBody {\n");
            sb.Append("  nodeNames: ").Append(NodeNames).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  haRedundantEffect: ").Append(HaRedundantEffect).Append("\n");
            sb.Append("  driver: ").Append(Driver).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdatePoolNodesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdatePoolNodesRequestBody input)
        {
            if (input == null) return false;
            if (this.NodeNames != input.NodeNames || (this.NodeNames != null && input.NodeNames != null && !this.NodeNames.SequenceEqual(input.NodeNames))) return false;
            if (this.Action != input.Action) return false;
            if (this.HaRedundantEffect != input.HaRedundantEffect || (this.HaRedundantEffect != null && !this.HaRedundantEffect.Equals(input.HaRedundantEffect))) return false;
            if (this.Driver != input.Driver || (this.Driver != null && !this.Driver.Equals(input.Driver))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                if (this.NodeNames != null) hashCode = hashCode * 59 + this.NodeNames.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.HaRedundantEffect != null) hashCode = hashCode * 59 + this.HaRedundantEffect.GetHashCode();
                if (this.Driver != null) hashCode = hashCode * 59 + this.Driver.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
