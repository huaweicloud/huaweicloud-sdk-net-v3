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
    public class VarsBodyPrimitiveTypeHolder 
    {

        /// <summary>
        /// HCL参数文件的内容。HCL模板支持参数传入，即，同一个模板可以给予不同的参数而达到不同的效果。  * vars_body使用HCL的tfvars格式，用户可以将“.tfvars”中的内容提交到vars_body中  * 资源编排服务支持vars_body和vars_uri，如果以上两种方式中声名了同一个变量，将报错400  * 如果vars_body过大，可以使用vars_uri  * 资源栈集不支持敏感数据加密，资源编排服务会直接明文使用、log、展示、存储对应的vars_body。
        /// </summary>
        [JsonProperty("vars_body", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsBody { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VarsBodyPrimitiveTypeHolder {\n");
            sb.Append("  varsBody: ").Append(VarsBody).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VarsBodyPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VarsBodyPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VarsBody == input.VarsBody ||
                    (this.VarsBody != null &&
                    this.VarsBody.Equals(input.VarsBody))
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
                if (this.VarsBody != null)
                    hashCode = hashCode * 59 + this.VarsBody.GetHashCode();
                return hashCode;
            }
        }
    }
}
