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
    public class VariableResponse 
    {

        /// <summary>
        /// 参数的名字  以HCL格式的模板为例，name 为 &#x60;my_hello_world_variable&#x60;  &#x60;&#x60;&#x60;hcl variable \&quot;my_hello_world_variable\&quot; {   type &#x3D; string   description &#x3D; \&quot;this is a variable\&quot;   default &#x3D; \&quot;hello world\&quot;   sensitive &#x3D; false   nullable &#x3D; false   validation {     condition     &#x3D; length(var.my_hello_world_variable) &gt; 0 &amp;&amp; substr(var.my_hello_world_variable, 0, 5) &#x3D;&#x3D; \&quot;hello\&quot;     error_message &#x3D; \&quot;my_hello_world_variable should start with &#39;hello&#39;.\&quot;   } } &#x60;&#x60;&#x60;  以json格式的模板为例，name 为 &#x60;my_hello_world_variable&#x60;  &#x60;&#x60;&#x60;json {   \&quot;variable\&quot;: {     \&quot;my_hello_world_variable\&quot;: [       {         \&quot;default\&quot;: \&quot;hello world\&quot;,         \&quot;description\&quot;: \&quot;this is a variable\&quot;,         \&quot;nullable\&quot;: false,         \&quot;sensitive\&quot;: false,         \&quot;type\&quot;: \&quot;string\&quot;,         \&quot;validation\&quot;: [           {             \&quot;condition\&quot;: \&quot;${length(var.my_hello_world_variable) &gt; 0 &amp;&amp; substr(var.my_hello_world_variable, 0, 5) &#x3D;&#x3D; \\\&quot;hello\\\&quot;}\&quot;,             \&quot;error_message\&quot;: \&quot;my_hello_world_variable should start with &#39;hello&#39;.\&quot;           }         ]       }     ]   } } &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数的类型  以HCL格式的模板为例，type 为 &#x60;string&#x60;  &#x60;&#x60;&#x60;hcl variable \&quot;my_hello_world_variable\&quot; {   type &#x3D; string   description &#x3D; \&quot;this is a variable\&quot;   default &#x3D; \&quot;hello world\&quot;   sensitive &#x3D; false   nullable &#x3D; false   validation {     condition     &#x3D; length(var.my_hello_world_variable) &gt; 0 &amp;&amp; substr(var.my_hello_world_variable, 0, 5) &#x3D;&#x3D; \&quot;hello\&quot;     error_message &#x3D; \&quot;my_hello_world_variable should start with &#39;hello&#39;.\&quot;   } } &#x60;&#x60;&#x60;  以json格式的模板为例，type 为 &#x60;string&#x60;  &#x60;&#x60;&#x60;json {   \&quot;variable\&quot;: {     \&quot;my_hello_world_variable\&quot;: [       {         \&quot;default\&quot;: \&quot;hello world\&quot;,         \&quot;description\&quot;: \&quot;this is a variable\&quot;,         \&quot;nullable\&quot;: false,         \&quot;sensitive\&quot;: false,         \&quot;type\&quot;: \&quot;string\&quot;,         \&quot;validation\&quot;: [           {             \&quot;condition\&quot;: \&quot;${length(var.my_hello_world_variable) &gt; 0 &amp;&amp; substr(var.my_hello_world_variable, 0, 5) &#x3D;&#x3D; \\\&quot;hello\\\&quot;}\&quot;,             \&quot;error_message\&quot;: \&quot;my_hello_world_variable should start with &#39;hello&#39;.\&quot;           }         ]       }     ]   } } &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 参数的描述  以HCL格式的模板为例，description 为 &#x60;this is a variable&#x60;  &#x60;&#x60;&#x60;hcl variable \&quot;my_hello_world_variable\&quot; {   type &#x3D; string   description &#x3D; \&quot;this is a variable\&quot;   default &#x3D; \&quot;hello world\&quot;   sensitive &#x3D; false   nullable &#x3D; false   validation {     condition     &#x3D; length(var.my_hello_world_variable) &gt; 0 &amp;&amp; substr(var.my_hello_world_variable, 0, 5) &#x3D;&#x3D; \&quot;hello\&quot;     error_message &#x3D; \&quot;my_hello_world_variable should start with &#39;hello&#39;.\&quot;   } } &#x60;&#x60;&#x60;  以json格式的模板为例，description 为 &#x60;this is a variable&#x60;  &#x60;&#x60;&#x60;json {   \&quot;variable\&quot;: {     \&quot;my_hello_world_variable\&quot;: [       {         \&quot;default\&quot;: \&quot;hello world\&quot;,         \&quot;description\&quot;: \&quot;this is a variable\&quot;,         \&quot;nullable\&quot;: false,         \&quot;sensitive\&quot;: false,         \&quot;type\&quot;: \&quot;string\&quot;,         \&quot;validation\&quot;: [           {             \&quot;condition\&quot;: \&quot;${length(var.my_hello_world_variable) &gt; 0 &amp;&amp; substr(var.my_hello_world_variable, 0, 5) &#x3D;&#x3D; \\\&quot;hello\\\&quot;}\&quot;,             \&quot;error_message\&quot;: \&quot;my_hello_world_variable should start with &#39;hello&#39;.\&quot;           }         ]       }     ]   } } &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 参数默认值。此返回值的类型将与type保持一致  例如，对于type为string的变量，此值的返回类型为string；对于type为number的变量，此值的返回类型为number  以HCL格式的模板为例，default 为 &#x60;hello world&#x60;  &#x60;&#x60;&#x60;hcl variable \&quot;my_hello_world_variable\&quot; {   type &#x3D; string   description &#x3D; \&quot;this is a variable\&quot;   default &#x3D; \&quot;hello world\&quot;   sensitive &#x3D; false   nullable &#x3D; false   validation {     condition     &#x3D; length(var.my_hello_world_variable) &gt; 0 &amp;&amp; substr(var.my_hello_world_variable, 0, 5) &#x3D;&#x3D; \&quot;hello\&quot;     error_message &#x3D; \&quot;my_hello_world_variable should start with &#39;hello&#39;.\&quot;   } } &#x60;&#x60;&#x60;  以json格式的模板为例，default 为 &#x60;hello world&#x60;  &#x60;&#x60;&#x60;json {   \&quot;variable\&quot;: {     \&quot;my_hello_world_variable\&quot;: [       {         \&quot;default\&quot;: \&quot;hello world\&quot;,         \&quot;description\&quot;: \&quot;this is a variable\&quot;,         \&quot;nullable\&quot;: false,         \&quot;sensitive\&quot;: false,         \&quot;type\&quot;: \&quot;string\&quot;,         \&quot;validation\&quot;: [           {             \&quot;condition\&quot;: \&quot;${length(var.my_hello_world_variable) &gt; 0 &amp;&amp; substr(var.my_hello_world_variable, 0, 5) &#x3D;&#x3D; \\\&quot;hello\\\&quot;}\&quot;,             \&quot;error_message\&quot;: \&quot;my_hello_world_variable should start with &#39;hello&#39;.\&quot;           }         ]       }     ]   } } &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public Object Default { get; set; }

        /// <summary>
        /// 参数是否为敏感字段  如果variable中没有定义sensitive，默认返回false。  以HCL格式的模板为例，sensitive 为 &#x60;false&#x60;  &#x60;&#x60;&#x60;hcl variable \&quot;my_hello_world_variable\&quot; {   type &#x3D; string   description &#x3D; \&quot;this is a variable\&quot;   default &#x3D; \&quot;hello world\&quot;   sensitive &#x3D; false   nullable &#x3D; false   validation {     condition     &#x3D; length(var.my_hello_world_variable) &gt; 0 &amp;&amp; substr(var.my_hello_world_variable, 0, 5) &#x3D;&#x3D; \&quot;hello\&quot;     error_message &#x3D; \&quot;my_hello_world_variable should start with &#39;hello&#39;.\&quot;   } } &#x60;&#x60;&#x60;  以json格式的模板为例，sensitive 为 &#x60;false&#x60;  &#x60;&#x60;&#x60;json {   \&quot;variable\&quot;: {     \&quot;my_hello_world_variable\&quot;: [       {         \&quot;default\&quot;: \&quot;hello world\&quot;,         \&quot;description\&quot;: \&quot;this is a variable\&quot;,         \&quot;nullable\&quot;: false,         \&quot;sensitive\&quot;: false,         \&quot;type\&quot;: \&quot;string\&quot;,         \&quot;validation\&quot;: [           {             \&quot;condition\&quot;: \&quot;${length(var.my_hello_world_variable) &gt; 0 &amp;&amp; substr(var.my_hello_world_variable, 0, 5) &#x3D;&#x3D; \\\&quot;hello\\\&quot;}\&quot;,             \&quot;error_message\&quot;: \&quot;my_hello_world_variable should start with &#39;hello&#39;.\&quot;           }         ]       }     ]   } } &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("sensitive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// 参数是否可设置为null。  如果variable中没有定义nullable，默认返回true。  以HCL格式的模板为例，nullable 为 &#x60;false&#x60;  &#x60;&#x60;&#x60;hcl variable \&quot;my_hello_world_variable\&quot; {   type &#x3D; string   description &#x3D; \&quot;this is a variable\&quot;   default &#x3D; \&quot;hello world\&quot;   sensitive &#x3D; false   nullable &#x3D; false   validation {     condition     &#x3D; length(var.my_hello_world_variable) &gt; 0 &amp;&amp; substr(var.my_hello_world_variable, 0, 5) &#x3D;&#x3D; \&quot;hello\&quot;     error_message &#x3D; \&quot;my_hello_world_variable should start with &#39;hello&#39;.\&quot;   } } &#x60;&#x60;&#x60;  以json格式的模板为例，nullable 为 &#x60;false&#x60;  &#x60;&#x60;&#x60;json {   \&quot;variable\&quot;: {     \&quot;my_hello_world_variable\&quot;: [       {         \&quot;default\&quot;: \&quot;hello world\&quot;,         \&quot;description\&quot;: \&quot;this is a variable\&quot;,         \&quot;nullable\&quot;: false,         \&quot;sensitive\&quot;: false,         \&quot;type\&quot;: \&quot;string\&quot;,         \&quot;validation\&quot;: [           {             \&quot;condition\&quot;: \&quot;${length(var.my_hello_world_variable) &gt; 0 &amp;&amp; substr(var.my_hello_world_variable, 0, 5) &#x3D;&#x3D; \\\&quot;hello\\\&quot;}\&quot;,             \&quot;error_message\&quot;: \&quot;my_hello_world_variable should start with &#39;hello&#39;.\&quot;           }         ]       }     ]   } } &#x60;&#x60;&#x60;
        /// </summary>
        [JsonProperty("nullable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nullable { get; set; }

        /// <summary>
        /// 参数的校验模块
        /// </summary>
        [JsonProperty("validations", NullValueHandling = NullValueHandling.Ignore)]
        public List<VariableValidationResponse> Validations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableResponse {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  sensitive: ").Append(Sensitive).Append("\n");
            sb.Append("  nullable: ").Append(Nullable).Append("\n");
            sb.Append("  validations: ").Append(Validations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VariableResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VariableResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    this.Sensitive == input.Sensitive ||
                    (this.Sensitive != null &&
                    this.Sensitive.Equals(input.Sensitive))
                ) && 
                (
                    this.Nullable == input.Nullable ||
                    (this.Nullable != null &&
                    this.Nullable.Equals(input.Nullable))
                ) && 
                (
                    this.Validations == input.Validations ||
                    this.Validations != null &&
                    input.Validations != null &&
                    this.Validations.SequenceEqual(input.Validations)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Sensitive != null)
                    hashCode = hashCode * 59 + this.Sensitive.GetHashCode();
                if (this.Nullable != null)
                    hashCode = hashCode * 59 + this.Nullable.GetHashCode();
                if (this.Validations != null)
                    hashCode = hashCode * 59 + this.Validations.GetHashCode();
                return hashCode;
            }
        }
    }
}
