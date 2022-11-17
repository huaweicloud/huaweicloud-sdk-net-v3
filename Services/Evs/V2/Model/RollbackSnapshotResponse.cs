using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class RollbackSnapshotResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rollback", NullValueHandling = NullValueHandling.Ignore)]
        public RollbackInfo Rollback { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RollbackSnapshotResponse {\n");
            sb.Append("  rollback: ").Append(Rollback).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RollbackSnapshotResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RollbackSnapshotResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rollback == input.Rollback ||
                    (this.Rollback != null &&
                    this.Rollback.Equals(input.Rollback))
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
                if (this.Rollback != null)
                    hashCode = hashCode * 59 + this.Rollback.GetHashCode();
                return hashCode;
            }
        }
    }
}
