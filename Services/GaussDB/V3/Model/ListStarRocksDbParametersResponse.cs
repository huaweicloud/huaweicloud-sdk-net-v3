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
    public class ListStarRocksDbParametersResponse : SdkResponse
    {

        /// <summary>
        /// 库参数信息。
        /// </summary>
        [JsonProperty("db_parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<DbParameter> DbParameters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStarRocksDbParametersResponse {\n");
            sb.Append("  dbParameters: ").Append(DbParameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStarRocksDbParametersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStarRocksDbParametersResponse input)
        {
            if (input == null) return false;
            if (this.DbParameters != input.DbParameters || (this.DbParameters != null && input.DbParameters != null && !this.DbParameters.SequenceEqual(input.DbParameters))) return false;

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
                if (this.DbParameters != null) hashCode = hashCode * 59 + this.DbParameters.GetHashCode();
                return hashCode;
            }
        }
    }
}
