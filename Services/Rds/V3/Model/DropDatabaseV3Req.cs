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
    /// 
    /// </summary>
    public class DropDatabaseV3Req 
    {

        /// <summary>
        /// 是否强制删除数据库，默认是false。
        /// </summary>
        [JsonProperty("is_force_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsForceDelete { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DropDatabaseV3Req {\n");
            sb.Append("  isForceDelete: ").Append(IsForceDelete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DropDatabaseV3Req);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DropDatabaseV3Req input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsForceDelete == input.IsForceDelete ||
                    (this.IsForceDelete != null &&
                    this.IsForceDelete.Equals(input.IsForceDelete))
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
                if (this.IsForceDelete != null)
                    hashCode = hashCode * 59 + this.IsForceDelete.GetHashCode();
                return hashCode;
            }
        }
    }
}
