using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListBusinessEnvResponse : SdkResponse
    {

        /// <summary>
        /// 环境列表。
        /// </summary>
        [JsonProperty("env_entry_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<EnvEntry> EnvEntryList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBusinessEnvResponse {\n");
            sb.Append("  envEntryList: ").Append(EnvEntryList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBusinessEnvResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBusinessEnvResponse input)
        {
            if (input == null) return false;
            if (this.EnvEntryList != input.EnvEntryList || (this.EnvEntryList != null && input.EnvEntryList != null && !this.EnvEntryList.SequenceEqual(input.EnvEntryList))) return false;

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
                if (this.EnvEntryList != null) hashCode = hashCode * 59 + this.EnvEntryList.GetHashCode();
                return hashCode;
            }
        }
    }
}
