using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInternetResponse : SdkResponse
    {

        /// <summary>
        /// 上网信息
        /// </summary>
        [JsonProperty("internet_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<InternetInfo> InternetInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInternetResponse {\n");
            sb.Append("  internetInfos: ").Append(InternetInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInternetResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInternetResponse input)
        {
            if (input == null) return false;
            if (this.InternetInfos != input.InternetInfos || (this.InternetInfos != null && input.InternetInfos != null && !this.InternetInfos.SequenceEqual(input.InternetInfos))) return false;

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
                if (this.InternetInfos != null) hashCode = hashCode * 59 + this.InternetInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
