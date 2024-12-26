using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AntiVirusSwitchDto 
    {

        /// <summary>
        /// 反病毒开关状态
        /// </summary>
        [JsonProperty("anti_virus_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? AntiVirusStatus { get; set; }

        /// <summary>
        /// 防护对象ID
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AntiVirusSwitchDto {\n");
            sb.Append("  antiVirusStatus: ").Append(AntiVirusStatus).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AntiVirusSwitchDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AntiVirusSwitchDto input)
        {
            if (input == null) return false;
            if (this.AntiVirusStatus != input.AntiVirusStatus || (this.AntiVirusStatus != null && !this.AntiVirusStatus.Equals(input.AntiVirusStatus))) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;

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
                if (this.AntiVirusStatus != null) hashCode = hashCode * 59 + this.AntiVirusStatus.GetHashCode();
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
