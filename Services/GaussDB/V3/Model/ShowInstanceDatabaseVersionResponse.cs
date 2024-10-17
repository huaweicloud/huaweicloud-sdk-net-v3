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
    public class ShowInstanceDatabaseVersionResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datastore", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceDatabaseVersionInfo Datastore { get; set; }

        /// <summary>
        /// 是否可升级。 - true：是。 - false：否。
        /// </summary>
        [JsonProperty("upgrade_flag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpgradeFlag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceDatabaseVersionResponse {\n");
            sb.Append("  datastore: ").Append(Datastore).Append("\n");
            sb.Append("  upgradeFlag: ").Append(UpgradeFlag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceDatabaseVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceDatabaseVersionResponse input)
        {
            if (input == null) return false;
            if (this.Datastore != input.Datastore || (this.Datastore != null && !this.Datastore.Equals(input.Datastore))) return false;
            if (this.UpgradeFlag != input.UpgradeFlag || (this.UpgradeFlag != null && !this.UpgradeFlag.Equals(input.UpgradeFlag))) return false;

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
                if (this.Datastore != null) hashCode = hashCode * 59 + this.Datastore.GetHashCode();
                if (this.UpgradeFlag != null) hashCode = hashCode * 59 + this.UpgradeFlag.GetHashCode();
                return hashCode;
            }
        }
    }
}
