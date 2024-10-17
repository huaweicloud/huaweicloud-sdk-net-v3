using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 删除日志接入请求体
    /// </summary>
    public class DeleteAccessConfigRequestBody 
    {

        /// <summary>
        /// 日志接入ID列表
        /// </summary>
        [JsonProperty("access_config_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccessConfigIdList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAccessConfigRequestBody {\n");
            sb.Append("  accessConfigIdList: ").Append(AccessConfigIdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAccessConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAccessConfigRequestBody input)
        {
            if (input == null) return false;
            if (this.AccessConfigIdList != input.AccessConfigIdList || (this.AccessConfigIdList != null && input.AccessConfigIdList != null && !this.AccessConfigIdList.SequenceEqual(input.AccessConfigIdList))) return false;

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
                if (this.AccessConfigIdList != null) hashCode = hashCode * 59 + this.AccessConfigIdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
