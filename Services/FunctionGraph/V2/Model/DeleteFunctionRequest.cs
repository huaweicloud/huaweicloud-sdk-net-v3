using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteFunctionRequest 
    {

        /// <summary>
        /// 函数的URN，详细解释见FunctionGraph函数模型的描述。  不允许删除函数的latest版本，如要删除整个函数（包含所有版本），提供不带任何版本号/别名的urn，如： urn:fss:xxxxxxxx:7aad83af3e8d42e99ac194e8419e2c9b:function:default:test
        /// </summary>
        [SDKProperty("function_urn", IsPath = true)]
        [JsonProperty("function_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionUrn { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteFunctionRequest {\n");
            sb.Append("  functionUrn: ").Append(FunctionUrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteFunctionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteFunctionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FunctionUrn == input.FunctionUrn ||
                    (this.FunctionUrn != null &&
                    this.FunctionUrn.Equals(input.FunctionUrn))
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
                if (this.FunctionUrn != null)
                    hashCode = hashCode * 59 + this.FunctionUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
