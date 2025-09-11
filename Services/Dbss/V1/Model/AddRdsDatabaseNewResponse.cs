using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AddRdsDatabaseNewResponse : SdkResponse
    {

        /// <summary>
        /// 结果列表
        /// </summary>
        [JsonProperty("ret_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RdsDbResponseRetList> RetList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddRdsDatabaseNewResponse {\n");
            sb.Append("  retList: ").Append(RetList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddRdsDatabaseNewResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddRdsDatabaseNewResponse input)
        {
            if (input == null) return false;
            if (this.RetList != input.RetList || (this.RetList != null && input.RetList != null && !this.RetList.SequenceEqual(input.RetList))) return false;

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
                if (this.RetList != null) hashCode = hashCode * 59 + this.RetList.GetHashCode();
                return hashCode;
            }
        }
    }
}
