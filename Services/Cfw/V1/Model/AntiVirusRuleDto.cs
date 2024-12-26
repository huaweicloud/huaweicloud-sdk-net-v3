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
    public class AntiVirusRuleDto 
    {

        /// <summary>
        /// 防护对象ID
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 扫描协议配置
        /// </summary>
        [JsonProperty("scan_protocol_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScanProtocolConfig> ScanProtocolConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AntiVirusRuleDto {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  scanProtocolConfigs: ").Append(ScanProtocolConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AntiVirusRuleDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AntiVirusRuleDto input)
        {
            if (input == null) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.ScanProtocolConfigs != input.ScanProtocolConfigs || (this.ScanProtocolConfigs != null && input.ScanProtocolConfigs != null && !this.ScanProtocolConfigs.SequenceEqual(input.ScanProtocolConfigs))) return false;

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
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.ScanProtocolConfigs != null) hashCode = hashCode * 59 + this.ScanProtocolConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
