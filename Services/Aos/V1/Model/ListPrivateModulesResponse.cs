using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListPrivateModulesResponse : SdkResponse
    {

        /// <summary>
        /// 私有模块的列表。默认以创建时间升序排序。
        /// </summary>
        [JsonProperty("modules", NullValueHandling = NullValueHandling.Ignore)]
        public List<PrivateModuleSummary> Modules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPrivateModulesResponse {\n");
            sb.Append("  modules: ").Append(Modules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPrivateModulesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPrivateModulesResponse input)
        {
            if (input == null) return false;
            if (this.Modules != input.Modules || (this.Modules != null && input.Modules != null && !this.Modules.SequenceEqual(input.Modules))) return false;

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
                if (this.Modules != null) hashCode = hashCode * 59 + this.Modules.GetHashCode();
                return hashCode;
            }
        }
    }
}
