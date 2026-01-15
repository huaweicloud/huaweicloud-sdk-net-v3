using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DeleteColumnInfosResponse : SdkResponse
    {

        /// <summary>
        /// 删除结果
        /// </summary>
        [JsonProperty("delete_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteColumnInfosResponse {\n");
            sb.Append("  deleteResult: ").Append(DeleteResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteColumnInfosResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteColumnInfosResponse input)
        {
            if (input == null) return false;
            if (this.DeleteResult != input.DeleteResult || (this.DeleteResult != null && !this.DeleteResult.Equals(input.DeleteResult))) return false;

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
                if (this.DeleteResult != null) hashCode = hashCode * 59 + this.DeleteResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
