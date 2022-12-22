using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListConfigurationDatastoresResponse : SdkResponse
    {

        /// <summary>
        /// 引擎信息。
        /// </summary>
        [JsonProperty("datastores", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataStoreList> Datastores { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConfigurationDatastoresResponse {\n");
            sb.Append("  datastores: ").Append(Datastores).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConfigurationDatastoresResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListConfigurationDatastoresResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Datastores == input.Datastores ||
                    this.Datastores != null &&
                    input.Datastores != null &&
                    this.Datastores.SequenceEqual(input.Datastores)
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
                if (this.Datastores != null)
                    hashCode = hashCode * 59 + this.Datastores.GetHashCode();
                return hashCode;
            }
        }
    }
}
