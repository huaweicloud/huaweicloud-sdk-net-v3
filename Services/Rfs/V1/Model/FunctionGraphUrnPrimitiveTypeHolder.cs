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
    /// 
    /// </summary>
    public class FunctionGraphUrnPrimitiveTypeHolder 
    {

        /// <summary>
        /// FunctionGraph方法的统一资源标识，用于唯一标识的FunctionGraph方法。当前只支持和RFS同region的function_graph_urn，如果给予了关于其他region的，会报错400。  关于该参数的详细解释，请参考官方文档：https://support.huaweicloud.com/api-functiongraph/functiongraph_06_0102.html
        /// </summary>
        [JsonProperty("function_graph_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionGraphUrn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FunctionGraphUrnPrimitiveTypeHolder {\n");
            sb.Append("  functionGraphUrn: ").Append(FunctionGraphUrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FunctionGraphUrnPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FunctionGraphUrnPrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.FunctionGraphUrn != input.FunctionGraphUrn || (this.FunctionGraphUrn != null && !this.FunctionGraphUrn.Equals(input.FunctionGraphUrn))) return false;

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
                if (this.FunctionGraphUrn != null) hashCode = hashCode * 59 + this.FunctionGraphUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
