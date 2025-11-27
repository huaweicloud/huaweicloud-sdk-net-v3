using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rfs.V1.Model
{
    /// <summary>
    /// 资源栈输出
    /// </summary>
    public class StackOutput 
    {

        /// <summary>
        /// 资源栈输出的名称，由用户在模板中定义  以 HCL 模板为例，name 为 vpc_id  &#x60;&#x60;&#x60;hcl output \&quot;vpc_id\&quot; {   value &#x3D; huaweicloud_vpc.my_hello_world_vpc.id } &#x60;&#x60;&#x60;  以 json 模板为例，name 为 vpc_id &#x60;&#x60;&#x60;json {   \&quot;output\&quot;: {     \&quot;vpc_id\&quot;: [       {         \&quot;value\&quot;: \&quot;${huaweicloud_vpc.my_hello_world_vpc.id}\&quot;       }     ]   } } &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 资源栈输出的描述，由用户在模板中定义
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 资源栈输出的类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 资源栈输出的值
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 标识该资源栈输出是否为敏感信息，由用户在模板中定义  如果用户在模板中将该输出定义为sensitive，则返回体中该输出的value和type不会返回真实值，而是返回&#x60;&lt;sensitive&gt;&#x60;
        /// </summary>
        [JsonProperty("sensitive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sensitive { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StackOutput {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  sensitive: ").Append(Sensitive).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StackOutput);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StackOutput input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Sensitive != input.Sensitive || (this.Sensitive != null && !this.Sensitive.Equals(input.Sensitive))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Sensitive != null) hashCode = hashCode * 59 + this.Sensitive.GetHashCode();
                return hashCode;
            }
        }
    }
}
