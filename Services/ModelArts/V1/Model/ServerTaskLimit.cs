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
    /// **参数解释：** 服务任务限制信息。 **约束限制：** 不涉及。
    /// </summary>
    public class ServerTaskLimit 
    {

        /// <summary>
        /// **参数解释：** 单个服务任务限制总数。 **取值范围：** [0, 10000]。
        /// </summary>
        [JsonProperty("max_task", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxTask { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerTaskLimit {\n");
            sb.Append("  maxTask: ").Append(MaxTask).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerTaskLimit);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerTaskLimit input)
        {
            if (input == null) return false;
            if (this.MaxTask != input.MaxTask || (this.MaxTask != null && !this.MaxTask.Equals(input.MaxTask))) return false;

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
                if (this.MaxTask != null) hashCode = hashCode * 59 + this.MaxTask.GetHashCode();
                return hashCode;
            }
        }
    }
}
