using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 函数工作流转发配置信息
    /// </summary>
    public class FunctionGraphForwarding 
    {

        /// <summary>
        /// **参数说明**：函数的URN（Uniform Resource Name），唯一标识函数。
        /// </summary>
        [JsonProperty("func_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FuncUrn { get; set; }

        /// <summary>
        /// **参数说明**：函数名称。
        /// </summary>
        [JsonProperty("func_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FuncName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FunctionGraphForwarding {\n");
            sb.Append("  funcUrn: ").Append(FuncUrn).Append("\n");
            sb.Append("  funcName: ").Append(FuncName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FunctionGraphForwarding);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FunctionGraphForwarding input)
        {
            if (input == null) return false;
            if (this.FuncUrn != input.FuncUrn || (this.FuncUrn != null && !this.FuncUrn.Equals(input.FuncUrn))) return false;
            if (this.FuncName != input.FuncName || (this.FuncName != null && !this.FuncName.Equals(input.FuncName))) return false;

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
                if (this.FuncUrn != null) hashCode = hashCode * 59 + this.FuncUrn.GetHashCode();
                if (this.FuncName != null) hashCode = hashCode * 59 + this.FuncName.GetHashCode();
                return hashCode;
            }
        }
    }
}
