using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eps.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListMigrationRecordResponse : SdkResponse
    {

        /// <summary>
        /// 资源迁移记录列表
        /// </summary>
        [JsonProperty("records", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceMigrateRecord> Records { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMigrationRecordResponse {\n");
            sb.Append("  records: ").Append(Records).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMigrationRecordResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMigrationRecordResponse input)
        {
            if (input == null) return false;
            if (this.Records != input.Records || (this.Records != null && input.Records != null && !this.Records.SequenceEqual(input.Records))) return false;

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
                if (this.Records != null) hashCode = hashCode * 59 + this.Records.GetHashCode();
                return hashCode;
            }
        }
    }
}
