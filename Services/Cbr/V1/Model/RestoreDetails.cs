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
    public class RestoreDetails 
    {

        /// <summary>
        /// 目的路径
        /// </summary>
        [JsonProperty("destination_path", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationPath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreDetails {\n");
            sb.Append("  destinationPath: ").Append(DestinationPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DestinationPath == input.DestinationPath ||
                    (this.DestinationPath != null &&
                    this.DestinationPath.Equals(input.DestinationPath))
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
                if (this.DestinationPath != null)
                    hashCode = hashCode * 59 + this.DestinationPath.GetHashCode();
                return hashCode;
            }
        }
    }
}
