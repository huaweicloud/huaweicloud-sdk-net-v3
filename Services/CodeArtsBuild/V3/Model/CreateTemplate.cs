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
    /// 模板中构建执行步骤列表
    /// </summary>
    public class CreateTemplate 
    {

        /// <summary>
        /// 构建执行的步骤
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateTemplateSteps> Steps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTemplate {\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTemplate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTemplate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
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
                if (this.Steps != null)
                    hashCode = hashCode * 59 + this.Steps.GetHashCode();
                return hashCode;
            }
        }
    }
}
