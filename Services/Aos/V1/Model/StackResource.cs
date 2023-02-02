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
    /// 资源栈中所管理的资源信息
    /// </summary>
    public class StackResource 
    {
        /// <summary>
        /// 资源的状态 * &#x60;CREATION_IN_PROGRESS&#x60; - 正在生成 * &#x60;CREATION_FAILED&#x60;      - 生成失败 * &#x60;CREATION_COMPLETE&#x60;    - 生成完成 * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除 * &#x60;DELETION_FAILED&#x60;      - 删除失败 * &#x60;DELETION_COMPLETE&#x60;    - 已经删除 * &#x60;UPDATE_IN_PROGRESS&#x60;   - 正在更新。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后DELETION * &#x60;UPDATE_FAILED&#x60;        - 更新失败。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后DELETION * &#x60;UPDATE_COMPLETE&#x60;      - 更新完成。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后DELETION 
        /// </summary>
        /// <value>资源的状态 * &#x60;CREATION_IN_PROGRESS&#x60; - 正在生成 * &#x60;CREATION_FAILED&#x60;      - 生成失败 * &#x60;CREATION_COMPLETE&#x60;    - 生成完成 * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除 * &#x60;DELETION_FAILED&#x60;      - 删除失败 * &#x60;DELETION_COMPLETE&#x60;    - 已经删除 * &#x60;UPDATE_IN_PROGRESS&#x60;   - 正在更新。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后DELETION * &#x60;UPDATE_FAILED&#x60;        - 更新失败。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后DELETION * &#x60;UPDATE_COMPLETE&#x60;      - 更新完成。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后DELETION </value>
        [JsonConverter(typeof(EnumClassConverter<ResourceStatusEnum>))]
        public class ResourceStatusEnum
        {
            /// <summary>
            /// Enum CREATION_IN_PROGRESS for value: CREATION_IN_PROGRESS
            /// </summary>
            public static readonly ResourceStatusEnum CREATION_IN_PROGRESS = new ResourceStatusEnum("CREATION_IN_PROGRESS");

            /// <summary>
            /// Enum CREATION_FAILED for value: CREATION_FAILED
            /// </summary>
            public static readonly ResourceStatusEnum CREATION_FAILED = new ResourceStatusEnum("CREATION_FAILED");

            /// <summary>
            /// Enum CREATION_COMPLETE for value: CREATION_COMPLETE
            /// </summary>
            public static readonly ResourceStatusEnum CREATION_COMPLETE = new ResourceStatusEnum("CREATION_COMPLETE");

            /// <summary>
            /// Enum DELETION_IN_PROGRESS for value: DELETION_IN_PROGRESS
            /// </summary>
            public static readonly ResourceStatusEnum DELETION_IN_PROGRESS = new ResourceStatusEnum("DELETION_IN_PROGRESS");

            /// <summary>
            /// Enum DELETION_FAILED for value: DELETION_FAILED
            /// </summary>
            public static readonly ResourceStatusEnum DELETION_FAILED = new ResourceStatusEnum("DELETION_FAILED");

            /// <summary>
            /// Enum DELETION_COMPLETE for value: DELETION_COMPLETE
            /// </summary>
            public static readonly ResourceStatusEnum DELETION_COMPLETE = new ResourceStatusEnum("DELETION_COMPLETE");

            /// <summary>
            /// Enum UPDATE_IN_PROGRESS for value: UPDATE_IN_PROGRESS
            /// </summary>
            public static readonly ResourceStatusEnum UPDATE_IN_PROGRESS = new ResourceStatusEnum("UPDATE_IN_PROGRESS");

            /// <summary>
            /// Enum UPDATE_FAILED for value: UPDATE_FAILED
            /// </summary>
            public static readonly ResourceStatusEnum UPDATE_FAILED = new ResourceStatusEnum("UPDATE_FAILED");

            /// <summary>
            /// Enum UPDATE_COMPLETE for value: UPDATE_COMPLETE
            /// </summary>
            public static readonly ResourceStatusEnum UPDATE_COMPLETE = new ResourceStatusEnum("UPDATE_COMPLETE");

            private static readonly Dictionary<string, ResourceStatusEnum> StaticFields =
            new Dictionary<string, ResourceStatusEnum>()
            {
                { "CREATION_IN_PROGRESS", CREATION_IN_PROGRESS },
                { "CREATION_FAILED", CREATION_FAILED },
                { "CREATION_COMPLETE", CREATION_COMPLETE },
                { "DELETION_IN_PROGRESS", DELETION_IN_PROGRESS },
                { "DELETION_FAILED", DELETION_FAILED },
                { "DELETION_COMPLETE", DELETION_COMPLETE },
                { "UPDATE_IN_PROGRESS", UPDATE_IN_PROGRESS },
                { "UPDATE_FAILED", UPDATE_FAILED },
                { "UPDATE_COMPLETE", UPDATE_COMPLETE },
            };

            private string _value;

            public ResourceStatusEnum()
            {

            }

            public ResourceStatusEnum(string value)
            {
                _value = value;
            }

            public static ResourceStatusEnum FromValue(string value)
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

                if (this.Equals(obj as ResourceStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResourceStatusEnum a, ResourceStatusEnum b)
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

            public static bool operator !=(ResourceStatusEnum a, ResourceStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资源的物理id，由为该资源提供服务的provider在资源部署的时候生成  注：与physical相关的参数可以在模板以外的地方，作为该资源的一种标识 
        /// </summary>
        [JsonProperty("physical_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PhysicalResourceId { get; set; }

        /// <summary>
        /// 资源的物理名称，由为该资源提供服务的provider在资源部署的时候定义  注：与physical相关的参数可以在模板以外的地方，作为该资源的一种标识 
        /// </summary>
        [JsonProperty("physical_resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PhysicalResourceName { get; set; }

        /// <summary>
        /// 资源的逻辑名称，由用户在模板中定义  注：与 logical 相关的参数仅仅在模板内部，作为该资源的一种标识  以hcl格式的模板为例，logical_resource_name 为 my_hello_world_vpc  &#x60;&#x60;&#x60;hcl resource \&quot;huaweicloud_vpc\&quot; \&quot;my_hello_world_vpc\&quot; {   name &#x3D; \&quot;test_vpc\&quot; } &#x60;&#x60;&#x60;  以json格式的模板为例，logical_resource_name 为 my_hello_world_vpc  &#x60;&#x60;&#x60;json {   \&quot;resource\&quot;: {     \&quot;huaweicloud_vpc\&quot;: {       \&quot;my_hello_world_vpc\&quot;: {         \&quot;name\&quot;: \&quot;test_vpc\&quot;       }     }   } } &#x60;&#x60;&#x60; 
        /// </summary>
        [JsonProperty("logical_resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogicalResourceName { get; set; }

        /// <summary>
        /// 资源的类型  注：与 logical 相关的参数仅仅在模板内部，作为该资源的一种标识  以hcl格式的模板为例，logical_resource_type 为 huaweicloud_vpc  &#x60;&#x60;&#x60;hcl resource \&quot;huaweicloud_vpc\&quot; \&quot;my_hello_world_vpc\&quot; {   name &#x3D; \&quot;test_vpc\&quot; } &#x60;&#x60;&#x60;  以json格式的模板为例，logical_resource_type 为 huaweicloud_vpc  &#x60;&#x60;&#x60;json {   \&quot;resource\&quot;: {     \&quot;huaweicloud_vpc\&quot;: {       \&quot;my_hello_world_vpc\&quot;: {         \&quot;name\&quot;: \&quot;test_vpc\&quot;       }     }   } } &#x60;&#x60;&#x60; 
        /// </summary>
        [JsonProperty("logical_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LogicalResourceType { get; set; }

        /// <summary>
        /// 资源的索引，若用户在模板中使用了count或for_each则会返回index_key。若index_key出现，则logical_resource_name + index_key可以作为该资源的一种标识  若用户在模板中使用count，则index_key为从0开始的数字  以hcl格式的模板为例，用户在模板中可以通过&#x60;huaweicloud_vpc.my_hello_world_vpc[0]&#x60;和&#x60;huaweicloud_vpc.my_hello_world_vpc[1]&#x60;标识两个资源  &#x60;&#x60;&#x60;hcl resource \&quot;huaweicloud_vpc\&quot; \&quot;my_hello_world_vpc\&quot; {   count &#x3D; 2   name &#x3D; \&quot;test_vpc\&quot; } &#x60;&#x60;&#x60;  以json格式的模板为例，用户在模板中可以通过&#x60;huaweicloud_vpc.my_hello_world_vpc[0]&#x60;和&#x60;huaweicloud_vpc.my_hello_world_vpc[1]&#x60;标识两个资源  &#x60;&#x60;&#x60;json {   \&quot;resource\&quot;: {     \&quot;huaweicloud_vpc\&quot;: {       \&quot;my_hello_world_vpc\&quot;: {         \&quot;name\&quot;: \&quot;test_vpc\&quot;,         \&quot;count\&quot;: 2       }     }   } } &#x60;&#x60;&#x60;  若用户在模板中使用for_each，则index_key为用户自定义的字符串  以hcl格式的模板为例，用户在模板中可以通过&#x60;huaweicloud_vpc.my_hello_world_vpc[\&quot;vpc1\&quot;]&#x60;和&#x60;huaweicloud_vpc.my_hello_world_vpc[\&quot;vpc2\&quot;]&#x60;标识两个资源  &#x60;&#x60;&#x60;hcl resource \&quot;huaweicloud_vpc\&quot; \&quot;my_hello_world_vpc\&quot; {   for_each &#x3D; {     \&quot;vpc1\&quot; &#x3D; \&quot;test_vpc\&quot;     \&quot;vpc2\&quot; &#x3D; \&quot;test_vpc\&quot;   }   name &#x3D; each.value } &#x60;&#x60;&#x60;  以json格式的模板为例，用户在模板中可以通过&#x60;huaweicloud_vpc.my_hello_world_vpc[\&quot;vpc1\&quot;]&#x60;和&#x60;huaweicloud_vpc.my_hello_world_vpc[\&quot;vpc2\&quot;]&#x60;标识两个资源  &#x60;&#x60;&#x60;json {   \&quot;resource\&quot;: {     \&quot;huaweicloud_vpc\&quot;: {       \&quot;my_hello_world_vpc\&quot;: {         \&quot;for_each\&quot;: {           \&quot;vpc1\&quot;: \&quot;test_vpc\&quot;,           \&quot;vpc2\&quot;: \&quot;test_vpc\&quot;         }         \&quot;name\&quot;: \&quot;${each.value}\&quot;       }     }   } } &#x60;&#x60;&#x60; 
        /// </summary>
        [JsonProperty("index_key", NullValueHandling = NullValueHandling.Ignore)]
        public string IndexKey { get; set; }

        /// <summary>
        /// 资源的状态 * &#x60;CREATION_IN_PROGRESS&#x60; - 正在生成 * &#x60;CREATION_FAILED&#x60;      - 生成失败 * &#x60;CREATION_COMPLETE&#x60;    - 生成完成 * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除 * &#x60;DELETION_FAILED&#x60;      - 删除失败 * &#x60;DELETION_COMPLETE&#x60;    - 已经删除 * &#x60;UPDATE_IN_PROGRESS&#x60;   - 正在更新。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后DELETION * &#x60;UPDATE_FAILED&#x60;        - 更新失败。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后DELETION * &#x60;UPDATE_COMPLETE&#x60;      - 更新完成。此处的更新特指非替换式更新，如果是替换式更新，则使用CREATION后DELETION 
        /// </summary>
        [JsonProperty("resource_status", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceStatusEnum ResourceStatus { get; set; }
        /// <summary>
        /// 当该资源状态为任意失败状态（即以 &#x60;FAILED&#x60; 结尾时），将会展示简要的错误信息总结以供debug
        /// </summary>
        [JsonProperty("status_message", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StackResource {\n");
            sb.Append("  physicalResourceId: ").Append(PhysicalResourceId).Append("\n");
            sb.Append("  physicalResourceName: ").Append(PhysicalResourceName).Append("\n");
            sb.Append("  logicalResourceName: ").Append(LogicalResourceName).Append("\n");
            sb.Append("  logicalResourceType: ").Append(LogicalResourceType).Append("\n");
            sb.Append("  indexKey: ").Append(IndexKey).Append("\n");
            sb.Append("  resourceStatus: ").Append(ResourceStatus).Append("\n");
            sb.Append("  statusMessage: ").Append(StatusMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StackResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StackResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhysicalResourceId == input.PhysicalResourceId ||
                    (this.PhysicalResourceId != null &&
                    this.PhysicalResourceId.Equals(input.PhysicalResourceId))
                ) && 
                (
                    this.PhysicalResourceName == input.PhysicalResourceName ||
                    (this.PhysicalResourceName != null &&
                    this.PhysicalResourceName.Equals(input.PhysicalResourceName))
                ) && 
                (
                    this.LogicalResourceName == input.LogicalResourceName ||
                    (this.LogicalResourceName != null &&
                    this.LogicalResourceName.Equals(input.LogicalResourceName))
                ) && 
                (
                    this.LogicalResourceType == input.LogicalResourceType ||
                    (this.LogicalResourceType != null &&
                    this.LogicalResourceType.Equals(input.LogicalResourceType))
                ) && 
                (
                    this.IndexKey == input.IndexKey ||
                    (this.IndexKey != null &&
                    this.IndexKey.Equals(input.IndexKey))
                ) && 
                (
                    this.ResourceStatus == input.ResourceStatus ||
                    (this.ResourceStatus != null &&
                    this.ResourceStatus.Equals(input.ResourceStatus))
                ) && 
                (
                    this.StatusMessage == input.StatusMessage ||
                    (this.StatusMessage != null &&
                    this.StatusMessage.Equals(input.StatusMessage))
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
                if (this.PhysicalResourceId != null)
                    hashCode = hashCode * 59 + this.PhysicalResourceId.GetHashCode();
                if (this.PhysicalResourceName != null)
                    hashCode = hashCode * 59 + this.PhysicalResourceName.GetHashCode();
                if (this.LogicalResourceName != null)
                    hashCode = hashCode * 59 + this.LogicalResourceName.GetHashCode();
                if (this.LogicalResourceType != null)
                    hashCode = hashCode * 59 + this.LogicalResourceType.GetHashCode();
                if (this.IndexKey != null)
                    hashCode = hashCode * 59 + this.IndexKey.GetHashCode();
                if (this.ResourceStatus != null)
                    hashCode = hashCode * 59 + this.ResourceStatus.GetHashCode();
                if (this.StatusMessage != null)
                    hashCode = hashCode * 59 + this.StatusMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
