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
    public class ItemsResponse 
    {

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
        /// 该资源的模块地址
        /// </summary>
        [JsonProperty("module_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleAddress { get; set; }

        /// <summary>
        /// 该资源或该资源当前所给予的参数是否支持进行询价
        /// </summary>
        [JsonProperty("supported", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Supported { get; set; }

        /// <summary>
        /// 该资源不支持询价的具体原因
        /// </summary>
        [JsonProperty("unsupported_message", NullValueHandling = NullValueHandling.Ignore)]
        public string UnsupportedMessage { get; set; }

        /// <summary>
        /// 该资源的询价信息  如果该资源支持包周期计费或按需计费，或者该资源为免费资源，则返回该字段；如果该资源不支持询价，则不返回该字段。
        /// </summary>
        [JsonProperty("resource_price", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourcePriceResponse> ResourcePrice { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemsResponse {\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  index: ").Append(Index).Append("\n");
            sb.Append("  moduleAddress: ").Append(ModuleAddress).Append("\n");
            sb.Append("  supported: ").Append(Supported).Append("\n");
            sb.Append("  unsupportedMessage: ").Append(UnsupportedMessage).Append("\n");
            sb.Append("  resourcePrice: ").Append(ResourcePrice).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ItemsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ItemsResponse input)
        {
            if (input == null)
                return false;

            return 
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
                    this.ModuleAddress == input.ModuleAddress ||
                    (this.ModuleAddress != null &&
                    this.ModuleAddress.Equals(input.ModuleAddress))
                ) && 
                (
                    this.Supported == input.Supported ||
                    (this.Supported != null &&
                    this.Supported.Equals(input.Supported))
                ) && 
                (
                    this.UnsupportedMessage == input.UnsupportedMessage ||
                    (this.UnsupportedMessage != null &&
                    this.UnsupportedMessage.Equals(input.UnsupportedMessage))
                ) && 
                (
                    this.ResourcePrice == input.ResourcePrice ||
                    this.ResourcePrice != null &&
                    input.ResourcePrice != null &&
                    this.ResourcePrice.SequenceEqual(input.ResourcePrice)
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
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.ModuleAddress != null)
                    hashCode = hashCode * 59 + this.ModuleAddress.GetHashCode();
                if (this.Supported != null)
                    hashCode = hashCode * 59 + this.Supported.GetHashCode();
                if (this.UnsupportedMessage != null)
                    hashCode = hashCode * 59 + this.UnsupportedMessage.GetHashCode();
                if (this.ResourcePrice != null)
                    hashCode = hashCode * 59 + this.ResourcePrice.GetHashCode();
                return hashCode;
            }
        }
    }
}
