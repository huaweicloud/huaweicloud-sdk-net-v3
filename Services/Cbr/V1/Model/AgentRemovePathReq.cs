using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AgentRemovePathReq 
    {

        /// <summary>
        /// 移除备份路径详情 
        /// </summary>
        [JsonProperty("remove_path", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RemovePath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentRemovePathReq {\n");
            sb.Append("  removePath: ").Append(RemovePath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentRemovePathReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentRemovePathReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RemovePath == input.RemovePath ||
                    this.RemovePath != null &&
                    input.RemovePath != null &&
                    this.RemovePath.SequenceEqual(input.RemovePath)
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
                if (this.RemovePath != null)
                    hashCode = hashCode * 59 + this.RemovePath.GetHashCode();
                return hashCode;
            }
        }
    }
}
