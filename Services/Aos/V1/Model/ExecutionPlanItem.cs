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
    /// 
    /// </summary>
    public class ExecutionPlanItem 
    {
        /// <summary>
        /// 资源变更的类型   * &#x60;ADD&#x60; - 新增资源   * &#x60;ADD_THEN_DELETE&#x60; - 由不可更新的资源返回，先创建新资源，再删除旧资源   * &#x60;DELETE &#x60; - 删除资源   * &#x60;DELETE_THEN_ADD&#x60; - 由不可更新的资源返回，先删除旧资源，再创建新资源   * &#x60;UPDATE&#x60; - 更新资源    * &#x60;NO_OPERATION&#x60; - 仅变更资源的依赖关系，但是对资源本身并无修改的操作
        /// </summary>
        /// <value>资源变更的类型   * &#x60;ADD&#x60; - 新增资源   * &#x60;ADD_THEN_DELETE&#x60; - 由不可更新的资源返回，先创建新资源，再删除旧资源   * &#x60;DELETE &#x60; - 删除资源   * &#x60;DELETE_THEN_ADD&#x60; - 由不可更新的资源返回，先删除旧资源，再创建新资源   * &#x60;UPDATE&#x60; - 更新资源    * &#x60;NO_OPERATION&#x60; - 仅变更资源的依赖关系，但是对资源本身并无修改的操作</value>
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
                { "NO_OPERATION", NO_OPERATION },
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
        /// 资源模式   * &#x60;DATA&#x60; - 指可以在模板解析期间运行和获取服务端数据的资源类型，不会操作基础设施组件   * &#x60;RESOURCE&#x60; - 指通过模板管理的由服务定义的基础设施组件抽象，可以是物理资源也可以是逻辑资源
        /// </summary>
        /// <value>资源模式   * &#x60;DATA&#x60; - 指可以在模板解析期间运行和获取服务端数据的资源类型，不会操作基础设施组件   * &#x60;RESOURCE&#x60; - 指通过模板管理的由服务定义的基础设施组件抽象，可以是物理资源也可以是逻辑资源</value>
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
        /// 资源的类型  以HCL格式的模板为例，resource_type 为 huaweicloud_vpc  &#x60;&#x60;&#x60;hcl resource \&quot;huaweicloud_vpc\&quot; \&quot;my_hello_world_vpc\&quot; {   name &#x3D; \&quot;test_vpc\&quot; } &#x60;&#x60;&#x60;  以json格式的模板为例，resource_type 为 huaweicloud_vpc  &#x60;&#x60;&#x60;json {   \&quot;resource\&quot;: {     \&quot;huaweicloud_vpc\&quot;: {       \&quot;my_hello_world_vpc\&quot;: {         \&quot;name\&quot;: \&quot;test_vpc\&quot;       }     }   } } &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 资源的名称，默认为资源的逻辑名称  以HCL格式的模板为例，resource_name 为 my_hello_world_vpc  &#x60;&#x60;&#x60;hcl resource \&quot;huaweicloud_vpc\&quot; \&quot;my_hello_world_vpc\&quot; {   name &#x3D; \&quot;test_vpc\&quot; } &#x60;&#x60;&#x60;  以json格式的模板为例，resource_name 为 my_hello_world_vpc  &#x60;&#x60;&#x60;json {   \&quot;resource\&quot;: {     \&quot;huaweicloud_vpc\&quot;: {       \&quot;my_hello_world_vpc\&quot;: {         \&quot;name\&quot;: \&quot;test_vpc\&quot;       }     }   } } &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 资源的索引，如果用户在模板中使用了count或for_each则会返回index。如果index出现，则resource_name + index可以作为该资源的一种标识  如果用户在模板中使用count，则index为从0开始的数字  以HCL格式的模板为例，用户在模板中可以通过&#x60;huaweicloud_vpc.my_hello_world_vpc[0]&#x60;和&#x60;huaweicloud_vpc.my_hello_world_vpc[1]&#x60;标识两个资源  &#x60;&#x60;&#x60;hcl resource \&quot;huaweicloud_vpc\&quot; \&quot;my_hello_world_vpc\&quot; {   count &#x3D; 2   name &#x3D; \&quot;test_vpc\&quot; } &#x60;&#x60;&#x60;  以json格式的模板为例，用户在模板中可以通过&#x60;huaweicloud_vpc.my_hello_world_vpc[0]&#x60;和&#x60;huaweicloud_vpc.my_hello_world_vpc[1]&#x60;标识两个资源  &#x60;&#x60;&#x60;json {   \&quot;resource\&quot;: {     \&quot;huaweicloud_vpc\&quot;: {       \&quot;my_hello_world_vpc\&quot;: {         \&quot;name\&quot;: \&quot;test_vpc\&quot;,         \&quot;count\&quot;: 2       }     }   } } &#x60;&#x60;&#x60;  如果用户在模板中使用for_each，则index为用户自定义的字符串  以HCL格式的模板为例，用户在模板中可以通过&#x60;huaweicloud_vpc.my_hello_world_vpc[\&quot;vpc1\&quot;]&#x60;和&#x60;huaweicloud_vpc.my_hello_world_vpc[\&quot;vpc2\&quot;]&#x60;标识两个资源  &#x60;&#x60;&#x60;hcl resource \&quot;huaweicloud_vpc\&quot; \&quot;my_hello_world_vpc\&quot; {   for_each &#x3D; {     \&quot;vpc1\&quot; &#x3D; \&quot;test_vpc\&quot;     \&quot;vpc2\&quot; &#x3D; \&quot;test_vpc\&quot;   }   name &#x3D; each.value } &#x60;&#x60;&#x60;  以json格式的模板为例，用户在模板中可以通过&#x60;huaweicloud_vpc.my_hello_world_vpc[\&quot;vpc1\&quot;]&#x60;和&#x60;huaweicloud_vpc.my_hello_world_vpc[\&quot;vpc2\&quot;]&#x60;标识两个资源  &#x60;&#x60;&#x60;json {   \&quot;resource\&quot;: {     \&quot;huaweicloud_vpc\&quot;: {       \&quot;my_hello_world_vpc\&quot;: {         \&quot;for_each\&quot;: {           \&quot;vpc1\&quot;: \&quot;test_vpc\&quot;,           \&quot;vpc2\&quot;: \&quot;test_vpc\&quot;         }         \&quot;name\&quot;: \&quot;${each.value}\&quot;       }     }   } } &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public string Index { get; set; }

        /// <summary>
        /// 资源变更的类型   * &#x60;ADD&#x60; - 新增资源   * &#x60;ADD_THEN_DELETE&#x60; - 由不可更新的资源返回，先创建新资源，再删除旧资源   * &#x60;DELETE &#x60; - 删除资源   * &#x60;DELETE_THEN_ADD&#x60; - 由不可更新的资源返回，先删除旧资源，再创建新资源   * &#x60;UPDATE&#x60; - 更新资源    * &#x60;NO_OPERATION&#x60; - 仅变更资源的依赖关系，但是对资源本身并无修改的操作
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 触发该项目变更的原因，例如用户更新模板；远端删除资源等等
        /// </summary>
        [JsonProperty("action_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionReason { get; set; }

        /// <summary>
        /// 该项目所属的provider名称。
        /// </summary>
        [JsonProperty("provider_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderName { get; set; }

        /// <summary>
        /// 资源模式   * &#x60;DATA&#x60; - 指可以在模板解析期间运行和获取服务端数据的资源类型，不会操作基础设施组件   * &#x60;RESOURCE&#x60; - 指通过模板管理的由服务定义的基础设施组件抽象，可以是物理资源也可以是逻辑资源
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// 当前资源的变更是否由偏差导致。  偏差，也叫漂移。指的是资源被资源编排服务创建以后，又经历过非资源编排服务触发的修改，如手动修改、调用SDK修改等，使得资源的配置与本服务所记录的资源的配置不一致。这种不一致便称为偏差。  当资源产生偏差以后： * 如果用户试图创建执行计划，则会提示用户产生偏差 * 如果用户直接部署，则偏差有可能被覆盖，资源编排服务只保证资源和模板最终一致。  资源的偏差有两种类型： * 资源定位属性被修改：如果是定位属性被修改，常见于删除后重建，此时资源已经不属于同一个资源。资源编排服务会认为此资源已经被删除，会尝试创建一个新的资源。 * 资源普通属性被修改：如果是普通属性被修改，则资源编排服务依然可以找到资源，但是下次部署会尝试修复偏差，即将资源保持和模板最终一致。  **注：资源编排服务团队极力推荐，如果资源是通过本服务创建的，请一直使用本服务进行维护和更新以确保资源和模板保持一致。建议非紧急事件以外的情况不要手动调整。**
        /// </summary>
        [JsonProperty("drifted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Drifted { get; set; }

        /// <summary>
        /// 当前资源的变更是否是导入的。
        /// </summary>
        [JsonProperty("imported", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Imported { get; set; }

        /// <summary>
        /// 资源的物理id，是唯一id，由为该资源提供服务的provider、云服务或其他服务提供方在资源部署的时候生成
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 执行计划项目中变更的属性，当无属性变更时为空列表。
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
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  index: ").Append(Index).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  actionReason: ").Append(ActionReason).Append("\n");
            sb.Append("  providerName: ").Append(ProviderName).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  drifted: ").Append(Drifted).Append("\n");
            sb.Append("  imported: ").Append(Imported).Append("\n");
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
            if (input == null) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.Index != input.Index || (this.Index != null && !this.Index.Equals(input.Index))) return false;
            if (this.Action != input.Action) return false;
            if (this.ActionReason != input.ActionReason || (this.ActionReason != null && !this.ActionReason.Equals(input.ActionReason))) return false;
            if (this.ProviderName != input.ProviderName || (this.ProviderName != null && !this.ProviderName.Equals(input.ProviderName))) return false;
            if (this.Mode != input.Mode) return false;
            if (this.Drifted != input.Drifted || (this.Drifted != null && !this.Drifted.Equals(input.Drifted))) return false;
            if (this.Imported != input.Imported || (this.Imported != null && !this.Imported.Equals(input.Imported))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.Attributes != input.Attributes || (this.Attributes != null && input.Attributes != null && !this.Attributes.SequenceEqual(input.Attributes))) return false;

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
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.Index != null) hashCode = hashCode * 59 + this.Index.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ActionReason != null) hashCode = hashCode * 59 + this.ActionReason.GetHashCode();
                if (this.ProviderName != null) hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Drifted != null) hashCode = hashCode * 59 + this.Drifted.GetHashCode();
                if (this.Imported != null) hashCode = hashCode * 59 + this.Imported.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.Attributes != null) hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                return hashCode;
            }
        }
    }
}
