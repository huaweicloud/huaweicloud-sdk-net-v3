using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CreateRecordSetRequest 
    {

        /// <summary>
        /// 项目ID
        /// </summary>
        [SDKProperty("X-Zone-Project-ID", IsHeader = true)]
        [JsonProperty("X-Zone-Project-ID", NullValueHandling = NullValueHandling.Ignore)]
        public string XZoneProjectID { get; set; }

        /// <summary>
        /// DNS区域ID
        /// </summary>
        [SDKProperty("X-Zone-ID", IsHeader = true)]
        [JsonProperty("X-Zone-ID", NullValueHandling = NullValueHandling.Ignore)]
        public string XZoneID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateRecordSetRequestBody> Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRecordSetRequest {\n");
            sb.Append("  xZoneProjectID: ").Append(XZoneProjectID).Append("\n");
            sb.Append("  xZoneID: ").Append(XZoneID).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRecordSetRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRecordSetRequest input)
        {
            if (input == null) return false;
            if (this.XZoneProjectID != input.XZoneProjectID || (this.XZoneProjectID != null && !this.XZoneProjectID.Equals(input.XZoneProjectID))) return false;
            if (this.XZoneID != input.XZoneID || (this.XZoneID != null && !this.XZoneID.Equals(input.XZoneID))) return false;
            if (this.Body != input.Body || (this.Body != null && input.Body != null && !this.Body.SequenceEqual(input.Body))) return false;

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
                if (this.XZoneProjectID != null) hashCode = hashCode * 59 + this.XZoneProjectID.GetHashCode();
                if (this.XZoneID != null) hashCode = hashCode * 59 + this.XZoneID.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
