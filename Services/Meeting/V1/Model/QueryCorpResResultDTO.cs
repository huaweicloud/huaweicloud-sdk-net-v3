using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 查询企业资源的返回结果。
    /// </summary>
    public class QueryCorpResResultDTO 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("corpVcRes", NullValueHandling = NullValueHandling.Ignore)]
        public QueryCorpVcResResultDTO CorpVcRes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryCorpResResultDTO {\n");
            sb.Append("  corpVcRes: ").Append(CorpVcRes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryCorpResResultDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryCorpResResultDTO input)
        {
            if (input == null) return false;
            if (this.CorpVcRes != input.CorpVcRes || (this.CorpVcRes != null && !this.CorpVcRes.Equals(input.CorpVcRes))) return false;

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
                if (this.CorpVcRes != null) hashCode = hashCode * 59 + this.CorpVcRes.GetHashCode();
                return hashCode;
            }
        }
    }
}
