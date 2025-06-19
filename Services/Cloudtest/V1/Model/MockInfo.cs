using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MockInfo 
    {

        /// <summary>
        /// mock id
        /// </summary>
        [JsonProperty("mock_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MockId { get; set; }

        /// <summary>
        /// mock开关
        /// </summary>
        [JsonProperty("mock_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MockSwitch { get; set; }

        /// <summary>
        /// mock url
        /// </summary>
        [JsonProperty("mock_url", NullValueHandling = NullValueHandling.Ignore)]
        public string MockUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MockInfo {\n");
            sb.Append("  mockId: ").Append(MockId).Append("\n");
            sb.Append("  mockSwitch: ").Append(MockSwitch).Append("\n");
            sb.Append("  mockUrl: ").Append(MockUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MockInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MockInfo input)
        {
            if (input == null) return false;
            if (this.MockId != input.MockId || (this.MockId != null && !this.MockId.Equals(input.MockId))) return false;
            if (this.MockSwitch != input.MockSwitch || (this.MockSwitch != null && !this.MockSwitch.Equals(input.MockSwitch))) return false;
            if (this.MockUrl != input.MockUrl || (this.MockUrl != null && !this.MockUrl.Equals(input.MockUrl))) return false;

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
                if (this.MockId != null) hashCode = hashCode * 59 + this.MockId.GetHashCode();
                if (this.MockSwitch != null) hashCode = hashCode * 59 + this.MockSwitch.GetHashCode();
                if (this.MockUrl != null) hashCode = hashCode * 59 + this.MockUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
