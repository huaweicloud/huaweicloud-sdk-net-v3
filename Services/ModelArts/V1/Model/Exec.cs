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
    /// 
    /// </summary>
    public class Exec 
    {

        /// <summary>
        /// **参数解释**： 命令行方式采集指标。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Command { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Exec {\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Exec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Exec input)
        {
            if (input == null) return false;
            if (this.Command != input.Command || (this.Command != null && input.Command != null && !this.Command.SequenceEqual(input.Command))) return false;

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
                if (this.Command != null) hashCode = hashCode * 59 + this.Command.GetHashCode();
                return hashCode;
            }
        }
    }
}
