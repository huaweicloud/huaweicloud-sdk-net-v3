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
    /// 
    /// </summary>
    public class RefreshTaskRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("refresh_task", NullValueHandling = NullValueHandling.Ignore)]
        public RefreshTaskRequestBody RefreshTask { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefreshTaskRequest {\n");
            sb.Append("  refreshTask: ").Append(RefreshTask).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RefreshTaskRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RefreshTaskRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RefreshTask == input.RefreshTask ||
                    (this.RefreshTask != null &&
                    this.RefreshTask.Equals(input.RefreshTask))
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
                if (this.RefreshTask != null)
                    hashCode = hashCode * 59 + this.RefreshTask.GetHashCode();
                return hashCode;
            }
        }
    }
}
