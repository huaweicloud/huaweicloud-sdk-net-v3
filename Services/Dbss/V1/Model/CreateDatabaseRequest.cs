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
    /// 
    /// </summary>
    public class CreateDatabaseRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("database", NullValueHandling = NullValueHandling.Ignore)]
        public CreateDatabaseRequestDatabase Database { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDatabaseRequest {\n");
            sb.Append("  database: ").Append(Database).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDatabaseRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDatabaseRequest input)
        {
            if (input == null) return false;
            if (this.Database != input.Database || (this.Database != null && !this.Database.Equals(input.Database))) return false;

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
                if (this.Database != null) hashCode = hashCode * 59 + this.Database.GetHashCode();
                return hashCode;
            }
        }
    }
}
