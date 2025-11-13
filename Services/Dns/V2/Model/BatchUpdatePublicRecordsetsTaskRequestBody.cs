using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchUpdatePublicRecordsetsTaskRequestBody 
    {

        /// <summary>
        /// **参数解释：** 托管该记录的域名。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("zone_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ZoneNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public BatchUpdatePublicRecordsetsFilter Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("update_info", NullValueHandling = NullValueHandling.Ignore)]
        public BatchUpdatePublicRecordsetsUpdateValue UpdateInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdatePublicRecordsetsTaskRequestBody {\n");
            sb.Append("  zoneNames: ").Append(ZoneNames).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  updateInfo: ").Append(UpdateInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdatePublicRecordsetsTaskRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdatePublicRecordsetsTaskRequestBody input)
        {
            if (input == null) return false;
            if (this.ZoneNames != input.ZoneNames || (this.ZoneNames != null && input.ZoneNames != null && !this.ZoneNames.SequenceEqual(input.ZoneNames))) return false;
            if (this.Filter != input.Filter || (this.Filter != null && !this.Filter.Equals(input.Filter))) return false;
            if (this.UpdateInfo != input.UpdateInfo || (this.UpdateInfo != null && !this.UpdateInfo.Equals(input.UpdateInfo))) return false;

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
                if (this.ZoneNames != null) hashCode = hashCode * 59 + this.ZoneNames.GetHashCode();
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.UpdateInfo != null) hashCode = hashCode * 59 + this.UpdateInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
