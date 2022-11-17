using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class MigrateServerRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("migrate", NullValueHandling = NullValueHandling.Ignore)]
        public MigrateServerOption Migrate { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrateServerRequestBody {\n");
            sb.Append("  migrate: ").Append(Migrate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrateServerRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrateServerRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Migrate == input.Migrate ||
                    (this.Migrate != null &&
                    this.Migrate.Equals(input.Migrate))
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
                if (this.Migrate != null)
                    hashCode = hashCode * 59 + this.Migrate.GetHashCode();
                return hashCode;
            }
        }
    }
}
