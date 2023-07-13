using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TaskOutput 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs", NullValueHandling = NullValueHandling.Ignore)]
        public TaskOutputObs Obs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskOutput {\n");
            sb.Append("  obs: ").Append(Obs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskOutput);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Obs == input.Obs ||
                    (this.Obs != null &&
                    this.Obs.Equals(input.Obs))
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
                if (this.Obs != null)
                    hashCode = hashCode * 59 + this.Obs.GetHashCode();
                return hashCode;
            }
        }
    }
}
