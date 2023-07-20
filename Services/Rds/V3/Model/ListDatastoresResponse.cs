using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDatastoresResponse : SdkResponse
    {

        /// <summary>
        /// 数据库引擎信息。
        /// </summary>
        [JsonProperty("dataStores", NullValueHandling = NullValueHandling.Ignore)]
        public List<LDatastore> DataStores { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDatastoresResponse {\n");
            sb.Append("  dataStores: ").Append(DataStores).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDatastoresResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDatastoresResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataStores == input.DataStores ||
                    this.DataStores != null &&
                    input.DataStores != null &&
                    this.DataStores.SequenceEqual(input.DataStores)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DataStores != null)
                    hashCode = hashCode * 59 + this.DataStores.GetHashCode();
                return hashCode;
            }
        }
    }
}
