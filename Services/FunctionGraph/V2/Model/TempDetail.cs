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
    /// 
    /// </summary>
    public class TempDetail 
    {

        /// <summary>
        /// 模板输入
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public string Input { get; set; }

        /// <summary>
        /// 模板输出
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public string Output { get; set; }

        /// <summary>
        /// 警告信息
        /// </summary>
        [JsonProperty("warning", NullValueHandling = NullValueHandling.Ignore)]
        public string Warning { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TempDetail {\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  output: ").Append(Output).Append("\n");
            sb.Append("  warning: ").Append(Warning).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TempDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TempDetail input)
        {
            if (input == null) return false;
            if (this.Input != input.Input || (this.Input != null && !this.Input.Equals(input.Input))) return false;
            if (this.Output != input.Output || (this.Output != null && !this.Output.Equals(input.Output))) return false;
            if (this.Warning != input.Warning || (this.Warning != null && !this.Warning.Equals(input.Warning))) return false;

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
                if (this.Input != null) hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.Output != null) hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.Warning != null) hashCode = hashCode * 59 + this.Warning.GetHashCode();
                return hashCode;
            }
        }
    }
}
