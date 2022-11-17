using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 支持的磁盘IO类型信息。
    /// </summary>
    public class ListEngineIosEntity 
    {

        /// <summary>
        /// 磁盘IO编码。
        /// </summary>
        [JsonProperty("io_spec", NullValueHandling = NullValueHandling.Ignore)]
        public string IoSpec { get; set; }

        /// <summary>
        /// 磁盘类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 可用区。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// 不可用区。
        /// </summary>
        [JsonProperty("unavailable_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UnavailableZones { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEngineIosEntity {\n");
            sb.Append("  ioSpec: ").Append(IoSpec).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  unavailableZones: ").Append(UnavailableZones).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEngineIosEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEngineIosEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IoSpec == input.IoSpec ||
                    (this.IoSpec != null &&
                    this.IoSpec.Equals(input.IoSpec))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.AvailableZones == input.AvailableZones ||
                    this.AvailableZones != null &&
                    input.AvailableZones != null &&
                    this.AvailableZones.SequenceEqual(input.AvailableZones)
                ) && 
                (
                    this.UnavailableZones == input.UnavailableZones ||
                    this.UnavailableZones != null &&
                    input.UnavailableZones != null &&
                    this.UnavailableZones.SequenceEqual(input.UnavailableZones)
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
                if (this.IoSpec != null)
                    hashCode = hashCode * 59 + this.IoSpec.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AvailableZones != null)
                    hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.UnavailableZones != null)
                    hashCode = hashCode * 59 + this.UnavailableZones.GetHashCode();
                return hashCode;
            }
        }
    }
}
