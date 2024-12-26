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
    public class AntiVirusVO 
    {

        /// <summary>
        /// 反病毒开关状态，0表示关闭，1表示开启
        /// </summary>
        [JsonProperty("anti_virus_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? AntiVirusStatus { get; set; }

        /// <summary>
        /// 防护对象id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AntiVirusVO {\n");
            sb.Append("  antiVirusStatus: ").Append(AntiVirusStatus).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AntiVirusVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AntiVirusVO input)
        {
            if (input == null) return false;
            if (this.AntiVirusStatus != input.AntiVirusStatus || (this.AntiVirusStatus != null && !this.AntiVirusStatus.Equals(input.AntiVirusStatus))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
