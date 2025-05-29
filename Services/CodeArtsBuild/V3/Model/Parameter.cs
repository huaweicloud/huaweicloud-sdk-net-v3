using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 构建作业参数
    /// </summary>
    public class Parameter 
    {

        /// <summary>
        /// 参数定义名，默认为hudson.model.StringParameterDefinition
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 构建执行参数子参数
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateBuildJobParameterParam> Params { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Parameter {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Parameter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Parameter input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Params != input.Params || (this.Params != null && input.Params != null && !this.Params.SequenceEqual(input.Params))) return false;

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
                if (this.Params != null) hashCode = hashCode * 59 + this.Params.GetHashCode();
                return hashCode;
            }
        }
    }
}
