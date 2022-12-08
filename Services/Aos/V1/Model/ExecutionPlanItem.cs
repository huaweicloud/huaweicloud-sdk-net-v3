using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 执行计划元素，承载执行计划中变更的细节。
    /// </summary>
    public class ExecutionPlanItem 
    {
        /// <summary>
        /// 资源变更的类型，这里，IN_PLACE_UPDATE、ADD_THEN_DELETE和 DELETE_THEN_ADD均为更新操作，IN_PLACE_UPDATE指原地更新； 而对于不可更新的资源，ADD_THEN_DELETE是先创建新的，再删除旧的；DELETE_THEN_ADD是先删除旧的，再创建新的. 执行计划的执行状态，只有当AVAILABLE的时候才可以使用apply执行 * &#x60;ADD&#x60; - 新建资源 * &#x60;ADD_THEN_DELETE&#x60; - 对于不可更新的资源执行先创建再删除的操作 * &#x60;DELETE &#x60; - 删除资源 * &#x60;DELETE_THEN_ADD&#x60; - 对于不可更新的资源执行先删除在创建的操作 * &#x60;UPDATE&#x60; - 更新资源  * &#x60;IN_PLACE_UPDATE&#x60; - 更新资源的操作 * &#x60;NO_OPERATION&#x60; - 变更资源的依赖关系，但是对资源本身并无修改的操作
        /// </summary>
        /// <value>资源变更的类型，这里，IN_PLACE_UPDATE、ADD_THEN_DELETE和 DELETE_THEN_ADD均为更新操作，IN_PLACE_UPDATE指原地更新； 而对于不可更新的资源，ADD_THEN_DELETE是先创建新的，再删除旧的；DELETE_THEN_ADD是先删除旧的，再创建新的. 执行计划的执行状态，只有当AVAILABLE的时候才可以使用apply执行 * &#x60;ADD&#x60; - 新建资源 * &#x60;ADD_THEN_DELETE&#x60; - 对于不可更新的资源执行先创建再删除的操作 * &#x60;DELETE &#x60; - 删除资源 * &#x60;DELETE_THEN_ADD&#x60; - 对于不可更新的资源执行先删除在创建的操作 * &#x60;UPDATE&#x60; - 更新资源  * &#x60;IN_PLACE_UPDATE&#x60; - 更新资源的操作 * &#x60;NO_OPERATION&#x60; - 变更资源的依赖关系，但是对资源本身并无修改的操作</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum ADD for value: ADD
            /// </summary>
            public static readonly ActionEnum ADD = new ActionEnum("ADD");

            /// <summary>
            /// Enum ADD_THEN_DELETE for value: ADD_THEN_DELETE
            /// </summary>
            public static readonly ActionEnum ADD_THEN_DELETE = new ActionEnum("ADD_THEN_DELETE");

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            public static readonly ActionEnum DELETE = new ActionEnum("DELETE");

            /// <summary>
            /// Enum DELETE_THEN_ADD for value: DELETE_THEN_ADD
            /// </summary>
            public static readonly ActionEnum DELETE_THEN_ADD = new ActionEnum("DELETE_THEN_ADD");

            /// <summary>
            /// Enum UPDATE for value: UPDATE
            /// </summary>
            public static readonly ActionEnum UPDATE = new ActionEnum("UPDATE");

            /// <summary>
            /// Enum IN_PLACE_UPDATE for value: IN_PLACE_UPDATE
            /// </summary>
            public static readonly ActionEnum IN_PLACE_UPDATE = new ActionEnum("IN_PLACE_UPDATE");

            /// <summary>
            /// Enum NO_OPERATION for value: NO_OPERATION
            /// </summary>
            public static readonly ActionEnum NO_OPERATION = new ActionEnum("NO_OPERATION");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "ADD", ADD },
                { "ADD_THEN_DELETE", ADD_THEN_DELETE },
                { "DELETE", DELETE },
                { "DELETE_THEN_ADD", DELETE_THEN_ADD },
                { "UPDATE", UPDATE },
                { "IN_PLACE_UPDATE", IN_PLACE_UPDATE },
                { "NO_OPERATION", NO_OPERATION },
            };

            private string Value;

            public ActionEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// * &#x60;DATA&#x60; - 指可以在模板解析期间运行和获取服务端数据的资源类型，不会操作基础设施组件 * &#x60;RESOURCE&#x60; - 指通过模板管理的由服务定义的基础设施组件抽象，可以是物理资源也可以是逻辑资源
        /// </summary>
        /// <value>* &#x60;DATA&#x60; - 指可以在模板解析期间运行和获取服务端数据的资源类型，不会操作基础设施组件 * &#x60;RESOURCE&#x60; - 指通过模板管理的由服务定义的基础设施组件抽象，可以是物理资源也可以是逻辑资源</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum DATA for value: DATA
            /// </summary>
            public static readonly ModeEnum DATA = new ModeEnum("DATA");

            /// <summary>
            /// Enum RESOURCE for value: RESOURCE
            /// </summary>
            public static readonly ModeEnum RESOURCE = new ModeEnum("RESOURCE");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "DATA", DATA },
                { "RESOURCE", RESOURCE },
            };

            private string Value;

            public ModeEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资源变更的类型，这里，IN_PLACE_UPDATE、ADD_THEN_DELETE和 DELETE_THEN_ADD均为更新操作，IN_PLACE_UPDATE指原地更新； 而对于不可更新的资源，ADD_THEN_DELETE是先创建新的，再删除旧的；DELETE_THEN_ADD是先删除旧的，再创建新的. 执行计划的执行状态，只有当AVAILABLE的时候才可以使用apply执行 * &#x60;ADD&#x60; - 新建资源 * &#x60;ADD_THEN_DELETE&#x60; - 对于不可更新的资源执行先创建再删除的操作 * &#x60;DELETE &#x60; - 删除资源 * &#x60;DELETE_THEN_ADD&#x60; - 对于不可更新的资源执行先删除在创建的操作 * &#x60;UPDATE&#x60; - 更新资源  * &#x60;IN_PLACE_UPDATE&#x60; - 更新资源的操作 * &#x60;NO_OPERATION&#x60; - 变更资源的依赖关系，但是对资源本身并无修改的操作
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 表示该动作触发的原因，例如用户更新模板；远端删除资源等等
        /// </summary>
        [JsonProperty("action_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionReason { get; set; }

        /// <summary>
        /// 表示该资源所属的provider名字。
        /// </summary>
        [JsonProperty("provider_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderName { get; set; }

        /// <summary>
        /// 当前资源在HCL模板中对应的类型。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 当前资源的在HCL模板中指定的名字。
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 表示资源对应的index，例如对于使用count构建的资源，其类型和名字一样，但是index是从1到count的数值；对于使用for_each创建的资源，index可以是for_each中指定的key名。
        /// </summary>
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public string Index { get; set; }

        /// <summary>
        /// * &#x60;DATA&#x60; - 指可以在模板解析期间运行和获取服务端数据的资源类型，不会操作基础设施组件 * &#x60;RESOURCE&#x60; - 指通过模板管理的由服务定义的基础设施组件抽象，可以是物理资源也可以是逻辑资源
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// 当前资源的变更是否由配置漂移导致。
        /// </summary>
        [JsonProperty("drifted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Drifted { get; set; }

        /// <summary>
        /// 当前资源的唯一ID，当操作类型为创建时为空。当资源为新建时为空。注意resouce_name是资源在HCL模板中定义的名字，resource_id是provider提供的唯一ID。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 执行计划元素变更的属性，当无属性变更时为空。
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExecutionPlanDiffAttribute> Attributes { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutionPlanItem {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  actionReason: ").Append(ActionReason).Append("\n");
            sb.Append("  providerName: ").Append(ProviderName).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  index: ").Append(Index).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  drifted: ").Append(Drifted).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  attributes: ").Append(Attributes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecutionPlanItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecutionPlanItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.ActionReason == input.ActionReason ||
                    (this.ActionReason != null &&
                    this.ActionReason.Equals(input.ActionReason))
                ) && 
                (
                    this.ProviderName == input.ProviderName ||
                    (this.ProviderName != null &&
                    this.ProviderName.Equals(input.ProviderName))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Drifted == input.Drifted ||
                    (this.Drifted != null &&
                    this.Drifted.Equals(input.Drifted))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ActionReason != null)
                    hashCode = hashCode * 59 + this.ActionReason.GetHashCode();
                if (this.ProviderName != null)
                    hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Drifted != null)
                    hashCode = hashCode * 59 + this.Drifted.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                return hashCode;
            }
        }
    }
}
