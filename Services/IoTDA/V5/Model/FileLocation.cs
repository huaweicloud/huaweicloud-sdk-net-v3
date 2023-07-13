using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 升级包的位置
    /// </summary>
    public class FileLocation 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_location", NullValueHandling = NullValueHandling.Ignore)]
        public ObsLocation ObsLocation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileLocation {\n");
            sb.Append("  obsLocation: ").Append(ObsLocation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FileLocation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FileLocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObsLocation == input.ObsLocation ||
                    (this.ObsLocation != null &&
                    this.ObsLocation.Equals(input.ObsLocation))
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
                if (this.ObsLocation != null)
                    hashCode = hashCode * 59 + this.ObsLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
