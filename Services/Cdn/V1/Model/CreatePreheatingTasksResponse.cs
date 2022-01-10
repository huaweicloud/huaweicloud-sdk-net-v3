using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreatePreheatingTasksResponse : SdkResponse
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("preheating_task", NullValueHandling = NullValueHandling.Ignore)]
        public string PreheatingTask { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePreheatingTasksResponse {\n");
            sb.Append("  preheatingTask: ").Append(PreheatingTask).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePreheatingTasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePreheatingTasksResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PreheatingTask == input.PreheatingTask ||
                    (this.PreheatingTask != null &&
                    this.PreheatingTask.Equals(input.PreheatingTask))
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
                if (this.PreheatingTask != null)
                    hashCode = hashCode * 59 + this.PreheatingTask.GetHashCode();
                return hashCode;
            }
        }
    }
}
