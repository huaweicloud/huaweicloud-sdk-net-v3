using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAz2MigrateResponse : SdkResponse
    {

        /// <summary>
        /// 可用区具体信息。
        /// </summary>
        [JsonProperty("az_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<Az2Migrate> AzList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAz2MigrateResponse {\n");
            sb.Append("  azList: ").Append(AzList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAz2MigrateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAz2MigrateResponse input)
        {
            if (input == null) return false;
            if (this.AzList != input.AzList || (this.AzList != null && input.AzList != null && !this.AzList.SequenceEqual(input.AzList))) return false;

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
                if (this.AzList != null) hashCode = hashCode * 59 + this.AzList.GetHashCode();
                return hashCode;
            }
        }
    }
}
