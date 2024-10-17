using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListGaussMySqlDatabaseCharsetsResponse : SdkResponse
    {

        /// <summary>
        /// 数据库字符集列表
        /// </summary>
        [JsonProperty("charsets", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Charsets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListGaussMySqlDatabaseCharsetsResponse {\n");
            sb.Append("  charsets: ").Append(Charsets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGaussMySqlDatabaseCharsetsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGaussMySqlDatabaseCharsetsResponse input)
        {
            if (input == null) return false;
            if (this.Charsets != input.Charsets || (this.Charsets != null && input.Charsets != null && !this.Charsets.SequenceEqual(input.Charsets))) return false;

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
                if (this.Charsets != null) hashCode = hashCode * 59 + this.Charsets.GetHashCode();
                return hashCode;
            }
        }
    }
}
