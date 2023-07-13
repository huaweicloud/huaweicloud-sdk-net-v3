using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class ChangeServerOsWithCloudInitRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os-change", NullValueHandling = NullValueHandling.Ignore)]
        public ChangeServerOsWithCloudInitOption OsChange { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeServerOsWithCloudInitRequestBody {\n");
            sb.Append("  osChange: ").Append(OsChange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeServerOsWithCloudInitRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeServerOsWithCloudInitRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OsChange == input.OsChange ||
                    (this.OsChange != null &&
                    this.OsChange.Equals(input.OsChange))
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
                if (this.OsChange != null)
                    hashCode = hashCode * 59 + this.OsChange.GetHashCode();
                return hashCode;
            }
        }
    }
}
