using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 精调训练环境变量信息
    /// </summary>
    public class TaskEnv 
    {

        /// <summary>
        /// 精调训练环境变量信息
        /// </summary>
        [JsonProperty("envs", NullValueHandling = NullValueHandling.Ignore)]
        public List<EnvVar> Envs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskEnv {\n");
            sb.Append("  envs: ").Append(Envs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskEnv);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskEnv input)
        {
            if (input == null) return false;
            if (this.Envs != input.Envs || (this.Envs != null && input.Envs != null && !this.Envs.SequenceEqual(input.Envs))) return false;

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
                if (this.Envs != null) hashCode = hashCode * 59 + this.Envs.GetHashCode();
                return hashCode;
            }
        }
    }
}
