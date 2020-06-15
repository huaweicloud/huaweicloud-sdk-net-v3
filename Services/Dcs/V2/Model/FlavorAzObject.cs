using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FlavorAzObject 
    {

        /// <summary>
        /// 缓存容量。
        /// </summary>
        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public string Capacity { get; set; }

        /// <summary>
        /// 有资源的可用区编码。
        /// </summary>
        [JsonProperty("az_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AzCodes { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlavorAzObject {\n");
            sb.Append("  capacity: ").Append(Capacity).Append("\n");
            sb.Append("  azCodes: ").Append(AzCodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlavorAzObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlavorAzObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
                ) && 
                (
                    this.AzCodes == input.AzCodes ||
                    this.AzCodes != null &&
                    input.AzCodes != null &&
                    this.AzCodes.SequenceEqual(input.AzCodes)
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
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.AzCodes != null)
                    hashCode = hashCode * 59 + this.AzCodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
